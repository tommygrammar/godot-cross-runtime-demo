using System;

namespace GodotWeb
{
    public class DisplayServer : GodotObject
    {
        public DisplayServer(ulong id) : base(id) { }

        public bool has_feature(long feature)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, feature);
            Helpers.SendCommand(Commands.CMD_DisplayServer_has_feature__2__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public string get_name()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_get_name__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void help_set_search_callbacks(object search_callback, object action_callback)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteCallable(Commands.CMD_DATA + 8, search_callback);
            Helpers.WriteCallable(Commands.CMD_DATA + 8, action_callback);
            Helpers.SendCommand(Commands.CMD_DisplayServer_help_set_search_callbacks__25__25__r0);
            Helpers.WaitForCompletion();
        }

        public void global_menu_set_popup_callbacks(string menu_root, object open_callback, object close_callback)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, menu_root);
            Helpers.WriteCallable(Commands.CMD_DATA + 1036, open_callback);
            Helpers.WriteCallable(Commands.CMD_DATA + 1036, close_callback);
            Helpers.SendCommand(Commands.CMD_DisplayServer_global_menu_set_popup_callbacks__4__25__25__r0);
            Helpers.WaitForCompletion();
        }

        public long global_menu_add_submenu_item(string menu_root, string label, string submenu, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, menu_root);
            Helpers.WriteString(Commands.CMD_DATA + 1036, label);
            Helpers.WriteString(Commands.CMD_DATA + 2064, submenu);
            Helpers.WriteInt64(Commands.CMD_DATA + 3092, index);
            Helpers.SendCommand(Commands.CMD_DisplayServer_global_menu_add_submenu_item__4__4__4__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long global_menu_add_item(string menu_root, string label, object callback, object key_callback, object tag, long accelerator, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, menu_root);
            Helpers.WriteString(Commands.CMD_DATA + 1036, label);
            Helpers.WriteCallable(Commands.CMD_DATA + 2064, callback);
            Helpers.WriteCallable(Commands.CMD_DATA + 2064, key_callback);
            Helpers.WriteVariant(Commands.CMD_DATA + 2064, tag);
            Helpers.WriteInt64(Commands.CMD_DATA + 2064, accelerator);
            Helpers.WriteInt64(Commands.CMD_DATA + 2072, index);
            Helpers.SendCommand(Commands.CMD_DisplayServer_global_menu_add_item__4__4__25__25__0__2__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long global_menu_add_check_item(string menu_root, string label, object callback, object key_callback, object tag, long accelerator, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, menu_root);
            Helpers.WriteString(Commands.CMD_DATA + 1036, label);
            Helpers.WriteCallable(Commands.CMD_DATA + 2064, callback);
            Helpers.WriteCallable(Commands.CMD_DATA + 2064, key_callback);
            Helpers.WriteVariant(Commands.CMD_DATA + 2064, tag);
            Helpers.WriteInt64(Commands.CMD_DATA + 2064, accelerator);
            Helpers.WriteInt64(Commands.CMD_DATA + 2072, index);
            Helpers.SendCommand(Commands.CMD_DisplayServer_global_menu_add_check_item__4__4__25__25__0__2__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long global_menu_add_icon_item(string menu_root, ulong icon, string label, object callback, object key_callback, object tag, long accelerator, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, menu_root);
            Helpers.WriteUInt64(Commands.CMD_DATA + 1036, icon);
            Helpers.WriteString(Commands.CMD_DATA + 1044, label);
            Helpers.WriteCallable(Commands.CMD_DATA + 2072, callback);
            Helpers.WriteCallable(Commands.CMD_DATA + 2072, key_callback);
            Helpers.WriteVariant(Commands.CMD_DATA + 2072, tag);
            Helpers.WriteInt64(Commands.CMD_DATA + 2072, accelerator);
            Helpers.WriteInt64(Commands.CMD_DATA + 2080, index);
            Helpers.SendCommand(Commands.CMD_DisplayServer_global_menu_add_icon_item__4__24__4__25__25__0__2__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long global_menu_add_icon_check_item(string menu_root, ulong icon, string label, object callback, object key_callback, object tag, long accelerator, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, menu_root);
            Helpers.WriteUInt64(Commands.CMD_DATA + 1036, icon);
            Helpers.WriteString(Commands.CMD_DATA + 1044, label);
            Helpers.WriteCallable(Commands.CMD_DATA + 2072, callback);
            Helpers.WriteCallable(Commands.CMD_DATA + 2072, key_callback);
            Helpers.WriteVariant(Commands.CMD_DATA + 2072, tag);
            Helpers.WriteInt64(Commands.CMD_DATA + 2072, accelerator);
            Helpers.WriteInt64(Commands.CMD_DATA + 2080, index);
            Helpers.SendCommand(Commands.CMD_DisplayServer_global_menu_add_icon_check_item__4__24__4__25__25__0__2__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long global_menu_add_radio_check_item(string menu_root, string label, object callback, object key_callback, object tag, long accelerator, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, menu_root);
            Helpers.WriteString(Commands.CMD_DATA + 1036, label);
            Helpers.WriteCallable(Commands.CMD_DATA + 2064, callback);
            Helpers.WriteCallable(Commands.CMD_DATA + 2064, key_callback);
            Helpers.WriteVariant(Commands.CMD_DATA + 2064, tag);
            Helpers.WriteInt64(Commands.CMD_DATA + 2064, accelerator);
            Helpers.WriteInt64(Commands.CMD_DATA + 2072, index);
            Helpers.SendCommand(Commands.CMD_DisplayServer_global_menu_add_radio_check_item__4__4__25__25__0__2__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long global_menu_add_icon_radio_check_item(string menu_root, ulong icon, string label, object callback, object key_callback, object tag, long accelerator, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, menu_root);
            Helpers.WriteUInt64(Commands.CMD_DATA + 1036, icon);
            Helpers.WriteString(Commands.CMD_DATA + 1044, label);
            Helpers.WriteCallable(Commands.CMD_DATA + 2072, callback);
            Helpers.WriteCallable(Commands.CMD_DATA + 2072, key_callback);
            Helpers.WriteVariant(Commands.CMD_DATA + 2072, tag);
            Helpers.WriteInt64(Commands.CMD_DATA + 2072, accelerator);
            Helpers.WriteInt64(Commands.CMD_DATA + 2080, index);
            Helpers.SendCommand(Commands.CMD_DisplayServer_global_menu_add_icon_radio_check_item__4__24__4__25__25__0__2__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long global_menu_add_multistate_item(string menu_root, string label, long max_states, long default_state, object callback, object key_callback, object tag, long accelerator, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, menu_root);
            Helpers.WriteString(Commands.CMD_DATA + 1036, label);
            Helpers.WriteInt64(Commands.CMD_DATA + 2064, max_states);
            Helpers.WriteInt64(Commands.CMD_DATA + 2072, default_state);
            Helpers.WriteCallable(Commands.CMD_DATA + 2080, callback);
            Helpers.WriteCallable(Commands.CMD_DATA + 2080, key_callback);
            Helpers.WriteVariant(Commands.CMD_DATA + 2080, tag);
            Helpers.WriteInt64(Commands.CMD_DATA + 2080, accelerator);
            Helpers.WriteInt64(Commands.CMD_DATA + 2088, index);
            Helpers.SendCommand(Commands.CMD_DisplayServer_global_menu_add_multistate_item__4__4__2__2__25__25__0__2__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long global_menu_add_separator(string menu_root, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, menu_root);
            Helpers.WriteInt64(Commands.CMD_DATA + 1036, index);
            Helpers.SendCommand(Commands.CMD_DisplayServer_global_menu_add_separator__4__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long global_menu_get_item_index_from_text(string menu_root, string text)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, menu_root);
            Helpers.WriteString(Commands.CMD_DATA + 1036, text);
            Helpers.SendCommand(Commands.CMD_DisplayServer_global_menu_get_item_index_from_text__4__4__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long global_menu_get_item_index_from_tag(string menu_root, object tag)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, menu_root);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, tag);
            Helpers.SendCommand(Commands.CMD_DisplayServer_global_menu_get_item_index_from_tag__4__0__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool global_menu_is_item_checked(string menu_root, long idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, menu_root);
            Helpers.WriteInt64(Commands.CMD_DATA + 1036, idx);
            Helpers.SendCommand(Commands.CMD_DisplayServer_global_menu_is_item_checked__4__2__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool global_menu_is_item_checkable(string menu_root, long idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, menu_root);
            Helpers.WriteInt64(Commands.CMD_DATA + 1036, idx);
            Helpers.SendCommand(Commands.CMD_DisplayServer_global_menu_is_item_checkable__4__2__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool global_menu_is_item_radio_checkable(string menu_root, long idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, menu_root);
            Helpers.WriteInt64(Commands.CMD_DATA + 1036, idx);
            Helpers.SendCommand(Commands.CMD_DisplayServer_global_menu_is_item_radio_checkable__4__2__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public object global_menu_get_item_callback(string menu_root, long idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, menu_root);
            Helpers.WriteInt64(Commands.CMD_DATA + 1036, idx);
            Helpers.SendCommand(Commands.CMD_DisplayServer_global_menu_get_item_callback__4__2__r25);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadCallable(Commands.CMD_DATA);
            return result;
        }

        public object global_menu_get_item_key_callback(string menu_root, long idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, menu_root);
            Helpers.WriteInt64(Commands.CMD_DATA + 1036, idx);
            Helpers.SendCommand(Commands.CMD_DisplayServer_global_menu_get_item_key_callback__4__2__r25);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadCallable(Commands.CMD_DATA);
            return result;
        }

        public void global_menu_get_item_tag(string menu_root, long idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, menu_root);
            Helpers.WriteInt64(Commands.CMD_DATA + 1036, idx);
            Helpers.SendCommand(Commands.CMD_DisplayServer_global_menu_get_item_tag__4__2__r0);
            Helpers.WaitForCompletion();
        }

        public string global_menu_get_item_text(string menu_root, long idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, menu_root);
            Helpers.WriteInt64(Commands.CMD_DATA + 1036, idx);
            Helpers.SendCommand(Commands.CMD_DisplayServer_global_menu_get_item_text__4__2__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public string global_menu_get_item_submenu(string menu_root, long idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, menu_root);
            Helpers.WriteInt64(Commands.CMD_DATA + 1036, idx);
            Helpers.SendCommand(Commands.CMD_DisplayServer_global_menu_get_item_submenu__4__2__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public long global_menu_get_item_accelerator(string menu_root, long idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, menu_root);
            Helpers.WriteInt64(Commands.CMD_DATA + 1036, idx);
            Helpers.SendCommand(Commands.CMD_DisplayServer_global_menu_get_item_accelerator__4__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool global_menu_is_item_disabled(string menu_root, long idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, menu_root);
            Helpers.WriteInt64(Commands.CMD_DATA + 1036, idx);
            Helpers.SendCommand(Commands.CMD_DisplayServer_global_menu_is_item_disabled__4__2__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool global_menu_is_item_hidden(string menu_root, long idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, menu_root);
            Helpers.WriteInt64(Commands.CMD_DATA + 1036, idx);
            Helpers.SendCommand(Commands.CMD_DisplayServer_global_menu_is_item_hidden__4__2__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public string global_menu_get_item_tooltip(string menu_root, long idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, menu_root);
            Helpers.WriteInt64(Commands.CMD_DATA + 1036, idx);
            Helpers.SendCommand(Commands.CMD_DisplayServer_global_menu_get_item_tooltip__4__2__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public long global_menu_get_item_state(string menu_root, long idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, menu_root);
            Helpers.WriteInt64(Commands.CMD_DATA + 1036, idx);
            Helpers.SendCommand(Commands.CMD_DisplayServer_global_menu_get_item_state__4__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long global_menu_get_item_max_states(string menu_root, long idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, menu_root);
            Helpers.WriteInt64(Commands.CMD_DATA + 1036, idx);
            Helpers.SendCommand(Commands.CMD_DisplayServer_global_menu_get_item_max_states__4__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong global_menu_get_item_icon(string menu_root, long idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, menu_root);
            Helpers.WriteInt64(Commands.CMD_DATA + 1036, idx);
            Helpers.SendCommand(Commands.CMD_DisplayServer_global_menu_get_item_icon__4__2__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public long global_menu_get_item_indentation_level(string menu_root, long idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, menu_root);
            Helpers.WriteInt64(Commands.CMD_DATA + 1036, idx);
            Helpers.SendCommand(Commands.CMD_DisplayServer_global_menu_get_item_indentation_level__4__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void global_menu_set_item_checked(string menu_root, long idx, bool checked_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, menu_root);
            Helpers.WriteInt64(Commands.CMD_DATA + 1036, idx);
            Helpers.WriteInt32(Commands.CMD_DATA + 1044, checked_ ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_DisplayServer_global_menu_set_item_checked__4__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public void global_menu_set_item_checkable(string menu_root, long idx, bool checkable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, menu_root);
            Helpers.WriteInt64(Commands.CMD_DATA + 1036, idx);
            Helpers.WriteInt32(Commands.CMD_DATA + 1044, checkable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_DisplayServer_global_menu_set_item_checkable__4__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public void global_menu_set_item_radio_checkable(string menu_root, long idx, bool checkable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, menu_root);
            Helpers.WriteInt64(Commands.CMD_DATA + 1036, idx);
            Helpers.WriteInt32(Commands.CMD_DATA + 1044, checkable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_DisplayServer_global_menu_set_item_radio_checkable__4__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public void global_menu_set_item_callback(string menu_root, long idx, object callback)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, menu_root);
            Helpers.WriteInt64(Commands.CMD_DATA + 1036, idx);
            Helpers.WriteCallable(Commands.CMD_DATA + 1044, callback);
            Helpers.SendCommand(Commands.CMD_DisplayServer_global_menu_set_item_callback__4__2__25__r0);
            Helpers.WaitForCompletion();
        }

        public void global_menu_set_item_hover_callbacks(string menu_root, long idx, object callback)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, menu_root);
            Helpers.WriteInt64(Commands.CMD_DATA + 1036, idx);
            Helpers.WriteCallable(Commands.CMD_DATA + 1044, callback);
            Helpers.SendCommand(Commands.CMD_DisplayServer_global_menu_set_item_hover_callbacks__4__2__25__r0);
            Helpers.WaitForCompletion();
        }

        public void global_menu_set_item_key_callback(string menu_root, long idx, object key_callback)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, menu_root);
            Helpers.WriteInt64(Commands.CMD_DATA + 1036, idx);
            Helpers.WriteCallable(Commands.CMD_DATA + 1044, key_callback);
            Helpers.SendCommand(Commands.CMD_DisplayServer_global_menu_set_item_key_callback__4__2__25__r0);
            Helpers.WaitForCompletion();
        }

        public void global_menu_set_item_tag(string menu_root, long idx, object tag)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, menu_root);
            Helpers.WriteInt64(Commands.CMD_DATA + 1036, idx);
            Helpers.WriteVariant(Commands.CMD_DATA + 1044, tag);
            Helpers.SendCommand(Commands.CMD_DisplayServer_global_menu_set_item_tag__4__2__0__r0);
            Helpers.WaitForCompletion();
        }

        public void global_menu_set_item_text(string menu_root, long idx, string text)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, menu_root);
            Helpers.WriteInt64(Commands.CMD_DATA + 1036, idx);
            Helpers.WriteString(Commands.CMD_DATA + 1044, text);
            Helpers.SendCommand(Commands.CMD_DisplayServer_global_menu_set_item_text__4__2__4__r0);
            Helpers.WaitForCompletion();
        }

        public void global_menu_set_item_submenu(string menu_root, long idx, string submenu)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, menu_root);
            Helpers.WriteInt64(Commands.CMD_DATA + 1036, idx);
            Helpers.WriteString(Commands.CMD_DATA + 1044, submenu);
            Helpers.SendCommand(Commands.CMD_DisplayServer_global_menu_set_item_submenu__4__2__4__r0);
            Helpers.WaitForCompletion();
        }

        public void global_menu_set_item_accelerator(string menu_root, long idx, long keycode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, menu_root);
            Helpers.WriteInt64(Commands.CMD_DATA + 1036, idx);
            Helpers.WriteInt64(Commands.CMD_DATA + 1044, keycode);
            Helpers.SendCommand(Commands.CMD_DisplayServer_global_menu_set_item_accelerator__4__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public void global_menu_set_item_disabled(string menu_root, long idx, bool disabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, menu_root);
            Helpers.WriteInt64(Commands.CMD_DATA + 1036, idx);
            Helpers.WriteInt32(Commands.CMD_DATA + 1044, disabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_DisplayServer_global_menu_set_item_disabled__4__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public void global_menu_set_item_hidden(string menu_root, long idx, bool hidden)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, menu_root);
            Helpers.WriteInt64(Commands.CMD_DATA + 1036, idx);
            Helpers.WriteInt32(Commands.CMD_DATA + 1044, hidden ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_DisplayServer_global_menu_set_item_hidden__4__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public void global_menu_set_item_tooltip(string menu_root, long idx, string tooltip)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, menu_root);
            Helpers.WriteInt64(Commands.CMD_DATA + 1036, idx);
            Helpers.WriteString(Commands.CMD_DATA + 1044, tooltip);
            Helpers.SendCommand(Commands.CMD_DisplayServer_global_menu_set_item_tooltip__4__2__4__r0);
            Helpers.WaitForCompletion();
        }

        public void global_menu_set_item_state(string menu_root, long idx, long state)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, menu_root);
            Helpers.WriteInt64(Commands.CMD_DATA + 1036, idx);
            Helpers.WriteInt64(Commands.CMD_DATA + 1044, state);
            Helpers.SendCommand(Commands.CMD_DisplayServer_global_menu_set_item_state__4__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public void global_menu_set_item_max_states(string menu_root, long idx, long max_states)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, menu_root);
            Helpers.WriteInt64(Commands.CMD_DATA + 1036, idx);
            Helpers.WriteInt64(Commands.CMD_DATA + 1044, max_states);
            Helpers.SendCommand(Commands.CMD_DisplayServer_global_menu_set_item_max_states__4__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public void global_menu_set_item_icon(string menu_root, long idx, ulong icon)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, menu_root);
            Helpers.WriteInt64(Commands.CMD_DATA + 1036, idx);
            Helpers.WriteUInt64(Commands.CMD_DATA + 1044, icon);
            Helpers.SendCommand(Commands.CMD_DisplayServer_global_menu_set_item_icon__4__2__24__r0);
            Helpers.WaitForCompletion();
        }

        public void global_menu_set_item_indentation_level(string menu_root, long idx, long level)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, menu_root);
            Helpers.WriteInt64(Commands.CMD_DATA + 1036, idx);
            Helpers.WriteInt64(Commands.CMD_DATA + 1044, level);
            Helpers.SendCommand(Commands.CMD_DisplayServer_global_menu_set_item_indentation_level__4__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public long global_menu_get_item_count(string menu_root)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, menu_root);
            Helpers.SendCommand(Commands.CMD_DisplayServer_global_menu_get_item_count__4__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void global_menu_remove_item(string menu_root, long idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, menu_root);
            Helpers.WriteInt64(Commands.CMD_DATA + 1036, idx);
            Helpers.SendCommand(Commands.CMD_DisplayServer_global_menu_remove_item__4__2__r0);
            Helpers.WaitForCompletion();
        }

        public void global_menu_clear(string menu_root)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, menu_root);
            Helpers.SendCommand(Commands.CMD_DisplayServer_global_menu_clear__4__r0);
            Helpers.WaitForCompletion();
        }

        public object global_menu_get_system_menu_roots()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_global_menu_get_system_menu_roots__r27);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadDictionary(Commands.CMD_DATA);
            return result;
        }

        public bool tts_is_speaking()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_tts_is_speaking__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool tts_is_paused()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_tts_is_paused__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public object tts_get_voices()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_tts_get_voices__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public string[] tts_get_voices_for_language(string language)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, language);
            Helpers.SendCommand(Commands.CMD_DisplayServer_tts_get_voices_for_language__4__r34);
            Helpers.WaitForCompletion();
            string[] result = Helpers.ReadPackedStringArray(Commands.CMD_DATA);
            return result;
        }

        public void tts_speak(string text, string voice, long volume, double pitch, double rate, long utterance_id, bool interrupt)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, text);
            Helpers.WriteString(Commands.CMD_DATA + 1036, voice);
            Helpers.WriteInt64(Commands.CMD_DATA + 2064, volume);
            Helpers.WriteDouble(Commands.CMD_DATA + 2072, pitch);
            Helpers.WriteDouble(Commands.CMD_DATA + 2080, rate);
            Helpers.WriteInt64(Commands.CMD_DATA + 2088, utterance_id);
            Helpers.WriteInt32(Commands.CMD_DATA + 2096, interrupt ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_DisplayServer_tts_speak__4__4__2__3__3__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public void tts_pause()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_tts_pause__r0);
            Helpers.WaitForCompletion();
        }

        public void tts_resume()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_tts_resume__r0);
            Helpers.WaitForCompletion();
        }

        public void tts_stop()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_tts_stop__r0);
            Helpers.WaitForCompletion();
        }

        public void tts_set_utterance_callback(long event_, object callable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, event_);
            Helpers.WriteCallable(Commands.CMD_DATA + 16, callable);
            Helpers.SendCommand(Commands.CMD_DisplayServer_tts_set_utterance_callback__2__25__r0);
            Helpers.WaitForCompletion();
        }

        public void _tts_post_utterance_event(long event_, long id, long char_pos)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, event_);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, id);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, char_pos);
            Helpers.SendCommand(Commands.CMD_DisplayServer__tts_post_utterance_event__2__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_dark_mode_supported()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_is_dark_mode_supported__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool is_dark_mode()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_is_dark_mode__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public Color get_accent_color()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_get_accent_color__r20);
            Helpers.WaitForCompletion();
            Color result = Helpers.ReadColor(Commands.CMD_DATA);
            return result;
        }

        public Color get_base_color()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_get_base_color__r20);
            Helpers.WaitForCompletion();
            Color result = Helpers.ReadColor(Commands.CMD_DATA);
            return result;
        }

        public void set_system_theme_change_callback(object callable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteCallable(Commands.CMD_DATA + 8, callable);
            Helpers.SendCommand(Commands.CMD_DisplayServer_set_system_theme_change_callback__25__r0);
            Helpers.WaitForCompletion();
        }

        public void mouse_set_mode(long mouse_mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, mouse_mode);
            Helpers.SendCommand(Commands.CMD_DisplayServer_mouse_set_mode__2__r0);
            Helpers.WaitForCompletion();
        }

        public long mouse_get_mode()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_mouse_get_mode__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void warp_mouse(Vector2i position)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2i(Commands.CMD_DATA + 8, position);
            Helpers.SendCommand(Commands.CMD_DisplayServer_warp_mouse__6__r0);
            Helpers.WaitForCompletion();
        }

        public Vector2i mouse_get_position()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_mouse_get_position__r6);
            Helpers.WaitForCompletion();
            Vector2i result = Helpers.ReadVector2i(Commands.CMD_DATA);
            return result;
        }

        public long mouse_get_button_state()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_mouse_get_button_state__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void clipboard_set(string clipboard)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, clipboard);
            Helpers.SendCommand(Commands.CMD_DisplayServer_clipboard_set__4__r0);
            Helpers.WaitForCompletion();
        }

        public string clipboard_get()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_clipboard_get__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public ulong clipboard_get_image()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_clipboard_get_image__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public bool clipboard_has()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_clipboard_has__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool clipboard_has_image()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_clipboard_has_image__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void clipboard_set_primary(string clipboard_primary)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, clipboard_primary);
            Helpers.SendCommand(Commands.CMD_DisplayServer_clipboard_set_primary__4__r0);
            Helpers.WaitForCompletion();
        }

        public string clipboard_get_primary()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_clipboard_get_primary__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public object get_display_cutouts()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_get_display_cutouts__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public Rect2i get_display_safe_area()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_get_display_safe_area__r8);
            Helpers.WaitForCompletion();
            Rect2i result = Helpers.ReadRect2i(Commands.CMD_DATA);
            return result;
        }

        public long get_screen_count()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_get_screen_count__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long get_primary_screen()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_get_primary_screen__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long get_keyboard_focus_screen()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_get_keyboard_focus_screen__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long get_screen_from_rect(Rect2 rect)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRect2(Commands.CMD_DATA + 8, rect);
            Helpers.SendCommand(Commands.CMD_DisplayServer_get_screen_from_rect__7__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public Vector2i screen_get_position(long screen)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, screen);
            Helpers.SendCommand(Commands.CMD_DisplayServer_screen_get_position__2__r6);
            Helpers.WaitForCompletion();
            Vector2i result = Helpers.ReadVector2i(Commands.CMD_DATA);
            return result;
        }

        public Vector2i screen_get_size(long screen)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, screen);
            Helpers.SendCommand(Commands.CMD_DisplayServer_screen_get_size__2__r6);
            Helpers.WaitForCompletion();
            Vector2i result = Helpers.ReadVector2i(Commands.CMD_DATA);
            return result;
        }

        public Rect2i screen_get_usable_rect(long screen)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, screen);
            Helpers.SendCommand(Commands.CMD_DisplayServer_screen_get_usable_rect__2__r8);
            Helpers.WaitForCompletion();
            Rect2i result = Helpers.ReadRect2i(Commands.CMD_DATA);
            return result;
        }

        public long screen_get_dpi(long screen)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, screen);
            Helpers.SendCommand(Commands.CMD_DisplayServer_screen_get_dpi__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public double screen_get_scale(long screen)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, screen);
            Helpers.SendCommand(Commands.CMD_DisplayServer_screen_get_scale__2__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public bool is_touchscreen_available()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_is_touchscreen_available__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public double screen_get_max_scale()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_screen_get_max_scale__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public double screen_get_refresh_rate(long screen)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, screen);
            Helpers.SendCommand(Commands.CMD_DisplayServer_screen_get_refresh_rate__2__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public Color screen_get_pixel(Vector2i position)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2i(Commands.CMD_DATA + 8, position);
            Helpers.SendCommand(Commands.CMD_DisplayServer_screen_get_pixel__6__r20);
            Helpers.WaitForCompletion();
            Color result = Helpers.ReadColor(Commands.CMD_DATA);
            return result;
        }

        public ulong screen_get_image(long screen)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, screen);
            Helpers.SendCommand(Commands.CMD_DisplayServer_screen_get_image__2__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong screen_get_image_rect(Rect2i rect)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRect2i(Commands.CMD_DATA + 8, rect);
            Helpers.SendCommand(Commands.CMD_DisplayServer_screen_get_image_rect__8__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void screen_set_orientation(long orientation, long screen)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, orientation);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, screen);
            Helpers.SendCommand(Commands.CMD_DisplayServer_screen_set_orientation__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public long screen_get_orientation(long screen)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, screen);
            Helpers.SendCommand(Commands.CMD_DisplayServer_screen_get_orientation__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void screen_set_keep_on(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_DisplayServer_screen_set_keep_on__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool screen_is_kept_on()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_screen_is_kept_on__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public int[] get_window_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_get_window_list__r30);
            Helpers.WaitForCompletion();
            int[] result = Helpers.ReadPackedInt32Array(Commands.CMD_DATA);
            return result;
        }

        public long get_window_at_screen_position(Vector2i position)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2i(Commands.CMD_DATA + 8, position);
            Helpers.SendCommand(Commands.CMD_DisplayServer_get_window_at_screen_position__6__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long window_get_native_handle(long handle_type, long window_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, handle_type);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, window_id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_window_get_native_handle__2__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long window_get_active_popup()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_window_get_active_popup__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void window_set_popup_safe_rect(long window, Rect2i rect)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, window);
            Helpers.WriteRect2i(Commands.CMD_DATA + 16, rect);
            Helpers.SendCommand(Commands.CMD_DisplayServer_window_set_popup_safe_rect__2__8__r0);
            Helpers.WaitForCompletion();
        }

        public Rect2i window_get_popup_safe_rect(long window)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, window);
            Helpers.SendCommand(Commands.CMD_DisplayServer_window_get_popup_safe_rect__2__r8);
            Helpers.WaitForCompletion();
            Rect2i result = Helpers.ReadRect2i(Commands.CMD_DATA);
            return result;
        }

        public void window_set_title(string title, long window_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, title);
            Helpers.WriteInt64(Commands.CMD_DATA + 1036, window_id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_window_set_title__4__2__r0);
            Helpers.WaitForCompletion();
        }

        public Vector2i window_get_title_size(string title, long window_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, title);
            Helpers.WriteInt64(Commands.CMD_DATA + 1036, window_id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_window_get_title_size__4__2__r6);
            Helpers.WaitForCompletion();
            Vector2i result = Helpers.ReadVector2i(Commands.CMD_DATA);
            return result;
        }

        public void window_set_mouse_passthrough(Vector2[] region, long window_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WritePackedVector2Array(Commands.CMD_DATA + 8, region);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, window_id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_window_set_mouse_passthrough__35__2__r0);
            Helpers.WaitForCompletion();
        }

        public long window_get_current_screen(long window_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, window_id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_window_get_current_screen__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void window_set_current_screen(long screen, long window_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, screen);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, window_id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_window_set_current_screen__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public Vector2i window_get_position(long window_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, window_id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_window_get_position__2__r6);
            Helpers.WaitForCompletion();
            Vector2i result = Helpers.ReadVector2i(Commands.CMD_DATA);
            return result;
        }

        public Vector2i window_get_position_with_decorations(long window_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, window_id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_window_get_position_with_decorations__2__r6);
            Helpers.WaitForCompletion();
            Vector2i result = Helpers.ReadVector2i(Commands.CMD_DATA);
            return result;
        }

        public void window_set_position(Vector2i position, long window_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2i(Commands.CMD_DATA + 8, position);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, window_id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_window_set_position__6__2__r0);
            Helpers.WaitForCompletion();
        }

        public Vector2i window_get_size(long window_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, window_id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_window_get_size__2__r6);
            Helpers.WaitForCompletion();
            Vector2i result = Helpers.ReadVector2i(Commands.CMD_DATA);
            return result;
        }

        public void window_set_size(Vector2i size, long window_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2i(Commands.CMD_DATA + 8, size);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, window_id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_window_set_size__6__2__r0);
            Helpers.WaitForCompletion();
        }

        public void window_set_rect_changed_callback(object callback, long window_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteCallable(Commands.CMD_DATA + 8, callback);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, window_id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_window_set_rect_changed_callback__25__2__r0);
            Helpers.WaitForCompletion();
        }

        public void window_set_window_event_callback(object callback, long window_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteCallable(Commands.CMD_DATA + 8, callback);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, window_id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_window_set_window_event_callback__25__2__r0);
            Helpers.WaitForCompletion();
        }

        public void window_set_input_event_callback(object callback, long window_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteCallable(Commands.CMD_DATA + 8, callback);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, window_id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_window_set_input_event_callback__25__2__r0);
            Helpers.WaitForCompletion();
        }

        public void window_set_input_text_callback(object callback, long window_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteCallable(Commands.CMD_DATA + 8, callback);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, window_id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_window_set_input_text_callback__25__2__r0);
            Helpers.WaitForCompletion();
        }

        public void window_set_drop_files_callback(object callback, long window_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteCallable(Commands.CMD_DATA + 8, callback);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, window_id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_window_set_drop_files_callback__25__2__r0);
            Helpers.WaitForCompletion();
        }

        public long window_get_attached_instance_id(long window_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, window_id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_window_get_attached_instance_id__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public Vector2i window_get_max_size(long window_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, window_id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_window_get_max_size__2__r6);
            Helpers.WaitForCompletion();
            Vector2i result = Helpers.ReadVector2i(Commands.CMD_DATA);
            return result;
        }

        public void window_set_max_size(Vector2i max_size, long window_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2i(Commands.CMD_DATA + 8, max_size);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, window_id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_window_set_max_size__6__2__r0);
            Helpers.WaitForCompletion();
        }

        public Vector2i window_get_min_size(long window_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, window_id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_window_get_min_size__2__r6);
            Helpers.WaitForCompletion();
            Vector2i result = Helpers.ReadVector2i(Commands.CMD_DATA);
            return result;
        }

        public void window_set_min_size(Vector2i min_size, long window_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2i(Commands.CMD_DATA + 8, min_size);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, window_id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_window_set_min_size__6__2__r0);
            Helpers.WaitForCompletion();
        }

        public Vector2i window_get_size_with_decorations(long window_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, window_id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_window_get_size_with_decorations__2__r6);
            Helpers.WaitForCompletion();
            Vector2i result = Helpers.ReadVector2i(Commands.CMD_DATA);
            return result;
        }

        public long window_get_mode(long window_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, window_id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_window_get_mode__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void window_set_mode(long mode, long window_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, mode);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, window_id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_window_set_mode__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public void window_set_flag(long flag, bool enabled, long window_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, flag);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enabled ? 1 : 0);
            Helpers.WriteInt64(Commands.CMD_DATA + 20, window_id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_window_set_flag__2__1__2__r0);
            Helpers.WaitForCompletion();
        }

        public bool window_get_flag(long flag, long window_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, flag);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, window_id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_window_get_flag__2__2__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void window_set_window_buttons_offset(Vector2i offset, long window_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2i(Commands.CMD_DATA + 8, offset);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, window_id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_window_set_window_buttons_offset__6__2__r0);
            Helpers.WaitForCompletion();
        }

        public Vector3i window_get_safe_title_margins(long window_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, window_id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_window_get_safe_title_margins__2__r10);
            Helpers.WaitForCompletion();
            Vector3i result = Helpers.ReadVector3i(Commands.CMD_DATA);
            return result;
        }

        public void window_request_attention(long window_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, window_id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_window_request_attention__2__r0);
            Helpers.WaitForCompletion();
        }

        public void window_move_to_foreground(long window_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, window_id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_window_move_to_foreground__2__r0);
            Helpers.WaitForCompletion();
        }

        public bool window_is_focused(long window_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, window_id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_window_is_focused__2__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool window_can_draw(long window_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, window_id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_window_can_draw__2__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void window_set_transient(long window_id, long parent_window_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, window_id);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, parent_window_id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_window_set_transient__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public void window_set_exclusive(long window_id, bool exclusive)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, window_id);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, exclusive ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_DisplayServer_window_set_exclusive__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public void window_set_ime_active(bool active, long window_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, active ? 1 : 0);
            Helpers.WriteInt64(Commands.CMD_DATA + 12, window_id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_window_set_ime_active__1__2__r0);
            Helpers.WaitForCompletion();
        }

        public void window_set_ime_position(Vector2i position, long window_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2i(Commands.CMD_DATA + 8, position);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, window_id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_window_set_ime_position__6__2__r0);
            Helpers.WaitForCompletion();
        }

        public void window_set_vsync_mode(long vsync_mode, long window_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, vsync_mode);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, window_id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_window_set_vsync_mode__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public long window_get_vsync_mode(long window_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, window_id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_window_get_vsync_mode__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool window_is_maximize_allowed(long window_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, window_id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_window_is_maximize_allowed__2__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool window_maximize_on_title_dbl_click()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_window_maximize_on_title_dbl_click__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool window_minimize_on_title_dbl_click()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_window_minimize_on_title_dbl_click__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void window_start_drag(long window_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, window_id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_window_start_drag__2__r0);
            Helpers.WaitForCompletion();
        }

        public void window_start_resize(long edge, long window_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, edge);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, window_id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_window_start_resize__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public void window_set_color(Color color)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteColor(Commands.CMD_DATA + 8, color);
            Helpers.SendCommand(Commands.CMD_DisplayServer_window_set_color__20__r0);
            Helpers.WaitForCompletion();
        }

        public long accessibility_should_increase_contrast()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_should_increase_contrast__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long accessibility_should_reduce_animation()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_should_reduce_animation__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long accessibility_should_reduce_transparency()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_should_reduce_transparency__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long accessibility_screen_reader_active()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_screen_reader_active__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong accessibility_create_element(long window_id, long role)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, window_id);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, role);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_create_element__2__2__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public ulong accessibility_create_sub_element(ulong parent_rid, long role, long insert_pos)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, parent_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, role);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, insert_pos);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_create_sub_element__23__2__2__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public ulong accessibility_create_sub_text_edit_elements(ulong parent_rid, ulong shaped_text, double min_height, long insert_pos, bool is_last_line)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, parent_rid);
            Helpers.WriteRID(Commands.CMD_DATA + 16, shaped_text);
            Helpers.WriteDouble(Commands.CMD_DATA + 24, min_height);
            Helpers.WriteInt64(Commands.CMD_DATA + 32, insert_pos);
            Helpers.WriteInt32(Commands.CMD_DATA + 40, is_last_line ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_create_sub_text_edit_elements__23__23__3__2__1__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public bool accessibility_has_element(ulong id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_has_element__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void accessibility_free_element(ulong id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_free_element__23__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_element_set_meta(ulong id, object meta)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteVariant(Commands.CMD_DATA + 16, meta);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_element_set_meta__23__0__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_element_get_meta(ulong id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_element_get_meta__23__r0);
            Helpers.WaitForCompletion();
        }

        public void _accessibility_update_if_active(object callback)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteCallable(Commands.CMD_DATA + 8, callback);
            Helpers.SendCommand(Commands.CMD_DisplayServer__accessibility_update_if_active__25__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_set_window_rect(long window_id, Rect2 rect_out, Rect2 rect_in)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, window_id);
            Helpers.WriteRect2(Commands.CMD_DATA + 16, rect_out);
            Helpers.WriteRect2(Commands.CMD_DATA + 32, rect_in);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_set_window_rect__2__7__7__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_set_window_focused(long window_id, bool focused)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, window_id);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, focused ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_set_window_focused__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_set_focus(ulong id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_set_focus__23__r0);
            Helpers.WaitForCompletion();
        }

        public ulong accessibility_get_window_root(long window_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, window_id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_get_window_root__2__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void accessibility_update_set_role(ulong id, long role)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, role);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_set_role__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_set_name(ulong id, string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteString(Commands.CMD_DATA + 16, name);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_set_name__23__4__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_set_extra_info(ulong id, string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteString(Commands.CMD_DATA + 16, name);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_set_extra_info__23__4__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_set_description(ulong id, string description)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteString(Commands.CMD_DATA + 16, description);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_set_description__23__4__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_set_value(ulong id, string value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteString(Commands.CMD_DATA + 16, value);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_set_value__23__4__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_set_tooltip(ulong id, string tooltip)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteString(Commands.CMD_DATA + 16, tooltip);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_set_tooltip__23__4__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_set_bounds(ulong id, Rect2 p_rect)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteRect2(Commands.CMD_DATA + 16, p_rect);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_set_bounds__23__7__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_set_transform(ulong id, Transform2D transform)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteTransform2D(Commands.CMD_DATA + 16, transform);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_set_transform__23__11__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_add_child(ulong id, ulong child_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteRID(Commands.CMD_DATA + 16, child_id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_add_child__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_add_related_controls(ulong id, ulong related_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteRID(Commands.CMD_DATA + 16, related_id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_add_related_controls__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_add_related_details(ulong id, ulong related_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteRID(Commands.CMD_DATA + 16, related_id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_add_related_details__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_add_related_described_by(ulong id, ulong related_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteRID(Commands.CMD_DATA + 16, related_id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_add_related_described_by__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_add_related_flow_to(ulong id, ulong related_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteRID(Commands.CMD_DATA + 16, related_id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_add_related_flow_to__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_add_related_labeled_by(ulong id, ulong related_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteRID(Commands.CMD_DATA + 16, related_id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_add_related_labeled_by__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_add_related_radio_group(ulong id, ulong related_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteRID(Commands.CMD_DATA + 16, related_id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_add_related_radio_group__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_set_active_descendant(ulong id, ulong other_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteRID(Commands.CMD_DATA + 16, other_id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_set_active_descendant__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_set_next_on_line(ulong id, ulong other_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteRID(Commands.CMD_DATA + 16, other_id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_set_next_on_line__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_set_previous_on_line(ulong id, ulong other_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteRID(Commands.CMD_DATA + 16, other_id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_set_previous_on_line__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_set_member_of(ulong id, ulong group_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteRID(Commands.CMD_DATA + 16, group_id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_set_member_of__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_set_in_page_link_target(ulong id, ulong other_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteRID(Commands.CMD_DATA + 16, other_id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_set_in_page_link_target__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_set_error_message(ulong id, ulong other_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteRID(Commands.CMD_DATA + 16, other_id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_set_error_message__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_set_live(ulong id, long live)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, live);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_set_live__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_add_action(ulong id, long action, object callable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, action);
            Helpers.WriteCallable(Commands.CMD_DATA + 24, callable);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_add_action__23__2__25__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_add_custom_action(ulong id, long action_id, string action_description)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, action_id);
            Helpers.WriteString(Commands.CMD_DATA + 24, action_description);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_add_custom_action__23__2__4__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_set_table_row_count(ulong id, long count)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, count);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_set_table_row_count__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_set_table_column_count(ulong id, long count)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, count);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_set_table_column_count__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_set_table_row_index(ulong id, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, index);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_set_table_row_index__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_set_table_column_index(ulong id, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, index);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_set_table_column_index__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_set_table_cell_position(ulong id, long row_index, long column_index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, row_index);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, column_index);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_set_table_cell_position__23__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_set_table_cell_span(ulong id, long row_span, long column_span)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, row_span);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, column_span);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_set_table_cell_span__23__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_set_list_item_count(ulong id, long size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, size);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_set_list_item_count__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_set_list_item_index(ulong id, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, index);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_set_list_item_index__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_set_list_item_level(ulong id, long level)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, level);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_set_list_item_level__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_set_list_item_selected(ulong id, bool selected)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, selected ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_set_list_item_selected__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_set_list_item_expanded(ulong id, bool expanded)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, expanded ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_set_list_item_expanded__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_set_popup_type(ulong id, long popup)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, popup);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_set_popup_type__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_set_checked(ulong id, bool checekd)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, checekd ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_set_checked__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_set_num_value(ulong id, double position)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, position);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_set_num_value__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_set_num_range(ulong id, double min, double max)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, min);
            Helpers.WriteDouble(Commands.CMD_DATA + 24, max);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_set_num_range__23__3__3__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_set_num_step(ulong id, double step)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, step);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_set_num_step__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_set_num_jump(ulong id, double jump)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, jump);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_set_num_jump__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_set_scroll_x(ulong id, double position)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, position);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_set_scroll_x__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_set_scroll_x_range(ulong id, double min, double max)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, min);
            Helpers.WriteDouble(Commands.CMD_DATA + 24, max);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_set_scroll_x_range__23__3__3__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_set_scroll_y(ulong id, double position)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, position);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_set_scroll_y__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_set_scroll_y_range(ulong id, double min, double max)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, min);
            Helpers.WriteDouble(Commands.CMD_DATA + 24, max);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_set_scroll_y_range__23__3__3__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_set_text_decorations(ulong id, bool underline, bool strikethrough, bool overline)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, underline ? 1 : 0);
            Helpers.WriteInt32(Commands.CMD_DATA + 20, strikethrough ? 1 : 0);
            Helpers.WriteInt32(Commands.CMD_DATA + 24, overline ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_set_text_decorations__23__1__1__1__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_set_text_align(ulong id, long align)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, align);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_set_text_align__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_set_text_selection(ulong id, ulong text_start_id, long start_char, ulong text_end_id, long end_char)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteRID(Commands.CMD_DATA + 16, text_start_id);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, start_char);
            Helpers.WriteRID(Commands.CMD_DATA + 32, text_end_id);
            Helpers.WriteInt64(Commands.CMD_DATA + 40, end_char);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_set_text_selection__23__23__2__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_set_flag(ulong id, long flag, bool value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, flag);
            Helpers.WriteInt32(Commands.CMD_DATA + 24, value ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_set_flag__23__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_set_classname(ulong id, string classname)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteString(Commands.CMD_DATA + 16, classname);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_set_classname__23__4__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_set_placeholder(ulong id, string placeholder)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteString(Commands.CMD_DATA + 16, placeholder);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_set_placeholder__23__4__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_set_language(ulong id, string language)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteString(Commands.CMD_DATA + 16, language);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_set_language__23__4__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_set_text_orientation(ulong id, bool vertical)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, vertical ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_set_text_orientation__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_set_list_orientation(ulong id, bool vertical)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, vertical ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_set_list_orientation__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_set_shortcut(ulong id, string shortcut)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteString(Commands.CMD_DATA + 16, shortcut);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_set_shortcut__23__4__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_set_url(ulong id, string url)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteString(Commands.CMD_DATA + 16, url);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_set_url__23__4__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_set_role_description(ulong id, string description)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteString(Commands.CMD_DATA + 16, description);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_set_role_description__23__4__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_set_state_description(ulong id, string description)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteString(Commands.CMD_DATA + 16, description);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_set_state_description__23__4__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_set_color_value(ulong id, Color color)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteColor(Commands.CMD_DATA + 16, color);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_set_color_value__23__20__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_set_background_color(ulong id, Color color)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteColor(Commands.CMD_DATA + 16, color);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_set_background_color__23__20__r0);
            Helpers.WaitForCompletion();
        }

        public void accessibility_update_set_foreground_color(ulong id, Color color)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, id);
            Helpers.WriteColor(Commands.CMD_DATA + 16, color);
            Helpers.SendCommand(Commands.CMD_DisplayServer_accessibility_update_set_foreground_color__23__20__r0);
            Helpers.WaitForCompletion();
        }

        public Vector2i ime_get_selection()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_ime_get_selection__r6);
            Helpers.WaitForCompletion();
            Vector2i result = Helpers.ReadVector2i(Commands.CMD_DATA);
            return result;
        }

        public string ime_get_text()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_ime_get_text__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void virtual_keyboard_show(string existing_text, Rect2 position, long type, long max_length, long cursor_start, long cursor_end)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, existing_text);
            Helpers.WriteRect2(Commands.CMD_DATA + 1036, position);
            Helpers.WriteInt64(Commands.CMD_DATA + 1052, type);
            Helpers.WriteInt64(Commands.CMD_DATA + 1060, max_length);
            Helpers.WriteInt64(Commands.CMD_DATA + 1068, cursor_start);
            Helpers.WriteInt64(Commands.CMD_DATA + 1076, cursor_end);
            Helpers.SendCommand(Commands.CMD_DisplayServer_virtual_keyboard_show__4__7__2__2__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public void virtual_keyboard_hide()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_virtual_keyboard_hide__r0);
            Helpers.WaitForCompletion();
        }

        public long virtual_keyboard_get_height()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_virtual_keyboard_get_height__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool has_hardware_keyboard()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_has_hardware_keyboard__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_hardware_keyboard_connection_change_callback(object callable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteCallable(Commands.CMD_DATA + 8, callable);
            Helpers.SendCommand(Commands.CMD_DisplayServer_set_hardware_keyboard_connection_change_callback__25__r0);
            Helpers.WaitForCompletion();
        }

        public void cursor_set_shape(long shape)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, shape);
            Helpers.SendCommand(Commands.CMD_DisplayServer_cursor_set_shape__2__r0);
            Helpers.WaitForCompletion();
        }

        public long cursor_get_shape()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_cursor_get_shape__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void cursor_set_custom_image(ulong cursor, long shape, Vector2 hotspot)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, cursor);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, shape);
            Helpers.WriteVector2(Commands.CMD_DATA + 24, hotspot);
            Helpers.SendCommand(Commands.CMD_DisplayServer_cursor_set_custom_image__24__2__5__r0);
            Helpers.WaitForCompletion();
        }

        public bool get_swap_cancel_ok()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_get_swap_cancel_ok__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void enable_for_stealing_focus(long process_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, process_id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_enable_for_stealing_focus__2__r0);
            Helpers.WaitForCompletion();
        }

        public long dialog_show(string title, string description, string[] buttons, object callback)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, title);
            Helpers.WriteString(Commands.CMD_DATA + 1036, description);
            Helpers.WritePackedStringArray(Commands.CMD_DATA + 2064, buttons);
            Helpers.WriteCallable(Commands.CMD_DATA + 2064, callback);
            Helpers.SendCommand(Commands.CMD_DisplayServer_dialog_show__4__4__34__25__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long dialog_input_text(string title, string description, string existing_text, object callback)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, title);
            Helpers.WriteString(Commands.CMD_DATA + 1036, description);
            Helpers.WriteString(Commands.CMD_DATA + 2064, existing_text);
            Helpers.WriteCallable(Commands.CMD_DATA + 3092, callback);
            Helpers.SendCommand(Commands.CMD_DisplayServer_dialog_input_text__4__4__4__25__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long file_dialog_show(string title, string current_directory, string filename, bool show_hidden, long mode, string[] filters, object callback, long parent_window_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, title);
            Helpers.WriteString(Commands.CMD_DATA + 1036, current_directory);
            Helpers.WriteString(Commands.CMD_DATA + 2064, filename);
            Helpers.WriteInt32(Commands.CMD_DATA + 3092, show_hidden ? 1 : 0);
            Helpers.WriteInt64(Commands.CMD_DATA + 3096, mode);
            Helpers.WritePackedStringArray(Commands.CMD_DATA + 3104, filters);
            Helpers.WriteCallable(Commands.CMD_DATA + 3104, callback);
            Helpers.WriteInt64(Commands.CMD_DATA + 3104, parent_window_id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_file_dialog_show__4__4__4__1__2__34__25__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long file_dialog_with_options_show(string title, string current_directory, string root, string filename, bool show_hidden, long mode, string[] filters, object options, object callback, long parent_window_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, title);
            Helpers.WriteString(Commands.CMD_DATA + 1036, current_directory);
            Helpers.WriteString(Commands.CMD_DATA + 2064, root);
            Helpers.WriteString(Commands.CMD_DATA + 3092, filename);
            Helpers.WriteInt32(Commands.CMD_DATA + 4120, show_hidden ? 1 : 0);
            Helpers.WriteInt64(Commands.CMD_DATA + 4124, mode);
            Helpers.WritePackedStringArray(Commands.CMD_DATA + 4132, filters);
            Helpers.WriteArray(Commands.CMD_DATA + 4132, options);
            Helpers.WriteCallable(Commands.CMD_DATA + 4132, callback);
            Helpers.WriteInt64(Commands.CMD_DATA + 4132, parent_window_id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_file_dialog_with_options_show__4__4__4__4__1__2__34__28__25__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void beep()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_beep__r0);
            Helpers.WaitForCompletion();
        }

        public long keyboard_get_layout_count()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_keyboard_get_layout_count__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long keyboard_get_current_layout()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_keyboard_get_current_layout__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void keyboard_set_current_layout(long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, index);
            Helpers.SendCommand(Commands.CMD_DisplayServer_keyboard_set_current_layout__2__r0);
            Helpers.WaitForCompletion();
        }

        public string keyboard_get_layout_language(long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, index);
            Helpers.SendCommand(Commands.CMD_DisplayServer_keyboard_get_layout_language__2__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public string keyboard_get_layout_name(long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, index);
            Helpers.SendCommand(Commands.CMD_DisplayServer_keyboard_get_layout_name__2__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public long keyboard_get_keycode_from_physical(long keycode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, keycode);
            Helpers.SendCommand(Commands.CMD_DisplayServer_keyboard_get_keycode_from_physical__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long keyboard_get_label_from_physical(long keycode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, keycode);
            Helpers.SendCommand(Commands.CMD_DisplayServer_keyboard_get_label_from_physical__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void show_emoji_and_symbol_picker()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_show_emoji_and_symbol_picker__r0);
            Helpers.WaitForCompletion();
        }

        public bool color_picker(object callback)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteCallable(Commands.CMD_DATA + 8, callback);
            Helpers.SendCommand(Commands.CMD_DisplayServer_color_picker__25__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void process_events()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_process_events__r0);
            Helpers.WaitForCompletion();
        }

        public void force_process_and_drop_events()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_force_process_and_drop_events__r0);
            Helpers.WaitForCompletion();
        }

        public void set_native_icon(string filename)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, filename);
            Helpers.SendCommand(Commands.CMD_DisplayServer_set_native_icon__4__r0);
            Helpers.WaitForCompletion();
        }

        public void set_icon(ulong image)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, image);
            Helpers.SendCommand(Commands.CMD_DisplayServer_set_icon__24__r0);
            Helpers.WaitForCompletion();
        }

        public long create_status_indicator(ulong icon, string tooltip, object callback)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, icon);
            Helpers.WriteString(Commands.CMD_DATA + 16, tooltip);
            Helpers.WriteCallable(Commands.CMD_DATA + 1044, callback);
            Helpers.SendCommand(Commands.CMD_DisplayServer_create_status_indicator__24__4__25__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void status_indicator_set_icon(long id, ulong icon)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 16, icon);
            Helpers.SendCommand(Commands.CMD_DisplayServer_status_indicator_set_icon__2__24__r0);
            Helpers.WaitForCompletion();
        }

        public void status_indicator_set_tooltip(long id, string tooltip)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, id);
            Helpers.WriteString(Commands.CMD_DATA + 16, tooltip);
            Helpers.SendCommand(Commands.CMD_DisplayServer_status_indicator_set_tooltip__2__4__r0);
            Helpers.WaitForCompletion();
        }

        public void status_indicator_set_menu(long id, ulong menu_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, id);
            Helpers.WriteRID(Commands.CMD_DATA + 16, menu_rid);
            Helpers.SendCommand(Commands.CMD_DisplayServer_status_indicator_set_menu__2__23__r0);
            Helpers.WaitForCompletion();
        }

        public void status_indicator_set_callback(long id, object callback)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, id);
            Helpers.WriteCallable(Commands.CMD_DATA + 16, callback);
            Helpers.SendCommand(Commands.CMD_DisplayServer_status_indicator_set_callback__2__25__r0);
            Helpers.WaitForCompletion();
        }

        public Rect2 status_indicator_get_rect(long id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_status_indicator_get_rect__2__r7);
            Helpers.WaitForCompletion();
            Rect2 result = Helpers.ReadRect2(Commands.CMD_DATA);
            return result;
        }

        public void delete_status_indicator(long id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_delete_status_indicator__2__r0);
            Helpers.WaitForCompletion();
        }

        public long tablet_get_driver_count()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_tablet_get_driver_count__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public string tablet_get_driver_name(long idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, idx);
            Helpers.SendCommand(Commands.CMD_DisplayServer_tablet_get_driver_name__2__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public string tablet_get_current_driver()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_tablet_get_current_driver__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void tablet_set_current_driver(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_DisplayServer_tablet_set_current_driver__4__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_window_transparency_available()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_is_window_transparency_available__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void register_additional_output(ulong object_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, object_);
            Helpers.SendCommand(Commands.CMD_DisplayServer_register_additional_output__24__r0);
            Helpers.WaitForCompletion();
        }

        public void unregister_additional_output(ulong object_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, object_);
            Helpers.SendCommand(Commands.CMD_DisplayServer_unregister_additional_output__24__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_additional_outputs()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_has_additional_outputs__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void free()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_free__r0);
            Helpers.WaitForCompletion();
        }

        public void _init()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer__init__r0);
            Helpers.WaitForCompletion();
        }

        public string _to_string()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer__to_string__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void _notification(long what)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, what);
            Helpers.SendCommand(Commands.CMD_DisplayServer__notification__2__r0);
            Helpers.WaitForCompletion();
        }

        public bool _set(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_DisplayServer__set__21__0__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _get(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_DisplayServer__get__21__r0);
            Helpers.WaitForCompletion();
        }

        public object _get_property_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer__get_property_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void _validate_property(object property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDictionary(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_DisplayServer__validate_property__27__r0);
            Helpers.WaitForCompletion();
        }

        public bool _property_can_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_DisplayServer__property_can_revert__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _property_get_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_DisplayServer__property_get_revert__21__r0);
            Helpers.WaitForCompletion();
        }

        public bool _iter_init(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteArray(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_DisplayServer__iter_init__28__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool _iter_next(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteArray(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_DisplayServer__iter_next__28__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _iter_get(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVariant(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_DisplayServer__iter_get__0__r0);
            Helpers.WaitForCompletion();
        }

        public string get_class()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_get_class__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public bool is_class(string class_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, class_);
            Helpers.SendCommand(Commands.CMD_DisplayServer_is_class__4__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_DisplayServer_set__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_DisplayServer_get__21__r0);
            Helpers.WaitForCompletion();
        }

        public void set_indexed(string property_path, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, property_path);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_DisplayServer_set_indexed__22__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get_indexed(string property_path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, property_path);
            Helpers.SendCommand(Commands.CMD_DisplayServer_get_indexed__22__r0);
            Helpers.WaitForCompletion();
        }

        public object get_property_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_get_property_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_method_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_get_method_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public bool property_can_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_DisplayServer_property_can_revert__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void property_get_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_DisplayServer_property_get_revert__21__r0);
            Helpers.WaitForCompletion();
        }

        public void notification(long what, bool reversed)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, what);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, reversed ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_DisplayServer_notification__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public string to_string()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_to_string__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public ulong get_instance_id()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_get_instance_id__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_script(object script)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVariant(Commands.CMD_DATA + 8, script);
            Helpers.SendCommand(Commands.CMD_DisplayServer_set_script__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get_script()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_get_script__r0);
            Helpers.WaitForCompletion();
        }

        public void set_meta(string name, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_DisplayServer_set_meta__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void remove_meta(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_DisplayServer_remove_meta__21__r0);
            Helpers.WaitForCompletion();
        }

        public void get_meta(string name, object default_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, default_);
            Helpers.SendCommand(Commands.CMD_DisplayServer_get_meta__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_meta(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_DisplayServer_has_meta__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public object get_meta_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_get_meta_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void add_user_signal(string signal, object arguments)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, signal);
            Helpers.WriteArray(Commands.CMD_DATA + 1036, arguments);
            Helpers.SendCommand(Commands.CMD_DisplayServer_add_user_signal__4__28__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_user_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_DisplayServer_has_user_signal__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void remove_user_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_DisplayServer_remove_user_signal__21__r0);
            Helpers.WaitForCompletion();
        }

        public long emit_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_DisplayServer_emit_signal__21__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void call(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_DisplayServer_call__21__r0);
            Helpers.WaitForCompletion();
        }

        public void call_deferred(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_DisplayServer_call_deferred__21__r0);
            Helpers.WaitForCompletion();
        }

        public void set_deferred(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_DisplayServer_set_deferred__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void callv(string method, object arg_array)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.WriteArray(Commands.CMD_DATA + 1036, arg_array);
            Helpers.SendCommand(Commands.CMD_DisplayServer_callv__21__28__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_method(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_DisplayServer_has_method__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public long get_method_argument_count(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_DisplayServer_get_method_argument_count__21__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool has_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_DisplayServer_has_signal__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public object get_signal_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_get_signal_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_signal_connection_list(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_DisplayServer_get_signal_connection_list__21__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_incoming_connections()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_get_incoming_connections__r28);
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
            Helpers.SendCommand(Commands.CMD_DisplayServer_connect__21__25__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void disconnect(string signal, object callable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.WriteCallable(Commands.CMD_DATA + 1036, callable);
            Helpers.SendCommand(Commands.CMD_DisplayServer_disconnect__21__25__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_connected(string signal, object callable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.WriteCallable(Commands.CMD_DATA + 1036, callable);
            Helpers.SendCommand(Commands.CMD_DisplayServer_is_connected__21__25__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool has_connections(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_DisplayServer_has_connections__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_block_signals(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_DisplayServer_set_block_signals__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_blocking_signals()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_is_blocking_signals__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void notify_property_list_changed()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_notify_property_list_changed__r0);
            Helpers.WaitForCompletion();
        }

        public void set_message_translation(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_DisplayServer_set_message_translation__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool can_translate_messages()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_can_translate_messages__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public string tr(string message, string context)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, message);
            Helpers.WriteStringName(Commands.CMD_DATA + 1036, context);
            Helpers.SendCommand(Commands.CMD_DisplayServer_tr__21__21__r4);
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
            Helpers.SendCommand(Commands.CMD_DisplayServer_tr_n__21__21__2__21__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public string get_translation_domain()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_get_translation_domain__r21);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadStringName(Commands.CMD_DATA);
            return result;
        }

        public void set_translation_domain(string domain)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, domain);
            Helpers.SendCommand(Commands.CMD_DisplayServer_set_translation_domain__21__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_queued_for_deletion()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_is_queued_for_deletion__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void cancel_free()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_cancel_free__r0);
            Helpers.WaitForCompletion();
        }

        public ulong get_singleton()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_DisplayServer_get_singleton__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

    }
}
