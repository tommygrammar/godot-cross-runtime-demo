using System;

namespace GodotWeb
{
    public class RenderingServer : GodotObject
    {
        public RenderingServer(ulong id) : base(id) { }

        public ulong texture_2d_create(ulong image)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, image);
            Helpers.SendCommand(Commands.CMD_RenderingServer_texture_2d_create__24__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public ulong texture_2d_layered_create(object layers, long layered_type)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteArray(Commands.CMD_DATA + 8, layers);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, layered_type);
            Helpers.SendCommand(Commands.CMD_RenderingServer_texture_2d_layered_create__28__2__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public ulong texture_3d_create(long format, long width, long height, long depth, bool mipmaps, object arg_data)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, format);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, width);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, height);
            Helpers.WriteInt64(Commands.CMD_DATA + 32, depth);
            Helpers.WriteInt32(Commands.CMD_DATA + 40, mipmaps ? 1 : 0);
            Helpers.WriteArray(Commands.CMD_DATA + 44, arg_data);
            Helpers.SendCommand(Commands.CMD_RenderingServer_texture_3d_create__2__2__2__2__1__28__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public ulong texture_proxy_create(ulong base_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, base_);
            Helpers.SendCommand(Commands.CMD_RenderingServer_texture_proxy_create__23__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public ulong texture_create_from_native_handle(long type, long format, long native_handle, long width, long height, long depth, long layers, long layered_type)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, type);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, format);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, native_handle);
            Helpers.WriteInt64(Commands.CMD_DATA + 32, width);
            Helpers.WriteInt64(Commands.CMD_DATA + 40, height);
            Helpers.WriteInt64(Commands.CMD_DATA + 48, depth);
            Helpers.WriteInt64(Commands.CMD_DATA + 56, layers);
            Helpers.WriteInt64(Commands.CMD_DATA + 64, layered_type);
            Helpers.SendCommand(Commands.CMD_RenderingServer_texture_create_from_native_handle__2__2__2__2__2__2__2__2__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void texture_2d_update(ulong texture, ulong image, long layer)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, texture);
            Helpers.WriteUInt64(Commands.CMD_DATA + 16, image);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, layer);
            Helpers.SendCommand(Commands.CMD_RenderingServer_texture_2d_update__23__24__2__r0);
            Helpers.WaitForCompletion();
        }

        public void texture_3d_update(ulong texture, object arg_data)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, texture);
            Helpers.WriteArray(Commands.CMD_DATA + 16, arg_data);
            Helpers.SendCommand(Commands.CMD_RenderingServer_texture_3d_update__23__28__r0);
            Helpers.WaitForCompletion();
        }

        public void texture_proxy_update(ulong texture, ulong proxy_to)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, texture);
            Helpers.WriteRID(Commands.CMD_DATA + 16, proxy_to);
            Helpers.SendCommand(Commands.CMD_RenderingServer_texture_proxy_update__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public ulong texture_2d_placeholder_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_texture_2d_placeholder_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public ulong texture_2d_layered_placeholder_create(long layered_type)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, layered_type);
            Helpers.SendCommand(Commands.CMD_RenderingServer_texture_2d_layered_placeholder_create__2__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public ulong texture_3d_placeholder_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_texture_3d_placeholder_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public ulong texture_2d_get(ulong texture)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, texture);
            Helpers.SendCommand(Commands.CMD_RenderingServer_texture_2d_get__23__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong texture_2d_layer_get(ulong texture, long layer)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, texture);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, layer);
            Helpers.SendCommand(Commands.CMD_RenderingServer_texture_2d_layer_get__23__2__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public object texture_3d_get(ulong texture)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, texture);
            Helpers.SendCommand(Commands.CMD_RenderingServer_texture_3d_get__23__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void texture_replace(ulong texture, ulong by_texture)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, texture);
            Helpers.WriteRID(Commands.CMD_DATA + 16, by_texture);
            Helpers.SendCommand(Commands.CMD_RenderingServer_texture_replace__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public void texture_set_size_override(ulong texture, long width, long height)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, texture);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, width);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, height);
            Helpers.SendCommand(Commands.CMD_RenderingServer_texture_set_size_override__23__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public void texture_set_path(ulong texture, string path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, texture);
            Helpers.WriteString(Commands.CMD_DATA + 16, path);
            Helpers.SendCommand(Commands.CMD_RenderingServer_texture_set_path__23__4__r0);
            Helpers.WaitForCompletion();
        }

        public string texture_get_path(ulong texture)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, texture);
            Helpers.SendCommand(Commands.CMD_RenderingServer_texture_get_path__23__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public long texture_get_format(ulong texture)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, texture);
            Helpers.SendCommand(Commands.CMD_RenderingServer_texture_get_format__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void texture_set_force_redraw_if_visible(ulong texture, bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, texture);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_texture_set_force_redraw_if_visible__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public ulong texture_rd_create(ulong rd_texture, long layer_type)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rd_texture);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, layer_type);
            Helpers.SendCommand(Commands.CMD_RenderingServer_texture_rd_create__23__2__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public ulong texture_get_rd_texture(ulong texture, bool srgb)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, texture);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, srgb ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_texture_get_rd_texture__23__1__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public long texture_get_native_handle(ulong texture, bool srgb)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, texture);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, srgb ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_texture_get_native_handle__23__1__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong shader_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_shader_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void shader_set_code(ulong shader, string code)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shader);
            Helpers.WriteString(Commands.CMD_DATA + 16, code);
            Helpers.SendCommand(Commands.CMD_RenderingServer_shader_set_code__23__4__r0);
            Helpers.WaitForCompletion();
        }

        public void shader_set_path_hint(ulong shader, string path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shader);
            Helpers.WriteString(Commands.CMD_DATA + 16, path);
            Helpers.SendCommand(Commands.CMD_RenderingServer_shader_set_path_hint__23__4__r0);
            Helpers.WaitForCompletion();
        }

        public string shader_get_code(ulong shader)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shader);
            Helpers.SendCommand(Commands.CMD_RenderingServer_shader_get_code__23__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public object get_shader_parameter_list(ulong shader)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shader);
            Helpers.SendCommand(Commands.CMD_RenderingServer_get_shader_parameter_list__23__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void shader_get_parameter_default(ulong shader, string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shader);
            Helpers.WriteStringName(Commands.CMD_DATA + 16, name);
            Helpers.SendCommand(Commands.CMD_RenderingServer_shader_get_parameter_default__23__21__r0);
            Helpers.WaitForCompletion();
        }

        public void shader_set_default_texture_parameter(ulong shader, string name, ulong texture, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shader);
            Helpers.WriteStringName(Commands.CMD_DATA + 16, name);
            Helpers.WriteRID(Commands.CMD_DATA + 1044, texture);
            Helpers.WriteInt64(Commands.CMD_DATA + 1052, index);
            Helpers.SendCommand(Commands.CMD_RenderingServer_shader_set_default_texture_parameter__23__21__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public ulong shader_get_default_texture_parameter(ulong shader, string name, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shader);
            Helpers.WriteStringName(Commands.CMD_DATA + 16, name);
            Helpers.WriteInt64(Commands.CMD_DATA + 1044, index);
            Helpers.SendCommand(Commands.CMD_RenderingServer_shader_get_default_texture_parameter__23__21__2__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public ulong material_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_material_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void material_set_shader(ulong shader_material, ulong shader)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shader_material);
            Helpers.WriteRID(Commands.CMD_DATA + 16, shader);
            Helpers.SendCommand(Commands.CMD_RenderingServer_material_set_shader__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public void material_set_param(ulong material, string parameter, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, material);
            Helpers.WriteStringName(Commands.CMD_DATA + 16, parameter);
            Helpers.WriteVariant(Commands.CMD_DATA + 1044, value);
            Helpers.SendCommand(Commands.CMD_RenderingServer_material_set_param__23__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void material_get_param(ulong material, string parameter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, material);
            Helpers.WriteStringName(Commands.CMD_DATA + 16, parameter);
            Helpers.SendCommand(Commands.CMD_RenderingServer_material_get_param__23__21__r0);
            Helpers.WaitForCompletion();
        }

        public void material_set_render_priority(ulong material, long priority)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, material);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, priority);
            Helpers.SendCommand(Commands.CMD_RenderingServer_material_set_render_priority__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void material_set_next_pass(ulong material, ulong next_material)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, material);
            Helpers.WriteRID(Commands.CMD_DATA + 16, next_material);
            Helpers.SendCommand(Commands.CMD_RenderingServer_material_set_next_pass__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public void material_set_use_debanding(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_material_set_use_debanding__1__r0);
            Helpers.WaitForCompletion();
        }

        public ulong mesh_create_from_surfaces(object surfaces, long blend_shape_count)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteArray(Commands.CMD_DATA + 8, surfaces);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, blend_shape_count);
            Helpers.SendCommand(Commands.CMD_RenderingServer_mesh_create_from_surfaces__28__2__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public ulong mesh_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_mesh_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public long mesh_surface_get_format_offset(long format, long vertex_count, long array_index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, format);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, vertex_count);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, array_index);
            Helpers.SendCommand(Commands.CMD_RenderingServer_mesh_surface_get_format_offset__2__2__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long mesh_surface_get_format_vertex_stride(long format, long vertex_count)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, format);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, vertex_count);
            Helpers.SendCommand(Commands.CMD_RenderingServer_mesh_surface_get_format_vertex_stride__2__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long mesh_surface_get_format_normal_tangent_stride(long format, long vertex_count)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, format);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, vertex_count);
            Helpers.SendCommand(Commands.CMD_RenderingServer_mesh_surface_get_format_normal_tangent_stride__2__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long mesh_surface_get_format_attribute_stride(long format, long vertex_count)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, format);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, vertex_count);
            Helpers.SendCommand(Commands.CMD_RenderingServer_mesh_surface_get_format_attribute_stride__2__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long mesh_surface_get_format_skin_stride(long format, long vertex_count)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, format);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, vertex_count);
            Helpers.SendCommand(Commands.CMD_RenderingServer_mesh_surface_get_format_skin_stride__2__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long mesh_surface_get_format_index_stride(long format, long vertex_count)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, format);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, vertex_count);
            Helpers.SendCommand(Commands.CMD_RenderingServer_mesh_surface_get_format_index_stride__2__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void mesh_add_surface(ulong mesh, object surface)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, mesh);
            Helpers.WriteDictionary(Commands.CMD_DATA + 16, surface);
            Helpers.SendCommand(Commands.CMD_RenderingServer_mesh_add_surface__23__27__r0);
            Helpers.WaitForCompletion();
        }

        public void mesh_add_surface_from_arrays(ulong mesh, long primitive, object arrays, object blend_shapes, object lods, long compress_format)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, mesh);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, primitive);
            Helpers.WriteArray(Commands.CMD_DATA + 24, arrays);
            Helpers.WriteArray(Commands.CMD_DATA + 24, blend_shapes);
            Helpers.WriteDictionary(Commands.CMD_DATA + 24, lods);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, compress_format);
            Helpers.SendCommand(Commands.CMD_RenderingServer_mesh_add_surface_from_arrays__23__2__28__28__27__2__r0);
            Helpers.WaitForCompletion();
        }

        public long mesh_get_blend_shape_count(ulong mesh)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, mesh);
            Helpers.SendCommand(Commands.CMD_RenderingServer_mesh_get_blend_shape_count__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void mesh_set_blend_shape_mode(ulong mesh, long mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, mesh);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, mode);
            Helpers.SendCommand(Commands.CMD_RenderingServer_mesh_set_blend_shape_mode__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long mesh_get_blend_shape_mode(ulong mesh)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, mesh);
            Helpers.SendCommand(Commands.CMD_RenderingServer_mesh_get_blend_shape_mode__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void mesh_surface_set_material(ulong mesh, long surface, ulong material)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, mesh);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, surface);
            Helpers.WriteRID(Commands.CMD_DATA + 24, material);
            Helpers.SendCommand(Commands.CMD_RenderingServer_mesh_surface_set_material__23__2__23__r0);
            Helpers.WaitForCompletion();
        }

        public ulong mesh_surface_get_material(ulong mesh, long surface)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, mesh);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, surface);
            Helpers.SendCommand(Commands.CMD_RenderingServer_mesh_surface_get_material__23__2__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public object mesh_get_surface(ulong mesh, long surface)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, mesh);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, surface);
            Helpers.SendCommand(Commands.CMD_RenderingServer_mesh_get_surface__23__2__r27);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadDictionary(Commands.CMD_DATA);
            return result;
        }

        public object mesh_surface_get_arrays(ulong mesh, long surface)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, mesh);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, surface);
            Helpers.SendCommand(Commands.CMD_RenderingServer_mesh_surface_get_arrays__23__2__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object mesh_surface_get_blend_shape_arrays(ulong mesh, long surface)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, mesh);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, surface);
            Helpers.SendCommand(Commands.CMD_RenderingServer_mesh_surface_get_blend_shape_arrays__23__2__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public long mesh_get_surface_count(ulong mesh)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, mesh);
            Helpers.SendCommand(Commands.CMD_RenderingServer_mesh_get_surface_count__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void mesh_set_custom_aabb(ulong mesh, AABB aabb)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, mesh);
            Helpers.WriteAABB(Commands.CMD_DATA + 16, aabb);
            Helpers.SendCommand(Commands.CMD_RenderingServer_mesh_set_custom_aabb__23__16__r0);
            Helpers.WaitForCompletion();
        }

        public AABB mesh_get_custom_aabb(ulong mesh)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, mesh);
            Helpers.SendCommand(Commands.CMD_RenderingServer_mesh_get_custom_aabb__23__r16);
            Helpers.WaitForCompletion();
            AABB result = Helpers.ReadAABB(Commands.CMD_DATA);
            return result;
        }

        public void mesh_surface_remove(ulong mesh, long surface)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, mesh);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, surface);
            Helpers.SendCommand(Commands.CMD_RenderingServer_mesh_surface_remove__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void mesh_clear(ulong mesh)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, mesh);
            Helpers.SendCommand(Commands.CMD_RenderingServer_mesh_clear__23__r0);
            Helpers.WaitForCompletion();
        }

        public void mesh_surface_update_vertex_region(ulong mesh, long surface, long offset, byte[] arg_data)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, mesh);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, surface);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, offset);
            Helpers.WritePackedByteArray(Commands.CMD_DATA + 32, arg_data);
            Helpers.SendCommand(Commands.CMD_RenderingServer_mesh_surface_update_vertex_region__23__2__2__29__r0);
            Helpers.WaitForCompletion();
        }

        public void mesh_surface_update_attribute_region(ulong mesh, long surface, long offset, byte[] arg_data)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, mesh);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, surface);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, offset);
            Helpers.WritePackedByteArray(Commands.CMD_DATA + 32, arg_data);
            Helpers.SendCommand(Commands.CMD_RenderingServer_mesh_surface_update_attribute_region__23__2__2__29__r0);
            Helpers.WaitForCompletion();
        }

        public void mesh_surface_update_skin_region(ulong mesh, long surface, long offset, byte[] arg_data)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, mesh);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, surface);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, offset);
            Helpers.WritePackedByteArray(Commands.CMD_DATA + 32, arg_data);
            Helpers.SendCommand(Commands.CMD_RenderingServer_mesh_surface_update_skin_region__23__2__2__29__r0);
            Helpers.WaitForCompletion();
        }

        public void mesh_surface_update_index_region(ulong mesh, long surface, long offset, byte[] arg_data)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, mesh);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, surface);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, offset);
            Helpers.WritePackedByteArray(Commands.CMD_DATA + 32, arg_data);
            Helpers.SendCommand(Commands.CMD_RenderingServer_mesh_surface_update_index_region__23__2__2__29__r0);
            Helpers.WaitForCompletion();
        }

        public void mesh_set_shadow_mesh(ulong mesh, ulong shadow_mesh)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, mesh);
            Helpers.WriteRID(Commands.CMD_DATA + 16, shadow_mesh);
            Helpers.SendCommand(Commands.CMD_RenderingServer_mesh_set_shadow_mesh__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public ulong multimesh_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_multimesh_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void multimesh_allocate_data(ulong multimesh, long instances, long transform_format, bool color_format, bool custom_data_format, bool use_indirect)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, multimesh);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, instances);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, transform_format);
            Helpers.WriteInt32(Commands.CMD_DATA + 32, color_format ? 1 : 0);
            Helpers.WriteInt32(Commands.CMD_DATA + 36, custom_data_format ? 1 : 0);
            Helpers.WriteInt32(Commands.CMD_DATA + 40, use_indirect ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_multimesh_allocate_data__23__2__2__1__1__1__r0);
            Helpers.WaitForCompletion();
        }

        public long multimesh_get_instance_count(ulong multimesh)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, multimesh);
            Helpers.SendCommand(Commands.CMD_RenderingServer_multimesh_get_instance_count__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void multimesh_set_mesh(ulong multimesh, ulong mesh)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, multimesh);
            Helpers.WriteRID(Commands.CMD_DATA + 16, mesh);
            Helpers.SendCommand(Commands.CMD_RenderingServer_multimesh_set_mesh__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public void multimesh_instance_set_transform(ulong multimesh, long index, Transform3D transform)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, multimesh);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, index);
            Helpers.WriteTransform3D(Commands.CMD_DATA + 24, transform);
            Helpers.SendCommand(Commands.CMD_RenderingServer_multimesh_instance_set_transform__23__2__18__r0);
            Helpers.WaitForCompletion();
        }

        public void multimesh_instance_set_transform_2d(ulong multimesh, long index, Transform2D transform)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, multimesh);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, index);
            Helpers.WriteTransform2D(Commands.CMD_DATA + 24, transform);
            Helpers.SendCommand(Commands.CMD_RenderingServer_multimesh_instance_set_transform_2d__23__2__11__r0);
            Helpers.WaitForCompletion();
        }

        public void multimesh_instance_set_color(ulong multimesh, long index, Color color)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, multimesh);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, index);
            Helpers.WriteColor(Commands.CMD_DATA + 24, color);
            Helpers.SendCommand(Commands.CMD_RenderingServer_multimesh_instance_set_color__23__2__20__r0);
            Helpers.WaitForCompletion();
        }

        public void multimesh_instance_set_custom_data(ulong multimesh, long index, Color custom_data)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, multimesh);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, index);
            Helpers.WriteColor(Commands.CMD_DATA + 24, custom_data);
            Helpers.SendCommand(Commands.CMD_RenderingServer_multimesh_instance_set_custom_data__23__2__20__r0);
            Helpers.WaitForCompletion();
        }

        public ulong multimesh_get_mesh(ulong multimesh)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, multimesh);
            Helpers.SendCommand(Commands.CMD_RenderingServer_multimesh_get_mesh__23__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public AABB multimesh_get_aabb(ulong multimesh)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, multimesh);
            Helpers.SendCommand(Commands.CMD_RenderingServer_multimesh_get_aabb__23__r16);
            Helpers.WaitForCompletion();
            AABB result = Helpers.ReadAABB(Commands.CMD_DATA);
            return result;
        }

        public void multimesh_set_custom_aabb(ulong multimesh, AABB aabb)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, multimesh);
            Helpers.WriteAABB(Commands.CMD_DATA + 16, aabb);
            Helpers.SendCommand(Commands.CMD_RenderingServer_multimesh_set_custom_aabb__23__16__r0);
            Helpers.WaitForCompletion();
        }

        public AABB multimesh_get_custom_aabb(ulong multimesh)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, multimesh);
            Helpers.SendCommand(Commands.CMD_RenderingServer_multimesh_get_custom_aabb__23__r16);
            Helpers.WaitForCompletion();
            AABB result = Helpers.ReadAABB(Commands.CMD_DATA);
            return result;
        }

        public Transform3D multimesh_instance_get_transform(ulong multimesh, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, multimesh);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, index);
            Helpers.SendCommand(Commands.CMD_RenderingServer_multimesh_instance_get_transform__23__2__r18);
            Helpers.WaitForCompletion();
            Transform3D result = Helpers.ReadTransform3D(Commands.CMD_DATA);
            return result;
        }

        public Transform2D multimesh_instance_get_transform_2d(ulong multimesh, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, multimesh);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, index);
            Helpers.SendCommand(Commands.CMD_RenderingServer_multimesh_instance_get_transform_2d__23__2__r11);
            Helpers.WaitForCompletion();
            Transform2D result = Helpers.ReadTransform2D(Commands.CMD_DATA);
            return result;
        }

        public Color multimesh_instance_get_color(ulong multimesh, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, multimesh);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, index);
            Helpers.SendCommand(Commands.CMD_RenderingServer_multimesh_instance_get_color__23__2__r20);
            Helpers.WaitForCompletion();
            Color result = Helpers.ReadColor(Commands.CMD_DATA);
            return result;
        }

        public Color multimesh_instance_get_custom_data(ulong multimesh, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, multimesh);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, index);
            Helpers.SendCommand(Commands.CMD_RenderingServer_multimesh_instance_get_custom_data__23__2__r20);
            Helpers.WaitForCompletion();
            Color result = Helpers.ReadColor(Commands.CMD_DATA);
            return result;
        }

        public void multimesh_set_visible_instances(ulong multimesh, long visible)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, multimesh);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, visible);
            Helpers.SendCommand(Commands.CMD_RenderingServer_multimesh_set_visible_instances__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long multimesh_get_visible_instances(ulong multimesh)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, multimesh);
            Helpers.SendCommand(Commands.CMD_RenderingServer_multimesh_get_visible_instances__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void multimesh_set_buffer(ulong multimesh, float[] buffer)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, multimesh);
            Helpers.WritePackedFloat32Array(Commands.CMD_DATA + 16, buffer);
            Helpers.SendCommand(Commands.CMD_RenderingServer_multimesh_set_buffer__23__32__r0);
            Helpers.WaitForCompletion();
        }

        public ulong multimesh_get_command_buffer_rd_rid(ulong multimesh)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, multimesh);
            Helpers.SendCommand(Commands.CMD_RenderingServer_multimesh_get_command_buffer_rd_rid__23__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public ulong multimesh_get_buffer_rd_rid(ulong multimesh)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, multimesh);
            Helpers.SendCommand(Commands.CMD_RenderingServer_multimesh_get_buffer_rd_rid__23__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public float[] multimesh_get_buffer(ulong multimesh)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, multimesh);
            Helpers.SendCommand(Commands.CMD_RenderingServer_multimesh_get_buffer__23__r32);
            Helpers.WaitForCompletion();
            float[] result = Helpers.ReadPackedFloat32Array(Commands.CMD_DATA);
            return result;
        }

        public void multimesh_set_buffer_interpolated(ulong multimesh, float[] buffer, float[] buffer_previous)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, multimesh);
            Helpers.WritePackedFloat32Array(Commands.CMD_DATA + 16, buffer);
            Helpers.WritePackedFloat32Array(Commands.CMD_DATA + 16 + 4 + (buffer.Length * 4), buffer_previous);
            Helpers.SendCommand(Commands.CMD_RenderingServer_multimesh_set_buffer_interpolated__23__32__32__r0);
            Helpers.WaitForCompletion();
        }

        public void multimesh_set_physics_interpolated(ulong multimesh, bool interpolated)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, multimesh);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, interpolated ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_multimesh_set_physics_interpolated__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public void multimesh_set_physics_interpolation_quality(ulong multimesh, long quality)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, multimesh);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, quality);
            Helpers.SendCommand(Commands.CMD_RenderingServer_multimesh_set_physics_interpolation_quality__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void multimesh_instance_reset_physics_interpolation(ulong multimesh, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, multimesh);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, index);
            Helpers.SendCommand(Commands.CMD_RenderingServer_multimesh_instance_reset_physics_interpolation__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void multimesh_instances_reset_physics_interpolation(ulong multimesh)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, multimesh);
            Helpers.SendCommand(Commands.CMD_RenderingServer_multimesh_instances_reset_physics_interpolation__23__r0);
            Helpers.WaitForCompletion();
        }

        public ulong skeleton_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_skeleton_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void skeleton_allocate_data(ulong skeleton, long bones, bool is_2d_skeleton)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, skeleton);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, bones);
            Helpers.WriteInt32(Commands.CMD_DATA + 24, is_2d_skeleton ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_skeleton_allocate_data__23__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public long skeleton_get_bone_count(ulong skeleton)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, skeleton);
            Helpers.SendCommand(Commands.CMD_RenderingServer_skeleton_get_bone_count__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void skeleton_bone_set_transform(ulong skeleton, long bone, Transform3D transform)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, skeleton);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, bone);
            Helpers.WriteTransform3D(Commands.CMD_DATA + 24, transform);
            Helpers.SendCommand(Commands.CMD_RenderingServer_skeleton_bone_set_transform__23__2__18__r0);
            Helpers.WaitForCompletion();
        }

        public Transform3D skeleton_bone_get_transform(ulong skeleton, long bone)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, skeleton);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, bone);
            Helpers.SendCommand(Commands.CMD_RenderingServer_skeleton_bone_get_transform__23__2__r18);
            Helpers.WaitForCompletion();
            Transform3D result = Helpers.ReadTransform3D(Commands.CMD_DATA);
            return result;
        }

        public void skeleton_bone_set_transform_2d(ulong skeleton, long bone, Transform2D transform)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, skeleton);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, bone);
            Helpers.WriteTransform2D(Commands.CMD_DATA + 24, transform);
            Helpers.SendCommand(Commands.CMD_RenderingServer_skeleton_bone_set_transform_2d__23__2__11__r0);
            Helpers.WaitForCompletion();
        }

        public Transform2D skeleton_bone_get_transform_2d(ulong skeleton, long bone)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, skeleton);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, bone);
            Helpers.SendCommand(Commands.CMD_RenderingServer_skeleton_bone_get_transform_2d__23__2__r11);
            Helpers.WaitForCompletion();
            Transform2D result = Helpers.ReadTransform2D(Commands.CMD_DATA);
            return result;
        }

        public void skeleton_set_base_transform_2d(ulong skeleton, Transform2D base_transform)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, skeleton);
            Helpers.WriteTransform2D(Commands.CMD_DATA + 16, base_transform);
            Helpers.SendCommand(Commands.CMD_RenderingServer_skeleton_set_base_transform_2d__23__11__r0);
            Helpers.WaitForCompletion();
        }

        public ulong directional_light_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_directional_light_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public ulong omni_light_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_omni_light_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public ulong spot_light_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_spot_light_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void light_set_color(ulong light, Color color)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, light);
            Helpers.WriteColor(Commands.CMD_DATA + 16, color);
            Helpers.SendCommand(Commands.CMD_RenderingServer_light_set_color__23__20__r0);
            Helpers.WaitForCompletion();
        }

        public void light_set_param(ulong light, long param, double value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, light);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, param);
            Helpers.WriteDouble(Commands.CMD_DATA + 24, value);
            Helpers.SendCommand(Commands.CMD_RenderingServer_light_set_param__23__2__3__r0);
            Helpers.WaitForCompletion();
        }

        public void light_set_shadow(ulong light, bool enabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, light);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_light_set_shadow__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public void light_set_projector(ulong light, ulong texture)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, light);
            Helpers.WriteRID(Commands.CMD_DATA + 16, texture);
            Helpers.SendCommand(Commands.CMD_RenderingServer_light_set_projector__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public void light_set_negative(ulong light, bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, light);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_light_set_negative__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public void light_set_cull_mask(ulong light, long mask)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, light);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, mask);
            Helpers.SendCommand(Commands.CMD_RenderingServer_light_set_cull_mask__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void light_set_distance_fade(ulong decal, bool enabled, double begin, double shadow, double length)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, decal);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enabled ? 1 : 0);
            Helpers.WriteDouble(Commands.CMD_DATA + 20, begin);
            Helpers.WriteDouble(Commands.CMD_DATA + 28, shadow);
            Helpers.WriteDouble(Commands.CMD_DATA + 36, length);
            Helpers.SendCommand(Commands.CMD_RenderingServer_light_set_distance_fade__23__1__3__3__3__r0);
            Helpers.WaitForCompletion();
        }

        public void light_set_reverse_cull_face_mode(ulong light, bool enabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, light);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_light_set_reverse_cull_face_mode__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public void light_set_shadow_caster_mask(ulong light, long mask)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, light);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, mask);
            Helpers.SendCommand(Commands.CMD_RenderingServer_light_set_shadow_caster_mask__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void light_set_bake_mode(ulong light, long bake_mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, light);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, bake_mode);
            Helpers.SendCommand(Commands.CMD_RenderingServer_light_set_bake_mode__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void light_set_max_sdfgi_cascade(ulong light, long cascade)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, light);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, cascade);
            Helpers.SendCommand(Commands.CMD_RenderingServer_light_set_max_sdfgi_cascade__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void light_omni_set_shadow_mode(ulong light, long mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, light);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, mode);
            Helpers.SendCommand(Commands.CMD_RenderingServer_light_omni_set_shadow_mode__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void light_directional_set_shadow_mode(ulong light, long mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, light);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, mode);
            Helpers.SendCommand(Commands.CMD_RenderingServer_light_directional_set_shadow_mode__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void light_directional_set_blend_splits(ulong light, bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, light);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_light_directional_set_blend_splits__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public void light_directional_set_sky_mode(ulong light, long mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, light);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, mode);
            Helpers.SendCommand(Commands.CMD_RenderingServer_light_directional_set_sky_mode__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void light_projectors_set_filter(long filter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, filter);
            Helpers.SendCommand(Commands.CMD_RenderingServer_light_projectors_set_filter__2__r0);
            Helpers.WaitForCompletion();
        }

        public void lightmaps_set_bicubic_filter(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_lightmaps_set_bicubic_filter__1__r0);
            Helpers.WaitForCompletion();
        }

        public void positional_soft_shadow_filter_set_quality(long quality)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, quality);
            Helpers.SendCommand(Commands.CMD_RenderingServer_positional_soft_shadow_filter_set_quality__2__r0);
            Helpers.WaitForCompletion();
        }

        public void directional_soft_shadow_filter_set_quality(long quality)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, quality);
            Helpers.SendCommand(Commands.CMD_RenderingServer_directional_soft_shadow_filter_set_quality__2__r0);
            Helpers.WaitForCompletion();
        }

        public void directional_shadow_atlas_set_size(long size, bool is_16bits)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, size);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, is_16bits ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_directional_shadow_atlas_set_size__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public ulong reflection_probe_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_reflection_probe_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void reflection_probe_set_update_mode(ulong probe, long mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, probe);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, mode);
            Helpers.SendCommand(Commands.CMD_RenderingServer_reflection_probe_set_update_mode__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void reflection_probe_set_intensity(ulong probe, double intensity)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, probe);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, intensity);
            Helpers.SendCommand(Commands.CMD_RenderingServer_reflection_probe_set_intensity__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public void reflection_probe_set_blend_distance(ulong probe, double blend_distance)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, probe);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, blend_distance);
            Helpers.SendCommand(Commands.CMD_RenderingServer_reflection_probe_set_blend_distance__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public void reflection_probe_set_ambient_mode(ulong probe, long mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, probe);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, mode);
            Helpers.SendCommand(Commands.CMD_RenderingServer_reflection_probe_set_ambient_mode__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void reflection_probe_set_ambient_color(ulong probe, Color color)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, probe);
            Helpers.WriteColor(Commands.CMD_DATA + 16, color);
            Helpers.SendCommand(Commands.CMD_RenderingServer_reflection_probe_set_ambient_color__23__20__r0);
            Helpers.WaitForCompletion();
        }

        public void reflection_probe_set_ambient_energy(ulong probe, double energy)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, probe);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, energy);
            Helpers.SendCommand(Commands.CMD_RenderingServer_reflection_probe_set_ambient_energy__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public void reflection_probe_set_max_distance(ulong probe, double distance)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, probe);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, distance);
            Helpers.SendCommand(Commands.CMD_RenderingServer_reflection_probe_set_max_distance__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public void reflection_probe_set_size(ulong probe, Vector3 size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, probe);
            Helpers.WriteVector3(Commands.CMD_DATA + 16, size);
            Helpers.SendCommand(Commands.CMD_RenderingServer_reflection_probe_set_size__23__9__r0);
            Helpers.WaitForCompletion();
        }

        public void reflection_probe_set_origin_offset(ulong probe, Vector3 offset)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, probe);
            Helpers.WriteVector3(Commands.CMD_DATA + 16, offset);
            Helpers.SendCommand(Commands.CMD_RenderingServer_reflection_probe_set_origin_offset__23__9__r0);
            Helpers.WaitForCompletion();
        }

        public void reflection_probe_set_as_interior(ulong probe, bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, probe);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_reflection_probe_set_as_interior__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public void reflection_probe_set_enable_box_projection(ulong probe, bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, probe);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_reflection_probe_set_enable_box_projection__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public void reflection_probe_set_enable_shadows(ulong probe, bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, probe);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_reflection_probe_set_enable_shadows__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public void reflection_probe_set_cull_mask(ulong probe, long layers)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, probe);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, layers);
            Helpers.SendCommand(Commands.CMD_RenderingServer_reflection_probe_set_cull_mask__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void reflection_probe_set_reflection_mask(ulong probe, long layers)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, probe);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, layers);
            Helpers.SendCommand(Commands.CMD_RenderingServer_reflection_probe_set_reflection_mask__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void reflection_probe_set_resolution(ulong probe, long resolution)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, probe);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, resolution);
            Helpers.SendCommand(Commands.CMD_RenderingServer_reflection_probe_set_resolution__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void reflection_probe_set_mesh_lod_threshold(ulong probe, double pixels)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, probe);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, pixels);
            Helpers.SendCommand(Commands.CMD_RenderingServer_reflection_probe_set_mesh_lod_threshold__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public ulong decal_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_decal_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void decal_set_size(ulong decal, Vector3 size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, decal);
            Helpers.WriteVector3(Commands.CMD_DATA + 16, size);
            Helpers.SendCommand(Commands.CMD_RenderingServer_decal_set_size__23__9__r0);
            Helpers.WaitForCompletion();
        }

        public void decal_set_texture(ulong decal, long type, ulong texture)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, decal);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, type);
            Helpers.WriteRID(Commands.CMD_DATA + 24, texture);
            Helpers.SendCommand(Commands.CMD_RenderingServer_decal_set_texture__23__2__23__r0);
            Helpers.WaitForCompletion();
        }

        public void decal_set_emission_energy(ulong decal, double energy)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, decal);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, energy);
            Helpers.SendCommand(Commands.CMD_RenderingServer_decal_set_emission_energy__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public void decal_set_albedo_mix(ulong decal, double albedo_mix)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, decal);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, albedo_mix);
            Helpers.SendCommand(Commands.CMD_RenderingServer_decal_set_albedo_mix__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public void decal_set_modulate(ulong decal, Color color)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, decal);
            Helpers.WriteColor(Commands.CMD_DATA + 16, color);
            Helpers.SendCommand(Commands.CMD_RenderingServer_decal_set_modulate__23__20__r0);
            Helpers.WaitForCompletion();
        }

        public void decal_set_cull_mask(ulong decal, long mask)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, decal);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, mask);
            Helpers.SendCommand(Commands.CMD_RenderingServer_decal_set_cull_mask__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void decal_set_distance_fade(ulong decal, bool enabled, double begin, double length)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, decal);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enabled ? 1 : 0);
            Helpers.WriteDouble(Commands.CMD_DATA + 20, begin);
            Helpers.WriteDouble(Commands.CMD_DATA + 28, length);
            Helpers.SendCommand(Commands.CMD_RenderingServer_decal_set_distance_fade__23__1__3__3__r0);
            Helpers.WaitForCompletion();
        }

        public void decal_set_fade(ulong decal, double above, double below)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, decal);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, above);
            Helpers.WriteDouble(Commands.CMD_DATA + 24, below);
            Helpers.SendCommand(Commands.CMD_RenderingServer_decal_set_fade__23__3__3__r0);
            Helpers.WaitForCompletion();
        }

        public void decal_set_normal_fade(ulong decal, double fade)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, decal);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, fade);
            Helpers.SendCommand(Commands.CMD_RenderingServer_decal_set_normal_fade__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public void decals_set_filter(long filter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, filter);
            Helpers.SendCommand(Commands.CMD_RenderingServer_decals_set_filter__2__r0);
            Helpers.WaitForCompletion();
        }

        public void gi_set_use_half_resolution(bool half_resolution)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, half_resolution ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_gi_set_use_half_resolution__1__r0);
            Helpers.WaitForCompletion();
        }

        public ulong voxel_gi_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_voxel_gi_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void voxel_gi_allocate_data(ulong voxel_gi, Transform3D to_cell_xform, AABB aabb, Vector3i octree_size, byte[] octree_cells, byte[] data_cells, byte[] distance_field, int[] level_counts)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, voxel_gi);
            Helpers.WriteTransform3D(Commands.CMD_DATA + 16, to_cell_xform);
            Helpers.WriteAABB(Commands.CMD_DATA + 64, aabb);
            Helpers.WriteVector3i(Commands.CMD_DATA + 88, octree_size);
            Helpers.WritePackedByteArray(Commands.CMD_DATA + 100, octree_cells);
            Helpers.WritePackedByteArray(Commands.CMD_DATA + 100 + 4 + octree_cells.Length, data_cells);
            Helpers.WritePackedByteArray(Commands.CMD_DATA + 100 + 4 + octree_cells.Length + 4 + data_cells.Length, distance_field);
            Helpers.WritePackedInt32Array(Commands.CMD_DATA + 100 + 4 + octree_cells.Length + 4 + data_cells.Length + 4 + distance_field.Length, level_counts);
            Helpers.SendCommand(Commands.CMD_RenderingServer_voxel_gi_allocate_data__23__18__16__10__29__29__29__30__r0);
            Helpers.WaitForCompletion();
        }

        public Vector3i voxel_gi_get_octree_size(ulong voxel_gi)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, voxel_gi);
            Helpers.SendCommand(Commands.CMD_RenderingServer_voxel_gi_get_octree_size__23__r10);
            Helpers.WaitForCompletion();
            Vector3i result = Helpers.ReadVector3i(Commands.CMD_DATA);
            return result;
        }

        public byte[] voxel_gi_get_octree_cells(ulong voxel_gi)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, voxel_gi);
            Helpers.SendCommand(Commands.CMD_RenderingServer_voxel_gi_get_octree_cells__23__r29);
            Helpers.WaitForCompletion();
            byte[] result = Helpers.ReadPackedByteArray(Commands.CMD_DATA);
            return result;
        }

        public byte[] voxel_gi_get_data_cells(ulong voxel_gi)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, voxel_gi);
            Helpers.SendCommand(Commands.CMD_RenderingServer_voxel_gi_get_data_cells__23__r29);
            Helpers.WaitForCompletion();
            byte[] result = Helpers.ReadPackedByteArray(Commands.CMD_DATA);
            return result;
        }

        public byte[] voxel_gi_get_distance_field(ulong voxel_gi)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, voxel_gi);
            Helpers.SendCommand(Commands.CMD_RenderingServer_voxel_gi_get_distance_field__23__r29);
            Helpers.WaitForCompletion();
            byte[] result = Helpers.ReadPackedByteArray(Commands.CMD_DATA);
            return result;
        }

        public int[] voxel_gi_get_level_counts(ulong voxel_gi)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, voxel_gi);
            Helpers.SendCommand(Commands.CMD_RenderingServer_voxel_gi_get_level_counts__23__r30);
            Helpers.WaitForCompletion();
            int[] result = Helpers.ReadPackedInt32Array(Commands.CMD_DATA);
            return result;
        }

        public Transform3D voxel_gi_get_to_cell_xform(ulong voxel_gi)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, voxel_gi);
            Helpers.SendCommand(Commands.CMD_RenderingServer_voxel_gi_get_to_cell_xform__23__r18);
            Helpers.WaitForCompletion();
            Transform3D result = Helpers.ReadTransform3D(Commands.CMD_DATA);
            return result;
        }

        public void voxel_gi_set_dynamic_range(ulong voxel_gi, double range)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, voxel_gi);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, range);
            Helpers.SendCommand(Commands.CMD_RenderingServer_voxel_gi_set_dynamic_range__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public void voxel_gi_set_propagation(ulong voxel_gi, double amount)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, voxel_gi);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, amount);
            Helpers.SendCommand(Commands.CMD_RenderingServer_voxel_gi_set_propagation__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public void voxel_gi_set_energy(ulong voxel_gi, double energy)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, voxel_gi);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, energy);
            Helpers.SendCommand(Commands.CMD_RenderingServer_voxel_gi_set_energy__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public void voxel_gi_set_baked_exposure_normalization(ulong voxel_gi, double baked_exposure)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, voxel_gi);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, baked_exposure);
            Helpers.SendCommand(Commands.CMD_RenderingServer_voxel_gi_set_baked_exposure_normalization__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public void voxel_gi_set_bias(ulong voxel_gi, double bias)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, voxel_gi);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, bias);
            Helpers.SendCommand(Commands.CMD_RenderingServer_voxel_gi_set_bias__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public void voxel_gi_set_normal_bias(ulong voxel_gi, double bias)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, voxel_gi);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, bias);
            Helpers.SendCommand(Commands.CMD_RenderingServer_voxel_gi_set_normal_bias__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public void voxel_gi_set_interior(ulong voxel_gi, bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, voxel_gi);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_voxel_gi_set_interior__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public void voxel_gi_set_use_two_bounces(ulong voxel_gi, bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, voxel_gi);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_voxel_gi_set_use_two_bounces__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public void voxel_gi_set_quality(long quality)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, quality);
            Helpers.SendCommand(Commands.CMD_RenderingServer_voxel_gi_set_quality__2__r0);
            Helpers.WaitForCompletion();
        }

        public ulong lightmap_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_lightmap_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void lightmap_set_textures(ulong lightmap, ulong light, bool uses_sh)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, lightmap);
            Helpers.WriteRID(Commands.CMD_DATA + 16, light);
            Helpers.WriteInt32(Commands.CMD_DATA + 24, uses_sh ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_lightmap_set_textures__23__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public void lightmap_set_probe_bounds(ulong lightmap, AABB bounds)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, lightmap);
            Helpers.WriteAABB(Commands.CMD_DATA + 16, bounds);
            Helpers.SendCommand(Commands.CMD_RenderingServer_lightmap_set_probe_bounds__23__16__r0);
            Helpers.WaitForCompletion();
        }

        public void lightmap_set_probe_interior(ulong lightmap, bool interior)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, lightmap);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, interior ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_lightmap_set_probe_interior__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public void lightmap_set_probe_capture_data(ulong lightmap, Vector3[] points, Color[] point_sh, int[] tetrahedra, int[] bsp_tree)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, lightmap);
            Helpers.WritePackedVector3Array(Commands.CMD_DATA + 16, points);
            Helpers.WritePackedColorArray(Commands.CMD_DATA + 16, point_sh);
            Helpers.WritePackedInt32Array(Commands.CMD_DATA + 16, tetrahedra);
            Helpers.WritePackedInt32Array(Commands.CMD_DATA + 16, bsp_tree);
            Helpers.SendCommand(Commands.CMD_RenderingServer_lightmap_set_probe_capture_data__23__36__37__30__30__r0);
            Helpers.WaitForCompletion();
        }

        public Vector3[] lightmap_get_probe_capture_points(ulong lightmap)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, lightmap);
            Helpers.SendCommand(Commands.CMD_RenderingServer_lightmap_get_probe_capture_points__23__r36);
            Helpers.WaitForCompletion();
            Vector3[] result = Helpers.ReadPackedVector3Array(Commands.CMD_DATA);
            return result;
        }

        public Color[] lightmap_get_probe_capture_sh(ulong lightmap)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, lightmap);
            Helpers.SendCommand(Commands.CMD_RenderingServer_lightmap_get_probe_capture_sh__23__r37);
            Helpers.WaitForCompletion();
            Color[] result = Helpers.ReadPackedColorArray(Commands.CMD_DATA);
            return result;
        }

        public int[] lightmap_get_probe_capture_tetrahedra(ulong lightmap)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, lightmap);
            Helpers.SendCommand(Commands.CMD_RenderingServer_lightmap_get_probe_capture_tetrahedra__23__r30);
            Helpers.WaitForCompletion();
            int[] result = Helpers.ReadPackedInt32Array(Commands.CMD_DATA);
            return result;
        }

        public int[] lightmap_get_probe_capture_bsp_tree(ulong lightmap)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, lightmap);
            Helpers.SendCommand(Commands.CMD_RenderingServer_lightmap_get_probe_capture_bsp_tree__23__r30);
            Helpers.WaitForCompletion();
            int[] result = Helpers.ReadPackedInt32Array(Commands.CMD_DATA);
            return result;
        }

        public void lightmap_set_baked_exposure_normalization(ulong lightmap, double baked_exposure)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, lightmap);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, baked_exposure);
            Helpers.SendCommand(Commands.CMD_RenderingServer_lightmap_set_baked_exposure_normalization__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public void lightmap_set_probe_capture_update_speed(double speed)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDouble(Commands.CMD_DATA + 8, speed);
            Helpers.SendCommand(Commands.CMD_RenderingServer_lightmap_set_probe_capture_update_speed__3__r0);
            Helpers.WaitForCompletion();
        }

        public ulong particles_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_particles_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void particles_set_mode(ulong particles, long mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, particles);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, mode);
            Helpers.SendCommand(Commands.CMD_RenderingServer_particles_set_mode__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void particles_set_emitting(ulong particles, bool emitting)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, particles);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, emitting ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_particles_set_emitting__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool particles_get_emitting(ulong particles)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, particles);
            Helpers.SendCommand(Commands.CMD_RenderingServer_particles_get_emitting__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void particles_set_amount(ulong particles, long amount)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, particles);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, amount);
            Helpers.SendCommand(Commands.CMD_RenderingServer_particles_set_amount__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void particles_set_amount_ratio(ulong particles, double ratio)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, particles);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, ratio);
            Helpers.SendCommand(Commands.CMD_RenderingServer_particles_set_amount_ratio__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public void particles_set_lifetime(ulong particles, double lifetime)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, particles);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, lifetime);
            Helpers.SendCommand(Commands.CMD_RenderingServer_particles_set_lifetime__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public void particles_set_one_shot(ulong particles, bool one_shot)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, particles);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, one_shot ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_particles_set_one_shot__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public void particles_set_pre_process_time(ulong particles, double time)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, particles);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, time);
            Helpers.SendCommand(Commands.CMD_RenderingServer_particles_set_pre_process_time__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public void particles_request_process_time(ulong particles, double time)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, particles);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, time);
            Helpers.SendCommand(Commands.CMD_RenderingServer_particles_request_process_time__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public void particles_set_explosiveness_ratio(ulong particles, double ratio)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, particles);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, ratio);
            Helpers.SendCommand(Commands.CMD_RenderingServer_particles_set_explosiveness_ratio__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public void particles_set_randomness_ratio(ulong particles, double ratio)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, particles);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, ratio);
            Helpers.SendCommand(Commands.CMD_RenderingServer_particles_set_randomness_ratio__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public void particles_set_interp_to_end(ulong particles, double factor)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, particles);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, factor);
            Helpers.SendCommand(Commands.CMD_RenderingServer_particles_set_interp_to_end__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public void particles_set_emitter_velocity(ulong particles, Vector3 velocity)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, particles);
            Helpers.WriteVector3(Commands.CMD_DATA + 16, velocity);
            Helpers.SendCommand(Commands.CMD_RenderingServer_particles_set_emitter_velocity__23__9__r0);
            Helpers.WaitForCompletion();
        }

        public void particles_set_custom_aabb(ulong particles, AABB aabb)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, particles);
            Helpers.WriteAABB(Commands.CMD_DATA + 16, aabb);
            Helpers.SendCommand(Commands.CMD_RenderingServer_particles_set_custom_aabb__23__16__r0);
            Helpers.WaitForCompletion();
        }

        public void particles_set_speed_scale(ulong particles, double scale)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, particles);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, scale);
            Helpers.SendCommand(Commands.CMD_RenderingServer_particles_set_speed_scale__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public void particles_set_use_local_coordinates(ulong particles, bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, particles);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_particles_set_use_local_coordinates__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public void particles_set_process_material(ulong particles, ulong material)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, particles);
            Helpers.WriteRID(Commands.CMD_DATA + 16, material);
            Helpers.SendCommand(Commands.CMD_RenderingServer_particles_set_process_material__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public void particles_set_fixed_fps(ulong particles, long fps)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, particles);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, fps);
            Helpers.SendCommand(Commands.CMD_RenderingServer_particles_set_fixed_fps__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void particles_set_interpolate(ulong particles, bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, particles);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_particles_set_interpolate__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public void particles_set_fractional_delta(ulong particles, bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, particles);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_particles_set_fractional_delta__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public void particles_set_collision_base_size(ulong particles, double size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, particles);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, size);
            Helpers.SendCommand(Commands.CMD_RenderingServer_particles_set_collision_base_size__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public void particles_set_transform_align(ulong particles, long align)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, particles);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, align);
            Helpers.SendCommand(Commands.CMD_RenderingServer_particles_set_transform_align__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void particles_set_trails(ulong particles, bool enable, double length_sec)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, particles);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enable ? 1 : 0);
            Helpers.WriteDouble(Commands.CMD_DATA + 20, length_sec);
            Helpers.SendCommand(Commands.CMD_RenderingServer_particles_set_trails__23__1__3__r0);
            Helpers.WaitForCompletion();
        }

        public void particles_set_trail_bind_poses(ulong particles, object bind_poses)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, particles);
            Helpers.WriteArray(Commands.CMD_DATA + 16, bind_poses);
            Helpers.SendCommand(Commands.CMD_RenderingServer_particles_set_trail_bind_poses__23__28__r0);
            Helpers.WaitForCompletion();
        }

        public bool particles_is_inactive(ulong particles)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, particles);
            Helpers.SendCommand(Commands.CMD_RenderingServer_particles_is_inactive__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void particles_request_process(ulong particles)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, particles);
            Helpers.SendCommand(Commands.CMD_RenderingServer_particles_request_process__23__r0);
            Helpers.WaitForCompletion();
        }

        public void particles_restart(ulong particles)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, particles);
            Helpers.SendCommand(Commands.CMD_RenderingServer_particles_restart__23__r0);
            Helpers.WaitForCompletion();
        }

        public void particles_set_subemitter(ulong particles, ulong subemitter_particles)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, particles);
            Helpers.WriteRID(Commands.CMD_DATA + 16, subemitter_particles);
            Helpers.SendCommand(Commands.CMD_RenderingServer_particles_set_subemitter__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public void particles_emit(ulong particles, Transform3D transform, Vector3 velocity, Color color, Color custom, long emit_flags)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, particles);
            Helpers.WriteTransform3D(Commands.CMD_DATA + 16, transform);
            Helpers.WriteVector3(Commands.CMD_DATA + 64, velocity);
            Helpers.WriteColor(Commands.CMD_DATA + 76, color);
            Helpers.WriteColor(Commands.CMD_DATA + 92, custom);
            Helpers.WriteInt64(Commands.CMD_DATA + 108, emit_flags);
            Helpers.SendCommand(Commands.CMD_RenderingServer_particles_emit__23__18__9__20__20__2__r0);
            Helpers.WaitForCompletion();
        }

        public void particles_set_draw_order(ulong particles, long order)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, particles);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, order);
            Helpers.SendCommand(Commands.CMD_RenderingServer_particles_set_draw_order__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void particles_set_draw_passes(ulong particles, long count)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, particles);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, count);
            Helpers.SendCommand(Commands.CMD_RenderingServer_particles_set_draw_passes__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void particles_set_draw_pass_mesh(ulong particles, long pass, ulong mesh)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, particles);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, pass);
            Helpers.WriteRID(Commands.CMD_DATA + 24, mesh);
            Helpers.SendCommand(Commands.CMD_RenderingServer_particles_set_draw_pass_mesh__23__2__23__r0);
            Helpers.WaitForCompletion();
        }

        public AABB particles_get_current_aabb(ulong particles)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, particles);
            Helpers.SendCommand(Commands.CMD_RenderingServer_particles_get_current_aabb__23__r16);
            Helpers.WaitForCompletion();
            AABB result = Helpers.ReadAABB(Commands.CMD_DATA);
            return result;
        }

        public void particles_set_emission_transform(ulong particles, Transform3D transform)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, particles);
            Helpers.WriteTransform3D(Commands.CMD_DATA + 16, transform);
            Helpers.SendCommand(Commands.CMD_RenderingServer_particles_set_emission_transform__23__18__r0);
            Helpers.WaitForCompletion();
        }

        public ulong particles_collision_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_particles_collision_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void particles_collision_set_collision_type(ulong particles_collision, long type)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, particles_collision);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, type);
            Helpers.SendCommand(Commands.CMD_RenderingServer_particles_collision_set_collision_type__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void particles_collision_set_cull_mask(ulong particles_collision, long mask)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, particles_collision);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, mask);
            Helpers.SendCommand(Commands.CMD_RenderingServer_particles_collision_set_cull_mask__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void particles_collision_set_sphere_radius(ulong particles_collision, double radius)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, particles_collision);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, radius);
            Helpers.SendCommand(Commands.CMD_RenderingServer_particles_collision_set_sphere_radius__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public void particles_collision_set_box_extents(ulong particles_collision, Vector3 extents)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, particles_collision);
            Helpers.WriteVector3(Commands.CMD_DATA + 16, extents);
            Helpers.SendCommand(Commands.CMD_RenderingServer_particles_collision_set_box_extents__23__9__r0);
            Helpers.WaitForCompletion();
        }

        public void particles_collision_set_attractor_strength(ulong particles_collision, double strength)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, particles_collision);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, strength);
            Helpers.SendCommand(Commands.CMD_RenderingServer_particles_collision_set_attractor_strength__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public void particles_collision_set_attractor_directionality(ulong particles_collision, double amount)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, particles_collision);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, amount);
            Helpers.SendCommand(Commands.CMD_RenderingServer_particles_collision_set_attractor_directionality__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public void particles_collision_set_attractor_attenuation(ulong particles_collision, double curve)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, particles_collision);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, curve);
            Helpers.SendCommand(Commands.CMD_RenderingServer_particles_collision_set_attractor_attenuation__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public void particles_collision_set_field_texture(ulong particles_collision, ulong texture)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, particles_collision);
            Helpers.WriteRID(Commands.CMD_DATA + 16, texture);
            Helpers.SendCommand(Commands.CMD_RenderingServer_particles_collision_set_field_texture__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public void particles_collision_height_field_update(ulong particles_collision)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, particles_collision);
            Helpers.SendCommand(Commands.CMD_RenderingServer_particles_collision_height_field_update__23__r0);
            Helpers.WaitForCompletion();
        }

        public void particles_collision_set_height_field_resolution(ulong particles_collision, long resolution)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, particles_collision);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, resolution);
            Helpers.SendCommand(Commands.CMD_RenderingServer_particles_collision_set_height_field_resolution__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void particles_collision_set_height_field_mask(ulong particles_collision, long mask)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, particles_collision);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, mask);
            Helpers.SendCommand(Commands.CMD_RenderingServer_particles_collision_set_height_field_mask__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public ulong fog_volume_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_fog_volume_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void fog_volume_set_shape(ulong fog_volume, long shape)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, fog_volume);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, shape);
            Helpers.SendCommand(Commands.CMD_RenderingServer_fog_volume_set_shape__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void fog_volume_set_size(ulong fog_volume, Vector3 size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, fog_volume);
            Helpers.WriteVector3(Commands.CMD_DATA + 16, size);
            Helpers.SendCommand(Commands.CMD_RenderingServer_fog_volume_set_size__23__9__r0);
            Helpers.WaitForCompletion();
        }

        public void fog_volume_set_material(ulong fog_volume, ulong material)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, fog_volume);
            Helpers.WriteRID(Commands.CMD_DATA + 16, material);
            Helpers.SendCommand(Commands.CMD_RenderingServer_fog_volume_set_material__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public ulong visibility_notifier_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_visibility_notifier_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void visibility_notifier_set_aabb(ulong notifier, AABB aabb)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, notifier);
            Helpers.WriteAABB(Commands.CMD_DATA + 16, aabb);
            Helpers.SendCommand(Commands.CMD_RenderingServer_visibility_notifier_set_aabb__23__16__r0);
            Helpers.WaitForCompletion();
        }

        public void visibility_notifier_set_callbacks(ulong notifier, object enter_callable, object exit_callable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, notifier);
            Helpers.WriteCallable(Commands.CMD_DATA + 16, enter_callable);
            Helpers.WriteCallable(Commands.CMD_DATA + 16, exit_callable);
            Helpers.SendCommand(Commands.CMD_RenderingServer_visibility_notifier_set_callbacks__23__25__25__r0);
            Helpers.WaitForCompletion();
        }

        public ulong occluder_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_occluder_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void occluder_set_mesh(ulong occluder, Vector3[] vertices, int[] indices)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, occluder);
            Helpers.WritePackedVector3Array(Commands.CMD_DATA + 16, vertices);
            Helpers.WritePackedInt32Array(Commands.CMD_DATA + 16, indices);
            Helpers.SendCommand(Commands.CMD_RenderingServer_occluder_set_mesh__23__36__30__r0);
            Helpers.WaitForCompletion();
        }

        public ulong camera_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_camera_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void camera_set_perspective(ulong camera, double fovy_degrees, double z_near, double z_far)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, camera);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, fovy_degrees);
            Helpers.WriteDouble(Commands.CMD_DATA + 24, z_near);
            Helpers.WriteDouble(Commands.CMD_DATA + 32, z_far);
            Helpers.SendCommand(Commands.CMD_RenderingServer_camera_set_perspective__23__3__3__3__r0);
            Helpers.WaitForCompletion();
        }

        public void camera_set_orthogonal(ulong camera, double size, double z_near, double z_far)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, camera);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, size);
            Helpers.WriteDouble(Commands.CMD_DATA + 24, z_near);
            Helpers.WriteDouble(Commands.CMD_DATA + 32, z_far);
            Helpers.SendCommand(Commands.CMD_RenderingServer_camera_set_orthogonal__23__3__3__3__r0);
            Helpers.WaitForCompletion();
        }

        public void camera_set_frustum(ulong camera, double size, Vector2 offset, double z_near, double z_far)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, camera);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, size);
            Helpers.WriteVector2(Commands.CMD_DATA + 24, offset);
            Helpers.WriteDouble(Commands.CMD_DATA + 32, z_near);
            Helpers.WriteDouble(Commands.CMD_DATA + 40, z_far);
            Helpers.SendCommand(Commands.CMD_RenderingServer_camera_set_frustum__23__3__5__3__3__r0);
            Helpers.WaitForCompletion();
        }

        public void camera_set_transform(ulong camera, Transform3D transform)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, camera);
            Helpers.WriteTransform3D(Commands.CMD_DATA + 16, transform);
            Helpers.SendCommand(Commands.CMD_RenderingServer_camera_set_transform__23__18__r0);
            Helpers.WaitForCompletion();
        }

        public void camera_set_cull_mask(ulong camera, long layers)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, camera);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, layers);
            Helpers.SendCommand(Commands.CMD_RenderingServer_camera_set_cull_mask__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void camera_set_environment(ulong camera, ulong env)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, camera);
            Helpers.WriteRID(Commands.CMD_DATA + 16, env);
            Helpers.SendCommand(Commands.CMD_RenderingServer_camera_set_environment__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public void camera_set_camera_attributes(ulong camera, ulong effects)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, camera);
            Helpers.WriteRID(Commands.CMD_DATA + 16, effects);
            Helpers.SendCommand(Commands.CMD_RenderingServer_camera_set_camera_attributes__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public void camera_set_compositor(ulong camera, ulong compositor)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, camera);
            Helpers.WriteRID(Commands.CMD_DATA + 16, compositor);
            Helpers.SendCommand(Commands.CMD_RenderingServer_camera_set_compositor__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public void camera_set_use_vertical_aspect(ulong camera, bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, camera);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_camera_set_use_vertical_aspect__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public ulong viewport_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_viewport_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void viewport_set_use_xr(ulong viewport, bool use_xr)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, viewport);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, use_xr ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_viewport_set_use_xr__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public void viewport_set_size(ulong viewport, long width, long height)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, viewport);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, width);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, height);
            Helpers.SendCommand(Commands.CMD_RenderingServer_viewport_set_size__23__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public void viewport_set_active(ulong viewport, bool active)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, viewport);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, active ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_viewport_set_active__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public void viewport_set_parent_viewport(ulong viewport, ulong parent_viewport)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, viewport);
            Helpers.WriteRID(Commands.CMD_DATA + 16, parent_viewport);
            Helpers.SendCommand(Commands.CMD_RenderingServer_viewport_set_parent_viewport__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public void viewport_attach_to_screen(ulong viewport, Rect2 rect, long screen)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, viewport);
            Helpers.WriteRect2(Commands.CMD_DATA + 16, rect);
            Helpers.WriteInt64(Commands.CMD_DATA + 32, screen);
            Helpers.SendCommand(Commands.CMD_RenderingServer_viewport_attach_to_screen__23__7__2__r0);
            Helpers.WaitForCompletion();
        }

        public void viewport_set_render_direct_to_screen(ulong viewport, bool enabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, viewport);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_viewport_set_render_direct_to_screen__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public void viewport_set_canvas_cull_mask(ulong viewport, long canvas_cull_mask)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, viewport);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, canvas_cull_mask);
            Helpers.SendCommand(Commands.CMD_RenderingServer_viewport_set_canvas_cull_mask__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void viewport_set_scaling_3d_mode(ulong viewport, long scaling_3d_mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, viewport);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, scaling_3d_mode);
            Helpers.SendCommand(Commands.CMD_RenderingServer_viewport_set_scaling_3d_mode__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void viewport_set_scaling_3d_scale(ulong viewport, double scale)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, viewport);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, scale);
            Helpers.SendCommand(Commands.CMD_RenderingServer_viewport_set_scaling_3d_scale__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public void viewport_set_fsr_sharpness(ulong viewport, double sharpness)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, viewport);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, sharpness);
            Helpers.SendCommand(Commands.CMD_RenderingServer_viewport_set_fsr_sharpness__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public void viewport_set_texture_mipmap_bias(ulong viewport, double mipmap_bias)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, viewport);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, mipmap_bias);
            Helpers.SendCommand(Commands.CMD_RenderingServer_viewport_set_texture_mipmap_bias__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public void viewport_set_anisotropic_filtering_level(ulong viewport, long anisotropic_filtering_level)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, viewport);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, anisotropic_filtering_level);
            Helpers.SendCommand(Commands.CMD_RenderingServer_viewport_set_anisotropic_filtering_level__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void viewport_set_update_mode(ulong viewport, long update_mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, viewport);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, update_mode);
            Helpers.SendCommand(Commands.CMD_RenderingServer_viewport_set_update_mode__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long viewport_get_update_mode(ulong viewport)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, viewport);
            Helpers.SendCommand(Commands.CMD_RenderingServer_viewport_get_update_mode__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void viewport_set_clear_mode(ulong viewport, long clear_mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, viewport);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, clear_mode);
            Helpers.SendCommand(Commands.CMD_RenderingServer_viewport_set_clear_mode__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public ulong viewport_get_render_target(ulong viewport)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, viewport);
            Helpers.SendCommand(Commands.CMD_RenderingServer_viewport_get_render_target__23__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public ulong viewport_get_texture(ulong viewport)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, viewport);
            Helpers.SendCommand(Commands.CMD_RenderingServer_viewport_get_texture__23__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void viewport_set_disable_3d(ulong viewport, bool disable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, viewport);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, disable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_viewport_set_disable_3d__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public void viewport_set_disable_2d(ulong viewport, bool disable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, viewport);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, disable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_viewport_set_disable_2d__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public void viewport_set_environment_mode(ulong viewport, long mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, viewport);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, mode);
            Helpers.SendCommand(Commands.CMD_RenderingServer_viewport_set_environment_mode__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void viewport_attach_camera(ulong viewport, ulong camera)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, viewport);
            Helpers.WriteRID(Commands.CMD_DATA + 16, camera);
            Helpers.SendCommand(Commands.CMD_RenderingServer_viewport_attach_camera__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public void viewport_set_scenario(ulong viewport, ulong scenario)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, viewport);
            Helpers.WriteRID(Commands.CMD_DATA + 16, scenario);
            Helpers.SendCommand(Commands.CMD_RenderingServer_viewport_set_scenario__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public void viewport_attach_canvas(ulong viewport, ulong canvas)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, viewport);
            Helpers.WriteRID(Commands.CMD_DATA + 16, canvas);
            Helpers.SendCommand(Commands.CMD_RenderingServer_viewport_attach_canvas__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public void viewport_remove_canvas(ulong viewport, ulong canvas)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, viewport);
            Helpers.WriteRID(Commands.CMD_DATA + 16, canvas);
            Helpers.SendCommand(Commands.CMD_RenderingServer_viewport_remove_canvas__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public void viewport_set_snap_2d_transforms_to_pixel(ulong viewport, bool enabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, viewport);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_viewport_set_snap_2d_transforms_to_pixel__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public void viewport_set_snap_2d_vertices_to_pixel(ulong viewport, bool enabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, viewport);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_viewport_set_snap_2d_vertices_to_pixel__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public void viewport_set_default_canvas_item_texture_filter(ulong viewport, long filter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, viewport);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, filter);
            Helpers.SendCommand(Commands.CMD_RenderingServer_viewport_set_default_canvas_item_texture_filter__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void viewport_set_default_canvas_item_texture_repeat(ulong viewport, long repeat)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, viewport);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, repeat);
            Helpers.SendCommand(Commands.CMD_RenderingServer_viewport_set_default_canvas_item_texture_repeat__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void viewport_set_canvas_transform(ulong viewport, ulong canvas, Transform2D offset)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, viewport);
            Helpers.WriteRID(Commands.CMD_DATA + 16, canvas);
            Helpers.WriteTransform2D(Commands.CMD_DATA + 24, offset);
            Helpers.SendCommand(Commands.CMD_RenderingServer_viewport_set_canvas_transform__23__23__11__r0);
            Helpers.WaitForCompletion();
        }

        public void viewport_set_canvas_stacking(ulong viewport, ulong canvas, long layer, long sublayer)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, viewport);
            Helpers.WriteRID(Commands.CMD_DATA + 16, canvas);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, layer);
            Helpers.WriteInt64(Commands.CMD_DATA + 32, sublayer);
            Helpers.SendCommand(Commands.CMD_RenderingServer_viewport_set_canvas_stacking__23__23__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public void viewport_set_transparent_background(ulong viewport, bool enabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, viewport);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_viewport_set_transparent_background__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public void viewport_set_global_canvas_transform(ulong viewport, Transform2D transform)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, viewport);
            Helpers.WriteTransform2D(Commands.CMD_DATA + 16, transform);
            Helpers.SendCommand(Commands.CMD_RenderingServer_viewport_set_global_canvas_transform__23__11__r0);
            Helpers.WaitForCompletion();
        }

        public void viewport_set_sdf_oversize_and_scale(ulong viewport, long oversize, long scale)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, viewport);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, oversize);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, scale);
            Helpers.SendCommand(Commands.CMD_RenderingServer_viewport_set_sdf_oversize_and_scale__23__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public void viewport_set_positional_shadow_atlas_size(ulong viewport, long size, bool use_16_bits)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, viewport);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, size);
            Helpers.WriteInt32(Commands.CMD_DATA + 24, use_16_bits ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_viewport_set_positional_shadow_atlas_size__23__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public void viewport_set_positional_shadow_atlas_quadrant_subdivision(ulong viewport, long quadrant, long subdivision)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, viewport);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, quadrant);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, subdivision);
            Helpers.SendCommand(Commands.CMD_RenderingServer_viewport_set_positional_shadow_atlas_quadrant_subdivision__23__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public void viewport_set_msaa_3d(ulong viewport, long msaa)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, viewport);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, msaa);
            Helpers.SendCommand(Commands.CMD_RenderingServer_viewport_set_msaa_3d__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void viewport_set_msaa_2d(ulong viewport, long msaa)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, viewport);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, msaa);
            Helpers.SendCommand(Commands.CMD_RenderingServer_viewport_set_msaa_2d__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void viewport_set_use_hdr_2d(ulong viewport, bool enabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, viewport);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_viewport_set_use_hdr_2d__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public void viewport_set_screen_space_aa(ulong viewport, long mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, viewport);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, mode);
            Helpers.SendCommand(Commands.CMD_RenderingServer_viewport_set_screen_space_aa__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void viewport_set_use_taa(ulong viewport, bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, viewport);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_viewport_set_use_taa__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public void viewport_set_use_debanding(ulong viewport, bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, viewport);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_viewport_set_use_debanding__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public void viewport_set_use_occlusion_culling(ulong viewport, bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, viewport);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_viewport_set_use_occlusion_culling__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public void viewport_set_occlusion_rays_per_thread(long rays_per_thread)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, rays_per_thread);
            Helpers.SendCommand(Commands.CMD_RenderingServer_viewport_set_occlusion_rays_per_thread__2__r0);
            Helpers.WaitForCompletion();
        }

        public void viewport_set_occlusion_culling_build_quality(long quality)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, quality);
            Helpers.SendCommand(Commands.CMD_RenderingServer_viewport_set_occlusion_culling_build_quality__2__r0);
            Helpers.WaitForCompletion();
        }

        public long viewport_get_render_info(ulong viewport, long type, long info)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, viewport);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, type);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, info);
            Helpers.SendCommand(Commands.CMD_RenderingServer_viewport_get_render_info__23__2__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void viewport_set_debug_draw(ulong viewport, long draw)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, viewport);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, draw);
            Helpers.SendCommand(Commands.CMD_RenderingServer_viewport_set_debug_draw__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void viewport_set_measure_render_time(ulong viewport, bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, viewport);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_viewport_set_measure_render_time__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public double viewport_get_measured_render_time_cpu(ulong viewport)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, viewport);
            Helpers.SendCommand(Commands.CMD_RenderingServer_viewport_get_measured_render_time_cpu__23__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public double viewport_get_measured_render_time_gpu(ulong viewport)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, viewport);
            Helpers.SendCommand(Commands.CMD_RenderingServer_viewport_get_measured_render_time_gpu__23__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void viewport_set_vrs_mode(ulong viewport, long mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, viewport);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, mode);
            Helpers.SendCommand(Commands.CMD_RenderingServer_viewport_set_vrs_mode__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void viewport_set_vrs_update_mode(ulong viewport, long mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, viewport);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, mode);
            Helpers.SendCommand(Commands.CMD_RenderingServer_viewport_set_vrs_update_mode__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void viewport_set_vrs_texture(ulong viewport, ulong texture)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, viewport);
            Helpers.WriteRID(Commands.CMD_DATA + 16, texture);
            Helpers.SendCommand(Commands.CMD_RenderingServer_viewport_set_vrs_texture__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public ulong sky_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_sky_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void sky_set_radiance_size(ulong sky, long radiance_size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, sky);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, radiance_size);
            Helpers.SendCommand(Commands.CMD_RenderingServer_sky_set_radiance_size__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void sky_set_mode(ulong sky, long mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, sky);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, mode);
            Helpers.SendCommand(Commands.CMD_RenderingServer_sky_set_mode__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void sky_set_material(ulong sky, ulong material)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, sky);
            Helpers.WriteRID(Commands.CMD_DATA + 16, material);
            Helpers.SendCommand(Commands.CMD_RenderingServer_sky_set_material__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public ulong sky_bake_panorama(ulong sky, double energy, bool bake_irradiance, Vector2i size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, sky);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, energy);
            Helpers.WriteInt32(Commands.CMD_DATA + 24, bake_irradiance ? 1 : 0);
            Helpers.WriteVector2i(Commands.CMD_DATA + 28, size);
            Helpers.SendCommand(Commands.CMD_RenderingServer_sky_bake_panorama__23__3__1__6__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong compositor_effect_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_compositor_effect_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void compositor_effect_set_enabled(ulong effect, bool enabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, effect);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_compositor_effect_set_enabled__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public void compositor_effect_set_callback(ulong effect, long callback_type, object callback)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, effect);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, callback_type);
            Helpers.WriteCallable(Commands.CMD_DATA + 24, callback);
            Helpers.SendCommand(Commands.CMD_RenderingServer_compositor_effect_set_callback__23__2__25__r0);
            Helpers.WaitForCompletion();
        }

        public void compositor_effect_set_flag(ulong effect, long flag, bool set)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, effect);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, flag);
            Helpers.WriteInt32(Commands.CMD_DATA + 24, set ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_compositor_effect_set_flag__23__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public ulong compositor_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_compositor_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void compositor_set_compositor_effects(ulong compositor, object effects)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, compositor);
            Helpers.WriteArray(Commands.CMD_DATA + 16, effects);
            Helpers.SendCommand(Commands.CMD_RenderingServer_compositor_set_compositor_effects__23__28__r0);
            Helpers.WaitForCompletion();
        }

        public ulong environment_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_environment_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void environment_set_background(ulong env, long bg)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, env);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, bg);
            Helpers.SendCommand(Commands.CMD_RenderingServer_environment_set_background__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void environment_set_camera_id(ulong env, long id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, env);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_environment_set_camera_id__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void environment_set_sky(ulong env, ulong sky)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, env);
            Helpers.WriteRID(Commands.CMD_DATA + 16, sky);
            Helpers.SendCommand(Commands.CMD_RenderingServer_environment_set_sky__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public void environment_set_sky_custom_fov(ulong env, double scale)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, env);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, scale);
            Helpers.SendCommand(Commands.CMD_RenderingServer_environment_set_sky_custom_fov__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public void environment_set_sky_orientation(ulong env, Basis orientation)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, env);
            Helpers.WriteBasis(Commands.CMD_DATA + 16, orientation);
            Helpers.SendCommand(Commands.CMD_RenderingServer_environment_set_sky_orientation__23__17__r0);
            Helpers.WaitForCompletion();
        }

        public void environment_set_bg_color(ulong env, Color color)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, env);
            Helpers.WriteColor(Commands.CMD_DATA + 16, color);
            Helpers.SendCommand(Commands.CMD_RenderingServer_environment_set_bg_color__23__20__r0);
            Helpers.WaitForCompletion();
        }

        public void environment_set_bg_energy(ulong env, double multiplier, double exposure_value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, env);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, multiplier);
            Helpers.WriteDouble(Commands.CMD_DATA + 24, exposure_value);
            Helpers.SendCommand(Commands.CMD_RenderingServer_environment_set_bg_energy__23__3__3__r0);
            Helpers.WaitForCompletion();
        }

        public void environment_set_canvas_max_layer(ulong env, long max_layer)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, env);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, max_layer);
            Helpers.SendCommand(Commands.CMD_RenderingServer_environment_set_canvas_max_layer__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void environment_set_ambient_light(ulong env, Color color, long ambient, double energy, double sky_contribution, long reflection_source)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, env);
            Helpers.WriteColor(Commands.CMD_DATA + 16, color);
            Helpers.WriteInt64(Commands.CMD_DATA + 32, ambient);
            Helpers.WriteDouble(Commands.CMD_DATA + 40, energy);
            Helpers.WriteDouble(Commands.CMD_DATA + 48, sky_contribution);
            Helpers.WriteInt64(Commands.CMD_DATA + 56, reflection_source);
            Helpers.SendCommand(Commands.CMD_RenderingServer_environment_set_ambient_light__23__20__2__3__3__2__r0);
            Helpers.WaitForCompletion();
        }

        public void environment_set_glow(ulong env, bool enable, float[] levels, double intensity, double strength, double mix, double bloom_threshold, long blend_mode, double hdr_bleed_threshold, double hdr_bleed_scale, double hdr_luminance_cap, double glow_map_strength, ulong glow_map)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, env);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enable ? 1 : 0);
            Helpers.WritePackedFloat32Array(Commands.CMD_DATA + 20, levels);
            Helpers.WriteDouble(Commands.CMD_DATA + 20 + 4 + (levels.Length * 4), intensity);
            Helpers.WriteDouble(Commands.CMD_DATA + 20 + 4 + (levels.Length * 4) + 8, strength);
            Helpers.WriteDouble(Commands.CMD_DATA + 20 + 4 + (levels.Length * 4) + 8 + 8, mix);
            Helpers.WriteDouble(Commands.CMD_DATA + 20 + 4 + (levels.Length * 4) + 8 + 8 + 8, bloom_threshold);
            Helpers.WriteInt64(Commands.CMD_DATA + 20 + 4 + (levels.Length * 4) + 8 + 8 + 8 + 8, blend_mode);
            Helpers.WriteDouble(Commands.CMD_DATA + 20 + 4 + (levels.Length * 4) + 8 + 8 + 8 + 8 + 8, hdr_bleed_threshold);
            Helpers.WriteDouble(Commands.CMD_DATA + 20 + 4 + (levels.Length * 4) + 8 + 8 + 8 + 8 + 8 + 8, hdr_bleed_scale);
            Helpers.WriteDouble(Commands.CMD_DATA + 20 + 4 + (levels.Length * 4) + 8 + 8 + 8 + 8 + 8 + 8 + 8, hdr_luminance_cap);
            Helpers.WriteDouble(Commands.CMD_DATA + 20 + 4 + (levels.Length * 4) + 8 + 8 + 8 + 8 + 8 + 8 + 8 + 8, glow_map_strength);
            Helpers.WriteRID(Commands.CMD_DATA + 20 + 4 + (levels.Length * 4) + 8 + 8 + 8 + 8 + 8 + 8 + 8 + 8 + 8, glow_map);
            Helpers.SendCommand(Commands.CMD_RenderingServer_environment_set_glow__23__1__32__3__3__3__3__2__3__3__3__3__23__r0);
            Helpers.WaitForCompletion();
        }

        public void environment_set_tonemap(ulong env, long tone_mapper, double exposure, double white)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, env);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, tone_mapper);
            Helpers.WriteDouble(Commands.CMD_DATA + 24, exposure);
            Helpers.WriteDouble(Commands.CMD_DATA + 32, white);
            Helpers.SendCommand(Commands.CMD_RenderingServer_environment_set_tonemap__23__2__3__3__r0);
            Helpers.WaitForCompletion();
        }

        public void environment_set_tonemap_agx_contrast(ulong env, double agx_contrast)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, env);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, agx_contrast);
            Helpers.SendCommand(Commands.CMD_RenderingServer_environment_set_tonemap_agx_contrast__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public void environment_set_adjustment(ulong env, bool enable, double brightness, double contrast, double saturation, bool use_1d_color_correction, ulong color_correction)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, env);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enable ? 1 : 0);
            Helpers.WriteDouble(Commands.CMD_DATA + 20, brightness);
            Helpers.WriteDouble(Commands.CMD_DATA + 28, contrast);
            Helpers.WriteDouble(Commands.CMD_DATA + 36, saturation);
            Helpers.WriteInt32(Commands.CMD_DATA + 44, use_1d_color_correction ? 1 : 0);
            Helpers.WriteRID(Commands.CMD_DATA + 48, color_correction);
            Helpers.SendCommand(Commands.CMD_RenderingServer_environment_set_adjustment__23__1__3__3__3__1__23__r0);
            Helpers.WaitForCompletion();
        }

        public void environment_set_ssr(ulong env, bool enable, long max_steps, double fade_in, double fade_out, double depth_tolerance)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, env);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enable ? 1 : 0);
            Helpers.WriteInt64(Commands.CMD_DATA + 20, max_steps);
            Helpers.WriteDouble(Commands.CMD_DATA + 28, fade_in);
            Helpers.WriteDouble(Commands.CMD_DATA + 36, fade_out);
            Helpers.WriteDouble(Commands.CMD_DATA + 44, depth_tolerance);
            Helpers.SendCommand(Commands.CMD_RenderingServer_environment_set_ssr__23__1__2__3__3__3__r0);
            Helpers.WaitForCompletion();
        }

        public void environment_set_ssao(ulong env, bool enable, double radius, double intensity, double power, double detail, double horizon, double sharpness, double light_affect, double ao_channel_affect)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, env);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enable ? 1 : 0);
            Helpers.WriteDouble(Commands.CMD_DATA + 20, radius);
            Helpers.WriteDouble(Commands.CMD_DATA + 28, intensity);
            Helpers.WriteDouble(Commands.CMD_DATA + 36, power);
            Helpers.WriteDouble(Commands.CMD_DATA + 44, detail);
            Helpers.WriteDouble(Commands.CMD_DATA + 52, horizon);
            Helpers.WriteDouble(Commands.CMD_DATA + 60, sharpness);
            Helpers.WriteDouble(Commands.CMD_DATA + 68, light_affect);
            Helpers.WriteDouble(Commands.CMD_DATA + 76, ao_channel_affect);
            Helpers.SendCommand(Commands.CMD_RenderingServer_environment_set_ssao__23__1__3__3__3__3__3__3__3__3__r0);
            Helpers.WaitForCompletion();
        }

        public void environment_set_fog(ulong env, bool enable, Color light_color, double light_energy, double sun_scatter, double density, double height, double height_density, double aerial_perspective, double sky_affect, long fog_mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, env);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enable ? 1 : 0);
            Helpers.WriteColor(Commands.CMD_DATA + 20, light_color);
            Helpers.WriteDouble(Commands.CMD_DATA + 36, light_energy);
            Helpers.WriteDouble(Commands.CMD_DATA + 44, sun_scatter);
            Helpers.WriteDouble(Commands.CMD_DATA + 52, density);
            Helpers.WriteDouble(Commands.CMD_DATA + 60, height);
            Helpers.WriteDouble(Commands.CMD_DATA + 68, height_density);
            Helpers.WriteDouble(Commands.CMD_DATA + 76, aerial_perspective);
            Helpers.WriteDouble(Commands.CMD_DATA + 84, sky_affect);
            Helpers.WriteInt64(Commands.CMD_DATA + 92, fog_mode);
            Helpers.SendCommand(Commands.CMD_RenderingServer_environment_set_fog__23__1__20__3__3__3__3__3__3__3__2__r0);
            Helpers.WaitForCompletion();
        }

        public void environment_set_fog_depth(ulong env, double curve, double begin, double end)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, env);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, curve);
            Helpers.WriteDouble(Commands.CMD_DATA + 24, begin);
            Helpers.WriteDouble(Commands.CMD_DATA + 32, end);
            Helpers.SendCommand(Commands.CMD_RenderingServer_environment_set_fog_depth__23__3__3__3__r0);
            Helpers.WaitForCompletion();
        }

        public void environment_set_sdfgi(ulong env, bool enable, long cascades, double min_cell_size, long y_scale, bool use_occlusion, double bounce_feedback, bool read_sky, double energy, double normal_bias, double probe_bias)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, env);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enable ? 1 : 0);
            Helpers.WriteInt64(Commands.CMD_DATA + 20, cascades);
            Helpers.WriteDouble(Commands.CMD_DATA + 28, min_cell_size);
            Helpers.WriteInt64(Commands.CMD_DATA + 36, y_scale);
            Helpers.WriteInt32(Commands.CMD_DATA + 44, use_occlusion ? 1 : 0);
            Helpers.WriteDouble(Commands.CMD_DATA + 48, bounce_feedback);
            Helpers.WriteInt32(Commands.CMD_DATA + 56, read_sky ? 1 : 0);
            Helpers.WriteDouble(Commands.CMD_DATA + 60, energy);
            Helpers.WriteDouble(Commands.CMD_DATA + 68, normal_bias);
            Helpers.WriteDouble(Commands.CMD_DATA + 76, probe_bias);
            Helpers.SendCommand(Commands.CMD_RenderingServer_environment_set_sdfgi__23__1__2__3__2__1__3__1__3__3__3__r0);
            Helpers.WaitForCompletion();
        }

        public void environment_set_volumetric_fog(ulong env, bool enable, double density, Color albedo, Color emission, double emission_energy, double anisotropy, double length, double p_detail_spread, double gi_inject, bool temporal_reprojection, double temporal_reprojection_amount, double ambient_inject, double sky_affect)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, env);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enable ? 1 : 0);
            Helpers.WriteDouble(Commands.CMD_DATA + 20, density);
            Helpers.WriteColor(Commands.CMD_DATA + 28, albedo);
            Helpers.WriteColor(Commands.CMD_DATA + 44, emission);
            Helpers.WriteDouble(Commands.CMD_DATA + 60, emission_energy);
            Helpers.WriteDouble(Commands.CMD_DATA + 68, anisotropy);
            Helpers.WriteDouble(Commands.CMD_DATA + 76, length);
            Helpers.WriteDouble(Commands.CMD_DATA + 84, p_detail_spread);
            Helpers.WriteDouble(Commands.CMD_DATA + 92, gi_inject);
            Helpers.WriteInt32(Commands.CMD_DATA + 100, temporal_reprojection ? 1 : 0);
            Helpers.WriteDouble(Commands.CMD_DATA + 104, temporal_reprojection_amount);
            Helpers.WriteDouble(Commands.CMD_DATA + 112, ambient_inject);
            Helpers.WriteDouble(Commands.CMD_DATA + 120, sky_affect);
            Helpers.SendCommand(Commands.CMD_RenderingServer_environment_set_volumetric_fog__23__1__3__20__20__3__3__3__3__3__1__3__3__3__r0);
            Helpers.WaitForCompletion();
        }

        public void environment_glow_set_use_bicubic_upscale(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_environment_glow_set_use_bicubic_upscale__1__r0);
            Helpers.WaitForCompletion();
        }

        public void environment_set_ssr_half_size(bool half_size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, half_size ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_environment_set_ssr_half_size__1__r0);
            Helpers.WaitForCompletion();
        }

        public void environment_set_ssr_roughness_quality(long quality)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, quality);
            Helpers.SendCommand(Commands.CMD_RenderingServer_environment_set_ssr_roughness_quality__2__r0);
            Helpers.WaitForCompletion();
        }

        public void environment_set_ssao_quality(long quality, bool half_size, double adaptive_target, long blur_passes, double fadeout_from, double fadeout_to)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, quality);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, half_size ? 1 : 0);
            Helpers.WriteDouble(Commands.CMD_DATA + 20, adaptive_target);
            Helpers.WriteInt64(Commands.CMD_DATA + 28, blur_passes);
            Helpers.WriteDouble(Commands.CMD_DATA + 36, fadeout_from);
            Helpers.WriteDouble(Commands.CMD_DATA + 44, fadeout_to);
            Helpers.SendCommand(Commands.CMD_RenderingServer_environment_set_ssao_quality__2__1__3__2__3__3__r0);
            Helpers.WaitForCompletion();
        }

        public void environment_set_ssil_quality(long quality, bool half_size, double adaptive_target, long blur_passes, double fadeout_from, double fadeout_to)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, quality);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, half_size ? 1 : 0);
            Helpers.WriteDouble(Commands.CMD_DATA + 20, adaptive_target);
            Helpers.WriteInt64(Commands.CMD_DATA + 28, blur_passes);
            Helpers.WriteDouble(Commands.CMD_DATA + 36, fadeout_from);
            Helpers.WriteDouble(Commands.CMD_DATA + 44, fadeout_to);
            Helpers.SendCommand(Commands.CMD_RenderingServer_environment_set_ssil_quality__2__1__3__2__3__3__r0);
            Helpers.WaitForCompletion();
        }

        public void environment_set_sdfgi_ray_count(long ray_count)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, ray_count);
            Helpers.SendCommand(Commands.CMD_RenderingServer_environment_set_sdfgi_ray_count__2__r0);
            Helpers.WaitForCompletion();
        }

        public void environment_set_sdfgi_frames_to_converge(long frames)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, frames);
            Helpers.SendCommand(Commands.CMD_RenderingServer_environment_set_sdfgi_frames_to_converge__2__r0);
            Helpers.WaitForCompletion();
        }

        public void environment_set_sdfgi_frames_to_update_light(long frames)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, frames);
            Helpers.SendCommand(Commands.CMD_RenderingServer_environment_set_sdfgi_frames_to_update_light__2__r0);
            Helpers.WaitForCompletion();
        }

        public void environment_set_volumetric_fog_volume_size(long size, long depth)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, size);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, depth);
            Helpers.SendCommand(Commands.CMD_RenderingServer_environment_set_volumetric_fog_volume_size__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public void environment_set_volumetric_fog_filter_active(bool active)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, active ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_environment_set_volumetric_fog_filter_active__1__r0);
            Helpers.WaitForCompletion();
        }

        public ulong environment_bake_panorama(ulong environment, bool bake_irradiance, Vector2i size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, environment);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, bake_irradiance ? 1 : 0);
            Helpers.WriteVector2i(Commands.CMD_DATA + 20, size);
            Helpers.SendCommand(Commands.CMD_RenderingServer_environment_bake_panorama__23__1__6__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void screen_space_roughness_limiter_set_active(bool enable, double amount, double limit)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.WriteDouble(Commands.CMD_DATA + 12, amount);
            Helpers.WriteDouble(Commands.CMD_DATA + 20, limit);
            Helpers.SendCommand(Commands.CMD_RenderingServer_screen_space_roughness_limiter_set_active__1__3__3__r0);
            Helpers.WaitForCompletion();
        }

        public void sub_surface_scattering_set_quality(long quality)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, quality);
            Helpers.SendCommand(Commands.CMD_RenderingServer_sub_surface_scattering_set_quality__2__r0);
            Helpers.WaitForCompletion();
        }

        public void sub_surface_scattering_set_scale(double scale, double depth_scale)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDouble(Commands.CMD_DATA + 8, scale);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, depth_scale);
            Helpers.SendCommand(Commands.CMD_RenderingServer_sub_surface_scattering_set_scale__3__3__r0);
            Helpers.WaitForCompletion();
        }

        public ulong camera_attributes_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_camera_attributes_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void camera_attributes_set_dof_blur_quality(long quality, bool use_jitter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, quality);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, use_jitter ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_camera_attributes_set_dof_blur_quality__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public void camera_attributes_set_dof_blur_bokeh_shape(long shape)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, shape);
            Helpers.SendCommand(Commands.CMD_RenderingServer_camera_attributes_set_dof_blur_bokeh_shape__2__r0);
            Helpers.WaitForCompletion();
        }

        public void camera_attributes_set_dof_blur(ulong camera_attributes, bool far_enable, double far_distance, double far_transition, bool near_enable, double near_distance, double near_transition, double amount)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, camera_attributes);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, far_enable ? 1 : 0);
            Helpers.WriteDouble(Commands.CMD_DATA + 20, far_distance);
            Helpers.WriteDouble(Commands.CMD_DATA + 28, far_transition);
            Helpers.WriteInt32(Commands.CMD_DATA + 36, near_enable ? 1 : 0);
            Helpers.WriteDouble(Commands.CMD_DATA + 40, near_distance);
            Helpers.WriteDouble(Commands.CMD_DATA + 48, near_transition);
            Helpers.WriteDouble(Commands.CMD_DATA + 56, amount);
            Helpers.SendCommand(Commands.CMD_RenderingServer_camera_attributes_set_dof_blur__23__1__3__3__1__3__3__3__r0);
            Helpers.WaitForCompletion();
        }

        public void camera_attributes_set_exposure(ulong camera_attributes, double multiplier, double normalization)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, camera_attributes);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, multiplier);
            Helpers.WriteDouble(Commands.CMD_DATA + 24, normalization);
            Helpers.SendCommand(Commands.CMD_RenderingServer_camera_attributes_set_exposure__23__3__3__r0);
            Helpers.WaitForCompletion();
        }

        public void camera_attributes_set_auto_exposure(ulong camera_attributes, bool enable, double min_sensitivity, double max_sensitivity, double speed, double scale)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, camera_attributes);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enable ? 1 : 0);
            Helpers.WriteDouble(Commands.CMD_DATA + 20, min_sensitivity);
            Helpers.WriteDouble(Commands.CMD_DATA + 28, max_sensitivity);
            Helpers.WriteDouble(Commands.CMD_DATA + 36, speed);
            Helpers.WriteDouble(Commands.CMD_DATA + 44, scale);
            Helpers.SendCommand(Commands.CMD_RenderingServer_camera_attributes_set_auto_exposure__23__1__3__3__3__3__r0);
            Helpers.WaitForCompletion();
        }

        public ulong scenario_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_scenario_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void scenario_set_environment(ulong scenario, ulong environment)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, scenario);
            Helpers.WriteRID(Commands.CMD_DATA + 16, environment);
            Helpers.SendCommand(Commands.CMD_RenderingServer_scenario_set_environment__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public void scenario_set_fallback_environment(ulong scenario, ulong environment)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, scenario);
            Helpers.WriteRID(Commands.CMD_DATA + 16, environment);
            Helpers.SendCommand(Commands.CMD_RenderingServer_scenario_set_fallback_environment__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public void scenario_set_camera_attributes(ulong scenario, ulong effects)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, scenario);
            Helpers.WriteRID(Commands.CMD_DATA + 16, effects);
            Helpers.SendCommand(Commands.CMD_RenderingServer_scenario_set_camera_attributes__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public void scenario_set_compositor(ulong scenario, ulong compositor)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, scenario);
            Helpers.WriteRID(Commands.CMD_DATA + 16, compositor);
            Helpers.SendCommand(Commands.CMD_RenderingServer_scenario_set_compositor__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public ulong instance_create2(ulong base_, ulong scenario)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, base_);
            Helpers.WriteRID(Commands.CMD_DATA + 16, scenario);
            Helpers.SendCommand(Commands.CMD_RenderingServer_instance_create2__23__23__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public ulong instance_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_instance_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void instance_set_base(ulong instance, ulong base_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, instance);
            Helpers.WriteRID(Commands.CMD_DATA + 16, base_);
            Helpers.SendCommand(Commands.CMD_RenderingServer_instance_set_base__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public void instance_set_scenario(ulong instance, ulong scenario)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, instance);
            Helpers.WriteRID(Commands.CMD_DATA + 16, scenario);
            Helpers.SendCommand(Commands.CMD_RenderingServer_instance_set_scenario__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public void instance_set_layer_mask(ulong instance, long mask)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, instance);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, mask);
            Helpers.SendCommand(Commands.CMD_RenderingServer_instance_set_layer_mask__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void instance_set_pivot_data(ulong instance, double sorting_offset, bool use_aabb_center)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, instance);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, sorting_offset);
            Helpers.WriteInt32(Commands.CMD_DATA + 24, use_aabb_center ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_instance_set_pivot_data__23__3__1__r0);
            Helpers.WaitForCompletion();
        }

        public void instance_set_transform(ulong instance, Transform3D transform)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, instance);
            Helpers.WriteTransform3D(Commands.CMD_DATA + 16, transform);
            Helpers.SendCommand(Commands.CMD_RenderingServer_instance_set_transform__23__18__r0);
            Helpers.WaitForCompletion();
        }

        public void instance_attach_object_instance_id(ulong instance, long id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, instance);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_instance_attach_object_instance_id__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void instance_set_blend_shape_weight(ulong instance, long shape, double weight)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, instance);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, shape);
            Helpers.WriteDouble(Commands.CMD_DATA + 24, weight);
            Helpers.SendCommand(Commands.CMD_RenderingServer_instance_set_blend_shape_weight__23__2__3__r0);
            Helpers.WaitForCompletion();
        }

        public void instance_set_surface_override_material(ulong instance, long surface, ulong material)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, instance);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, surface);
            Helpers.WriteRID(Commands.CMD_DATA + 24, material);
            Helpers.SendCommand(Commands.CMD_RenderingServer_instance_set_surface_override_material__23__2__23__r0);
            Helpers.WaitForCompletion();
        }

        public void instance_set_visible(ulong instance, bool visible)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, instance);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, visible ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_instance_set_visible__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public void instance_geometry_set_transparency(ulong instance, double transparency)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, instance);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, transparency);
            Helpers.SendCommand(Commands.CMD_RenderingServer_instance_geometry_set_transparency__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public void instance_teleport(ulong instance)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, instance);
            Helpers.SendCommand(Commands.CMD_RenderingServer_instance_teleport__23__r0);
            Helpers.WaitForCompletion();
        }

        public void instance_set_custom_aabb(ulong instance, AABB aabb)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, instance);
            Helpers.WriteAABB(Commands.CMD_DATA + 16, aabb);
            Helpers.SendCommand(Commands.CMD_RenderingServer_instance_set_custom_aabb__23__16__r0);
            Helpers.WaitForCompletion();
        }

        public void instance_attach_skeleton(ulong instance, ulong skeleton)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, instance);
            Helpers.WriteRID(Commands.CMD_DATA + 16, skeleton);
            Helpers.SendCommand(Commands.CMD_RenderingServer_instance_attach_skeleton__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public void instance_set_extra_visibility_margin(ulong instance, double margin)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, instance);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, margin);
            Helpers.SendCommand(Commands.CMD_RenderingServer_instance_set_extra_visibility_margin__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public void instance_set_visibility_parent(ulong instance, ulong parent)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, instance);
            Helpers.WriteRID(Commands.CMD_DATA + 16, parent);
            Helpers.SendCommand(Commands.CMD_RenderingServer_instance_set_visibility_parent__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public void instance_set_ignore_culling(ulong instance, bool enabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, instance);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_instance_set_ignore_culling__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public void instance_geometry_set_flag(ulong instance, long flag, bool enabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, instance);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, flag);
            Helpers.WriteInt32(Commands.CMD_DATA + 24, enabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_instance_geometry_set_flag__23__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public void instance_geometry_set_cast_shadows_setting(ulong instance, long shadow_casting_setting)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, instance);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, shadow_casting_setting);
            Helpers.SendCommand(Commands.CMD_RenderingServer_instance_geometry_set_cast_shadows_setting__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void instance_geometry_set_material_override(ulong instance, ulong material)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, instance);
            Helpers.WriteRID(Commands.CMD_DATA + 16, material);
            Helpers.SendCommand(Commands.CMD_RenderingServer_instance_geometry_set_material_override__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public void instance_geometry_set_material_overlay(ulong instance, ulong material)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, instance);
            Helpers.WriteRID(Commands.CMD_DATA + 16, material);
            Helpers.SendCommand(Commands.CMD_RenderingServer_instance_geometry_set_material_overlay__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public void instance_geometry_set_visibility_range(ulong instance, double min, double max, double min_margin, double max_margin, long fade_mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, instance);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, min);
            Helpers.WriteDouble(Commands.CMD_DATA + 24, max);
            Helpers.WriteDouble(Commands.CMD_DATA + 32, min_margin);
            Helpers.WriteDouble(Commands.CMD_DATA + 40, max_margin);
            Helpers.WriteInt64(Commands.CMD_DATA + 48, fade_mode);
            Helpers.SendCommand(Commands.CMD_RenderingServer_instance_geometry_set_visibility_range__23__3__3__3__3__2__r0);
            Helpers.WaitForCompletion();
        }

        public void instance_geometry_set_lightmap(ulong instance, ulong lightmap, Rect2 lightmap_uv_scale, long lightmap_slice)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, instance);
            Helpers.WriteRID(Commands.CMD_DATA + 16, lightmap);
            Helpers.WriteRect2(Commands.CMD_DATA + 24, lightmap_uv_scale);
            Helpers.WriteInt64(Commands.CMD_DATA + 40, lightmap_slice);
            Helpers.SendCommand(Commands.CMD_RenderingServer_instance_geometry_set_lightmap__23__23__7__2__r0);
            Helpers.WaitForCompletion();
        }

        public void instance_geometry_set_lod_bias(ulong instance, double lod_bias)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, instance);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, lod_bias);
            Helpers.SendCommand(Commands.CMD_RenderingServer_instance_geometry_set_lod_bias__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public void instance_geometry_set_shader_parameter(ulong instance, string parameter, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, instance);
            Helpers.WriteStringName(Commands.CMD_DATA + 16, parameter);
            Helpers.WriteVariant(Commands.CMD_DATA + 1044, value);
            Helpers.SendCommand(Commands.CMD_RenderingServer_instance_geometry_set_shader_parameter__23__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void instance_geometry_get_shader_parameter(ulong instance, string parameter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, instance);
            Helpers.WriteStringName(Commands.CMD_DATA + 16, parameter);
            Helpers.SendCommand(Commands.CMD_RenderingServer_instance_geometry_get_shader_parameter__23__21__r0);
            Helpers.WaitForCompletion();
        }

        public void instance_geometry_get_shader_parameter_default_value(ulong instance, string parameter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, instance);
            Helpers.WriteStringName(Commands.CMD_DATA + 16, parameter);
            Helpers.SendCommand(Commands.CMD_RenderingServer_instance_geometry_get_shader_parameter_default_value__23__21__r0);
            Helpers.WaitForCompletion();
        }

        public object instance_geometry_get_shader_parameter_list(ulong instance)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, instance);
            Helpers.SendCommand(Commands.CMD_RenderingServer_instance_geometry_get_shader_parameter_list__23__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public long[] instances_cull_aabb(AABB aabb, ulong scenario)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteAABB(Commands.CMD_DATA + 8, aabb);
            Helpers.WriteRID(Commands.CMD_DATA + 32, scenario);
            Helpers.SendCommand(Commands.CMD_RenderingServer_instances_cull_aabb__16__23__r31);
            Helpers.WaitForCompletion();
            long[] result = Helpers.ReadPackedInt64Array(Commands.CMD_DATA);
            return result;
        }

        public long[] instances_cull_ray(Vector3 from, Vector3 to, ulong scenario)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector3(Commands.CMD_DATA + 8, from);
            Helpers.WriteVector3(Commands.CMD_DATA + 20, to);
            Helpers.WriteRID(Commands.CMD_DATA + 32, scenario);
            Helpers.SendCommand(Commands.CMD_RenderingServer_instances_cull_ray__9__9__23__r31);
            Helpers.WaitForCompletion();
            long[] result = Helpers.ReadPackedInt64Array(Commands.CMD_DATA);
            return result;
        }

        public long[] instances_cull_convex(object convex, ulong scenario)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteArray(Commands.CMD_DATA + 8, convex);
            Helpers.WriteRID(Commands.CMD_DATA + 8, scenario);
            Helpers.SendCommand(Commands.CMD_RenderingServer_instances_cull_convex__28__23__r31);
            Helpers.WaitForCompletion();
            long[] result = Helpers.ReadPackedInt64Array(Commands.CMD_DATA);
            return result;
        }

        public object bake_render_uv2(ulong base_, object material_overrides, Vector2i image_size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, base_);
            Helpers.WriteArray(Commands.CMD_DATA + 16, material_overrides);
            Helpers.WriteVector2i(Commands.CMD_DATA + 16, image_size);
            Helpers.SendCommand(Commands.CMD_RenderingServer_bake_render_uv2__23__28__6__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public ulong canvas_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void canvas_set_item_mirroring(ulong canvas, ulong item, Vector2 mirroring)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, canvas);
            Helpers.WriteRID(Commands.CMD_DATA + 16, item);
            Helpers.WriteVector2(Commands.CMD_DATA + 24, mirroring);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_set_item_mirroring__23__23__5__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_set_item_repeat(ulong item, Vector2 repeat_size, long repeat_times)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, item);
            Helpers.WriteVector2(Commands.CMD_DATA + 16, repeat_size);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, repeat_times);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_set_item_repeat__23__5__2__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_set_modulate(ulong canvas, Color color)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, canvas);
            Helpers.WriteColor(Commands.CMD_DATA + 16, color);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_set_modulate__23__20__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_set_disable_scale(bool disable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, disable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_set_disable_scale__1__r0);
            Helpers.WaitForCompletion();
        }

        public ulong canvas_texture_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_texture_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void canvas_texture_set_channel(ulong canvas_texture, long channel, ulong texture)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, canvas_texture);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, channel);
            Helpers.WriteRID(Commands.CMD_DATA + 24, texture);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_texture_set_channel__23__2__23__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_texture_set_shading_parameters(ulong canvas_texture, Color base_color, double shininess)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, canvas_texture);
            Helpers.WriteColor(Commands.CMD_DATA + 16, base_color);
            Helpers.WriteDouble(Commands.CMD_DATA + 32, shininess);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_texture_set_shading_parameters__23__20__3__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_texture_set_texture_filter(ulong canvas_texture, long filter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, canvas_texture);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, filter);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_texture_set_texture_filter__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_texture_set_texture_repeat(ulong canvas_texture, long repeat)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, canvas_texture);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, repeat);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_texture_set_texture_repeat__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public ulong canvas_item_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_item_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void canvas_item_set_parent(ulong item, ulong parent)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, item);
            Helpers.WriteRID(Commands.CMD_DATA + 16, parent);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_item_set_parent__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_item_set_default_texture_filter(ulong item, long filter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, item);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, filter);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_item_set_default_texture_filter__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_item_set_default_texture_repeat(ulong item, long repeat)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, item);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, repeat);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_item_set_default_texture_repeat__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_item_set_visible(ulong item, bool visible)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, item);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, visible ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_item_set_visible__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_item_set_light_mask(ulong item, long mask)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, item);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, mask);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_item_set_light_mask__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_item_set_visibility_layer(ulong item, long visibility_layer)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, item);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, visibility_layer);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_item_set_visibility_layer__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_item_set_transform(ulong item, Transform2D transform)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, item);
            Helpers.WriteTransform2D(Commands.CMD_DATA + 16, transform);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_item_set_transform__23__11__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_item_set_clip(ulong item, bool clip)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, item);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, clip ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_item_set_clip__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_item_set_distance_field_mode(ulong item, bool enabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, item);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_item_set_distance_field_mode__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_item_set_custom_rect(ulong item, bool use_custom_rect, Rect2 rect)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, item);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, use_custom_rect ? 1 : 0);
            Helpers.WriteRect2(Commands.CMD_DATA + 20, rect);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_item_set_custom_rect__23__1__7__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_item_set_modulate(ulong item, Color color)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, item);
            Helpers.WriteColor(Commands.CMD_DATA + 16, color);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_item_set_modulate__23__20__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_item_set_self_modulate(ulong item, Color color)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, item);
            Helpers.WriteColor(Commands.CMD_DATA + 16, color);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_item_set_self_modulate__23__20__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_item_set_draw_behind_parent(ulong item, bool enabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, item);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_item_set_draw_behind_parent__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_item_set_interpolated(ulong item, bool interpolated)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, item);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, interpolated ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_item_set_interpolated__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_item_reset_physics_interpolation(ulong item)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, item);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_item_reset_physics_interpolation__23__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_item_transform_physics_interpolation(ulong item, Transform2D transform)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, item);
            Helpers.WriteTransform2D(Commands.CMD_DATA + 16, transform);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_item_transform_physics_interpolation__23__11__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_item_add_line(ulong item, Vector2 from, Vector2 to, Color color, double width, bool antialiased)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, item);
            Helpers.WriteVector2(Commands.CMD_DATA + 16, from);
            Helpers.WriteVector2(Commands.CMD_DATA + 24, to);
            Helpers.WriteColor(Commands.CMD_DATA + 32, color);
            Helpers.WriteDouble(Commands.CMD_DATA + 48, width);
            Helpers.WriteInt32(Commands.CMD_DATA + 56, antialiased ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_item_add_line__23__5__5__20__3__1__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_item_add_polyline(ulong item, Vector2[] points, Color[] colors, double width, bool antialiased)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, item);
            Helpers.WritePackedVector2Array(Commands.CMD_DATA + 16, points);
            Helpers.WritePackedColorArray(Commands.CMD_DATA + 16, colors);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, width);
            Helpers.WriteInt32(Commands.CMD_DATA + 24, antialiased ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_item_add_polyline__23__35__37__3__1__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_item_add_multiline(ulong item, Vector2[] points, Color[] colors, double width, bool antialiased)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, item);
            Helpers.WritePackedVector2Array(Commands.CMD_DATA + 16, points);
            Helpers.WritePackedColorArray(Commands.CMD_DATA + 16, colors);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, width);
            Helpers.WriteInt32(Commands.CMD_DATA + 24, antialiased ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_item_add_multiline__23__35__37__3__1__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_item_add_rect(ulong item, Rect2 rect, Color color, bool antialiased)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, item);
            Helpers.WriteRect2(Commands.CMD_DATA + 16, rect);
            Helpers.WriteColor(Commands.CMD_DATA + 32, color);
            Helpers.WriteInt32(Commands.CMD_DATA + 48, antialiased ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_item_add_rect__23__7__20__1__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_item_add_circle(ulong item, Vector2 pos, double radius, Color color, bool antialiased)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, item);
            Helpers.WriteVector2(Commands.CMD_DATA + 16, pos);
            Helpers.WriteDouble(Commands.CMD_DATA + 24, radius);
            Helpers.WriteColor(Commands.CMD_DATA + 32, color);
            Helpers.WriteInt32(Commands.CMD_DATA + 48, antialiased ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_item_add_circle__23__5__3__20__1__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_item_add_ellipse(ulong item, Vector2 pos, double major, double minor, Color color, bool antialiased)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, item);
            Helpers.WriteVector2(Commands.CMD_DATA + 16, pos);
            Helpers.WriteDouble(Commands.CMD_DATA + 24, major);
            Helpers.WriteDouble(Commands.CMD_DATA + 32, minor);
            Helpers.WriteColor(Commands.CMD_DATA + 40, color);
            Helpers.WriteInt32(Commands.CMD_DATA + 56, antialiased ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_item_add_ellipse__23__5__3__3__20__1__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_item_add_texture_rect(ulong item, Rect2 rect, ulong texture, bool tile, Color modulate, bool transpose)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, item);
            Helpers.WriteRect2(Commands.CMD_DATA + 16, rect);
            Helpers.WriteRID(Commands.CMD_DATA + 32, texture);
            Helpers.WriteInt32(Commands.CMD_DATA + 40, tile ? 1 : 0);
            Helpers.WriteColor(Commands.CMD_DATA + 44, modulate);
            Helpers.WriteInt32(Commands.CMD_DATA + 60, transpose ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_item_add_texture_rect__23__7__23__1__20__1__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_item_add_msdf_texture_rect_region(ulong item, Rect2 rect, ulong texture, Rect2 src_rect, Color modulate, long outline_size, double px_range, double scale)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, item);
            Helpers.WriteRect2(Commands.CMD_DATA + 16, rect);
            Helpers.WriteRID(Commands.CMD_DATA + 32, texture);
            Helpers.WriteRect2(Commands.CMD_DATA + 40, src_rect);
            Helpers.WriteColor(Commands.CMD_DATA + 56, modulate);
            Helpers.WriteInt64(Commands.CMD_DATA + 72, outline_size);
            Helpers.WriteDouble(Commands.CMD_DATA + 80, px_range);
            Helpers.WriteDouble(Commands.CMD_DATA + 88, scale);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_item_add_msdf_texture_rect_region__23__7__23__7__20__2__3__3__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_item_add_lcd_texture_rect_region(ulong item, Rect2 rect, ulong texture, Rect2 src_rect, Color modulate)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, item);
            Helpers.WriteRect2(Commands.CMD_DATA + 16, rect);
            Helpers.WriteRID(Commands.CMD_DATA + 32, texture);
            Helpers.WriteRect2(Commands.CMD_DATA + 40, src_rect);
            Helpers.WriteColor(Commands.CMD_DATA + 56, modulate);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_item_add_lcd_texture_rect_region__23__7__23__7__20__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_item_add_texture_rect_region(ulong item, Rect2 rect, ulong texture, Rect2 src_rect, Color modulate, bool transpose, bool clip_uv)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, item);
            Helpers.WriteRect2(Commands.CMD_DATA + 16, rect);
            Helpers.WriteRID(Commands.CMD_DATA + 32, texture);
            Helpers.WriteRect2(Commands.CMD_DATA + 40, src_rect);
            Helpers.WriteColor(Commands.CMD_DATA + 56, modulate);
            Helpers.WriteInt32(Commands.CMD_DATA + 72, transpose ? 1 : 0);
            Helpers.WriteInt32(Commands.CMD_DATA + 76, clip_uv ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_item_add_texture_rect_region__23__7__23__7__20__1__1__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_item_add_nine_patch(ulong item, Rect2 rect, Rect2 source, ulong texture, Vector2 topleft, Vector2 bottomright, long x_axis_mode, long y_axis_mode, bool draw_center, Color modulate)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, item);
            Helpers.WriteRect2(Commands.CMD_DATA + 16, rect);
            Helpers.WriteRect2(Commands.CMD_DATA + 32, source);
            Helpers.WriteRID(Commands.CMD_DATA + 48, texture);
            Helpers.WriteVector2(Commands.CMD_DATA + 56, topleft);
            Helpers.WriteVector2(Commands.CMD_DATA + 64, bottomright);
            Helpers.WriteInt64(Commands.CMD_DATA + 72, x_axis_mode);
            Helpers.WriteInt64(Commands.CMD_DATA + 80, y_axis_mode);
            Helpers.WriteInt32(Commands.CMD_DATA + 88, draw_center ? 1 : 0);
            Helpers.WriteColor(Commands.CMD_DATA + 92, modulate);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_item_add_nine_patch__23__7__7__23__5__5__2__2__1__20__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_item_add_primitive(ulong item, Vector2[] points, Color[] colors, Vector2[] uvs, ulong texture)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, item);
            Helpers.WritePackedVector2Array(Commands.CMD_DATA + 16, points);
            Helpers.WritePackedColorArray(Commands.CMD_DATA + 16, colors);
            Helpers.WritePackedVector2Array(Commands.CMD_DATA + 16, uvs);
            Helpers.WriteRID(Commands.CMD_DATA + 16, texture);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_item_add_primitive__23__35__37__35__23__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_item_add_polygon(ulong item, Vector2[] points, Color[] colors, Vector2[] uvs, ulong texture)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, item);
            Helpers.WritePackedVector2Array(Commands.CMD_DATA + 16, points);
            Helpers.WritePackedColorArray(Commands.CMD_DATA + 16, colors);
            Helpers.WritePackedVector2Array(Commands.CMD_DATA + 16, uvs);
            Helpers.WriteRID(Commands.CMD_DATA + 16, texture);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_item_add_polygon__23__35__37__35__23__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_item_add_triangle_array(ulong item, int[] indices, Vector2[] points, Color[] colors, Vector2[] uvs, int[] bones, float[] weights, ulong texture, long count)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, item);
            Helpers.WritePackedInt32Array(Commands.CMD_DATA + 16, indices);
            Helpers.WritePackedVector2Array(Commands.CMD_DATA + 16, points);
            Helpers.WritePackedColorArray(Commands.CMD_DATA + 16, colors);
            Helpers.WritePackedVector2Array(Commands.CMD_DATA + 16, uvs);
            Helpers.WritePackedInt32Array(Commands.CMD_DATA + 16, bones);
            Helpers.WritePackedFloat32Array(Commands.CMD_DATA + 16, weights);
            Helpers.WriteRID(Commands.CMD_DATA + 16 + 4 + (weights.Length * 4), texture);
            Helpers.WriteInt64(Commands.CMD_DATA + 16 + 4 + (weights.Length * 4) + 8, count);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_item_add_triangle_array__23__30__35__37__35__30__32__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_item_add_mesh(ulong item, ulong mesh, Transform2D transform, Color modulate, ulong texture)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, item);
            Helpers.WriteRID(Commands.CMD_DATA + 16, mesh);
            Helpers.WriteTransform2D(Commands.CMD_DATA + 24, transform);
            Helpers.WriteColor(Commands.CMD_DATA + 48, modulate);
            Helpers.WriteRID(Commands.CMD_DATA + 64, texture);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_item_add_mesh__23__23__11__20__23__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_item_add_multimesh(ulong item, ulong mesh, ulong texture)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, item);
            Helpers.WriteRID(Commands.CMD_DATA + 16, mesh);
            Helpers.WriteRID(Commands.CMD_DATA + 24, texture);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_item_add_multimesh__23__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_item_add_particles(ulong item, ulong particles, ulong texture)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, item);
            Helpers.WriteRID(Commands.CMD_DATA + 16, particles);
            Helpers.WriteRID(Commands.CMD_DATA + 24, texture);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_item_add_particles__23__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_item_add_set_transform(ulong item, Transform2D transform)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, item);
            Helpers.WriteTransform2D(Commands.CMD_DATA + 16, transform);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_item_add_set_transform__23__11__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_item_add_clip_ignore(ulong item, bool ignore)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, item);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, ignore ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_item_add_clip_ignore__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_item_add_animation_slice(ulong item, double animation_length, double slice_begin, double slice_end, double offset)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, item);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, animation_length);
            Helpers.WriteDouble(Commands.CMD_DATA + 24, slice_begin);
            Helpers.WriteDouble(Commands.CMD_DATA + 32, slice_end);
            Helpers.WriteDouble(Commands.CMD_DATA + 40, offset);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_item_add_animation_slice__23__3__3__3__3__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_item_set_sort_children_by_y(ulong item, bool enabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, item);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_item_set_sort_children_by_y__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_item_set_z_index(ulong item, long z_index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, item);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, z_index);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_item_set_z_index__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_item_set_z_as_relative_to_parent(ulong item, bool enabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, item);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_item_set_z_as_relative_to_parent__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_item_set_copy_to_backbuffer(ulong item, bool enabled, Rect2 rect)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, item);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enabled ? 1 : 0);
            Helpers.WriteRect2(Commands.CMD_DATA + 20, rect);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_item_set_copy_to_backbuffer__23__1__7__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_item_attach_skeleton(ulong item, ulong skeleton)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, item);
            Helpers.WriteRID(Commands.CMD_DATA + 16, skeleton);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_item_attach_skeleton__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_item_clear(ulong item)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, item);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_item_clear__23__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_item_set_draw_index(ulong item, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, item);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, index);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_item_set_draw_index__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_item_set_material(ulong item, ulong material)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, item);
            Helpers.WriteRID(Commands.CMD_DATA + 16, material);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_item_set_material__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_item_set_use_parent_material(ulong item, bool enabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, item);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_item_set_use_parent_material__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_item_set_instance_shader_parameter(ulong instance, string parameter, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, instance);
            Helpers.WriteStringName(Commands.CMD_DATA + 16, parameter);
            Helpers.WriteVariant(Commands.CMD_DATA + 1044, value);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_item_set_instance_shader_parameter__23__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_item_get_instance_shader_parameter(ulong instance, string parameter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, instance);
            Helpers.WriteStringName(Commands.CMD_DATA + 16, parameter);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_item_get_instance_shader_parameter__23__21__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_item_get_instance_shader_parameter_default_value(ulong instance, string parameter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, instance);
            Helpers.WriteStringName(Commands.CMD_DATA + 16, parameter);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_item_get_instance_shader_parameter_default_value__23__21__r0);
            Helpers.WaitForCompletion();
        }

        public object canvas_item_get_instance_shader_parameter_list(ulong instance)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, instance);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_item_get_instance_shader_parameter_list__23__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void canvas_item_set_visibility_notifier(ulong item, bool enable, Rect2 area, object enter_callable, object exit_callable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, item);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enable ? 1 : 0);
            Helpers.WriteRect2(Commands.CMD_DATA + 20, area);
            Helpers.WriteCallable(Commands.CMD_DATA + 36, enter_callable);
            Helpers.WriteCallable(Commands.CMD_DATA + 36, exit_callable);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_item_set_visibility_notifier__23__1__7__25__25__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_item_set_canvas_group_mode(ulong item, long mode, double clear_margin, bool fit_empty, double fit_margin, bool blur_mipmaps)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, item);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, mode);
            Helpers.WriteDouble(Commands.CMD_DATA + 24, clear_margin);
            Helpers.WriteInt32(Commands.CMD_DATA + 32, fit_empty ? 1 : 0);
            Helpers.WriteDouble(Commands.CMD_DATA + 36, fit_margin);
            Helpers.WriteInt32(Commands.CMD_DATA + 44, blur_mipmaps ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_item_set_canvas_group_mode__23__2__3__1__3__1__r0);
            Helpers.WaitForCompletion();
        }

        public Rect2 debug_canvas_item_get_rect(ulong item)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, item);
            Helpers.SendCommand(Commands.CMD_RenderingServer_debug_canvas_item_get_rect__23__r7);
            Helpers.WaitForCompletion();
            Rect2 result = Helpers.ReadRect2(Commands.CMD_DATA);
            return result;
        }

        public ulong canvas_light_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_light_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void canvas_light_attach_to_canvas(ulong light, ulong canvas)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, light);
            Helpers.WriteRID(Commands.CMD_DATA + 16, canvas);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_light_attach_to_canvas__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_light_set_enabled(ulong light, bool enabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, light);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_light_set_enabled__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_light_set_texture_scale(ulong light, double scale)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, light);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, scale);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_light_set_texture_scale__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_light_set_transform(ulong light, Transform2D transform)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, light);
            Helpers.WriteTransform2D(Commands.CMD_DATA + 16, transform);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_light_set_transform__23__11__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_light_set_texture(ulong light, ulong texture)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, light);
            Helpers.WriteRID(Commands.CMD_DATA + 16, texture);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_light_set_texture__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_light_set_texture_offset(ulong light, Vector2 offset)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, light);
            Helpers.WriteVector2(Commands.CMD_DATA + 16, offset);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_light_set_texture_offset__23__5__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_light_set_color(ulong light, Color color)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, light);
            Helpers.WriteColor(Commands.CMD_DATA + 16, color);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_light_set_color__23__20__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_light_set_height(ulong light, double height)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, light);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, height);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_light_set_height__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_light_set_energy(ulong light, double energy)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, light);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, energy);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_light_set_energy__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_light_set_z_range(ulong light, long min_z, long max_z)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, light);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, min_z);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, max_z);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_light_set_z_range__23__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_light_set_layer_range(ulong light, long min_layer, long max_layer)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, light);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, min_layer);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, max_layer);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_light_set_layer_range__23__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_light_set_item_cull_mask(ulong light, long mask)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, light);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, mask);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_light_set_item_cull_mask__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_light_set_item_shadow_cull_mask(ulong light, long mask)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, light);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, mask);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_light_set_item_shadow_cull_mask__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_light_set_mode(ulong light, long mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, light);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, mode);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_light_set_mode__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_light_set_shadow_enabled(ulong light, bool enabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, light);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_light_set_shadow_enabled__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_light_set_shadow_filter(ulong light, long filter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, light);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, filter);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_light_set_shadow_filter__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_light_set_shadow_color(ulong light, Color color)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, light);
            Helpers.WriteColor(Commands.CMD_DATA + 16, color);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_light_set_shadow_color__23__20__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_light_set_shadow_smooth(ulong light, double smooth)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, light);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, smooth);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_light_set_shadow_smooth__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_light_set_blend_mode(ulong light, long mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, light);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, mode);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_light_set_blend_mode__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_light_set_interpolated(ulong light, bool interpolated)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, light);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, interpolated ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_light_set_interpolated__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_light_reset_physics_interpolation(ulong light)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, light);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_light_reset_physics_interpolation__23__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_light_transform_physics_interpolation(ulong light, Transform2D transform)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, light);
            Helpers.WriteTransform2D(Commands.CMD_DATA + 16, transform);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_light_transform_physics_interpolation__23__11__r0);
            Helpers.WaitForCompletion();
        }

        public ulong canvas_light_occluder_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_light_occluder_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void canvas_light_occluder_attach_to_canvas(ulong occluder, ulong canvas)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, occluder);
            Helpers.WriteRID(Commands.CMD_DATA + 16, canvas);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_light_occluder_attach_to_canvas__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_light_occluder_set_enabled(ulong occluder, bool enabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, occluder);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_light_occluder_set_enabled__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_light_occluder_set_polygon(ulong occluder, ulong polygon)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, occluder);
            Helpers.WriteRID(Commands.CMD_DATA + 16, polygon);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_light_occluder_set_polygon__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_light_occluder_set_as_sdf_collision(ulong occluder, bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, occluder);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_light_occluder_set_as_sdf_collision__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_light_occluder_set_transform(ulong occluder, Transform2D transform)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, occluder);
            Helpers.WriteTransform2D(Commands.CMD_DATA + 16, transform);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_light_occluder_set_transform__23__11__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_light_occluder_set_light_mask(ulong occluder, long mask)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, occluder);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, mask);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_light_occluder_set_light_mask__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_light_occluder_set_interpolated(ulong occluder, bool interpolated)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, occluder);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, interpolated ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_light_occluder_set_interpolated__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_light_occluder_reset_physics_interpolation(ulong occluder)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, occluder);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_light_occluder_reset_physics_interpolation__23__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_light_occluder_transform_physics_interpolation(ulong occluder, Transform2D transform)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, occluder);
            Helpers.WriteTransform2D(Commands.CMD_DATA + 16, transform);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_light_occluder_transform_physics_interpolation__23__11__r0);
            Helpers.WaitForCompletion();
        }

        public ulong canvas_occluder_polygon_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_occluder_polygon_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void canvas_occluder_polygon_set_shape(ulong occluder_polygon, Vector2[] shape, bool closed)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, occluder_polygon);
            Helpers.WritePackedVector2Array(Commands.CMD_DATA + 16, shape);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, closed ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_occluder_polygon_set_shape__23__35__1__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_occluder_polygon_set_cull_mode(ulong occluder_polygon, long mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, occluder_polygon);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, mode);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_occluder_polygon_set_cull_mode__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void canvas_set_shadow_texture_size(long size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, size);
            Helpers.SendCommand(Commands.CMD_RenderingServer_canvas_set_shadow_texture_size__2__r0);
            Helpers.WaitForCompletion();
        }

        public void global_shader_parameter_add(string name, long type, object default_value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteInt64(Commands.CMD_DATA + 1036, type);
            Helpers.WriteVariant(Commands.CMD_DATA + 1044, default_value);
            Helpers.SendCommand(Commands.CMD_RenderingServer_global_shader_parameter_add__21__2__0__r0);
            Helpers.WaitForCompletion();
        }

        public void global_shader_parameter_remove(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_RenderingServer_global_shader_parameter_remove__21__r0);
            Helpers.WaitForCompletion();
        }

        public object global_shader_parameter_get_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_global_shader_parameter_get_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void global_shader_parameter_set(string name, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_RenderingServer_global_shader_parameter_set__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void global_shader_parameter_set_override(string name, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_RenderingServer_global_shader_parameter_set_override__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void global_shader_parameter_get(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_RenderingServer_global_shader_parameter_get__21__r0);
            Helpers.WaitForCompletion();
        }

        public long global_shader_parameter_get_type(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_RenderingServer_global_shader_parameter_get_type__21__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void free_rid(ulong rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.SendCommand(Commands.CMD_RenderingServer_free_rid__23__r0);
            Helpers.WaitForCompletion();
        }

        public void request_frame_drawn_callback(object callable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteCallable(Commands.CMD_DATA + 8, callable);
            Helpers.SendCommand(Commands.CMD_RenderingServer_request_frame_drawn_callback__25__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_changed()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_has_changed__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public long get_rendering_info(long info)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, info);
            Helpers.SendCommand(Commands.CMD_RenderingServer_get_rendering_info__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public string get_video_adapter_name()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_get_video_adapter_name__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public string get_video_adapter_vendor()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_get_video_adapter_vendor__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public long get_video_adapter_type()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_get_video_adapter_type__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public string get_video_adapter_api_version()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_get_video_adapter_api_version__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public string get_current_rendering_driver_name()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_get_current_rendering_driver_name__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public string get_current_rendering_method()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_get_current_rendering_method__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public ulong make_sphere_mesh(long latitudes, long longitudes, double radius)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, latitudes);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, longitudes);
            Helpers.WriteDouble(Commands.CMD_DATA + 24, radius);
            Helpers.SendCommand(Commands.CMD_RenderingServer_make_sphere_mesh__2__2__3__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public ulong get_test_cube()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_get_test_cube__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public ulong get_test_texture()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_get_test_texture__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public ulong get_white_texture()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_get_white_texture__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void set_boot_image_with_stretch(ulong image, Color color, long stretch_mode, bool use_filter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, image);
            Helpers.WriteColor(Commands.CMD_DATA + 16, color);
            Helpers.WriteInt64(Commands.CMD_DATA + 32, stretch_mode);
            Helpers.WriteInt32(Commands.CMD_DATA + 40, use_filter ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_set_boot_image_with_stretch__24__20__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public void set_boot_image(ulong image, Color color, bool scale, bool use_filter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, image);
            Helpers.WriteColor(Commands.CMD_DATA + 16, color);
            Helpers.WriteInt32(Commands.CMD_DATA + 32, scale ? 1 : 0);
            Helpers.WriteInt32(Commands.CMD_DATA + 36, use_filter ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_set_boot_image__24__20__1__1__r0);
            Helpers.WaitForCompletion();
        }

        public Color get_default_clear_color()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_get_default_clear_color__r20);
            Helpers.WaitForCompletion();
            Color result = Helpers.ReadColor(Commands.CMD_DATA);
            return result;
        }

        public void set_default_clear_color(Color color)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteColor(Commands.CMD_DATA + 8, color);
            Helpers.SendCommand(Commands.CMD_RenderingServer_set_default_clear_color__20__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_os_feature(string feature)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, feature);
            Helpers.SendCommand(Commands.CMD_RenderingServer_has_os_feature__4__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_debug_generate_wireframes(bool generate)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, generate ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_set_debug_generate_wireframes__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_render_loop_enabled()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_is_render_loop_enabled__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_render_loop_enabled(bool enabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_set_render_loop_enabled__1__r0);
            Helpers.WaitForCompletion();
        }

        public double get_frame_setup_time_cpu()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_get_frame_setup_time_cpu__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void force_sync()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_force_sync__r0);
            Helpers.WaitForCompletion();
        }

        public void force_draw(bool swap_buffers, double frame_step)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, swap_buffers ? 1 : 0);
            Helpers.WriteDouble(Commands.CMD_DATA + 12, frame_step);
            Helpers.SendCommand(Commands.CMD_RenderingServer_force_draw__1__3__r0);
            Helpers.WaitForCompletion();
        }

        public ulong get_rendering_device()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_get_rendering_device__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong create_local_rendering_device()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_create_local_rendering_device__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public bool is_on_render_thread()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_is_on_render_thread__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void call_on_render_thread(object callable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteCallable(Commands.CMD_DATA + 8, callable);
            Helpers.SendCommand(Commands.CMD_RenderingServer_call_on_render_thread__25__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_feature(long feature)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, feature);
            Helpers.SendCommand(Commands.CMD_RenderingServer_has_feature__2__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void free()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_free__r0);
            Helpers.WaitForCompletion();
        }

        public void _init()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer__init__r0);
            Helpers.WaitForCompletion();
        }

        public string _to_string()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer__to_string__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void _notification(long what)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, what);
            Helpers.SendCommand(Commands.CMD_RenderingServer__notification__2__r0);
            Helpers.WaitForCompletion();
        }

        public bool _set(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_RenderingServer__set__21__0__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _get(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_RenderingServer__get__21__r0);
            Helpers.WaitForCompletion();
        }

        public object _get_property_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer__get_property_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void _validate_property(object property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDictionary(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_RenderingServer__validate_property__27__r0);
            Helpers.WaitForCompletion();
        }

        public bool _property_can_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_RenderingServer__property_can_revert__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _property_get_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_RenderingServer__property_get_revert__21__r0);
            Helpers.WaitForCompletion();
        }

        public bool _iter_init(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteArray(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_RenderingServer__iter_init__28__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool _iter_next(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteArray(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_RenderingServer__iter_next__28__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _iter_get(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVariant(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_RenderingServer__iter_get__0__r0);
            Helpers.WaitForCompletion();
        }

        public string get_class()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_get_class__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public bool is_class(string class_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, class_);
            Helpers.SendCommand(Commands.CMD_RenderingServer_is_class__4__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_RenderingServer_set__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_RenderingServer_get__21__r0);
            Helpers.WaitForCompletion();
        }

        public void set_indexed(string property_path, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, property_path);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_RenderingServer_set_indexed__22__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get_indexed(string property_path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, property_path);
            Helpers.SendCommand(Commands.CMD_RenderingServer_get_indexed__22__r0);
            Helpers.WaitForCompletion();
        }

        public object get_property_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_get_property_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_method_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_get_method_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public bool property_can_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_RenderingServer_property_can_revert__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void property_get_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_RenderingServer_property_get_revert__21__r0);
            Helpers.WaitForCompletion();
        }

        public void notification(long what, bool reversed)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, what);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, reversed ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_notification__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public string to_string()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_to_string__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public ulong get_instance_id()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_get_instance_id__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_script(object script)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVariant(Commands.CMD_DATA + 8, script);
            Helpers.SendCommand(Commands.CMD_RenderingServer_set_script__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get_script()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_get_script__r0);
            Helpers.WaitForCompletion();
        }

        public void set_meta(string name, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_RenderingServer_set_meta__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void remove_meta(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_RenderingServer_remove_meta__21__r0);
            Helpers.WaitForCompletion();
        }

        public void get_meta(string name, object default_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, default_);
            Helpers.SendCommand(Commands.CMD_RenderingServer_get_meta__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_meta(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_RenderingServer_has_meta__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public object get_meta_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_get_meta_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void add_user_signal(string signal, object arguments)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, signal);
            Helpers.WriteArray(Commands.CMD_DATA + 1036, arguments);
            Helpers.SendCommand(Commands.CMD_RenderingServer_add_user_signal__4__28__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_user_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_RenderingServer_has_user_signal__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void remove_user_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_RenderingServer_remove_user_signal__21__r0);
            Helpers.WaitForCompletion();
        }

        public long emit_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_RenderingServer_emit_signal__21__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void call(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_RenderingServer_call__21__r0);
            Helpers.WaitForCompletion();
        }

        public void call_deferred(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_RenderingServer_call_deferred__21__r0);
            Helpers.WaitForCompletion();
        }

        public void set_deferred(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_RenderingServer_set_deferred__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void callv(string method, object arg_array)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.WriteArray(Commands.CMD_DATA + 1036, arg_array);
            Helpers.SendCommand(Commands.CMD_RenderingServer_callv__21__28__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_method(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_RenderingServer_has_method__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public long get_method_argument_count(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_RenderingServer_get_method_argument_count__21__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool has_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_RenderingServer_has_signal__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public object get_signal_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_get_signal_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_signal_connection_list(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_RenderingServer_get_signal_connection_list__21__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_incoming_connections()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_get_incoming_connections__r28);
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
            Helpers.SendCommand(Commands.CMD_RenderingServer_connect__21__25__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void disconnect(string signal, object callable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.WriteCallable(Commands.CMD_DATA + 1036, callable);
            Helpers.SendCommand(Commands.CMD_RenderingServer_disconnect__21__25__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_connected(string signal, object callable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.WriteCallable(Commands.CMD_DATA + 1036, callable);
            Helpers.SendCommand(Commands.CMD_RenderingServer_is_connected__21__25__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool has_connections(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_RenderingServer_has_connections__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_block_signals(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_set_block_signals__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_blocking_signals()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_is_blocking_signals__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void notify_property_list_changed()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_notify_property_list_changed__r0);
            Helpers.WaitForCompletion();
        }

        public void set_message_translation(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RenderingServer_set_message_translation__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool can_translate_messages()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_can_translate_messages__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public string tr(string message, string context)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, message);
            Helpers.WriteStringName(Commands.CMD_DATA + 1036, context);
            Helpers.SendCommand(Commands.CMD_RenderingServer_tr__21__21__r4);
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
            Helpers.SendCommand(Commands.CMD_RenderingServer_tr_n__21__21__2__21__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public string get_translation_domain()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_get_translation_domain__r21);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadStringName(Commands.CMD_DATA);
            return result;
        }

        public void set_translation_domain(string domain)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, domain);
            Helpers.SendCommand(Commands.CMD_RenderingServer_set_translation_domain__21__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_queued_for_deletion()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_is_queued_for_deletion__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void cancel_free()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_cancel_free__r0);
            Helpers.WaitForCompletion();
        }

        public ulong get_singleton()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RenderingServer_get_singleton__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

    }
}
