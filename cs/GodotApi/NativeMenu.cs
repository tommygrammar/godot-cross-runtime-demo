using System;

namespace GodotWeb
{
    public class NativeMenu : GodotObject
    {
        public NativeMenu(ulong id) : base(id) { }

        public bool has_feature(long feature)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, feature);
            Helpers.SendCommand(Commands.CMD_NativeMenu_has_feature__2__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool has_system_menu(long menu_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, menu_id);
            Helpers.SendCommand(Commands.CMD_NativeMenu_has_system_menu__2__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public ulong get_system_menu(long menu_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, menu_id);
            Helpers.SendCommand(Commands.CMD_NativeMenu_get_system_menu__2__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public string get_system_menu_name(long menu_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, menu_id);
            Helpers.SendCommand(Commands.CMD_NativeMenu_get_system_menu_name__2__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public string get_system_menu_text(long menu_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, menu_id);
            Helpers.SendCommand(Commands.CMD_NativeMenu_get_system_menu_text__2__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void set_system_menu_text(long menu_id, string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, menu_id);
            Helpers.WriteString(Commands.CMD_DATA + 16, name);
            Helpers.SendCommand(Commands.CMD_NativeMenu_set_system_menu_text__2__4__r0);
            Helpers.WaitForCompletion();
        }

        public ulong create_menu()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_NativeMenu_create_menu__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public bool has_menu(ulong rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.SendCommand(Commands.CMD_NativeMenu_has_menu__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void free_menu(ulong rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.SendCommand(Commands.CMD_NativeMenu_free_menu__23__r0);
            Helpers.WaitForCompletion();
        }

        public Vector2 get_size(ulong rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.SendCommand(Commands.CMD_NativeMenu_get_size__23__r5);
            Helpers.WaitForCompletion();
            Vector2 result = Helpers.ReadVector2(Commands.CMD_DATA);
            return result;
        }

        public void popup(ulong rid, Vector2i position)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.WriteVector2i(Commands.CMD_DATA + 16, position);
            Helpers.SendCommand(Commands.CMD_NativeMenu_popup__23__6__r0);
            Helpers.WaitForCompletion();
        }

        public void set_interface_direction(ulong rid, bool is_rtl)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, is_rtl ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_NativeMenu_set_interface_direction__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public void set_popup_open_callback(ulong rid, object callback)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.WriteCallable(Commands.CMD_DATA + 16, callback);
            Helpers.SendCommand(Commands.CMD_NativeMenu_set_popup_open_callback__23__25__r0);
            Helpers.WaitForCompletion();
        }

        public object get_popup_open_callback(ulong rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.SendCommand(Commands.CMD_NativeMenu_get_popup_open_callback__23__r25);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadCallable(Commands.CMD_DATA);
            return result;
        }

        public void set_popup_close_callback(ulong rid, object callback)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.WriteCallable(Commands.CMD_DATA + 16, callback);
            Helpers.SendCommand(Commands.CMD_NativeMenu_set_popup_close_callback__23__25__r0);
            Helpers.WaitForCompletion();
        }

        public object get_popup_close_callback(ulong rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.SendCommand(Commands.CMD_NativeMenu_get_popup_close_callback__23__r25);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadCallable(Commands.CMD_DATA);
            return result;
        }

        public void set_minimum_width(ulong rid, double width)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, width);
            Helpers.SendCommand(Commands.CMD_NativeMenu_set_minimum_width__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public double get_minimum_width(ulong rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.SendCommand(Commands.CMD_NativeMenu_get_minimum_width__23__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public bool is_opened(ulong rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.SendCommand(Commands.CMD_NativeMenu_is_opened__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public long add_submenu_item(ulong rid, string label, ulong submenu_rid, object tag, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.WriteString(Commands.CMD_DATA + 16, label);
            Helpers.WriteRID(Commands.CMD_DATA + 1044, submenu_rid);
            Helpers.WriteVariant(Commands.CMD_DATA + 1052, tag);
            Helpers.WriteInt64(Commands.CMD_DATA + 1052, index);
            Helpers.SendCommand(Commands.CMD_NativeMenu_add_submenu_item__23__4__23__0__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long add_item(ulong rid, string label, object callback, object key_callback, object tag, long accelerator, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.WriteString(Commands.CMD_DATA + 16, label);
            Helpers.WriteCallable(Commands.CMD_DATA + 1044, callback);
            Helpers.WriteCallable(Commands.CMD_DATA + 1044, key_callback);
            Helpers.WriteVariant(Commands.CMD_DATA + 1044, tag);
            Helpers.WriteInt64(Commands.CMD_DATA + 1044, accelerator);
            Helpers.WriteInt64(Commands.CMD_DATA + 1052, index);
            Helpers.SendCommand(Commands.CMD_NativeMenu_add_item__23__4__25__25__0__2__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long add_check_item(ulong rid, string label, object callback, object key_callback, object tag, long accelerator, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.WriteString(Commands.CMD_DATA + 16, label);
            Helpers.WriteCallable(Commands.CMD_DATA + 1044, callback);
            Helpers.WriteCallable(Commands.CMD_DATA + 1044, key_callback);
            Helpers.WriteVariant(Commands.CMD_DATA + 1044, tag);
            Helpers.WriteInt64(Commands.CMD_DATA + 1044, accelerator);
            Helpers.WriteInt64(Commands.CMD_DATA + 1052, index);
            Helpers.SendCommand(Commands.CMD_NativeMenu_add_check_item__23__4__25__25__0__2__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long add_icon_item(ulong rid, ulong icon, string label, object callback, object key_callback, object tag, long accelerator, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.WriteUInt64(Commands.CMD_DATA + 16, icon);
            Helpers.WriteString(Commands.CMD_DATA + 24, label);
            Helpers.WriteCallable(Commands.CMD_DATA + 1052, callback);
            Helpers.WriteCallable(Commands.CMD_DATA + 1052, key_callback);
            Helpers.WriteVariant(Commands.CMD_DATA + 1052, tag);
            Helpers.WriteInt64(Commands.CMD_DATA + 1052, accelerator);
            Helpers.WriteInt64(Commands.CMD_DATA + 1060, index);
            Helpers.SendCommand(Commands.CMD_NativeMenu_add_icon_item__23__24__4__25__25__0__2__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long add_icon_check_item(ulong rid, ulong icon, string label, object callback, object key_callback, object tag, long accelerator, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.WriteUInt64(Commands.CMD_DATA + 16, icon);
            Helpers.WriteString(Commands.CMD_DATA + 24, label);
            Helpers.WriteCallable(Commands.CMD_DATA + 1052, callback);
            Helpers.WriteCallable(Commands.CMD_DATA + 1052, key_callback);
            Helpers.WriteVariant(Commands.CMD_DATA + 1052, tag);
            Helpers.WriteInt64(Commands.CMD_DATA + 1052, accelerator);
            Helpers.WriteInt64(Commands.CMD_DATA + 1060, index);
            Helpers.SendCommand(Commands.CMD_NativeMenu_add_icon_check_item__23__24__4__25__25__0__2__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long add_radio_check_item(ulong rid, string label, object callback, object key_callback, object tag, long accelerator, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.WriteString(Commands.CMD_DATA + 16, label);
            Helpers.WriteCallable(Commands.CMD_DATA + 1044, callback);
            Helpers.WriteCallable(Commands.CMD_DATA + 1044, key_callback);
            Helpers.WriteVariant(Commands.CMD_DATA + 1044, tag);
            Helpers.WriteInt64(Commands.CMD_DATA + 1044, accelerator);
            Helpers.WriteInt64(Commands.CMD_DATA + 1052, index);
            Helpers.SendCommand(Commands.CMD_NativeMenu_add_radio_check_item__23__4__25__25__0__2__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long add_icon_radio_check_item(ulong rid, ulong icon, string label, object callback, object key_callback, object tag, long accelerator, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.WriteUInt64(Commands.CMD_DATA + 16, icon);
            Helpers.WriteString(Commands.CMD_DATA + 24, label);
            Helpers.WriteCallable(Commands.CMD_DATA + 1052, callback);
            Helpers.WriteCallable(Commands.CMD_DATA + 1052, key_callback);
            Helpers.WriteVariant(Commands.CMD_DATA + 1052, tag);
            Helpers.WriteInt64(Commands.CMD_DATA + 1052, accelerator);
            Helpers.WriteInt64(Commands.CMD_DATA + 1060, index);
            Helpers.SendCommand(Commands.CMD_NativeMenu_add_icon_radio_check_item__23__24__4__25__25__0__2__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long add_multistate_item(ulong rid, string label, long max_states, long default_state, object callback, object key_callback, object tag, long accelerator, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.WriteString(Commands.CMD_DATA + 16, label);
            Helpers.WriteInt64(Commands.CMD_DATA + 1044, max_states);
            Helpers.WriteInt64(Commands.CMD_DATA + 1052, default_state);
            Helpers.WriteCallable(Commands.CMD_DATA + 1060, callback);
            Helpers.WriteCallable(Commands.CMD_DATA + 1060, key_callback);
            Helpers.WriteVariant(Commands.CMD_DATA + 1060, tag);
            Helpers.WriteInt64(Commands.CMD_DATA + 1060, accelerator);
            Helpers.WriteInt64(Commands.CMD_DATA + 1068, index);
            Helpers.SendCommand(Commands.CMD_NativeMenu_add_multistate_item__23__4__2__2__25__25__0__2__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long add_separator(ulong rid, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, index);
            Helpers.SendCommand(Commands.CMD_NativeMenu_add_separator__23__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long find_item_index_with_text(ulong rid, string text)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.WriteString(Commands.CMD_DATA + 16, text);
            Helpers.SendCommand(Commands.CMD_NativeMenu_find_item_index_with_text__23__4__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long find_item_index_with_tag(ulong rid, object tag)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.WriteVariant(Commands.CMD_DATA + 16, tag);
            Helpers.SendCommand(Commands.CMD_NativeMenu_find_item_index_with_tag__23__0__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long find_item_index_with_submenu(ulong rid, ulong submenu_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.WriteRID(Commands.CMD_DATA + 16, submenu_rid);
            Helpers.SendCommand(Commands.CMD_NativeMenu_find_item_index_with_submenu__23__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool is_item_checked(ulong rid, long idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, idx);
            Helpers.SendCommand(Commands.CMD_NativeMenu_is_item_checked__23__2__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool is_item_checkable(ulong rid, long idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, idx);
            Helpers.SendCommand(Commands.CMD_NativeMenu_is_item_checkable__23__2__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool is_item_radio_checkable(ulong rid, long idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, idx);
            Helpers.SendCommand(Commands.CMD_NativeMenu_is_item_radio_checkable__23__2__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public object get_item_callback(ulong rid, long idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, idx);
            Helpers.SendCommand(Commands.CMD_NativeMenu_get_item_callback__23__2__r25);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadCallable(Commands.CMD_DATA);
            return result;
        }

        public object get_item_key_callback(ulong rid, long idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, idx);
            Helpers.SendCommand(Commands.CMD_NativeMenu_get_item_key_callback__23__2__r25);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadCallable(Commands.CMD_DATA);
            return result;
        }

        public void get_item_tag(ulong rid, long idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, idx);
            Helpers.SendCommand(Commands.CMD_NativeMenu_get_item_tag__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public string get_item_text(ulong rid, long idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, idx);
            Helpers.SendCommand(Commands.CMD_NativeMenu_get_item_text__23__2__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public ulong get_item_submenu(ulong rid, long idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, idx);
            Helpers.SendCommand(Commands.CMD_NativeMenu_get_item_submenu__23__2__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public long get_item_accelerator(ulong rid, long idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, idx);
            Helpers.SendCommand(Commands.CMD_NativeMenu_get_item_accelerator__23__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool is_item_disabled(ulong rid, long idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, idx);
            Helpers.SendCommand(Commands.CMD_NativeMenu_is_item_disabled__23__2__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool is_item_hidden(ulong rid, long idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, idx);
            Helpers.SendCommand(Commands.CMD_NativeMenu_is_item_hidden__23__2__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public string get_item_tooltip(ulong rid, long idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, idx);
            Helpers.SendCommand(Commands.CMD_NativeMenu_get_item_tooltip__23__2__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public long get_item_state(ulong rid, long idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, idx);
            Helpers.SendCommand(Commands.CMD_NativeMenu_get_item_state__23__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long get_item_max_states(ulong rid, long idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, idx);
            Helpers.SendCommand(Commands.CMD_NativeMenu_get_item_max_states__23__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong get_item_icon(ulong rid, long idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, idx);
            Helpers.SendCommand(Commands.CMD_NativeMenu_get_item_icon__23__2__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public long get_item_indentation_level(ulong rid, long idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, idx);
            Helpers.SendCommand(Commands.CMD_NativeMenu_get_item_indentation_level__23__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_item_checked(ulong rid, long idx, bool checked_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, idx);
            Helpers.WriteInt32(Commands.CMD_DATA + 24, checked_ ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_NativeMenu_set_item_checked__23__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public void set_item_checkable(ulong rid, long idx, bool checkable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, idx);
            Helpers.WriteInt32(Commands.CMD_DATA + 24, checkable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_NativeMenu_set_item_checkable__23__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public void set_item_radio_checkable(ulong rid, long idx, bool checkable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, idx);
            Helpers.WriteInt32(Commands.CMD_DATA + 24, checkable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_NativeMenu_set_item_radio_checkable__23__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public void set_item_callback(ulong rid, long idx, object callback)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, idx);
            Helpers.WriteCallable(Commands.CMD_DATA + 24, callback);
            Helpers.SendCommand(Commands.CMD_NativeMenu_set_item_callback__23__2__25__r0);
            Helpers.WaitForCompletion();
        }

        public void set_item_hover_callbacks(ulong rid, long idx, object callback)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, idx);
            Helpers.WriteCallable(Commands.CMD_DATA + 24, callback);
            Helpers.SendCommand(Commands.CMD_NativeMenu_set_item_hover_callbacks__23__2__25__r0);
            Helpers.WaitForCompletion();
        }

        public void set_item_key_callback(ulong rid, long idx, object key_callback)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, idx);
            Helpers.WriteCallable(Commands.CMD_DATA + 24, key_callback);
            Helpers.SendCommand(Commands.CMD_NativeMenu_set_item_key_callback__23__2__25__r0);
            Helpers.WaitForCompletion();
        }

        public void set_item_tag(ulong rid, long idx, object tag)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, idx);
            Helpers.WriteVariant(Commands.CMD_DATA + 24, tag);
            Helpers.SendCommand(Commands.CMD_NativeMenu_set_item_tag__23__2__0__r0);
            Helpers.WaitForCompletion();
        }

        public void set_item_text(ulong rid, long idx, string text)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, idx);
            Helpers.WriteString(Commands.CMD_DATA + 24, text);
            Helpers.SendCommand(Commands.CMD_NativeMenu_set_item_text__23__2__4__r0);
            Helpers.WaitForCompletion();
        }

        public void set_item_submenu(ulong rid, long idx, ulong submenu_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, idx);
            Helpers.WriteRID(Commands.CMD_DATA + 24, submenu_rid);
            Helpers.SendCommand(Commands.CMD_NativeMenu_set_item_submenu__23__2__23__r0);
            Helpers.WaitForCompletion();
        }

        public void set_item_accelerator(ulong rid, long idx, long keycode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, idx);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, keycode);
            Helpers.SendCommand(Commands.CMD_NativeMenu_set_item_accelerator__23__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public void set_item_disabled(ulong rid, long idx, bool disabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, idx);
            Helpers.WriteInt32(Commands.CMD_DATA + 24, disabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_NativeMenu_set_item_disabled__23__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public void set_item_hidden(ulong rid, long idx, bool hidden)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, idx);
            Helpers.WriteInt32(Commands.CMD_DATA + 24, hidden ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_NativeMenu_set_item_hidden__23__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public void set_item_tooltip(ulong rid, long idx, string tooltip)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, idx);
            Helpers.WriteString(Commands.CMD_DATA + 24, tooltip);
            Helpers.SendCommand(Commands.CMD_NativeMenu_set_item_tooltip__23__2__4__r0);
            Helpers.WaitForCompletion();
        }

        public void set_item_state(ulong rid, long idx, long state)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, idx);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, state);
            Helpers.SendCommand(Commands.CMD_NativeMenu_set_item_state__23__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public void set_item_max_states(ulong rid, long idx, long max_states)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, idx);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, max_states);
            Helpers.SendCommand(Commands.CMD_NativeMenu_set_item_max_states__23__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public void set_item_icon(ulong rid, long idx, ulong icon)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, idx);
            Helpers.WriteUInt64(Commands.CMD_DATA + 24, icon);
            Helpers.SendCommand(Commands.CMD_NativeMenu_set_item_icon__23__2__24__r0);
            Helpers.WaitForCompletion();
        }

        public void set_item_indentation_level(ulong rid, long idx, long level)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, idx);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, level);
            Helpers.SendCommand(Commands.CMD_NativeMenu_set_item_indentation_level__23__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_item_count(ulong rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.SendCommand(Commands.CMD_NativeMenu_get_item_count__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool is_system_menu(ulong rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.SendCommand(Commands.CMD_NativeMenu_is_system_menu__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void remove_item(ulong rid, long idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, idx);
            Helpers.SendCommand(Commands.CMD_NativeMenu_remove_item__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void clear(ulong rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.SendCommand(Commands.CMD_NativeMenu_clear__23__r0);
            Helpers.WaitForCompletion();
        }

        public void free()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_NativeMenu_free__r0);
            Helpers.WaitForCompletion();
        }

        public void _init()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_NativeMenu__init__r0);
            Helpers.WaitForCompletion();
        }

        public string _to_string()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_NativeMenu__to_string__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void _notification(long what)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, what);
            Helpers.SendCommand(Commands.CMD_NativeMenu__notification__2__r0);
            Helpers.WaitForCompletion();
        }

        public bool _set(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_NativeMenu__set__21__0__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _get(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_NativeMenu__get__21__r0);
            Helpers.WaitForCompletion();
        }

        public object _get_property_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_NativeMenu__get_property_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void _validate_property(object property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDictionary(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_NativeMenu__validate_property__27__r0);
            Helpers.WaitForCompletion();
        }

        public bool _property_can_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_NativeMenu__property_can_revert__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _property_get_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_NativeMenu__property_get_revert__21__r0);
            Helpers.WaitForCompletion();
        }

        public bool _iter_init(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteArray(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_NativeMenu__iter_init__28__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool _iter_next(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteArray(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_NativeMenu__iter_next__28__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _iter_get(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVariant(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_NativeMenu__iter_get__0__r0);
            Helpers.WaitForCompletion();
        }

        public string get_class()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_NativeMenu_get_class__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public bool is_class(string class_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, class_);
            Helpers.SendCommand(Commands.CMD_NativeMenu_is_class__4__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_NativeMenu_set__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_NativeMenu_get__21__r0);
            Helpers.WaitForCompletion();
        }

        public void set_indexed(string property_path, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, property_path);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_NativeMenu_set_indexed__22__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get_indexed(string property_path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, property_path);
            Helpers.SendCommand(Commands.CMD_NativeMenu_get_indexed__22__r0);
            Helpers.WaitForCompletion();
        }

        public object get_property_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_NativeMenu_get_property_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_method_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_NativeMenu_get_method_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public bool property_can_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_NativeMenu_property_can_revert__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void property_get_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_NativeMenu_property_get_revert__21__r0);
            Helpers.WaitForCompletion();
        }

        public void notification(long what, bool reversed)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, what);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, reversed ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_NativeMenu_notification__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public string to_string()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_NativeMenu_to_string__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public ulong get_instance_id()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_NativeMenu_get_instance_id__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_script(object script)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVariant(Commands.CMD_DATA + 8, script);
            Helpers.SendCommand(Commands.CMD_NativeMenu_set_script__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get_script()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_NativeMenu_get_script__r0);
            Helpers.WaitForCompletion();
        }

        public void set_meta(string name, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_NativeMenu_set_meta__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void remove_meta(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_NativeMenu_remove_meta__21__r0);
            Helpers.WaitForCompletion();
        }

        public void get_meta(string name, object default_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, default_);
            Helpers.SendCommand(Commands.CMD_NativeMenu_get_meta__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_meta(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_NativeMenu_has_meta__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public object get_meta_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_NativeMenu_get_meta_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void add_user_signal(string signal, object arguments)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, signal);
            Helpers.WriteArray(Commands.CMD_DATA + 1036, arguments);
            Helpers.SendCommand(Commands.CMD_NativeMenu_add_user_signal__4__28__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_user_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_NativeMenu_has_user_signal__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void remove_user_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_NativeMenu_remove_user_signal__21__r0);
            Helpers.WaitForCompletion();
        }

        public long emit_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_NativeMenu_emit_signal__21__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void call(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_NativeMenu_call__21__r0);
            Helpers.WaitForCompletion();
        }

        public void call_deferred(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_NativeMenu_call_deferred__21__r0);
            Helpers.WaitForCompletion();
        }

        public void set_deferred(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_NativeMenu_set_deferred__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void callv(string method, object arg_array)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.WriteArray(Commands.CMD_DATA + 1036, arg_array);
            Helpers.SendCommand(Commands.CMD_NativeMenu_callv__21__28__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_method(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_NativeMenu_has_method__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public long get_method_argument_count(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_NativeMenu_get_method_argument_count__21__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool has_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_NativeMenu_has_signal__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public object get_signal_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_NativeMenu_get_signal_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_signal_connection_list(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_NativeMenu_get_signal_connection_list__21__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_incoming_connections()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_NativeMenu_get_incoming_connections__r28);
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
            Helpers.SendCommand(Commands.CMD_NativeMenu_connect__21__25__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void disconnect(string signal, object callable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.WriteCallable(Commands.CMD_DATA + 1036, callable);
            Helpers.SendCommand(Commands.CMD_NativeMenu_disconnect__21__25__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_connected(string signal, object callable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.WriteCallable(Commands.CMD_DATA + 1036, callable);
            Helpers.SendCommand(Commands.CMD_NativeMenu_is_connected__21__25__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool has_connections(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_NativeMenu_has_connections__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_block_signals(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_NativeMenu_set_block_signals__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_blocking_signals()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_NativeMenu_is_blocking_signals__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void notify_property_list_changed()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_NativeMenu_notify_property_list_changed__r0);
            Helpers.WaitForCompletion();
        }

        public void set_message_translation(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_NativeMenu_set_message_translation__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool can_translate_messages()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_NativeMenu_can_translate_messages__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public string tr(string message, string context)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, message);
            Helpers.WriteStringName(Commands.CMD_DATA + 1036, context);
            Helpers.SendCommand(Commands.CMD_NativeMenu_tr__21__21__r4);
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
            Helpers.SendCommand(Commands.CMD_NativeMenu_tr_n__21__21__2__21__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public string get_translation_domain()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_NativeMenu_get_translation_domain__r21);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadStringName(Commands.CMD_DATA);
            return result;
        }

        public void set_translation_domain(string domain)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, domain);
            Helpers.SendCommand(Commands.CMD_NativeMenu_set_translation_domain__21__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_queued_for_deletion()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_NativeMenu_is_queued_for_deletion__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void cancel_free()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_NativeMenu_cancel_free__r0);
            Helpers.WaitForCompletion();
        }

        public ulong get_singleton()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_NativeMenu_get_singleton__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

    }
}
