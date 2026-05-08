#include "headers/bridge_helpers.h"
void handle_EngineDebugger(uint32_t cmd, volatile uint8_t *payload, volatile uint32_t *cmd_ptr, volatile uint8_t *status_ptr) {
    switch (cmd) {
        case CMD_EngineDebugger_is_active__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("EngineDebugger", "is_active");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_EngineDebugger_register_profiler__21__24__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName name = read_string_name(payload, 8);
            ObjectID profiler = read_object_id(payload, 1036);
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "register_profiler");
            if (bind) {
                Variant args[2];
                args[0] = name;
                args[1] = profiler;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_EngineDebugger_unregister_profiler__21__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName name = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "unregister_profiler");
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

        case CMD_EngineDebugger_is_profiling__21__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName name = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "is_profiling");
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

        case CMD_EngineDebugger_has_profiler__21__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName name = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "has_profiler");
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

        case CMD_EngineDebugger_profiler_add_frame_data__21__28__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName name = read_string_name(payload, 8);
            Array arg_data = read_array(payload, 1036);
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "profiler_add_frame_data");
            if (bind) {
                Variant args[2];
                args[0] = name;
                args[1] = arg_data;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_EngineDebugger_profiler_enable__21__1__28__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName name = read_string_name(payload, 8);
            bool enable = (read_int32(payload, 1036) != 0);
            Array arguments = read_array(payload, 1040);
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "profiler_enable");
            if (bind) {
                Variant args[3];
                args[0] = name;
                args[1] = enable;
                args[2] = arguments;
                const Variant *argptrs[3];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 3, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_EngineDebugger_register_message_capture__21__25__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName name = read_string_name(payload, 8);
            Callable callable = read_callable(payload, 1036);
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "register_message_capture");
            if (bind) {
                Variant args[2];
                args[0] = name;
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

        case CMD_EngineDebugger_unregister_message_capture__21__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName name = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "unregister_message_capture");
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

        case CMD_EngineDebugger_has_capture__21__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName name = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "has_capture");
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

        case CMD_EngineDebugger_line_poll__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("EngineDebugger", "line_poll");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_EngineDebugger_send_message__4__28__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            String message = read_string_from_data(payload + 8);
            Array arg_data = read_array(payload, 1036);
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "send_message");
            if (bind) {
                Variant args[2];
                args[0] = message;
                args[1] = arg_data;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_EngineDebugger_debug__1__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            bool can_continue = (read_int32(payload, 8) != 0);
            bool is_error_breakpoint = (read_int32(payload, 12) != 0);
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "debug");
            if (bind) {
                Variant args[2];
                args[0] = can_continue;
                args[1] = is_error_breakpoint;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_EngineDebugger_script_debug__24__1__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            ObjectID language = read_object_id(payload, 8);
            bool can_continue = (read_int32(payload, 16) != 0);
            bool is_error_breakpoint = (read_int32(payload, 20) != 0);
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "script_debug");
            if (bind) {
                Variant args[3];
                args[0] = language;
                args[1] = can_continue;
                args[2] = is_error_breakpoint;
                const Variant *argptrs[3];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 3, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_EngineDebugger_set_lines_left__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t lines = read_int64(payload, 8);
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "set_lines_left");
            if (bind) {
                Variant args[1];
                args[0] = lines;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_EngineDebugger_get_lines_left__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("EngineDebugger", "get_lines_left");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_EngineDebugger_set_depth__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t depth = read_int64(payload, 8);
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "set_depth");
            if (bind) {
                Variant args[1];
                args[0] = depth;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_EngineDebugger_get_depth__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("EngineDebugger", "get_depth");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_EngineDebugger_is_breakpoint__2__21__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t line = read_int64(payload, 8);
            StringName source = read_string_name(payload, 16);
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "is_breakpoint");
            if (bind) {
                Variant args[2];
                args[0] = line;
                args[1] = source;
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

        case CMD_EngineDebugger_is_skipping_breakpoints__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("EngineDebugger", "is_skipping_breakpoints");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_EngineDebugger_insert_breakpoint__2__21__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t line = read_int64(payload, 8);
            StringName source = read_string_name(payload, 16);
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "insert_breakpoint");
            if (bind) {
                Variant args[2];
                args[0] = line;
                args[1] = source;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_EngineDebugger_remove_breakpoint__2__21__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t line = read_int64(payload, 8);
            StringName source = read_string_name(payload, 16);
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "remove_breakpoint");
            if (bind) {
                Variant args[2];
                args[0] = line;
                args[1] = source;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_EngineDebugger_clear_breakpoints__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("EngineDebugger", "clear_breakpoints");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_EngineDebugger_free__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("EngineDebugger", "free");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_EngineDebugger__init__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("EngineDebugger", "_init");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_EngineDebugger__to_string__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("EngineDebugger", "_to_string");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_EngineDebugger__notification__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t what = read_int64(payload, 8);
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "_notification");
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

        case CMD_EngineDebugger__set__21__0__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName property = read_string_name(payload, 8);
            Variant value;
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "_set");
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

        case CMD_EngineDebugger__get__21__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName property = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "_get");
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

        case CMD_EngineDebugger__get_property_list__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("EngineDebugger", "_get_property_list");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_EngineDebugger__validate_property__27__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            Dictionary property = read_dictionary(payload, 8);
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "_validate_property");
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

        case CMD_EngineDebugger__property_can_revert__21__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName property = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "_property_can_revert");
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

        case CMD_EngineDebugger__property_get_revert__21__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName property = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "_property_get_revert");
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

        case CMD_EngineDebugger__iter_init__28__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            Array iter = read_array(payload, 8);
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "_iter_init");
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

        case CMD_EngineDebugger__iter_next__28__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            Array iter = read_array(payload, 8);
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "_iter_next");
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

        case CMD_EngineDebugger__iter_get__0__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            Variant iter;
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "_iter_get");
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

        case CMD_EngineDebugger_get_class__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("EngineDebugger", "get_class");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_EngineDebugger_is_class__4__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            String class_ = read_string_from_data(payload + 8);
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "is_class");
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

        case CMD_EngineDebugger_set__21__0__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName property = read_string_name(payload, 8);
            Variant value;
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "set");
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

        case CMD_EngineDebugger_get__21__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName property = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "get");
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

        case CMD_EngineDebugger_set_indexed__22__0__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            NodePath property_path = read_node_path(payload, 8);
            Variant value;
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "set_indexed");
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

        case CMD_EngineDebugger_get_indexed__22__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            NodePath property_path = read_node_path(payload, 8);
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "get_indexed");
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

        case CMD_EngineDebugger_get_property_list__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("EngineDebugger", "get_property_list");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_EngineDebugger_get_method_list__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("EngineDebugger", "get_method_list");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_EngineDebugger_property_can_revert__21__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName property = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "property_can_revert");
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

        case CMD_EngineDebugger_property_get_revert__21__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName property = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "property_get_revert");
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

        case CMD_EngineDebugger_notification__2__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t what = read_int64(payload, 8);
            bool reversed = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "notification");
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

        case CMD_EngineDebugger_to_string__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("EngineDebugger", "to_string");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_EngineDebugger_get_instance_id__r24: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("EngineDebugger", "get_instance_id");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
                write_object_id(payload, 0, ret_value.operator ObjectID());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_EngineDebugger_set_script__0__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            Variant script;
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "set_script");
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

        case CMD_EngineDebugger_get_script__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("EngineDebugger", "get_script");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_EngineDebugger_set_meta__21__0__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName name = read_string_name(payload, 8);
            Variant value;
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "set_meta");
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

        case CMD_EngineDebugger_remove_meta__21__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName name = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "remove_meta");
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

        case CMD_EngineDebugger_get_meta__21__0__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName name = read_string_name(payload, 8);
            Variant default_;
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "get_meta");
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

        case CMD_EngineDebugger_has_meta__21__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName name = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "has_meta");
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

        case CMD_EngineDebugger_get_meta_list__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("EngineDebugger", "get_meta_list");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_EngineDebugger_add_user_signal__4__28__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            String signal = read_string_from_data(payload + 8);
            Array arguments = read_array(payload, 1036);
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "add_user_signal");
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

        case CMD_EngineDebugger_has_user_signal__21__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName signal = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "has_user_signal");
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

        case CMD_EngineDebugger_remove_user_signal__21__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName signal = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "remove_user_signal");
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

        case CMD_EngineDebugger_emit_signal__21__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName signal = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "emit_signal");
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

        case CMD_EngineDebugger_call__21__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName method = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "call");
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

        case CMD_EngineDebugger_call_deferred__21__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName method = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "call_deferred");
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

        case CMD_EngineDebugger_set_deferred__21__0__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName property = read_string_name(payload, 8);
            Variant value;
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "set_deferred");
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

        case CMD_EngineDebugger_callv__21__28__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName method = read_string_name(payload, 8);
            Array arg_array = read_array(payload, 1036);
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "callv");
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

        case CMD_EngineDebugger_has_method__21__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName method = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "has_method");
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

        case CMD_EngineDebugger_get_method_argument_count__21__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName method = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "get_method_argument_count");
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

        case CMD_EngineDebugger_has_signal__21__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName signal = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "has_signal");
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

        case CMD_EngineDebugger_get_signal_list__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("EngineDebugger", "get_signal_list");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_EngineDebugger_get_signal_connection_list__21__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName signal = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "get_signal_connection_list");
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

        case CMD_EngineDebugger_get_incoming_connections__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("EngineDebugger", "get_incoming_connections");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_EngineDebugger_connect__21__25__2__r2: {
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
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "connect");
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

        case CMD_EngineDebugger_disconnect__21__25__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName signal = read_string_name(payload, 8);
            Callable callable = read_callable(payload, 1036);
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "disconnect");
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

        case CMD_EngineDebugger_is_connected__21__25__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName signal = read_string_name(payload, 8);
            Callable callable = read_callable(payload, 1036);
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "is_connected");
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

        case CMD_EngineDebugger_has_connections__21__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName signal = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "has_connections");
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

        case CMD_EngineDebugger_set_block_signals__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            bool enable = (read_int32(payload, 8) != 0);
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "set_block_signals");
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

        case CMD_EngineDebugger_is_blocking_signals__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("EngineDebugger", "is_blocking_signals");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_EngineDebugger_notify_property_list_changed__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("EngineDebugger", "notify_property_list_changed");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_EngineDebugger_set_message_translation__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            bool enable = (read_int32(payload, 8) != 0);
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "set_message_translation");
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

        case CMD_EngineDebugger_can_translate_messages__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("EngineDebugger", "can_translate_messages");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_EngineDebugger_tr__21__21__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName message = read_string_name(payload, 8);
            StringName context = read_string_name(payload, 1036);
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "tr");
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

        case CMD_EngineDebugger_tr_n__21__21__2__21__r4: {
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
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "tr_n");
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

        case CMD_EngineDebugger_get_translation_domain__r21: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("EngineDebugger", "get_translation_domain");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_EngineDebugger_set_translation_domain__21__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName domain = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("EngineDebugger", "set_translation_domain");
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

        case CMD_EngineDebugger_is_queued_for_deletion__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("EngineDebugger", "is_queued_for_deletion");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_EngineDebugger_cancel_free__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("EngineDebugger", "cancel_free");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_EngineDebugger_get_singleton__r24: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("EngineDebugger", "get_singleton");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
                write_object_id(payload, 0, ret_value.operator ObjectID());
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
