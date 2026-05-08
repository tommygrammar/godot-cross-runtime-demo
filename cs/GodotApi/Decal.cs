using System;

namespace GodotWeb
{
    public class Decal : GodotObject
    {
        public Decal(ulong id) : base(id) { }

        public void set_size(Vector3 size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector3(Commands.CMD_DATA + 8, size);
            Helpers.SendCommand(Commands.CMD_Decal_set_size__9__r0);
            Helpers.WaitForCompletion();
        }

        public Vector3 get_size()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_size__r9);
            Helpers.WaitForCompletion();
            Vector3 result = Helpers.ReadVector3(Commands.CMD_DATA);
            return result;
        }

        public void set_texture(long type, ulong texture)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, type);
            Helpers.WriteUInt64(Commands.CMD_DATA + 16, texture);
            Helpers.SendCommand(Commands.CMD_Decal_set_texture__2__24__r0);
            Helpers.WaitForCompletion();
        }

        public ulong get_texture(long type)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, type);
            Helpers.SendCommand(Commands.CMD_Decal_get_texture__2__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_emission_energy(double energy)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDouble(Commands.CMD_DATA + 8, energy);
            Helpers.SendCommand(Commands.CMD_Decal_set_emission_energy__3__r0);
            Helpers.WaitForCompletion();
        }

        public double get_emission_energy()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_emission_energy__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void set_albedo_mix(double energy)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDouble(Commands.CMD_DATA + 8, energy);
            Helpers.SendCommand(Commands.CMD_Decal_set_albedo_mix__3__r0);
            Helpers.WaitForCompletion();
        }

        public double get_albedo_mix()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_albedo_mix__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void set_modulate(Color color)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteColor(Commands.CMD_DATA + 8, color);
            Helpers.SendCommand(Commands.CMD_Decal_set_modulate__20__r0);
            Helpers.WaitForCompletion();
        }

        public Color get_modulate()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_modulate__r20);
            Helpers.WaitForCompletion();
            Color result = Helpers.ReadColor(Commands.CMD_DATA);
            return result;
        }

        public void set_upper_fade(double fade)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDouble(Commands.CMD_DATA + 8, fade);
            Helpers.SendCommand(Commands.CMD_Decal_set_upper_fade__3__r0);
            Helpers.WaitForCompletion();
        }

        public double get_upper_fade()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_upper_fade__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void set_lower_fade(double fade)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDouble(Commands.CMD_DATA + 8, fade);
            Helpers.SendCommand(Commands.CMD_Decal_set_lower_fade__3__r0);
            Helpers.WaitForCompletion();
        }

        public double get_lower_fade()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_lower_fade__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void set_normal_fade(double fade)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDouble(Commands.CMD_DATA + 8, fade);
            Helpers.SendCommand(Commands.CMD_Decal_set_normal_fade__3__r0);
            Helpers.WaitForCompletion();
        }

        public double get_normal_fade()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_normal_fade__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void set_enable_distance_fade(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Decal_set_enable_distance_fade__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_distance_fade_enabled()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_is_distance_fade_enabled__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_distance_fade_begin(double distance)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDouble(Commands.CMD_DATA + 8, distance);
            Helpers.SendCommand(Commands.CMD_Decal_set_distance_fade_begin__3__r0);
            Helpers.WaitForCompletion();
        }

        public double get_distance_fade_begin()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_distance_fade_begin__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void set_distance_fade_length(double distance)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDouble(Commands.CMD_DATA + 8, distance);
            Helpers.SendCommand(Commands.CMD_Decal_set_distance_fade_length__3__r0);
            Helpers.WaitForCompletion();
        }

        public double get_distance_fade_length()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_distance_fade_length__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void set_cull_mask(long mask)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, mask);
            Helpers.SendCommand(Commands.CMD_Decal_set_cull_mask__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_cull_mask()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_cull_mask__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public AABB _get_aabb()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal__get_aabb__r16);
            Helpers.WaitForCompletion();
            AABB result = Helpers.ReadAABB(Commands.CMD_DATA);
            return result;
        }

        public void set_base(ulong base_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, base_);
            Helpers.SendCommand(Commands.CMD_Decal_set_base__23__r0);
            Helpers.WaitForCompletion();
        }

        public ulong get_base()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_base__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public ulong get_instance()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_instance__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void set_layer_mask(long mask)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, mask);
            Helpers.SendCommand(Commands.CMD_Decal_set_layer_mask__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_layer_mask()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_layer_mask__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_layer_mask_value(long layer_number, bool value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, layer_number);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, value ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Decal_set_layer_mask_value__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool get_layer_mask_value(long layer_number)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, layer_number);
            Helpers.SendCommand(Commands.CMD_Decal_get_layer_mask_value__2__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_sorting_offset(double offset)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDouble(Commands.CMD_DATA + 8, offset);
            Helpers.SendCommand(Commands.CMD_Decal_set_sorting_offset__3__r0);
            Helpers.WaitForCompletion();
        }

        public double get_sorting_offset()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_sorting_offset__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void set_sorting_use_aabb_center(bool enabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Decal_set_sorting_use_aabb_center__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_sorting_use_aabb_center()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_is_sorting_use_aabb_center__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public AABB get_aabb()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_aabb__r16);
            Helpers.WaitForCompletion();
            AABB result = Helpers.ReadAABB(Commands.CMD_DATA);
            return result;
        }

        public void set_transform(Transform3D local)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteTransform3D(Commands.CMD_DATA + 8, local);
            Helpers.SendCommand(Commands.CMD_Decal_set_transform__18__r0);
            Helpers.WaitForCompletion();
        }

        public Transform3D get_transform()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_transform__r18);
            Helpers.WaitForCompletion();
            Transform3D result = Helpers.ReadTransform3D(Commands.CMD_DATA);
            return result;
        }

        public void set_position(Vector3 position)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector3(Commands.CMD_DATA + 8, position);
            Helpers.SendCommand(Commands.CMD_Decal_set_position__9__r0);
            Helpers.WaitForCompletion();
        }

        public Vector3 get_position()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_position__r9);
            Helpers.WaitForCompletion();
            Vector3 result = Helpers.ReadVector3(Commands.CMD_DATA);
            return result;
        }

        public void set_rotation(Vector3 euler_radians)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector3(Commands.CMD_DATA + 8, euler_radians);
            Helpers.SendCommand(Commands.CMD_Decal_set_rotation__9__r0);
            Helpers.WaitForCompletion();
        }

        public Vector3 get_rotation()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_rotation__r9);
            Helpers.WaitForCompletion();
            Vector3 result = Helpers.ReadVector3(Commands.CMD_DATA);
            return result;
        }

        public void set_rotation_degrees(Vector3 euler_degrees)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector3(Commands.CMD_DATA + 8, euler_degrees);
            Helpers.SendCommand(Commands.CMD_Decal_set_rotation_degrees__9__r0);
            Helpers.WaitForCompletion();
        }

        public Vector3 get_rotation_degrees()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_rotation_degrees__r9);
            Helpers.WaitForCompletion();
            Vector3 result = Helpers.ReadVector3(Commands.CMD_DATA);
            return result;
        }

        public void set_rotation_order(long order)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, order);
            Helpers.SendCommand(Commands.CMD_Decal_set_rotation_order__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_rotation_order()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_rotation_order__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_rotation_edit_mode(long edit_mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, edit_mode);
            Helpers.SendCommand(Commands.CMD_Decal_set_rotation_edit_mode__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_rotation_edit_mode()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_rotation_edit_mode__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_scale(Vector3 scale)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector3(Commands.CMD_DATA + 8, scale);
            Helpers.SendCommand(Commands.CMD_Decal_set_scale__9__r0);
            Helpers.WaitForCompletion();
        }

        public Vector3 get_scale()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_scale__r9);
            Helpers.WaitForCompletion();
            Vector3 result = Helpers.ReadVector3(Commands.CMD_DATA);
            return result;
        }

        public void set_quaternion(Quaternion quaternion)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteQuaternion(Commands.CMD_DATA + 8, quaternion);
            Helpers.SendCommand(Commands.CMD_Decal_set_quaternion__15__r0);
            Helpers.WaitForCompletion();
        }

        public Quaternion get_quaternion()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_quaternion__r15);
            Helpers.WaitForCompletion();
            Quaternion result = Helpers.ReadQuaternion(Commands.CMD_DATA);
            return result;
        }

        public void set_basis(Basis basis)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteBasis(Commands.CMD_DATA + 8, basis);
            Helpers.SendCommand(Commands.CMD_Decal_set_basis__17__r0);
            Helpers.WaitForCompletion();
        }

        public Basis get_basis()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_basis__r17);
            Helpers.WaitForCompletion();
            Basis result = Helpers.ReadBasis(Commands.CMD_DATA);
            return result;
        }

        public void set_global_transform(Transform3D global)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteTransform3D(Commands.CMD_DATA + 8, global);
            Helpers.SendCommand(Commands.CMD_Decal_set_global_transform__18__r0);
            Helpers.WaitForCompletion();
        }

        public Transform3D get_global_transform()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_global_transform__r18);
            Helpers.WaitForCompletion();
            Transform3D result = Helpers.ReadTransform3D(Commands.CMD_DATA);
            return result;
        }

        public Transform3D get_global_transform_interpolated()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_global_transform_interpolated__r18);
            Helpers.WaitForCompletion();
            Transform3D result = Helpers.ReadTransform3D(Commands.CMD_DATA);
            return result;
        }

        public void set_global_position(Vector3 position)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector3(Commands.CMD_DATA + 8, position);
            Helpers.SendCommand(Commands.CMD_Decal_set_global_position__9__r0);
            Helpers.WaitForCompletion();
        }

        public Vector3 get_global_position()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_global_position__r9);
            Helpers.WaitForCompletion();
            Vector3 result = Helpers.ReadVector3(Commands.CMD_DATA);
            return result;
        }

        public void set_global_basis(Basis basis)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteBasis(Commands.CMD_DATA + 8, basis);
            Helpers.SendCommand(Commands.CMD_Decal_set_global_basis__17__r0);
            Helpers.WaitForCompletion();
        }

        public Basis get_global_basis()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_global_basis__r17);
            Helpers.WaitForCompletion();
            Basis result = Helpers.ReadBasis(Commands.CMD_DATA);
            return result;
        }

        public void set_global_rotation(Vector3 euler_radians)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector3(Commands.CMD_DATA + 8, euler_radians);
            Helpers.SendCommand(Commands.CMD_Decal_set_global_rotation__9__r0);
            Helpers.WaitForCompletion();
        }

        public Vector3 get_global_rotation()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_global_rotation__r9);
            Helpers.WaitForCompletion();
            Vector3 result = Helpers.ReadVector3(Commands.CMD_DATA);
            return result;
        }

        public void set_global_rotation_degrees(Vector3 euler_degrees)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector3(Commands.CMD_DATA + 8, euler_degrees);
            Helpers.SendCommand(Commands.CMD_Decal_set_global_rotation_degrees__9__r0);
            Helpers.WaitForCompletion();
        }

        public Vector3 get_global_rotation_degrees()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_global_rotation_degrees__r9);
            Helpers.WaitForCompletion();
            Vector3 result = Helpers.ReadVector3(Commands.CMD_DATA);
            return result;
        }

        public ulong get_parent_node_3d()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_parent_node_3d__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_ignore_transform_notification(bool enabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Decal_set_ignore_transform_notification__1__r0);
            Helpers.WaitForCompletion();
        }

        public void set_as_top_level(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Decal_set_as_top_level__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_set_as_top_level()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_is_set_as_top_level__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_disable_scale(bool disable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, disable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Decal_set_disable_scale__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_scale_disabled()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_is_scale_disabled__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public ulong get_world_3d()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_world_3d__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void force_update_transform()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_force_update_transform__r0);
            Helpers.WaitForCompletion();
        }

        public void set_visibility_parent(string path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, path);
            Helpers.SendCommand(Commands.CMD_Decal_set_visibility_parent__22__r0);
            Helpers.WaitForCompletion();
        }

        public string get_visibility_parent()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_visibility_parent__r22);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadNodePath(Commands.CMD_DATA);
            return result;
        }

        public void update_gizmos()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_update_gizmos__r0);
            Helpers.WaitForCompletion();
        }

        public void add_gizmo(ulong gizmo)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, gizmo);
            Helpers.SendCommand(Commands.CMD_Decal_add_gizmo__24__r0);
            Helpers.WaitForCompletion();
        }

        public object get_gizmos()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_gizmos__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void clear_gizmos()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_clear_gizmos__r0);
            Helpers.WaitForCompletion();
        }

        public void set_subgizmo_selection(ulong gizmo, long id, Transform3D transform)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, gizmo);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, id);
            Helpers.WriteTransform3D(Commands.CMD_DATA + 24, transform);
            Helpers.SendCommand(Commands.CMD_Decal_set_subgizmo_selection__24__2__18__r0);
            Helpers.WaitForCompletion();
        }

        public void clear_subgizmo_selection()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_clear_subgizmo_selection__r0);
            Helpers.WaitForCompletion();
        }

        public void set_visible(bool visible)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, visible ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Decal_set_visible__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_visible()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_is_visible__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool is_visible_in_tree()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_is_visible_in_tree__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void show()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_show__r0);
            Helpers.WaitForCompletion();
        }

        public void hide()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_hide__r0);
            Helpers.WaitForCompletion();
        }

        public void set_notify_local_transform(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Decal_set_notify_local_transform__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_local_transform_notification_enabled()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_is_local_transform_notification_enabled__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_notify_transform(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Decal_set_notify_transform__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_transform_notification_enabled()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_is_transform_notification_enabled__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void rotate(Vector3 axis, double angle)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector3(Commands.CMD_DATA + 8, axis);
            Helpers.WriteDouble(Commands.CMD_DATA + 20, angle);
            Helpers.SendCommand(Commands.CMD_Decal_rotate__9__3__r0);
            Helpers.WaitForCompletion();
        }

        public void global_rotate(Vector3 axis, double angle)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector3(Commands.CMD_DATA + 8, axis);
            Helpers.WriteDouble(Commands.CMD_DATA + 20, angle);
            Helpers.SendCommand(Commands.CMD_Decal_global_rotate__9__3__r0);
            Helpers.WaitForCompletion();
        }

        public void global_scale(Vector3 scale)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector3(Commands.CMD_DATA + 8, scale);
            Helpers.SendCommand(Commands.CMD_Decal_global_scale__9__r0);
            Helpers.WaitForCompletion();
        }

        public void global_translate(Vector3 offset)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector3(Commands.CMD_DATA + 8, offset);
            Helpers.SendCommand(Commands.CMD_Decal_global_translate__9__r0);
            Helpers.WaitForCompletion();
        }

        public void rotate_object_local(Vector3 axis, double angle)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector3(Commands.CMD_DATA + 8, axis);
            Helpers.WriteDouble(Commands.CMD_DATA + 20, angle);
            Helpers.SendCommand(Commands.CMD_Decal_rotate_object_local__9__3__r0);
            Helpers.WaitForCompletion();
        }

        public void scale_object_local(Vector3 scale)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector3(Commands.CMD_DATA + 8, scale);
            Helpers.SendCommand(Commands.CMD_Decal_scale_object_local__9__r0);
            Helpers.WaitForCompletion();
        }

        public void translate_object_local(Vector3 offset)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector3(Commands.CMD_DATA + 8, offset);
            Helpers.SendCommand(Commands.CMD_Decal_translate_object_local__9__r0);
            Helpers.WaitForCompletion();
        }

        public void rotate_x(double angle)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDouble(Commands.CMD_DATA + 8, angle);
            Helpers.SendCommand(Commands.CMD_Decal_rotate_x__3__r0);
            Helpers.WaitForCompletion();
        }

        public void rotate_y(double angle)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDouble(Commands.CMD_DATA + 8, angle);
            Helpers.SendCommand(Commands.CMD_Decal_rotate_y__3__r0);
            Helpers.WaitForCompletion();
        }

        public void rotate_z(double angle)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDouble(Commands.CMD_DATA + 8, angle);
            Helpers.SendCommand(Commands.CMD_Decal_rotate_z__3__r0);
            Helpers.WaitForCompletion();
        }

        public void translate(Vector3 offset)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector3(Commands.CMD_DATA + 8, offset);
            Helpers.SendCommand(Commands.CMD_Decal_translate__9__r0);
            Helpers.WaitForCompletion();
        }

        public void orthonormalize()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_orthonormalize__r0);
            Helpers.WaitForCompletion();
        }

        public void set_identity()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_set_identity__r0);
            Helpers.WaitForCompletion();
        }

        public void look_at(Vector3 target, Vector3 up, bool use_model_front)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector3(Commands.CMD_DATA + 8, target);
            Helpers.WriteVector3(Commands.CMD_DATA + 20, up);
            Helpers.WriteInt32(Commands.CMD_DATA + 32, use_model_front ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Decal_look_at__9__9__1__r0);
            Helpers.WaitForCompletion();
        }

        public void look_at_from_position(Vector3 position, Vector3 target, Vector3 up, bool use_model_front)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector3(Commands.CMD_DATA + 8, position);
            Helpers.WriteVector3(Commands.CMD_DATA + 20, target);
            Helpers.WriteVector3(Commands.CMD_DATA + 32, up);
            Helpers.WriteInt32(Commands.CMD_DATA + 44, use_model_front ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Decal_look_at_from_position__9__9__9__1__r0);
            Helpers.WaitForCompletion();
        }

        public Vector3 to_local(Vector3 global_point)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector3(Commands.CMD_DATA + 8, global_point);
            Helpers.SendCommand(Commands.CMD_Decal_to_local__9__r9);
            Helpers.WaitForCompletion();
            Vector3 result = Helpers.ReadVector3(Commands.CMD_DATA);
            return result;
        }

        public Vector3 to_global(Vector3 local_point)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector3(Commands.CMD_DATA + 8, local_point);
            Helpers.SendCommand(Commands.CMD_Decal_to_global__9__r9);
            Helpers.WaitForCompletion();
            Vector3 result = Helpers.ReadVector3(Commands.CMD_DATA);
            return result;
        }

        public void _process(double delta)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDouble(Commands.CMD_DATA + 8, delta);
            Helpers.SendCommand(Commands.CMD_Decal__process__3__r0);
            Helpers.WaitForCompletion();
        }

        public void _physics_process(double delta)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDouble(Commands.CMD_DATA + 8, delta);
            Helpers.SendCommand(Commands.CMD_Decal__physics_process__3__r0);
            Helpers.WaitForCompletion();
        }

        public void _enter_tree()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal__enter_tree__r0);
            Helpers.WaitForCompletion();
        }

        public void _exit_tree()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal__exit_tree__r0);
            Helpers.WaitForCompletion();
        }

        public void _ready()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal__ready__r0);
            Helpers.WaitForCompletion();
        }

        public string[] _get_configuration_warnings()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal__get_configuration_warnings__r34);
            Helpers.WaitForCompletion();
            string[] result = Helpers.ReadPackedStringArray(Commands.CMD_DATA);
            return result;
        }

        public string[] _get_accessibility_configuration_warnings()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal__get_accessibility_configuration_warnings__r34);
            Helpers.WaitForCompletion();
            string[] result = Helpers.ReadPackedStringArray(Commands.CMD_DATA);
            return result;
        }

        public void _input(ulong event_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, event_);
            Helpers.SendCommand(Commands.CMD_Decal__input__24__r0);
            Helpers.WaitForCompletion();
        }

        public void _shortcut_input(ulong event_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, event_);
            Helpers.SendCommand(Commands.CMD_Decal__shortcut_input__24__r0);
            Helpers.WaitForCompletion();
        }

        public void _unhandled_input(ulong event_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, event_);
            Helpers.SendCommand(Commands.CMD_Decal__unhandled_input__24__r0);
            Helpers.WaitForCompletion();
        }

        public void _unhandled_key_input(ulong event_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, event_);
            Helpers.SendCommand(Commands.CMD_Decal__unhandled_key_input__24__r0);
            Helpers.WaitForCompletion();
        }

        public ulong _get_focused_accessibility_element()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal__get_focused_accessibility_element__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void print_orphan_nodes()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_print_orphan_nodes__r0);
            Helpers.WaitForCompletion();
        }

        public object get_orphan_node_ids()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_orphan_node_ids__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void add_sibling(ulong sibling, bool force_readable_name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, sibling);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, force_readable_name ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Decal_add_sibling__24__1__r0);
            Helpers.WaitForCompletion();
        }

        public void set_name(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_Decal_set_name__21__r0);
            Helpers.WaitForCompletion();
        }

        public string get_name()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_name__r21);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadStringName(Commands.CMD_DATA);
            return result;
        }

        public void add_child(ulong node, bool force_readable_name, long internal_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, node);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, force_readable_name ? 1 : 0);
            Helpers.WriteInt64(Commands.CMD_DATA + 20, internal_);
            Helpers.SendCommand(Commands.CMD_Decal_add_child__24__1__2__r0);
            Helpers.WaitForCompletion();
        }

        public void remove_child(ulong node)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, node);
            Helpers.SendCommand(Commands.CMD_Decal_remove_child__24__r0);
            Helpers.WaitForCompletion();
        }

        public void reparent(ulong new_parent, bool keep_global_transform)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, new_parent);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, keep_global_transform ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Decal_reparent__24__1__r0);
            Helpers.WaitForCompletion();
        }

        public long get_child_count(bool include_internal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, include_internal ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Decal_get_child_count__1__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public object get_children(bool include_internal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, include_internal ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Decal_get_children__1__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public ulong get_child(long idx, bool include_internal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, idx);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, include_internal ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Decal_get_child__2__1__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public bool has_node(string path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, path);
            Helpers.SendCommand(Commands.CMD_Decal_has_node__22__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public ulong get_node(string path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, path);
            Helpers.SendCommand(Commands.CMD_Decal_get_node__22__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong get_node_or_null(string path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, path);
            Helpers.SendCommand(Commands.CMD_Decal_get_node_or_null__22__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong get_parent()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_parent__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong find_child(string pattern, bool recursive, bool owned)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, pattern);
            Helpers.WriteInt32(Commands.CMD_DATA + 1036, recursive ? 1 : 0);
            Helpers.WriteInt32(Commands.CMD_DATA + 1040, owned ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Decal_find_child__4__1__1__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public object find_children(string pattern, string type, bool recursive, bool owned)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, pattern);
            Helpers.WriteString(Commands.CMD_DATA + 1036, type);
            Helpers.WriteInt32(Commands.CMD_DATA + 2064, recursive ? 1 : 0);
            Helpers.WriteInt32(Commands.CMD_DATA + 2068, owned ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Decal_find_children__4__4__1__1__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public ulong find_parent(string pattern)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, pattern);
            Helpers.SendCommand(Commands.CMD_Decal_find_parent__4__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public bool has_node_and_resource(string path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, path);
            Helpers.SendCommand(Commands.CMD_Decal_has_node_and_resource__22__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public object get_node_and_resource(string path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, path);
            Helpers.SendCommand(Commands.CMD_Decal_get_node_and_resource__22__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public bool is_inside_tree()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_is_inside_tree__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool is_part_of_edited_scene()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_is_part_of_edited_scene__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool is_ancestor_of(ulong node)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, node);
            Helpers.SendCommand(Commands.CMD_Decal_is_ancestor_of__24__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool is_greater_than(ulong node)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, node);
            Helpers.SendCommand(Commands.CMD_Decal_is_greater_than__24__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public string get_path()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_path__r22);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadNodePath(Commands.CMD_DATA);
            return result;
        }

        public string get_path_to(ulong node, bool use_unique_path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, node);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, use_unique_path ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Decal_get_path_to__24__1__r22);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadNodePath(Commands.CMD_DATA);
            return result;
        }

        public void add_to_group(string group, bool persistent)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, group);
            Helpers.WriteInt32(Commands.CMD_DATA + 1036, persistent ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Decal_add_to_group__21__1__r0);
            Helpers.WaitForCompletion();
        }

        public void remove_from_group(string group)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, group);
            Helpers.SendCommand(Commands.CMD_Decal_remove_from_group__21__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_in_group(string group)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, group);
            Helpers.SendCommand(Commands.CMD_Decal_is_in_group__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void move_child(ulong child_node, long to_index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, child_node);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, to_index);
            Helpers.SendCommand(Commands.CMD_Decal_move_child__24__2__r0);
            Helpers.WaitForCompletion();
        }

        public object get_groups()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_groups__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void set_owner(ulong owner)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, owner);
            Helpers.SendCommand(Commands.CMD_Decal_set_owner__24__r0);
            Helpers.WaitForCompletion();
        }

        public ulong get_owner()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_owner__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public long get_index(bool include_internal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, include_internal ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Decal_get_index__1__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void print_tree()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_print_tree__r0);
            Helpers.WaitForCompletion();
        }

        public void print_tree_pretty()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_print_tree_pretty__r0);
            Helpers.WaitForCompletion();
        }

        public string get_tree_string()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_tree_string__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public string get_tree_string_pretty()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_tree_string_pretty__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void set_scene_file_path(string scene_file_path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, scene_file_path);
            Helpers.SendCommand(Commands.CMD_Decal_set_scene_file_path__4__r0);
            Helpers.WaitForCompletion();
        }

        public string get_scene_file_path()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_scene_file_path__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void propagate_notification(long what)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, what);
            Helpers.SendCommand(Commands.CMD_Decal_propagate_notification__2__r0);
            Helpers.WaitForCompletion();
        }

        public void propagate_call(string method, object args, bool parent_first)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.WriteArray(Commands.CMD_DATA + 1036, args);
            Helpers.WriteInt32(Commands.CMD_DATA + 1036, parent_first ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Decal_propagate_call__21__28__1__r0);
            Helpers.WaitForCompletion();
        }

        public void set_physics_process(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Decal_set_physics_process__1__r0);
            Helpers.WaitForCompletion();
        }

        public double get_physics_process_delta_time()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_physics_process_delta_time__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public bool is_physics_processing()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_is_physics_processing__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public double get_process_delta_time()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_process_delta_time__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void set_process(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Decal_set_process__1__r0);
            Helpers.WaitForCompletion();
        }

        public void set_process_priority(long priority)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, priority);
            Helpers.SendCommand(Commands.CMD_Decal_set_process_priority__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_process_priority()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_process_priority__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_physics_process_priority(long priority)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, priority);
            Helpers.SendCommand(Commands.CMD_Decal_set_physics_process_priority__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_physics_process_priority()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_physics_process_priority__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool is_processing()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_is_processing__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_process_input(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Decal_set_process_input__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_processing_input()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_is_processing_input__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_process_shortcut_input(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Decal_set_process_shortcut_input__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_processing_shortcut_input()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_is_processing_shortcut_input__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_process_unhandled_input(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Decal_set_process_unhandled_input__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_processing_unhandled_input()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_is_processing_unhandled_input__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_process_unhandled_key_input(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Decal_set_process_unhandled_key_input__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_processing_unhandled_key_input()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_is_processing_unhandled_key_input__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_process_mode(long mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, mode);
            Helpers.SendCommand(Commands.CMD_Decal_set_process_mode__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_process_mode()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_process_mode__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool can_process()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_can_process__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_process_thread_group(long mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, mode);
            Helpers.SendCommand(Commands.CMD_Decal_set_process_thread_group__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_process_thread_group()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_process_thread_group__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_process_thread_messages(long flags)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, flags);
            Helpers.SendCommand(Commands.CMD_Decal_set_process_thread_messages__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_process_thread_messages()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_process_thread_messages__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_process_thread_group_order(long order)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, order);
            Helpers.SendCommand(Commands.CMD_Decal_set_process_thread_group_order__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_process_thread_group_order()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_process_thread_group_order__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void queue_accessibility_update()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_queue_accessibility_update__r0);
            Helpers.WaitForCompletion();
        }

        public ulong get_accessibility_element()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_accessibility_element__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void set_display_folded(bool fold)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, fold ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Decal_set_display_folded__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_displayed_folded()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_is_displayed_folded__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_process_internal(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Decal_set_process_internal__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_processing_internal()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_is_processing_internal__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_physics_process_internal(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Decal_set_physics_process_internal__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_physics_processing_internal()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_is_physics_processing_internal__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_physics_interpolation_mode(long mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, mode);
            Helpers.SendCommand(Commands.CMD_Decal_set_physics_interpolation_mode__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_physics_interpolation_mode()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_physics_interpolation_mode__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool is_physics_interpolated()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_is_physics_interpolated__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool is_physics_interpolated_and_enabled()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_is_physics_interpolated_and_enabled__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void reset_physics_interpolation()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_reset_physics_interpolation__r0);
            Helpers.WaitForCompletion();
        }

        public void set_auto_translate_mode(long mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, mode);
            Helpers.SendCommand(Commands.CMD_Decal_set_auto_translate_mode__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_auto_translate_mode()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_auto_translate_mode__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool can_auto_translate()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_can_auto_translate__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_translation_domain_inherited()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_set_translation_domain_inherited__r0);
            Helpers.WaitForCompletion();
        }

        public ulong get_window()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_window__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong get_last_exclusive_window()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_last_exclusive_window__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong get_tree()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_tree__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong create_tween()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_create_tween__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong duplicate(long flags)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, flags);
            Helpers.SendCommand(Commands.CMD_Decal_duplicate__2__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void replace_by(ulong node, bool keep_groups)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, node);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, keep_groups ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Decal_replace_by__24__1__r0);
            Helpers.WaitForCompletion();
        }

        public void set_scene_instance_load_placeholder(bool load_placeholder)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, load_placeholder ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Decal_set_scene_instance_load_placeholder__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool get_scene_instance_load_placeholder()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_scene_instance_load_placeholder__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_editable_instance(ulong node, bool is_editable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, node);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, is_editable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Decal_set_editable_instance__24__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_editable_instance(ulong node)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, node);
            Helpers.SendCommand(Commands.CMD_Decal_is_editable_instance__24__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public ulong get_viewport()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_viewport__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void queue_free()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_queue_free__r0);
            Helpers.WaitForCompletion();
        }

        public void request_ready()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_request_ready__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_node_ready()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_is_node_ready__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_multiplayer_authority(long id, bool recursive)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, id);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, recursive ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Decal_set_multiplayer_authority__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public long get_multiplayer_authority()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_multiplayer_authority__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool is_multiplayer_authority()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_is_multiplayer_authority__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public ulong get_multiplayer()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_multiplayer__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void rpc_config(string method, object config)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, config);
            Helpers.SendCommand(Commands.CMD_Decal_rpc_config__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get_node_rpc_config()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_node_rpc_config__r0);
            Helpers.WaitForCompletion();
        }

        public void set_editor_description(string editor_description)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, editor_description);
            Helpers.SendCommand(Commands.CMD_Decal_set_editor_description__4__r0);
            Helpers.WaitForCompletion();
        }

        public string get_editor_description()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_editor_description__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void set_unique_name_in_owner(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Decal_set_unique_name_in_owner__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_unique_name_in_owner()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_is_unique_name_in_owner__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public string atr(string message, string context)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, message);
            Helpers.WriteStringName(Commands.CMD_DATA + 1036, context);
            Helpers.SendCommand(Commands.CMD_Decal_atr__4__21__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public string atr_n(string message, string plural_message, long n, string context)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, message);
            Helpers.WriteStringName(Commands.CMD_DATA + 1036, plural_message);
            Helpers.WriteInt64(Commands.CMD_DATA + 2064, n);
            Helpers.WriteStringName(Commands.CMD_DATA + 2072, context);
            Helpers.SendCommand(Commands.CMD_Decal_atr_n__4__21__2__21__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void _set_property_pinned(string property, bool pinned)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, property);
            Helpers.WriteInt32(Commands.CMD_DATA + 1036, pinned ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Decal__set_property_pinned__4__1__r0);
            Helpers.WaitForCompletion();
        }

        public long rpc(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_Decal_rpc__21__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long rpc_id(long peer_id, string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, peer_id);
            Helpers.WriteStringName(Commands.CMD_DATA + 16, method);
            Helpers.SendCommand(Commands.CMD_Decal_rpc_id__2__21__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void update_configuration_warnings()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_update_configuration_warnings__r0);
            Helpers.WaitForCompletion();
        }

        public void call_deferred_thread_group(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_Decal_call_deferred_thread_group__21__r0);
            Helpers.WaitForCompletion();
        }

        public void set_deferred_thread_group(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_Decal_set_deferred_thread_group__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void notify_deferred_thread_group(long what)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, what);
            Helpers.SendCommand(Commands.CMD_Decal_notify_deferred_thread_group__2__r0);
            Helpers.WaitForCompletion();
        }

        public void call_thread_safe(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_Decal_call_thread_safe__21__r0);
            Helpers.WaitForCompletion();
        }

        public void set_thread_safe(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_Decal_set_thread_safe__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void notify_thread_safe(long what)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, what);
            Helpers.SendCommand(Commands.CMD_Decal_notify_thread_safe__2__r0);
            Helpers.WaitForCompletion();
        }

        public void free()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_free__r0);
            Helpers.WaitForCompletion();
        }

        public void _init()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal__init__r0);
            Helpers.WaitForCompletion();
        }

        public string _to_string()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal__to_string__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void _notification(long what)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, what);
            Helpers.SendCommand(Commands.CMD_Decal__notification__2__r0);
            Helpers.WaitForCompletion();
        }

        public bool _set(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_Decal__set__21__0__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _get(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_Decal__get__21__r0);
            Helpers.WaitForCompletion();
        }

        public object _get_property_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal__get_property_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void _validate_property(object property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDictionary(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_Decal__validate_property__27__r0);
            Helpers.WaitForCompletion();
        }

        public bool _property_can_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_Decal__property_can_revert__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _property_get_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_Decal__property_get_revert__21__r0);
            Helpers.WaitForCompletion();
        }

        public bool _iter_init(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteArray(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_Decal__iter_init__28__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool _iter_next(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteArray(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_Decal__iter_next__28__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _iter_get(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVariant(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_Decal__iter_get__0__r0);
            Helpers.WaitForCompletion();
        }

        public string get_class()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_class__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public bool is_class(string class_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, class_);
            Helpers.SendCommand(Commands.CMD_Decal_is_class__4__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_Decal_set__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_Decal_get__21__r0);
            Helpers.WaitForCompletion();
        }

        public void set_indexed(string property_path, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, property_path);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_Decal_set_indexed__22__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get_indexed(string property_path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, property_path);
            Helpers.SendCommand(Commands.CMD_Decal_get_indexed__22__r0);
            Helpers.WaitForCompletion();
        }

        public object get_property_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_property_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_method_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_method_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public bool property_can_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_Decal_property_can_revert__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void property_get_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_Decal_property_get_revert__21__r0);
            Helpers.WaitForCompletion();
        }

        public void notification(long what, bool reversed)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, what);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, reversed ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Decal_notification__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public string to_string()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_to_string__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public ulong get_instance_id()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_instance_id__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_script(object script)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVariant(Commands.CMD_DATA + 8, script);
            Helpers.SendCommand(Commands.CMD_Decal_set_script__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get_script()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_script__r0);
            Helpers.WaitForCompletion();
        }

        public void set_meta(string name, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_Decal_set_meta__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void remove_meta(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_Decal_remove_meta__21__r0);
            Helpers.WaitForCompletion();
        }

        public void get_meta(string name, object default_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, default_);
            Helpers.SendCommand(Commands.CMD_Decal_get_meta__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_meta(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_Decal_has_meta__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public object get_meta_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_meta_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void add_user_signal(string signal, object arguments)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, signal);
            Helpers.WriteArray(Commands.CMD_DATA + 1036, arguments);
            Helpers.SendCommand(Commands.CMD_Decal_add_user_signal__4__28__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_user_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_Decal_has_user_signal__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void remove_user_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_Decal_remove_user_signal__21__r0);
            Helpers.WaitForCompletion();
        }

        public long emit_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_Decal_emit_signal__21__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void call(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_Decal_call__21__r0);
            Helpers.WaitForCompletion();
        }

        public void call_deferred(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_Decal_call_deferred__21__r0);
            Helpers.WaitForCompletion();
        }

        public void set_deferred(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_Decal_set_deferred__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void callv(string method, object arg_array)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.WriteArray(Commands.CMD_DATA + 1036, arg_array);
            Helpers.SendCommand(Commands.CMD_Decal_callv__21__28__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_method(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_Decal_has_method__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public long get_method_argument_count(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_Decal_get_method_argument_count__21__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool has_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_Decal_has_signal__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public object get_signal_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_signal_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_signal_connection_list(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_Decal_get_signal_connection_list__21__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_incoming_connections()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_incoming_connections__r28);
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
            Helpers.SendCommand(Commands.CMD_Decal_connect__21__25__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void disconnect(string signal, object callable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.WriteCallable(Commands.CMD_DATA + 1036, callable);
            Helpers.SendCommand(Commands.CMD_Decal_disconnect__21__25__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_connected(string signal, object callable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.WriteCallable(Commands.CMD_DATA + 1036, callable);
            Helpers.SendCommand(Commands.CMD_Decal_is_connected__21__25__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool has_connections(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_Decal_has_connections__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_block_signals(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Decal_set_block_signals__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_blocking_signals()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_is_blocking_signals__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void notify_property_list_changed()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_notify_property_list_changed__r0);
            Helpers.WaitForCompletion();
        }

        public void set_message_translation(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Decal_set_message_translation__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool can_translate_messages()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_can_translate_messages__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public string tr(string message, string context)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, message);
            Helpers.WriteStringName(Commands.CMD_DATA + 1036, context);
            Helpers.SendCommand(Commands.CMD_Decal_tr__21__21__r4);
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
            Helpers.SendCommand(Commands.CMD_Decal_tr_n__21__21__2__21__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public string get_translation_domain()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_get_translation_domain__r21);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadStringName(Commands.CMD_DATA);
            return result;
        }

        public void set_translation_domain(string domain)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, domain);
            Helpers.SendCommand(Commands.CMD_Decal_set_translation_domain__21__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_queued_for_deletion()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_is_queued_for_deletion__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void cancel_free()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Decal_cancel_free__r0);
            Helpers.WaitForCompletion();
        }

    }
}
