using System;

namespace GodotWeb
{
    public class Geometry2D : GodotObject
    {
        public Geometry2D(ulong id) : base(id) { }

        public bool is_point_in_circle(Vector2 point, Vector2 circle_position, double circle_radius)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2(Commands.CMD_DATA + 8, point);
            Helpers.WriteVector2(Commands.CMD_DATA + 16, circle_position);
            Helpers.WriteDouble(Commands.CMD_DATA + 24, circle_radius);
            Helpers.SendCommand(Commands.CMD_Geometry2D_is_point_in_circle__5__5__3__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public double segment_intersects_circle(Vector2 segment_from, Vector2 segment_to, Vector2 circle_position, double circle_radius)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2(Commands.CMD_DATA + 8, segment_from);
            Helpers.WriteVector2(Commands.CMD_DATA + 16, segment_to);
            Helpers.WriteVector2(Commands.CMD_DATA + 24, circle_position);
            Helpers.WriteDouble(Commands.CMD_DATA + 32, circle_radius);
            Helpers.SendCommand(Commands.CMD_Geometry2D_segment_intersects_circle__5__5__5__3__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void segment_intersects_segment(Vector2 from_a, Vector2 to_a, Vector2 from_b, Vector2 to_b)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2(Commands.CMD_DATA + 8, from_a);
            Helpers.WriteVector2(Commands.CMD_DATA + 16, to_a);
            Helpers.WriteVector2(Commands.CMD_DATA + 24, from_b);
            Helpers.WriteVector2(Commands.CMD_DATA + 32, to_b);
            Helpers.SendCommand(Commands.CMD_Geometry2D_segment_intersects_segment__5__5__5__5__r0);
            Helpers.WaitForCompletion();
        }

        public void line_intersects_line(Vector2 from_a, Vector2 dir_a, Vector2 from_b, Vector2 dir_b)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2(Commands.CMD_DATA + 8, from_a);
            Helpers.WriteVector2(Commands.CMD_DATA + 16, dir_a);
            Helpers.WriteVector2(Commands.CMD_DATA + 24, from_b);
            Helpers.WriteVector2(Commands.CMD_DATA + 32, dir_b);
            Helpers.SendCommand(Commands.CMD_Geometry2D_line_intersects_line__5__5__5__5__r0);
            Helpers.WaitForCompletion();
        }

        public Vector2[] get_closest_points_between_segments(Vector2 p1, Vector2 q1, Vector2 p2, Vector2 q2)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2(Commands.CMD_DATA + 8, p1);
            Helpers.WriteVector2(Commands.CMD_DATA + 16, q1);
            Helpers.WriteVector2(Commands.CMD_DATA + 24, p2);
            Helpers.WriteVector2(Commands.CMD_DATA + 32, q2);
            Helpers.SendCommand(Commands.CMD_Geometry2D_get_closest_points_between_segments__5__5__5__5__r35);
            Helpers.WaitForCompletion();
            Vector2[] result = Helpers.ReadPackedVector2Array(Commands.CMD_DATA);
            return result;
        }

