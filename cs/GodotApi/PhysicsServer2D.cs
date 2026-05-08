using System;

namespace GodotWeb
{
    public class PhysicsServer2D : GodotObject
    {
        public PhysicsServer2D(ulong id) : base(id) { }

        public ulong world_boundary_shape_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_world_boundary_shape_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public ulong separation_ray_shape_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_separation_ray_shape_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public ulong segment_shape_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_segment_shape_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public ulong circle_shape_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_circle_shape_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public ulong rectangle_shape_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_rectangle_shape_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public ulong capsule_shape_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_capsule_shape_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public ulong convex_polygon_shape_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_convex_polygon_shape_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public ulong concave_polygon_shape_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_concave_polygon_shape_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void shape_set_data(ulong shape, object arg_data)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shape);
            Helpers.WriteVariant(Commands.CMD_DATA + 16, arg_data);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_shape_set_data__23__0__r0);
            Helpers.WaitForCompletion();
        }

        public long shape_get_type(ulong shape)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shape);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_shape_get_type__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void shape_get_data(ulong shape)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shape);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_shape_get_data__23__r0);
            Helpers.WaitForCompletion();
        }

        public ulong space_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_space_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void space_set_active(ulong space, bool active)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, space);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, active ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_space_set_active__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool space_is_active(ulong space)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, space);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_space_is_active__23__r1);
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
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_space_set_param__23__2__3__r0);
            Helpers.WaitForCompletion();
        }

        public double space_get_param(ulong space, long param)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, space);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, param);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_space_get_param__23__2__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public ulong space_get_direct_state(ulong space)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, space);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_space_get_direct_state__23__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong area_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_area_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void area_set_space(ulong area, ulong space)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, area);
            Helpers.WriteRID(Commands.CMD_DATA + 16, space);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_area_set_space__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public ulong area_get_space(ulong area)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, area);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_area_get_space__23__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void area_add_shape(ulong area, ulong shape, Transform2D transform, bool disabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, area);
            Helpers.WriteRID(Commands.CMD_DATA + 16, shape);
            Helpers.WriteTransform2D(Commands.CMD_DATA + 24, transform);
            Helpers.WriteInt32(Commands.CMD_DATA + 48, disabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_area_add_shape__23__23__11__1__r0);
            Helpers.WaitForCompletion();
        }

        public void area_set_shape(ulong area, long shape_idx, ulong shape)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, area);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, shape_idx);
            Helpers.WriteRID(Commands.CMD_DATA + 24, shape);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_area_set_shape__23__2__23__r0);
            Helpers.WaitForCompletion();
        }

        public void area_set_shape_transform(ulong area, long shape_idx, Transform2D transform)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, area);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, shape_idx);
            Helpers.WriteTransform2D(Commands.CMD_DATA + 24, transform);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_area_set_shape_transform__23__2__11__r0);
            Helpers.WaitForCompletion();
        }

        public void area_set_shape_disabled(ulong area, long shape_idx, bool disabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, area);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, shape_idx);
            Helpers.WriteInt32(Commands.CMD_DATA + 24, disabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_area_set_shape_disabled__23__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public long area_get_shape_count(ulong area)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, area);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_area_get_shape_count__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong area_get_shape(ulong area, long shape_idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, area);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, shape_idx);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_area_get_shape__23__2__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public Transform2D area_get_shape_transform(ulong area, long shape_idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, area);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, shape_idx);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_area_get_shape_transform__23__2__r11);
            Helpers.WaitForCompletion();
            Transform2D result = Helpers.ReadTransform2D(Commands.CMD_DATA);
            return result;
        }

        public void area_remove_shape(ulong area, long shape_idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, area);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, shape_idx);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_area_remove_shape__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void area_clear_shapes(ulong area)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, area);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_area_clear_shapes__23__r0);
            Helpers.WaitForCompletion();
        }

        public void area_set_collision_layer(ulong area, long layer)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, area);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, layer);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_area_set_collision_layer__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long area_get_collision_layer(ulong area)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, area);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_area_get_collision_layer__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void area_set_collision_mask(ulong area, long mask)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, area);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, mask);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_area_set_collision_mask__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long area_get_collision_mask(ulong area)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, area);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_area_get_collision_mask__23__r2);
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
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_area_set_param__23__2__0__r0);
            Helpers.WaitForCompletion();
        }

        public void area_set_transform(ulong area, Transform2D transform)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, area);
            Helpers.WriteTransform2D(Commands.CMD_DATA + 16, transform);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_area_set_transform__23__11__r0);
            Helpers.WaitForCompletion();
        }

        public void area_get_param(ulong area, long param)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, area);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, param);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_area_get_param__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public Transform2D area_get_transform(ulong area)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, area);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_area_get_transform__23__r11);
            Helpers.WaitForCompletion();
            Transform2D result = Helpers.ReadTransform2D(Commands.CMD_DATA);
            return result;
        }

        public void area_attach_object_instance_id(ulong area, long id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, area);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_area_attach_object_instance_id__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long area_get_object_instance_id(ulong area)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, area);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_area_get_object_instance_id__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void area_attach_canvas_instance_id(ulong area, long id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, area);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_area_attach_canvas_instance_id__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long area_get_canvas_instance_id(ulong area)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, area);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_area_get_canvas_instance_id__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void area_set_monitor_callback(ulong area, object callback)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, area);
            Helpers.WriteCallable(Commands.CMD_DATA + 16, callback);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_area_set_monitor_callback__23__25__r0);
            Helpers.WaitForCompletion();
        }

        public void area_set_area_monitor_callback(ulong area, object callback)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, area);
            Helpers.WriteCallable(Commands.CMD_DATA + 16, callback);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_area_set_area_monitor_callback__23__25__r0);
            Helpers.WaitForCompletion();
        }

        public void area_set_monitorable(ulong area, bool monitorable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, area);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, monitorable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_area_set_monitorable__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public ulong body_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_body_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void body_set_space(ulong body, ulong space)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteRID(Commands.CMD_DATA + 16, space);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_body_set_space__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public ulong body_get_space(ulong body)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_body_get_space__23__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void body_set_mode(ulong body, long mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, mode);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_body_set_mode__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long body_get_mode(ulong body)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_body_get_mode__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void body_add_shape(ulong body, ulong shape, Transform2D transform, bool disabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteRID(Commands.CMD_DATA + 16, shape);
            Helpers.WriteTransform2D(Commands.CMD_DATA + 24, transform);
            Helpers.WriteInt32(Commands.CMD_DATA + 48, disabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_body_add_shape__23__23__11__1__r0);
            Helpers.WaitForCompletion();
        }

        public void body_set_shape(ulong body, long shape_idx, ulong shape)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, shape_idx);
            Helpers.WriteRID(Commands.CMD_DATA + 24, shape);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_body_set_shape__23__2__23__r0);
            Helpers.WaitForCompletion();
        }

        public void body_set_shape_transform(ulong body, long shape_idx, Transform2D transform)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, shape_idx);
            Helpers.WriteTransform2D(Commands.CMD_DATA + 24, transform);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_body_set_shape_transform__23__2__11__r0);
            Helpers.WaitForCompletion();
        }

        public long body_get_shape_count(ulong body)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_body_get_shape_count__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong body_get_shape(ulong body, long shape_idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, shape_idx);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_body_get_shape__23__2__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public Transform2D body_get_shape_transform(ulong body, long shape_idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, shape_idx);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_body_get_shape_transform__23__2__r11);
            Helpers.WaitForCompletion();
            Transform2D result = Helpers.ReadTransform2D(Commands.CMD_DATA);
            return result;
        }

        public void body_remove_shape(ulong body, long shape_idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, shape_idx);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_body_remove_shape__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void body_clear_shapes(ulong body)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_body_clear_shapes__23__r0);
            Helpers.WaitForCompletion();
        }

        public void body_set_shape_disabled(ulong body, long shape_idx, bool disabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, shape_idx);
            Helpers.WriteInt32(Commands.CMD_DATA + 24, disabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_body_set_shape_disabled__23__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public void body_set_shape_as_one_way_collision(ulong body, long shape_idx, bool enable, double margin)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, shape_idx);
            Helpers.WriteInt32(Commands.CMD_DATA + 24, enable ? 1 : 0);
            Helpers.WriteDouble(Commands.CMD_DATA + 28, margin);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_body_set_shape_as_one_way_collision__23__2__1__3__r0);
            Helpers.WaitForCompletion();
        }

        public void body_attach_object_instance_id(ulong body, long id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_body_attach_object_instance_id__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long body_get_object_instance_id(ulong body)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_body_get_object_instance_id__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void body_attach_canvas_instance_id(ulong body, long id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_body_attach_canvas_instance_id__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long body_get_canvas_instance_id(ulong body)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_body_get_canvas_instance_id__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void body_set_continuous_collision_detection_mode(ulong body, long mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, mode);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_body_set_continuous_collision_detection_mode__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long body_get_continuous_collision_detection_mode(ulong body)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_body_get_continuous_collision_detection_mode__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void body_set_collision_layer(ulong body, long layer)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, layer);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_body_set_collision_layer__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long body_get_collision_layer(ulong body)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_body_get_collision_layer__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void body_set_collision_mask(ulong body, long mask)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, mask);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_body_set_collision_mask__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long body_get_collision_mask(ulong body)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_body_get_collision_mask__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void body_set_collision_priority(ulong body, double priority)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, priority);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_body_set_collision_priority__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public double body_get_collision_priority(ulong body)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_body_get_collision_priority__23__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void body_set_param(ulong body, long param, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, param);
            Helpers.WriteVariant(Commands.CMD_DATA + 24, value);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_body_set_param__23__2__0__r0);
            Helpers.WaitForCompletion();
        }

        public void body_get_param(ulong body, long param)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, param);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_body_get_param__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void body_reset_mass_properties(ulong body)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_body_reset_mass_properties__23__r0);
            Helpers.WaitForCompletion();
        }

        public void body_set_state(ulong body, long state, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, state);
            Helpers.WriteVariant(Commands.CMD_DATA + 24, value);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_body_set_state__23__2__0__r0);
            Helpers.WaitForCompletion();
        }

        public void body_get_state(ulong body, long state)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, state);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_body_get_state__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void body_apply_central_impulse(ulong body, Vector2 impulse)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteVector2(Commands.CMD_DATA + 16, impulse);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_body_apply_central_impulse__23__5__r0);
            Helpers.WaitForCompletion();
        }

        public void body_apply_torque_impulse(ulong body, double impulse)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, impulse);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_body_apply_torque_impulse__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public void body_apply_impulse(ulong body, Vector2 impulse, Vector2 position)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteVector2(Commands.CMD_DATA + 16, impulse);
            Helpers.WriteVector2(Commands.CMD_DATA + 24, position);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_body_apply_impulse__23__5__5__r0);
            Helpers.WaitForCompletion();
        }

        public void body_apply_central_force(ulong body, Vector2 force)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteVector2(Commands.CMD_DATA + 16, force);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_body_apply_central_force__23__5__r0);
            Helpers.WaitForCompletion();
        }

        public void body_apply_force(ulong body, Vector2 force, Vector2 position)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteVector2(Commands.CMD_DATA + 16, force);
            Helpers.WriteVector2(Commands.CMD_DATA + 24, position);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_body_apply_force__23__5__5__r0);
            Helpers.WaitForCompletion();
        }

        public void body_apply_torque(ulong body, double torque)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, torque);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_body_apply_torque__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public void body_add_constant_central_force(ulong body, Vector2 force)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteVector2(Commands.CMD_DATA + 16, force);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_body_add_constant_central_force__23__5__r0);
            Helpers.WaitForCompletion();
        }

        public void body_add_constant_force(ulong body, Vector2 force, Vector2 position)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteVector2(Commands.CMD_DATA + 16, force);
            Helpers.WriteVector2(Commands.CMD_DATA + 24, position);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_body_add_constant_force__23__5__5__r0);
            Helpers.WaitForCompletion();
        }

        public void body_add_constant_torque(ulong body, double torque)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, torque);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_body_add_constant_torque__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public void body_set_constant_force(ulong body, Vector2 force)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteVector2(Commands.CMD_DATA + 16, force);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_body_set_constant_force__23__5__r0);
            Helpers.WaitForCompletion();
        }

        public Vector2 body_get_constant_force(ulong body)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_body_get_constant_force__23__r5);
            Helpers.WaitForCompletion();
            Vector2 result = Helpers.ReadVector2(Commands.CMD_DATA);
            return result;
        }

        public void body_set_constant_torque(ulong body, double torque)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, torque);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_body_set_constant_torque__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public double body_get_constant_torque(ulong body)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_body_get_constant_torque__23__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void body_set_axis_velocity(ulong body, Vector2 axis_velocity)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteVector2(Commands.CMD_DATA + 16, axis_velocity);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_body_set_axis_velocity__23__5__r0);
            Helpers.WaitForCompletion();
        }

        public void body_add_collision_exception(ulong body, ulong excepted_body)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteRID(Commands.CMD_DATA + 16, excepted_body);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_body_add_collision_exception__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public void body_remove_collision_exception(ulong body, ulong excepted_body)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteRID(Commands.CMD_DATA + 16, excepted_body);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_body_remove_collision_exception__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public void body_set_max_contacts_reported(ulong body, long amount)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, amount);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_body_set_max_contacts_reported__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long body_get_max_contacts_reported(ulong body)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_body_get_max_contacts_reported__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void body_set_omit_force_integration(ulong body, bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_body_set_omit_force_integration__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool body_is_omitting_force_integration(ulong body)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_body_is_omitting_force_integration__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void body_set_state_sync_callback(ulong body, object callable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteCallable(Commands.CMD_DATA + 16, callable);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_body_set_state_sync_callback__23__25__r0);
            Helpers.WaitForCompletion();
        }

        public void body_set_force_integration_callback(ulong body, object callable, object userdata)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteCallable(Commands.CMD_DATA + 16, callable);
            Helpers.WriteVariant(Commands.CMD_DATA + 16, userdata);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_body_set_force_integration_callback__23__25__0__r0);
            Helpers.WaitForCompletion();
        }

        public bool body_test_motion(ulong body, ulong parameters, ulong arg_result)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.WriteUInt64(Commands.CMD_DATA + 16, parameters);
            Helpers.WriteUInt64(Commands.CMD_DATA + 24, arg_result);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_body_test_motion__23__24__24__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public ulong body_get_direct_state(ulong body)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_body_get_direct_state__23__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong joint_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_joint_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void joint_clear(ulong joint)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, joint);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_joint_clear__23__r0);
            Helpers.WaitForCompletion();
        }

        public void joint_set_param(ulong joint, long param, double value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, joint);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, param);
            Helpers.WriteDouble(Commands.CMD_DATA + 24, value);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_joint_set_param__23__2__3__r0);
            Helpers.WaitForCompletion();
        }

        public double joint_get_param(ulong joint, long param)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, joint);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, param);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_joint_get_param__23__2__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void joint_disable_collisions_between_bodies(ulong joint, bool disable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, joint);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, disable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_joint_disable_collisions_between_bodies__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool joint_is_disabled_collisions_between_bodies(ulong joint)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, joint);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_joint_is_disabled_collisions_between_bodies__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void joint_make_pin(ulong joint, Vector2 anchor, ulong body_a, ulong body_b)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, joint);
            Helpers.WriteVector2(Commands.CMD_DATA + 16, anchor);
            Helpers.WriteRID(Commands.CMD_DATA + 24, body_a);
            Helpers.WriteRID(Commands.CMD_DATA + 32, body_b);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_joint_make_pin__23__5__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public void joint_make_groove(ulong joint, Vector2 groove1_a, Vector2 groove2_a, Vector2 anchor_b, ulong body_a, ulong body_b)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, joint);
            Helpers.WriteVector2(Commands.CMD_DATA + 16, groove1_a);
            Helpers.WriteVector2(Commands.CMD_DATA + 24, groove2_a);
            Helpers.WriteVector2(Commands.CMD_DATA + 32, anchor_b);
            Helpers.WriteRID(Commands.CMD_DATA + 40, body_a);
            Helpers.WriteRID(Commands.CMD_DATA + 48, body_b);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_joint_make_groove__23__5__5__5__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public void joint_make_damped_spring(ulong joint, Vector2 anchor_a, Vector2 anchor_b, ulong body_a, ulong body_b)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, joint);
            Helpers.WriteVector2(Commands.CMD_DATA + 16, anchor_a);
            Helpers.WriteVector2(Commands.CMD_DATA + 24, anchor_b);
            Helpers.WriteRID(Commands.CMD_DATA + 32, body_a);
            Helpers.WriteRID(Commands.CMD_DATA + 40, body_b);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_joint_make_damped_spring__23__5__5__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public void pin_joint_set_flag(ulong joint, long flag, bool enabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, joint);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, flag);
            Helpers.WriteInt32(Commands.CMD_DATA + 24, enabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_pin_joint_set_flag__23__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool pin_joint_get_flag(ulong joint, long flag)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, joint);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, flag);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_pin_joint_get_flag__23__2__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void pin_joint_set_param(ulong joint, long param, double value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, joint);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, param);
            Helpers.WriteDouble(Commands.CMD_DATA + 24, value);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_pin_joint_set_param__23__2__3__r0);
            Helpers.WaitForCompletion();
        }

        public double pin_joint_get_param(ulong joint, long param)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, joint);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, param);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_pin_joint_get_param__23__2__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void damped_spring_joint_set_param(ulong joint, long param, double value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, joint);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, param);
            Helpers.WriteDouble(Commands.CMD_DATA + 24, value);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_damped_spring_joint_set_param__23__2__3__r0);
            Helpers.WaitForCompletion();
        }

        public double damped_spring_joint_get_param(ulong joint, long param)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, joint);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, param);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_damped_spring_joint_get_param__23__2__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public long joint_get_type(ulong joint)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, joint);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_joint_get_type__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void free_rid(ulong rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_free_rid__23__r0);
            Helpers.WaitForCompletion();
        }

        public void set_active(bool active)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, active ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_set_active__1__r0);
            Helpers.WaitForCompletion();
        }

        public long get_process_info(long process_info)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, process_info);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_get_process_info__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void free()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_free__r0);
            Helpers.WaitForCompletion();
        }

        public void _init()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D__init__r0);
            Helpers.WaitForCompletion();
        }

        public string _to_string()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D__to_string__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void _notification(long what)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, what);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D__notification__2__r0);
            Helpers.WaitForCompletion();
        }

        public bool _set(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D__set__21__0__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _get(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D__get__21__r0);
            Helpers.WaitForCompletion();
        }

        public object _get_property_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D__get_property_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void _validate_property(object property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDictionary(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D__validate_property__27__r0);
            Helpers.WaitForCompletion();
        }

        public bool _property_can_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D__property_can_revert__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _property_get_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D__property_get_revert__21__r0);
            Helpers.WaitForCompletion();
        }

        public bool _iter_init(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteArray(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D__iter_init__28__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool _iter_next(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteArray(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D__iter_next__28__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _iter_get(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVariant(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D__iter_get__0__r0);
            Helpers.WaitForCompletion();
        }

        public string get_class()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_get_class__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public bool is_class(string class_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, class_);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_is_class__4__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_set__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_get__21__r0);
            Helpers.WaitForCompletion();
        }

        public void set_indexed(string property_path, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, property_path);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_set_indexed__22__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get_indexed(string property_path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, property_path);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_get_indexed__22__r0);
            Helpers.WaitForCompletion();
        }

        public object get_property_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_get_property_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_method_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_get_method_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public bool property_can_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_property_can_revert__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void property_get_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_property_get_revert__21__r0);
            Helpers.WaitForCompletion();
        }

        public void notification(long what, bool reversed)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, what);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, reversed ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_notification__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public string to_string()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_to_string__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public ulong get_instance_id()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_get_instance_id__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_script(object script)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVariant(Commands.CMD_DATA + 8, script);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_set_script__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get_script()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_get_script__r0);
            Helpers.WaitForCompletion();
        }

        public void set_meta(string name, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_set_meta__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void remove_meta(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_remove_meta__21__r0);
            Helpers.WaitForCompletion();
        }

        public void get_meta(string name, object default_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, default_);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_get_meta__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_meta(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_has_meta__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public object get_meta_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_get_meta_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void add_user_signal(string signal, object arguments)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, signal);
            Helpers.WriteArray(Commands.CMD_DATA + 1036, arguments);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_add_user_signal__4__28__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_user_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_has_user_signal__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void remove_user_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_remove_user_signal__21__r0);
            Helpers.WaitForCompletion();
        }

        public long emit_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_emit_signal__21__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void call(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_call__21__r0);
            Helpers.WaitForCompletion();
        }

        public void call_deferred(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_call_deferred__21__r0);
            Helpers.WaitForCompletion();
        }

        public void set_deferred(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_set_deferred__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void callv(string method, object arg_array)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.WriteArray(Commands.CMD_DATA + 1036, arg_array);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_callv__21__28__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_method(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_has_method__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public long get_method_argument_count(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_get_method_argument_count__21__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool has_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_has_signal__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public object get_signal_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_get_signal_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_signal_connection_list(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_get_signal_connection_list__21__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_incoming_connections()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_get_incoming_connections__r28);
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
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_connect__21__25__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void disconnect(string signal, object callable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.WriteCallable(Commands.CMD_DATA + 1036, callable);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_disconnect__21__25__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_connected(string signal, object callable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.WriteCallable(Commands.CMD_DATA + 1036, callable);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_is_connected__21__25__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool has_connections(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_has_connections__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_block_signals(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_set_block_signals__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_blocking_signals()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_is_blocking_signals__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void notify_property_list_changed()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_notify_property_list_changed__r0);
            Helpers.WaitForCompletion();
        }

        public void set_message_translation(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_set_message_translation__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool can_translate_messages()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_can_translate_messages__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public string tr(string message, string context)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, message);
            Helpers.WriteStringName(Commands.CMD_DATA + 1036, context);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_tr__21__21__r4);
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
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_tr_n__21__21__2__21__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public string get_translation_domain()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_get_translation_domain__r21);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadStringName(Commands.CMD_DATA);
            return result;
        }

        public void set_translation_domain(string domain)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, domain);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_set_translation_domain__21__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_queued_for_deletion()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_is_queued_for_deletion__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void cancel_free()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_cancel_free__r0);
            Helpers.WaitForCompletion();
        }

        public ulong get_singleton()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsServer2D_get_singleton__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

    }
}
