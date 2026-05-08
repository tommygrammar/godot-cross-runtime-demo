using System;

namespace GodotWeb
{
    public class RenderingDevice : GodotObject
    {
        public RenderingDevice(ulong id) : base(id) { }

        public ulong texture_create(ulong format, ulong view, object arg_data)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, format);
            Helpers.WriteUInt64(Commands.CMD_DATA + 16, view);
            Helpers.WriteArray(Commands.CMD_DATA + 24, arg_data);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_texture_create__24__24__28__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public ulong texture_create_shared(ulong view, ulong with_texture)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, view);
            Helpers.WriteRID(Commands.CMD_DATA + 16, with_texture);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_texture_create_shared__24__23__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public ulong texture_create_shared_from_slice(ulong view, ulong with_texture, long layer, long mipmap, long mipmaps, long slice_type)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, view);
            Helpers.WriteRID(Commands.CMD_DATA + 16, with_texture);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, layer);
            Helpers.WriteInt64(Commands.CMD_DATA + 32, mipmap);
            Helpers.WriteInt64(Commands.CMD_DATA + 40, mipmaps);
            Helpers.WriteInt64(Commands.CMD_DATA + 48, slice_type);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_texture_create_shared_from_slice__24__23__2__2__2__2__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public ulong texture_create_from_extension(long type, long format, long samples, long usage_flags, long image, long width, long height, long depth, long layers, long mipmaps)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, type);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, format);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, samples);
            Helpers.WriteInt64(Commands.CMD_DATA + 32, usage_flags);
            Helpers.WriteInt64(Commands.CMD_DATA + 40, image);
            Helpers.WriteInt64(Commands.CMD_DATA + 48, width);
            Helpers.WriteInt64(Commands.CMD_DATA + 56, height);
            Helpers.WriteInt64(Commands.CMD_DATA + 64, depth);
            Helpers.WriteInt64(Commands.CMD_DATA + 72, layers);
            Helpers.WriteInt64(Commands.CMD_DATA + 80, mipmaps);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_texture_create_from_extension__2__2__2__2__2__2__2__2__2__2__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public long texture_update(ulong texture, long layer, byte[] arg_data)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, texture);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, layer);
            Helpers.WritePackedByteArray(Commands.CMD_DATA + 24, arg_data);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_texture_update__23__2__29__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public byte[] texture_get_data(ulong texture, long layer)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, texture);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, layer);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_texture_get_data__23__2__r29);
            Helpers.WaitForCompletion();
            byte[] result = Helpers.ReadPackedByteArray(Commands.CMD_DATA);
            return result;
        }

        public long texture_get_data_async(ulong texture, long layer, object callback)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, texture);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, layer);
            Helpers.WriteCallable(Commands.CMD_DATA + 24, callback);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_texture_get_data_async__23__2__25__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool texture_is_format_supported_for_usage(long format, long usage_flags)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, format);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, usage_flags);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_texture_is_format_supported_for_usage__2__2__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool texture_is_shared(ulong texture)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, texture);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_texture_is_shared__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool texture_is_valid(ulong texture)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, texture);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_texture_is_valid__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void texture_set_discardable(ulong texture, bool discardable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, texture);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, discardable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_texture_set_discardable__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool texture_is_discardable(ulong texture)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, texture);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_texture_is_discardable__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public long texture_copy(ulong from_texture, ulong to_texture, Vector3 from_pos, Vector3 to_pos, Vector3 size, long src_mipmap, long dst_mipmap, long src_layer, long dst_layer)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, from_texture);
            Helpers.WriteRID(Commands.CMD_DATA + 16, to_texture);
            Helpers.WriteVector3(Commands.CMD_DATA + 24, from_pos);
            Helpers.WriteVector3(Commands.CMD_DATA + 36, to_pos);
            Helpers.WriteVector3(Commands.CMD_DATA + 48, size);
            Helpers.WriteInt64(Commands.CMD_DATA + 60, src_mipmap);
            Helpers.WriteInt64(Commands.CMD_DATA + 68, dst_mipmap);
            Helpers.WriteInt64(Commands.CMD_DATA + 76, src_layer);
            Helpers.WriteInt64(Commands.CMD_DATA + 84, dst_layer);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_texture_copy__23__23__9__9__9__2__2__2__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long texture_clear(ulong texture, Color color, long base_mipmap, long mipmap_count, long base_layer, long layer_count)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, texture);
            Helpers.WriteColor(Commands.CMD_DATA + 16, color);
            Helpers.WriteInt64(Commands.CMD_DATA + 32, base_mipmap);
            Helpers.WriteInt64(Commands.CMD_DATA + 40, mipmap_count);
            Helpers.WriteInt64(Commands.CMD_DATA + 48, base_layer);
            Helpers.WriteInt64(Commands.CMD_DATA + 56, layer_count);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_texture_clear__23__20__2__2__2__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long texture_resolve_multisample(ulong from_texture, ulong to_texture)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, from_texture);
            Helpers.WriteRID(Commands.CMD_DATA + 16, to_texture);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_texture_resolve_multisample__23__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong texture_get_format(ulong texture)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, texture);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_texture_get_format__23__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public long texture_get_native_handle(ulong texture)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, texture);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_texture_get_native_handle__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long framebuffer_format_create(object attachments, long view_count)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteArray(Commands.CMD_DATA + 8, attachments);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, view_count);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_framebuffer_format_create__28__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long framebuffer_format_create_multipass(object attachments, object passes, long view_count)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteArray(Commands.CMD_DATA + 8, attachments);
            Helpers.WriteArray(Commands.CMD_DATA + 8, passes);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, view_count);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_framebuffer_format_create_multipass__28__28__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long framebuffer_format_create_empty(long samples)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, samples);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_framebuffer_format_create_empty__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long framebuffer_format_get_texture_samples(long format, long render_pass)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, format);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, render_pass);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_framebuffer_format_get_texture_samples__2__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong framebuffer_create(object textures, long validate_with_format, long view_count)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteArray(Commands.CMD_DATA + 8, textures);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, validate_with_format);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, view_count);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_framebuffer_create__28__2__2__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public ulong framebuffer_create_multipass(object textures, object passes, long validate_with_format, long view_count)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteArray(Commands.CMD_DATA + 8, textures);
            Helpers.WriteArray(Commands.CMD_DATA + 8, passes);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, validate_with_format);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, view_count);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_framebuffer_create_multipass__28__28__2__2__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public ulong framebuffer_create_empty(Vector2i size, long samples, long validate_with_format)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2i(Commands.CMD_DATA + 8, size);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, samples);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, validate_with_format);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_framebuffer_create_empty__6__2__2__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public long framebuffer_get_format(ulong framebuffer)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, framebuffer);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_framebuffer_get_format__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool framebuffer_is_valid(ulong framebuffer)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, framebuffer);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_framebuffer_is_valid__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public ulong sampler_create(ulong state)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, state);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_sampler_create__24__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public bool sampler_is_format_supported_for_filter(long format, long sampler_filter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, format);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, sampler_filter);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_sampler_is_format_supported_for_filter__2__2__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public ulong vertex_buffer_create(long size_bytes, byte[] arg_data, long creation_bits)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, size_bytes);
            Helpers.WritePackedByteArray(Commands.CMD_DATA + 16, arg_data);
            Helpers.WriteInt64(Commands.CMD_DATA + 16 + 4 + arg_data.Length, creation_bits);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_vertex_buffer_create__2__29__2__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public long vertex_format_create(object vertex_descriptions)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteArray(Commands.CMD_DATA + 8, vertex_descriptions);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_vertex_format_create__28__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong vertex_array_create(long vertex_count, long vertex_format, object src_buffers, long[] offsets)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, vertex_count);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, vertex_format);
            Helpers.WriteArray(Commands.CMD_DATA + 24, src_buffers);
            Helpers.WritePackedInt64Array(Commands.CMD_DATA + 24, offsets);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_vertex_array_create__2__2__28__31__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public ulong index_buffer_create(long size_indices, long format, byte[] arg_data, bool use_restart_indices, long creation_bits)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, size_indices);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, format);
            Helpers.WritePackedByteArray(Commands.CMD_DATA + 24, arg_data);
            Helpers.WriteInt32(Commands.CMD_DATA + 24 + 4 + arg_data.Length, use_restart_indices ? 1 : 0);
            Helpers.WriteInt64(Commands.CMD_DATA + 24 + 4 + arg_data.Length + 4, creation_bits);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_index_buffer_create__2__2__29__1__2__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public ulong index_array_create(ulong index_buffer, long index_offset, long index_count)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, index_buffer);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, index_offset);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, index_count);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_index_array_create__23__2__2__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public ulong shader_compile_spirv_from_source(ulong shader_source, bool allow_cache)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, shader_source);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, allow_cache ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_shader_compile_spirv_from_source__24__1__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public byte[] shader_compile_binary_from_spirv(ulong spirv_data, string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, spirv_data);
            Helpers.WriteString(Commands.CMD_DATA + 16, name);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_shader_compile_binary_from_spirv__24__4__r29);
            Helpers.WaitForCompletion();
            byte[] result = Helpers.ReadPackedByteArray(Commands.CMD_DATA);
            return result;
        }

        public ulong shader_create_from_spirv(ulong spirv_data, string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, spirv_data);
            Helpers.WriteString(Commands.CMD_DATA + 16, name);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_shader_create_from_spirv__24__4__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public ulong shader_create_from_bytecode(byte[] binary_data, ulong placeholder_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WritePackedByteArray(Commands.CMD_DATA + 8, binary_data);
            Helpers.WriteRID(Commands.CMD_DATA + 8 + 4 + binary_data.Length, placeholder_rid);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_shader_create_from_bytecode__29__23__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public ulong shader_create_placeholder()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_shader_create_placeholder__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public long shader_get_vertex_input_attribute_mask(ulong shader)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shader);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_shader_get_vertex_input_attribute_mask__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong uniform_buffer_create(long size_bytes, byte[] arg_data, long creation_bits)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, size_bytes);
            Helpers.WritePackedByteArray(Commands.CMD_DATA + 16, arg_data);
            Helpers.WriteInt64(Commands.CMD_DATA + 16 + 4 + arg_data.Length, creation_bits);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_uniform_buffer_create__2__29__2__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public ulong storage_buffer_create(long size_bytes, byte[] arg_data, long usage, long creation_bits)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, size_bytes);
            Helpers.WritePackedByteArray(Commands.CMD_DATA + 16, arg_data);
            Helpers.WriteInt64(Commands.CMD_DATA + 16 + 4 + arg_data.Length, usage);
            Helpers.WriteInt64(Commands.CMD_DATA + 16 + 4 + arg_data.Length + 8, creation_bits);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_storage_buffer_create__2__29__2__2__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public ulong texture_buffer_create(long size_bytes, long format, byte[] arg_data)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, size_bytes);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, format);
            Helpers.WritePackedByteArray(Commands.CMD_DATA + 24, arg_data);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_texture_buffer_create__2__2__29__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public ulong uniform_set_create(object uniforms, ulong shader, long shader_set)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteArray(Commands.CMD_DATA + 8, uniforms);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shader);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, shader_set);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_uniform_set_create__28__23__2__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public bool uniform_set_is_valid(ulong uniform_set)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, uniform_set);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_uniform_set_is_valid__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public long buffer_copy(ulong src_buffer, ulong dst_buffer, long src_offset, long dst_offset, long size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, src_buffer);
            Helpers.WriteRID(Commands.CMD_DATA + 16, dst_buffer);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, src_offset);
            Helpers.WriteInt64(Commands.CMD_DATA + 32, dst_offset);
            Helpers.WriteInt64(Commands.CMD_DATA + 40, size);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_buffer_copy__23__23__2__2__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long buffer_update(ulong buffer, long offset, long size_bytes, byte[] arg_data)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, buffer);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, offset);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, size_bytes);
            Helpers.WritePackedByteArray(Commands.CMD_DATA + 32, arg_data);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_buffer_update__23__2__2__29__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long buffer_clear(ulong buffer, long offset, long size_bytes)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, buffer);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, offset);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, size_bytes);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_buffer_clear__23__2__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public byte[] buffer_get_data(ulong buffer, long offset_bytes, long size_bytes)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, buffer);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, offset_bytes);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, size_bytes);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_buffer_get_data__23__2__2__r29);
            Helpers.WaitForCompletion();
            byte[] result = Helpers.ReadPackedByteArray(Commands.CMD_DATA);
            return result;
        }

        public long buffer_get_data_async(ulong buffer, object callback, long offset_bytes, long size_bytes)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, buffer);
            Helpers.WriteCallable(Commands.CMD_DATA + 16, callback);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, offset_bytes);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, size_bytes);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_buffer_get_data_async__23__25__2__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long buffer_get_device_address(ulong buffer)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, buffer);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_buffer_get_device_address__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong render_pipeline_create(ulong shader, long framebuffer_format, long vertex_format, long primitive, ulong rasterization_state, ulong multisample_state, ulong stencil_state, ulong color_blend_state, long dynamic_state_flags, long for_render_pass, object specialization_constants)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shader);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, framebuffer_format);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, vertex_format);
            Helpers.WriteInt64(Commands.CMD_DATA + 32, primitive);
            Helpers.WriteUInt64(Commands.CMD_DATA + 40, rasterization_state);
            Helpers.WriteUInt64(Commands.CMD_DATA + 48, multisample_state);
            Helpers.WriteUInt64(Commands.CMD_DATA + 56, stencil_state);
            Helpers.WriteUInt64(Commands.CMD_DATA + 64, color_blend_state);
            Helpers.WriteInt64(Commands.CMD_DATA + 72, dynamic_state_flags);
            Helpers.WriteInt64(Commands.CMD_DATA + 80, for_render_pass);
            Helpers.WriteArray(Commands.CMD_DATA + 88, specialization_constants);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_render_pipeline_create__23__2__2__2__24__24__24__24__2__2__28__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public bool render_pipeline_is_valid(ulong render_pipeline)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, render_pipeline);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_render_pipeline_is_valid__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public ulong compute_pipeline_create(ulong shader, object specialization_constants)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shader);
            Helpers.WriteArray(Commands.CMD_DATA + 16, specialization_constants);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_compute_pipeline_create__23__28__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public bool compute_pipeline_is_valid(ulong compute_pipeline)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, compute_pipeline);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_compute_pipeline_is_valid__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public long screen_get_width(long screen)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, screen);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_screen_get_width__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long screen_get_height(long screen)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, screen);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_screen_get_height__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long screen_get_framebuffer_format(long screen)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, screen);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_screen_get_framebuffer_format__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long draw_list_begin_for_screen(long screen, Color clear_color)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, screen);
            Helpers.WriteColor(Commands.CMD_DATA + 16, clear_color);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_draw_list_begin_for_screen__2__20__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long draw_list_begin(ulong framebuffer, long draw_flags, Color[] clear_color_values, double clear_depth_value, long clear_stencil_value, Rect2 region, long breadcrumb)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, framebuffer);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, draw_flags);
            Helpers.WritePackedColorArray(Commands.CMD_DATA + 24, clear_color_values);
            Helpers.WriteDouble(Commands.CMD_DATA + 24, clear_depth_value);
            Helpers.WriteInt64(Commands.CMD_DATA + 32, clear_stencil_value);
            Helpers.WriteRect2(Commands.CMD_DATA + 40, region);
            Helpers.WriteInt64(Commands.CMD_DATA + 56, breadcrumb);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_draw_list_begin__23__2__37__3__2__7__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long[] draw_list_begin_split(ulong framebuffer, long splits, long initial_color_action, long final_color_action, long initial_depth_action, long final_depth_action, Color[] clear_color_values, double clear_depth, long clear_stencil, Rect2 region, object storage_textures)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, framebuffer);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, splits);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, initial_color_action);
            Helpers.WriteInt64(Commands.CMD_DATA + 32, final_color_action);
            Helpers.WriteInt64(Commands.CMD_DATA + 40, initial_depth_action);
            Helpers.WriteInt64(Commands.CMD_DATA + 48, final_depth_action);
            Helpers.WritePackedColorArray(Commands.CMD_DATA + 56, clear_color_values);
            Helpers.WriteDouble(Commands.CMD_DATA + 56, clear_depth);
            Helpers.WriteInt64(Commands.CMD_DATA + 64, clear_stencil);
            Helpers.WriteRect2(Commands.CMD_DATA + 72, region);
            Helpers.WriteArray(Commands.CMD_DATA + 88, storage_textures);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_draw_list_begin_split__23__2__2__2__2__2__37__3__2__7__28__r31);
            Helpers.WaitForCompletion();
            long[] result = Helpers.ReadPackedInt64Array(Commands.CMD_DATA);
            return result;
        }

        public void draw_list_set_blend_constants(long draw_list, Color color)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, draw_list);
            Helpers.WriteColor(Commands.CMD_DATA + 16, color);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_draw_list_set_blend_constants__2__20__r0);
            Helpers.WaitForCompletion();
        }

        public void draw_list_bind_render_pipeline(long draw_list, ulong render_pipeline)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, draw_list);
            Helpers.WriteRID(Commands.CMD_DATA + 16, render_pipeline);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_draw_list_bind_render_pipeline__2__23__r0);
            Helpers.WaitForCompletion();
        }

        public void draw_list_bind_uniform_set(long draw_list, ulong uniform_set, long set_index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, draw_list);
            Helpers.WriteRID(Commands.CMD_DATA + 16, uniform_set);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, set_index);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_draw_list_bind_uniform_set__2__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void draw_list_bind_vertex_array(long draw_list, ulong vertex_array)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, draw_list);
            Helpers.WriteRID(Commands.CMD_DATA + 16, vertex_array);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_draw_list_bind_vertex_array__2__23__r0);
            Helpers.WaitForCompletion();
        }

        public void draw_list_bind_vertex_buffers_format(long draw_list, long vertex_format, long vertex_count, object vertex_buffers, long[] offsets)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, draw_list);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, vertex_format);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, vertex_count);
            Helpers.WriteArray(Commands.CMD_DATA + 32, vertex_buffers);
            Helpers.WritePackedInt64Array(Commands.CMD_DATA + 32, offsets);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_draw_list_bind_vertex_buffers_format__2__2__2__28__31__r0);
            Helpers.WaitForCompletion();
        }

        public void draw_list_bind_index_array(long draw_list, ulong index_array)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, draw_list);
            Helpers.WriteRID(Commands.CMD_DATA + 16, index_array);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_draw_list_bind_index_array__2__23__r0);
            Helpers.WaitForCompletion();
        }

        public void draw_list_set_push_constant(long draw_list, byte[] buffer, long size_bytes)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, draw_list);
            Helpers.WritePackedByteArray(Commands.CMD_DATA + 16, buffer);
            Helpers.WriteInt64(Commands.CMD_DATA + 16 + 4 + buffer.Length, size_bytes);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_draw_list_set_push_constant__2__29__2__r0);
            Helpers.WaitForCompletion();
        }

        public void draw_list_draw(long draw_list, bool use_indices, long instances, long procedural_vertex_count)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, draw_list);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, use_indices ? 1 : 0);
            Helpers.WriteInt64(Commands.CMD_DATA + 20, instances);
            Helpers.WriteInt64(Commands.CMD_DATA + 28, procedural_vertex_count);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_draw_list_draw__2__1__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public void draw_list_draw_indirect(long draw_list, bool use_indices, ulong buffer, long offset, long draw_count, long stride)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, draw_list);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, use_indices ? 1 : 0);
            Helpers.WriteRID(Commands.CMD_DATA + 20, buffer);
            Helpers.WriteInt64(Commands.CMD_DATA + 28, offset);
            Helpers.WriteInt64(Commands.CMD_DATA + 36, draw_count);
            Helpers.WriteInt64(Commands.CMD_DATA + 44, stride);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_draw_list_draw_indirect__2__1__23__2__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public void draw_list_enable_scissor(long draw_list, Rect2 rect)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, draw_list);
            Helpers.WriteRect2(Commands.CMD_DATA + 16, rect);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_draw_list_enable_scissor__2__7__r0);
            Helpers.WaitForCompletion();
        }

        public void draw_list_disable_scissor(long draw_list)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, draw_list);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_draw_list_disable_scissor__2__r0);
            Helpers.WaitForCompletion();
        }

        public long draw_list_switch_to_next_pass()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_draw_list_switch_to_next_pass__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long[] draw_list_switch_to_next_pass_split(long splits)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, splits);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_draw_list_switch_to_next_pass_split__2__r31);
            Helpers.WaitForCompletion();
            long[] result = Helpers.ReadPackedInt64Array(Commands.CMD_DATA);
            return result;
        }

        public void draw_list_end()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_draw_list_end__r0);
            Helpers.WaitForCompletion();
        }

        public long compute_list_begin()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_compute_list_begin__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void compute_list_bind_compute_pipeline(long compute_list, ulong compute_pipeline)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, compute_list);
            Helpers.WriteRID(Commands.CMD_DATA + 16, compute_pipeline);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_compute_list_bind_compute_pipeline__2__23__r0);
            Helpers.WaitForCompletion();
        }

        public void compute_list_set_push_constant(long compute_list, byte[] buffer, long size_bytes)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, compute_list);
            Helpers.WritePackedByteArray(Commands.CMD_DATA + 16, buffer);
            Helpers.WriteInt64(Commands.CMD_DATA + 16 + 4 + buffer.Length, size_bytes);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_compute_list_set_push_constant__2__29__2__r0);
            Helpers.WaitForCompletion();
        }

        public void compute_list_bind_uniform_set(long compute_list, ulong uniform_set, long set_index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, compute_list);
            Helpers.WriteRID(Commands.CMD_DATA + 16, uniform_set);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, set_index);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_compute_list_bind_uniform_set__2__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void compute_list_dispatch(long compute_list, long x_groups, long y_groups, long z_groups)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, compute_list);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, x_groups);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, y_groups);
            Helpers.WriteInt64(Commands.CMD_DATA + 32, z_groups);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_compute_list_dispatch__2__2__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public void compute_list_dispatch_indirect(long compute_list, ulong buffer, long offset)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, compute_list);
            Helpers.WriteRID(Commands.CMD_DATA + 16, buffer);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, offset);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_compute_list_dispatch_indirect__2__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void compute_list_add_barrier(long compute_list)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, compute_list);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_compute_list_add_barrier__2__r0);
            Helpers.WaitForCompletion();
        }

        public void compute_list_end()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_compute_list_end__r0);
            Helpers.WaitForCompletion();
        }

        public void free_rid(ulong rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_free_rid__23__r0);
            Helpers.WaitForCompletion();
        }

        public void capture_timestamp(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_capture_timestamp__4__r0);
            Helpers.WaitForCompletion();
        }

        public long get_captured_timestamps_count()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_get_captured_timestamps_count__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long get_captured_timestamps_frame()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_get_captured_timestamps_frame__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long get_captured_timestamp_gpu_time(long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, index);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_get_captured_timestamp_gpu_time__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long get_captured_timestamp_cpu_time(long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, index);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_get_captured_timestamp_cpu_time__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public string get_captured_timestamp_name(long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, index);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_get_captured_timestamp_name__2__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public bool has_feature(long feature)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, feature);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_has_feature__2__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public long limit_get(long limit)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, limit);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_limit_get__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long get_frame_delay()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_get_frame_delay__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void submit()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_submit__r0);
            Helpers.WaitForCompletion();
        }

        public void sync()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_sync__r0);
            Helpers.WaitForCompletion();
        }

        public void barrier(long from, long to)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, from);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, to);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_barrier__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public void full_barrier()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_full_barrier__r0);
            Helpers.WaitForCompletion();
        }

        public ulong create_local_device()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_create_local_device__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_resource_name(ulong id, string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteString(Commands.CMD_DATA + 16, name);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_set_resource_name__23__4__r0);
            Helpers.WaitForCompletion();
        }

        public void draw_command_begin_label(string name, Color color)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, name);
            Helpers.WriteColor(Commands.CMD_DATA + 1036, color);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_draw_command_begin_label__4__20__r0);
            Helpers.WaitForCompletion();
        }

        public void draw_command_insert_label(string name, Color color)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, name);
            Helpers.WriteColor(Commands.CMD_DATA + 1036, color);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_draw_command_insert_label__4__20__r0);
            Helpers.WaitForCompletion();
        }

        public void draw_command_end_label()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_draw_command_end_label__r0);
            Helpers.WaitForCompletion();
        }

        public string get_device_vendor_name()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_get_device_vendor_name__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public string get_device_name()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_get_device_name__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public string get_device_pipeline_cache_uuid()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_get_device_pipeline_cache_uuid__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public long get_memory_usage(long type)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, type);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_get_memory_usage__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long get_driver_resource(long resource, ulong rid, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, resource);
            Helpers.WriteRID(Commands.CMD_DATA + 16, rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, index);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_get_driver_resource__2__23__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public string get_perf_report()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_get_perf_report__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public string get_driver_and_device_memory_report()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_get_driver_and_device_memory_report__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public string get_tracked_object_name(long type_index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, type_index);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_get_tracked_object_name__2__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public long get_tracked_object_type_count()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_get_tracked_object_type_count__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long get_driver_total_memory()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_get_driver_total_memory__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long get_driver_allocation_count()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_get_driver_allocation_count__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long get_driver_memory_by_object_type(long type)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, type);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_get_driver_memory_by_object_type__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long get_driver_allocs_by_object_type(long type)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, type);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_get_driver_allocs_by_object_type__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long get_device_total_memory()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_get_device_total_memory__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long get_device_allocation_count()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_get_device_allocation_count__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long get_device_memory_by_object_type(long type)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, type);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_get_device_memory_by_object_type__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long get_device_allocs_by_object_type(long type)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, type);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_get_device_allocs_by_object_type__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void free()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_free__r0);
            Helpers.WaitForCompletion();
        }

        public void _init()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingDevice__init__r0);
            Helpers.WaitForCompletion();
        }

        public string _to_string()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingDevice__to_string__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void _notification(long what)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, what);
            Helpers.SendCommand(Commands.CMD_RenderingDevice__notification__2__r0);
            Helpers.WaitForCompletion();
        }

        public bool _set(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_RenderingDevice__set__21__0__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _get(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_RenderingDevice__get__21__r0);
            Helpers.WaitForCompletion();
        }

        public object _get_property_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingDevice__get_property_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void _validate_property(object property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDictionary(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_RenderingDevice__validate_property__27__r0);
            Helpers.WaitForCompletion();
        }

        public bool _property_can_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_RenderingDevice__property_can_revert__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _property_get_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_RenderingDevice__property_get_revert__21__r0);
            Helpers.WaitForCompletion();
        }

        public bool _iter_init(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteArray(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_RenderingDevice__iter_init__28__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool _iter_next(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteArray(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_RenderingDevice__iter_next__28__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _iter_get(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVariant(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_RenderingDevice__iter_get__0__r0);
            Helpers.WaitForCompletion();
        }

        public string get_class()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_get_class__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public bool is_class(string class_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, class_);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_is_class__4__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_set__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_get__21__r0);
            Helpers.WaitForCompletion();
        }

        public void set_indexed(string property_path, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, property_path);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_set_indexed__22__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get_indexed(string property_path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, property_path);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_get_indexed__22__r0);
            Helpers.WaitForCompletion();
        }

        public object get_property_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_get_property_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_method_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_get_method_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public bool property_can_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_property_can_revert__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void property_get_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_property_get_revert__21__r0);
            Helpers.WaitForCompletion();
        }

        public void notification(long what, bool reversed)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, what);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, reversed ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_notification__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public string to_string()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_to_string__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public ulong get_instance_id()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_get_instance_id__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_script(object script)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVariant(Commands.CMD_DATA + 8, script);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_set_script__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get_script()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_get_script__r0);
            Helpers.WaitForCompletion();
        }

        public void set_meta(string name, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_set_meta__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void remove_meta(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_remove_meta__21__r0);
            Helpers.WaitForCompletion();
        }

        public void get_meta(string name, object default_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, default_);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_get_meta__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_meta(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_has_meta__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public object get_meta_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_get_meta_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void add_user_signal(string signal, object arguments)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, signal);
            Helpers.WriteArray(Commands.CMD_DATA + 1036, arguments);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_add_user_signal__4__28__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_user_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_has_user_signal__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void remove_user_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_remove_user_signal__21__r0);
            Helpers.WaitForCompletion();
        }

        public long emit_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_emit_signal__21__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void call(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_call__21__r0);
            Helpers.WaitForCompletion();
        }

        public void call_deferred(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_call_deferred__21__r0);
            Helpers.WaitForCompletion();
        }

        public void set_deferred(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_set_deferred__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void callv(string method, object arg_array)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.WriteArray(Commands.CMD_DATA + 1036, arg_array);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_callv__21__28__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_method(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_has_method__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public long get_method_argument_count(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_get_method_argument_count__21__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool has_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_has_signal__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public object get_signal_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_get_signal_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_signal_connection_list(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_get_signal_connection_list__21__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_incoming_connections()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_get_incoming_connections__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public long connect(string signal, object callable, long flags)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.WriteCallable(Commands.CMD_DATA + 1036, callable);
            Helpers.WriteInt64(Commands.CMD_DATA + 1036, flags);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_connect__21__25__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void disconnect(string signal, object callable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.WriteCallable(Commands.CMD_DATA + 1036, callable);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_disconnect__21__25__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_connected(string signal, object callable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.WriteCallable(Commands.CMD_DATA + 1036, callable);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_is_connected__21__25__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool has_connections(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_has_connections__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_block_signals(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_set_block_signals__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_blocking_signals()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_is_blocking_signals__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void notify_property_list_changed()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_notify_property_list_changed__r0);
            Helpers.WaitForCompletion();
        }

        public void set_message_translation(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_set_message_translation__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool can_translate_messages()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_can_translate_messages__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public string tr(string message, string context)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, message);
            Helpers.WriteStringName(Commands.CMD_DATA + 1036, context);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_tr__21__21__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public string tr_n(string message, string plural_message, long n, string context)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, message);
            Helpers.WriteStringName(Commands.CMD_DATA + 1036, plural_message);
            Helpers.WriteInt64(Commands.CMD_DATA + 2064, n);
            Helpers.WriteStringName(Commands.CMD_DATA + 2072, context);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_tr_n__21__21__2__21__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public string get_translation_domain()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_get_translation_domain__r21);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadStringName(Commands.CMD_DATA);
            return result;
        }

        public void set_translation_domain(string domain)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, domain);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_set_translation_domain__21__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_queued_for_deletion()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_is_queued_for_deletion__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void cancel_free()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingDevice_cancel_free__r0);
            Helpers.WaitForCompletion();
        }

    }
}
