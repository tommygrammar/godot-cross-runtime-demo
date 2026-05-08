using System;

namespace GodotWeb
{
    public class TreeItem : GodotObject
    {
        public TreeItem(ulong id) : base(id) { }

        public void set_cell_mode(long column, long mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, mode);
            Helpers.SendCommand(Commands.CMD_TreeItem_set_cell_mode__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_cell_mode(long column)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_cell_mode__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_auto_translate_mode(long column, long mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, mode);
            Helpers.SendCommand(Commands.CMD_TreeItem_set_auto_translate_mode__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_auto_translate_mode(long column)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_auto_translate_mode__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_edit_multiline(long column, bool multiline)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, multiline ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_TreeItem_set_edit_multiline__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_edit_multiline(long column)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.SendCommand(Commands.CMD_TreeItem_is_edit_multiline__2__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_checked(long column, bool checked_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, checked_ ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_TreeItem_set_checked__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public void set_indeterminate(long column, bool indeterminate)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, indeterminate ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_TreeItem_set_indeterminate__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_checked(long column)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.SendCommand(Commands.CMD_TreeItem_is_checked__2__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool is_indeterminate(long column)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.SendCommand(Commands.CMD_TreeItem_is_indeterminate__2__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void propagate_check(long column, bool emit_signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, emit_signal ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_TreeItem_propagate_check__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public void set_text(long column, string text)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.WriteString(Commands.CMD_DATA + 16, text);
            Helpers.SendCommand(Commands.CMD_TreeItem_set_text__2__4__r0);
            Helpers.WaitForCompletion();
        }

        public string get_text(long column)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_text__2__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void set_description(long column, string description)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.WriteString(Commands.CMD_DATA + 16, description);
            Helpers.SendCommand(Commands.CMD_TreeItem_set_description__2__4__r0);
            Helpers.WaitForCompletion();
        }

        public string get_description(long column)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_description__2__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void set_text_direction(long column, long direction)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, direction);
            Helpers.SendCommand(Commands.CMD_TreeItem_set_text_direction__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_text_direction(long column)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_text_direction__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_autowrap_mode(long column, long autowrap_mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, autowrap_mode);
            Helpers.SendCommand(Commands.CMD_TreeItem_set_autowrap_mode__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_autowrap_mode(long column)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_autowrap_mode__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_text_overrun_behavior(long column, long overrun_behavior)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, overrun_behavior);
            Helpers.SendCommand(Commands.CMD_TreeItem_set_text_overrun_behavior__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_text_overrun_behavior(long column)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_text_overrun_behavior__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_structured_text_bidi_override(long column, long parser)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, parser);
            Helpers.SendCommand(Commands.CMD_TreeItem_set_structured_text_bidi_override__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_structured_text_bidi_override(long column)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_structured_text_bidi_override__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_structured_text_bidi_override_options(long column, object args)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.WriteArray(Commands.CMD_DATA + 16, args);
            Helpers.SendCommand(Commands.CMD_TreeItem_set_structured_text_bidi_override_options__2__28__r0);
            Helpers.WaitForCompletion();
        }

        public object get_structured_text_bidi_override_options(long column)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_structured_text_bidi_override_options__2__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void set_language(long column, string language)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.WriteString(Commands.CMD_DATA + 16, language);
            Helpers.SendCommand(Commands.CMD_TreeItem_set_language__2__4__r0);
            Helpers.WaitForCompletion();
        }

        public string get_language(long column)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_language__2__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void set_suffix(long column, string text)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.WriteString(Commands.CMD_DATA + 16, text);
            Helpers.SendCommand(Commands.CMD_TreeItem_set_suffix__2__4__r0);
            Helpers.WaitForCompletion();
        }

        public string get_suffix(long column)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_suffix__2__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void set_icon(long column, ulong texture)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.WriteUInt64(Commands.CMD_DATA + 16, texture);
            Helpers.SendCommand(Commands.CMD_TreeItem_set_icon__2__24__r0);
            Helpers.WaitForCompletion();
        }

        public ulong get_icon(long column)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_icon__2__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_icon_overlay(long column, ulong texture)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.WriteUInt64(Commands.CMD_DATA + 16, texture);
            Helpers.SendCommand(Commands.CMD_TreeItem_set_icon_overlay__2__24__r0);
            Helpers.WaitForCompletion();
        }

        public ulong get_icon_overlay(long column)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_icon_overlay__2__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_icon_region(long column, Rect2 region)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.WriteRect2(Commands.CMD_DATA + 16, region);
            Helpers.SendCommand(Commands.CMD_TreeItem_set_icon_region__2__7__r0);
            Helpers.WaitForCompletion();
        }

