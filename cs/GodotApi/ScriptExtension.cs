using System;

namespace GodotWeb
{
    public class ScriptExtension : GodotObject
    {
        public ScriptExtension(ulong id) : base(id) { }

        public bool _editor_can_reload_from_file()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension__editor_can_reload_from_file__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _placeholder_erased(long placeholder)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, placeholder);
            Helpers.SendCommand(Commands.CMD_ScriptExtension__placeholder_erased__2__r0);
            Helpers.WaitForCompletion();
        }

        public bool _can_instantiate()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension__can_instantiate__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public ulong _get_base_script()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension__get_base_script__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public string _get_global_name()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension__get_global_name__r21);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadStringName(Commands.CMD_DATA);
            return result;
        }

        public bool _inherits_script(ulong script)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, script);
            Helpers.SendCommand(Commands.CMD_ScriptExtension__inherits_script__24__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public string _get_instance_base_type()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension__get_instance_base_type__r21);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadStringName(Commands.CMD_DATA);
            return result;
        }

        public long _instance_create(ulong for_object)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, for_object);
            Helpers.SendCommand(Commands.CMD_ScriptExtension__instance_create__24__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long _placeholder_instance_create(ulong for_object)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, for_object);
            Helpers.SendCommand(Commands.CMD_ScriptExtension__placeholder_instance_create__24__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool _instance_has(ulong object_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, object_);
            Helpers.SendCommand(Commands.CMD_ScriptExtension__instance_has__24__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool _has_source_code()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension__has_source_code__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public string _get_source_code()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension__get_source_code__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void _set_source_code(string code)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, code);
            Helpers.SendCommand(Commands.CMD_ScriptExtension__set_source_code__4__r0);
            Helpers.WaitForCompletion();
        }

        public long _reload(bool keep_state)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, keep_state ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScriptExtension__reload__1__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public string _get_doc_class_name()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension__get_doc_class_name__r21);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadStringName(Commands.CMD_DATA);
            return result;
        }

        public object _get_documentation()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension__get_documentation__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public string _get_class_icon_path()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension__get_class_icon_path__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public bool _has_method(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_ScriptExtension__has_method__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool _has_static_method(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_ScriptExtension__has_static_method__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _get_script_method_argument_count(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_ScriptExtension__get_script_method_argument_count__21__r0);
            Helpers.WaitForCompletion();
        }

        public object _get_method_info(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_ScriptExtension__get_method_info__21__r27);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadDictionary(Commands.CMD_DATA);
            return result;
        }

        public bool _is_tool()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension__is_tool__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool _is_valid()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension__is_valid__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool _is_abstract()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension__is_abstract__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public ulong _get_language()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension__get_language__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public bool _has_script_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_ScriptExtension__has_script_signal__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public object _get_script_signal_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension__get_script_signal_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public bool _has_property_default_value(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_ScriptExtension__has_property_default_value__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _get_property_default_value(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_ScriptExtension__get_property_default_value__21__r0);
            Helpers.WaitForCompletion();
        }

        public void _update_exports()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension__update_exports__r0);
            Helpers.WaitForCompletion();
        }

        public object _get_script_method_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension__get_script_method_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object _get_script_property_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension__get_script_property_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public long _get_member_line(string member)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, member);
            Helpers.SendCommand(Commands.CMD_ScriptExtension__get_member_line__21__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public object _get_constants()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension__get_constants__r27);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadDictionary(Commands.CMD_DATA);
            return result;
        }

        public object _get_members()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension__get_members__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public bool _is_placeholder_fallback_enabled()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension__is_placeholder_fallback_enabled__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _get_rpc_config()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension__get_rpc_config__r0);
            Helpers.WaitForCompletion();
        }

        public bool can_instantiate()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_can_instantiate__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool instance_has(ulong base_object)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, base_object);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_instance_has__24__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool has_source_code()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_has_source_code__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public string get_source_code()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_get_source_code__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void set_source_code(string source)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, source);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_set_source_code__4__r0);
            Helpers.WaitForCompletion();
        }

        public long reload(bool keep_state)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, keep_state ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_reload__1__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong get_base_script()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_get_base_script__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public string get_instance_base_type()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_get_instance_base_type__r21);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadStringName(Commands.CMD_DATA);
            return result;
        }

        public string get_global_name()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_get_global_name__r21);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadStringName(Commands.CMD_DATA);
            return result;
        }

        public bool has_script_signal(string signal_name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal_name);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_has_script_signal__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public object get_script_property_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_get_script_property_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_script_method_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_get_script_method_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_script_signal_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_get_script_signal_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_script_constant_map()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_get_script_constant_map__r27);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadDictionary(Commands.CMD_DATA);
            return result;
        }

        public void get_property_default_value(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_get_property_default_value__21__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_tool()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_is_tool__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool is_abstract()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_is_abstract__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void get_rpc_config()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_get_rpc_config__r0);
            Helpers.WaitForCompletion();
        }

        public void _setup_local_to_scene()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension__setup_local_to_scene__r0);
            Helpers.WaitForCompletion();
        }

        public ulong _get_rid()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension__get_rid__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void _reset_state()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension__reset_state__r0);
            Helpers.WaitForCompletion();
        }

        public void _set_path_cache(string path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, path);
            Helpers.SendCommand(Commands.CMD_ScriptExtension__set_path_cache__4__r0);
            Helpers.WaitForCompletion();
        }

        public void set_path(string path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, path);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_set_path__4__r0);
            Helpers.WaitForCompletion();
        }

        public void take_over_path(string path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, path);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_take_over_path__4__r0);
            Helpers.WaitForCompletion();
        }

        public string get_path()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_get_path__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void set_path_cache(string path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, path);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_set_path_cache__4__r0);
            Helpers.WaitForCompletion();
        }

        public void set_name(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_set_name__4__r0);
            Helpers.WaitForCompletion();
        }

        public string get_name()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_get_name__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public ulong get_rid()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_get_rid__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void set_local_to_scene(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_set_local_to_scene__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_local_to_scene()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_is_local_to_scene__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public ulong get_local_scene()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_get_local_scene__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void setup_local_to_scene()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_setup_local_to_scene__r0);
            Helpers.WaitForCompletion();
        }

        public void reset_state()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_reset_state__r0);
            Helpers.WaitForCompletion();
        }

        public void set_id_for_path(string path, string id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, path);
            Helpers.WriteString(Commands.CMD_DATA + 1036, id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_set_id_for_path__4__4__r0);
            Helpers.WaitForCompletion();
        }

        public string get_id_for_path(string path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, path);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_get_id_for_path__4__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public bool is_built_in()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_is_built_in__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public string generate_scene_unique_id()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_generate_scene_unique_id__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void set_scene_unique_id(string id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_set_scene_unique_id__4__r0);
            Helpers.WaitForCompletion();
        }

        public string get_scene_unique_id()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_get_scene_unique_id__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void emit_changed()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_emit_changed__r0);
            Helpers.WaitForCompletion();
        }

        public ulong duplicate(bool deep)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, deep ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_duplicate__1__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong duplicate_deep(long deep_subresources_mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, deep_subresources_mode);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_duplicate_deep__2__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public bool init_ref()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_init_ref__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool reference()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_reference__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool unreference()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_unreference__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public long get_reference_count()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_get_reference_count__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void free()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_free__r0);
            Helpers.WaitForCompletion();
        }

        public void _init()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension__init__r0);
            Helpers.WaitForCompletion();
        }

        public string _to_string()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension__to_string__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void _notification(long what)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, what);
            Helpers.SendCommand(Commands.CMD_ScriptExtension__notification__2__r0);
            Helpers.WaitForCompletion();
        }

        public bool _set(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_ScriptExtension__set__21__0__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _get(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_ScriptExtension__get__21__r0);
            Helpers.WaitForCompletion();
        }

        public object _get_property_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension__get_property_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void _validate_property(object property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDictionary(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_ScriptExtension__validate_property__27__r0);
            Helpers.WaitForCompletion();
        }

        public bool _property_can_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_ScriptExtension__property_can_revert__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _property_get_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_ScriptExtension__property_get_revert__21__r0);
            Helpers.WaitForCompletion();
        }

        public bool _iter_init(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteArray(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_ScriptExtension__iter_init__28__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool _iter_next(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteArray(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_ScriptExtension__iter_next__28__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _iter_get(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVariant(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_ScriptExtension__iter_get__0__r0);
            Helpers.WaitForCompletion();
        }

        public string get_class()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_get_class__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public bool is_class(string class_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, class_);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_is_class__4__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_set__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_get__21__r0);
            Helpers.WaitForCompletion();
        }

        public void set_indexed(string property_path, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, property_path);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_set_indexed__22__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get_indexed(string property_path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, property_path);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_get_indexed__22__r0);
            Helpers.WaitForCompletion();
        }

        public object get_property_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_get_property_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_method_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_get_method_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public bool property_can_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_property_can_revert__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void property_get_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_property_get_revert__21__r0);
            Helpers.WaitForCompletion();
        }

        public void notification(long what, bool reversed)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, what);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, reversed ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_notification__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public string to_string()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_to_string__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public ulong get_instance_id()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_get_instance_id__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_script(object script)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVariant(Commands.CMD_DATA + 8, script);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_set_script__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get_script()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_get_script__r0);
            Helpers.WaitForCompletion();
        }

        public void set_meta(string name, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_set_meta__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void remove_meta(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_remove_meta__21__r0);
            Helpers.WaitForCompletion();
        }

        public void get_meta(string name, object default_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, default_);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_get_meta__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_meta(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_has_meta__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public object get_meta_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_get_meta_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void add_user_signal(string signal, object arguments)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, signal);
            Helpers.WriteArray(Commands.CMD_DATA + 1036, arguments);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_add_user_signal__4__28__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_user_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_has_user_signal__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void remove_user_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_remove_user_signal__21__r0);
            Helpers.WaitForCompletion();
        }

        public long emit_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_emit_signal__21__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void call(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_call__21__r0);
            Helpers.WaitForCompletion();
        }

        public void call_deferred(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_call_deferred__21__r0);
            Helpers.WaitForCompletion();
        }

        public void set_deferred(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_set_deferred__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void callv(string method, object arg_array)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.WriteArray(Commands.CMD_DATA + 1036, arg_array);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_callv__21__28__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_method(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_has_method__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public long get_method_argument_count(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_get_method_argument_count__21__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool has_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_has_signal__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public object get_signal_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_get_signal_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_signal_connection_list(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_get_signal_connection_list__21__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_incoming_connections()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_get_incoming_connections__r28);
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
            Helpers.SendCommand(Commands.CMD_ScriptExtension_connect__21__25__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void disconnect(string signal, object callable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.WriteCallable(Commands.CMD_DATA + 1036, callable);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_disconnect__21__25__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_connected(string signal, object callable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.WriteCallable(Commands.CMD_DATA + 1036, callable);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_is_connected__21__25__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool has_connections(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_has_connections__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_block_signals(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_set_block_signals__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_blocking_signals()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_is_blocking_signals__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void notify_property_list_changed()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_notify_property_list_changed__r0);
            Helpers.WaitForCompletion();
        }

        public void set_message_translation(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_set_message_translation__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool can_translate_messages()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_can_translate_messages__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public string tr(string message, string context)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, message);
            Helpers.WriteStringName(Commands.CMD_DATA + 1036, context);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_tr__21__21__r4);
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
            Helpers.SendCommand(Commands.CMD_ScriptExtension_tr_n__21__21__2__21__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public string get_translation_domain()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_get_translation_domain__r21);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadStringName(Commands.CMD_DATA);
            return result;
        }

        public void set_translation_domain(string domain)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, domain);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_set_translation_domain__21__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_queued_for_deletion()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_is_queued_for_deletion__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void cancel_free()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_ScriptExtension_cancel_free__r0);
            Helpers.WaitForCompletion();
        }

    }
}
