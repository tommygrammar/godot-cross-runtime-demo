using System;

namespace GodotWeb
{
    public class PhysicsDirectSpaceState3DExtension : GodotObject
    {
        public PhysicsDirectSpaceState3DExtension(ulong id) : base(id) { }

        public bool _intersect_ray(Vector3 from, Vector3 to, long collision_mask, bool collide_with_bodies, bool collide_with_areas, bool hit_from_inside, bool hit_back_faces, bool pick_ray, long arg_result)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector3(Commands.CMD_DATA + 8, from);
            Helpers.WriteVector3(Commands.CMD_DATA + 20, to);
            Helpers.WriteInt64(Commands.CMD_DATA + 32, collision_mask);
            Helpers.WriteInt32(Commands.CMD_DATA + 40, collide_with_bodies ? 1 : 0);
            Helpers.WriteInt32(Commands.CMD_DATA + 44, collide_with_areas ? 1 : 0);
            Helpers.WriteInt32(Commands.CMD_DATA + 48, hit_from_inside ? 1 : 0);
            Helpers.WriteInt32(Commands.CMD_DATA + 52, hit_back_faces ? 1 : 0);
            Helpers.WriteInt32(Commands.CMD_DATA + 56, pick_ray ? 1 : 0);
            Helpers.WriteInt64(Commands.CMD_DATA + 60, arg_result);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension__intersect_ray__9__9__2__1__1__1__1__1__2__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public long _intersect_point(Vector3 position, long collision_mask, bool collide_with_bodies, bool collide_with_areas, long results, long max_results)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector3(Commands.CMD_DATA + 8, position);
            Helpers.WriteInt64(Commands.CMD_DATA + 20, collision_mask);
            Helpers.WriteInt32(Commands.CMD_DATA + 28, collide_with_bodies ? 1 : 0);
            Helpers.WriteInt32(Commands.CMD_DATA + 32, collide_with_areas ? 1 : 0);
            Helpers.WriteInt64(Commands.CMD_DATA + 36, results);
            Helpers.WriteInt64(Commands.CMD_DATA + 44, max_results);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension__intersect_point__9__2__1__1__2__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long _intersect_shape(ulong shape_rid, Transform3D transform, Vector3 motion, double margin, long collision_mask, bool collide_with_bodies, bool collide_with_areas, long result_count, long max_results)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shape_rid);
            Helpers.WriteTransform3D(Commands.CMD_DATA + 16, transform);
            Helpers.WriteVector3(Commands.CMD_DATA + 64, motion);
            Helpers.WriteDouble(Commands.CMD_DATA + 76, margin);
            Helpers.WriteInt64(Commands.CMD_DATA + 84, collision_mask);
            Helpers.WriteInt32(Commands.CMD_DATA + 92, collide_with_bodies ? 1 : 0);
            Helpers.WriteInt32(Commands.CMD_DATA + 96, collide_with_areas ? 1 : 0);
            Helpers.WriteInt64(Commands.CMD_DATA + 100, result_count);
            Helpers.WriteInt64(Commands.CMD_DATA + 108, max_results);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension__intersect_shape__23__18__9__3__2__1__1__2__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool _cast_motion(ulong shape_rid, Transform3D transform, Vector3 motion, double margin, long collision_mask, bool collide_with_bodies, bool collide_with_areas, long closest_safe, long closest_unsafe, long info)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shape_rid);
            Helpers.WriteTransform3D(Commands.CMD_DATA + 16, transform);
            Helpers.WriteVector3(Commands.CMD_DATA + 64, motion);
            Helpers.WriteDouble(Commands.CMD_DATA + 76, margin);
            Helpers.WriteInt64(Commands.CMD_DATA + 84, collision_mask);
            Helpers.WriteInt32(Commands.CMD_DATA + 92, collide_with_bodies ? 1 : 0);
            Helpers.WriteInt32(Commands.CMD_DATA + 96, collide_with_areas ? 1 : 0);
            Helpers.WriteInt64(Commands.CMD_DATA + 100, closest_safe);
            Helpers.WriteInt64(Commands.CMD_DATA + 108, closest_unsafe);
            Helpers.WriteInt64(Commands.CMD_DATA + 116, info);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension__cast_motion__23__18__9__3__2__1__1__2__2__2__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool _collide_shape(ulong shape_rid, Transform3D transform, Vector3 motion, double margin, long collision_mask, bool collide_with_bodies, bool collide_with_areas, long results, long max_results, long result_count)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shape_rid);
            Helpers.WriteTransform3D(Commands.CMD_DATA + 16, transform);
            Helpers.WriteVector3(Commands.CMD_DATA + 64, motion);
            Helpers.WriteDouble(Commands.CMD_DATA + 76, margin);
            Helpers.WriteInt64(Commands.CMD_DATA + 84, collision_mask);
            Helpers.WriteInt32(Commands.CMD_DATA + 92, collide_with_bodies ? 1 : 0);
            Helpers.WriteInt32(Commands.CMD_DATA + 96, collide_with_areas ? 1 : 0);
            Helpers.WriteInt64(Commands.CMD_DATA + 100, results);
            Helpers.WriteInt64(Commands.CMD_DATA + 108, max_results);
            Helpers.WriteInt64(Commands.CMD_DATA + 116, result_count);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension__collide_shape__23__18__9__3__2__1__1__2__2__2__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool _rest_info(ulong shape_rid, Transform3D transform, Vector3 motion, double margin, long collision_mask, bool collide_with_bodies, bool collide_with_areas, long rest_info)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shape_rid);
            Helpers.WriteTransform3D(Commands.CMD_DATA + 16, transform);
            Helpers.WriteVector3(Commands.CMD_DATA + 64, motion);
            Helpers.WriteDouble(Commands.CMD_DATA + 76, margin);
            Helpers.WriteInt64(Commands.CMD_DATA + 84, collision_mask);
            Helpers.WriteInt32(Commands.CMD_DATA + 92, collide_with_bodies ? 1 : 0);
            Helpers.WriteInt32(Commands.CMD_DATA + 96, collide_with_areas ? 1 : 0);
            Helpers.WriteInt64(Commands.CMD_DATA + 100, rest_info);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension__rest_info__23__18__9__3__2__1__1__2__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public Vector3 _get_closest_point_to_object_volume(ulong object_, Vector3 point)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, object_);
            Helpers.WriteVector3(Commands.CMD_DATA + 16, point);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension__get_closest_point_to_object_volume__23__9__r9);
            Helpers.WaitForCompletion();
            Vector3 result = Helpers.ReadVector3(Commands.CMD_DATA);
            return result;
        }

        public bool is_body_excluded_from_query(ulong body)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, body);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension_is_body_excluded_from_query__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public object intersect_point(ulong parameters, long max_results)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, parameters);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, max_results);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension_intersect_point__24__2__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object intersect_ray(ulong parameters)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, parameters);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension_intersect_ray__24__r27);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadDictionary(Commands.CMD_DATA);
            return result;
        }

        public object intersect_shape(ulong parameters, long max_results)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, parameters);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, max_results);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension_intersect_shape__24__2__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public float[] cast_motion(ulong parameters)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, parameters);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension_cast_motion__24__r32);
            Helpers.WaitForCompletion();
            float[] result = Helpers.ReadPackedFloat32Array(Commands.CMD_DATA);
            return result;
        }

        public object collide_shape(ulong parameters, long max_results)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, parameters);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, max_results);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension_collide_shape__24__2__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_rest_info(ulong parameters)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, parameters);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension_get_rest_info__24__r27);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadDictionary(Commands.CMD_DATA);
            return result;
        }

        public void free()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension_free__r0);
            Helpers.WaitForCompletion();
        }

        public void _init()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension__init__r0);
            Helpers.WaitForCompletion();
        }

        public string _to_string()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension__to_string__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void _notification(long what)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, what);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension__notification__2__r0);
            Helpers.WaitForCompletion();
        }

        public bool _set(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension__set__21__0__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _get(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension__get__21__r0);
            Helpers.WaitForCompletion();
        }

        public object _get_property_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension__get_property_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void _validate_property(object property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDictionary(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension__validate_property__27__r0);
            Helpers.WaitForCompletion();
        }

        public bool _property_can_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension__property_can_revert__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _property_get_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension__property_get_revert__21__r0);
            Helpers.WaitForCompletion();
        }

        public bool _iter_init(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteArray(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension__iter_init__28__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool _iter_next(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteArray(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension__iter_next__28__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _iter_get(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVariant(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension__iter_get__0__r0);
            Helpers.WaitForCompletion();
        }

        public string get_class()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension_get_class__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public bool is_class(string class_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, class_);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension_is_class__4__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension_set__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension_get__21__r0);
            Helpers.WaitForCompletion();
        }

        public void set_indexed(string property_path, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, property_path);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension_set_indexed__22__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get_indexed(string property_path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, property_path);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension_get_indexed__22__r0);
            Helpers.WaitForCompletion();
        }

        public object get_property_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension_get_property_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_method_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension_get_method_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public bool property_can_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension_property_can_revert__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void property_get_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension_property_get_revert__21__r0);
            Helpers.WaitForCompletion();
        }

        public void notification(long what, bool reversed)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, what);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, reversed ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension_notification__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public string to_string()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension_to_string__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public ulong get_instance_id()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension_get_instance_id__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_script(object script)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVariant(Commands.CMD_DATA + 8, script);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension_set_script__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get_script()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension_get_script__r0);
            Helpers.WaitForCompletion();
        }

        public void set_meta(string name, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension_set_meta__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void remove_meta(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension_remove_meta__21__r0);
            Helpers.WaitForCompletion();
        }

        public void get_meta(string name, object default_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, default_);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension_get_meta__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_meta(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension_has_meta__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public object get_meta_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension_get_meta_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void add_user_signal(string signal, object arguments)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, signal);
            Helpers.WriteArray(Commands.CMD_DATA + 1036, arguments);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension_add_user_signal__4__28__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_user_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension_has_user_signal__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void remove_user_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension_remove_user_signal__21__r0);
            Helpers.WaitForCompletion();
        }

        public long emit_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension_emit_signal__21__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void call(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension_call__21__r0);
            Helpers.WaitForCompletion();
        }

        public void call_deferred(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension_call_deferred__21__r0);
            Helpers.WaitForCompletion();
        }

        public void set_deferred(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension_set_deferred__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void callv(string method, object arg_array)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.WriteArray(Commands.CMD_DATA + 1036, arg_array);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension_callv__21__28__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_method(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension_has_method__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public long get_method_argument_count(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension_get_method_argument_count__21__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool has_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension_has_signal__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public object get_signal_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension_get_signal_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_signal_connection_list(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension_get_signal_connection_list__21__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_incoming_connections()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension_get_incoming_connections__r28);
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
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension_connect__21__25__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void disconnect(string signal, object callable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.WriteCallable(Commands.CMD_DATA + 1036, callable);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension_disconnect__21__25__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_connected(string signal, object callable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.WriteCallable(Commands.CMD_DATA + 1036, callable);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension_is_connected__21__25__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool has_connections(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension_has_connections__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_block_signals(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension_set_block_signals__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_blocking_signals()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension_is_blocking_signals__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void notify_property_list_changed()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension_notify_property_list_changed__r0);
            Helpers.WaitForCompletion();
        }

        public void set_message_translation(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension_set_message_translation__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool can_translate_messages()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension_can_translate_messages__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public string tr(string message, string context)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, message);
            Helpers.WriteStringName(Commands.CMD_DATA + 1036, context);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension_tr__21__21__r4);
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
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension_tr_n__21__21__2__21__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public string get_translation_domain()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension_get_translation_domain__r21);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadStringName(Commands.CMD_DATA);
            return result;
        }

        public void set_translation_domain(string domain)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, domain);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension_set_translation_domain__21__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_queued_for_deletion()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension_is_queued_for_deletion__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void cancel_free()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_PhysicsDirectSpaceState3DExtension_cancel_free__r0);
            Helpers.WaitForCompletion();
        }

    }
}
