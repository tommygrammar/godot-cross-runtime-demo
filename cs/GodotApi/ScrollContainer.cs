using System;

namespace GodotWeb
{
    public class ScrollContainer : GodotObject
    {
        public ScrollContainer(ulong id) : base(id) { }

        public void set_h_scroll(long value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, value);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_h_scroll__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_h_scroll()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_h_scroll__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_v_scroll(long value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, value);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_v_scroll__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_v_scroll()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_v_scroll__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_horizontal_custom_step(double value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDouble(Commands.CMD_DATA + 8, value);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_horizontal_custom_step__3__r0);
            Helpers.WaitForCompletion();
        }

        public double get_horizontal_custom_step()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_horizontal_custom_step__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void set_vertical_custom_step(double value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDouble(Commands.CMD_DATA + 8, value);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_vertical_custom_step__3__r0);
            Helpers.WaitForCompletion();
        }

        public double get_vertical_custom_step()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_vertical_custom_step__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void set_horizontal_scroll_mode(long enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, enable);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_horizontal_scroll_mode__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_horizontal_scroll_mode()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_horizontal_scroll_mode__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_vertical_scroll_mode(long enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, enable);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_vertical_scroll_mode__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_vertical_scroll_mode()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_vertical_scroll_mode__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_deadzone(long deadzone)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, deadzone);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_deadzone__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_deadzone()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_deadzone__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_scroll_hint_mode(long scroll_hint_mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, scroll_hint_mode);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_scroll_hint_mode__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_scroll_hint_mode()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_scroll_hint_mode__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_tile_scroll_hint(bool tile_scroll_hint)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, tile_scroll_hint ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_tile_scroll_hint__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_scroll_hint_tiled()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_is_scroll_hint_tiled__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_follow_focus(bool enabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_follow_focus__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_following_focus()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_is_following_focus__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public ulong get_h_scroll_bar()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_h_scroll_bar__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong get_v_scroll_bar()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_v_scroll_bar__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void ensure_control_visible(ulong control)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, control);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_ensure_control_visible__24__r0);
            Helpers.WaitForCompletion();
        }

        public void set_draw_focus_border(bool draw)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, draw ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_draw_focus_border__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool get_draw_focus_border()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_draw_focus_border__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public int[] _get_allowed_size_flags_horizontal()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__get_allowed_size_flags_horizontal__r30);
            Helpers.WaitForCompletion();
            int[] result = Helpers.ReadPackedInt32Array(Commands.CMD_DATA);
            return result;
        }

        public int[] _get_allowed_size_flags_vertical()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__get_allowed_size_flags_vertical__r30);
            Helpers.WaitForCompletion();
            int[] result = Helpers.ReadPackedInt32Array(Commands.CMD_DATA);
            return result;
        }

        public void queue_sort()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_queue_sort__r0);
            Helpers.WaitForCompletion();
        }

        public void fit_child_in_rect(ulong child, Rect2 rect)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, child);
            Helpers.WriteRect2(Commands.CMD_DATA + 16, rect);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_fit_child_in_rect__24__7__r0);
            Helpers.WaitForCompletion();
        }

        public bool _has_point(Vector2 point)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2(Commands.CMD_DATA + 8, point);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__has_point__5__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public object _structured_text_parser(object args, string text)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteArray(Commands.CMD_DATA + 8, args);
            Helpers.WriteString(Commands.CMD_DATA + 8, text);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__structured_text_parser__28__4__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public Vector2 _get_minimum_size()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__get_minimum_size__r5);
            Helpers.WaitForCompletion();
            Vector2 result = Helpers.ReadVector2(Commands.CMD_DATA);
            return result;
        }

        public string _get_tooltip(Vector2 at_position)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2(Commands.CMD_DATA + 8, at_position);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__get_tooltip__5__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void _get_drag_data(Vector2 at_position)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2(Commands.CMD_DATA + 8, at_position);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__get_drag_data__5__r0);
            Helpers.WaitForCompletion();
        }

        public bool _can_drop_data(Vector2 at_position, object arg_data)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2(Commands.CMD_DATA + 8, at_position);
            Helpers.WriteVariant(Commands.CMD_DATA + 16, arg_data);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__can_drop_data__5__0__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _drop_data(Vector2 at_position, object arg_data)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2(Commands.CMD_DATA + 8, at_position);
            Helpers.WriteVariant(Commands.CMD_DATA + 16, arg_data);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__drop_data__5__0__r0);
            Helpers.WaitForCompletion();
        }

        public ulong _make_custom_tooltip(string for_text)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, for_text);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__make_custom_tooltip__4__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public string _accessibility_get_contextual_info()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__accessibility_get_contextual_info__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public string _get_accessibility_container_name(ulong node)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, node);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__get_accessibility_container_name__24__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void _gui_input(ulong event_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, event_);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__gui_input__24__r0);
            Helpers.WaitForCompletion();
        }

        public void accept_event()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_accept_event__r0);
            Helpers.WaitForCompletion();
        }

        public Vector2 get_minimum_size()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_minimum_size__r5);
            Helpers.WaitForCompletion();
            Vector2 result = Helpers.ReadVector2(Commands.CMD_DATA);
            return result;
        }

        public Vector2 get_combined_minimum_size()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_combined_minimum_size__r5);
            Helpers.WaitForCompletion();
            Vector2 result = Helpers.ReadVector2(Commands.CMD_DATA);
            return result;
        }

        public void _set_layout_mode(long mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, mode);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__set_layout_mode__2__r0);
            Helpers.WaitForCompletion();
        }

        public long _get_layout_mode()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__get_layout_mode__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void _set_anchors_layout_preset(long preset)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, preset);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__set_anchors_layout_preset__2__r0);
            Helpers.WaitForCompletion();
        }

        public long _get_anchors_layout_preset()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__get_anchors_layout_preset__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_anchors_preset(long preset, bool keep_offsets)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, preset);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, keep_offsets ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_anchors_preset__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public void set_offsets_preset(long preset, long resize_mode, long margin)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, preset);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, resize_mode);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, margin);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_offsets_preset__2__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public void set_anchors_and_offsets_preset(long preset, long resize_mode, long margin)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, preset);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, resize_mode);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, margin);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_anchors_and_offsets_preset__2__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public void _set_anchor(long side, double anchor)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, side);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, anchor);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__set_anchor__2__3__r0);
            Helpers.WaitForCompletion();
        }

        public void set_anchor(long side, double anchor, bool keep_offset, bool push_opposite_anchor)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, side);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, anchor);
            Helpers.WriteInt32(Commands.CMD_DATA + 24, keep_offset ? 1 : 0);
            Helpers.WriteInt32(Commands.CMD_DATA + 28, push_opposite_anchor ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_anchor__2__3__1__1__r0);
            Helpers.WaitForCompletion();
        }

        public double get_anchor(long side)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, side);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_anchor__2__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void set_offset(long side, double offset)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, side);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, offset);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_offset__2__3__r0);
            Helpers.WaitForCompletion();
        }

        public double get_offset(long offset)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, offset);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_offset__2__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void set_anchor_and_offset(long side, double anchor, double offset, bool push_opposite_anchor)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, side);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, anchor);
            Helpers.WriteDouble(Commands.CMD_DATA + 24, offset);
            Helpers.WriteInt32(Commands.CMD_DATA + 32, push_opposite_anchor ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_anchor_and_offset__2__3__3__1__r0);
            Helpers.WaitForCompletion();
        }

        public void set_begin(Vector2 position)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2(Commands.CMD_DATA + 8, position);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_begin__5__r0);
            Helpers.WaitForCompletion();
        }

        public void set_end(Vector2 position)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2(Commands.CMD_DATA + 8, position);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_end__5__r0);
            Helpers.WaitForCompletion();
        }

        public void set_position(Vector2 position, bool keep_offsets)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2(Commands.CMD_DATA + 8, position);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, keep_offsets ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_position__5__1__r0);
            Helpers.WaitForCompletion();
        }

        public void _set_position(Vector2 position)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2(Commands.CMD_DATA + 8, position);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__set_position__5__r0);
            Helpers.WaitForCompletion();
        }

        public void set_size(Vector2 size, bool keep_offsets)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2(Commands.CMD_DATA + 8, size);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, keep_offsets ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_size__5__1__r0);
            Helpers.WaitForCompletion();
        }

        public void reset_size()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_reset_size__r0);
            Helpers.WaitForCompletion();
        }

        public void _set_size(Vector2 size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2(Commands.CMD_DATA + 8, size);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__set_size__5__r0);
            Helpers.WaitForCompletion();
        }

        public void set_custom_minimum_size(Vector2 size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2(Commands.CMD_DATA + 8, size);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_custom_minimum_size__5__r0);
            Helpers.WaitForCompletion();
        }

        public void set_global_position(Vector2 position, bool keep_offsets)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2(Commands.CMD_DATA + 8, position);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, keep_offsets ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_global_position__5__1__r0);
            Helpers.WaitForCompletion();
        }

        public void _set_global_position(Vector2 position)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2(Commands.CMD_DATA + 8, position);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__set_global_position__5__r0);
            Helpers.WaitForCompletion();
        }

        public void set_rotation(double radians)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDouble(Commands.CMD_DATA + 8, radians);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_rotation__3__r0);
            Helpers.WaitForCompletion();
        }

        public void set_rotation_degrees(double degrees)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDouble(Commands.CMD_DATA + 8, degrees);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_rotation_degrees__3__r0);
            Helpers.WaitForCompletion();
        }

        public void set_scale(Vector2 scale)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2(Commands.CMD_DATA + 8, scale);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_scale__5__r0);
            Helpers.WaitForCompletion();
        }

        public void set_pivot_offset(Vector2 pivot_offset)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2(Commands.CMD_DATA + 8, pivot_offset);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_pivot_offset__5__r0);
            Helpers.WaitForCompletion();
        }

        public void set_pivot_offset_ratio(Vector2 ratio)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2(Commands.CMD_DATA + 8, ratio);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_pivot_offset_ratio__5__r0);
            Helpers.WaitForCompletion();
        }

        public Vector2 get_begin()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_begin__r5);
            Helpers.WaitForCompletion();
            Vector2 result = Helpers.ReadVector2(Commands.CMD_DATA);
            return result;
        }

        public Vector2 get_end()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_end__r5);
            Helpers.WaitForCompletion();
            Vector2 result = Helpers.ReadVector2(Commands.CMD_DATA);
            return result;
        }

        public Vector2 get_position()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_position__r5);
            Helpers.WaitForCompletion();
            Vector2 result = Helpers.ReadVector2(Commands.CMD_DATA);
            return result;
        }

        public Vector2 get_size()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_size__r5);
            Helpers.WaitForCompletion();
            Vector2 result = Helpers.ReadVector2(Commands.CMD_DATA);
            return result;
        }

        public double get_rotation()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_rotation__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public double get_rotation_degrees()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_rotation_degrees__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public Vector2 get_scale()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_scale__r5);
            Helpers.WaitForCompletion();
            Vector2 result = Helpers.ReadVector2(Commands.CMD_DATA);
            return result;
        }

        public Vector2 get_pivot_offset()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_pivot_offset__r5);
            Helpers.WaitForCompletion();
            Vector2 result = Helpers.ReadVector2(Commands.CMD_DATA);
            return result;
        }

        public Vector2 get_pivot_offset_ratio()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_pivot_offset_ratio__r5);
            Helpers.WaitForCompletion();
            Vector2 result = Helpers.ReadVector2(Commands.CMD_DATA);
            return result;
        }

        public Vector2 get_combined_pivot_offset()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_combined_pivot_offset__r5);
            Helpers.WaitForCompletion();
            Vector2 result = Helpers.ReadVector2(Commands.CMD_DATA);
            return result;
        }

        public Vector2 get_custom_minimum_size()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_custom_minimum_size__r5);
            Helpers.WaitForCompletion();
            Vector2 result = Helpers.ReadVector2(Commands.CMD_DATA);
            return result;
        }

        public Vector2 get_parent_area_size()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_parent_area_size__r5);
            Helpers.WaitForCompletion();
            Vector2 result = Helpers.ReadVector2(Commands.CMD_DATA);
            return result;
        }

        public Vector2 get_global_position()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_global_position__r5);
            Helpers.WaitForCompletion();
            Vector2 result = Helpers.ReadVector2(Commands.CMD_DATA);
            return result;
        }

        public Vector2 get_screen_position()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_screen_position__r5);
            Helpers.WaitForCompletion();
            Vector2 result = Helpers.ReadVector2(Commands.CMD_DATA);
            return result;
        }

        public Rect2 get_rect()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_rect__r7);
            Helpers.WaitForCompletion();
            Rect2 result = Helpers.ReadRect2(Commands.CMD_DATA);
            return result;
        }

        public Rect2 get_global_rect()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_global_rect__r7);
            Helpers.WaitForCompletion();
            Rect2 result = Helpers.ReadRect2(Commands.CMD_DATA);
            return result;
        }

        public void set_focus_mode(long mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, mode);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_focus_mode__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_focus_mode()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_focus_mode__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long get_focus_mode_with_override()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_focus_mode_with_override__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_focus_behavior_recursive(long focus_behavior_recursive)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, focus_behavior_recursive);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_focus_behavior_recursive__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_focus_behavior_recursive()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_focus_behavior_recursive__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool has_focus(bool ignore_hidden_focus)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, ignore_hidden_focus ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_has_focus__1__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void grab_focus(bool hide_focus)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, hide_focus ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_grab_focus__1__r0);
            Helpers.WaitForCompletion();
        }

        public void release_focus()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_release_focus__r0);
            Helpers.WaitForCompletion();
        }

        public ulong find_prev_valid_focus()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_find_prev_valid_focus__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong find_next_valid_focus()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_find_next_valid_focus__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong find_valid_focus_neighbor(long side)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, side);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_find_valid_focus_neighbor__2__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_h_size_flags(long flags)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, flags);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_h_size_flags__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_h_size_flags()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_h_size_flags__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_stretch_ratio(double ratio)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDouble(Commands.CMD_DATA + 8, ratio);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_stretch_ratio__3__r0);
            Helpers.WaitForCompletion();
        }

        public double get_stretch_ratio()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_stretch_ratio__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void set_v_size_flags(long flags)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, flags);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_v_size_flags__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_v_size_flags()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_v_size_flags__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_theme(ulong theme)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, theme);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_theme__24__r0);
            Helpers.WaitForCompletion();
        }

        public ulong get_theme()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_theme__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_theme_type_variation(string theme_type)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, theme_type);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_theme_type_variation__21__r0);
            Helpers.WaitForCompletion();
        }

        public string get_theme_type_variation()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_theme_type_variation__r21);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadStringName(Commands.CMD_DATA);
            return result;
        }

        public void begin_bulk_theme_override()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_begin_bulk_theme_override__r0);
            Helpers.WaitForCompletion();
        }

        public void end_bulk_theme_override()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_end_bulk_theme_override__r0);
            Helpers.WaitForCompletion();
        }

        public void add_theme_icon_override(string name, ulong texture)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteUInt64(Commands.CMD_DATA + 1036, texture);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_add_theme_icon_override__21__24__r0);
            Helpers.WaitForCompletion();
        }

        public void add_theme_stylebox_override(string name, ulong stylebox)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteUInt64(Commands.CMD_DATA + 1036, stylebox);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_add_theme_stylebox_override__21__24__r0);
            Helpers.WaitForCompletion();
        }

        public void add_theme_font_override(string name, ulong font)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteUInt64(Commands.CMD_DATA + 1036, font);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_add_theme_font_override__21__24__r0);
            Helpers.WaitForCompletion();
        }

        public void add_theme_font_size_override(string name, long font_size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteInt64(Commands.CMD_DATA + 1036, font_size);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_add_theme_font_size_override__21__2__r0);
            Helpers.WaitForCompletion();
        }

        public void add_theme_color_override(string name, Color color)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteColor(Commands.CMD_DATA + 1036, color);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_add_theme_color_override__21__20__r0);
            Helpers.WaitForCompletion();
        }

        public void add_theme_constant_override(string name, long constant)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteInt64(Commands.CMD_DATA + 1036, constant);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_add_theme_constant_override__21__2__r0);
            Helpers.WaitForCompletion();
        }

        public void remove_theme_icon_override(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_remove_theme_icon_override__21__r0);
            Helpers.WaitForCompletion();
        }

        public void remove_theme_stylebox_override(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_remove_theme_stylebox_override__21__r0);
            Helpers.WaitForCompletion();
        }

        public void remove_theme_font_override(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_remove_theme_font_override__21__r0);
            Helpers.WaitForCompletion();
        }

        public void remove_theme_font_size_override(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_remove_theme_font_size_override__21__r0);
            Helpers.WaitForCompletion();
        }

        public void remove_theme_color_override(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_remove_theme_color_override__21__r0);
            Helpers.WaitForCompletion();
        }

        public void remove_theme_constant_override(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_remove_theme_constant_override__21__r0);
            Helpers.WaitForCompletion();
        }

        public ulong get_theme_icon(string name, string theme_type)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteStringName(Commands.CMD_DATA + 1036, theme_type);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_theme_icon__21__21__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong get_theme_stylebox(string name, string theme_type)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteStringName(Commands.CMD_DATA + 1036, theme_type);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_theme_stylebox__21__21__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong get_theme_font(string name, string theme_type)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteStringName(Commands.CMD_DATA + 1036, theme_type);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_theme_font__21__21__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public long get_theme_font_size(string name, string theme_type)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteStringName(Commands.CMD_DATA + 1036, theme_type);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_theme_font_size__21__21__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public Color get_theme_color(string name, string theme_type)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteStringName(Commands.CMD_DATA + 1036, theme_type);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_theme_color__21__21__r20);
            Helpers.WaitForCompletion();
            Color result = Helpers.ReadColor(Commands.CMD_DATA);
            return result;
        }

        public long get_theme_constant(string name, string theme_type)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteStringName(Commands.CMD_DATA + 1036, theme_type);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_theme_constant__21__21__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool has_theme_icon_override(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_has_theme_icon_override__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool has_theme_stylebox_override(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_has_theme_stylebox_override__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool has_theme_font_override(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_has_theme_font_override__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool has_theme_font_size_override(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_has_theme_font_size_override__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool has_theme_color_override(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_has_theme_color_override__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool has_theme_constant_override(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_has_theme_constant_override__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool has_theme_icon(string name, string theme_type)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteStringName(Commands.CMD_DATA + 1036, theme_type);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_has_theme_icon__21__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool has_theme_stylebox(string name, string theme_type)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteStringName(Commands.CMD_DATA + 1036, theme_type);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_has_theme_stylebox__21__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool has_theme_font(string name, string theme_type)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteStringName(Commands.CMD_DATA + 1036, theme_type);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_has_theme_font__21__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool has_theme_font_size(string name, string theme_type)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteStringName(Commands.CMD_DATA + 1036, theme_type);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_has_theme_font_size__21__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool has_theme_color(string name, string theme_type)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteStringName(Commands.CMD_DATA + 1036, theme_type);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_has_theme_color__21__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool has_theme_constant(string name, string theme_type)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteStringName(Commands.CMD_DATA + 1036, theme_type);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_has_theme_constant__21__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public double get_theme_default_base_scale()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_theme_default_base_scale__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public ulong get_theme_default_font()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_theme_default_font__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public long get_theme_default_font_size()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_theme_default_font_size__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong get_parent_control()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_parent_control__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_h_grow_direction(long direction)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, direction);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_h_grow_direction__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_h_grow_direction()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_h_grow_direction__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_v_grow_direction(long direction)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, direction);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_v_grow_direction__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_v_grow_direction()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_v_grow_direction__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_tooltip_auto_translate_mode(long mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, mode);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_tooltip_auto_translate_mode__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_tooltip_auto_translate_mode()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_tooltip_auto_translate_mode__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_tooltip_text(string hint)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, hint);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_tooltip_text__4__r0);
            Helpers.WaitForCompletion();
        }

        public string get_tooltip_text()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_tooltip_text__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public string get_tooltip(Vector2 at_position)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2(Commands.CMD_DATA + 8, at_position);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_tooltip__5__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void set_default_cursor_shape(long shape)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, shape);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_default_cursor_shape__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_default_cursor_shape()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_default_cursor_shape__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long get_cursor_shape(Vector2 position)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2(Commands.CMD_DATA + 8, position);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_cursor_shape__5__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_focus_neighbor(long side, string neighbor)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, side);
            Helpers.WriteNodePath(Commands.CMD_DATA + 16, neighbor);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_focus_neighbor__2__22__r0);
            Helpers.WaitForCompletion();
        }

        public string get_focus_neighbor(long side)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, side);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_focus_neighbor__2__r22);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadNodePath(Commands.CMD_DATA);
            return result;
        }

        public void set_focus_next(string next)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, next);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_focus_next__22__r0);
            Helpers.WaitForCompletion();
        }

        public string get_focus_next()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_focus_next__r22);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadNodePath(Commands.CMD_DATA);
            return result;
        }

        public void set_focus_previous(string previous)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, previous);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_focus_previous__22__r0);
            Helpers.WaitForCompletion();
        }

        public string get_focus_previous()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_focus_previous__r22);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadNodePath(Commands.CMD_DATA);
            return result;
        }

        public void force_drag(object arg_data, ulong preview)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVariant(Commands.CMD_DATA + 8, arg_data);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, preview);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_force_drag__0__24__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_drag()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_accessibility_drag__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_drop()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_accessibility_drop__r0);
            Helpers.WaitForCompletion();
        }

        public void set_accessibility_name(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_accessibility_name__4__r0);
            Helpers.WaitForCompletion();
        }

        public string get_accessibility_name()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_accessibility_name__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void set_accessibility_description(string description)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, description);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_accessibility_description__4__r0);
            Helpers.WaitForCompletion();
        }

        public string get_accessibility_description()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_accessibility_description__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void set_accessibility_live(long mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, mode);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_accessibility_live__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_accessibility_live()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_accessibility_live__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_accessibility_controls_nodes(object node_path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteArray(Commands.CMD_DATA + 8, node_path);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_accessibility_controls_nodes__28__r0);
            Helpers.WaitForCompletion();
        }

        public object get_accessibility_controls_nodes()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_accessibility_controls_nodes__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void set_accessibility_described_by_nodes(object node_path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteArray(Commands.CMD_DATA + 8, node_path);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_accessibility_described_by_nodes__28__r0);
            Helpers.WaitForCompletion();
        }

        public object get_accessibility_described_by_nodes()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_accessibility_described_by_nodes__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void set_accessibility_labeled_by_nodes(object node_path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteArray(Commands.CMD_DATA + 8, node_path);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_accessibility_labeled_by_nodes__28__r0);
            Helpers.WaitForCompletion();
        }

        public object get_accessibility_labeled_by_nodes()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_accessibility_labeled_by_nodes__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void set_accessibility_flow_to_nodes(object node_path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteArray(Commands.CMD_DATA + 8, node_path);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_accessibility_flow_to_nodes__28__r0);
            Helpers.WaitForCompletion();
        }

        public object get_accessibility_flow_to_nodes()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_accessibility_flow_to_nodes__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void set_mouse_filter(long filter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, filter);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_mouse_filter__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_mouse_filter()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_mouse_filter__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long get_mouse_filter_with_override()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_mouse_filter_with_override__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_mouse_behavior_recursive(long mouse_behavior_recursive)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, mouse_behavior_recursive);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_mouse_behavior_recursive__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_mouse_behavior_recursive()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_mouse_behavior_recursive__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_force_pass_scroll_events(bool force_pass_scroll_events)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, force_pass_scroll_events ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_force_pass_scroll_events__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_force_pass_scroll_events()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_is_force_pass_scroll_events__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_clip_contents(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_clip_contents__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_clipping_contents()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_is_clipping_contents__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void grab_click_focus()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_grab_click_focus__r0);
            Helpers.WaitForCompletion();
        }

        public void set_drag_forwarding(object drag_func, object can_drop_func, object drop_func)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteCallable(Commands.CMD_DATA + 8, drag_func);
            Helpers.WriteCallable(Commands.CMD_DATA + 8, can_drop_func);
            Helpers.WriteCallable(Commands.CMD_DATA + 8, drop_func);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_drag_forwarding__25__25__25__r0);
            Helpers.WaitForCompletion();
        }

        public void set_drag_preview(ulong control)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, control);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_drag_preview__24__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_drag_successful()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_is_drag_successful__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void warp_mouse(Vector2 position)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2(Commands.CMD_DATA + 8, position);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_warp_mouse__5__r0);
            Helpers.WaitForCompletion();
        }

        public void set_shortcut_context(ulong node)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, node);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_shortcut_context__24__r0);
            Helpers.WaitForCompletion();
        }

        public ulong get_shortcut_context()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_shortcut_context__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void update_minimum_size()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_update_minimum_size__r0);
            Helpers.WaitForCompletion();
        }

        public void set_layout_direction(long direction)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, direction);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_layout_direction__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_layout_direction()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_layout_direction__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool is_layout_rtl()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_is_layout_rtl__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_auto_translate(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_auto_translate__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_auto_translating()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_is_auto_translating__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_localize_numeral_system(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_localize_numeral_system__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_localizing_numeral_system()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_is_localizing_numeral_system__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _draw()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__draw__r0);
            Helpers.WaitForCompletion();
        }

        public void _top_level_raise_self()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__top_level_raise_self__r0);
            Helpers.WaitForCompletion();
        }

        public void _edit_set_state(object state)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDictionary(Commands.CMD_DATA + 8, state);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__edit_set_state__27__r0);
            Helpers.WaitForCompletion();
        }

        public object _edit_get_state()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__edit_get_state__r27);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadDictionary(Commands.CMD_DATA);
            return result;
        }

        public void _edit_set_position(Vector2 position)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2(Commands.CMD_DATA + 8, position);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__edit_set_position__5__r0);
            Helpers.WaitForCompletion();
        }

        public Vector2 _edit_get_position()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__edit_get_position__r5);
            Helpers.WaitForCompletion();
            Vector2 result = Helpers.ReadVector2(Commands.CMD_DATA);
            return result;
        }

        public void _edit_set_scale(Vector2 scale)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2(Commands.CMD_DATA + 8, scale);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__edit_set_scale__5__r0);
            Helpers.WaitForCompletion();
        }

        public Vector2 _edit_get_scale()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__edit_get_scale__r5);
            Helpers.WaitForCompletion();
            Vector2 result = Helpers.ReadVector2(Commands.CMD_DATA);
            return result;
        }

        public void _edit_set_rect(Rect2 rect)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRect2(Commands.CMD_DATA + 8, rect);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__edit_set_rect__7__r0);
            Helpers.WaitForCompletion();
        }

        public Rect2 _edit_get_rect()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__edit_get_rect__r7);
            Helpers.WaitForCompletion();
            Rect2 result = Helpers.ReadRect2(Commands.CMD_DATA);
            return result;
        }

        public bool _edit_use_rect()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__edit_use_rect__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _edit_set_rotation(double degrees)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDouble(Commands.CMD_DATA + 8, degrees);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__edit_set_rotation__3__r0);
            Helpers.WaitForCompletion();
        }

        public double _edit_get_rotation()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__edit_get_rotation__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public bool _edit_use_rotation()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__edit_use_rotation__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _edit_set_pivot(Vector2 pivot)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2(Commands.CMD_DATA + 8, pivot);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__edit_set_pivot__5__r0);
            Helpers.WaitForCompletion();
        }

        public Vector2 _edit_get_pivot()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__edit_get_pivot__r5);
            Helpers.WaitForCompletion();
            Vector2 result = Helpers.ReadVector2(Commands.CMD_DATA);
            return result;
        }

        public bool _edit_use_pivot()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__edit_use_pivot__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public Transform2D _edit_get_transform()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__edit_get_transform__r11);
            Helpers.WaitForCompletion();
            Transform2D result = Helpers.ReadTransform2D(Commands.CMD_DATA);
            return result;
        }

        public ulong get_canvas_item()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_canvas_item__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void set_visible(bool visible)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, visible ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_visible__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_visible()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_is_visible__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool is_visible_in_tree()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_is_visible_in_tree__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void show()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_show__r0);
            Helpers.WaitForCompletion();
        }

        public void hide()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_hide__r0);
            Helpers.WaitForCompletion();
        }

        public void queue_redraw()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_queue_redraw__r0);
            Helpers.WaitForCompletion();
        }

        public void move_to_front()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_move_to_front__r0);
            Helpers.WaitForCompletion();
        }

        public void set_as_top_level(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_as_top_level__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_set_as_top_level()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_is_set_as_top_level__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_light_mask(long light_mask)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, light_mask);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_light_mask__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_light_mask()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_light_mask__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_modulate(Color modulate)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteColor(Commands.CMD_DATA + 8, modulate);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_modulate__20__r0);
            Helpers.WaitForCompletion();
        }

        public Color get_modulate()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_modulate__r20);
            Helpers.WaitForCompletion();
            Color result = Helpers.ReadColor(Commands.CMD_DATA);
            return result;
        }

        public void set_self_modulate(Color self_modulate)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteColor(Commands.CMD_DATA + 8, self_modulate);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_self_modulate__20__r0);
            Helpers.WaitForCompletion();
        }

        public Color get_self_modulate()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_self_modulate__r20);
            Helpers.WaitForCompletion();
            Color result = Helpers.ReadColor(Commands.CMD_DATA);
            return result;
        }

        public void set_z_index(long z_index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, z_index);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_z_index__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_z_index()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_z_index__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_z_as_relative(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_z_as_relative__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_z_relative()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_is_z_relative__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_y_sort_enabled(bool enabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_y_sort_enabled__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_y_sort_enabled()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_is_y_sort_enabled__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_draw_behind_parent(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_draw_behind_parent__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_draw_behind_parent_enabled()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_is_draw_behind_parent_enabled__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void draw_line(Vector2 from, Vector2 to, Color color, double width, bool antialiased)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2(Commands.CMD_DATA + 8, from);
            Helpers.WriteVector2(Commands.CMD_DATA + 16, to);
            Helpers.WriteColor(Commands.CMD_DATA + 24, color);
            Helpers.WriteDouble(Commands.CMD_DATA + 40, width);
            Helpers.WriteInt32(Commands.CMD_DATA + 48, antialiased ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_draw_line__5__5__20__3__1__r0);
            Helpers.WaitForCompletion();
        }

        public void draw_dashed_line(Vector2 from, Vector2 to, Color color, double width, double dash, bool aligned, bool antialiased)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2(Commands.CMD_DATA + 8, from);
            Helpers.WriteVector2(Commands.CMD_DATA + 16, to);
            Helpers.WriteColor(Commands.CMD_DATA + 24, color);
            Helpers.WriteDouble(Commands.CMD_DATA + 40, width);
            Helpers.WriteDouble(Commands.CMD_DATA + 48, dash);
            Helpers.WriteInt32(Commands.CMD_DATA + 56, aligned ? 1 : 0);
            Helpers.WriteInt32(Commands.CMD_DATA + 60, antialiased ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_draw_dashed_line__5__5__20__3__3__1__1__r0);
            Helpers.WaitForCompletion();
        }

        public void draw_polyline(Vector2[] points, Color color, double width, bool antialiased)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WritePackedVector2Array(Commands.CMD_DATA + 8, points);
            Helpers.WriteColor(Commands.CMD_DATA + 8, color);
            Helpers.WriteDouble(Commands.CMD_DATA + 24, width);
            Helpers.WriteInt32(Commands.CMD_DATA + 32, antialiased ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_draw_polyline__35__20__3__1__r0);
            Helpers.WaitForCompletion();
        }

        public void draw_polyline_colors(Vector2[] points, Color[] colors, double width, bool antialiased)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WritePackedVector2Array(Commands.CMD_DATA + 8, points);
            Helpers.WritePackedColorArray(Commands.CMD_DATA + 8, colors);
            Helpers.WriteDouble(Commands.CMD_DATA + 8, width);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, antialiased ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_draw_polyline_colors__35__37__3__1__r0);
            Helpers.WaitForCompletion();
        }

        public void draw_ellipse_arc(Vector2 center, double major, double minor, double start_angle, double end_angle, long point_count, Color color, double width, bool antialiased)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2(Commands.CMD_DATA + 8, center);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, major);
            Helpers.WriteDouble(Commands.CMD_DATA + 24, minor);
            Helpers.WriteDouble(Commands.CMD_DATA + 32, start_angle);
            Helpers.WriteDouble(Commands.CMD_DATA + 40, end_angle);
            Helpers.WriteInt64(Commands.CMD_DATA + 48, point_count);
            Helpers.WriteColor(Commands.CMD_DATA + 56, color);
            Helpers.WriteDouble(Commands.CMD_DATA + 72, width);
            Helpers.WriteInt32(Commands.CMD_DATA + 80, antialiased ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_draw_ellipse_arc__5__3__3__3__3__2__20__3__1__r0);
            Helpers.WaitForCompletion();
        }

        public void draw_arc(Vector2 center, double radius, double start_angle, double end_angle, long point_count, Color color, double width, bool antialiased)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2(Commands.CMD_DATA + 8, center);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, radius);
            Helpers.WriteDouble(Commands.CMD_DATA + 24, start_angle);
            Helpers.WriteDouble(Commands.CMD_DATA + 32, end_angle);
            Helpers.WriteInt64(Commands.CMD_DATA + 40, point_count);
            Helpers.WriteColor(Commands.CMD_DATA + 48, color);
            Helpers.WriteDouble(Commands.CMD_DATA + 64, width);
            Helpers.WriteInt32(Commands.CMD_DATA + 72, antialiased ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_draw_arc__5__3__3__3__2__20__3__1__r0);
            Helpers.WaitForCompletion();
        }

        public void draw_multiline(Vector2[] points, Color color, double width, bool antialiased)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WritePackedVector2Array(Commands.CMD_DATA + 8, points);
            Helpers.WriteColor(Commands.CMD_DATA + 8, color);
            Helpers.WriteDouble(Commands.CMD_DATA + 24, width);
            Helpers.WriteInt32(Commands.CMD_DATA + 32, antialiased ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_draw_multiline__35__20__3__1__r0);
            Helpers.WaitForCompletion();
        }

        public void draw_multiline_colors(Vector2[] points, Color[] colors, double width, bool antialiased)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WritePackedVector2Array(Commands.CMD_DATA + 8, points);
            Helpers.WritePackedColorArray(Commands.CMD_DATA + 8, colors);
            Helpers.WriteDouble(Commands.CMD_DATA + 8, width);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, antialiased ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_draw_multiline_colors__35__37__3__1__r0);
            Helpers.WaitForCompletion();
        }

        public void draw_rect(Rect2 rect, Color color, bool filled, double width, bool antialiased)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRect2(Commands.CMD_DATA + 8, rect);
            Helpers.WriteColor(Commands.CMD_DATA + 24, color);
            Helpers.WriteInt32(Commands.CMD_DATA + 40, filled ? 1 : 0);
            Helpers.WriteDouble(Commands.CMD_DATA + 44, width);
            Helpers.WriteInt32(Commands.CMD_DATA + 52, antialiased ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_draw_rect__7__20__1__3__1__r0);
            Helpers.WaitForCompletion();
        }

        public void draw_circle(Vector2 position, double radius, Color color, bool filled, double width, bool antialiased)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2(Commands.CMD_DATA + 8, position);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, radius);
            Helpers.WriteColor(Commands.CMD_DATA + 24, color);
            Helpers.WriteInt32(Commands.CMD_DATA + 40, filled ? 1 : 0);
            Helpers.WriteDouble(Commands.CMD_DATA + 44, width);
            Helpers.WriteInt32(Commands.CMD_DATA + 52, antialiased ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_draw_circle__5__3__20__1__3__1__r0);
            Helpers.WaitForCompletion();
        }

        public void draw_ellipse(Vector2 position, double major, double minor, Color color, bool filled, double width, bool antialiased)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2(Commands.CMD_DATA + 8, position);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, major);
            Helpers.WriteDouble(Commands.CMD_DATA + 24, minor);
            Helpers.WriteColor(Commands.CMD_DATA + 32, color);
            Helpers.WriteInt32(Commands.CMD_DATA + 48, filled ? 1 : 0);
            Helpers.WriteDouble(Commands.CMD_DATA + 52, width);
            Helpers.WriteInt32(Commands.CMD_DATA + 60, antialiased ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_draw_ellipse__5__3__3__20__1__3__1__r0);
            Helpers.WaitForCompletion();
        }

        public void draw_texture(ulong texture, Vector2 position, Color modulate)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, texture);
            Helpers.WriteVector2(Commands.CMD_DATA + 16, position);
            Helpers.WriteColor(Commands.CMD_DATA + 24, modulate);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_draw_texture__24__5__20__r0);
            Helpers.WaitForCompletion();
        }

        public void draw_texture_rect(ulong texture, Rect2 rect, bool tile, Color modulate, bool transpose)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, texture);
            Helpers.WriteRect2(Commands.CMD_DATA + 16, rect);
            Helpers.WriteInt32(Commands.CMD_DATA + 32, tile ? 1 : 0);
            Helpers.WriteColor(Commands.CMD_DATA + 36, modulate);
            Helpers.WriteInt32(Commands.CMD_DATA + 52, transpose ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_draw_texture_rect__24__7__1__20__1__r0);
            Helpers.WaitForCompletion();
        }

        public void draw_texture_rect_region(ulong texture, Rect2 rect, Rect2 src_rect, Color modulate, bool transpose, bool clip_uv)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, texture);
            Helpers.WriteRect2(Commands.CMD_DATA + 16, rect);
            Helpers.WriteRect2(Commands.CMD_DATA + 32, src_rect);
            Helpers.WriteColor(Commands.CMD_DATA + 48, modulate);
            Helpers.WriteInt32(Commands.CMD_DATA + 64, transpose ? 1 : 0);
            Helpers.WriteInt32(Commands.CMD_DATA + 68, clip_uv ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_draw_texture_rect_region__24__7__7__20__1__1__r0);
            Helpers.WaitForCompletion();
        }

        public void draw_msdf_texture_rect_region(ulong texture, Rect2 rect, Rect2 src_rect, Color modulate, double outline, double pixel_range, double scale)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, texture);
            Helpers.WriteRect2(Commands.CMD_DATA + 16, rect);
            Helpers.WriteRect2(Commands.CMD_DATA + 32, src_rect);
            Helpers.WriteColor(Commands.CMD_DATA + 48, modulate);
            Helpers.WriteDouble(Commands.CMD_DATA + 64, outline);
            Helpers.WriteDouble(Commands.CMD_DATA + 72, pixel_range);
            Helpers.WriteDouble(Commands.CMD_DATA + 80, scale);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_draw_msdf_texture_rect_region__24__7__7__20__3__3__3__r0);
            Helpers.WaitForCompletion();
        }

        public void draw_lcd_texture_rect_region(ulong texture, Rect2 rect, Rect2 src_rect, Color modulate)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, texture);
            Helpers.WriteRect2(Commands.CMD_DATA + 16, rect);
            Helpers.WriteRect2(Commands.CMD_DATA + 32, src_rect);
            Helpers.WriteColor(Commands.CMD_DATA + 48, modulate);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_draw_lcd_texture_rect_region__24__7__7__20__r0);
            Helpers.WaitForCompletion();
        }

        public void draw_style_box(ulong style_box, Rect2 rect)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, style_box);
            Helpers.WriteRect2(Commands.CMD_DATA + 16, rect);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_draw_style_box__24__7__r0);
            Helpers.WaitForCompletion();
        }

        public void draw_primitive(Vector2[] points, Color[] colors, Vector2[] uvs, ulong texture)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WritePackedVector2Array(Commands.CMD_DATA + 8, points);
            Helpers.WritePackedColorArray(Commands.CMD_DATA + 8, colors);
            Helpers.WritePackedVector2Array(Commands.CMD_DATA + 8, uvs);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, texture);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_draw_primitive__35__37__35__24__r0);
            Helpers.WaitForCompletion();
        }

        public void draw_polygon(Vector2[] points, Color[] colors, Vector2[] uvs, ulong texture)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WritePackedVector2Array(Commands.CMD_DATA + 8, points);
            Helpers.WritePackedColorArray(Commands.CMD_DATA + 8, colors);
            Helpers.WritePackedVector2Array(Commands.CMD_DATA + 8, uvs);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, texture);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_draw_polygon__35__37__35__24__r0);
            Helpers.WaitForCompletion();
        }

        public void draw_colored_polygon(Vector2[] points, Color color, Vector2[] uvs, ulong texture)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WritePackedVector2Array(Commands.CMD_DATA + 8, points);
            Helpers.WriteColor(Commands.CMD_DATA + 8, color);
            Helpers.WritePackedVector2Array(Commands.CMD_DATA + 24, uvs);
            Helpers.WriteUInt64(Commands.CMD_DATA + 24, texture);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_draw_colored_polygon__35__20__35__24__r0);
            Helpers.WaitForCompletion();
        }

        public void draw_string(ulong font, Vector2 pos, string text, long alignment, double width, long font_size, Color modulate, long justification_flags, long direction, long orientation, double oversampling)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, font);
            Helpers.WriteVector2(Commands.CMD_DATA + 16, pos);
            Helpers.WriteString(Commands.CMD_DATA + 24, text);
            Helpers.WriteInt64(Commands.CMD_DATA + 1052, alignment);
            Helpers.WriteDouble(Commands.CMD_DATA + 1060, width);
            Helpers.WriteInt64(Commands.CMD_DATA + 1068, font_size);
            Helpers.WriteColor(Commands.CMD_DATA + 1076, modulate);
            Helpers.WriteInt64(Commands.CMD_DATA + 1092, justification_flags);
            Helpers.WriteInt64(Commands.CMD_DATA + 1100, direction);
            Helpers.WriteInt64(Commands.CMD_DATA + 1108, orientation);
            Helpers.WriteDouble(Commands.CMD_DATA + 1116, oversampling);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_draw_string__24__5__4__2__3__2__20__2__2__2__3__r0);
            Helpers.WaitForCompletion();
        }

        public void draw_multiline_string(ulong font, Vector2 pos, string text, long alignment, double width, long font_size, long max_lines, Color modulate, long brk_flags, long justification_flags, long direction, long orientation, double oversampling)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, font);
            Helpers.WriteVector2(Commands.CMD_DATA + 16, pos);
            Helpers.WriteString(Commands.CMD_DATA + 24, text);
            Helpers.WriteInt64(Commands.CMD_DATA + 1052, alignment);
            Helpers.WriteDouble(Commands.CMD_DATA + 1060, width);
            Helpers.WriteInt64(Commands.CMD_DATA + 1068, font_size);
            Helpers.WriteInt64(Commands.CMD_DATA + 1076, max_lines);
            Helpers.WriteColor(Commands.CMD_DATA + 1084, modulate);
            Helpers.WriteInt64(Commands.CMD_DATA + 1100, brk_flags);
            Helpers.WriteInt64(Commands.CMD_DATA + 1108, justification_flags);
            Helpers.WriteInt64(Commands.CMD_DATA + 1116, direction);
            Helpers.WriteInt64(Commands.CMD_DATA + 1124, orientation);
            Helpers.WriteDouble(Commands.CMD_DATA + 1132, oversampling);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_draw_multiline_string__24__5__4__2__3__2__2__20__2__2__2__2__3__r0);
            Helpers.WaitForCompletion();
        }

        public void draw_string_outline(ulong font, Vector2 pos, string text, long alignment, double width, long font_size, long size, Color modulate, long justification_flags, long direction, long orientation, double oversampling)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, font);
            Helpers.WriteVector2(Commands.CMD_DATA + 16, pos);
            Helpers.WriteString(Commands.CMD_DATA + 24, text);
            Helpers.WriteInt64(Commands.CMD_DATA + 1052, alignment);
            Helpers.WriteDouble(Commands.CMD_DATA + 1060, width);
            Helpers.WriteInt64(Commands.CMD_DATA + 1068, font_size);
            Helpers.WriteInt64(Commands.CMD_DATA + 1076, size);
            Helpers.WriteColor(Commands.CMD_DATA + 1084, modulate);
            Helpers.WriteInt64(Commands.CMD_DATA + 1100, justification_flags);
            Helpers.WriteInt64(Commands.CMD_DATA + 1108, direction);
            Helpers.WriteInt64(Commands.CMD_DATA + 1116, orientation);
            Helpers.WriteDouble(Commands.CMD_DATA + 1124, oversampling);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_draw_string_outline__24__5__4__2__3__2__2__20__2__2__2__3__r0);
            Helpers.WaitForCompletion();
        }

        public void draw_multiline_string_outline(ulong font, Vector2 pos, string text, long alignment, double width, long font_size, long max_lines, long size, Color modulate, long brk_flags, long justification_flags, long direction, long orientation, double oversampling)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, font);
            Helpers.WriteVector2(Commands.CMD_DATA + 16, pos);
            Helpers.WriteString(Commands.CMD_DATA + 24, text);
            Helpers.WriteInt64(Commands.CMD_DATA + 1052, alignment);
            Helpers.WriteDouble(Commands.CMD_DATA + 1060, width);
            Helpers.WriteInt64(Commands.CMD_DATA + 1068, font_size);
            Helpers.WriteInt64(Commands.CMD_DATA + 1076, max_lines);
            Helpers.WriteInt64(Commands.CMD_DATA + 1084, size);
            Helpers.WriteColor(Commands.CMD_DATA + 1092, modulate);
            Helpers.WriteInt64(Commands.CMD_DATA + 1108, brk_flags);
            Helpers.WriteInt64(Commands.CMD_DATA + 1116, justification_flags);
            Helpers.WriteInt64(Commands.CMD_DATA + 1124, direction);
            Helpers.WriteInt64(Commands.CMD_DATA + 1132, orientation);
            Helpers.WriteDouble(Commands.CMD_DATA + 1140, oversampling);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_draw_multiline_string_outline__24__5__4__2__3__2__2__2__20__2__2__2__2__3__r0);
            Helpers.WaitForCompletion();
        }

        public void draw_char(ulong font, Vector2 pos, string char_, long font_size, Color modulate, double oversampling)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, font);
            Helpers.WriteVector2(Commands.CMD_DATA + 16, pos);
            Helpers.WriteString(Commands.CMD_DATA + 24, char_);
            Helpers.WriteInt64(Commands.CMD_DATA + 1052, font_size);
            Helpers.WriteColor(Commands.CMD_DATA + 1060, modulate);
            Helpers.WriteDouble(Commands.CMD_DATA + 1076, oversampling);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_draw_char__24__5__4__2__20__3__r0);
            Helpers.WaitForCompletion();
        }

        public void draw_char_outline(ulong font, Vector2 pos, string char_, long font_size, long size, Color modulate, double oversampling)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, font);
            Helpers.WriteVector2(Commands.CMD_DATA + 16, pos);
            Helpers.WriteString(Commands.CMD_DATA + 24, char_);
            Helpers.WriteInt64(Commands.CMD_DATA + 1052, font_size);
            Helpers.WriteInt64(Commands.CMD_DATA + 1060, size);
            Helpers.WriteColor(Commands.CMD_DATA + 1068, modulate);
            Helpers.WriteDouble(Commands.CMD_DATA + 1084, oversampling);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_draw_char_outline__24__5__4__2__2__20__3__r0);
            Helpers.WaitForCompletion();
        }

        public void draw_mesh(ulong mesh, ulong texture, Transform2D transform, Color modulate)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, mesh);
            Helpers.WriteUInt64(Commands.CMD_DATA + 16, texture);
            Helpers.WriteTransform2D(Commands.CMD_DATA + 24, transform);
            Helpers.WriteColor(Commands.CMD_DATA + 48, modulate);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_draw_mesh__24__24__11__20__r0);
            Helpers.WaitForCompletion();
        }

        public void draw_multimesh(ulong multimesh, ulong texture)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, multimesh);
            Helpers.WriteUInt64(Commands.CMD_DATA + 16, texture);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_draw_multimesh__24__24__r0);
            Helpers.WaitForCompletion();
        }

        public void draw_set_transform(Vector2 position, double rotation, Vector2 scale)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2(Commands.CMD_DATA + 8, position);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, rotation);
            Helpers.WriteVector2(Commands.CMD_DATA + 24, scale);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_draw_set_transform__5__3__5__r0);
            Helpers.WaitForCompletion();
        }

        public void draw_set_transform_matrix(Transform2D xform)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteTransform2D(Commands.CMD_DATA + 8, xform);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_draw_set_transform_matrix__11__r0);
            Helpers.WaitForCompletion();
        }

        public void draw_animation_slice(double animation_length, double slice_begin, double slice_end, double offset)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDouble(Commands.CMD_DATA + 8, animation_length);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, slice_begin);
            Helpers.WriteDouble(Commands.CMD_DATA + 24, slice_end);
            Helpers.WriteDouble(Commands.CMD_DATA + 32, offset);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_draw_animation_slice__3__3__3__3__r0);
            Helpers.WaitForCompletion();
        }

        public void draw_end_animation()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_draw_end_animation__r0);
            Helpers.WaitForCompletion();
        }

        public Transform2D get_transform()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_transform__r11);
            Helpers.WaitForCompletion();
            Transform2D result = Helpers.ReadTransform2D(Commands.CMD_DATA);
            return result;
        }

        public Transform2D get_global_transform()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_global_transform__r11);
            Helpers.WaitForCompletion();
            Transform2D result = Helpers.ReadTransform2D(Commands.CMD_DATA);
            return result;
        }

        public Transform2D get_global_transform_with_canvas()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_global_transform_with_canvas__r11);
            Helpers.WaitForCompletion();
            Transform2D result = Helpers.ReadTransform2D(Commands.CMD_DATA);
            return result;
        }

        public Transform2D get_viewport_transform()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_viewport_transform__r11);
            Helpers.WaitForCompletion();
            Transform2D result = Helpers.ReadTransform2D(Commands.CMD_DATA);
            return result;
        }

        public Rect2 get_viewport_rect()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_viewport_rect__r7);
            Helpers.WaitForCompletion();
            Rect2 result = Helpers.ReadRect2(Commands.CMD_DATA);
            return result;
        }

        public Transform2D get_canvas_transform()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_canvas_transform__r11);
            Helpers.WaitForCompletion();
            Transform2D result = Helpers.ReadTransform2D(Commands.CMD_DATA);
            return result;
        }

        public Transform2D get_screen_transform()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_screen_transform__r11);
            Helpers.WaitForCompletion();
            Transform2D result = Helpers.ReadTransform2D(Commands.CMD_DATA);
            return result;
        }

        public Vector2 get_local_mouse_position()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_local_mouse_position__r5);
            Helpers.WaitForCompletion();
            Vector2 result = Helpers.ReadVector2(Commands.CMD_DATA);
            return result;
        }

        public Vector2 get_global_mouse_position()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_global_mouse_position__r5);
            Helpers.WaitForCompletion();
            Vector2 result = Helpers.ReadVector2(Commands.CMD_DATA);
            return result;
        }

        public ulong get_canvas()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_canvas__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public ulong get_canvas_layer_node()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_canvas_layer_node__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong get_world_2d()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_world_2d__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_material(ulong material)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, material);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_material__24__r0);
            Helpers.WaitForCompletion();
        }

        public ulong get_material()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_material__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_instance_shader_parameter(string name, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_instance_shader_parameter__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get_instance_shader_parameter(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_instance_shader_parameter__21__r0);
            Helpers.WaitForCompletion();
        }

        public void set_use_parent_material(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_use_parent_material__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool get_use_parent_material()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_use_parent_material__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_notify_local_transform(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_notify_local_transform__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_local_transform_notification_enabled()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_is_local_transform_notification_enabled__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_notify_transform(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_notify_transform__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_transform_notification_enabled()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_is_transform_notification_enabled__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void force_update_transform()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_force_update_transform__r0);
            Helpers.WaitForCompletion();
        }

        public Vector2 make_canvas_position_local(Vector2 viewport_point)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2(Commands.CMD_DATA + 8, viewport_point);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_make_canvas_position_local__5__r5);
            Helpers.WaitForCompletion();
            Vector2 result = Helpers.ReadVector2(Commands.CMD_DATA);
            return result;
        }

        public ulong make_input_local(ulong event_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, event_);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_make_input_local__24__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_visibility_layer(long layer)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, layer);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_visibility_layer__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_visibility_layer()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_visibility_layer__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_visibility_layer_bit(long layer, bool enabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, layer);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_visibility_layer_bit__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool get_visibility_layer_bit(long layer)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, layer);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_visibility_layer_bit__2__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_texture_filter(long mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, mode);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_texture_filter__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_texture_filter()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_texture_filter__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_texture_repeat(long mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, mode);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_texture_repeat__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_texture_repeat()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_texture_repeat__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_clip_children_mode(long mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, mode);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_clip_children_mode__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_clip_children_mode()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_clip_children_mode__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void _process(double delta)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDouble(Commands.CMD_DATA + 8, delta);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__process__3__r0);
            Helpers.WaitForCompletion();
        }

        public void _physics_process(double delta)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDouble(Commands.CMD_DATA + 8, delta);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__physics_process__3__r0);
            Helpers.WaitForCompletion();
        }

        public void _enter_tree()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__enter_tree__r0);
            Helpers.WaitForCompletion();
        }

        public void _exit_tree()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__exit_tree__r0);
            Helpers.WaitForCompletion();
        }

        public void _ready()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__ready__r0);
            Helpers.WaitForCompletion();
        }

        public string[] _get_configuration_warnings()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__get_configuration_warnings__r34);
            Helpers.WaitForCompletion();
            string[] result = Helpers.ReadPackedStringArray(Commands.CMD_DATA);
            return result;
        }

        public string[] _get_accessibility_configuration_warnings()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__get_accessibility_configuration_warnings__r34);
            Helpers.WaitForCompletion();
            string[] result = Helpers.ReadPackedStringArray(Commands.CMD_DATA);
            return result;
        }

        public void _input(ulong event_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, event_);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__input__24__r0);
            Helpers.WaitForCompletion();
        }

        public void _shortcut_input(ulong event_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, event_);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__shortcut_input__24__r0);
            Helpers.WaitForCompletion();
        }

        public void _unhandled_input(ulong event_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, event_);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__unhandled_input__24__r0);
            Helpers.WaitForCompletion();
        }

        public void _unhandled_key_input(ulong event_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, event_);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__unhandled_key_input__24__r0);
            Helpers.WaitForCompletion();
        }

        public ulong _get_focused_accessibility_element()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__get_focused_accessibility_element__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void print_orphan_nodes()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_print_orphan_nodes__r0);
            Helpers.WaitForCompletion();
        }

        public object get_orphan_node_ids()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_orphan_node_ids__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void add_sibling(ulong sibling, bool force_readable_name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, sibling);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, force_readable_name ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_add_sibling__24__1__r0);
            Helpers.WaitForCompletion();
        }

        public void set_name(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_name__21__r0);
            Helpers.WaitForCompletion();
        }

        public string get_name()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_name__r21);
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
            Helpers.SendCommand(Commands.CMD_ScrollContainer_add_child__24__1__2__r0);
            Helpers.WaitForCompletion();
        }

        public void remove_child(ulong node)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, node);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_remove_child__24__r0);
            Helpers.WaitForCompletion();
        }

        public void reparent(ulong new_parent, bool keep_global_transform)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, new_parent);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, keep_global_transform ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_reparent__24__1__r0);
            Helpers.WaitForCompletion();
        }

        public long get_child_count(bool include_internal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, include_internal ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_child_count__1__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public object get_children(bool include_internal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, include_internal ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_children__1__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public ulong get_child(long idx, bool include_internal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, idx);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, include_internal ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_child__2__1__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public bool has_node(string path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, path);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_has_node__22__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public ulong get_node(string path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, path);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_node__22__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong get_node_or_null(string path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, path);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_node_or_null__22__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong get_parent()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_parent__r24);
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
            Helpers.SendCommand(Commands.CMD_ScrollContainer_find_child__4__1__1__r24);
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
            Helpers.SendCommand(Commands.CMD_ScrollContainer_find_children__4__4__1__1__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public ulong find_parent(string pattern)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, pattern);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_find_parent__4__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public bool has_node_and_resource(string path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, path);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_has_node_and_resource__22__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public object get_node_and_resource(string path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, path);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_node_and_resource__22__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public bool is_inside_tree()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_is_inside_tree__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool is_part_of_edited_scene()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_is_part_of_edited_scene__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool is_ancestor_of(ulong node)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, node);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_is_ancestor_of__24__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool is_greater_than(ulong node)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, node);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_is_greater_than__24__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public string get_path()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_path__r22);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadNodePath(Commands.CMD_DATA);
            return result;
        }

        public string get_path_to(ulong node, bool use_unique_path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, node);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, use_unique_path ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_path_to__24__1__r22);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadNodePath(Commands.CMD_DATA);
            return result;
        }

        public void add_to_group(string group, bool persistent)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, group);
            Helpers.WriteInt32(Commands.CMD_DATA + 1036, persistent ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_add_to_group__21__1__r0);
            Helpers.WaitForCompletion();
        }

        public void remove_from_group(string group)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, group);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_remove_from_group__21__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_in_group(string group)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, group);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_is_in_group__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void move_child(ulong child_node, long to_index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, child_node);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, to_index);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_move_child__24__2__r0);
            Helpers.WaitForCompletion();
        }

        public object get_groups()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_groups__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void set_owner(ulong owner)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, owner);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_owner__24__r0);
            Helpers.WaitForCompletion();
        }

        public ulong get_owner()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_owner__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public long get_index(bool include_internal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, include_internal ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_index__1__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void print_tree()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_print_tree__r0);
            Helpers.WaitForCompletion();
        }

        public void print_tree_pretty()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_print_tree_pretty__r0);
            Helpers.WaitForCompletion();
        }

        public string get_tree_string()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_tree_string__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public string get_tree_string_pretty()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_tree_string_pretty__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void set_scene_file_path(string scene_file_path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, scene_file_path);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_scene_file_path__4__r0);
            Helpers.WaitForCompletion();
        }

        public string get_scene_file_path()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_scene_file_path__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void propagate_notification(long what)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, what);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_propagate_notification__2__r0);
            Helpers.WaitForCompletion();
        }

        public void propagate_call(string method, object args, bool parent_first)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.WriteArray(Commands.CMD_DATA + 1036, args);
            Helpers.WriteInt32(Commands.CMD_DATA + 1036, parent_first ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_propagate_call__21__28__1__r0);
            Helpers.WaitForCompletion();
        }

        public void set_physics_process(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_physics_process__1__r0);
            Helpers.WaitForCompletion();
        }

        public double get_physics_process_delta_time()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_physics_process_delta_time__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public bool is_physics_processing()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_is_physics_processing__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public double get_process_delta_time()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_process_delta_time__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void set_process(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_process__1__r0);
            Helpers.WaitForCompletion();
        }

        public void set_process_priority(long priority)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, priority);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_process_priority__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_process_priority()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_process_priority__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_physics_process_priority(long priority)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, priority);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_physics_process_priority__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_physics_process_priority()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_physics_process_priority__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool is_processing()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_is_processing__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_process_input(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_process_input__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_processing_input()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_is_processing_input__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_process_shortcut_input(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_process_shortcut_input__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_processing_shortcut_input()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_is_processing_shortcut_input__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_process_unhandled_input(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_process_unhandled_input__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_processing_unhandled_input()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_is_processing_unhandled_input__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_process_unhandled_key_input(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_process_unhandled_key_input__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_processing_unhandled_key_input()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_is_processing_unhandled_key_input__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_process_mode(long mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, mode);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_process_mode__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_process_mode()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_process_mode__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool can_process()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_can_process__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_process_thread_group(long mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, mode);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_process_thread_group__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_process_thread_group()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_process_thread_group__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_process_thread_messages(long flags)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, flags);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_process_thread_messages__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_process_thread_messages()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_process_thread_messages__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_process_thread_group_order(long order)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, order);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_process_thread_group_order__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_process_thread_group_order()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_process_thread_group_order__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void queue_accessibility_update()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_queue_accessibility_update__r0);
            Helpers.WaitForCompletion();
        }

        public ulong get_accessibility_element()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_accessibility_element__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void set_display_folded(bool fold)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, fold ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_display_folded__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_displayed_folded()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_is_displayed_folded__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_process_internal(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_process_internal__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_processing_internal()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_is_processing_internal__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_physics_process_internal(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_physics_process_internal__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_physics_processing_internal()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_is_physics_processing_internal__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_physics_interpolation_mode(long mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, mode);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_physics_interpolation_mode__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_physics_interpolation_mode()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_physics_interpolation_mode__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool is_physics_interpolated()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_is_physics_interpolated__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool is_physics_interpolated_and_enabled()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_is_physics_interpolated_and_enabled__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void reset_physics_interpolation()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_reset_physics_interpolation__r0);
            Helpers.WaitForCompletion();
        }

        public void set_auto_translate_mode(long mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, mode);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_auto_translate_mode__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_auto_translate_mode()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_auto_translate_mode__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool can_auto_translate()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_can_auto_translate__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_translation_domain_inherited()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_translation_domain_inherited__r0);
            Helpers.WaitForCompletion();
        }

        public ulong get_window()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_window__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong get_last_exclusive_window()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_last_exclusive_window__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong get_tree()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_tree__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong create_tween()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_create_tween__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong duplicate(long flags)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, flags);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_duplicate__2__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void replace_by(ulong node, bool keep_groups)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, node);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, keep_groups ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_replace_by__24__1__r0);
            Helpers.WaitForCompletion();
        }

        public void set_scene_instance_load_placeholder(bool load_placeholder)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, load_placeholder ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_scene_instance_load_placeholder__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool get_scene_instance_load_placeholder()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_scene_instance_load_placeholder__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_editable_instance(ulong node, bool is_editable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, node);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, is_editable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_editable_instance__24__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_editable_instance(ulong node)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, node);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_is_editable_instance__24__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public ulong get_viewport()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_viewport__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void queue_free()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_queue_free__r0);
            Helpers.WaitForCompletion();
        }

        public void request_ready()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_request_ready__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_node_ready()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_is_node_ready__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_multiplayer_authority(long id, bool recursive)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, id);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, recursive ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_multiplayer_authority__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public long get_multiplayer_authority()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_multiplayer_authority__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool is_multiplayer_authority()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_is_multiplayer_authority__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public ulong get_multiplayer()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_multiplayer__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void rpc_config(string method, object config)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, config);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_rpc_config__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get_node_rpc_config()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_node_rpc_config__r0);
            Helpers.WaitForCompletion();
        }

        public void set_editor_description(string editor_description)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, editor_description);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_editor_description__4__r0);
            Helpers.WaitForCompletion();
        }

        public string get_editor_description()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_editor_description__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void set_unique_name_in_owner(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_unique_name_in_owner__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_unique_name_in_owner()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_is_unique_name_in_owner__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public string atr(string message, string context)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, message);
            Helpers.WriteStringName(Commands.CMD_DATA + 1036, context);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_atr__4__21__r4);
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
            Helpers.SendCommand(Commands.CMD_ScrollContainer_atr_n__4__21__2__21__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void _set_property_pinned(string property, bool pinned)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, property);
            Helpers.WriteInt32(Commands.CMD_DATA + 1036, pinned ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__set_property_pinned__4__1__r0);
            Helpers.WaitForCompletion();
        }

        public long rpc(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_rpc__21__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long rpc_id(long peer_id, string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, peer_id);
            Helpers.WriteStringName(Commands.CMD_DATA + 16, method);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_rpc_id__2__21__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void update_configuration_warnings()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_update_configuration_warnings__r0);
            Helpers.WaitForCompletion();
        }

        public void call_deferred_thread_group(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_call_deferred_thread_group__21__r0);
            Helpers.WaitForCompletion();
        }

        public void set_deferred_thread_group(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_deferred_thread_group__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void notify_deferred_thread_group(long what)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, what);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_notify_deferred_thread_group__2__r0);
            Helpers.WaitForCompletion();
        }

        public void call_thread_safe(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_call_thread_safe__21__r0);
            Helpers.WaitForCompletion();
        }

        public void set_thread_safe(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_thread_safe__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void notify_thread_safe(long what)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, what);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_notify_thread_safe__2__r0);
            Helpers.WaitForCompletion();
        }

        public void free()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_free__r0);
            Helpers.WaitForCompletion();
        }

        public void _init()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__init__r0);
            Helpers.WaitForCompletion();
        }

        public string _to_string()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__to_string__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void _notification(long what)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, what);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__notification__2__r0);
            Helpers.WaitForCompletion();
        }

        public bool _set(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__set__21__0__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _get(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__get__21__r0);
            Helpers.WaitForCompletion();
        }

        public object _get_property_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__get_property_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void _validate_property(object property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDictionary(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__validate_property__27__r0);
            Helpers.WaitForCompletion();
        }

        public bool _property_can_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__property_can_revert__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _property_get_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__property_get_revert__21__r0);
            Helpers.WaitForCompletion();
        }

        public bool _iter_init(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteArray(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__iter_init__28__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool _iter_next(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteArray(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__iter_next__28__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _iter_get(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVariant(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_ScrollContainer__iter_get__0__r0);
            Helpers.WaitForCompletion();
        }

        public string get_class()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_class__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public bool is_class(string class_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, class_);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_is_class__4__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get__21__r0);
            Helpers.WaitForCompletion();
        }

        public void set_indexed(string property_path, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, property_path);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_indexed__22__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get_indexed(string property_path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, property_path);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_indexed__22__r0);
            Helpers.WaitForCompletion();
        }

        public object get_property_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_property_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_method_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_method_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public bool property_can_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_property_can_revert__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void property_get_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_property_get_revert__21__r0);
            Helpers.WaitForCompletion();
        }

        public void notification(long what, bool reversed)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, what);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, reversed ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_notification__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public string to_string()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_to_string__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public ulong get_instance_id()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_instance_id__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_script(object script)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVariant(Commands.CMD_DATA + 8, script);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_script__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get_script()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_script__r0);
            Helpers.WaitForCompletion();
        }

        public void set_meta(string name, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_meta__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void remove_meta(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_remove_meta__21__r0);
            Helpers.WaitForCompletion();
        }

        public void get_meta(string name, object default_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, default_);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_meta__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_meta(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_has_meta__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public object get_meta_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_meta_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void add_user_signal(string signal, object arguments)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, signal);
            Helpers.WriteArray(Commands.CMD_DATA + 1036, arguments);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_add_user_signal__4__28__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_user_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_has_user_signal__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void remove_user_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_remove_user_signal__21__r0);
            Helpers.WaitForCompletion();
        }

        public long emit_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_emit_signal__21__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void call(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_call__21__r0);
            Helpers.WaitForCompletion();
        }

        public void call_deferred(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_call_deferred__21__r0);
            Helpers.WaitForCompletion();
        }

        public void set_deferred(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_deferred__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void callv(string method, object arg_array)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.WriteArray(Commands.CMD_DATA + 1036, arg_array);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_callv__21__28__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_method(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_has_method__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public long get_method_argument_count(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_method_argument_count__21__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool has_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_has_signal__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public object get_signal_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_signal_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_signal_connection_list(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_signal_connection_list__21__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_incoming_connections()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_incoming_connections__r28);
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
            Helpers.SendCommand(Commands.CMD_ScrollContainer_connect__21__25__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void disconnect(string signal, object callable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.WriteCallable(Commands.CMD_DATA + 1036, callable);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_disconnect__21__25__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_connected(string signal, object callable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.WriteCallable(Commands.CMD_DATA + 1036, callable);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_is_connected__21__25__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool has_connections(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_has_connections__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_block_signals(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_block_signals__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_blocking_signals()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_is_blocking_signals__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void notify_property_list_changed()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_notify_property_list_changed__r0);
            Helpers.WaitForCompletion();
        }

        public void set_message_translation(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_message_translation__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool can_translate_messages()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_can_translate_messages__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public string tr(string message, string context)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, message);
            Helpers.WriteStringName(Commands.CMD_DATA + 1036, context);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_tr__21__21__r4);
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
            Helpers.SendCommand(Commands.CMD_ScrollContainer_tr_n__21__21__2__21__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public string get_translation_domain()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_get_translation_domain__r21);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadStringName(Commands.CMD_DATA);
            return result;
        }

        public void set_translation_domain(string domain)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, domain);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_set_translation_domain__21__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_queued_for_deletion()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_is_queued_for_deletion__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void cancel_free()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScrollContainer_cancel_free__r0);
            Helpers.WaitForCompletion();
        }

    }
}
