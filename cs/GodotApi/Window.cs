using System;

namespace GodotWeb
{
    public class Window : GodotObject
    {
        public Window(ulong id) : base(id) { }

        public Vector2 _get_contents_minimum_size()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window__get_contents_minimum_size__r5);
            Helpers.WaitForCompletion();
            Vector2 result = Helpers.ReadVector2(Commands.CMD_DATA);
            return result;
        }

        public void set_title(string title)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, title);
            Helpers.SendCommand(Commands.CMD_Window_set_title__4__r0);
            Helpers.WaitForCompletion();
        }

        public string get_title()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_title__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void set_initial_position(long initial_position)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, initial_position);
            Helpers.SendCommand(Commands.CMD_Window_set_initial_position__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_initial_position()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_initial_position__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_current_screen(long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, index);
            Helpers.SendCommand(Commands.CMD_Window_set_current_screen__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_current_screen()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_current_screen__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_position(Vector2i position)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2i(Commands.CMD_DATA + 8, position);
            Helpers.SendCommand(Commands.CMD_Window_set_position__6__r0);
            Helpers.WaitForCompletion();
        }

        public Vector2i get_position()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_position__r6);
            Helpers.WaitForCompletion();
            Vector2i result = Helpers.ReadVector2i(Commands.CMD_DATA);
            return result;
        }

        public void move_to_center()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_move_to_center__r0);
            Helpers.WaitForCompletion();
        }

        public void set_size(Vector2i size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2i(Commands.CMD_DATA + 8, size);
            Helpers.SendCommand(Commands.CMD_Window_set_size__6__r0);
            Helpers.WaitForCompletion();
        }

        public Vector2i get_size()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_size__r6);
            Helpers.WaitForCompletion();
            Vector2i result = Helpers.ReadVector2i(Commands.CMD_DATA);
            return result;
        }

        public void reset_size()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_reset_size__r0);
            Helpers.WaitForCompletion();
        }

        public Vector2i get_position_with_decorations()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_position_with_decorations__r6);
            Helpers.WaitForCompletion();
            Vector2i result = Helpers.ReadVector2i(Commands.CMD_DATA);
            return result;
        }

        public Vector2i get_size_with_decorations()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_size_with_decorations__r6);
            Helpers.WaitForCompletion();
            Vector2i result = Helpers.ReadVector2i(Commands.CMD_DATA);
            return result;
        }

        public void set_max_size(Vector2i max_size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2i(Commands.CMD_DATA + 8, max_size);
            Helpers.SendCommand(Commands.CMD_Window_set_max_size__6__r0);
            Helpers.WaitForCompletion();
        }

        public Vector2i get_max_size()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_max_size__r6);
            Helpers.WaitForCompletion();
            Vector2i result = Helpers.ReadVector2i(Commands.CMD_DATA);
            return result;
        }

        public void set_min_size(Vector2i min_size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2i(Commands.CMD_DATA + 8, min_size);
            Helpers.SendCommand(Commands.CMD_Window_set_min_size__6__r0);
            Helpers.WaitForCompletion();
        }

        public Vector2i get_min_size()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_min_size__r6);
            Helpers.WaitForCompletion();
            Vector2i result = Helpers.ReadVector2i(Commands.CMD_DATA);
            return result;
        }

        public void set_mode(long mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, mode);
            Helpers.SendCommand(Commands.CMD_Window_set_mode__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_mode()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_mode__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_flag(long flag, bool enabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, flag);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_set_flag__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool get_flag(long flag)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, flag);
            Helpers.SendCommand(Commands.CMD_Window_get_flag__2__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool is_maximize_allowed()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_is_maximize_allowed__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void request_attention()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_request_attention__r0);
            Helpers.WaitForCompletion();
        }

        public void move_to_foreground()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_move_to_foreground__r0);
            Helpers.WaitForCompletion();
        }

        public void set_visible(bool visible)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, visible ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_set_visible__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_visible()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_is_visible__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void hide()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_hide__r0);
            Helpers.WaitForCompletion();
        }

        public void show()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_show__r0);
            Helpers.WaitForCompletion();
        }

        public void set_transient(bool transient)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, transient ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_set_transient__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_transient()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_is_transient__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_transient_to_focused(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_set_transient_to_focused__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_transient_to_focused()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_is_transient_to_focused__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_exclusive(bool exclusive)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, exclusive ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_set_exclusive__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_exclusive()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_is_exclusive__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_unparent_when_invisible(bool unparent)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, unparent ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_set_unparent_when_invisible__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool can_draw()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_can_draw__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool has_focus()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_has_focus__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void grab_focus()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_grab_focus__r0);
            Helpers.WaitForCompletion();
        }

        public void start_drag()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_start_drag__r0);
            Helpers.WaitForCompletion();
        }

        public void start_resize(long edge)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, edge);
            Helpers.SendCommand(Commands.CMD_Window_start_resize__2__r0);
            Helpers.WaitForCompletion();
        }

        public void set_ime_active(bool active)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, active ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_set_ime_active__1__r0);
            Helpers.WaitForCompletion();
        }

        public void set_ime_position(Vector2i position)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2i(Commands.CMD_DATA + 8, position);
            Helpers.SendCommand(Commands.CMD_Window_set_ime_position__6__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_embedded()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_is_embedded__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public Vector2 get_contents_minimum_size()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_contents_minimum_size__r5);
            Helpers.WaitForCompletion();
            Vector2 result = Helpers.ReadVector2(Commands.CMD_DATA);
            return result;
        }

        public void set_force_native(bool force_native)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, force_native ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_set_force_native__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool get_force_native()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_force_native__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_content_scale_size(Vector2i size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2i(Commands.CMD_DATA + 8, size);
            Helpers.SendCommand(Commands.CMD_Window_set_content_scale_size__6__r0);
            Helpers.WaitForCompletion();
        }

        public Vector2i get_content_scale_size()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_content_scale_size__r6);
            Helpers.WaitForCompletion();
            Vector2i result = Helpers.ReadVector2i(Commands.CMD_DATA);
            return result;
        }

        public void set_content_scale_mode(long mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, mode);
            Helpers.SendCommand(Commands.CMD_Window_set_content_scale_mode__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_content_scale_mode()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_content_scale_mode__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_content_scale_aspect(long aspect)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, aspect);
            Helpers.SendCommand(Commands.CMD_Window_set_content_scale_aspect__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_content_scale_aspect()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_content_scale_aspect__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_content_scale_stretch(long stretch)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, stretch);
            Helpers.SendCommand(Commands.CMD_Window_set_content_scale_stretch__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_content_scale_stretch()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_content_scale_stretch__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_nonclient_area(Rect2i area)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRect2i(Commands.CMD_DATA + 8, area);
            Helpers.SendCommand(Commands.CMD_Window_set_nonclient_area__8__r0);
            Helpers.WaitForCompletion();
        }

        public Rect2i get_nonclient_area()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_nonclient_area__r8);
            Helpers.WaitForCompletion();
            Rect2i result = Helpers.ReadRect2i(Commands.CMD_DATA);
            return result;
        }

        public void set_keep_title_visible(bool title_visible)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, title_visible ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_set_keep_title_visible__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool get_keep_title_visible()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_keep_title_visible__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_content_scale_factor(double factor)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDouble(Commands.CMD_DATA + 8, factor);
            Helpers.SendCommand(Commands.CMD_Window_set_content_scale_factor__3__r0);
            Helpers.WaitForCompletion();
        }

        public double get_content_scale_factor()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_content_scale_factor__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void set_mouse_passthrough_polygon(Vector2[] polygon)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WritePackedVector2Array(Commands.CMD_DATA + 8, polygon);
            Helpers.SendCommand(Commands.CMD_Window_set_mouse_passthrough_polygon__35__r0);
            Helpers.WaitForCompletion();
        }

        public Vector2[] get_mouse_passthrough_polygon()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_mouse_passthrough_polygon__r35);
            Helpers.WaitForCompletion();
            Vector2[] result = Helpers.ReadPackedVector2Array(Commands.CMD_DATA);
            return result;
        }

        public void set_wrap_controls(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_set_wrap_controls__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_wrapping_controls()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_is_wrapping_controls__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void child_controls_changed()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_child_controls_changed__r0);
            Helpers.WaitForCompletion();
        }

        public void set_theme(ulong theme)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, theme);
            Helpers.SendCommand(Commands.CMD_Window_set_theme__24__r0);
            Helpers.WaitForCompletion();
        }

        public ulong get_theme()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_theme__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_theme_type_variation(string theme_type)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, theme_type);
            Helpers.SendCommand(Commands.CMD_Window_set_theme_type_variation__21__r0);
            Helpers.WaitForCompletion();
        }

        public string get_theme_type_variation()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_theme_type_variation__r21);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadStringName(Commands.CMD_DATA);
            return result;
        }

        public void begin_bulk_theme_override()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_begin_bulk_theme_override__r0);
            Helpers.WaitForCompletion();
        }

        public void end_bulk_theme_override()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_end_bulk_theme_override__r0);
            Helpers.WaitForCompletion();
        }

        public void add_theme_icon_override(string name, ulong texture)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteUInt64(Commands.CMD_DATA + 1036, texture);
            Helpers.SendCommand(Commands.CMD_Window_add_theme_icon_override__21__24__r0);
            Helpers.WaitForCompletion();
        }

        public void add_theme_stylebox_override(string name, ulong stylebox)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteUInt64(Commands.CMD_DATA + 1036, stylebox);
            Helpers.SendCommand(Commands.CMD_Window_add_theme_stylebox_override__21__24__r0);
            Helpers.WaitForCompletion();
        }

        public void add_theme_font_override(string name, ulong font)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteUInt64(Commands.CMD_DATA + 1036, font);
            Helpers.SendCommand(Commands.CMD_Window_add_theme_font_override__21__24__r0);
            Helpers.WaitForCompletion();
        }

        public void add_theme_font_size_override(string name, long font_size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteInt64(Commands.CMD_DATA + 1036, font_size);
            Helpers.SendCommand(Commands.CMD_Window_add_theme_font_size_override__21__2__r0);
            Helpers.WaitForCompletion();
        }

        public void add_theme_color_override(string name, Color color)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteColor(Commands.CMD_DATA + 1036, color);
            Helpers.SendCommand(Commands.CMD_Window_add_theme_color_override__21__20__r0);
            Helpers.WaitForCompletion();
        }

        public void add_theme_constant_override(string name, long constant)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteInt64(Commands.CMD_DATA + 1036, constant);
            Helpers.SendCommand(Commands.CMD_Window_add_theme_constant_override__21__2__r0);
            Helpers.WaitForCompletion();
        }

        public void remove_theme_icon_override(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_Window_remove_theme_icon_override__21__r0);
            Helpers.WaitForCompletion();
        }

        public void remove_theme_stylebox_override(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_Window_remove_theme_stylebox_override__21__r0);
            Helpers.WaitForCompletion();
        }

        public void remove_theme_font_override(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_Window_remove_theme_font_override__21__r0);
            Helpers.WaitForCompletion();
        }

        public void remove_theme_font_size_override(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_Window_remove_theme_font_size_override__21__r0);
            Helpers.WaitForCompletion();
        }

        public void remove_theme_color_override(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_Window_remove_theme_color_override__21__r0);
            Helpers.WaitForCompletion();
        }

        public void remove_theme_constant_override(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_Window_remove_theme_constant_override__21__r0);
            Helpers.WaitForCompletion();
        }

        public ulong get_theme_icon(string name, string theme_type)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteStringName(Commands.CMD_DATA + 1036, theme_type);
            Helpers.SendCommand(Commands.CMD_Window_get_theme_icon__21__21__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong get_theme_stylebox(string name, string theme_type)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteStringName(Commands.CMD_DATA + 1036, theme_type);
            Helpers.SendCommand(Commands.CMD_Window_get_theme_stylebox__21__21__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong get_theme_font(string name, string theme_type)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteStringName(Commands.CMD_DATA + 1036, theme_type);
            Helpers.SendCommand(Commands.CMD_Window_get_theme_font__21__21__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public long get_theme_font_size(string name, string theme_type)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteStringName(Commands.CMD_DATA + 1036, theme_type);
            Helpers.SendCommand(Commands.CMD_Window_get_theme_font_size__21__21__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public Color get_theme_color(string name, string theme_type)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteStringName(Commands.CMD_DATA + 1036, theme_type);
            Helpers.SendCommand(Commands.CMD_Window_get_theme_color__21__21__r20);
            Helpers.WaitForCompletion();
            Color result = Helpers.ReadColor(Commands.CMD_DATA);
            return result;
        }

        public long get_theme_constant(string name, string theme_type)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteStringName(Commands.CMD_DATA + 1036, theme_type);
            Helpers.SendCommand(Commands.CMD_Window_get_theme_constant__21__21__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool has_theme_icon_override(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_Window_has_theme_icon_override__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool has_theme_stylebox_override(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_Window_has_theme_stylebox_override__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool has_theme_font_override(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_Window_has_theme_font_override__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool has_theme_font_size_override(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_Window_has_theme_font_size_override__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool has_theme_color_override(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_Window_has_theme_color_override__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool has_theme_constant_override(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_Window_has_theme_constant_override__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool has_theme_icon(string name, string theme_type)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteStringName(Commands.CMD_DATA + 1036, theme_type);
            Helpers.SendCommand(Commands.CMD_Window_has_theme_icon__21__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool has_theme_stylebox(string name, string theme_type)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteStringName(Commands.CMD_DATA + 1036, theme_type);
            Helpers.SendCommand(Commands.CMD_Window_has_theme_stylebox__21__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool has_theme_font(string name, string theme_type)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteStringName(Commands.CMD_DATA + 1036, theme_type);
            Helpers.SendCommand(Commands.CMD_Window_has_theme_font__21__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool has_theme_font_size(string name, string theme_type)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteStringName(Commands.CMD_DATA + 1036, theme_type);
            Helpers.SendCommand(Commands.CMD_Window_has_theme_font_size__21__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool has_theme_color(string name, string theme_type)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteStringName(Commands.CMD_DATA + 1036, theme_type);
            Helpers.SendCommand(Commands.CMD_Window_has_theme_color__21__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool has_theme_constant(string name, string theme_type)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteStringName(Commands.CMD_DATA + 1036, theme_type);
            Helpers.SendCommand(Commands.CMD_Window_has_theme_constant__21__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public double get_theme_default_base_scale()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_theme_default_base_scale__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public ulong get_theme_default_font()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_theme_default_font__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public long get_theme_default_font_size()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_theme_default_font_size__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long get_window_id()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_window_id__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_accessibility_name(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_Window_set_accessibility_name__4__r0);
            Helpers.WaitForCompletion();
        }

        public string get_accessibility_name()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_accessibility_name__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void set_accessibility_description(string description)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, description);
            Helpers.SendCommand(Commands.CMD_Window_set_accessibility_description__4__r0);
            Helpers.WaitForCompletion();
        }

        public string get_accessibility_description()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_accessibility_description__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public ulong get_focused_window()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_focused_window__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_layout_direction(long direction)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, direction);
            Helpers.SendCommand(Commands.CMD_Window_set_layout_direction__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_layout_direction()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_layout_direction__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool is_layout_rtl()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_is_layout_rtl__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_auto_translate(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_set_auto_translate__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_auto_translating()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_is_auto_translating__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_use_font_oversampling(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_set_use_font_oversampling__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_using_font_oversampling()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_is_using_font_oversampling__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void popup(Rect2i rect)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRect2i(Commands.CMD_DATA + 8, rect);
            Helpers.SendCommand(Commands.CMD_Window_popup__8__r0);
            Helpers.WaitForCompletion();
        }

        public void popup_on_parent(Rect2i parent_rect)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRect2i(Commands.CMD_DATA + 8, parent_rect);
            Helpers.SendCommand(Commands.CMD_Window_popup_on_parent__8__r0);
            Helpers.WaitForCompletion();
        }

        public void popup_centered(Vector2i minsize)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2i(Commands.CMD_DATA + 8, minsize);
            Helpers.SendCommand(Commands.CMD_Window_popup_centered__6__r0);
            Helpers.WaitForCompletion();
        }

        public void popup_centered_ratio(double ratio)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDouble(Commands.CMD_DATA + 8, ratio);
            Helpers.SendCommand(Commands.CMD_Window_popup_centered_ratio__3__r0);
            Helpers.WaitForCompletion();
        }

        public void popup_centered_clamped(Vector2i minsize, double fallback_ratio)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2i(Commands.CMD_DATA + 8, minsize);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, fallback_ratio);
            Helpers.SendCommand(Commands.CMD_Window_popup_centered_clamped__6__3__r0);
            Helpers.WaitForCompletion();
        }

        public void popup_exclusive(ulong from_node, Rect2i rect)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, from_node);
            Helpers.WriteRect2i(Commands.CMD_DATA + 16, rect);
            Helpers.SendCommand(Commands.CMD_Window_popup_exclusive__24__8__r0);
            Helpers.WaitForCompletion();
        }

        public void popup_exclusive_on_parent(ulong from_node, Rect2i parent_rect)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, from_node);
            Helpers.WriteRect2i(Commands.CMD_DATA + 16, parent_rect);
            Helpers.SendCommand(Commands.CMD_Window_popup_exclusive_on_parent__24__8__r0);
            Helpers.WaitForCompletion();
        }

        public void popup_exclusive_centered(ulong from_node, Vector2i minsize)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, from_node);
            Helpers.WriteVector2i(Commands.CMD_DATA + 16, minsize);
            Helpers.SendCommand(Commands.CMD_Window_popup_exclusive_centered__24__6__r0);
            Helpers.WaitForCompletion();
        }

        public void popup_exclusive_centered_ratio(ulong from_node, double ratio)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, from_node);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, ratio);
            Helpers.SendCommand(Commands.CMD_Window_popup_exclusive_centered_ratio__24__3__r0);
            Helpers.WaitForCompletion();
        }

        public void popup_exclusive_centered_clamped(ulong from_node, Vector2i minsize, double fallback_ratio)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, from_node);
            Helpers.WriteVector2i(Commands.CMD_DATA + 16, minsize);
            Helpers.WriteDouble(Commands.CMD_DATA + 24, fallback_ratio);
            Helpers.SendCommand(Commands.CMD_Window_popup_exclusive_centered_clamped__24__6__3__r0);
            Helpers.WaitForCompletion();
        }

        public void set_world_2d(ulong world_2d)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, world_2d);
            Helpers.SendCommand(Commands.CMD_Window_set_world_2d__24__r0);
            Helpers.WaitForCompletion();
        }

        public ulong get_world_2d()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_world_2d__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong find_world_2d()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_find_world_2d__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_canvas_transform(Transform2D xform)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteTransform2D(Commands.CMD_DATA + 8, xform);
            Helpers.SendCommand(Commands.CMD_Window_set_canvas_transform__11__r0);
            Helpers.WaitForCompletion();
        }

        public Transform2D get_canvas_transform()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_canvas_transform__r11);
            Helpers.WaitForCompletion();
            Transform2D result = Helpers.ReadTransform2D(Commands.CMD_DATA);
            return result;
        }

        public void set_global_canvas_transform(Transform2D xform)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteTransform2D(Commands.CMD_DATA + 8, xform);
            Helpers.SendCommand(Commands.CMD_Window_set_global_canvas_transform__11__r0);
            Helpers.WaitForCompletion();
        }

        public Transform2D get_global_canvas_transform()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_global_canvas_transform__r11);
            Helpers.WaitForCompletion();
            Transform2D result = Helpers.ReadTransform2D(Commands.CMD_DATA);
            return result;
        }

        public Transform2D get_stretch_transform()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_stretch_transform__r11);
            Helpers.WaitForCompletion();
            Transform2D result = Helpers.ReadTransform2D(Commands.CMD_DATA);
            return result;
        }

        public Transform2D get_final_transform()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_final_transform__r11);
            Helpers.WaitForCompletion();
            Transform2D result = Helpers.ReadTransform2D(Commands.CMD_DATA);
            return result;
        }

        public Transform2D get_screen_transform()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_screen_transform__r11);
            Helpers.WaitForCompletion();
            Transform2D result = Helpers.ReadTransform2D(Commands.CMD_DATA);
            return result;
        }

        public Rect2 get_visible_rect()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_visible_rect__r7);
            Helpers.WaitForCompletion();
            Rect2 result = Helpers.ReadRect2(Commands.CMD_DATA);
            return result;
        }

        public void set_transparent_background(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_set_transparent_background__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_transparent_background()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_has_transparent_background__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_use_hdr_2d(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_set_use_hdr_2d__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_using_hdr_2d()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_is_using_hdr_2d__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_msaa_2d(long msaa)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, msaa);
            Helpers.SendCommand(Commands.CMD_Window_set_msaa_2d__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_msaa_2d()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_msaa_2d__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_msaa_3d(long msaa)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, msaa);
            Helpers.SendCommand(Commands.CMD_Window_set_msaa_3d__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_msaa_3d()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_msaa_3d__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_screen_space_aa(long screen_space_aa)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, screen_space_aa);
            Helpers.SendCommand(Commands.CMD_Window_set_screen_space_aa__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_screen_space_aa()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_screen_space_aa__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_use_taa(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_set_use_taa__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_using_taa()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_is_using_taa__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_use_debanding(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_set_use_debanding__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_using_debanding()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_is_using_debanding__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_use_occlusion_culling(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_set_use_occlusion_culling__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_using_occlusion_culling()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_is_using_occlusion_culling__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_debug_draw(long debug_draw)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, debug_draw);
            Helpers.SendCommand(Commands.CMD_Window_set_debug_draw__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_debug_draw()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_debug_draw__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_use_oversampling(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_set_use_oversampling__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_using_oversampling()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_is_using_oversampling__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_oversampling_override(double oversampling)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDouble(Commands.CMD_DATA + 8, oversampling);
            Helpers.SendCommand(Commands.CMD_Window_set_oversampling_override__3__r0);
            Helpers.WaitForCompletion();
        }

        public double get_oversampling_override()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_oversampling_override__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public double get_oversampling()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_oversampling__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public long get_render_info(long type, long info)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, type);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, info);
            Helpers.SendCommand(Commands.CMD_Window_get_render_info__2__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong get_texture()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_texture__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_physics_object_picking(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_set_physics_object_picking__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool get_physics_object_picking()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_physics_object_picking__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_physics_object_picking_sort(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_set_physics_object_picking_sort__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool get_physics_object_picking_sort()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_physics_object_picking_sort__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_physics_object_picking_first_only(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_set_physics_object_picking_first_only__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool get_physics_object_picking_first_only()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_physics_object_picking_first_only__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public ulong get_viewport_rid()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_viewport_rid__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void push_text_input(string text)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, text);
            Helpers.SendCommand(Commands.CMD_Window_push_text_input__4__r0);
            Helpers.WaitForCompletion();
        }

        public void push_input(ulong event_, bool in_local_coords)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, event_);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, in_local_coords ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_push_input__24__1__r0);
            Helpers.WaitForCompletion();
        }

        public void push_unhandled_input(ulong event_, bool in_local_coords)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, event_);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, in_local_coords ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_push_unhandled_input__24__1__r0);
            Helpers.WaitForCompletion();
        }

        public void notify_mouse_entered()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_notify_mouse_entered__r0);
            Helpers.WaitForCompletion();
        }

        public void notify_mouse_exited()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_notify_mouse_exited__r0);
            Helpers.WaitForCompletion();
        }

        public Vector2 get_mouse_position()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_mouse_position__r5);
            Helpers.WaitForCompletion();
            Vector2 result = Helpers.ReadVector2(Commands.CMD_DATA);
            return result;
        }

        public void warp_mouse(Vector2 position)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2(Commands.CMD_DATA + 8, position);
            Helpers.SendCommand(Commands.CMD_Window_warp_mouse__5__r0);
            Helpers.WaitForCompletion();
        }

        public void update_mouse_cursor_state()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_update_mouse_cursor_state__r0);
            Helpers.WaitForCompletion();
        }

        public void gui_cancel_drag()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_gui_cancel_drag__r0);
            Helpers.WaitForCompletion();
        }

        public void gui_get_drag_data()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_gui_get_drag_data__r0);
            Helpers.WaitForCompletion();
        }

        public string gui_get_drag_description()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_gui_get_drag_description__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void gui_set_drag_description(string description)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, description);
            Helpers.SendCommand(Commands.CMD_Window_gui_set_drag_description__4__r0);
            Helpers.WaitForCompletion();
        }

        public bool gui_is_dragging()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_gui_is_dragging__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool gui_is_drag_successful()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_gui_is_drag_successful__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void gui_release_focus()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_gui_release_focus__r0);
            Helpers.WaitForCompletion();
        }

        public ulong gui_get_focus_owner()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_gui_get_focus_owner__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong gui_get_hovered_control()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_gui_get_hovered_control__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_disable_input(bool disable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, disable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_set_disable_input__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_input_disabled()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_is_input_disabled__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_positional_shadow_atlas_size(long size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, size);
            Helpers.SendCommand(Commands.CMD_Window_set_positional_shadow_atlas_size__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_positional_shadow_atlas_size()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_positional_shadow_atlas_size__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_positional_shadow_atlas_16_bits(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_set_positional_shadow_atlas_16_bits__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool get_positional_shadow_atlas_16_bits()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_positional_shadow_atlas_16_bits__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_snap_controls_to_pixels(bool enabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_set_snap_controls_to_pixels__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_snap_controls_to_pixels_enabled()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_is_snap_controls_to_pixels_enabled__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_snap_2d_transforms_to_pixel(bool enabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_set_snap_2d_transforms_to_pixel__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_snap_2d_transforms_to_pixel_enabled()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_is_snap_2d_transforms_to_pixel_enabled__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_snap_2d_vertices_to_pixel(bool enabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_set_snap_2d_vertices_to_pixel__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_snap_2d_vertices_to_pixel_enabled()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_is_snap_2d_vertices_to_pixel_enabled__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_positional_shadow_atlas_quadrant_subdiv(long quadrant, long subdiv)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, quadrant);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, subdiv);
            Helpers.SendCommand(Commands.CMD_Window_set_positional_shadow_atlas_quadrant_subdiv__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_positional_shadow_atlas_quadrant_subdiv(long quadrant)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, quadrant);
            Helpers.SendCommand(Commands.CMD_Window_get_positional_shadow_atlas_quadrant_subdiv__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_input_as_handled()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_set_input_as_handled__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_input_handled()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_is_input_handled__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_handle_input_locally(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_set_handle_input_locally__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_handling_input_locally()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_is_handling_input_locally__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_default_canvas_item_texture_filter(long mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, mode);
            Helpers.SendCommand(Commands.CMD_Window_set_default_canvas_item_texture_filter__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_default_canvas_item_texture_filter()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_default_canvas_item_texture_filter__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_embedding_subwindows(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_set_embedding_subwindows__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_embedding_subwindows()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_is_embedding_subwindows__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public object get_embedded_subwindows()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_embedded_subwindows__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void set_drag_threshold(long threshold)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, threshold);
            Helpers.SendCommand(Commands.CMD_Window_set_drag_threshold__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_drag_threshold()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_drag_threshold__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_canvas_cull_mask(long mask)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, mask);
            Helpers.SendCommand(Commands.CMD_Window_set_canvas_cull_mask__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_canvas_cull_mask()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_canvas_cull_mask__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_canvas_cull_mask_bit(long layer, bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, layer);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_set_canvas_cull_mask_bit__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool get_canvas_cull_mask_bit(long layer)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, layer);
            Helpers.SendCommand(Commands.CMD_Window_get_canvas_cull_mask_bit__2__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_default_canvas_item_texture_repeat(long mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, mode);
            Helpers.SendCommand(Commands.CMD_Window_set_default_canvas_item_texture_repeat__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_default_canvas_item_texture_repeat()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_default_canvas_item_texture_repeat__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_sdf_oversize(long oversize)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, oversize);
            Helpers.SendCommand(Commands.CMD_Window_set_sdf_oversize__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_sdf_oversize()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_sdf_oversize__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_sdf_scale(long scale)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, scale);
            Helpers.SendCommand(Commands.CMD_Window_set_sdf_scale__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_sdf_scale()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_sdf_scale__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_mesh_lod_threshold(double pixels)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDouble(Commands.CMD_DATA + 8, pixels);
            Helpers.SendCommand(Commands.CMD_Window_set_mesh_lod_threshold__3__r0);
            Helpers.WaitForCompletion();
        }

        public double get_mesh_lod_threshold()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_mesh_lod_threshold__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void _process_picking()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window__process_picking__r0);
            Helpers.WaitForCompletion();
        }

        public void set_as_audio_listener_2d(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_set_as_audio_listener_2d__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_audio_listener_2d()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_is_audio_listener_2d__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public ulong get_audio_listener_2d()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_audio_listener_2d__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong get_camera_2d()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_camera_2d__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_world_3d(ulong world_3d)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, world_3d);
            Helpers.SendCommand(Commands.CMD_Window_set_world_3d__24__r0);
            Helpers.WaitForCompletion();
        }

        public ulong get_world_3d()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_world_3d__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong find_world_3d()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_find_world_3d__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_use_own_world_3d(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_set_use_own_world_3d__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_using_own_world_3d()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_is_using_own_world_3d__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public ulong get_audio_listener_3d()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_audio_listener_3d__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong get_camera_3d()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_camera_3d__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_as_audio_listener_3d(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_set_as_audio_listener_3d__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_audio_listener_3d()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_is_audio_listener_3d__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_disable_3d(bool disable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, disable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_set_disable_3d__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_3d_disabled()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_is_3d_disabled__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_use_xr(bool use)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, use ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_set_use_xr__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_using_xr()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_is_using_xr__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_scaling_3d_mode(long scaling_3d_mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, scaling_3d_mode);
            Helpers.SendCommand(Commands.CMD_Window_set_scaling_3d_mode__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_scaling_3d_mode()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_scaling_3d_mode__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_scaling_3d_scale(double scale)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDouble(Commands.CMD_DATA + 8, scale);
            Helpers.SendCommand(Commands.CMD_Window_set_scaling_3d_scale__3__r0);
            Helpers.WaitForCompletion();
        }

        public double get_scaling_3d_scale()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_scaling_3d_scale__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void set_fsr_sharpness(double fsr_sharpness)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDouble(Commands.CMD_DATA + 8, fsr_sharpness);
            Helpers.SendCommand(Commands.CMD_Window_set_fsr_sharpness__3__r0);
            Helpers.WaitForCompletion();
        }

        public double get_fsr_sharpness()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_fsr_sharpness__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void set_texture_mipmap_bias(double texture_mipmap_bias)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDouble(Commands.CMD_DATA + 8, texture_mipmap_bias);
            Helpers.SendCommand(Commands.CMD_Window_set_texture_mipmap_bias__3__r0);
            Helpers.WaitForCompletion();
        }

        public double get_texture_mipmap_bias()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_texture_mipmap_bias__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void set_anisotropic_filtering_level(long anisotropic_filtering_level)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, anisotropic_filtering_level);
            Helpers.SendCommand(Commands.CMD_Window_set_anisotropic_filtering_level__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_anisotropic_filtering_level()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_anisotropic_filtering_level__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_vrs_mode(long mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, mode);
            Helpers.SendCommand(Commands.CMD_Window_set_vrs_mode__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_vrs_mode()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_vrs_mode__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_vrs_update_mode(long mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, mode);
            Helpers.SendCommand(Commands.CMD_Window_set_vrs_update_mode__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_vrs_update_mode()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_vrs_update_mode__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_vrs_texture(ulong texture)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, texture);
            Helpers.SendCommand(Commands.CMD_Window_set_vrs_texture__24__r0);
            Helpers.WaitForCompletion();
        }

        public ulong get_vrs_texture()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_vrs_texture__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void _process(double delta)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDouble(Commands.CMD_DATA + 8, delta);
            Helpers.SendCommand(Commands.CMD_Window__process__3__r0);
            Helpers.WaitForCompletion();
        }

        public void _physics_process(double delta)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDouble(Commands.CMD_DATA + 8, delta);
            Helpers.SendCommand(Commands.CMD_Window__physics_process__3__r0);
            Helpers.WaitForCompletion();
        }

        public void _enter_tree()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window__enter_tree__r0);
            Helpers.WaitForCompletion();
        }

        public void _exit_tree()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window__exit_tree__r0);
            Helpers.WaitForCompletion();
        }

        public void _ready()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window__ready__r0);
            Helpers.WaitForCompletion();
        }

        public string[] _get_configuration_warnings()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window__get_configuration_warnings__r34);
            Helpers.WaitForCompletion();
            string[] result = Helpers.ReadPackedStringArray(Commands.CMD_DATA);
            return result;
        }

        public string[] _get_accessibility_configuration_warnings()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window__get_accessibility_configuration_warnings__r34);
            Helpers.WaitForCompletion();
            string[] result = Helpers.ReadPackedStringArray(Commands.CMD_DATA);
            return result;
        }

        public void _input(ulong event_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, event_);
            Helpers.SendCommand(Commands.CMD_Window__input__24__r0);
            Helpers.WaitForCompletion();
        }

        public void _shortcut_input(ulong event_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, event_);
            Helpers.SendCommand(Commands.CMD_Window__shortcut_input__24__r0);
            Helpers.WaitForCompletion();
        }

        public void _unhandled_input(ulong event_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, event_);
            Helpers.SendCommand(Commands.CMD_Window__unhandled_input__24__r0);
            Helpers.WaitForCompletion();
        }

        public void _unhandled_key_input(ulong event_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, event_);
            Helpers.SendCommand(Commands.CMD_Window__unhandled_key_input__24__r0);
            Helpers.WaitForCompletion();
        }

        public ulong _get_focused_accessibility_element()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window__get_focused_accessibility_element__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void print_orphan_nodes()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_print_orphan_nodes__r0);
            Helpers.WaitForCompletion();
        }

        public object get_orphan_node_ids()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_orphan_node_ids__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void add_sibling(ulong sibling, bool force_readable_name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, sibling);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, force_readable_name ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_add_sibling__24__1__r0);
            Helpers.WaitForCompletion();
        }

        public void set_name(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_Window_set_name__21__r0);
            Helpers.WaitForCompletion();
        }

        public string get_name()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_name__r21);
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
            Helpers.SendCommand(Commands.CMD_Window_add_child__24__1__2__r0);
            Helpers.WaitForCompletion();
        }

        public void remove_child(ulong node)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, node);
            Helpers.SendCommand(Commands.CMD_Window_remove_child__24__r0);
            Helpers.WaitForCompletion();
        }

        public void reparent(ulong new_parent, bool keep_global_transform)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, new_parent);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, keep_global_transform ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_reparent__24__1__r0);
            Helpers.WaitForCompletion();
        }

        public long get_child_count(bool include_internal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, include_internal ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_get_child_count__1__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public object get_children(bool include_internal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, include_internal ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_get_children__1__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public ulong get_child(long idx, bool include_internal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, idx);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, include_internal ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_get_child__2__1__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public bool has_node(string path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, path);
            Helpers.SendCommand(Commands.CMD_Window_has_node__22__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public ulong get_node(string path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, path);
            Helpers.SendCommand(Commands.CMD_Window_get_node__22__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong get_node_or_null(string path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, path);
            Helpers.SendCommand(Commands.CMD_Window_get_node_or_null__22__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong get_parent()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_parent__r24);
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
            Helpers.SendCommand(Commands.CMD_Window_find_child__4__1__1__r24);
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
            Helpers.SendCommand(Commands.CMD_Window_find_children__4__4__1__1__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public ulong find_parent(string pattern)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, pattern);
            Helpers.SendCommand(Commands.CMD_Window_find_parent__4__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public bool has_node_and_resource(string path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, path);
            Helpers.SendCommand(Commands.CMD_Window_has_node_and_resource__22__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public object get_node_and_resource(string path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, path);
            Helpers.SendCommand(Commands.CMD_Window_get_node_and_resource__22__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public bool is_inside_tree()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_is_inside_tree__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool is_part_of_edited_scene()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_is_part_of_edited_scene__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool is_ancestor_of(ulong node)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, node);
            Helpers.SendCommand(Commands.CMD_Window_is_ancestor_of__24__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool is_greater_than(ulong node)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, node);
            Helpers.SendCommand(Commands.CMD_Window_is_greater_than__24__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public string get_path()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_path__r22);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadNodePath(Commands.CMD_DATA);
            return result;
        }

        public string get_path_to(ulong node, bool use_unique_path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, node);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, use_unique_path ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_get_path_to__24__1__r22);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadNodePath(Commands.CMD_DATA);
            return result;
        }

        public void add_to_group(string group, bool persistent)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, group);
            Helpers.WriteInt32(Commands.CMD_DATA + 1036, persistent ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_add_to_group__21__1__r0);
            Helpers.WaitForCompletion();
        }

        public void remove_from_group(string group)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, group);
            Helpers.SendCommand(Commands.CMD_Window_remove_from_group__21__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_in_group(string group)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, group);
            Helpers.SendCommand(Commands.CMD_Window_is_in_group__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void move_child(ulong child_node, long to_index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, child_node);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, to_index);
            Helpers.SendCommand(Commands.CMD_Window_move_child__24__2__r0);
            Helpers.WaitForCompletion();
        }

        public object get_groups()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_groups__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void set_owner(ulong owner)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, owner);
            Helpers.SendCommand(Commands.CMD_Window_set_owner__24__r0);
            Helpers.WaitForCompletion();
        }

        public ulong get_owner()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_owner__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public long get_index(bool include_internal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, include_internal ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_get_index__1__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void print_tree()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_print_tree__r0);
            Helpers.WaitForCompletion();
        }

        public void print_tree_pretty()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_print_tree_pretty__r0);
            Helpers.WaitForCompletion();
        }

        public string get_tree_string()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_tree_string__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public string get_tree_string_pretty()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_tree_string_pretty__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void set_scene_file_path(string scene_file_path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, scene_file_path);
            Helpers.SendCommand(Commands.CMD_Window_set_scene_file_path__4__r0);
            Helpers.WaitForCompletion();
        }

        public string get_scene_file_path()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_scene_file_path__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void propagate_notification(long what)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, what);
            Helpers.SendCommand(Commands.CMD_Window_propagate_notification__2__r0);
            Helpers.WaitForCompletion();
        }

        public void propagate_call(string method, object args, bool parent_first)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.WriteArray(Commands.CMD_DATA + 1036, args);
            Helpers.WriteInt32(Commands.CMD_DATA + 1036, parent_first ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_propagate_call__21__28__1__r0);
            Helpers.WaitForCompletion();
        }

        public void set_physics_process(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_set_physics_process__1__r0);
            Helpers.WaitForCompletion();
        }

        public double get_physics_process_delta_time()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_physics_process_delta_time__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public bool is_physics_processing()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_is_physics_processing__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public double get_process_delta_time()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_process_delta_time__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void set_process(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_set_process__1__r0);
            Helpers.WaitForCompletion();
        }

        public void set_process_priority(long priority)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, priority);
            Helpers.SendCommand(Commands.CMD_Window_set_process_priority__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_process_priority()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_process_priority__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_physics_process_priority(long priority)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, priority);
            Helpers.SendCommand(Commands.CMD_Window_set_physics_process_priority__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_physics_process_priority()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_physics_process_priority__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool is_processing()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_is_processing__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_process_input(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_set_process_input__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_processing_input()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_is_processing_input__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_process_shortcut_input(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_set_process_shortcut_input__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_processing_shortcut_input()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_is_processing_shortcut_input__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_process_unhandled_input(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_set_process_unhandled_input__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_processing_unhandled_input()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_is_processing_unhandled_input__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_process_unhandled_key_input(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_set_process_unhandled_key_input__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_processing_unhandled_key_input()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_is_processing_unhandled_key_input__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_process_mode(long mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, mode);
            Helpers.SendCommand(Commands.CMD_Window_set_process_mode__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_process_mode()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_process_mode__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool can_process()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_can_process__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_process_thread_group(long mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, mode);
            Helpers.SendCommand(Commands.CMD_Window_set_process_thread_group__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_process_thread_group()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_process_thread_group__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_process_thread_messages(long flags)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, flags);
            Helpers.SendCommand(Commands.CMD_Window_set_process_thread_messages__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_process_thread_messages()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_process_thread_messages__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_process_thread_group_order(long order)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, order);
            Helpers.SendCommand(Commands.CMD_Window_set_process_thread_group_order__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_process_thread_group_order()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_process_thread_group_order__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void queue_accessibility_update()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_queue_accessibility_update__r0);
            Helpers.WaitForCompletion();
        }

        public ulong get_accessibility_element()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_accessibility_element__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void set_display_folded(bool fold)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, fold ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_set_display_folded__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_displayed_folded()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_is_displayed_folded__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_process_internal(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_set_process_internal__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_processing_internal()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_is_processing_internal__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_physics_process_internal(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_set_physics_process_internal__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_physics_processing_internal()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_is_physics_processing_internal__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_physics_interpolation_mode(long mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, mode);
            Helpers.SendCommand(Commands.CMD_Window_set_physics_interpolation_mode__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_physics_interpolation_mode()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_physics_interpolation_mode__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool is_physics_interpolated()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_is_physics_interpolated__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool is_physics_interpolated_and_enabled()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_is_physics_interpolated_and_enabled__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void reset_physics_interpolation()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_reset_physics_interpolation__r0);
            Helpers.WaitForCompletion();
        }

        public void set_auto_translate_mode(long mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, mode);
            Helpers.SendCommand(Commands.CMD_Window_set_auto_translate_mode__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_auto_translate_mode()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_auto_translate_mode__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool can_auto_translate()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_can_auto_translate__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_translation_domain_inherited()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_set_translation_domain_inherited__r0);
            Helpers.WaitForCompletion();
        }

        public ulong get_window()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_window__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong get_last_exclusive_window()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_last_exclusive_window__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong get_tree()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_tree__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong create_tween()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_create_tween__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong duplicate(long flags)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, flags);
            Helpers.SendCommand(Commands.CMD_Window_duplicate__2__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void replace_by(ulong node, bool keep_groups)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, node);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, keep_groups ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_replace_by__24__1__r0);
            Helpers.WaitForCompletion();
        }

        public void set_scene_instance_load_placeholder(bool load_placeholder)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, load_placeholder ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_set_scene_instance_load_placeholder__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool get_scene_instance_load_placeholder()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_scene_instance_load_placeholder__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_editable_instance(ulong node, bool is_editable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, node);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, is_editable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_set_editable_instance__24__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_editable_instance(ulong node)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, node);
            Helpers.SendCommand(Commands.CMD_Window_is_editable_instance__24__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public ulong get_viewport()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_viewport__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void queue_free()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_queue_free__r0);
            Helpers.WaitForCompletion();
        }

        public void request_ready()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_request_ready__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_node_ready()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_is_node_ready__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_multiplayer_authority(long id, bool recursive)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, id);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, recursive ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_set_multiplayer_authority__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public long get_multiplayer_authority()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_multiplayer_authority__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool is_multiplayer_authority()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_is_multiplayer_authority__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public ulong get_multiplayer()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_multiplayer__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void rpc_config(string method, object config)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, config);
            Helpers.SendCommand(Commands.CMD_Window_rpc_config__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get_node_rpc_config()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_node_rpc_config__r0);
            Helpers.WaitForCompletion();
        }

        public void set_editor_description(string editor_description)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, editor_description);
            Helpers.SendCommand(Commands.CMD_Window_set_editor_description__4__r0);
            Helpers.WaitForCompletion();
        }

        public string get_editor_description()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_editor_description__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void set_unique_name_in_owner(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_set_unique_name_in_owner__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_unique_name_in_owner()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_is_unique_name_in_owner__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public string atr(string message, string context)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, message);
            Helpers.WriteStringName(Commands.CMD_DATA + 1036, context);
            Helpers.SendCommand(Commands.CMD_Window_atr__4__21__r4);
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
            Helpers.SendCommand(Commands.CMD_Window_atr_n__4__21__2__21__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void _set_property_pinned(string property, bool pinned)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, property);
            Helpers.WriteInt32(Commands.CMD_DATA + 1036, pinned ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window__set_property_pinned__4__1__r0);
            Helpers.WaitForCompletion();
        }

        public long rpc(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_Window_rpc__21__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long rpc_id(long peer_id, string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, peer_id);
            Helpers.WriteStringName(Commands.CMD_DATA + 16, method);
            Helpers.SendCommand(Commands.CMD_Window_rpc_id__2__21__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void update_configuration_warnings()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_update_configuration_warnings__r0);
            Helpers.WaitForCompletion();
        }

        public void call_deferred_thread_group(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_Window_call_deferred_thread_group__21__r0);
            Helpers.WaitForCompletion();
        }

        public void set_deferred_thread_group(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_Window_set_deferred_thread_group__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void notify_deferred_thread_group(long what)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, what);
            Helpers.SendCommand(Commands.CMD_Window_notify_deferred_thread_group__2__r0);
            Helpers.WaitForCompletion();
        }

        public void call_thread_safe(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_Window_call_thread_safe__21__r0);
            Helpers.WaitForCompletion();
        }

        public void set_thread_safe(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_Window_set_thread_safe__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void notify_thread_safe(long what)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, what);
            Helpers.SendCommand(Commands.CMD_Window_notify_thread_safe__2__r0);
            Helpers.WaitForCompletion();
        }

        public void free()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_free__r0);
            Helpers.WaitForCompletion();
        }

        public void _init()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window__init__r0);
            Helpers.WaitForCompletion();
        }

        public string _to_string()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window__to_string__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void _notification(long what)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, what);
            Helpers.SendCommand(Commands.CMD_Window__notification__2__r0);
            Helpers.WaitForCompletion();
        }

        public bool _set(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_Window__set__21__0__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _get(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_Window__get__21__r0);
            Helpers.WaitForCompletion();
        }

        public object _get_property_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window__get_property_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void _validate_property(object property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDictionary(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_Window__validate_property__27__r0);
            Helpers.WaitForCompletion();
        }

        public bool _property_can_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_Window__property_can_revert__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _property_get_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_Window__property_get_revert__21__r0);
            Helpers.WaitForCompletion();
        }

        public bool _iter_init(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteArray(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_Window__iter_init__28__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool _iter_next(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteArray(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_Window__iter_next__28__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _iter_get(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVariant(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_Window__iter_get__0__r0);
            Helpers.WaitForCompletion();
        }

        public string get_class()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_class__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public bool is_class(string class_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, class_);
            Helpers.SendCommand(Commands.CMD_Window_is_class__4__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_Window_set__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_Window_get__21__r0);
            Helpers.WaitForCompletion();
        }

        public void set_indexed(string property_path, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, property_path);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_Window_set_indexed__22__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get_indexed(string property_path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, property_path);
            Helpers.SendCommand(Commands.CMD_Window_get_indexed__22__r0);
            Helpers.WaitForCompletion();
        }

        public object get_property_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_property_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_method_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_method_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public bool property_can_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_Window_property_can_revert__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void property_get_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_Window_property_get_revert__21__r0);
            Helpers.WaitForCompletion();
        }

        public void notification(long what, bool reversed)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, what);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, reversed ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_notification__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public string to_string()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_to_string__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public ulong get_instance_id()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_instance_id__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_script(object script)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVariant(Commands.CMD_DATA + 8, script);
            Helpers.SendCommand(Commands.CMD_Window_set_script__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get_script()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_script__r0);
            Helpers.WaitForCompletion();
        }

        public void set_meta(string name, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_Window_set_meta__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void remove_meta(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_Window_remove_meta__21__r0);
            Helpers.WaitForCompletion();
        }

        public void get_meta(string name, object default_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, default_);
            Helpers.SendCommand(Commands.CMD_Window_get_meta__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_meta(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_Window_has_meta__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public object get_meta_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_meta_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void add_user_signal(string signal, object arguments)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, signal);
            Helpers.WriteArray(Commands.CMD_DATA + 1036, arguments);
            Helpers.SendCommand(Commands.CMD_Window_add_user_signal__4__28__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_user_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_Window_has_user_signal__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void remove_user_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_Window_remove_user_signal__21__r0);
            Helpers.WaitForCompletion();
        }

        public long emit_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_Window_emit_signal__21__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void call(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_Window_call__21__r0);
            Helpers.WaitForCompletion();
        }

        public void call_deferred(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_Window_call_deferred__21__r0);
            Helpers.WaitForCompletion();
        }

        public void set_deferred(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_Window_set_deferred__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void callv(string method, object arg_array)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.WriteArray(Commands.CMD_DATA + 1036, arg_array);
            Helpers.SendCommand(Commands.CMD_Window_callv__21__28__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_method(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_Window_has_method__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public long get_method_argument_count(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_Window_get_method_argument_count__21__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool has_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_Window_has_signal__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public object get_signal_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_signal_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_signal_connection_list(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_Window_get_signal_connection_list__21__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_incoming_connections()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_incoming_connections__r28);
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
            Helpers.SendCommand(Commands.CMD_Window_connect__21__25__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void disconnect(string signal, object callable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.WriteCallable(Commands.CMD_DATA + 1036, callable);
            Helpers.SendCommand(Commands.CMD_Window_disconnect__21__25__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_connected(string signal, object callable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.WriteCallable(Commands.CMD_DATA + 1036, callable);
            Helpers.SendCommand(Commands.CMD_Window_is_connected__21__25__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool has_connections(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_Window_has_connections__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_block_signals(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_set_block_signals__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_blocking_signals()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_is_blocking_signals__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void notify_property_list_changed()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_notify_property_list_changed__r0);
            Helpers.WaitForCompletion();
        }

        public void set_message_translation(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_Window_set_message_translation__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool can_translate_messages()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_can_translate_messages__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public string tr(string message, string context)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, message);
            Helpers.WriteStringName(Commands.CMD_DATA + 1036, context);
            Helpers.SendCommand(Commands.CMD_Window_tr__21__21__r4);
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
            Helpers.SendCommand(Commands.CMD_Window_tr_n__21__21__2__21__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public string get_translation_domain()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_get_translation_domain__r21);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadStringName(Commands.CMD_DATA);
            return result;
        }

        public void set_translation_domain(string domain)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, domain);
            Helpers.SendCommand(Commands.CMD_Window_set_translation_domain__21__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_queued_for_deletion()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_is_queued_for_deletion__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void cancel_free()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_Window_cancel_free__r0);
            Helpers.WaitForCompletion();
        }

    }
}