        public Vector2 get_closest_point_to_segment(Vector2 point, Vector2 s1, Vector2 s2)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2(Commands.CMD_DATA + 8, point);
            Helpers.WriteVector2(Commands.CMD_DATA + 16, s1);
            Helpers.WriteVector2(Commands.CMD_DATA + 24, s2);
            Helpers.SendCommand(Commands.CMD_Geometry2D_get_closest_point_to_segment__5__5__5__r5);
            Helpers.WaitForCompletion();
            Vector2 result = Helpers.ReadVector2(Commands.CMD_DATA);
            return result;
        }

        public Vector2 get_closest_point_to_segment_uncapped(Vector2 point, Vector2 s1, Vector2 s2)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2(Commands.CMD_DATA + 8, point);
            Helpers.WriteVector2(Commands.CMD_DATA + 16, s1);
            Helpers.WriteVector2(Commands.CMD_DATA + 24, s2);
            Helpers.SendCommand(Commands.CMD_Geometry2D_get_closest_point_to_segment_uncapped__5__5__5__r5);
            Helpers.WaitForCompletion();
            Vector2 result = Helpers.ReadVector2(Commands.CMD_DATA);
            return result;
        }

        public bool point_is_inside_triangle(Vector2 point, Vector2 a, Vector2 b, Vector2 c)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2(Commands.CMD_DATA + 8, point);
            Helpers.WriteVector2(Commands.CMD_DATA + 16, a);
            Helpers.WriteVector2(Commands.CMD_DATA + 24, b);
            Helpers.WriteVector2(Commands.CMD_DATA + 32, c);
            Helpers.SendCommand(Commands.CMD_Geometry2D_point_is_inside_triangle__5__5__5__5__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool is_polygon_clockwise(Vector2[] polygon)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WritePackedVector2Array(Commands.CMD_DATA + 8, polygon);
            Helpers.SendCommand(Commands.CMD_Geometry2D_is_polygon_clockwise__35__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool is_point_in_polygon(Vector2 point, Vector2[] polygon)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2(Commands.CMD_DATA + 8, point);
            Helpers.WritePackedVector2Array(Commands.CMD_DATA + 16, polygon);
            Helpers.SendCommand(Commands.CMD_Geometry2D_is_point_in_polygon__5__35__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public int[] triangulate_polygon(Vector2[] polygon)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WritePackedVector2Array(Commands.CMD_DATA + 8, polygon);
            Helpers.SendCommand(Commands.CMD_Geometry2D_triangulate_polygon__35__r30);
            Helpers.WaitForCompletion();
            int[] result = Helpers.ReadPackedInt32Array(Commands.CMD_DATA);
            return result;
        }

        public int[] triangulate_delaunay(Vector2[] points)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WritePackedVector2Array(Commands.CMD_DATA + 8, points);
            Helpers.SendCommand(Commands.CMD_Geometry2D_triangulate_delaunay__35__r30);
            Helpers.WaitForCompletion();
            int[] result = Helpers.ReadPackedInt32Array(Commands.CMD_DATA);
            return result;
        }

        public Vector2[] convex_hull(Vector2[] points)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WritePackedVector2Array(Commands.CMD_DATA + 8, points);
            Helpers.SendCommand(Commands.CMD_Geometry2D_convex_hull__35__r35);
            Helpers.WaitForCompletion();
            Vector2[] result = Helpers.ReadPackedVector2Array(Commands.CMD_DATA);
            return result;
        }

        public object decompose_polygon_in_convex(Vector2[] polygon)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WritePackedVector2Array(Commands.CMD_DATA + 8, polygon);
            Helpers.SendCommand(Commands.CMD_Geometry2D_decompose_polygon_in_convex__35__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object merge_polygons(Vector2[] polygon_a, Vector2[] polygon_b)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WritePackedVector2Array(Commands.CMD_DATA + 8, polygon_a);
            Helpers.WritePackedVector2Array(Commands.CMD_DATA + 8, polygon_b);
            Helpers.SendCommand(Commands.CMD_Geometry2D_merge_polygons__35__35__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object clip_polygons(Vector2[] polygon_a, Vector2[] polygon_b)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WritePackedVector2Array(Commands.CMD_DATA + 8, polygon_a);
            Helpers.WritePackedVector2Array(Commands.CMD_DATA + 8, polygon_b);
            Helpers.SendCommand(Commands.CMD_Geometry2D_clip_polygons__35__35__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object intersect_polygons(Vector2[] polygon_a, Vector2[] polygon_b)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WritePackedVector2Array(Commands.CMD_DATA + 8, polygon_a);
            Helpers.WritePackedVector2Array(Commands.CMD_DATA + 8, polygon_b);
            Helpers.SendCommand(Commands.CMD_Geometry2D_intersect_polygons__35__35__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object exclude_polygons(Vector2[] polygon_a, Vector2[] polygon_b)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WritePackedVector2Array(Commands.CMD_DATA + 8, polygon_a);
            Helpers.WritePackedVector2Array(Commands.CMD_DATA + 8, polygon_b);
            Helpers.SendCommand(Commands.CMD_Geometry2D_exclude_polygons__35__35__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object clip_polyline_with_polygon(Vector2[] polyline, Vector2[] polygon)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WritePackedVector2Array(Commands.CMD_DATA + 8, polyline);
            Helpers.WritePackedVector2Array(Commands.CMD_DATA + 8, polygon);
            Helpers.SendCommand(Commands.CMD_Geometry2D_clip_polyline_with_polygon__35__35__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object intersect_polyline_with_polygon(Vector2[] polyline, Vector2[] polygon)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WritePackedVector2Array(Commands.CMD_DATA + 8, polyline);
            Helpers.WritePackedVector2Array(Commands.CMD_DATA + 8, polygon);
            Helpers.SendCommand(Commands.CMD_Geometry2D_intersect_polyline_with_polygon__35__35__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object offset_polygon(Vector2[] polygon, double delta, long join_type)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WritePackedVector2Array(Commands.CMD_DATA + 8, polygon);
            Helpers.WriteDouble(Commands.CMD_DATA + 8, delta);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, join_type);
            Helpers.SendCommand(Commands.CMD_Geometry2D_offset_polygon__35__3__2__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object offset_polyline(Vector2[] polyline, double delta, long join_type, long end_type)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WritePackedVector2Array(Commands.CMD_DATA + 8, polyline);
            Helpers.WriteDouble(Commands.CMD_DATA + 8, delta);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, join_type);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, end_type);
            Helpers.SendCommand(Commands.CMD_Geometry2D_offset_polyline__35__3__2__2__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object make_atlas(Vector2[] sizes)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WritePackedVector2Array(Commands.CMD_DATA + 8, sizes);
            Helpers.SendCommand(Commands.CMD_Geometry2D_make_atlas__35__r27);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadDictionary(Commands.CMD_DATA);
            return result;
        }

        public object bresenham_line(Vector2i from, Vector2i to)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2i(Commands.CMD_DATA + 8, from);
            Helpers.WriteVector2i(Commands.CMD_DATA + 16, to);
            Helpers.SendCommand(Commands.CMD_Geometry2D_bresenham_line__6__6__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void free()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Geometry2D_free__r0);
            Helpers.WaitForCompletion();
        }

        public void _init()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Geometry2D__init__r0);
            Helpers.WaitForCompletion();
        }

        public string _to_string()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Geometry2D__to_string__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void _notification(long what)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, what);
            Helpers.SendCommand(Commands.CMD_Geometry2D__notification__2__r0);
            Helpers.WaitForCompletion();
        }

        public bool _set(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_Geometry2D__set__21__0__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _get(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_Geometry2D__get__21__r0);
            Helpers.WaitForCompletion();
        }

        public object _get_property_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Geometry2D__get_property_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void _validate_property(object property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDictionary(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_Geometry2D__validate_property__27__r0);
            Helpers.WaitForCompletion();
        }

        public bool _property_can_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_Geometry2D__property_can_revert__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _property_get_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_Geometry2D__property_get_revert__21__r0);
            Helpers.WaitForCompletion();
        }

        public bool _iter_init(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteArray(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_Geometry2D__iter_init__28__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool _iter_next(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteArray(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_Geometry2D__iter_next__28__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _iter_get(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVariant(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_Geometry2D__iter_get__0__r0);
            Helpers.WaitForCompletion();
        }

        public string get_class()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Geometry2D_get_class__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public bool is_class(string class_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, class_);
            Helpers.SendCommand(Commands.CMD_Geometry2D_is_class__4__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_Geometry2D_set__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_Geometry2D_get__21__r0);
            Helpers.WaitForCompletion();
        }

        public void set_indexed(string property_path, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, property_path);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_Geometry2D_set_indexed__22__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get_indexed(string property_path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, property_path);
            Helpers.SendCommand(Commands.CMD_Geometry2D_get_indexed__22__r0);
            Helpers.WaitForCompletion();
        }

        public object get_property_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Geometry2D_get_property_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_method_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Geometry2D_get_method_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public bool property_can_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_Geometry2D_property_can_revert__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void property_get_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_Geometry2D_property_get_revert__21__r0);
            Helpers.WaitForCompletion();
        }

        public void notification(long what, bool reversed)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, what);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, reversed ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Geometry2D_notification__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public string to_string()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Geometry2D_to_string__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public ulong get_instance_id()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Geometry2D_get_instance_id__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_script(object script)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVariant(Commands.CMD_DATA + 8, script);
            Helpers.SendCommand(Commands.CMD_Geometry2D_set_script__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get_script()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Geometry2D_get_script__r0);
            Helpers.WaitForCompletion();
        }

        public void set_meta(string name, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_Geometry2D_set_meta__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void remove_meta(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_Geometry2D_remove_meta__21__r0);
            Helpers.WaitForCompletion();
        }

        public void get_meta(string name, object default_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, default_);
            Helpers.SendCommand(Commands.CMD_Geometry2D_get_meta__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_meta(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_Geometry2D_has_meta__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public object get_meta_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Geometry2D_get_meta_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void add_user_signal(string signal, object arguments)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, signal);
            Helpers.WriteArray(Commands.CMD_DATA + 1036, arguments);
            Helpers.SendCommand(Commands.CMD_Geometry2D_add_user_signal__4__28__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_user_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_Geometry2D_has_user_signal__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void remove_user_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_Geometry2D_remove_user_signal__21__r0);
            Helpers.WaitForCompletion();
        }

        public long emit_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_Geometry2D_emit_signal__21__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void call(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_Geometry2D_call__21__r0);
            Helpers.WaitForCompletion();
        }

        public void call_deferred(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_Geometry2D_call_deferred__21__r0);
            Helpers.WaitForCompletion();
        }

        public void set_deferred(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_Geometry2D_set_deferred__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void callv(string method, object arg_array)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.WriteArray(Commands.CMD_DATA + 1036, arg_array);
            Helpers.SendCommand(Commands.CMD_Geometry2D_callv__21__28__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_method(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_Geometry2D_has_method__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public long get_method_argument_count(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_Geometry2D_get_method_argument_count__21__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool has_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_Geometry2D_has_signal__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public object get_signal_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Geometry2D_get_signal_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_signal_connection_list(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_Geometry2D_get_signal_connection_list__21__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_incoming_connections()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Geometry2D_get_incoming_connections__r28);
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
            Helpers.SendCommand(Commands.CMD_Geometry2D_connect__21__25__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void disconnect(string signal, object callable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.WriteCallable(Commands.CMD_DATA + 1036, callable);
            Helpers.SendCommand(Commands.CMD_Geometry2D_disconnect__21__25__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_connected(string signal, object callable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.WriteCallable(Commands.CMD_DATA + 1036, callable);
            Helpers.SendCommand(Commands.CMD_Geometry2D_is_connected__21__25__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool has_connections(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_Geometry2D_has_connections__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_block_signals(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Geometry2D_set_block_signals__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_blocking_signals()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Geometry2D_is_blocking_signals__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void notify_property_list_changed()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Geometry2D_notify_property_list_changed__r0);
            Helpers.WaitForCompletion();
        }

        public void set_message_translation(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Geometry2D_set_message_translation__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool can_translate_messages()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Geometry2D_can_translate_messages__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public string tr(string message, string context)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, message);
            Helpers.WriteStringName(Commands.CMD_DATA + 1036, context);
            Helpers.SendCommand(Commands.CMD_Geometry2D_tr__21__21__r4);
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
            Helpers.SendCommand(Commands.CMD_Geometry2D_tr_n__21__21__2__21__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public string get_translation_domain()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Geometry2D_get_translation_domain__r21);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadStringName(Commands.CMD_DATA);
            return result;
        }

        public void set_translation_domain(string domain)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, domain);
            Helpers.SendCommand(Commands.CMD_Geometry2D_set_translation_domain__21__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_queued_for_deletion()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Geometry2D_is_queued_for_deletion__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void cancel_free()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Geometry2D_cancel_free__r0);
            Helpers.WaitForCompletion();
        }

        public ulong get_singleton()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Geometry2D_get_singleton__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

    }
}
