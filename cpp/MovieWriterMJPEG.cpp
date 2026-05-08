#include "headers/bridge_helpers.h"
void handle_MovieWriterMJPEG(uint32_t cmd, volatile uint8_t *payload, volatile uint32_t *cmd_ptr, volatile uint8_t *status_ptr) {
    switch (cmd) {
        case CMD_MovieWriterMJPEG__get_audio_mix_rate__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "_get_audio_mix_rate");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_MovieWriterMJPEG__get_audio_speaker_mode__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "_get_audio_speaker_mode");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_MovieWriterMJPEG__handles_file__4__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            String path = read_string_from_data(payload + 8);
            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "_handles_file");
            if (bind) {
                Variant args[1];
                args[0] = path;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_MovieWriterMJPEG__get_supported_extensions__r34: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "_get_supported_extensions");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_MovieWriterMJPEG__write_begin__6__2__4__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            Vector2i movie_size = read_vector2i(payload, 8);
            int64_t fps = read_int64(payload, 16);
            String base_path = read_string_from_data(payload + 24);
            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "_write_begin");
            if (bind) {
                Variant args[3];
                args[0] = movie_size;
                args[1] = fps;
                args[2] = base_path;
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

        case CMD_MovieWriterMJPEG__write_frame__24__2__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            ObjectID frame_image = read_object_id(payload, 8);
            int64_t audio_frame_block = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "_write_frame");
            if (bind) {
                Variant args[2];
                args[0] = frame_image;
                args[1] = audio_frame_block;
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

        case CMD_MovieWriterMJPEG__write_end__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "_write_end");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_MovieWriterMJPEG_add_writer__24__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            ObjectID writer = read_object_id(payload, 8);
            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "add_writer");
            if (bind) {
                Variant args[1];
                args[0] = writer;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_MovieWriterMJPEG_free__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "free");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_MovieWriterMJPEG__init__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "_init");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_MovieWriterMJPEG__to_string__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "_to_string");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_MovieWriterMJPEG__notification__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t what = read_int64(payload, 8);
            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "_notification");
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

        case CMD_MovieWriterMJPEG__set__21__0__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName property = read_string_name(payload, 8);
            Variant value;
            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "_set");
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

        case CMD_MovieWriterMJPEG__get__21__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName property = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "_get");
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

        case CMD_MovieWriterMJPEG__get_property_list__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "_get_property_list");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_MovieWriterMJPEG__validate_property__27__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            Dictionary property = read_dictionary(payload, 8);
            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "_validate_property");
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

        case CMD_MovieWriterMJPEG__property_can_revert__21__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName property = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "_property_can_revert");
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

        case CMD_MovieWriterMJPEG__property_get_revert__21__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName property = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "_property_get_revert");
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

        case CMD_MovieWriterMJPEG__iter_init__28__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            Array iter = read_array(payload, 8);
            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "_iter_init");
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

        case CMD_MovieWriterMJPEG__iter_next__28__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            Array iter = read_array(payload, 8);
            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "_iter_next");
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

        case CMD_MovieWriterMJPEG__iter_get__0__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            Variant iter;
            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "_iter_get");
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

        case CMD_MovieWriterMJPEG_get_class__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "get_class");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_MovieWriterMJPEG_is_class__4__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            String class_ = read_string_from_data(payload + 8);
            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "is_class");
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

        case CMD_MovieWriterMJPEG_set__21__0__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName property = read_string_name(payload, 8);
            Variant value;
            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "set");
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

        case CMD_MovieWriterMJPEG_get__21__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName property = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "get");
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

        case CMD_MovieWriterMJPEG_set_indexed__22__0__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            NodePath property_path = read_node_path(payload, 8);
            Variant value;
            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "set_indexed");
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

        case CMD_MovieWriterMJPEG_get_indexed__22__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            NodePath property_path = read_node_path(payload, 8);
            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "get_indexed");
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

        case CMD_MovieWriterMJPEG_get_property_list__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "get_property_list");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_MovieWriterMJPEG_get_method_list__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "get_method_list");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_MovieWriterMJPEG_property_can_revert__21__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName property = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "property_can_revert");
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

        case CMD_MovieWriterMJPEG_property_get_revert__21__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName property = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "property_get_revert");
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

        case CMD_MovieWriterMJPEG_notification__2__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t what = read_int64(payload, 8);
            bool reversed = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "notification");
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

        case CMD_MovieWriterMJPEG_to_string__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "to_string");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_MovieWriterMJPEG_get_instance_id__r24: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "get_instance_id");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
                write_object_id(payload, 0, ret_value.operator ObjectID());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_MovieWriterMJPEG_set_script__0__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            Variant script;
            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "set_script");
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

        case CMD_MovieWriterMJPEG_get_script__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "get_script");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_MovieWriterMJPEG_set_meta__21__0__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName name = read_string_name(payload, 8);
            Variant value;
            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "set_meta");
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

        case CMD_MovieWriterMJPEG_remove_meta__21__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName name = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "remove_meta");
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

        case CMD_MovieWriterMJPEG_get_meta__21__0__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName name = read_string_name(payload, 8);
            Variant default_;
            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "get_meta");
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

        case CMD_MovieWriterMJPEG_has_meta__21__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName name = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "has_meta");
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

        case CMD_MovieWriterMJPEG_get_meta_list__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "get_meta_list");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_MovieWriterMJPEG_add_user_signal__4__28__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            String signal = read_string_from_data(payload + 8);
            Array arguments = read_array(payload, 1036);
            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "add_user_signal");
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

        case CMD_MovieWriterMJPEG_has_user_signal__21__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName signal = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "has_user_signal");
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

        case CMD_MovieWriterMJPEG_remove_user_signal__21__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName signal = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "remove_user_signal");
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

        case CMD_MovieWriterMJPEG_emit_signal__21__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName signal = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "emit_signal");
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

        case CMD_MovieWriterMJPEG_call__21__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName method = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "call");
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

        case CMD_MovieWriterMJPEG_call_deferred__21__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName method = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "call_deferred");
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

        case CMD_MovieWriterMJPEG_set_deferred__21__0__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName property = read_string_name(payload, 8);
            Variant value;
            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "set_deferred");
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

        case CMD_MovieWriterMJPEG_callv__21__28__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName method = read_string_name(payload, 8);
            Array arg_array = read_array(payload, 1036);
            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "callv");
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

        case CMD_MovieWriterMJPEG_has_method__21__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName method = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "has_method");
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

        case CMD_MovieWriterMJPEG_get_method_argument_count__21__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName method = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "get_method_argument_count");
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

        case CMD_MovieWriterMJPEG_has_signal__21__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName signal = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "has_signal");
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

        case CMD_MovieWriterMJPEG_get_signal_list__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "get_signal_list");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_MovieWriterMJPEG_get_signal_connection_list__21__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName signal = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "get_signal_connection_list");
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

        case CMD_MovieWriterMJPEG_get_incoming_connections__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "get_incoming_connections");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_MovieWriterMJPEG_connect__21__25__2__r2: {
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
            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "connect");
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

        case CMD_MovieWriterMJPEG_disconnect__21__25__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName signal = read_string_name(payload, 8);
            Callable callable = read_callable(payload, 1036);
            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "disconnect");
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

        case CMD_MovieWriterMJPEG_is_connected__21__25__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName signal = read_string_name(payload, 8);
            Callable callable = read_callable(payload, 1036);
            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "is_connected");
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

        case CMD_MovieWriterMJPEG_has_connections__21__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName signal = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "has_connections");
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

        case CMD_MovieWriterMJPEG_set_block_signals__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            bool enable = (read_int32(payload, 8) != 0);
            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "set_block_signals");
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

        case CMD_MovieWriterMJPEG_is_blocking_signals__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "is_blocking_signals");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_MovieWriterMJPEG_notify_property_list_changed__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "notify_property_list_changed");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_MovieWriterMJPEG_set_message_translation__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            bool enable = (read_int32(payload, 8) != 0);
            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "set_message_translation");
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

        case CMD_MovieWriterMJPEG_can_translate_messages__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "can_translate_messages");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_MovieWriterMJPEG_tr__21__21__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName message = read_string_name(payload, 8);
            StringName context = read_string_name(payload, 1036);
            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "tr");
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

        case CMD_MovieWriterMJPEG_tr_n__21__21__2__21__r4: {
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
            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "tr_n");
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

        case CMD_MovieWriterMJPEG_get_translation_domain__r21: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "get_translation_domain");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_MovieWriterMJPEG_set_translation_domain__21__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName domain = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "set_translation_domain");
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

        case CMD_MovieWriterMJPEG_is_queued_for_deletion__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "is_queued_for_deletion");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_MovieWriterMJPEG_cancel_free__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("MovieWriterMJPEG", "cancel_free");
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
