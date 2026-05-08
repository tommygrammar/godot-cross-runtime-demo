#include "headers/bridge_helpers.h"
void handle_ScriptLanguageExtension(uint32_t cmd, volatile uint8_t *payload, volatile uint32_t *cmd_ptr, volatile uint8_t *status_ptr) {
    switch (cmd) {
        case CMD_ScriptLanguageExtension__get_name__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_get_name");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__init__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_init");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__get_type__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_get_type");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__get_extension__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_get_extension");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__finish__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_finish");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__get_reserved_words__r34: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_get_reserved_words");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__is_control_flow_keyword__4__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            String keyword = read_string_from_data(payload + 8);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_is_control_flow_keyword");
            if (bind) {
                Variant args[1];
                args[0] = keyword;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__get_comment_delimiters__r34: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_get_comment_delimiters");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__get_doc_comment_delimiters__r34: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_get_doc_comment_delimiters");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__get_string_delimiters__r34: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_get_string_delimiters");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__make_template__4__4__4__r24: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            String template_ = read_string_from_data(payload + 8);
            String class_name = read_string_from_data(payload + 1036);
            String base_class_name = read_string_from_data(payload + 2064);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_make_template");
            if (bind) {
                Variant args[3];
                args[0] = template_;
                args[1] = class_name;
                args[2] = base_class_name;
                const Variant *argptrs[3];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 3, error);
                write_object_id(payload, 0, ret_value.operator ObjectID());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__get_built_in_templates__21__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName object = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_get_built_in_templates");
            if (bind) {
                Variant args[1];
                args[0] = object;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__is_using_templates__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_is_using_templates");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__validate__4__4__1__1__1__1__r27: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            String script = read_string_from_data(payload + 8);
            String path = read_string_from_data(payload + 1036);
            bool validate_functions = (read_int32(payload, 2064) != 0);
            bool validate_errors = (read_int32(payload, 2068) != 0);
            bool validate_warnings = (read_int32(payload, 2072) != 0);
            bool validate_safe_lines = (read_int32(payload, 2076) != 0);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_validate");
            if (bind) {
                Variant args[6];
                args[0] = script;
                args[1] = path;
                args[2] = validate_functions;
                args[3] = validate_errors;
                args[4] = validate_warnings;
                args[5] = validate_safe_lines;
                const Variant *argptrs[6];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                argptrs[4] = &args[4];
                argptrs[5] = &args[5];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 6, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__validate_path__4__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            String path = read_string_from_data(payload + 8);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_validate_path");
            if (bind) {
                Variant args[1];
                args[0] = path;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__create_script__r24: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_create_script");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
                write_object_id(payload, 0, ret_value.operator ObjectID());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__has_named_classes__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_has_named_classes");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__supports_builtin_mode__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_supports_builtin_mode");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__supports_documentation__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_supports_documentation");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__can_inherit_from_file__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_can_inherit_from_file");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__find_function__4__4__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            String function = read_string_from_data(payload + 8);
            String code = read_string_from_data(payload + 1036);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_find_function");
            if (bind) {
                Variant args[2];
                args[0] = function;
                args[1] = code;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__make_function__4__4__34__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            String class_name = read_string_from_data(payload + 8);
            String function_name = read_string_from_data(payload + 1036);
            PackedStringArray function_args = read_packed_string_array(payload, 2064);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_make_function");
            if (bind) {
                Variant args[3];
                args[0] = class_name;
                args[1] = function_name;
                args[2] = function_args;
                const Variant *argptrs[3];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 3, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__can_make_function__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_can_make_function");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__open_in_external_editor__24__2__2__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            ObjectID script = read_object_id(payload, 8);
            int64_t line = read_int64(payload, 16);
            int64_t column = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_open_in_external_editor");
            if (bind) {
                Variant args[3];
                args[0] = script;
                args[1] = line;
                args[2] = column;
                const Variant *argptrs[3];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 3, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__overrides_external_editor__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_overrides_external_editor");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__preferred_file_name_casing__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_preferred_file_name_casing");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__complete_code__4__4__24__r27: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            String code = read_string_from_data(payload + 8);
            String path = read_string_from_data(payload + 1036);
            ObjectID owner = read_object_id(payload, 2064);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_complete_code");
            if (bind) {
                Variant args[3];
                args[0] = code;
                args[1] = path;
                args[2] = owner;
                const Variant *argptrs[3];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 3, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__lookup_code__4__4__4__24__r27: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            String code = read_string_from_data(payload + 8);
            String symbol = read_string_from_data(payload + 1036);
            String path = read_string_from_data(payload + 2064);
            ObjectID owner = read_object_id(payload, 3092);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_lookup_code");
            if (bind) {
                Variant args[4];
                args[0] = code;
                args[1] = symbol;
                args[2] = path;
                args[3] = owner;
                const Variant *argptrs[4];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 4, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__auto_indent_code__4__2__2__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            String code = read_string_from_data(payload + 8);
            int64_t from_line = read_int64(payload, 1036);
            int64_t to_line = read_int64(payload, 1044);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_auto_indent_code");
            if (bind) {
                Variant args[3];
                args[0] = code;
                args[1] = from_line;
                args[2] = to_line;
                const Variant *argptrs[3];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 3, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__add_global_constant__21__0__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName name = read_string_name(payload, 8);
            Variant value;
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_add_global_constant");
            if (bind) {
                Variant args[2];
                args[0] = name;
                args[1] = value;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__add_named_global_constant__21__0__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName name = read_string_name(payload, 8);
            Variant value;
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_add_named_global_constant");
            if (bind) {
                Variant args[2];
                args[0] = name;
                args[1] = value;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__remove_named_global_constant__21__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName name = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_remove_named_global_constant");
            if (bind) {
                Variant args[1];
                args[0] = name;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__thread_enter__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_thread_enter");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__thread_exit__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_thread_exit");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__debug_get_error__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_debug_get_error");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__debug_get_stack_level_count__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_debug_get_stack_level_count");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__debug_get_stack_level_line__2__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t level = read_int64(payload, 8);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_debug_get_stack_level_line");
            if (bind) {
                Variant args[1];
                args[0] = level;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__debug_get_stack_level_function__2__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t level = read_int64(payload, 8);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_debug_get_stack_level_function");
            if (bind) {
                Variant args[1];
                args[0] = level;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__debug_get_stack_level_source__2__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t level = read_int64(payload, 8);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_debug_get_stack_level_source");
            if (bind) {
                Variant args[1];
                args[0] = level;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__debug_get_stack_level_locals__2__2__2__r27: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t level = read_int64(payload, 8);
            int64_t max_subitems = read_int64(payload, 16);
            int64_t max_depth = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_debug_get_stack_level_locals");
            if (bind) {
                Variant args[3];
                args[0] = level;
                args[1] = max_subitems;
                args[2] = max_depth;
                const Variant *argptrs[3];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 3, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__debug_get_stack_level_members__2__2__2__r27: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t level = read_int64(payload, 8);
            int64_t max_subitems = read_int64(payload, 16);
            int64_t max_depth = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_debug_get_stack_level_members");
            if (bind) {
                Variant args[3];
                args[0] = level;
                args[1] = max_subitems;
                args[2] = max_depth;
                const Variant *argptrs[3];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 3, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__debug_get_stack_level_instance__2__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t level = read_int64(payload, 8);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_debug_get_stack_level_instance");
            if (bind) {
                Variant args[1];
                args[0] = level;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__debug_get_globals__2__2__r27: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t max_subitems = read_int64(payload, 8);
            int64_t max_depth = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_debug_get_globals");
            if (bind) {
                Variant args[2];
                args[0] = max_subitems;
                args[1] = max_depth;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__debug_parse_stack_level_expression__2__4__2__2__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t level = read_int64(payload, 8);
            String expression = read_string_from_data(payload + 16);
            int64_t max_subitems = read_int64(payload, 1044);
            int64_t max_depth = read_int64(payload, 1052);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_debug_parse_stack_level_expression");
            if (bind) {
                Variant args[4];
                args[0] = level;
                args[1] = expression;
                args[2] = max_subitems;
                args[3] = max_depth;
                const Variant *argptrs[4];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 4, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__debug_get_current_stack_info__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_debug_get_current_stack_info");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__reload_all_scripts__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_reload_all_scripts");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__reload_scripts__28__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            Array scripts = read_array(payload, 8);
            bool soft_reload = (read_int32(payload, 8) != 0);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_reload_scripts");
            if (bind) {
                Variant args[2];
                args[0] = scripts;
                args[1] = soft_reload;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__reload_tool_script__24__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            ObjectID script = read_object_id(payload, 8);
            bool soft_reload = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_reload_tool_script");
            if (bind) {
                Variant args[2];
                args[0] = script;
                args[1] = soft_reload;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__get_recognized_extensions__r34: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_get_recognized_extensions");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__get_public_functions__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_get_public_functions");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__get_public_constants__r27: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_get_public_constants");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__get_public_annotations__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_get_public_annotations");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__profiling_start__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_profiling_start");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__profiling_stop__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_profiling_stop");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__profiling_set_save_native_calls__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            bool enable = (read_int32(payload, 8) != 0);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_profiling_set_save_native_calls");
            if (bind) {
                Variant args[1];
                args[0] = enable;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__profiling_get_accumulated_data__2__2__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t info_array = read_int64(payload, 8);
            int64_t info_max = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_profiling_get_accumulated_data");
            if (bind) {
                Variant args[2];
                args[0] = info_array;
                args[1] = info_max;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__profiling_get_frame_data__2__2__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t info_array = read_int64(payload, 8);
            int64_t info_max = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_profiling_get_frame_data");
            if (bind) {
                Variant args[2];
                args[0] = info_array;
                args[1] = info_max;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__frame__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_frame");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__handles_global_class_type__4__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            String type = read_string_from_data(payload + 8);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_handles_global_class_type");
            if (bind) {
                Variant args[1];
                args[0] = type;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__get_global_class_name__4__r27: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            String path = read_string_from_data(payload + 8);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_get_global_class_name");
            if (bind) {
                Variant args[1];
                args[0] = path;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension_free__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "free");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__to_string__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_to_string");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__notification__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t what = read_int64(payload, 8);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_notification");
            if (bind) {
                Variant args[1];
                args[0] = what;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__set__21__0__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName property = read_string_name(payload, 8);
            Variant value;
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_set");
            if (bind) {
                Variant args[2];
                args[0] = property;
                args[1] = value;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__get__21__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName property = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_get");
            if (bind) {
                Variant args[1];
                args[0] = property;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__get_property_list__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_get_property_list");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__validate_property__27__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            Dictionary property = read_dictionary(payload, 8);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_validate_property");
            if (bind) {
                Variant args[1];
                args[0] = property;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__property_can_revert__21__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName property = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_property_can_revert");
            if (bind) {
                Variant args[1];
                args[0] = property;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__property_get_revert__21__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName property = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_property_get_revert");
            if (bind) {
                Variant args[1];
                args[0] = property;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__iter_init__28__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            Array iter = read_array(payload, 8);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_iter_init");
            if (bind) {
                Variant args[1];
                args[0] = iter;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__iter_next__28__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            Array iter = read_array(payload, 8);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_iter_next");
            if (bind) {
                Variant args[1];
                args[0] = iter;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension__iter_get__0__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            Variant iter;
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "_iter_get");
            if (bind) {
                Variant args[1];
                args[0] = iter;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension_get_class__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "get_class");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension_is_class__4__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            String class_ = read_string_from_data(payload + 8);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "is_class");
            if (bind) {
                Variant args[1];
                args[0] = class_;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension_set__21__0__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName property = read_string_name(payload, 8);
            Variant value;
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "set");
            if (bind) {
                Variant args[2];
                args[0] = property;
                args[1] = value;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension_get__21__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName property = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "get");
            if (bind) {
                Variant args[1];
                args[0] = property;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension_set_indexed__22__0__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            NodePath property_path = read_node_path(payload, 8);
            Variant value;
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "set_indexed");
            if (bind) {
                Variant args[2];
                args[0] = property_path;
                args[1] = value;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension_get_indexed__22__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            NodePath property_path = read_node_path(payload, 8);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "get_indexed");
            if (bind) {
                Variant args[1];
                args[0] = property_path;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension_get_property_list__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "get_property_list");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension_get_method_list__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "get_method_list");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension_property_can_revert__21__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName property = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "property_can_revert");
            if (bind) {
                Variant args[1];
                args[0] = property;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension_property_get_revert__21__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName property = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "property_get_revert");
            if (bind) {
                Variant args[1];
                args[0] = property;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension_notification__2__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t what = read_int64(payload, 8);
            bool reversed = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "notification");
            if (bind) {
                Variant args[2];
                args[0] = what;
                args[1] = reversed;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension_to_string__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "to_string");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension_get_instance_id__r24: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "get_instance_id");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
                write_object_id(payload, 0, ret_value.operator ObjectID());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension_set_script__0__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            Variant script;
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "set_script");
            if (bind) {
                Variant args[1];
                args[0] = script;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension_get_script__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "get_script");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension_set_meta__21__0__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName name = read_string_name(payload, 8);
            Variant value;
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "set_meta");
            if (bind) {
                Variant args[2];
                args[0] = name;
                args[1] = value;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension_remove_meta__21__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName name = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "remove_meta");
            if (bind) {
                Variant args[1];
                args[0] = name;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension_get_meta__21__0__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName name = read_string_name(payload, 8);
            Variant default_;
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "get_meta");
            if (bind) {
                Variant args[2];
                args[0] = name;
                args[1] = default_;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension_has_meta__21__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName name = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "has_meta");
            if (bind) {
                Variant args[1];
                args[0] = name;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension_get_meta_list__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "get_meta_list");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension_add_user_signal__4__28__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            String signal = read_string_from_data(payload + 8);
            Array arguments = read_array(payload, 1036);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "add_user_signal");
            if (bind) {
                Variant args[2];
                args[0] = signal;
                args[1] = arguments;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension_has_user_signal__21__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName signal = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "has_user_signal");
            if (bind) {
                Variant args[1];
                args[0] = signal;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension_remove_user_signal__21__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName signal = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "remove_user_signal");
            if (bind) {
                Variant args[1];
                args[0] = signal;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension_emit_signal__21__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName signal = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "emit_signal");
            if (bind) {
                Variant args[1];
                args[0] = signal;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension_call__21__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName method = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "call");
            if (bind) {
                Variant args[1];
                args[0] = method;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension_call_deferred__21__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName method = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "call_deferred");
            if (bind) {
                Variant args[1];
                args[0] = method;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension_set_deferred__21__0__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName property = read_string_name(payload, 8);
            Variant value;
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "set_deferred");
            if (bind) {
                Variant args[2];
                args[0] = property;
                args[1] = value;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension_callv__21__28__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName method = read_string_name(payload, 8);
            Array arg_array = read_array(payload, 1036);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "callv");
            if (bind) {
                Variant args[2];
                args[0] = method;
                args[1] = arg_array;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension_has_method__21__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName method = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "has_method");
            if (bind) {
                Variant args[1];
                args[0] = method;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension_get_method_argument_count__21__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName method = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "get_method_argument_count");
            if (bind) {
                Variant args[1];
                args[0] = method;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension_has_signal__21__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName signal = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "has_signal");
            if (bind) {
                Variant args[1];
                args[0] = signal;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension_get_signal_list__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "get_signal_list");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension_get_signal_connection_list__21__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName signal = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "get_signal_connection_list");
            if (bind) {
                Variant args[1];
                args[0] = signal;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension_get_incoming_connections__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "get_incoming_connections");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension_connect__21__25__2__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName signal = read_string_name(payload, 8);
            Callable callable = read_callable(payload, 1036);
            int64_t flags = read_int64(payload, 1036);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "connect");
            if (bind) {
                Variant args[3];
                args[0] = signal;
                args[1] = callable;
                args[2] = flags;
                const Variant *argptrs[3];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 3, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension_disconnect__21__25__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName signal = read_string_name(payload, 8);
            Callable callable = read_callable(payload, 1036);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "disconnect");
            if (bind) {
                Variant args[2];
                args[0] = signal;
                args[1] = callable;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension_is_connected__21__25__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName signal = read_string_name(payload, 8);
            Callable callable = read_callable(payload, 1036);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "is_connected");
            if (bind) {
                Variant args[2];
                args[0] = signal;
                args[1] = callable;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension_has_connections__21__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName signal = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "has_connections");
            if (bind) {
                Variant args[1];
                args[0] = signal;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension_set_block_signals__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            bool enable = (read_int32(payload, 8) != 0);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "set_block_signals");
            if (bind) {
                Variant args[1];
                args[0] = enable;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension_is_blocking_signals__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "is_blocking_signals");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension_notify_property_list_changed__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "notify_property_list_changed");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension_set_message_translation__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            bool enable = (read_int32(payload, 8) != 0);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "set_message_translation");
            if (bind) {
                Variant args[1];
                args[0] = enable;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension_can_translate_messages__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "can_translate_messages");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension_tr__21__21__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName message = read_string_name(payload, 8);
            StringName context = read_string_name(payload, 1036);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "tr");
            if (bind) {
                Variant args[2];
                args[0] = message;
                args[1] = context;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension_tr_n__21__21__2__21__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName message = read_string_name(payload, 8);
            StringName plural_message = read_string_name(payload, 1036);
            int64_t n = read_int64(payload, 2064);
            StringName context = read_string_name(payload, 2072);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "tr_n");
            if (bind) {
                Variant args[4];
                args[0] = message;
                args[1] = plural_message;
                args[2] = n;
                args[3] = context;
                const Variant *argptrs[4];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 4, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension_get_translation_domain__r21: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "get_translation_domain");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension_set_translation_domain__21__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName domain = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "set_translation_domain");
            if (bind) {
                Variant args[1];
                args[0] = domain;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension_is_queued_for_deletion__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "is_queued_for_deletion");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_ScriptLanguageExtension_cancel_free__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("ScriptLanguageExtension", "cancel_free");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        default: {
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;
    }
}
