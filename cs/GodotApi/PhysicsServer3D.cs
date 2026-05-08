using System;

namespace GodotWeb
{
    public class PhysicsServer3D : GodotObject
    {
        public PhysicsServer3D(ulong id) : base(id) { }

        public ulong world_boundary_shape_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_world_boundary_shape_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public ulong separation_ray_shape_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_separation_ray_shape_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public ulong sphere_shape_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_sphere_shape_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public ulong box_shape_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_box_shape_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public ulong capsule_shape_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_capsule_shape_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public ulong cylinder_shape_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_cylinder_shape_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public ulong convex_polygon_shape_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_convex_polygon_shape_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public ulong concave_polygon_shape_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_concave_polygon_shape_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public ulong heightmap_shape_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_heightmap_shape_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public ulong custom_shape_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_custom_shape_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void shape_set_data(ulong shape, object arg_data)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shape);
            Helpers.WriteVariant(Commands.CMD_DATA + 16, arg_data);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_shape_set_data__23__0__r0);
            Helpers.WaitForCompletion();
        }

        public void shape_set_margin(ulong shape, double margin)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shape);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, margin);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_shape_set_margin__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public long shape_get_type(ulong shape)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shape);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_shape_get_type__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void shape_get_data(ulong shape)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shape);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_shape_get_data__23__r0);
            Helpers.WaitForCompletion();
        }

        public double shape_get_margin(ulong shape)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shape);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_shape_get_margin__23__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public ulong space_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_space_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void space_set_active(ulong space, bool active)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, space);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, active ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_space_set_active__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool space_is_active(ulong space)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, space);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_space_is_active__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void space_set_param(ulong space, long param, double value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, space);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, param);
            Helpers.WriteDouble(Commands.CMD_DATA + 24, value);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_space_set_param__23__2__3__r0);
            Helpers.WaitForCompletion();
        }

        public double space_get_param(ulong space, long param)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, space);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, param);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_space_get_param__23__2__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public ulong space_get_direct_state(ulong space)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, space);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_space_get_direct_state__23__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong area_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_area_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void area_set_space(ulong area, ulong space)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, area);
            Helpers.WriteRID(Commands.CMD_DATA + 16, space);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_area_set_space__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public ulong area_get_space(ulong area)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, area);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_area_get_space__23__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void area_add_shape(ulong area, ulong shape, Transform3D transform, bool disabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, area);
            Helpers.WriteRID(Commands.CMD_DATA + 16, shape);
            Helpers.WriteTransform3D(Commands.CMD_DATA + 24, transform);
            Helpers.WriteInt32(Commands.CMD_DATA + 72, disabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_area_add_shape__23__23__18__1__r0);
            Helpers.WaitForCompletion();
        }

        public void area_set_shape(ulong area, long shape_idx, ulong shape)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, area);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, shape_idx);
            Helpers.WriteRID(Commands.CMD_DATA + 24, shape);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_area_set_shape__23__2__23__r0);
            Helpers.WaitForCompletion();
        }

        public void area_set_shape_transform(ulong area, long shape_idx, Transform3D transform)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, area);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, shape_idx);
            Helpers.WriteTransform3D(Commands.CMD_DATA + 24, transform);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_area_set_shape_transform__23__2__18__r0);
            Helpers.WaitForCompletion();
        }

        public void area_set_shape_disabled(ulong area, long shape_idx, bool disabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, area);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, shape_idx);
            Helpers.WriteInt32(Commands.CMD_DATA + 24, disabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_area_set_shape_disabled__23__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public long area_get_shape_count(ulong area)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, area);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_area_get_shape_count__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong area_get_shape(ulong area, long shape_idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, area);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, shape_idx);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_area_get_shape__23__2__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public Transform3D area_get_shape_transform(ulong area, long shape_idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, area);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, shape_idx);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_area_get_shape_transform__23__2__r18);
            Helpers.WaitForCompletion();
            Transform3D result = Helpers.ReadTransform3D(Commands.CMD_DATA);
            return result;
        }

        public void area_remove_shape(ulong area, long shape_idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, area);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, shape_idx);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_area_remove_shape__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void area_clear_shapes(ulong area)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, area);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_area_clear_shapes__23__r0);
            Helpers.WaitForCompletion();
        }

        public void area_set_collision_layer(ulong area, long layer)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, area);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, layer);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_area_set_collision_layer__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long area_get_collision_layer(ulong area)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, area);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_area_get_collision_layer__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void area_set_collision_mask(ulong area, long mask)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, area);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, mask);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_area_set_collision_mask__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long area_get_collision_mask(ulong area)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, area);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_area_get_collision_mask__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void area_set_param(ulong area, long param, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, area);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, param);
            Helpers.WriteVariant(Commands.CMD_DATA + 24, value);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_area_set_param__23__2__0__r0);
            Helpers.WaitForCompletion();
        }

        public void area_set_transform(ulong area, Transform3D transform)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, area);
            Helpers.WriteTransform3D(Commands.CMD_DATA + 16, transform);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_area_set_transform__23__18__r0);
            Helpers.WaitForCompletion();
        }

        public void area_get_param(ulong area, long param)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, area);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, param);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_area_get_param__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public Transform3D area_get_transform(ulong area)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, area);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_area_get_transform__23__r18);
            Helpers.WaitForCompletion();
            Transform3D result = Helpers.ReadTransform3D(Commands.CMD_DATA);
            return result;
        }

        public void area_attach_object_instance_id(ulong area, long id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, area);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_area_attach_object_instance_id__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long area_get_object_instance_id(ulong area)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, area);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_area_get_object_instance_id__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void area_set_monitor_callback(ulong area, object callback)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, area);
            Helpers.WriteCallable(Commands.CMD_DATA + 16, callback);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_area_set_monitor_callback__23__25__r0);
            Helpers.WaitForCompletion();
        }

        public void area_set_area_monitor_callback(ulong area, object callback)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, area);
            Helpers.WriteCallable(Commands.CMD_DATA + 16, callback);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_area_set_area_monitor_callback__23__25__r0);
            Helpers.WaitForCompletion();
        }

        public void area_set_monitorable(ulong area, bool monitorable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, area);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, monitorable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_area_set_monitorable__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public void area_set_ray_pickable(ulong area, bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, area);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_area_set_ray_pickable__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public ulong body_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_body_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void body_set_space(ulong body, ulong space)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteRID(Commands.CMD_DATA + 16, space);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_body_set_space__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public ulong body_get_space(ulong body)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_body_get_space__23__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void body_set_mode(ulong body, long mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, mode);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_body_set_mode__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long body_get_mode(ulong body)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_body_get_mode__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void body_set_collision_layer(ulong body, long layer)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, layer);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_body_set_collision_layer__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long body_get_collision_layer(ulong body)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_body_get_collision_layer__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void body_set_collision_mask(ulong body, long mask)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, mask);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_body_set_collision_mask__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long body_get_collision_mask(ulong body)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_body_get_collision_mask__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void body_set_collision_priority(ulong body, double priority)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, priority);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_body_set_collision_priority__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public double body_get_collision_priority(ulong body)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_body_get_collision_priority__23__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void body_add_shape(ulong body, ulong shape, Transform3D transform, bool disabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteRID(Commands.CMD_DATA + 16, shape);
            Helpers.WriteTransform3D(Commands.CMD_DATA + 24, transform);
            Helpers.WriteInt32(Commands.CMD_DATA + 72, disabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_body_add_shape__23__23__18__1__r0);
            Helpers.WaitForCompletion();
        }

        public void body_set_shape(ulong body, long shape_idx, ulong shape)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, shape_idx);
            Helpers.WriteRID(Commands.CMD_DATA + 24, shape);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_body_set_shape__23__2__23__r0);
            Helpers.WaitForCompletion();
        }

        public void body_set_shape_transform(ulong body, long shape_idx, Transform3D transform)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, shape_idx);
            Helpers.WriteTransform3D(Commands.CMD_DATA + 24, transform);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_body_set_shape_transform__23__2__18__r0);
            Helpers.WaitForCompletion();
        }

        public void body_set_shape_disabled(ulong body, long shape_idx, bool disabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, shape_idx);
            Helpers.WriteInt32(Commands.CMD_DATA + 24, disabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_body_set_shape_disabled__23__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public long body_get_shape_count(ulong body)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_body_get_shape_count__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong body_get_shape(ulong body, long shape_idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, shape_idx);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_body_get_shape__23__2__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public Transform3D body_get_shape_transform(ulong body, long shape_idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, shape_idx);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_body_get_shape_transform__23__2__r18);
            Helpers.WaitForCompletion();
            Transform3D result = Helpers.ReadTransform3D(Commands.CMD_DATA);
            return result;
        }

        public void body_remove_shape(ulong body, long shape_idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, shape_idx);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_body_remove_shape__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void body_clear_shapes(ulong body)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_body_clear_shapes__23__r0);
            Helpers.WaitForCompletion();
        }

        public void body_attach_object_instance_id(ulong body, long id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_body_attach_object_instance_id__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long body_get_object_instance_id(ulong body)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_body_get_object_instance_id__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void body_set_enable_continuous_collision_detection(ulong body, bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_body_set_enable_continuous_collision_detection__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool body_is_continuous_collision_detection_enabled(ulong body)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_body_is_continuous_collision_detection_enabled__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void body_set_param(ulong body, long param, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, param);
            Helpers.WriteVariant(Commands.CMD_DATA + 24, value);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_body_set_param__23__2__0__r0);
            Helpers.WaitForCompletion();
        }

        public void body_get_param(ulong body, long param)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, param);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_body_get_param__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void body_reset_mass_properties(ulong body)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_body_reset_mass_properties__23__r0);
            Helpers.WaitForCompletion();
        }

        public void body_set_state(ulong body, long state, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, state);
            Helpers.WriteVariant(Commands.CMD_DATA + 24, value);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_body_set_state__23__2__0__r0);
            Helpers.WaitForCompletion();
        }

        public void body_get_state(ulong body, long state)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, state);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_body_get_state__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void body_apply_central_impulse(ulong body, Vector3 impulse)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteVector3(Commands.CMD_DATA + 16, impulse);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_body_apply_central_impulse__23__9__r0);
            Helpers.WaitForCompletion();
        }

        public void body_apply_impulse(ulong body, Vector3 impulse, Vector3 position)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteVector3(Commands.CMD_DATA + 16, impulse);
            Helpers.WriteVector3(Commands.CMD_DATA + 28, position);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_body_apply_impulse__23__9__9__r0);
            Helpers.WaitForCompletion();
        }

        public void body_apply_torque_impulse(ulong body, Vector3 impulse)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteVector3(Commands.CMD_DATA + 16, impulse);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_body_apply_torque_impulse__23__9__r0);
            Helpers.WaitForCompletion();
        }

        public void body_apply_central_force(ulong body, Vector3 force)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteVector3(Commands.CMD_DATA + 16, force);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_body_apply_central_force__23__9__r0);
            Helpers.WaitForCompletion();
        }

        public void body_apply_force(ulong body, Vector3 force, Vector3 position)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteVector3(Commands.CMD_DATA + 16, force);
            Helpers.WriteVector3(Commands.CMD_DATA + 28, position);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_body_apply_force__23__9__9__r0);
            Helpers.WaitForCompletion();
        }

        public void body_apply_torque(ulong body, Vector3 torque)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteVector3(Commands.CMD_DATA + 16, torque);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_body_apply_torque__23__9__r0);
            Helpers.WaitForCompletion();
        }

        public void body_add_constant_central_force(ulong body, Vector3 force)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteVector3(Commands.CMD_DATA + 16, force);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_body_add_constant_central_force__23__9__r0);
            Helpers.WaitForCompletion();
        }

        public void body_add_constant_force(ulong body, Vector3 force, Vector3 position)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteVector3(Commands.CMD_DATA + 16, force);
            Helpers.WriteVector3(Commands.CMD_DATA + 28, position);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_body_add_constant_force__23__9__9__r0);
            Helpers.WaitForCompletion();
        }

        public void body_add_constant_torque(ulong body, Vector3 torque)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteVector3(Commands.CMD_DATA + 16, torque);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_body_add_constant_torque__23__9__r0);
            Helpers.WaitForCompletion();
        }

        public void body_set_constant_force(ulong body, Vector3 force)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteVector3(Commands.CMD_DATA + 16, force);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_body_set_constant_force__23__9__r0);
            Helpers.WaitForCompletion();
        }

        public Vector3 body_get_constant_force(ulong body)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_body_get_constant_force__23__r9);
            Helpers.WaitForCompletion();
            Vector3 result = Helpers.ReadVector3(Commands.CMD_DATA);
            return result;
        }

        public void body_set_constant_torque(ulong body, Vector3 torque)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteVector3(Commands.CMD_DATA + 16, torque);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_body_set_constant_torque__23__9__r0);
            Helpers.WaitForCompletion();
        }

        public Vector3 body_get_constant_torque(ulong body)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_body_get_constant_torque__23__r9);
            Helpers.WaitForCompletion();
            Vector3 result = Helpers.ReadVector3(Commands.CMD_DATA);
            return result;
        }

        public void body_set_axis_velocity(ulong body, Vector3 axis_velocity)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteVector3(Commands.CMD_DATA + 16, axis_velocity);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_body_set_axis_velocity__23__9__r0);
            Helpers.WaitForCompletion();
        }

        public void body_set_axis_lock(ulong body, long axis, bool lock_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, axis);
            Helpers.WriteInt32(Commands.CMD_DATA + 24, lock_ ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_body_set_axis_lock__23__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool body_is_axis_locked(ulong body, long axis)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, axis);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_body_is_axis_locked__23__2__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void body_add_collision_exception(ulong body, ulong excepted_body)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteRID(Commands.CMD_DATA + 16, excepted_body);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_body_add_collision_exception__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public void body_remove_collision_exception(ulong body, ulong excepted_body)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteRID(Commands.CMD_DATA + 16, excepted_body);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_body_remove_collision_exception__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public void body_set_max_contacts_reported(ulong body, long amount)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, amount);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_body_set_max_contacts_reported__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long body_get_max_contacts_reported(ulong body)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_body_get_max_contacts_reported__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void body_set_omit_force_integration(ulong body, bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_body_set_omit_force_integration__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool body_is_omitting_force_integration(ulong body)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_body_is_omitting_force_integration__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void body_set_state_sync_callback(ulong body, object callable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteCallable(Commands.CMD_DATA + 16, callable);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_body_set_state_sync_callback__23__25__r0);
            Helpers.WaitForCompletion();
        }

        public void body_set_force_integration_callback(ulong body, object callable, object userdata)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteCallable(Commands.CMD_DATA + 16, callable);
            Helpers.WriteVariant(Commands.CMD_DATA + 16, userdata);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_body_set_force_integration_callback__23__25__0__r0);
            Helpers.WaitForCompletion();
        }

        public void body_set_ray_pickable(ulong body, bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_body_set_ray_pickable__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool body_test_motion(ulong body, ulong parameters, ulong arg_result)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteUInt64(Commands.CMD_DATA + 16, parameters);
            Helpers.WriteUInt64(Commands.CMD_DATA + 24, arg_result);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_body_test_motion__23__24__24__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public ulong body_get_direct_state(ulong body)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_body_get_direct_state__23__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong soft_body_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_soft_body_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void soft_body_update_rendering_server(ulong body, ulong rendering_server_handler)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteUInt64(Commands.CMD_DATA + 16, rendering_server_handler);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_soft_body_update_rendering_server__23__24__r0);
            Helpers.WaitForCompletion();
        }

        public void soft_body_set_space(ulong body, ulong space)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteRID(Commands.CMD_DATA + 16, space);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_soft_body_set_space__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public ulong soft_body_get_space(ulong body)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_soft_body_get_space__23__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void soft_body_set_mesh(ulong body, ulong mesh)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteRID(Commands.CMD_DATA + 16, mesh);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_soft_body_set_mesh__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public AABB soft_body_get_bounds(ulong body)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_soft_body_get_bounds__23__r16);
            Helpers.WaitForCompletion();
            AABB result = Helpers.ReadAABB(Commands.CMD_DATA);
            return result;
        }

        public void soft_body_set_collision_layer(ulong body, long layer)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, layer);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_soft_body_set_collision_layer__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long soft_body_get_collision_layer(ulong body)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_soft_body_get_collision_layer__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void soft_body_set_collision_mask(ulong body, long mask)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, mask);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_soft_body_set_collision_mask__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long soft_body_get_collision_mask(ulong body)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_soft_body_get_collision_mask__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void soft_body_add_collision_exception(ulong body, ulong body_b)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteRID(Commands.CMD_DATA + 16, body_b);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_soft_body_add_collision_exception__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public void soft_body_remove_collision_exception(ulong body, ulong body_b)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteRID(Commands.CMD_DATA + 16, body_b);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_soft_body_remove_collision_exception__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public void soft_body_set_state(ulong body, long state, object variant)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, state);
            Helpers.WriteVariant(Commands.CMD_DATA + 24, variant);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_soft_body_set_state__23__2__0__r0);
            Helpers.WaitForCompletion();
        }

        public void soft_body_get_state(ulong body, long state)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, state);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_soft_body_get_state__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void soft_body_set_transform(ulong body, Transform3D transform)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteTransform3D(Commands.CMD_DATA + 16, transform);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_soft_body_set_transform__23__18__r0);
            Helpers.WaitForCompletion();
        }

        public void soft_body_set_ray_pickable(ulong body, bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_soft_body_set_ray_pickable__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public void soft_body_set_simulation_precision(ulong body, long simulation_precision)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, simulation_precision);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_soft_body_set_simulation_precision__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long soft_body_get_simulation_precision(ulong body)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_soft_body_get_simulation_precision__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void soft_body_set_total_mass(ulong body, double total_mass)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, total_mass);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_soft_body_set_total_mass__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public double soft_body_get_total_mass(ulong body)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_soft_body_get_total_mass__23__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void soft_body_set_linear_stiffness(ulong body, double stiffness)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, stiffness);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_soft_body_set_linear_stiffness__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public double soft_body_get_linear_stiffness(ulong body)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_soft_body_get_linear_stiffness__23__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void soft_body_set_shrinking_factor(ulong body, double shrinking_factor)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, shrinking_factor);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_soft_body_set_shrinking_factor__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public double soft_body_get_shrinking_factor(ulong body)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_soft_body_get_shrinking_factor__23__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void soft_body_set_pressure_coefficient(ulong body, double pressure_coefficient)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, pressure_coefficient);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_soft_body_set_pressure_coefficient__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public double soft_body_get_pressure_coefficient(ulong body)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_soft_body_get_pressure_coefficient__23__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void soft_body_set_damping_coefficient(ulong body, double damping_coefficient)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, damping_coefficient);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_soft_body_set_damping_coefficient__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public double soft_body_get_damping_coefficient(ulong body)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_soft_body_get_damping_coefficient__23__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void soft_body_set_drag_coefficient(ulong body, double drag_coefficient)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, drag_coefficient);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_soft_body_set_drag_coefficient__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public double soft_body_get_drag_coefficient(ulong body)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_soft_body_get_drag_coefficient__23__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void soft_body_move_point(ulong body, long point_index, Vector3 global_position)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, point_index);
            Helpers.WriteVector3(Commands.CMD_DATA + 24, global_position);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_soft_body_move_point__23__2__9__r0);
            Helpers.WaitForCompletion();
        }

        public Vector3 soft_body_get_point_global_position(ulong body, long point_index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, point_index);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_soft_body_get_point_global_position__23__2__r9);
            Helpers.WaitForCompletion();
            Vector3 result = Helpers.ReadVector3(Commands.CMD_DATA);
            return result;
        }

        public void soft_body_remove_all_pinned_points(ulong body)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_soft_body_remove_all_pinned_points__23__r0);
            Helpers.WaitForCompletion();
        }

        public void soft_body_pin_point(ulong body, long point_index, bool pin)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, point_index);
            Helpers.WriteInt32(Commands.CMD_DATA + 24, pin ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_soft_body_pin_point__23__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool soft_body_is_point_pinned(ulong body, long point_index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, point_index);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_soft_body_is_point_pinned__23__2__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void soft_body_apply_point_impulse(ulong body, long point_index, Vector3 impulse)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, point_index);
            Helpers.WriteVector3(Commands.CMD_DATA + 24, impulse);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_soft_body_apply_point_impulse__23__2__9__r0);
            Helpers.WaitForCompletion();
        }

        public void soft_body_apply_point_force(ulong body, long point_index, Vector3 force)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, point_index);
            Helpers.WriteVector3(Commands.CMD_DATA + 24, force);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_soft_body_apply_point_force__23__2__9__r0);
            Helpers.WaitForCompletion();
        }

        public void soft_body_apply_central_impulse(ulong body, Vector3 impulse)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteVector3(Commands.CMD_DATA + 16, impulse);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_soft_body_apply_central_impulse__23__9__r0);
            Helpers.WaitForCompletion();
        }

        public void soft_body_apply_central_force(ulong body, Vector3 force)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteVector3(Commands.CMD_DATA + 16, force);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_soft_body_apply_central_force__23__9__r0);
            Helpers.WaitForCompletion();
        }

        public ulong joint_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_joint_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void joint_clear(ulong joint)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, joint);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_joint_clear__23__r0);
            Helpers.WaitForCompletion();
        }

        public void joint_make_pin(ulong joint, ulong body_A, Vector3 local_A, ulong body_B, Vector3 local_B)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, joint);
            Helpers.WriteRID(Commands.CMD_DATA + 16, body_A);
            Helpers.WriteVector3(Commands.CMD_DATA + 24, local_A);
            Helpers.WriteRID(Commands.CMD_DATA + 36, body_B);
            Helpers.WriteVector3(Commands.CMD_DATA + 44, local_B);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_joint_make_pin__23__23__9__23__9__r0);
            Helpers.WaitForCompletion();
        }

        public void pin_joint_set_param(ulong joint, long param, double value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, joint);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, param);
            Helpers.WriteDouble(Commands.CMD_DATA + 24, value);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_pin_joint_set_param__23__2__3__r0);
            Helpers.WaitForCompletion();
        }

        public double pin_joint_get_param(ulong joint, long param)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, joint);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, param);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_pin_joint_get_param__23__2__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void pin_joint_set_local_a(ulong joint, Vector3 local_A)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, joint);
            Helpers.WriteVector3(Commands.CMD_DATA + 16, local_A);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_pin_joint_set_local_a__23__9__r0);
            Helpers.WaitForCompletion();
        }

        public Vector3 pin_joint_get_local_a(ulong joint)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, joint);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_pin_joint_get_local_a__23__r9);
            Helpers.WaitForCompletion();
            Vector3 result = Helpers.ReadVector3(Commands.CMD_DATA);
            return result;
        }

        public void pin_joint_set_local_b(ulong joint, Vector3 local_B)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, joint);
            Helpers.WriteVector3(Commands.CMD_DATA + 16, local_B);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_pin_joint_set_local_b__23__9__r0);
            Helpers.WaitForCompletion();
        }

        public Vector3 pin_joint_get_local_b(ulong joint)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, joint);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_pin_joint_get_local_b__23__r9);
            Helpers.WaitForCompletion();
            Vector3 result = Helpers.ReadVector3(Commands.CMD_DATA);
            return result;
        }

        public void joint_make_hinge(ulong joint, ulong body_A, Transform3D hinge_A, ulong body_B, Transform3D hinge_B)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, joint);
            Helpers.WriteRID(Commands.CMD_DATA + 16, body_A);
            Helpers.WriteTransform3D(Commands.CMD_DATA + 24, hinge_A);
            Helpers.WriteRID(Commands.CMD_DATA + 72, body_B);
            Helpers.WriteTransform3D(Commands.CMD_DATA + 80, hinge_B);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_joint_make_hinge__23__23__18__23__18__r0);
            Helpers.WaitForCompletion();
        }

        public void hinge_joint_set_param(ulong joint, long param, double value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, joint);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, param);
            Helpers.WriteDouble(Commands.CMD_DATA + 24, value);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_hinge_joint_set_param__23__2__3__r0);
            Helpers.WaitForCompletion();
        }

        public double hinge_joint_get_param(ulong joint, long param)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, joint);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, param);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_hinge_joint_get_param__23__2__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void hinge_joint_set_flag(ulong joint, long flag, bool enabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, joint);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, flag);
            Helpers.WriteInt32(Commands.CMD_DATA + 24, enabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_hinge_joint_set_flag__23__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool hinge_joint_get_flag(ulong joint, long flag)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, joint);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, flag);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_hinge_joint_get_flag__23__2__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void joint_make_slider(ulong joint, ulong body_A, Transform3D local_ref_A, ulong body_B, Transform3D local_ref_B)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, joint);
            Helpers.WriteRID(Commands.CMD_DATA + 16, body_A);
            Helpers.WriteTransform3D(Commands.CMD_DATA + 24, local_ref_A);
            Helpers.WriteRID(Commands.CMD_DATA + 72, body_B);
            Helpers.WriteTransform3D(Commands.CMD_DATA + 80, local_ref_B);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_joint_make_slider__23__23__18__23__18__r0);
            Helpers.WaitForCompletion();
        }

        public void slider_joint_set_param(ulong joint, long param, double value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, joint);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, param);
            Helpers.WriteDouble(Commands.CMD_DATA + 24, value);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_slider_joint_set_param__23__2__3__r0);
            Helpers.WaitForCompletion();
        }

        public double slider_joint_get_param(ulong joint, long param)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, joint);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, param);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_slider_joint_get_param__23__2__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void joint_make_cone_twist(ulong joint, ulong body_A, Transform3D local_ref_A, ulong body_B, Transform3D local_ref_B)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, joint);
            Helpers.WriteRID(Commands.CMD_DATA + 16, body_A);
            Helpers.WriteTransform3D(Commands.CMD_DATA + 24, local_ref_A);
            Helpers.WriteRID(Commands.CMD_DATA + 72, body_B);
            Helpers.WriteTransform3D(Commands.CMD_DATA + 80, local_ref_B);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_joint_make_cone_twist__23__23__18__23__18__r0);
            Helpers.WaitForCompletion();
        }

        public void cone_twist_joint_set_param(ulong joint, long param, double value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, joint);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, param);
            Helpers.WriteDouble(Commands.CMD_DATA + 24, value);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_cone_twist_joint_set_param__23__2__3__r0);
            Helpers.WaitForCompletion();
        }

        public double cone_twist_joint_get_param(ulong joint, long param)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, joint);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, param);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_cone_twist_joint_get_param__23__2__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public long joint_get_type(ulong joint)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, joint);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_joint_get_type__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void joint_set_solver_priority(ulong joint, long priority)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, joint);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, priority);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_joint_set_solver_priority__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long joint_get_solver_priority(ulong joint)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, joint);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_joint_get_solver_priority__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void joint_disable_collisions_between_bodies(ulong joint, bool disable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, joint);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, disable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_joint_disable_collisions_between_bodies__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool joint_is_disabled_collisions_between_bodies(ulong joint)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, joint);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_joint_is_disabled_collisions_between_bodies__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void joint_make_generic_6dof(ulong joint, ulong body_A, Transform3D local_ref_A, ulong body_B, Transform3D local_ref_B)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, joint);
            Helpers.WriteRID(Commands.CMD_DATA + 16, body_A);
            Helpers.WriteTransform3D(Commands.CMD_DATA + 24, local_ref_A);
            Helpers.WriteRID(Commands.CMD_DATA + 72, body_B);
            Helpers.WriteTransform3D(Commands.CMD_DATA + 80, local_ref_B);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_joint_make_generic_6dof__23__23__18__23__18__r0);
            Helpers.WaitForCompletion();
        }

        public void generic_6dof_joint_set_param(ulong joint, long axis, long param, double value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, joint);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, axis);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, param);
            Helpers.WriteDouble(Commands.CMD_DATA + 32, value);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_generic_6dof_joint_set_param__23__2__2__3__r0);
            Helpers.WaitForCompletion();
        }

        public double generic_6dof_joint_get_param(ulong joint, long axis, long param)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, joint);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, axis);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, param);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_generic_6dof_joint_get_param__23__2__2__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void generic_6dof_joint_set_flag(ulong joint, long axis, long flag, bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, joint);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, axis);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, flag);
            Helpers.WriteInt32(Commands.CMD_DATA + 32, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_generic_6dof_joint_set_flag__23__2__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool generic_6dof_joint_get_flag(ulong joint, long axis, long flag)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, joint);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, axis);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, flag);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_generic_6dof_joint_get_flag__23__2__2__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void free_rid(ulong rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_free_rid__23__r0);
            Helpers.WaitForCompletion();
        }

        public void set_active(bool active)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, active ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_set_active__1__r0);
            Helpers.WaitForCompletion();
        }

        public long get_process_info(long process_info)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, process_info);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_get_process_info__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void free()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_free__r0);
            Helpers.WaitForCompletion();
        }

        public void _init()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D__init__r0);
            Helpers.WaitForCompletion();
        }

        public string _to_string()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D__to_string__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void _notification(long what)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, what);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D__notification__2__r0);
            Helpers.WaitForCompletion();
        }

        public bool _set(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D__set__21__0__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _get(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D__get__21__r0);
            Helpers.WaitForCompletion();
        }

        public object _get_property_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D__get_property_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void _validate_property(object property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDictionary(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D__validate_property__27__r0);
            Helpers.WaitForCompletion();
        }

        public bool _property_can_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D__property_can_revert__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _property_get_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D__property_get_revert__21__r0);
            Helpers.WaitForCompletion();
        }

        public bool _iter_init(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteArray(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D__iter_init__28__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool _iter_next(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteArray(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D__iter_next__28__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _iter_get(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVariant(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D__iter_get__0__r0);
            Helpers.WaitForCompletion();
        }

        public string get_class()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_get_class__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public bool is_class(string class_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, class_);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_is_class__4__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_set__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_get__21__r0);
            Helpers.WaitForCompletion();
        }

        public void set_indexed(string property_path, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, property_path);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_set_indexed__22__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get_indexed(string property_path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, property_path);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_get_indexed__22__r0);
            Helpers.WaitForCompletion();
        }

        public object get_property_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_get_property_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_method_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_get_method_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public bool property_can_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_property_can_revert__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void property_get_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_property_get_revert__21__r0);
            Helpers.WaitForCompletion();
        }

        public void notification(long what, bool reversed)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, what);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, reversed ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_notification__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public string to_string()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_to_string__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public ulong get_instance_id()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_get_instance_id__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_script(object script)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVariant(Commands.CMD_DATA + 8, script);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_set_script__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get_script()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_get_script__r0);
            Helpers.WaitForCompletion();
        }

        public void set_meta(string name, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_set_meta__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void remove_meta(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_remove_meta__21__r0);
            Helpers.WaitForCompletion();
        }

        public void get_meta(string name, object default_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, default_);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_get_meta__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_meta(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_has_meta__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public object get_meta_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_get_meta_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void add_user_signal(string signal, object arguments)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, signal);
            Helpers.WriteArray(Commands.CMD_DATA + 1036, arguments);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_add_user_signal__4__28__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_user_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_has_user_signal__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void remove_user_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_remove_user_signal__21__r0);
            Helpers.WaitForCompletion();
        }

        public long emit_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_emit_signal__21__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void call(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_call__21__r0);
            Helpers.WaitForCompletion();
        }

        public void call_deferred(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_call_deferred__21__r0);
            Helpers.WaitForCompletion();
        }

        public void set_deferred(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_set_deferred__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void callv(string method, object arg_array)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.WriteArray(Commands.CMD_DATA + 1036, arg_array);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_callv__21__28__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_method(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_has_method__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public long get_method_argument_count(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_get_method_argument_count__21__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool has_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_has_signal__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public object get_signal_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_get_signal_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_signal_connection_list(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_get_signal_connection_list__21__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_incoming_connections()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_get_incoming_connections__r28);
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
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_connect__21__25__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void disconnect(string signal, object callable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.WriteCallable(Commands.CMD_DATA + 1036, callable);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_disconnect__21__25__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_connected(string signal, object callable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.WriteCallable(Commands.CMD_DATA + 1036, callable);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_is_connected__21__25__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool has_connections(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_has_connections__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_block_signals(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_set_block_signals__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_blocking_signals()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_is_blocking_signals__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void notify_property_list_changed()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_notify_property_list_changed__r0);
            Helpers.WaitForCompletion();
        }

        public void set_message_translation(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_set_message_translation__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool can_translate_messages()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_can_translate_messages__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public string tr(string message, string context)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, message);
            Helpers.WriteStringName(Commands.CMD_DATA + 1036, context);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_tr__21__21__r4);
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
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_tr_n__21__21__2__21__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public string get_translation_domain()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_get_translation_domain__r21);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadStringName(Commands.CMD_DATA);
            return result;
        }

        public void set_translation_domain(string domain)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, domain);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_set_translation_domain__21__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_queued_for_deletion()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_is_queued_for_deletion__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void cancel_free()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_cancel_free__r0);
            Helpers.WaitForCompletion();
        }

        public ulong get_singleton()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer3D_get_singleton__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

    }
}
