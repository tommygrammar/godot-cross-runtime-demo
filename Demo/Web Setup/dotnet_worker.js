self.onmessage = async function (e) {
  if (!e || !e.data || e.data.type !== "init") return;

  const dotnetUrl = e.data.dotnetUrl;
  const heapBuffer = e.data.buffer;

  try {
    if (
      !(heapBuffer instanceof ArrayBuffer) &&
      !(heapBuffer instanceof SharedArrayBuffer)
    ) {
      throw new Error(
        "[Worker] buffer is not ArrayBuffer or SharedArrayBuffer",
      );
    }

    const heapU8 = new Uint8Array(heapBuffer);

    // Keep references on self so other modules can use them.
    self.__heapBuffer = heapBuffer;
    self.__heapU8 = heapU8;

    self.__heapBulkRead = function (srcOffset, length) {
      srcOffset |= 0;
      length |= 0;

      const maxLen = Math.min(length, heapU8.byteLength - srcOffset);
      if (maxLen <= 0) {
        return new Uint8Array(0);
      }

      return heapU8.slice(srcOffset, srcOffset + maxLen);
    };

    self.__heapBulkWrite = function (srcArray, destOffset, length) {
      destOffset |= 0;
      length |= 0;

      if (!srcArray || typeof srcArray.length !== "number") {
        throw new Error(
          "[Worker] bulkWrite expects a typed array or array-like source",
        );
      }

      const maxLen = Math.min(
        length,
        srcArray.length,
        heapU8.byteLength - destOffset,
      );
      if (maxLen <= 0) {
        return;
      }

      const slice = srcArray.subarray(0, maxLen);
      heapU8.set(slice, destOffset);
    };

    self.__atomicWriteInt32 = function (offset, value) {
      offset |= 0;
      value |= 0;

      if (!(self.__heapBuffer instanceof SharedArrayBuffer)) {
        throw new Error("[Worker] atomicWriteInt32 requires SharedArrayBuffer");
      }

      if ((offset & 3) !== 0) {
        throw new Error(
          "[Worker] atomicWriteInt32 offset must be 4-byte aligned",
        );
      }

      const view = new Int32Array(self.__heapBuffer, offset, 1);
      Atomics.store(view, 0, value);
    };

    self.__atomicReadInt32 = function (offset) {
      offset |= 0;

      if (!(self.__heapBuffer instanceof SharedArrayBuffer)) {
        throw new Error("[Worker] atomicReadInt32 requires SharedArrayBuffer");
      }

      if ((offset & 3) !== 0) {
        throw new Error(
          "[Worker] atomicReadInt32 offset must be 4-byte aligned",
        );
      }

      const view = new Int32Array(self.__heapBuffer, offset, 1);
      return Atomics.load(view, 0);
    };

    // Expose an interop object on self.
    self.interop = self.interop || {};
    self.interop.bulkRead = function (srcOffset, length) {
      return self.__heapBulkRead(srcOffset, length);
    };
    self.interop.bulkWrite = function (srcArray, destOffset, length) {
      return self.__heapBulkWrite(srcArray, destOffset, length);
    };
    self.interop.atomicWriteInt32 = function (offset, value) {
      return self.__atomicWriteInt32(offset, value);
    };

    console.log("[Worker] Heap attached:", heapU8.byteLength, "bytes");
    console.log(
      "[Worker] bulkRead/bulkWrite/atomicWriteInt32 installed on self",
    );
    console.log("[Worker] Loading dotnet...");

    const dotnetModule = await import(dotnetUrl);
    const dotnetRuntime = await dotnetModule.dotnet.create();

    console.log("[Worker] Dotnet runtime created");

    const exports = await dotnetRuntime.getAssemblyExports("WebGodotApi");
    console.log("[Worker] Assembly exports:", Object.keys(exports));

    await exports.Interop.InitInterop();
    console.log("[Worker] Interop initialized");

    self.postMessage({ type: "ready" });

    console.log("[Worker] Ready — starting game loop");
    //runs game
    await exports.Interop.RunGame();
  } catch (err) {
    console.error("[Worker] Init error:", err);
    self.postMessage({
      type: "error",
      message: err?.message ?? String(err),
    });
  }
};
