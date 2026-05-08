using System;

namespace GodotWeb
{
    public class ArrayMesh : GodotObject
    {
        public ArrayMesh(ulong id) : base(id) { }

        public void add_blend_shape(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_add_blend_shape__21__r0);
            Helpers.WaitForCompletion();
        }

        public long get_blend_shape_count()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_get_blend_shape_count__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public string get_blend_shape_name(long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, index);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_get_blend_shape_name__2__r21);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadStringName(Commands.CMD_DATA);
            return result;
        }

        public void set_blend_shape_name(long index, string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, index);
            Helpers.WriteStringName(Commands.CMD_DATA + 16, name);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_set_blend_shape_name__2__21__r0);
            Helpers.WaitForCompletion();
        }

        public void clear_blend_shapes()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_clear_blend_shapes__r0);
            Helpers.WaitForCompletion();
        }

        public void set_blend_shape_mode(long mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, mode);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_set_blend_shape_mode__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_blend_shape_mode()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_get_blend_shape_mode__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void add_surface_from_arrays(long primitive, object arrays, object blend_shapes, object lods, long flags)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, primitive);
            Helpers.WriteArray(Commands.CMD_DATA + 16, arrays);
            Helpers.WriteArray(Commands.CMD_DATA + 16, blend_shapes);
            Helpers.WriteDictionary(Commands.CMD_DATA + 16, lods);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, flags);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_add_surface_from_arrays__2__28__28__27__2__r0);
            Helpers.WaitForCompletion();
        }

        public void clear_surfaces()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_clear_surfaces__r0);
            Helpers.WaitForCompletion();
        }

        public void surface_remove(long surf_idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, surf_idx);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_surface_remove__2__r0);
            Helpers.WaitForCompletion();
        }

        public void surface_update_vertex_region(long surf_idx, long offset, byte[] arg_data)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, surf_idx);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, offset);
            Helpers.WritePackedByteArray(Commands.CMD_DATA + 24, arg_data);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_surface_update_vertex_region__2__2__29__r0);
            Helpers.WaitForCompletion();
        }

        public void surface_update_attribute_region(long surf_idx, long offset, byte[] arg_data)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, surf_idx);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, offset);
            Helpers.WritePackedByteArray(Commands.CMD_DATA + 24, arg_data);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_surface_update_attribute_region__2__2__29__r0);
            Helpers.WaitForCompletion();
        }

        public void surface_update_skin_region(long surf_idx, long offset, byte[] arg_data)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, surf_idx);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, offset);
            Helpers.WritePackedByteArray(Commands.CMD_DATA + 24, arg_data);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_surface_update_skin_region__2__2__29__r0);
            Helpers.WaitForCompletion();
        }

        public long surface_get_array_len(long surf_idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, surf_idx);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_surface_get_array_len__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long surface_get_array_index_len(long surf_idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, surf_idx);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_surface_get_array_index_len__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long surface_get_format(long surf_idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, surf_idx);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_surface_get_format__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long surface_get_primitive_type(long surf_idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, surf_idx);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_surface_get_primitive_type__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long surface_find_by_name(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_surface_find_by_name__4__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void surface_set_name(long surf_idx, string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, surf_idx);
            Helpers.WriteString(Commands.CMD_DATA + 16, name);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_surface_set_name__2__4__r0);
            Helpers.WaitForCompletion();
        }

        public string surface_get_name(long surf_idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, surf_idx);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_surface_get_name__2__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void regen_normal_maps()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_regen_normal_maps__r0);
            Helpers.WaitForCompletion();
        }

        public long lightmap_unwrap(Transform3D transform, double texel_size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteTransform3D(Commands.CMD_DATA + 8, transform);
            Helpers.WriteDouble(Commands.CMD_DATA + 56, texel_size);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_lightmap_unwrap__18__3__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_custom_aabb(AABB aabb)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteAABB(Commands.CMD_DATA + 8, aabb);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_set_custom_aabb__16__r0);
            Helpers.WaitForCompletion();
        }

        public AABB get_custom_aabb()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_get_custom_aabb__r16);
            Helpers.WaitForCompletion();
            AABB result = Helpers.ReadAABB(Commands.CMD_DATA);
            return result;
        }

        public void set_shadow_mesh(ulong mesh)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, mesh);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_set_shadow_mesh__24__r0);
            Helpers.WaitForCompletion();
        }

        public ulong get_shadow_mesh()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_get_shadow_mesh__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void _set_blend_shape_names(string[] blend_shape_names)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WritePackedStringArray(Commands.CMD_DATA + 8, blend_shape_names);
            Helpers.SendCommand(Commands.CMD_ArrayMesh__set_blend_shape_names__34__r0);
            Helpers.WaitForCompletion();
        }

        public string[] _get_blend_shape_names()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ArrayMesh__get_blend_shape_names__r34);
            Helpers.WaitForCompletion();
            string[] result = Helpers.ReadPackedStringArray(Commands.CMD_DATA);
            return result;
        }

        public void _set_surfaces(object surfaces)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteArray(Commands.CMD_DATA + 8, surfaces);
            Helpers.SendCommand(Commands.CMD_ArrayMesh__set_surfaces__28__r0);
            Helpers.WaitForCompletion();
        }

        public object _get_surfaces()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ArrayMesh__get_surfaces__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public long _get_surface_count()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ArrayMesh__get_surface_count__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long _surface_get_array_len(long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, index);
            Helpers.SendCommand(Commands.CMD_ArrayMesh__surface_get_array_len__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long _surface_get_array_index_len(long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, index);
            Helpers.SendCommand(Commands.CMD_ArrayMesh__surface_get_array_index_len__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public object _surface_get_arrays(long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, index);
            Helpers.SendCommand(Commands.CMD_ArrayMesh__surface_get_arrays__2__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object _surface_get_blend_shape_arrays(long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, index);
            Helpers.SendCommand(Commands.CMD_ArrayMesh__surface_get_blend_shape_arrays__2__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object _surface_get_lods(long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, index);
            Helpers.SendCommand(Commands.CMD_ArrayMesh__surface_get_lods__2__r27);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadDictionary(Commands.CMD_DATA);
            return result;
        }

        public long _surface_get_format(long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, index);
            Helpers.SendCommand(Commands.CMD_ArrayMesh__surface_get_format__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long _surface_get_primitive_type(long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, index);
            Helpers.SendCommand(Commands.CMD_ArrayMesh__surface_get_primitive_type__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void _surface_set_material(long index, ulong material)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, index);
            Helpers.WriteUInt64(Commands.CMD_DATA + 16, material);
            Helpers.SendCommand(Commands.CMD_ArrayMesh__surface_set_material__2__24__r0);
            Helpers.WaitForCompletion();
        }

        public ulong _surface_get_material(long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, index);
            Helpers.SendCommand(Commands.CMD_ArrayMesh__surface_get_material__2__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public long _get_blend_shape_count()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ArrayMesh__get_blend_shape_count__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public string _get_blend_shape_name(long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, index);
            Helpers.SendCommand(Commands.CMD_ArrayMesh__get_blend_shape_name__2__r21);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadStringName(Commands.CMD_DATA);
            return result;
        }

        public void _set_blend_shape_name(long index, string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, index);
            Helpers.WriteStringName(Commands.CMD_DATA + 16, name);
            Helpers.SendCommand(Commands.CMD_ArrayMesh__set_blend_shape_name__2__21__r0);
            Helpers.WaitForCompletion();
        }

        public AABB _get_aabb()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ArrayMesh__get_aabb__r16);
            Helpers.WaitForCompletion();
            AABB result = Helpers.ReadAABB(Commands.CMD_DATA);
            return result;
        }

        public void set_lightmap_size_hint(Vector2i size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2i(Commands.CMD_DATA + 8, size);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_set_lightmap_size_hint__6__r0);
            Helpers.WaitForCompletion();
        }

        public Vector2i get_lightmap_size_hint()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_get_lightmap_size_hint__r6);
            Helpers.WaitForCompletion();
            Vector2i result = Helpers.ReadVector2i(Commands.CMD_DATA);
            return result;
        }

        public AABB get_aabb()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_get_aabb__r16);
            Helpers.WaitForCompletion();
            AABB result = Helpers.ReadAABB(Commands.CMD_DATA);
            return result;
        }

        public Vector3[] get_faces()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_get_faces__r36);
            Helpers.WaitForCompletion();
            Vector3[] result = Helpers.ReadPackedVector3Array(Commands.CMD_DATA);
            return result;
        }

        public long get_surface_count()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_get_surface_count__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public object surface_get_arrays(long surf_idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, surf_idx);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_surface_get_arrays__2__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object surface_get_blend_shape_arrays(long surf_idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, surf_idx);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_surface_get_blend_shape_arrays__2__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void surface_set_material(long surf_idx, ulong material)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, surf_idx);
            Helpers.WriteUInt64(Commands.CMD_DATA + 16, material);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_surface_set_material__2__24__r0);
            Helpers.WaitForCompletion();
        }

        public ulong surface_get_material(long surf_idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, surf_idx);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_surface_get_material__2__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong create_placeholder()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_create_placeholder__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong create_trimesh_shape()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_create_trimesh_shape__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong create_convex_shape(bool clean, bool simplify)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, clean ? 1 : 0);
            Helpers.WriteInt32(Commands.CMD_DATA + 12, simplify ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_create_convex_shape__1__1__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong create_outline(double margin)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDouble(Commands.CMD_DATA + 8, margin);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_create_outline__3__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong generate_triangle_mesh()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_generate_triangle_mesh__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void _setup_local_to_scene()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ArrayMesh__setup_local_to_scene__r0);
            Helpers.WaitForCompletion();
        }

        public ulong _get_rid()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ArrayMesh__get_rid__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void _reset_state()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ArrayMesh__reset_state__r0);
            Helpers.WaitForCompletion();
        }

        public void _set_path_cache(string path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, path);
            Helpers.SendCommand(Commands.CMD_ArrayMesh__set_path_cache__4__r0);
            Helpers.WaitForCompletion();
        }

        public void set_path(string path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, path);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_set_path__4__r0);
            Helpers.WaitForCompletion();
        }

        public void take_over_path(string path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, path);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_take_over_path__4__r0);
            Helpers.WaitForCompletion();
        }

        public string get_path()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_get_path__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void set_path_cache(string path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, path);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_set_path_cache__4__r0);
            Helpers.WaitForCompletion();
        }

        public void set_name(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_set_name__4__r0);
            Helpers.WaitForCompletion();
        }

        public string get_name()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_get_name__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public ulong get_rid()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_get_rid__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void set_local_to_scene(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_set_local_to_scene__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_local_to_scene()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_is_local_to_scene__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public ulong get_local_scene()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_get_local_scene__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void setup_local_to_scene()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_setup_local_to_scene__r0);
            Helpers.WaitForCompletion();
        }

        public void reset_state()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_reset_state__r0);
            Helpers.WaitForCompletion();
        }

        public void set_id_for_path(string path, string id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, path);
            Helpers.WriteString(Commands.CMD_DATA + 1036, id);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_set_id_for_path__4__4__r0);
            Helpers.WaitForCompletion();
        }

        public string get_id_for_path(string path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, path);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_get_id_for_path__4__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public bool is_built_in()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_is_built_in__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public string generate_scene_unique_id()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_generate_scene_unique_id__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void set_scene_unique_id(string id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, id);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_set_scene_unique_id__4__r0);
            Helpers.WaitForCompletion();
        }

        public string get_scene_unique_id()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_get_scene_unique_id__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void emit_changed()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_emit_changed__r0);
            Helpers.WaitForCompletion();
        }

        public ulong duplicate(bool deep)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, deep ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_duplicate__1__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong duplicate_deep(long deep_subresources_mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, deep_subresources_mode);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_duplicate_deep__2__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public bool init_ref()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_init_ref__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool reference()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_reference__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool unreference()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_unreference__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public long get_reference_count()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_get_reference_count__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void free()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_free__r0);
            Helpers.WaitForCompletion();
        }

        public void _init()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ArrayMesh__init__r0);
            Helpers.WaitForCompletion();
        }

        public string _to_string()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ArrayMesh__to_string__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void _notification(long what)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, what);
            Helpers.SendCommand(Commands.CMD_ArrayMesh__notification__2__r0);
            Helpers.WaitForCompletion();
        }

        public bool _set(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_ArrayMesh__set__21__0__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _get(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_ArrayMesh__get__21__r0);
            Helpers.WaitForCompletion();
        }

        public object _get_property_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ArrayMesh__get_property_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void _validate_property(object property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDictionary(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_ArrayMesh__validate_property__27__r0);
            Helpers.WaitForCompletion();
        }

        public bool _property_can_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_ArrayMesh__property_can_revert__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _property_get_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_ArrayMesh__property_get_revert__21__r0);
            Helpers.WaitForCompletion();
        }

        public bool _iter_init(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteArray(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_ArrayMesh__iter_init__28__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool _iter_next(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteArray(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_ArrayMesh__iter_next__28__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _iter_get(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVariant(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_ArrayMesh__iter_get__0__r0);
            Helpers.WaitForCompletion();
        }

        public string get_class()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_get_class__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public bool is_class(string class_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, class_);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_is_class__4__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_set__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_get__21__r0);
            Helpers.WaitForCompletion();
        }

        public void set_indexed(string property_path, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, property_path);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_set_indexed__22__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get_indexed(string property_path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, property_path);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_get_indexed__22__r0);
            Helpers.WaitForCompletion();
        }

        public object get_property_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_get_property_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_method_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_get_method_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public bool property_can_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_property_can_revert__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void property_get_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_property_get_revert__21__r0);
            Helpers.WaitForCompletion();
        }

        public void notification(long what, bool reversed)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, what);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, reversed ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_notification__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public string to_string()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_to_string__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public ulong get_instance_id()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_get_instance_id__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_script(object script)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVariant(Commands.CMD_DATA + 8, script);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_set_script__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get_script()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_get_script__r0);
            Helpers.WaitForCompletion();
        }

        public void set_meta(string name, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_set_meta__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void remove_meta(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_remove_meta__21__r0);
            Helpers.WaitForCompletion();
        }

        public void get_meta(string name, object default_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, default_);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_get_meta__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_meta(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_has_meta__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public object get_meta_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_get_meta_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void add_user_signal(string signal, object arguments)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, signal);
            Helpers.WriteArray(Commands.CMD_DATA + 1036, arguments);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_add_user_signal__4__28__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_user_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_has_user_signal__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void remove_user_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_remove_user_signal__21__r0);
            Helpers.WaitForCompletion();
        }

        public long emit_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_emit_signal__21__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void call(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_call__21__r0);
            Helpers.WaitForCompletion();
        }

        public void call_deferred(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_call_deferred__21__r0);
            Helpers.WaitForCompletion();
        }

        public void set_deferred(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_set_deferred__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void callv(string method, object arg_array)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.WriteArray(Commands.CMD_DATA + 1036, arg_array);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_callv__21__28__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_method(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_has_method__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public long get_method_argument_count(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_get_method_argument_count__21__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool has_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_has_signal__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public object get_signal_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_get_signal_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_signal_connection_list(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_get_signal_connection_list__21__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_incoming_connections()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_get_incoming_connections__r28);
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
            Helpers.SendCommand(Commands.CMD_ArrayMesh_connect__21__25__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void disconnect(string signal, object callable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.WriteCallable(Commands.CMD_DATA + 1036, callable);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_disconnect__21__25__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_connected(string signal, object callable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.WriteCallable(Commands.CMD_DATA + 1036, callable);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_is_connected__21__25__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool has_connections(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_has_connections__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_block_signals(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_set_block_signals__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_blocking_signals()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_is_blocking_signals__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void notify_property_list_changed()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_notify_property_list_changed__r0);
            Helpers.WaitForCompletion();
        }

        public void set_message_translation(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_set_message_translation__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool can_translate_messages()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_can_translate_messages__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public string tr(string message, string context)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, message);
            Helpers.WriteStringName(Commands.CMD_DATA + 1036, context);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_tr__21__21__r4);
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
            Helpers.SendCommand(Commands.CMD_ArrayMesh_tr_n__21__21__2__21__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public string get_translation_domain()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_get_translation_domain__r21);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadStringName(Commands.CMD_DATA);
            return result;
        }

        public void set_translation_domain(string domain)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, domain);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_set_translation_domain__21__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_queued_for_deletion()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_is_queued_for_deletion__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void cancel_free()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ArrayMesh_cancel_free__r0);
            Helpers.WaitForCompletion();
        }

    }
}