        public Rect2 get_icon_region(long column)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_icon_region__2__r7);
            Helpers.WaitForCompletion();
            Rect2 result = Helpers.ReadRect2(Commands.CMD_DATA);
            return result;
        }

        public void set_icon_max_width(long column, long width)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, width);
            Helpers.SendCommand(Commands.CMD_TreeItem_set_icon_max_width__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_icon_max_width(long column)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_icon_max_width__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_icon_modulate(long column, Color modulate)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.WriteColor(Commands.CMD_DATA + 16, modulate);
            Helpers.SendCommand(Commands.CMD_TreeItem_set_icon_modulate__2__20__r0);
            Helpers.WaitForCompletion();
        }

        public Color get_icon_modulate(long column)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_icon_modulate__2__r20);
            Helpers.WaitForCompletion();
            Color result = Helpers.ReadColor(Commands.CMD_DATA);
            return result;
        }

        public void set_range(long column, double value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, value);
            Helpers.SendCommand(Commands.CMD_TreeItem_set_range__2__3__r0);
            Helpers.WaitForCompletion();
        }

        public double get_range(long column)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_range__2__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void set_range_config(long column, double min, double max, double step, bool expr)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, min);
            Helpers.WriteDouble(Commands.CMD_DATA + 24, max);
            Helpers.WriteDouble(Commands.CMD_DATA + 32, step);
            Helpers.WriteInt32(Commands.CMD_DATA + 40, expr ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_TreeItem_set_range_config__2__3__3__3__1__r0);
            Helpers.WaitForCompletion();
        }

        public object get_range_config(long column)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_range_config__2__r27);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadDictionary(Commands.CMD_DATA);
            return result;
        }

        public void set_metadata(long column, object meta)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.WriteVariant(Commands.CMD_DATA + 16, meta);
            Helpers.SendCommand(Commands.CMD_TreeItem_set_metadata__2__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get_metadata(long column)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_metadata__2__r0);
            Helpers.WaitForCompletion();
        }

        public void set_custom_draw(long column, ulong object_, string callback)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.WriteUInt64(Commands.CMD_DATA + 16, object_);
            Helpers.WriteStringName(Commands.CMD_DATA + 24, callback);
            Helpers.SendCommand(Commands.CMD_TreeItem_set_custom_draw__2__24__21__r0);
            Helpers.WaitForCompletion();
        }

        public void set_custom_draw_callback(long column, object callback)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.WriteCallable(Commands.CMD_DATA + 16, callback);
            Helpers.SendCommand(Commands.CMD_TreeItem_set_custom_draw_callback__2__25__r0);
            Helpers.WaitForCompletion();
        }

        public object get_custom_draw_callback(long column)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_custom_draw_callback__2__r25);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadCallable(Commands.CMD_DATA);
            return result;
        }

        public void set_custom_stylebox(long column, ulong stylebox)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.WriteUInt64(Commands.CMD_DATA + 16, stylebox);
            Helpers.SendCommand(Commands.CMD_TreeItem_set_custom_stylebox__2__24__r0);
            Helpers.WaitForCompletion();
        }

        public ulong get_custom_stylebox(long column)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_custom_stylebox__2__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_collapsed(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_TreeItem_set_collapsed__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_collapsed()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TreeItem_is_collapsed__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_collapsed_recursive(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_TreeItem_set_collapsed_recursive__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_any_collapsed(bool only_visible)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, only_visible ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_TreeItem_is_any_collapsed__1__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_visible(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_TreeItem_set_visible__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_visible()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TreeItem_is_visible__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool is_visible_in_tree()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TreeItem_is_visible_in_tree__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void uncollapse_tree()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TreeItem_uncollapse_tree__r0);
            Helpers.WaitForCompletion();
        }

        public void set_custom_minimum_height(long height)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, height);
            Helpers.SendCommand(Commands.CMD_TreeItem_set_custom_minimum_height__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_custom_minimum_height()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_custom_minimum_height__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_selectable(long column, bool selectable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, selectable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_TreeItem_set_selectable__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_selectable(long column)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.SendCommand(Commands.CMD_TreeItem_is_selectable__2__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool is_selected(long column)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.SendCommand(Commands.CMD_TreeItem_is_selected__2__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void select(long column)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.SendCommand(Commands.CMD_TreeItem_select__2__r0);
            Helpers.WaitForCompletion();
        }

        public void deselect(long column)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.SendCommand(Commands.CMD_TreeItem_deselect__2__r0);
            Helpers.WaitForCompletion();
        }

        public void set_editable(long column, bool enabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_TreeItem_set_editable__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_editable(long column)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.SendCommand(Commands.CMD_TreeItem_is_editable__2__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_custom_color(long column, Color color)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.WriteColor(Commands.CMD_DATA + 16, color);
            Helpers.SendCommand(Commands.CMD_TreeItem_set_custom_color__2__20__r0);
            Helpers.WaitForCompletion();
        }

        public Color get_custom_color(long column)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_custom_color__2__r20);
            Helpers.WaitForCompletion();
            Color result = Helpers.ReadColor(Commands.CMD_DATA);
            return result;
        }

        public void clear_custom_color(long column)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.SendCommand(Commands.CMD_TreeItem_clear_custom_color__2__r0);
            Helpers.WaitForCompletion();
        }

        public void set_custom_font(long column, ulong font)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.WriteUInt64(Commands.CMD_DATA + 16, font);
            Helpers.SendCommand(Commands.CMD_TreeItem_set_custom_font__2__24__r0);
            Helpers.WaitForCompletion();
        }

        public ulong get_custom_font(long column)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_custom_font__2__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_custom_font_size(long column, long font_size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, font_size);
            Helpers.SendCommand(Commands.CMD_TreeItem_set_custom_font_size__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_custom_font_size(long column)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_custom_font_size__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_custom_bg_color(long column, Color color, bool just_outline)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.WriteColor(Commands.CMD_DATA + 16, color);
            Helpers.WriteInt32(Commands.CMD_DATA + 32, just_outline ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_TreeItem_set_custom_bg_color__2__20__1__r0);
            Helpers.WaitForCompletion();
        }

        public void clear_custom_bg_color(long column)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.SendCommand(Commands.CMD_TreeItem_clear_custom_bg_color__2__r0);
            Helpers.WaitForCompletion();
        }

        public Color get_custom_bg_color(long column)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_custom_bg_color__2__r20);
            Helpers.WaitForCompletion();
            Color result = Helpers.ReadColor(Commands.CMD_DATA);
            return result;
        }

        public void set_custom_as_button(long column, bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_TreeItem_set_custom_as_button__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_custom_set_as_button(long column)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.SendCommand(Commands.CMD_TreeItem_is_custom_set_as_button__2__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void clear_buttons()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TreeItem_clear_buttons__r0);
            Helpers.WaitForCompletion();
        }

        public void add_button(long column, ulong button, long id, bool disabled, string tooltip_text, string description)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.WriteUInt64(Commands.CMD_DATA + 16, button);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, id);
            Helpers.WriteInt32(Commands.CMD_DATA + 32, disabled ? 1 : 0);
            Helpers.WriteString(Commands.CMD_DATA + 36, tooltip_text);
            Helpers.WriteString(Commands.CMD_DATA + 1064, description);
            Helpers.SendCommand(Commands.CMD_TreeItem_add_button__2__24__2__1__4__4__r0);
            Helpers.WaitForCompletion();
        }

        public long get_button_count(long column)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_button_count__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public string get_button_tooltip_text(long column, long button_index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, button_index);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_button_tooltip_text__2__2__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public long get_button_id(long column, long button_index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, button_index);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_button_id__2__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long get_button_by_id(long column, long id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, id);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_button_by_id__2__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public Color get_button_color(long column, long id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, id);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_button_color__2__2__r20);
            Helpers.WaitForCompletion();
            Color result = Helpers.ReadColor(Commands.CMD_DATA);
            return result;
        }

        public ulong get_button(long column, long button_index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, button_index);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_button__2__2__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_button_tooltip_text(long column, long button_index, string tooltip)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, button_index);
            Helpers.WriteString(Commands.CMD_DATA + 24, tooltip);
            Helpers.SendCommand(Commands.CMD_TreeItem_set_button_tooltip_text__2__2__4__r0);
            Helpers.WaitForCompletion();
        }

        public void set_button(long column, long button_index, ulong button)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, button_index);
            Helpers.WriteUInt64(Commands.CMD_DATA + 24, button);
            Helpers.SendCommand(Commands.CMD_TreeItem_set_button__2__2__24__r0);
            Helpers.WaitForCompletion();
        }

        public void erase_button(long column, long button_index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, button_index);
            Helpers.SendCommand(Commands.CMD_TreeItem_erase_button__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public void set_button_description(long column, long button_index, string description)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, button_index);
            Helpers.WriteString(Commands.CMD_DATA + 24, description);
            Helpers.SendCommand(Commands.CMD_TreeItem_set_button_description__2__2__4__r0);
            Helpers.WaitForCompletion();
        }

        public void set_button_disabled(long column, long button_index, bool disabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, button_index);
            Helpers.WriteInt32(Commands.CMD_DATA + 24, disabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_TreeItem_set_button_disabled__2__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public void set_button_color(long column, long button_index, Color color)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, button_index);
            Helpers.WriteColor(Commands.CMD_DATA + 24, color);
            Helpers.SendCommand(Commands.CMD_TreeItem_set_button_color__2__2__20__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_button_disabled(long column, long button_index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, button_index);
            Helpers.SendCommand(Commands.CMD_TreeItem_is_button_disabled__2__2__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_tooltip_text(long column, string tooltip)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.WriteString(Commands.CMD_DATA + 16, tooltip);
            Helpers.SendCommand(Commands.CMD_TreeItem_set_tooltip_text__2__4__r0);
            Helpers.WaitForCompletion();
        }

        public string get_tooltip_text(long column)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_tooltip_text__2__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void set_text_alignment(long column, long text_alignment)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, text_alignment);
            Helpers.SendCommand(Commands.CMD_TreeItem_set_text_alignment__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_text_alignment(long column)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_text_alignment__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_expand_right(long column, bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_TreeItem_set_expand_right__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool get_expand_right(long column)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, column);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_expand_right__2__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_disable_folding(bool disable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, disable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_TreeItem_set_disable_folding__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_folding_disabled()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TreeItem_is_folding_disabled__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public ulong create_child(long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, index);
            Helpers.SendCommand(Commands.CMD_TreeItem_create_child__2__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void add_child(ulong child)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, child);
            Helpers.SendCommand(Commands.CMD_TreeItem_add_child__24__r0);
            Helpers.WaitForCompletion();
        }

        public void remove_child(ulong child)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, child);
            Helpers.SendCommand(Commands.CMD_TreeItem_remove_child__24__r0);
            Helpers.WaitForCompletion();
        }

        public ulong get_tree()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_tree__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong get_next()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_next__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong get_prev()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_prev__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong get_parent()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_parent__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong get_first_child()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_first_child__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong get_next_in_tree(bool wrap)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, wrap ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_next_in_tree__1__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong get_prev_in_tree(bool wrap)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, wrap ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_prev_in_tree__1__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong get_next_visible(bool wrap)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, wrap ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_next_visible__1__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong get_prev_visible(bool wrap)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, wrap ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_prev_visible__1__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong get_child(long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, index);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_child__2__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public long get_child_count()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_child_count__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public object get_children()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_children__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public long get_index()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_index__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void move_before(ulong item)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, item);
            Helpers.SendCommand(Commands.CMD_TreeItem_move_before__24__r0);
            Helpers.WaitForCompletion();
        }

        public void move_after(ulong item)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, item);
            Helpers.SendCommand(Commands.CMD_TreeItem_move_after__24__r0);
            Helpers.WaitForCompletion();
        }

        public void call_recursive(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_TreeItem_call_recursive__21__r0);
            Helpers.WaitForCompletion();
        }

        public void free()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TreeItem_free__r0);
            Helpers.WaitForCompletion();
        }

        public void _init()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TreeItem__init__r0);
            Helpers.WaitForCompletion();
        }

        public string _to_string()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TreeItem__to_string__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void _notification(long what)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, what);
            Helpers.SendCommand(Commands.CMD_TreeItem__notification__2__r0);
            Helpers.WaitForCompletion();
        }

        public bool _set(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_TreeItem__set__21__0__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _get(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_TreeItem__get__21__r0);
            Helpers.WaitForCompletion();
        }

        public object _get_property_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TreeItem__get_property_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void _validate_property(object property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDictionary(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_TreeItem__validate_property__27__r0);
            Helpers.WaitForCompletion();
        }

        public bool _property_can_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_TreeItem__property_can_revert__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _property_get_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_TreeItem__property_get_revert__21__r0);
            Helpers.WaitForCompletion();
        }

        public bool _iter_init(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteArray(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_TreeItem__iter_init__28__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool _iter_next(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteArray(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_TreeItem__iter_next__28__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _iter_get(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVariant(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_TreeItem__iter_get__0__r0);
            Helpers.WaitForCompletion();
        }

        public string get_class()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_class__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public bool is_class(string class_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, class_);
            Helpers.SendCommand(Commands.CMD_TreeItem_is_class__4__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_TreeItem_set__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_TreeItem_get__21__r0);
            Helpers.WaitForCompletion();
        }

        public void set_indexed(string property_path, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, property_path);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_TreeItem_set_indexed__22__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get_indexed(string property_path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, property_path);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_indexed__22__r0);
            Helpers.WaitForCompletion();
        }

        public object get_property_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_property_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_method_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_method_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public bool property_can_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_TreeItem_property_can_revert__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void property_get_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_TreeItem_property_get_revert__21__r0);
            Helpers.WaitForCompletion();
        }

        public void notification(long what, bool reversed)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, what);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, reversed ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_TreeItem_notification__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public string to_string()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TreeItem_to_string__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public ulong get_instance_id()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_instance_id__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_script(object script)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVariant(Commands.CMD_DATA + 8, script);
            Helpers.SendCommand(Commands.CMD_TreeItem_set_script__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get_script()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_script__r0);
            Helpers.WaitForCompletion();
        }

        public void set_meta(string name, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_TreeItem_set_meta__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void remove_meta(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_TreeItem_remove_meta__21__r0);
            Helpers.WaitForCompletion();
        }

        public void get_meta(string name, object default_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, default_);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_meta__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_meta(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_TreeItem_has_meta__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public object get_meta_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_meta_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void add_user_signal(string signal, object arguments)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, signal);
            Helpers.WriteArray(Commands.CMD_DATA + 1036, arguments);
            Helpers.SendCommand(Commands.CMD_TreeItem_add_user_signal__4__28__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_user_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_TreeItem_has_user_signal__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void remove_user_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_TreeItem_remove_user_signal__21__r0);
            Helpers.WaitForCompletion();
        }

        public long emit_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_TreeItem_emit_signal__21__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void call(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_TreeItem_call__21__r0);
            Helpers.WaitForCompletion();
        }

        public void call_deferred(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_TreeItem_call_deferred__21__r0);
            Helpers.WaitForCompletion();
        }

        public void set_deferred(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_TreeItem_set_deferred__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void callv(string method, object arg_array)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.WriteArray(Commands.CMD_DATA + 1036, arg_array);
            Helpers.SendCommand(Commands.CMD_TreeItem_callv__21__28__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_method(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_TreeItem_has_method__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public long get_method_argument_count(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_method_argument_count__21__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool has_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_TreeItem_has_signal__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public object get_signal_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_signal_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_signal_connection_list(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_signal_connection_list__21__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_incoming_connections()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_incoming_connections__r28);
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
            Helpers.SendCommand(Commands.CMD_TreeItem_connect__21__25__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void disconnect(string signal, object callable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.WriteCallable(Commands.CMD_DATA + 1036, callable);
            Helpers.SendCommand(Commands.CMD_TreeItem_disconnect__21__25__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_connected(string signal, object callable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.WriteCallable(Commands.CMD_DATA + 1036, callable);
            Helpers.SendCommand(Commands.CMD_TreeItem_is_connected__21__25__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool has_connections(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_TreeItem_has_connections__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_block_signals(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_TreeItem_set_block_signals__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_blocking_signals()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TreeItem_is_blocking_signals__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void notify_property_list_changed()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TreeItem_notify_property_list_changed__r0);
            Helpers.WaitForCompletion();
        }

        public void set_message_translation(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_TreeItem_set_message_translation__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool can_translate_messages()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TreeItem_can_translate_messages__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public string tr(string message, string context)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, message);
            Helpers.WriteStringName(Commands.CMD_DATA + 1036, context);
            Helpers.SendCommand(Commands.CMD_TreeItem_tr__21__21__r4);
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
            Helpers.SendCommand(Commands.CMD_TreeItem_tr_n__21__21__2__21__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public string get_translation_domain()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TreeItem_get_translation_domain__r21);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadStringName(Commands.CMD_DATA);
            return result;
        }

        public void set_translation_domain(string domain)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, domain);
            Helpers.SendCommand(Commands.CMD_TreeItem_set_translation_domain__21__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_queued_for_deletion()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TreeItem_is_queued_for_deletion__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void cancel_free()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TreeItem_cancel_free__r0);
            Helpers.WaitForCompletion();
        }

    }
}
