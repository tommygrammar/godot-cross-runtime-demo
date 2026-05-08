
## How to Setup the Cross-Runtime API
Follow these steps to build the Godot engine with the Cross-Runtime module and deploy the Web demo.
## 1. Clone and Prepare the Source
First, clone the Godot engine and the Cross-Runtime module into your workspace.
```bash
# Clone the Godot engine
git clone https://github.com/godotengine/godot# Clone the Cross-Runtime demo repository
git clone https://github.com/tommygrammar/godot-cross-runtime-demo
# Create the module directory within Godot
mkdir -p godot/modules/cross_runtime
# Copy the demo contents into the Godot module folder
cp -r godot-cross-runtime-demo/* godot/modules/cross_runtime/
```
## 2. Build Godot for Web
Ensure you have the Emscripten SDK (emsdk) installed and activated in your current terminal before running the build.

```bash
cd godot# Build the Godot Web export template
scons platform=web target=template_release
cd ..
```
## 3. Build the C# WASM Module
This step compiles the .cs logic (like the Dots.cs demo) into WebAssembly.

```bash
# Navigate to the module's C# source
cd godot/modules/cross_runtime/cs
# Build the project for WASM
dotnet build -c Release
# Prepare the web export directory
mkdir -p ../../../bin/.web_zip/cs
# Copy the generated .NET runtime framework to the web folder
cp -r bin/Release/net8.0/browser-wasm/AppBundle/_framework/ ../../../bin/.web_zip/cs/
cd ../../../
```

## 4. Deploy and Run
Finally, move the required web assets to the build folder and start a local server.
```bash
# Copy web assets to the bin folder
cp -r godot-cross-runtime-demo/for_web/* godot/bin/.web_zip/
# Start the server
cd godot/bin/.web_zip
python3 server.py
```

Access the demo: Open your browser and navigate to http://localhost:8000.
------------------------------


