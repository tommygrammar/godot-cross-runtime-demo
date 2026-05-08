using System;

namespace GodotWeb
{
    public class Animation : GodotObject
    {
        public Animation(ulong id) : base(id) { }

        public long add_track(long type, long at_position)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, type);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, at_position);
            Helpers.SendCommand(Commands.CMD_Animation_add_track__2__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void remove_track(long track_idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.SendCommand(Commands.CMD_Animation_remove_track__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_track_count()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Animation_get_track_count__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long track_get_type(long track_idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.SendCommand(Commands.CMD_Animation_track_get_type__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public string track_get_path(long track_idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.SendCommand(Commands.CMD_Animation_track_get_path__2__r22);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadNodePath(Commands.CMD_DATA);
            return result;
        }

        public void track_set_path(long track_idx, string path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.WriteNodePath(Commands.CMD_DATA + 16, path);
            Helpers.SendCommand(Commands.CMD_Animation_track_set_path__2__22__r0);
            Helpers.WaitForCompletion();
        }

        public long find_track(string path, long type)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, path);
            Helpers.WriteInt64(Commands.CMD_DATA + 1036, type);
            Helpers.SendCommand(Commands.CMD_Animation_find_track__22__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void track_move_up(long track_idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.SendCommand(Commands.CMD_Animation_track_move_up__2__r0);
            Helpers.WaitForCompletion();
        }

        public void track_move_down(long track_idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.SendCommand(Commands.CMD_Animation_track_move_down__2__r0);
            Helpers.WaitForCompletion();
        }

        public void track_move_to(long track_idx, long to_idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, to_idx);
            Helpers.SendCommand(Commands.CMD_Animation_track_move_to__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public void track_swap(long track_idx, long with_idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, with_idx);
            Helpers.SendCommand(Commands.CMD_Animation_track_swap__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public void track_set_imported(long track_idx, bool imported)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, imported ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Animation_track_set_imported__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool track_is_imported(long track_idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.SendCommand(Commands.CMD_Animation_track_is_imported__2__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void track_set_enabled(long track_idx, bool enabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Animation_track_set_enabled__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool track_is_enabled(long track_idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.SendCommand(Commands.CMD_Animation_track_is_enabled__2__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public long position_track_insert_key(long track_idx, double time, Vector3 position)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, time);
            Helpers.WriteVector3(Commands.CMD_DATA + 24, position);
            Helpers.SendCommand(Commands.CMD_Animation_position_track_insert_key__2__3__9__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long rotation_track_insert_key(long track_idx, double time, Quaternion rotation)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, time);
            Helpers.WriteQuaternion(Commands.CMD_DATA + 24, rotation);
            Helpers.SendCommand(Commands.CMD_Animation_rotation_track_insert_key__2__3__15__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long scale_track_insert_key(long track_idx, double time, Vector3 scale)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, time);
            Helpers.WriteVector3(Commands.CMD_DATA + 24, scale);
            Helpers.SendCommand(Commands.CMD_Animation_scale_track_insert_key__2__3__9__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long blend_shape_track_insert_key(long track_idx, double time, double amount)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, time);
            Helpers.WriteDouble(Commands.CMD_DATA + 24, amount);
            Helpers.SendCommand(Commands.CMD_Animation_blend_shape_track_insert_key__2__3__3__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public Vector3 position_track_interpolate(long track_idx, double time_sec, bool backward)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, time_sec);
            Helpers.WriteInt32(Commands.CMD_DATA + 24, backward ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Animation_position_track_interpolate__2__3__1__r9);
            Helpers.WaitForCompletion();
            Vector3 result = Helpers.ReadVector3(Commands.CMD_DATA);
            return result;
        }

        public Quaternion rotation_track_interpolate(long track_idx, double time_sec, bool backward)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, time_sec);
            Helpers.WriteInt32(Commands.CMD_DATA + 24, backward ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Animation_rotation_track_interpolate__2__3__1__r15);
            Helpers.WaitForCompletion();
            Quaternion result = Helpers.ReadQuaternion(Commands.CMD_DATA);
            return result;
        }

        public Vector3 scale_track_interpolate(long track_idx, double time_sec, bool backward)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, time_sec);
            Helpers.WriteInt32(Commands.CMD_DATA + 24, backward ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Animation_scale_track_interpolate__2__3__1__r9);
            Helpers.WaitForCompletion();
            Vector3 result = Helpers.ReadVector3(Commands.CMD_DATA);
            return result;
        }

        public double blend_shape_track_interpolate(long track_idx, double time_sec, bool backward)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, time_sec);
            Helpers.WriteInt32(Commands.CMD_DATA + 24, backward ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Animation_blend_shape_track_interpolate__2__3__1__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public long track_insert_key(long track_idx, double time, object key, double transition)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, time);
            Helpers.WriteVariant(Commands.CMD_DATA + 24, key);
            Helpers.WriteDouble(Commands.CMD_DATA + 24, transition);
            Helpers.SendCommand(Commands.CMD_Animation_track_insert_key__2__3__0__3__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void track_remove_key(long track_idx, long key_idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, key_idx);
            Helpers.SendCommand(Commands.CMD_Animation_track_remove_key__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public void track_remove_key_at_time(long track_idx, double time)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, time);
            Helpers.SendCommand(Commands.CMD_Animation_track_remove_key_at_time__2__3__r0);
            Helpers.WaitForCompletion();
        }

        public void track_set_key_value(long track_idx, long key, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, key);
            Helpers.WriteVariant(Commands.CMD_DATA + 24, value);
            Helpers.SendCommand(Commands.CMD_Animation_track_set_key_value__2__2__0__r0);
            Helpers.WaitForCompletion();
        }

        public void track_set_key_transition(long track_idx, long key_idx, double transition)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, key_idx);
            Helpers.WriteDouble(Commands.CMD_DATA + 24, transition);
            Helpers.SendCommand(Commands.CMD_Animation_track_set_key_transition__2__2__3__r0);
            Helpers.WaitForCompletion();
        }

        public void track_set_key_time(long track_idx, long key_idx, double time)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, key_idx);
            Helpers.WriteDouble(Commands.CMD_DATA + 24, time);
            Helpers.SendCommand(Commands.CMD_Animation_track_set_key_time__2__2__3__r0);
            Helpers.WaitForCompletion();
        }

        public double track_get_key_transition(long track_idx, long key_idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, key_idx);
            Helpers.SendCommand(Commands.CMD_Animation_track_get_key_transition__2__2__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public long track_get_key_count(long track_idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.SendCommand(Commands.CMD_Animation_track_get_key_count__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void track_get_key_value(long track_idx, long key_idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, key_idx);
            Helpers.SendCommand(Commands.CMD_Animation_track_get_key_value__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public double track_get_key_time(long track_idx, long key_idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, key_idx);
            Helpers.SendCommand(Commands.CMD_Animation_track_get_key_time__2__2__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public long track_find_key(long track_idx, double time, long find_mode, bool limit, bool backward)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, time);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, find_mode);
            Helpers.WriteInt32(Commands.CMD_DATA + 32, limit ? 1 : 0);
            Helpers.WriteInt32(Commands.CMD_DATA + 36, backward ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Animation_track_find_key__2__3__2__1__1__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void track_set_interpolation_type(long track_idx, long interpolation)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, interpolation);
            Helpers.SendCommand(Commands.CMD_Animation_track_set_interpolation_type__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public long track_get_interpolation_type(long track_idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.SendCommand(Commands.CMD_Animation_track_get_interpolation_type__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void track_set_interpolation_loop_wrap(long track_idx, bool interpolation)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, interpolation ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Animation_track_set_interpolation_loop_wrap__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool track_get_interpolation_loop_wrap(long track_idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.SendCommand(Commands.CMD_Animation_track_get_interpolation_loop_wrap__2__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool track_is_compressed(long track_idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.SendCommand(Commands.CMD_Animation_track_is_compressed__2__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void value_track_set_update_mode(long track_idx, long mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, mode);
            Helpers.SendCommand(Commands.CMD_Animation_value_track_set_update_mode__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public long value_track_get_update_mode(long track_idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.SendCommand(Commands.CMD_Animation_value_track_get_update_mode__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void value_track_interpolate(long track_idx, double time_sec, bool backward)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, time_sec);
            Helpers.WriteInt32(Commands.CMD_DATA + 24, backward ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Animation_value_track_interpolate__2__3__1__r0);
            Helpers.WaitForCompletion();
        }

        public string method_track_get_name(long track_idx, long key_idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, key_idx);
            Helpers.SendCommand(Commands.CMD_Animation_method_track_get_name__2__2__r21);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadStringName(Commands.CMD_DATA);
            return result;
        }

        public object method_track_get_params(long track_idx, long key_idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, key_idx);
            Helpers.SendCommand(Commands.CMD_Animation_method_track_get_params__2__2__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public long bezier_track_insert_key(long track_idx, double time, double value, Vector2 in_handle, Vector2 out_handle)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, time);
            Helpers.WriteDouble(Commands.CMD_DATA + 24, value);
            Helpers.WriteVector2(Commands.CMD_DATA + 32, in_handle);
            Helpers.WriteVector2(Commands.CMD_DATA + 40, out_handle);
            Helpers.SendCommand(Commands.CMD_Animation_bezier_track_insert_key__2__3__3__5__5__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void bezier_track_set_key_value(long track_idx, long key_idx, double value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, key_idx);
            Helpers.WriteDouble(Commands.CMD_DATA + 24, value);
            Helpers.SendCommand(Commands.CMD_Animation_bezier_track_set_key_value__2__2__3__r0);
            Helpers.WaitForCompletion();
        }

        public void bezier_track_set_key_in_handle(long track_idx, long key_idx, Vector2 in_handle, double balanced_value_time_ratio)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, key_idx);
            Helpers.WriteVector2(Commands.CMD_DATA + 24, in_handle);
            Helpers.WriteDouble(Commands.CMD_DATA + 32, balanced_value_time_ratio);
            Helpers.SendCommand(Commands.CMD_Animation_bezier_track_set_key_in_handle__2__2__5__3__r0);
            Helpers.WaitForCompletion();
        }

        public void bezier_track_set_key_out_handle(long track_idx, long key_idx, Vector2 out_handle, double balanced_value_time_ratio)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, key_idx);
            Helpers.WriteVector2(Commands.CMD_DATA + 24, out_handle);
            Helpers.WriteDouble(Commands.CMD_DATA + 32, balanced_value_time_ratio);
            Helpers.SendCommand(Commands.CMD_Animation_bezier_track_set_key_out_handle__2__2__5__3__r0);
            Helpers.WaitForCompletion();
        }

        public double bezier_track_get_key_value(long track_idx, long key_idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, key_idx);
            Helpers.SendCommand(Commands.CMD_Animation_bezier_track_get_key_value__2__2__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public Vector2 bezier_track_get_key_in_handle(long track_idx, long key_idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, key_idx);
            Helpers.SendCommand(Commands.CMD_Animation_bezier_track_get_key_in_handle__2__2__r5);
            Helpers.WaitForCompletion();
            Vector2 result = Helpers.ReadVector2(Commands.CMD_DATA);
            return result;
        }

        public Vector2 bezier_track_get_key_out_handle(long track_idx, long key_idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, key_idx);
            Helpers.SendCommand(Commands.CMD_Animation_bezier_track_get_key_out_handle__2__2__r5);
            Helpers.WaitForCompletion();
            Vector2 result = Helpers.ReadVector2(Commands.CMD_DATA);
            return result;
        }

        public double bezier_track_interpolate(long track_idx, double time)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, time);
            Helpers.SendCommand(Commands.CMD_Animation_bezier_track_interpolate__2__3__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public long audio_track_insert_key(long track_idx, double time, ulong stream, double start_offset, double end_offset)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, time);
            Helpers.WriteUInt64(Commands.CMD_DATA + 24, stream);
            Helpers.WriteDouble(Commands.CMD_DATA + 32, start_offset);
            Helpers.WriteDouble(Commands.CMD_DATA + 40, end_offset);
            Helpers.SendCommand(Commands.CMD_Animation_audio_track_insert_key__2__3__24__3__3__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void audio_track_set_key_stream(long track_idx, long key_idx, ulong stream)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, key_idx);
            Helpers.WriteUInt64(Commands.CMD_DATA + 24, stream);
            Helpers.SendCommand(Commands.CMD_Animation_audio_track_set_key_stream__2__2__24__r0);
            Helpers.WaitForCompletion();
        }

        public void audio_track_set_key_start_offset(long track_idx, long key_idx, double offset)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, key_idx);
            Helpers.WriteDouble(Commands.CMD_DATA + 24, offset);
            Helpers.SendCommand(Commands.CMD_Animation_audio_track_set_key_start_offset__2__2__3__r0);
            Helpers.WaitForCompletion();
        }

        public void audio_track_set_key_end_offset(long track_idx, long key_idx, double offset)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, key_idx);
            Helpers.WriteDouble(Commands.CMD_DATA + 24, offset);
            Helpers.SendCommand(Commands.CMD_Animation_audio_track_set_key_end_offset__2__2__3__r0);
            Helpers.WaitForCompletion();
        }

        public ulong audio_track_get_key_stream(long track_idx, long key_idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, key_idx);
            Helpers.SendCommand(Commands.CMD_Animation_audio_track_get_key_stream__2__2__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public double audio_track_get_key_start_offset(long track_idx, long key_idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, key_idx);
            Helpers.SendCommand(Commands.CMD_Animation_audio_track_get_key_start_offset__2__2__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public double audio_track_get_key_end_offset(long track_idx, long key_idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, key_idx);
            Helpers.SendCommand(Commands.CMD_Animation_audio_track_get_key_end_offset__2__2__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void audio_track_set_use_blend(long track_idx, bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Animation_audio_track_set_use_blend__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool audio_track_is_use_blend(long track_idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.SendCommand(Commands.CMD_Animation_audio_track_is_use_blend__2__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public long animation_track_insert_key(long track_idx, double time, string animation)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, time);
            Helpers.WriteStringName(Commands.CMD_DATA + 24, animation);
            Helpers.SendCommand(Commands.CMD_Animation_animation_track_insert_key__2__3__21__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void animation_track_set_key_animation(long track_idx, long key_idx, string animation)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, key_idx);
            Helpers.WriteStringName(Commands.CMD_DATA + 24, animation);
            Helpers.SendCommand(Commands.CMD_Animation_animation_track_set_key_animation__2__2__21__r0);
            Helpers.WaitForCompletion();
        }

        public string animation_track_get_key_animation(long track_idx, long key_idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, key_idx);
            Helpers.SendCommand(Commands.CMD_Animation_animation_track_get_key_animation__2__2__r21);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadStringName(Commands.CMD_DATA);
            return result;
        }

        public void add_marker(string name, double time)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteDouble(Commands.CMD_DATA + 1036, time);
            Helpers.SendCommand(Commands.CMD_Animation_add_marker__21__3__r0);
            Helpers.WaitForCompletion();
        }

        public void remove_marker(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_Animation_remove_marker__21__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_marker(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_Animation_has_marker__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public string get_marker_at_time(double time)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDouble(Commands.CMD_DATA + 8, time);
            Helpers.SendCommand(Commands.CMD_Animation_get_marker_at_time__3__r21);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadStringName(Commands.CMD_DATA);
            return result;
        }

        public string get_next_marker(double time)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDouble(Commands.CMD_DATA + 8, time);
            Helpers.SendCommand(Commands.CMD_Animation_get_next_marker__3__r21);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadStringName(Commands.CMD_DATA);
            return result;
        }

        public string get_prev_marker(double time)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDouble(Commands.CMD_DATA + 8, time);
            Helpers.SendCommand(Commands.CMD_Animation_get_prev_marker__3__r21);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadStringName(Commands.CMD_DATA);
            return result;
        }

        public double get_marker_time(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_Animation_get_marker_time__21__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public string[] get_marker_names()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Animation_get_marker_names__r34);
            Helpers.WaitForCompletion();
            string[] result = Helpers.ReadPackedStringArray(Commands.CMD_DATA);
            return result;
        }

        public Color get_marker_color(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_Animation_get_marker_color__21__r20);
            Helpers.WaitForCompletion();
            Color result = Helpers.ReadColor(Commands.CMD_DATA);
            return result;
        }

        public void set_marker_color(string name, Color color)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteColor(Commands.CMD_DATA + 1036, color);
            Helpers.SendCommand(Commands.CMD_Animation_set_marker_color__21__20__r0);
            Helpers.WaitForCompletion();
        }

        public void set_length(double time_sec)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDouble(Commands.CMD_DATA + 8, time_sec);
            Helpers.SendCommand(Commands.CMD_Animation_set_length__3__r0);
            Helpers.WaitForCompletion();
        }

        public double get_length()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Animation_get_length__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void set_loop_mode(long loop_mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, loop_mode);
            Helpers.SendCommand(Commands.CMD_Animation_set_loop_mode__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_loop_mode()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Animation_get_loop_mode__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_step(double size_sec)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDouble(Commands.CMD_DATA + 8, size_sec);
            Helpers.SendCommand(Commands.CMD_Animation_set_step__3__r0);
            Helpers.WaitForCompletion();
        }

        public double get_step()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Animation_get_step__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void clear()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Animation_clear__r0);
            Helpers.WaitForCompletion();
        }

        public void copy_track(long track_idx, ulong to_animation)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, track_idx);
            Helpers.WriteUInt64(Commands.CMD_DATA + 16, to_animation);
            Helpers.SendCommand(Commands.CMD_Animation_copy_track__2__24__r0);
            Helpers.WaitForCompletion();
        }

        public void optimize(double allowed_velocity_err, double allowed_angular_err, long precision)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDouble(Commands.CMD_DATA + 8, allowed_velocity_err);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, allowed_angular_err);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, precision);
            Helpers.SendCommand(Commands.CMD_Animation_optimize__3__3__2__r0);
            Helpers.WaitForCompletion();
        }

        public void compress(long page_size, long fps, double split_tolerance)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, page_size);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, fps);
            Helpers.WriteDouble(Commands.CMD_DATA + 24, split_tolerance);
            Helpers.SendCommand(Commands.CMD_Animation_compress__2__2__3__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_capture_included()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Animation_is_capture_included__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _setup_local_to_scene()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Animation__setup_local_to_scene__r0);
            Helpers.WaitForCompletion();
        }

        public ulong _get_rid()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Animation__get_rid__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void _reset_state()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Animation__reset_state__r0);
            Helpers.WaitForCompletion();
        }

        public void _set_path_cache(string path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, path);
            Helpers.SendCommand(Commands.CMD_Animation__set_path_cache__4__r0);
            Helpers.WaitForCompletion();
        }

        public void set_path(string path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, path);
            Helpers.SendCommand(Commands.CMD_Animation_set_path__4__r0);
            Helpers.WaitForCompletion();
        }

        public void take_over_path(string path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, path);
            Helpers.SendCommand(Commands.CMD_Animation_take_over_path__4__r0);
            Helpers.WaitForCompletion();
        }

        public string get_path()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Animation_get_path__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void set_path_cache(string path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, path);
            Helpers.SendCommand(Commands.CMD_Animation_set_path_cache__4__r0);
            Helpers.WaitForCompletion();
        }

        public void set_name(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_Animation_set_name__4__r0);
            Helpers.WaitForCompletion();
        }

        public string get_name()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Animation_get_name__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public ulong get_rid()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Animation_get_rid__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void set_local_to_scene(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Animation_set_local_to_scene__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_local_to_scene()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Animation_is_local_to_scene__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public ulong get_local_scene()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Animation_get_local_scene__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void setup_local_to_scene()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Animation_setup_local_to_scene__r0);
            Helpers.WaitForCompletion();
        }

        public void reset_state()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Animation_reset_state__r0);
            Helpers.WaitForCompletion();
        }

        public void set_id_for_path(string path, string id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, path);
            Helpers.WriteString(Commands.CMD_DATA + 1036, id);
            Helpers.SendCommand(Commands.CMD_Animation_set_id_for_path__4__4__r0);
            Helpers.WaitForCompletion();
        }

        public string get_id_for_path(string path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, path);
            Helpers.SendCommand(Commands.CMD_Animation_get_id_for_path__4__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public bool is_built_in()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Animation_is_built_in__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public string generate_scene_unique_id()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Animation_generate_scene_unique_id__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void set_scene_unique_id(string id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, id);
            Helpers.SendCommand(Commands.CMD_Animation_set_scene_unique_id__4__r0);
            Helpers.WaitForCompletion();
        }

        public string get_scene_unique_id()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Animation_get_scene_unique_id__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void emit_changed()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Animation_emit_changed__r0);
            Helpers.WaitForCompletion();
        }

        public ulong duplicate(bool deep)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, deep ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Animation_duplicate__1__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong duplicate_deep(long deep_subresources_mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, deep_subresources_mode);
            Helpers.SendCommand(Commands.CMD_Animation_duplicate_deep__2__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public bool init_ref()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Animation_init_ref__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool reference()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Animation_reference__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool unreference()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Animation_unreference__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public long get_reference_count()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Animation_get_reference_count__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void free()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Animation_free__r0);
            Helpers.WaitForCompletion();
        }

        public void _init()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Animation__init__r0);
            Helpers.WaitForCompletion();
        }

        public string _to_string()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Animation__to_string__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void _notification(long what)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, what);
            Helpers.SendCommand(Commands.CMD_Animation__notification__2__r0);
            Helpers.WaitForCompletion();
        }

        public bool _set(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_Animation__set__21__0__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _get(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_Animation__get__21__r0);
            Helpers.WaitForCompletion();
        }

        public object _get_property_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Animation__get_property_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void _validate_property(object property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDictionary(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_Animation__validate_property__27__r0);
            Helpers.WaitForCompletion();
        }

        public bool _property_can_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_Animation__property_can_revert__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _property_get_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_Animation__property_get_revert__21__r0);
            Helpers.WaitForCompletion();
        }

        public bool _iter_init(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteArray(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_Animation__iter_init__28__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool _iter_next(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteArray(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_Animation__iter_next__28__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _iter_get(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVariant(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_Animation__iter_get__0__r0);
            Helpers.WaitForCompletion();
        }

        public string get_class()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Animation_get_class__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public bool is_class(string class_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, class_);
            Helpers.SendCommand(Commands.CMD_Animation_is_class__4__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_Animation_set__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_Animation_get__21__r0);
            Helpers.WaitForCompletion();
        }

        public void set_indexed(string property_path, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, property_path);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_Animation_set_indexed__22__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get_indexed(string property_path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, property_path);
            Helpers.SendCommand(Commands.CMD_Animation_get_indexed__22__r0);
            Helpers.WaitForCompletion();
        }

        public object get_property_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Animation_get_property_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_method_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Animation_get_method_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public bool property_can_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_Animation_property_can_revert__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void property_get_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_Animation_property_get_revert__21__r0);
            Helpers.WaitForCompletion();
        }

        public void notification(long what, bool reversed)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, what);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, reversed ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Animation_notification__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public string to_string()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Animation_to_string__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public ulong get_instance_id()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Animation_get_instance_id__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_script(object script)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVariant(Commands.CMD_DATA + 8, script);
            Helpers.SendCommand(Commands.CMD_Animation_set_script__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get_script()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Animation_get_script__r0);
            Helpers.WaitForCompletion();
        }

        public void set_meta(string name, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_Animation_set_meta__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void remove_meta(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_Animation_remove_meta__21__r0);
            Helpers.WaitForCompletion();
        }

        public void get_meta(string name, object default_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, default_);
            Helpers.SendCommand(Commands.CMD_Animation_get_meta__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_meta(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_Animation_has_meta__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public object get_meta_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Animation_get_meta_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void add_user_signal(string signal, object arguments)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, signal);
            Helpers.WriteArray(Commands.CMD_DATA + 1036, arguments);
            Helpers.SendCommand(Commands.CMD_Animation_add_user_signal__4__28__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_user_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_Animation_has_user_signal__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void remove_user_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_Animation_remove_user_signal__21__r0);
            Helpers.WaitForCompletion();
        }

        public long emit_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_Animation_emit_signal__21__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void call(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_Animation_call__21__r0);
            Helpers.WaitForCompletion();
        }

        public void call_deferred(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_Animation_call_deferred__21__r0);
            Helpers.WaitForCompletion();
        }

        public void set_deferred(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_Animation_set_deferred__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void callv(string method, object arg_array)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.WriteArray(Commands.CMD_DATA + 1036, arg_array);
            Helpers.SendCommand(Commands.CMD_Animation_callv__21__28__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_method(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_Animation_has_method__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public long get_method_argument_count(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_Animation_get_method_argument_count__21__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool has_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_Animation_has_signal__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public object get_signal_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Animation_get_signal_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_signal_connection_list(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_Animation_get_signal_connection_list__21__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_incoming_connections()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Animation_get_incoming_connections__r28);
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
            Helpers.SendCommand(Commands.CMD_Animation_connect__21__25__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void disconnect(string signal, object callable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.WriteCallable(Commands.CMD_DATA + 1036, callable);
            Helpers.SendCommand(Commands.CMD_Animation_disconnect__21__25__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_connected(string signal, object callable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.WriteCallable(Commands.CMD_DATA + 1036, callable);
            Helpers.SendCommand(Commands.CMD_Animation_is_connected__21__25__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool has_connections(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_Animation_has_connections__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_block_signals(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Animation_set_block_signals__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_blocking_signals()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Animation_is_blocking_signals__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void notify_property_list_changed()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Animation_notify_property_list_changed__r0);
            Helpers.WaitForCompletion();
        }

        public void set_message_translation(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Animation_set_message_translation__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool can_translate_messages()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Animation_can_translate_messages__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public string tr(string message, string context)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, message);
            Helpers.WriteStringName(Commands.CMD_DATA + 1036, context);
            Helpers.SendCommand(Commands.CMD_Animation_tr__21__21__r4);
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
            Helpers.SendCommand(Commands.CMD_Animation_tr_n__21__21__2__21__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public string get_translation_domain()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Animation_get_translation_domain__r21);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadStringName(Commands.CMD_DATA);
            return result;
        }

        public void set_translation_domain(string domain)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, domain);
            Helpers.SendCommand(Commands.CMD_Animation_set_translation_domain__21__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_queued_for_deletion()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Animation_is_queued_for_deletion__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void cancel_free()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Animation_cancel_free__r0);
            Helpers.WaitForCompletion();
        }

    }
}
