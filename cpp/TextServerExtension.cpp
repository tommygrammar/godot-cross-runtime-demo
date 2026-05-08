#include "headers/bridge_helpers.h"
void handle_TextServerExtension(uint32_t cmd, volatile uint8_t *payload, volatile uint32_t *cmd_ptr, volatile uint8_t *status_ptr) {
    switch (cmd) {
        case CMD_TextServerExtension__has_feature__2__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t feature = read_int64(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_has_feature");
            if (bind) {
                Variant args[1];
                args[0] = feature;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__get_name__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_get_name");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__get_features__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_get_features");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__free_rid__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_free_rid");
            if (bind) {
                Variant args[1];
                args[0] = rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__has__23__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_has");
            if (bind) {
                Variant args[1];
                args[0] = rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__load_support_data__4__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            String filename = read_string_from_data(payload + 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_load_support_data");
            if (bind) {
                Variant args[1];
                args[0] = filename;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__get_support_data_filename__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_get_support_data_filename");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__get_support_data_info__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_get_support_data_info");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__save_support_data__4__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            String filename = read_string_from_data(payload + 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_save_support_data");
            if (bind) {
                Variant args[1];
                args[0] = filename;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__get_support_data__r29: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_get_support_data");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__is_locale_using_support_data__4__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            String locale = read_string_from_data(payload + 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_is_locale_using_support_data");
            if (bind) {
                Variant args[1];
                args[0] = locale;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__is_locale_right_to_left__4__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            String locale = read_string_from_data(payload + 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_is_locale_right_to_left");
            if (bind) {
                Variant args[1];
                args[0] = locale;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__name_to_tag__4__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            String name = read_string_from_data(payload + 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_name_to_tag");
            if (bind) {
                Variant args[1];
                args[0] = name;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__tag_to_name__2__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t tag = read_int64(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_tag_to_name");
            if (bind) {
                Variant args[1];
                args[0] = tag;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__create_font__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_create_font");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__create_font_linked_variation__23__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_create_font_linked_variation");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_set_data__23__29__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            PackedByteArray arg_data = read_packed_byte_array(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_set_data");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
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

        case CMD_TextServerExtension__font_set_data_ptr__23__2__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t data_ptr = read_int64(payload, 16);
            int64_t data_size = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_set_data_ptr");
            if (bind) {
                Variant args[3];
                args[0] = font_rid;
                args[1] = data_ptr;
                args[2] = data_size;
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

        case CMD_TextServerExtension__font_set_face_index__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t face_index = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_set_face_index");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = face_index;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_get_face_index__23__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_get_face_index");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_get_face_count__23__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_get_face_count");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_set_style__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t style = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_set_style");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = style;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_get_style__23__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_get_style");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_set_name__23__4__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            String name = read_string_from_data(payload + 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_set_name");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = name;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_get_name__23__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_get_name");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_get_ot_name_strings__23__r27: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_get_ot_name_strings");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_set_style_name__23__4__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            String name_style = read_string_from_data(payload + 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_set_style_name");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = name_style;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_get_style_name__23__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_get_style_name");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_set_weight__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t weight = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_set_weight");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = weight;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_get_weight__23__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_get_weight");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_set_stretch__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t stretch = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_set_stretch");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = stretch;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_get_stretch__23__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_get_stretch");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_set_antialiasing__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t antialiasing = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_set_antialiasing");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = antialiasing;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_get_antialiasing__23__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_get_antialiasing");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_set_disable_embedded_bitmaps__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            bool disable_embedded_bitmaps = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_set_disable_embedded_bitmaps");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = disable_embedded_bitmaps;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_get_disable_embedded_bitmaps__23__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_get_disable_embedded_bitmaps");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_set_generate_mipmaps__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            bool generate_mipmaps = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_set_generate_mipmaps");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = generate_mipmaps;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_get_generate_mipmaps__23__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_get_generate_mipmaps");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_set_multichannel_signed_distance_field__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            bool msdf = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_set_multichannel_signed_distance_field");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = msdf;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_is_multichannel_signed_distance_field__23__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_is_multichannel_signed_distance_field");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_set_msdf_pixel_range__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t msdf_pixel_range = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_set_msdf_pixel_range");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = msdf_pixel_range;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_get_msdf_pixel_range__23__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_get_msdf_pixel_range");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_set_msdf_size__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t msdf_size = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_set_msdf_size");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = msdf_size;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_get_msdf_size__23__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_get_msdf_size");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_set_fixed_size__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t fixed_size = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_set_fixed_size");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = fixed_size;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_get_fixed_size__23__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_get_fixed_size");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_set_fixed_size_scale_mode__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t fixed_size_scale_mode = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_set_fixed_size_scale_mode");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = fixed_size_scale_mode;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_get_fixed_size_scale_mode__23__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_get_fixed_size_scale_mode");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_set_allow_system_fallback__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            bool allow_system_fallback = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_set_allow_system_fallback");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = allow_system_fallback;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_is_allow_system_fallback__23__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_is_allow_system_fallback");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_clear_system_fallback_cache__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_clear_system_fallback_cache");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_set_force_autohinter__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            bool force_autohinter = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_set_force_autohinter");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = force_autohinter;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_is_force_autohinter__23__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_is_force_autohinter");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_set_modulate_color_glyphs__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            bool modulate = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_set_modulate_color_glyphs");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = modulate;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_is_modulate_color_glyphs__23__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_is_modulate_color_glyphs");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_set_hinting__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t hinting = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_set_hinting");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = hinting;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_get_hinting__23__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_get_hinting");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_set_subpixel_positioning__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t subpixel_positioning = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_set_subpixel_positioning");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = subpixel_positioning;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_get_subpixel_positioning__23__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_get_subpixel_positioning");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_set_keep_rounding_remainders__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            bool keep_rounding_remainders = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_set_keep_rounding_remainders");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = keep_rounding_remainders;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_get_keep_rounding_remainders__23__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_get_keep_rounding_remainders");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_set_embolden__23__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            double strength = read_double(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_set_embolden");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = strength;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_get_embolden__23__r3: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_get_embolden");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_double(payload, 0, ret_value.operator double());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_set_spacing__23__2__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t spacing = read_int64(payload, 16);
            int64_t value = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_set_spacing");
            if (bind) {
                Variant args[3];
                args[0] = font_rid;
                args[1] = spacing;
                args[2] = value;
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

        case CMD_TextServerExtension__font_get_spacing__23__2__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t spacing = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_get_spacing");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = spacing;
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

        case CMD_TextServerExtension__font_set_baseline_offset__23__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            double baseline_offset = read_double(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_set_baseline_offset");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = baseline_offset;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_get_baseline_offset__23__r3: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_get_baseline_offset");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_double(payload, 0, ret_value.operator double());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_set_transform__23__11__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            Transform2D transform = read_transform2d(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_set_transform");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = transform;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_get_transform__23__r11: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_get_transform");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_set_variation_coordinates__23__27__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            Dictionary variation_coordinates = read_dictionary(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_set_variation_coordinates");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = variation_coordinates;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_get_variation_coordinates__23__r27: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_get_variation_coordinates");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_set_oversampling__23__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            double oversampling = read_double(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_set_oversampling");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = oversampling;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_get_oversampling__23__r3: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_get_oversampling");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_double(payload, 0, ret_value.operator double());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_get_size_cache_list__23__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_get_size_cache_list");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_clear_size_cache__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_clear_size_cache");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_remove_size_cache__23__6__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            Vector2i size = read_vector2i(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_remove_size_cache");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = size;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_get_size_cache_info__23__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_get_size_cache_info");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_set_ascent__23__2__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t size = read_int64(payload, 16);
            double ascent = read_double(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_set_ascent");
            if (bind) {
                Variant args[3];
                args[0] = font_rid;
                args[1] = size;
                args[2] = ascent;
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

        case CMD_TextServerExtension__font_get_ascent__23__2__r3: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t size = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_get_ascent");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = size;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
                write_double(payload, 0, ret_value.operator double());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_set_descent__23__2__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t size = read_int64(payload, 16);
            double descent = read_double(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_set_descent");
            if (bind) {
                Variant args[3];
                args[0] = font_rid;
                args[1] = size;
                args[2] = descent;
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

        case CMD_TextServerExtension__font_get_descent__23__2__r3: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t size = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_get_descent");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = size;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
                write_double(payload, 0, ret_value.operator double());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_set_underline_position__23__2__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t size = read_int64(payload, 16);
            double underline_position = read_double(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_set_underline_position");
            if (bind) {
                Variant args[3];
                args[0] = font_rid;
                args[1] = size;
                args[2] = underline_position;
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

        case CMD_TextServerExtension__font_get_underline_position__23__2__r3: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t size = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_get_underline_position");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = size;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
                write_double(payload, 0, ret_value.operator double());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_set_underline_thickness__23__2__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t size = read_int64(payload, 16);
            double underline_thickness = read_double(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_set_underline_thickness");
            if (bind) {
                Variant args[3];
                args[0] = font_rid;
                args[1] = size;
                args[2] = underline_thickness;
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

        case CMD_TextServerExtension__font_get_underline_thickness__23__2__r3: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t size = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_get_underline_thickness");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = size;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
                write_double(payload, 0, ret_value.operator double());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_set_scale__23__2__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t size = read_int64(payload, 16);
            double scale = read_double(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_set_scale");
            if (bind) {
                Variant args[3];
                args[0] = font_rid;
                args[1] = size;
                args[2] = scale;
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

        case CMD_TextServerExtension__font_get_scale__23__2__r3: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t size = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_get_scale");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = size;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
                write_double(payload, 0, ret_value.operator double());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_get_texture_count__23__6__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            Vector2i size = read_vector2i(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_get_texture_count");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = size;
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

        case CMD_TextServerExtension__font_clear_textures__23__6__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            Vector2i size = read_vector2i(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_clear_textures");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = size;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_remove_texture__23__6__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            Vector2i size = read_vector2i(payload, 16);
            int64_t texture_index = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_remove_texture");
            if (bind) {
                Variant args[3];
                args[0] = font_rid;
                args[1] = size;
                args[2] = texture_index;
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

        case CMD_TextServerExtension__font_set_texture_image__23__6__2__24__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            Vector2i size = read_vector2i(payload, 16);
            int64_t texture_index = read_int64(payload, 24);
            ObjectID image = read_object_id(payload, 32);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_set_texture_image");
            if (bind) {
                Variant args[4];
                args[0] = font_rid;
                args[1] = size;
                args[2] = texture_index;
                args[3] = image;
                const Variant *argptrs[4];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 4, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_get_texture_image__23__6__2__r24: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            Vector2i size = read_vector2i(payload, 16);
            int64_t texture_index = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_get_texture_image");
            if (bind) {
                Variant args[3];
                args[0] = font_rid;
                args[1] = size;
                args[2] = texture_index;
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

        case CMD_TextServerExtension__font_set_texture_offsets__23__6__2__30__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            Vector2i size = read_vector2i(payload, 16);
            int64_t texture_index = read_int64(payload, 24);
            PackedInt32Array offset = read_packed_int32_array(payload, 32);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_set_texture_offsets");
            if (bind) {
                Variant args[4];
                args[0] = font_rid;
                args[1] = size;
                args[2] = texture_index;
                args[3] = offset;
                const Variant *argptrs[4];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 4, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_get_texture_offsets__23__6__2__r30: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            Vector2i size = read_vector2i(payload, 16);
            int64_t texture_index = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_get_texture_offsets");
            if (bind) {
                Variant args[3];
                args[0] = font_rid;
                args[1] = size;
                args[2] = texture_index;
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

        case CMD_TextServerExtension__font_get_glyph_list__23__6__r30: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            Vector2i size = read_vector2i(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_get_glyph_list");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = size;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_clear_glyphs__23__6__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            Vector2i size = read_vector2i(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_clear_glyphs");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = size;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_remove_glyph__23__6__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            Vector2i size = read_vector2i(payload, 16);
            int64_t glyph = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_remove_glyph");
            if (bind) {
                Variant args[3];
                args[0] = font_rid;
                args[1] = size;
                args[2] = glyph;
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

        case CMD_TextServerExtension__font_get_glyph_advance__23__2__2__r5: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t size = read_int64(payload, 16);
            int64_t glyph = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_get_glyph_advance");
            if (bind) {
                Variant args[3];
                args[0] = font_rid;
                args[1] = size;
                args[2] = glyph;
                const Variant *argptrs[3];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 3, error);
                Vector2 v2 = ret_value.operator Vector2();
                write_float(payload, 0, v2.x);
                write_float(payload, 4, v2.y);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_set_glyph_advance__23__2__2__5__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t size = read_int64(payload, 16);
            int64_t glyph = read_int64(payload, 24);
            Vector2 advance = read_vector2(payload, 32);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_set_glyph_advance");
            if (bind) {
                Variant args[4];
                args[0] = font_rid;
                args[1] = size;
                args[2] = glyph;
                args[3] = advance;
                const Variant *argptrs[4];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 4, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_get_glyph_offset__23__6__2__r5: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            Vector2i size = read_vector2i(payload, 16);
            int64_t glyph = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_get_glyph_offset");
            if (bind) {
                Variant args[3];
                args[0] = font_rid;
                args[1] = size;
                args[2] = glyph;
                const Variant *argptrs[3];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 3, error);
                Vector2 v2 = ret_value.operator Vector2();
                write_float(payload, 0, v2.x);
                write_float(payload, 4, v2.y);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_set_glyph_offset__23__6__2__5__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            Vector2i size = read_vector2i(payload, 16);
            int64_t glyph = read_int64(payload, 24);
            Vector2 offset = read_vector2(payload, 32);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_set_glyph_offset");
            if (bind) {
                Variant args[4];
                args[0] = font_rid;
                args[1] = size;
                args[2] = glyph;
                args[3] = offset;
                const Variant *argptrs[4];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 4, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_get_glyph_size__23__6__2__r5: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            Vector2i size = read_vector2i(payload, 16);
            int64_t glyph = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_get_glyph_size");
            if (bind) {
                Variant args[3];
                args[0] = font_rid;
                args[1] = size;
                args[2] = glyph;
                const Variant *argptrs[3];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 3, error);
                Vector2 v2 = ret_value.operator Vector2();
                write_float(payload, 0, v2.x);
                write_float(payload, 4, v2.y);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_set_glyph_size__23__6__2__5__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            Vector2i size = read_vector2i(payload, 16);
            int64_t glyph = read_int64(payload, 24);
            Vector2 gl_size = read_vector2(payload, 32);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_set_glyph_size");
            if (bind) {
                Variant args[4];
                args[0] = font_rid;
                args[1] = size;
                args[2] = glyph;
                args[3] = gl_size;
                const Variant *argptrs[4];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 4, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_get_glyph_uv_rect__23__6__2__r7: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            Vector2i size = read_vector2i(payload, 16);
            int64_t glyph = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_get_glyph_uv_rect");
            if (bind) {
                Variant args[3];
                args[0] = font_rid;
                args[1] = size;
                args[2] = glyph;
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

        case CMD_TextServerExtension__font_set_glyph_uv_rect__23__6__2__7__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            Vector2i size = read_vector2i(payload, 16);
            int64_t glyph = read_int64(payload, 24);
            Rect2 uv_rect = read_rect2(payload, 32);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_set_glyph_uv_rect");
            if (bind) {
                Variant args[4];
                args[0] = font_rid;
                args[1] = size;
                args[2] = glyph;
                args[3] = uv_rect;
                const Variant *argptrs[4];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 4, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_get_glyph_texture_idx__23__6__2__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            Vector2i size = read_vector2i(payload, 16);
            int64_t glyph = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_get_glyph_texture_idx");
            if (bind) {
                Variant args[3];
                args[0] = font_rid;
                args[1] = size;
                args[2] = glyph;
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

        case CMD_TextServerExtension__font_set_glyph_texture_idx__23__6__2__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            Vector2i size = read_vector2i(payload, 16);
            int64_t glyph = read_int64(payload, 24);
            int64_t texture_idx = read_int64(payload, 32);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_set_glyph_texture_idx");
            if (bind) {
                Variant args[4];
                args[0] = font_rid;
                args[1] = size;
                args[2] = glyph;
                args[3] = texture_idx;
                const Variant *argptrs[4];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 4, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_get_glyph_texture_rid__23__6__2__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            Vector2i size = read_vector2i(payload, 16);
            int64_t glyph = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_get_glyph_texture_rid");
            if (bind) {
                Variant args[3];
                args[0] = font_rid;
                args[1] = size;
                args[2] = glyph;
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

        case CMD_TextServerExtension__font_get_glyph_texture_size__23__6__2__r5: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            Vector2i size = read_vector2i(payload, 16);
            int64_t glyph = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_get_glyph_texture_size");
            if (bind) {
                Variant args[3];
                args[0] = font_rid;
                args[1] = size;
                args[2] = glyph;
                const Variant *argptrs[3];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 3, error);
                Vector2 v2 = ret_value.operator Vector2();
                write_float(payload, 0, v2.x);
                write_float(payload, 4, v2.y);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_get_glyph_contours__23__2__2__r27: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t size = read_int64(payload, 16);
            int64_t index = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_get_glyph_contours");
            if (bind) {
                Variant args[3];
                args[0] = font_rid;
                args[1] = size;
                args[2] = index;
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

        case CMD_TextServerExtension__font_get_kerning_list__23__2__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t size = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_get_kerning_list");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = size;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_clear_kerning_map__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t size = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_clear_kerning_map");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = size;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_remove_kerning__23__2__6__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t size = read_int64(payload, 16);
            Vector2i glyph_pair = read_vector2i(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_remove_kerning");
            if (bind) {
                Variant args[3];
                args[0] = font_rid;
                args[1] = size;
                args[2] = glyph_pair;
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

        case CMD_TextServerExtension__font_set_kerning__23__2__6__5__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t size = read_int64(payload, 16);
            Vector2i glyph_pair = read_vector2i(payload, 24);
            Vector2 kerning = read_vector2(payload, 32);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_set_kerning");
            if (bind) {
                Variant args[4];
                args[0] = font_rid;
                args[1] = size;
                args[2] = glyph_pair;
                args[3] = kerning;
                const Variant *argptrs[4];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 4, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_get_kerning__23__2__6__r5: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t size = read_int64(payload, 16);
            Vector2i glyph_pair = read_vector2i(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_get_kerning");
            if (bind) {
                Variant args[3];
                args[0] = font_rid;
                args[1] = size;
                args[2] = glyph_pair;
                const Variant *argptrs[3];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 3, error);
                Vector2 v2 = ret_value.operator Vector2();
                write_float(payload, 0, v2.x);
                write_float(payload, 4, v2.y);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_get_glyph_index__23__2__2__2__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t size = read_int64(payload, 16);
            int64_t char_ = read_int64(payload, 24);
            int64_t variation_selector = read_int64(payload, 32);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_get_glyph_index");
            if (bind) {
                Variant args[4];
                args[0] = font_rid;
                args[1] = size;
                args[2] = char_;
                args[3] = variation_selector;
                const Variant *argptrs[4];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 4, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_get_char_from_glyph_index__23__2__2__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t size = read_int64(payload, 16);
            int64_t glyph_index = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_get_char_from_glyph_index");
            if (bind) {
                Variant args[3];
                args[0] = font_rid;
                args[1] = size;
                args[2] = glyph_index;
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

        case CMD_TextServerExtension__font_has_char__23__2__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t char_ = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_has_char");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = char_;
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

        case CMD_TextServerExtension__font_get_supported_chars__23__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_get_supported_chars");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_get_supported_glyphs__23__r30: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_get_supported_glyphs");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_render_range__23__6__2__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            Vector2i size = read_vector2i(payload, 16);
            int64_t start = read_int64(payload, 24);
            int64_t end = read_int64(payload, 32);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_render_range");
            if (bind) {
                Variant args[4];
                args[0] = font_rid;
                args[1] = size;
                args[2] = start;
                args[3] = end;
                const Variant *argptrs[4];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 4, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_render_glyph__23__6__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            Vector2i size = read_vector2i(payload, 16);
            int64_t index = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_render_glyph");
            if (bind) {
                Variant args[3];
                args[0] = font_rid;
                args[1] = size;
                args[2] = index;
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

        case CMD_TextServerExtension__font_draw_glyph__23__23__2__5__2__20__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            RID canvas = read_rid(payload, 16);
            int64_t size = read_int64(payload, 24);
            Vector2 pos = read_vector2(payload, 32);
            int64_t index = read_int64(payload, 40);
            Color color = read_color(payload, 48);
            double oversampling = read_double(payload, 64);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_draw_glyph");
            if (bind) {
                Variant args[7];
                args[0] = font_rid;
                args[1] = canvas;
                args[2] = size;
                args[3] = pos;
                args[4] = index;
                args[5] = color;
                args[6] = oversampling;
                const Variant *argptrs[7];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                argptrs[4] = &args[4];
                argptrs[5] = &args[5];
                argptrs[6] = &args[6];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 7, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_draw_glyph_outline__23__23__2__2__5__2__20__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            RID canvas = read_rid(payload, 16);
            int64_t size = read_int64(payload, 24);
            int64_t outline_size = read_int64(payload, 32);
            Vector2 pos = read_vector2(payload, 40);
            int64_t index = read_int64(payload, 48);
            Color color = read_color(payload, 56);
            double oversampling = read_double(payload, 72);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_draw_glyph_outline");
            if (bind) {
                Variant args[8];
                args[0] = font_rid;
                args[1] = canvas;
                args[2] = size;
                args[3] = outline_size;
                args[4] = pos;
                args[5] = index;
                args[6] = color;
                args[7] = oversampling;
                const Variant *argptrs[8];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                argptrs[4] = &args[4];
                argptrs[5] = &args[5];
                argptrs[6] = &args[6];
                argptrs[7] = &args[7];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 8, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_is_language_supported__23__4__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            String language = read_string_from_data(payload + 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_is_language_supported");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = language;
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

        case CMD_TextServerExtension__font_set_language_support_override__23__4__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            String language = read_string_from_data(payload + 16);
            bool supported = (read_int32(payload, 1044) != 0);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_set_language_support_override");
            if (bind) {
                Variant args[3];
                args[0] = font_rid;
                args[1] = language;
                args[2] = supported;
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

        case CMD_TextServerExtension__font_get_language_support_override__23__4__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            String language = read_string_from_data(payload + 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_get_language_support_override");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = language;
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

        case CMD_TextServerExtension__font_remove_language_support_override__23__4__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            String language = read_string_from_data(payload + 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_remove_language_support_override");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = language;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_get_language_support_overrides__23__r34: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_get_language_support_overrides");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_is_script_supported__23__4__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            String script = read_string_from_data(payload + 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_is_script_supported");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = script;
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

        case CMD_TextServerExtension__font_set_script_support_override__23__4__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            String script = read_string_from_data(payload + 16);
            bool supported = (read_int32(payload, 1044) != 0);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_set_script_support_override");
            if (bind) {
                Variant args[3];
                args[0] = font_rid;
                args[1] = script;
                args[2] = supported;
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

        case CMD_TextServerExtension__font_get_script_support_override__23__4__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            String script = read_string_from_data(payload + 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_get_script_support_override");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = script;
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

        case CMD_TextServerExtension__font_remove_script_support_override__23__4__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            String script = read_string_from_data(payload + 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_remove_script_support_override");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = script;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_get_script_support_overrides__23__r34: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_get_script_support_overrides");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_set_opentype_feature_overrides__23__27__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            Dictionary overrides = read_dictionary(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_set_opentype_feature_overrides");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = overrides;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_get_opentype_feature_overrides__23__r27: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_get_opentype_feature_overrides");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_supported_feature_list__23__r27: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_supported_feature_list");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_supported_variation_list__23__r27: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_supported_variation_list");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_get_global_oversampling__r3: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_get_global_oversampling");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
                write_double(payload, 0, ret_value.operator double());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__font_set_global_oversampling__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            double oversampling = read_double(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_font_set_global_oversampling");
            if (bind) {
                Variant args[1];
                args[0] = oversampling;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__reference_oversampling_level__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            double oversampling = read_double(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_reference_oversampling_level");
            if (bind) {
                Variant args[1];
                args[0] = oversampling;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__unreference_oversampling_level__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            double oversampling = read_double(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_unreference_oversampling_level");
            if (bind) {
                Variant args[1];
                args[0] = oversampling;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__get_hex_code_box_size__2__2__r5: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t size = read_int64(payload, 8);
            int64_t index = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_get_hex_code_box_size");
            if (bind) {
                Variant args[2];
                args[0] = size;
                args[1] = index;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
                Vector2 v2 = ret_value.operator Vector2();
                write_float(payload, 0, v2.x);
                write_float(payload, 4, v2.y);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__draw_hex_code_box__23__2__5__2__20__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID canvas = read_rid(payload, 8);
            int64_t size = read_int64(payload, 16);
            Vector2 pos = read_vector2(payload, 24);
            int64_t index = read_int64(payload, 32);
            Color color = read_color(payload, 40);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_draw_hex_code_box");
            if (bind) {
                Variant args[5];
                args[0] = canvas;
                args[1] = size;
                args[2] = pos;
                args[3] = index;
                args[4] = color;
                const Variant *argptrs[5];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                argptrs[4] = &args[4];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 5, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__create_shaped_text__2__2__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t direction = read_int64(payload, 8);
            int64_t orientation = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_create_shaped_text");
            if (bind) {
                Variant args[2];
                args[0] = direction;
                args[1] = orientation;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_text_clear__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_clear");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_text_duplicate__23__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_duplicate");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_text_set_direction__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            int64_t direction = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_set_direction");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = direction;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_text_get_direction__23__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_get_direction");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_text_get_inferred_direction__23__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_get_inferred_direction");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_text_set_bidi_override__23__28__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            Array override = read_array(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_set_bidi_override");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = override;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_text_set_custom_punctuation__23__4__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            String punct = read_string_from_data(payload + 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_set_custom_punctuation");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = punct;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_text_get_custom_punctuation__23__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_get_custom_punctuation");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_text_set_custom_ellipsis__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            int64_t char_ = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_set_custom_ellipsis");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = char_;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_text_get_custom_ellipsis__23__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_get_custom_ellipsis");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_text_set_orientation__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            int64_t orientation = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_set_orientation");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = orientation;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_text_get_orientation__23__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_get_orientation");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_text_set_preserve_invalid__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            bool enabled = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_set_preserve_invalid");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = enabled;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_text_get_preserve_invalid__23__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_get_preserve_invalid");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_text_set_preserve_control__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            bool enabled = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_set_preserve_control");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = enabled;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_text_get_preserve_control__23__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_get_preserve_control");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_text_set_spacing__23__2__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            int64_t spacing = read_int64(payload, 16);
            int64_t value = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_set_spacing");
            if (bind) {
                Variant args[3];
                args[0] = shaped;
                args[1] = spacing;
                args[2] = value;
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

        case CMD_TextServerExtension__shaped_text_get_spacing__23__2__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            int64_t spacing = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_get_spacing");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = spacing;
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

        case CMD_TextServerExtension__shaped_text_add_string__23__4__28__2__27__4__0__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            String text = read_string_from_data(payload + 16);
            Array fonts = read_array(payload, 1044);
            int64_t size = read_int64(payload, 1044);
            Dictionary opentype_features = read_dictionary(payload, 1052);
            String language = read_string_from_data(payload + 1052);
            Variant meta;
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_add_string");
            if (bind) {
                Variant args[7];
                args[0] = shaped;
                args[1] = text;
                args[2] = fonts;
                args[3] = size;
                args[4] = opentype_features;
                args[5] = language;
                args[6] = meta;
                const Variant *argptrs[7];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                argptrs[4] = &args[4];
                argptrs[5] = &args[5];
                argptrs[6] = &args[6];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 7, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_text_add_object__23__0__5__2__2__3__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            Variant key;
            Vector2 size = read_vector2(payload, 16);
            int64_t inline_align = read_int64(payload, 24);
            int64_t length = read_int64(payload, 32);
            double baseline = read_double(payload, 40);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_add_object");
            if (bind) {
                Variant args[6];
                args[0] = shaped;
                args[1] = key;
                args[2] = size;
                args[3] = inline_align;
                args[4] = length;
                args[5] = baseline;
                const Variant *argptrs[6];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                argptrs[4] = &args[4];
                argptrs[5] = &args[5];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 6, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_text_resize_object__23__0__5__2__3__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            Variant key;
            Vector2 size = read_vector2(payload, 16);
            int64_t inline_align = read_int64(payload, 24);
            double baseline = read_double(payload, 32);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_resize_object");
            if (bind) {
                Variant args[5];
                args[0] = shaped;
                args[1] = key;
                args[2] = size;
                args[3] = inline_align;
                args[4] = baseline;
                const Variant *argptrs[5];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                argptrs[4] = &args[4];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 5, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_text_has_object__23__0__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            Variant key;
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_has_object");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = key;
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

        case CMD_TextServerExtension__shaped_get_text__23__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_get_text");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_get_span_count__23__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_get_span_count");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_get_span_meta__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            int64_t index = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_get_span_meta");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = index;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_get_span_embedded_object__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            int64_t index = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_get_span_embedded_object");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = index;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_get_span_text__23__2__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            int64_t index = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_get_span_text");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = index;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_get_span_object__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            int64_t index = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_get_span_object");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = index;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_set_span_update_font__23__2__28__2__27__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            int64_t index = read_int64(payload, 16);
            Array fonts = read_array(payload, 24);
            int64_t size = read_int64(payload, 24);
            Dictionary opentype_features = read_dictionary(payload, 32);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_set_span_update_font");
            if (bind) {
                Variant args[5];
                args[0] = shaped;
                args[1] = index;
                args[2] = fonts;
                args[3] = size;
                args[4] = opentype_features;
                const Variant *argptrs[5];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                argptrs[4] = &args[4];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 5, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_get_run_count__23__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_get_run_count");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_get_run_text__23__2__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            int64_t index = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_get_run_text");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = index;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_get_run_range__23__2__r6: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            int64_t index = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_get_run_range");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = index;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_get_run_glyph_range__23__2__r6: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            int64_t index = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_get_run_glyph_range");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = index;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_get_run_font_rid__23__2__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            int64_t index = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_get_run_font_rid");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = index;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_get_run_font_size__23__2__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            int64_t index = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_get_run_font_size");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = index;
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

        case CMD_TextServerExtension__shaped_get_run_language__23__2__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            int64_t index = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_get_run_language");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = index;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_get_run_direction__23__2__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            int64_t index = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_get_run_direction");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = index;
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

        case CMD_TextServerExtension__shaped_get_run_object__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            int64_t index = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_get_run_object");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = index;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_text_substr__23__2__2__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            int64_t start = read_int64(payload, 16);
            int64_t length = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_substr");
            if (bind) {
                Variant args[3];
                args[0] = shaped;
                args[1] = start;
                args[2] = length;
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

        case CMD_TextServerExtension__shaped_text_get_parent__23__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_get_parent");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_text_fit_to_width__23__3__2__r3: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            double width = read_double(payload, 16);
            int64_t justification_flags = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_fit_to_width");
            if (bind) {
                Variant args[3];
                args[0] = shaped;
                args[1] = width;
                args[2] = justification_flags;
                const Variant *argptrs[3];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 3, error);
                write_double(payload, 0, ret_value.operator double());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_text_tab_align__23__32__r3: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            PackedFloat32Array tab_stops = read_packed_float32_array(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_tab_align");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = tab_stops;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
                write_double(payload, 0, ret_value.operator double());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_text_shape__23__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_shape");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_text_update_breaks__23__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_update_breaks");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_text_update_justification_ops__23__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_update_justification_ops");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_text_is_ready__23__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_is_ready");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_text_get_glyphs__23__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_get_glyphs");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_text_sort_logical__23__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_sort_logical");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_text_get_glyph_count__23__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_get_glyph_count");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_text_get_range__23__r6: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_get_range");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_text_get_line_breaks_adv__23__32__2__1__2__r30: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            PackedFloat32Array width = read_packed_float32_array(payload, 16);
            int64_t start = read_int64(payload, 16 + 4 + (width.size() * 4));
            bool once = (read_int32(payload, 16 + 4 + (width.size() * 4) + 8) != 0);
            int64_t break_flags = read_int64(payload, 16 + 4 + (width.size() * 4) + 8 + 4);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_get_line_breaks_adv");
            if (bind) {
                Variant args[5];
                args[0] = shaped;
                args[1] = width;
                args[2] = start;
                args[3] = once;
                args[4] = break_flags;
                const Variant *argptrs[5];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                argptrs[4] = &args[4];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 5, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_text_get_line_breaks__23__3__2__2__r30: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            double width = read_double(payload, 16);
            int64_t start = read_int64(payload, 24);
            int64_t break_flags = read_int64(payload, 32);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_get_line_breaks");
            if (bind) {
                Variant args[4];
                args[0] = shaped;
                args[1] = width;
                args[2] = start;
                args[3] = break_flags;
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

        case CMD_TextServerExtension__shaped_text_get_word_breaks__23__2__2__r30: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            int64_t grapheme_flags = read_int64(payload, 16);
            int64_t skip_grapheme_flags = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_get_word_breaks");
            if (bind) {
                Variant args[3];
                args[0] = shaped;
                args[1] = grapheme_flags;
                args[2] = skip_grapheme_flags;
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

        case CMD_TextServerExtension__shaped_text_get_trim_pos__23__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_get_trim_pos");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_text_get_ellipsis_pos__23__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_get_ellipsis_pos");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_text_get_ellipsis_glyph_count__23__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_get_ellipsis_glyph_count");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_text_get_ellipsis_glyphs__23__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_get_ellipsis_glyphs");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_text_overrun_trim_to_width__23__3__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            double width = read_double(payload, 16);
            int64_t trim_flags = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_overrun_trim_to_width");
            if (bind) {
                Variant args[3];
                args[0] = shaped;
                args[1] = width;
                args[2] = trim_flags;
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

        case CMD_TextServerExtension__shaped_text_get_objects__23__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_get_objects");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_text_get_object_rect__23__0__r7: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            Variant key;
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_get_object_rect");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = key;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_text_get_object_range__23__0__r6: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            Variant key;
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_get_object_range");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = key;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_text_get_object_glyph__23__0__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            Variant key;
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_get_object_glyph");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = key;
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

        case CMD_TextServerExtension__shaped_text_get_size__23__r5: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_get_size");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                Vector2 v2 = ret_value.operator Vector2();
                write_float(payload, 0, v2.x);
                write_float(payload, 4, v2.y);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_text_get_ascent__23__r3: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_get_ascent");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_double(payload, 0, ret_value.operator double());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_text_get_descent__23__r3: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_get_descent");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_double(payload, 0, ret_value.operator double());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_text_get_width__23__r3: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_get_width");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_double(payload, 0, ret_value.operator double());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_text_get_underline_position__23__r3: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_get_underline_position");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_double(payload, 0, ret_value.operator double());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_text_get_underline_thickness__23__r3: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_get_underline_thickness");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_double(payload, 0, ret_value.operator double());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_text_get_dominant_direction_in_range__23__2__2__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            int64_t start = read_int64(payload, 16);
            int64_t end = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_get_dominant_direction_in_range");
            if (bind) {
                Variant args[3];
                args[0] = shaped;
                args[1] = start;
                args[2] = end;
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

        case CMD_TextServerExtension__shaped_text_get_carets__23__2__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            int64_t position = read_int64(payload, 16);
            int64_t caret = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_get_carets");
            if (bind) {
                Variant args[3];
                args[0] = shaped;
                args[1] = position;
                args[2] = caret;
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

        case CMD_TextServerExtension__shaped_text_get_selection__23__2__2__r35: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            int64_t start = read_int64(payload, 16);
            int64_t end = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_get_selection");
            if (bind) {
                Variant args[3];
                args[0] = shaped;
                args[1] = start;
                args[2] = end;
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

        case CMD_TextServerExtension__shaped_text_hit_test_grapheme__23__3__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            double coord = read_double(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_hit_test_grapheme");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = coord;
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

        case CMD_TextServerExtension__shaped_text_hit_test_position__23__3__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            double coord = read_double(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_hit_test_position");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = coord;
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

        case CMD_TextServerExtension__shaped_text_draw__23__23__5__3__3__20__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            RID canvas = read_rid(payload, 16);
            Vector2 pos = read_vector2(payload, 24);
            double clip_l = read_double(payload, 32);
            double clip_r = read_double(payload, 40);
            Color color = read_color(payload, 48);
            double oversampling = read_double(payload, 64);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_draw");
            if (bind) {
                Variant args[7];
                args[0] = shaped;
                args[1] = canvas;
                args[2] = pos;
                args[3] = clip_l;
                args[4] = clip_r;
                args[5] = color;
                args[6] = oversampling;
                const Variant *argptrs[7];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                argptrs[4] = &args[4];
                argptrs[5] = &args[5];
                argptrs[6] = &args[6];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 7, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_text_draw_outline__23__23__5__3__3__2__20__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            RID canvas = read_rid(payload, 16);
            Vector2 pos = read_vector2(payload, 24);
            double clip_l = read_double(payload, 32);
            double clip_r = read_double(payload, 40);
            int64_t outline_size = read_int64(payload, 48);
            Color color = read_color(payload, 56);
            double oversampling = read_double(payload, 72);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_draw_outline");
            if (bind) {
                Variant args[8];
                args[0] = shaped;
                args[1] = canvas;
                args[2] = pos;
                args[3] = clip_l;
                args[4] = clip_r;
                args[5] = outline_size;
                args[6] = color;
                args[7] = oversampling;
                const Variant *argptrs[8];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                argptrs[4] = &args[4];
                argptrs[5] = &args[5];
                argptrs[6] = &args[6];
                argptrs[7] = &args[7];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 8, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_text_get_grapheme_bounds__23__2__r5: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            int64_t pos = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_get_grapheme_bounds");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = pos;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
                Vector2 v2 = ret_value.operator Vector2();
                write_float(payload, 0, v2.x);
                write_float(payload, 4, v2.y);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_text_next_grapheme_pos__23__2__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            int64_t pos = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_next_grapheme_pos");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = pos;
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

        case CMD_TextServerExtension__shaped_text_prev_grapheme_pos__23__2__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            int64_t pos = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_prev_grapheme_pos");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = pos;
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

        case CMD_TextServerExtension__shaped_text_get_character_breaks__23__r30: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_get_character_breaks");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__shaped_text_next_character_pos__23__2__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            int64_t pos = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_next_character_pos");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = pos;
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

        case CMD_TextServerExtension__shaped_text_prev_character_pos__23__2__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            int64_t pos = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_prev_character_pos");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = pos;
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

        case CMD_TextServerExtension__shaped_text_closest_character_pos__23__2__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            int64_t pos = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_shaped_text_closest_character_pos");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = pos;
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

        case CMD_TextServerExtension__format_number__4__4__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            String number = read_string_from_data(payload + 8);
            String language = read_string_from_data(payload + 1036);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_format_number");
            if (bind) {
                Variant args[2];
                args[0] = number;
                args[1] = language;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__parse_number__4__4__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            String number = read_string_from_data(payload + 8);
            String language = read_string_from_data(payload + 1036);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_parse_number");
            if (bind) {
                Variant args[2];
                args[0] = number;
                args[1] = language;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__percent_sign__4__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            String language = read_string_from_data(payload + 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_percent_sign");
            if (bind) {
                Variant args[1];
                args[0] = language;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__strip_diacritics__4__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            String string = read_string_from_data(payload + 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_strip_diacritics");
            if (bind) {
                Variant args[1];
                args[0] = string;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__is_valid_identifier__4__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            String string = read_string_from_data(payload + 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_is_valid_identifier");
            if (bind) {
                Variant args[1];
                args[0] = string;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__is_valid_letter__2__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t unicode = read_int64(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_is_valid_letter");
            if (bind) {
                Variant args[1];
                args[0] = unicode;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__string_get_word_breaks__4__4__2__r30: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            String string = read_string_from_data(payload + 8);
            String language = read_string_from_data(payload + 1036);
            int64_t chars_per_line = read_int64(payload, 2064);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_string_get_word_breaks");
            if (bind) {
                Variant args[3];
                args[0] = string;
                args[1] = language;
                args[2] = chars_per_line;
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

        case CMD_TextServerExtension__string_get_character_breaks__4__4__r30: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            String string = read_string_from_data(payload + 8);
            String language = read_string_from_data(payload + 1036);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_string_get_character_breaks");
            if (bind) {
                Variant args[2];
                args[0] = string;
                args[1] = language;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__is_confusable__4__34__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            String string = read_string_from_data(payload + 8);
            PackedStringArray dict = read_packed_string_array(payload, 1036);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_is_confusable");
            if (bind) {
                Variant args[2];
                args[0] = string;
                args[1] = dict;
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

        case CMD_TextServerExtension__spoof_check__4__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            String string = read_string_from_data(payload + 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_spoof_check");
            if (bind) {
                Variant args[1];
                args[0] = string;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__string_to_upper__4__4__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            String string = read_string_from_data(payload + 8);
            String language = read_string_from_data(payload + 1036);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_string_to_upper");
            if (bind) {
                Variant args[2];
                args[0] = string;
                args[1] = language;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__string_to_lower__4__4__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            String string = read_string_from_data(payload + 8);
            String language = read_string_from_data(payload + 1036);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_string_to_lower");
            if (bind) {
                Variant args[2];
                args[0] = string;
                args[1] = language;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__string_to_title__4__4__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            String string = read_string_from_data(payload + 8);
            String language = read_string_from_data(payload + 1036);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_string_to_title");
            if (bind) {
                Variant args[2];
                args[0] = string;
                args[1] = language;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__parse_structured_text__2__28__4__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t parser_type = read_int64(payload, 8);
            Array arg_args = read_array(payload, 16);
            String text = read_string_from_data(payload + 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_parse_structured_text");
            if (bind) {
                Variant args[3];
                args[0] = parser_type;
                args[1] = arg_args;
                args[2] = text;
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

        case CMD_TextServerExtension__cleanup__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_cleanup");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_has_feature__2__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t feature = read_int64(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "has_feature");
            if (bind) {
                Variant args[1];
                args[0] = feature;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_get_name__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("TextServerExtension", "get_name");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_get_features__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("TextServerExtension", "get_features");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_load_support_data__4__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            String filename = read_string_from_data(payload + 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "load_support_data");
            if (bind) {
                Variant args[1];
                args[0] = filename;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_get_support_data_filename__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("TextServerExtension", "get_support_data_filename");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_get_support_data_info__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("TextServerExtension", "get_support_data_info");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_save_support_data__4__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            String filename = read_string_from_data(payload + 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "save_support_data");
            if (bind) {
                Variant args[1];
                args[0] = filename;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_get_support_data__r29: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("TextServerExtension", "get_support_data");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_is_locale_using_support_data__4__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            String locale = read_string_from_data(payload + 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "is_locale_using_support_data");
            if (bind) {
                Variant args[1];
                args[0] = locale;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_is_locale_right_to_left__4__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            String locale = read_string_from_data(payload + 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "is_locale_right_to_left");
            if (bind) {
                Variant args[1];
                args[0] = locale;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_name_to_tag__4__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            String name = read_string_from_data(payload + 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "name_to_tag");
            if (bind) {
                Variant args[1];
                args[0] = name;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_tag_to_name__2__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t tag = read_int64(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "tag_to_name");
            if (bind) {
                Variant args[1];
                args[0] = tag;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_has__23__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "has");
            if (bind) {
                Variant args[1];
                args[0] = rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_free_rid__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "free_rid");
            if (bind) {
                Variant args[1];
                args[0] = rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_create_font__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("TextServerExtension", "create_font");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_create_font_linked_variation__23__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "create_font_linked_variation");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_set_data__23__29__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            PackedByteArray arg_data = read_packed_byte_array(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_set_data");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
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

        case CMD_TextServerExtension_font_set_face_index__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t face_index = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_set_face_index");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = face_index;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_get_face_index__23__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_get_face_index");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_get_face_count__23__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_get_face_count");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_set_style__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t style = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_set_style");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = style;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_get_style__23__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_get_style");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_set_name__23__4__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            String name = read_string_from_data(payload + 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_set_name");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = name;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_get_name__23__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_get_name");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_get_ot_name_strings__23__r27: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_get_ot_name_strings");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_set_style_name__23__4__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            String name = read_string_from_data(payload + 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_set_style_name");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = name;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_get_style_name__23__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_get_style_name");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_set_weight__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t weight = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_set_weight");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = weight;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_get_weight__23__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_get_weight");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_set_stretch__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t weight = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_set_stretch");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = weight;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_get_stretch__23__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_get_stretch");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_set_antialiasing__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t antialiasing = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_set_antialiasing");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = antialiasing;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_get_antialiasing__23__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_get_antialiasing");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_set_disable_embedded_bitmaps__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            bool disable_embedded_bitmaps = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_set_disable_embedded_bitmaps");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = disable_embedded_bitmaps;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_get_disable_embedded_bitmaps__23__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_get_disable_embedded_bitmaps");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_set_generate_mipmaps__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            bool generate_mipmaps = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_set_generate_mipmaps");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = generate_mipmaps;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_get_generate_mipmaps__23__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_get_generate_mipmaps");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_set_multichannel_signed_distance_field__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            bool msdf = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_set_multichannel_signed_distance_field");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = msdf;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_is_multichannel_signed_distance_field__23__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_is_multichannel_signed_distance_field");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_set_msdf_pixel_range__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t msdf_pixel_range = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_set_msdf_pixel_range");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = msdf_pixel_range;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_get_msdf_pixel_range__23__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_get_msdf_pixel_range");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_set_msdf_size__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t msdf_size = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_set_msdf_size");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = msdf_size;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_get_msdf_size__23__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_get_msdf_size");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_set_fixed_size__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t fixed_size = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_set_fixed_size");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = fixed_size;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_get_fixed_size__23__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_get_fixed_size");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_set_fixed_size_scale_mode__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t fixed_size_scale_mode = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_set_fixed_size_scale_mode");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = fixed_size_scale_mode;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_get_fixed_size_scale_mode__23__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_get_fixed_size_scale_mode");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_set_allow_system_fallback__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            bool allow_system_fallback = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_set_allow_system_fallback");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = allow_system_fallback;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_is_allow_system_fallback__23__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_is_allow_system_fallback");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_clear_system_fallback_cache__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_clear_system_fallback_cache");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_set_force_autohinter__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            bool force_autohinter = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_set_force_autohinter");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = force_autohinter;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_is_force_autohinter__23__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_is_force_autohinter");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_set_modulate_color_glyphs__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            bool force_autohinter = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_set_modulate_color_glyphs");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = force_autohinter;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_is_modulate_color_glyphs__23__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_is_modulate_color_glyphs");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_set_hinting__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t hinting = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_set_hinting");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = hinting;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_get_hinting__23__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_get_hinting");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_set_subpixel_positioning__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t subpixel_positioning = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_set_subpixel_positioning");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = subpixel_positioning;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_get_subpixel_positioning__23__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_get_subpixel_positioning");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_set_keep_rounding_remainders__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            bool keep_rounding_remainders = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_set_keep_rounding_remainders");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = keep_rounding_remainders;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_get_keep_rounding_remainders__23__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_get_keep_rounding_remainders");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_set_embolden__23__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            double strength = read_double(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_set_embolden");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = strength;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_get_embolden__23__r3: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_get_embolden");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_double(payload, 0, ret_value.operator double());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_set_spacing__23__2__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t spacing = read_int64(payload, 16);
            int64_t value = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_set_spacing");
            if (bind) {
                Variant args[3];
                args[0] = font_rid;
                args[1] = spacing;
                args[2] = value;
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

        case CMD_TextServerExtension_font_get_spacing__23__2__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t spacing = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_get_spacing");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = spacing;
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

        case CMD_TextServerExtension_font_set_baseline_offset__23__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            double baseline_offset = read_double(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_set_baseline_offset");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = baseline_offset;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_get_baseline_offset__23__r3: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_get_baseline_offset");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_double(payload, 0, ret_value.operator double());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_set_transform__23__11__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            Transform2D transform = read_transform2d(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_set_transform");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = transform;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_get_transform__23__r11: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_get_transform");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_set_variation_coordinates__23__27__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            Dictionary variation_coordinates = read_dictionary(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_set_variation_coordinates");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = variation_coordinates;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_get_variation_coordinates__23__r27: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_get_variation_coordinates");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_set_oversampling__23__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            double oversampling = read_double(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_set_oversampling");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = oversampling;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_get_oversampling__23__r3: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_get_oversampling");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_double(payload, 0, ret_value.operator double());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_get_size_cache_list__23__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_get_size_cache_list");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_clear_size_cache__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_clear_size_cache");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_remove_size_cache__23__6__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            Vector2i size = read_vector2i(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_remove_size_cache");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = size;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_get_size_cache_info__23__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_get_size_cache_info");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_set_ascent__23__2__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t size = read_int64(payload, 16);
            double ascent = read_double(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_set_ascent");
            if (bind) {
                Variant args[3];
                args[0] = font_rid;
                args[1] = size;
                args[2] = ascent;
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

        case CMD_TextServerExtension_font_get_ascent__23__2__r3: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t size = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_get_ascent");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = size;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
                write_double(payload, 0, ret_value.operator double());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_set_descent__23__2__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t size = read_int64(payload, 16);
            double descent = read_double(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_set_descent");
            if (bind) {
                Variant args[3];
                args[0] = font_rid;
                args[1] = size;
                args[2] = descent;
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

        case CMD_TextServerExtension_font_get_descent__23__2__r3: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t size = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_get_descent");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = size;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
                write_double(payload, 0, ret_value.operator double());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_set_underline_position__23__2__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t size = read_int64(payload, 16);
            double underline_position = read_double(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_set_underline_position");
            if (bind) {
                Variant args[3];
                args[0] = font_rid;
                args[1] = size;
                args[2] = underline_position;
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

        case CMD_TextServerExtension_font_get_underline_position__23__2__r3: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t size = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_get_underline_position");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = size;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
                write_double(payload, 0, ret_value.operator double());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_set_underline_thickness__23__2__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t size = read_int64(payload, 16);
            double underline_thickness = read_double(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_set_underline_thickness");
            if (bind) {
                Variant args[3];
                args[0] = font_rid;
                args[1] = size;
                args[2] = underline_thickness;
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

        case CMD_TextServerExtension_font_get_underline_thickness__23__2__r3: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t size = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_get_underline_thickness");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = size;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
                write_double(payload, 0, ret_value.operator double());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_set_scale__23__2__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t size = read_int64(payload, 16);
            double scale = read_double(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_set_scale");
            if (bind) {
                Variant args[3];
                args[0] = font_rid;
                args[1] = size;
                args[2] = scale;
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

        case CMD_TextServerExtension_font_get_scale__23__2__r3: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t size = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_get_scale");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = size;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
                write_double(payload, 0, ret_value.operator double());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_get_texture_count__23__6__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            Vector2i size = read_vector2i(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_get_texture_count");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = size;
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

        case CMD_TextServerExtension_font_clear_textures__23__6__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            Vector2i size = read_vector2i(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_clear_textures");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = size;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_remove_texture__23__6__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            Vector2i size = read_vector2i(payload, 16);
            int64_t texture_index = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_remove_texture");
            if (bind) {
                Variant args[3];
                args[0] = font_rid;
                args[1] = size;
                args[2] = texture_index;
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

        case CMD_TextServerExtension_font_set_texture_image__23__6__2__24__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            Vector2i size = read_vector2i(payload, 16);
            int64_t texture_index = read_int64(payload, 24);
            ObjectID image = read_object_id(payload, 32);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_set_texture_image");
            if (bind) {
                Variant args[4];
                args[0] = font_rid;
                args[1] = size;
                args[2] = texture_index;
                args[3] = image;
                const Variant *argptrs[4];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 4, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_get_texture_image__23__6__2__r24: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            Vector2i size = read_vector2i(payload, 16);
            int64_t texture_index = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_get_texture_image");
            if (bind) {
                Variant args[3];
                args[0] = font_rid;
                args[1] = size;
                args[2] = texture_index;
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

        case CMD_TextServerExtension_font_set_texture_offsets__23__6__2__30__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            Vector2i size = read_vector2i(payload, 16);
            int64_t texture_index = read_int64(payload, 24);
            PackedInt32Array offset = read_packed_int32_array(payload, 32);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_set_texture_offsets");
            if (bind) {
                Variant args[4];
                args[0] = font_rid;
                args[1] = size;
                args[2] = texture_index;
                args[3] = offset;
                const Variant *argptrs[4];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 4, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_get_texture_offsets__23__6__2__r30: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            Vector2i size = read_vector2i(payload, 16);
            int64_t texture_index = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_get_texture_offsets");
            if (bind) {
                Variant args[3];
                args[0] = font_rid;
                args[1] = size;
                args[2] = texture_index;
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

        case CMD_TextServerExtension_font_get_glyph_list__23__6__r30: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            Vector2i size = read_vector2i(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_get_glyph_list");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = size;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_clear_glyphs__23__6__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            Vector2i size = read_vector2i(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_clear_glyphs");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = size;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_remove_glyph__23__6__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            Vector2i size = read_vector2i(payload, 16);
            int64_t glyph = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_remove_glyph");
            if (bind) {
                Variant args[3];
                args[0] = font_rid;
                args[1] = size;
                args[2] = glyph;
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

        case CMD_TextServerExtension_font_get_glyph_advance__23__2__2__r5: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t size = read_int64(payload, 16);
            int64_t glyph = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_get_glyph_advance");
            if (bind) {
                Variant args[3];
                args[0] = font_rid;
                args[1] = size;
                args[2] = glyph;
                const Variant *argptrs[3];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 3, error);
                Vector2 v2 = ret_value.operator Vector2();
                write_float(payload, 0, v2.x);
                write_float(payload, 4, v2.y);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_set_glyph_advance__23__2__2__5__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t size = read_int64(payload, 16);
            int64_t glyph = read_int64(payload, 24);
            Vector2 advance = read_vector2(payload, 32);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_set_glyph_advance");
            if (bind) {
                Variant args[4];
                args[0] = font_rid;
                args[1] = size;
                args[2] = glyph;
                args[3] = advance;
                const Variant *argptrs[4];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 4, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_get_glyph_offset__23__6__2__r5: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            Vector2i size = read_vector2i(payload, 16);
            int64_t glyph = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_get_glyph_offset");
            if (bind) {
                Variant args[3];
                args[0] = font_rid;
                args[1] = size;
                args[2] = glyph;
                const Variant *argptrs[3];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 3, error);
                Vector2 v2 = ret_value.operator Vector2();
                write_float(payload, 0, v2.x);
                write_float(payload, 4, v2.y);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_set_glyph_offset__23__6__2__5__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            Vector2i size = read_vector2i(payload, 16);
            int64_t glyph = read_int64(payload, 24);
            Vector2 offset = read_vector2(payload, 32);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_set_glyph_offset");
            if (bind) {
                Variant args[4];
                args[0] = font_rid;
                args[1] = size;
                args[2] = glyph;
                args[3] = offset;
                const Variant *argptrs[4];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 4, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_get_glyph_size__23__6__2__r5: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            Vector2i size = read_vector2i(payload, 16);
            int64_t glyph = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_get_glyph_size");
            if (bind) {
                Variant args[3];
                args[0] = font_rid;
                args[1] = size;
                args[2] = glyph;
                const Variant *argptrs[3];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 3, error);
                Vector2 v2 = ret_value.operator Vector2();
                write_float(payload, 0, v2.x);
                write_float(payload, 4, v2.y);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_set_glyph_size__23__6__2__5__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            Vector2i size = read_vector2i(payload, 16);
            int64_t glyph = read_int64(payload, 24);
            Vector2 gl_size = read_vector2(payload, 32);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_set_glyph_size");
            if (bind) {
                Variant args[4];
                args[0] = font_rid;
                args[1] = size;
                args[2] = glyph;
                args[3] = gl_size;
                const Variant *argptrs[4];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 4, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_get_glyph_uv_rect__23__6__2__r7: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            Vector2i size = read_vector2i(payload, 16);
            int64_t glyph = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_get_glyph_uv_rect");
            if (bind) {
                Variant args[3];
                args[0] = font_rid;
                args[1] = size;
                args[2] = glyph;
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

        case CMD_TextServerExtension_font_set_glyph_uv_rect__23__6__2__7__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            Vector2i size = read_vector2i(payload, 16);
            int64_t glyph = read_int64(payload, 24);
            Rect2 uv_rect = read_rect2(payload, 32);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_set_glyph_uv_rect");
            if (bind) {
                Variant args[4];
                args[0] = font_rid;
                args[1] = size;
                args[2] = glyph;
                args[3] = uv_rect;
                const Variant *argptrs[4];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 4, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_get_glyph_texture_idx__23__6__2__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            Vector2i size = read_vector2i(payload, 16);
            int64_t glyph = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_get_glyph_texture_idx");
            if (bind) {
                Variant args[3];
                args[0] = font_rid;
                args[1] = size;
                args[2] = glyph;
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

        case CMD_TextServerExtension_font_set_glyph_texture_idx__23__6__2__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            Vector2i size = read_vector2i(payload, 16);
            int64_t glyph = read_int64(payload, 24);
            int64_t texture_idx = read_int64(payload, 32);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_set_glyph_texture_idx");
            if (bind) {
                Variant args[4];
                args[0] = font_rid;
                args[1] = size;
                args[2] = glyph;
                args[3] = texture_idx;
                const Variant *argptrs[4];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 4, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_get_glyph_texture_rid__23__6__2__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            Vector2i size = read_vector2i(payload, 16);
            int64_t glyph = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_get_glyph_texture_rid");
            if (bind) {
                Variant args[3];
                args[0] = font_rid;
                args[1] = size;
                args[2] = glyph;
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

        case CMD_TextServerExtension_font_get_glyph_texture_size__23__6__2__r5: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            Vector2i size = read_vector2i(payload, 16);
            int64_t glyph = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_get_glyph_texture_size");
            if (bind) {
                Variant args[3];
                args[0] = font_rid;
                args[1] = size;
                args[2] = glyph;
                const Variant *argptrs[3];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 3, error);
                Vector2 v2 = ret_value.operator Vector2();
                write_float(payload, 0, v2.x);
                write_float(payload, 4, v2.y);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_get_glyph_contours__23__2__2__r27: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font = read_rid(payload, 8);
            int64_t size = read_int64(payload, 16);
            int64_t index = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_get_glyph_contours");
            if (bind) {
                Variant args[3];
                args[0] = font;
                args[1] = size;
                args[2] = index;
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

        case CMD_TextServerExtension_font_get_kerning_list__23__2__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t size = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_get_kerning_list");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = size;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_clear_kerning_map__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t size = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_clear_kerning_map");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = size;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_remove_kerning__23__2__6__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t size = read_int64(payload, 16);
            Vector2i glyph_pair = read_vector2i(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_remove_kerning");
            if (bind) {
                Variant args[3];
                args[0] = font_rid;
                args[1] = size;
                args[2] = glyph_pair;
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

        case CMD_TextServerExtension_font_set_kerning__23__2__6__5__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t size = read_int64(payload, 16);
            Vector2i glyph_pair = read_vector2i(payload, 24);
            Vector2 kerning = read_vector2(payload, 32);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_set_kerning");
            if (bind) {
                Variant args[4];
                args[0] = font_rid;
                args[1] = size;
                args[2] = glyph_pair;
                args[3] = kerning;
                const Variant *argptrs[4];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 4, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_get_kerning__23__2__6__r5: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t size = read_int64(payload, 16);
            Vector2i glyph_pair = read_vector2i(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_get_kerning");
            if (bind) {
                Variant args[3];
                args[0] = font_rid;
                args[1] = size;
                args[2] = glyph_pair;
                const Variant *argptrs[3];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 3, error);
                Vector2 v2 = ret_value.operator Vector2();
                write_float(payload, 0, v2.x);
                write_float(payload, 4, v2.y);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_get_glyph_index__23__2__2__2__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t size = read_int64(payload, 16);
            int64_t char_ = read_int64(payload, 24);
            int64_t variation_selector = read_int64(payload, 32);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_get_glyph_index");
            if (bind) {
                Variant args[4];
                args[0] = font_rid;
                args[1] = size;
                args[2] = char_;
                args[3] = variation_selector;
                const Variant *argptrs[4];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 4, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_get_char_from_glyph_index__23__2__2__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t size = read_int64(payload, 16);
            int64_t glyph_index = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_get_char_from_glyph_index");
            if (bind) {
                Variant args[3];
                args[0] = font_rid;
                args[1] = size;
                args[2] = glyph_index;
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

        case CMD_TextServerExtension_font_has_char__23__2__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            int64_t char_ = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_has_char");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = char_;
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

        case CMD_TextServerExtension_font_get_supported_chars__23__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_get_supported_chars");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_get_supported_glyphs__23__r30: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_get_supported_glyphs");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_render_range__23__6__2__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            Vector2i size = read_vector2i(payload, 16);
            int64_t start = read_int64(payload, 24);
            int64_t end = read_int64(payload, 32);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_render_range");
            if (bind) {
                Variant args[4];
                args[0] = font_rid;
                args[1] = size;
                args[2] = start;
                args[3] = end;
                const Variant *argptrs[4];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 4, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_render_glyph__23__6__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            Vector2i size = read_vector2i(payload, 16);
            int64_t index = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_render_glyph");
            if (bind) {
                Variant args[3];
                args[0] = font_rid;
                args[1] = size;
                args[2] = index;
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

        case CMD_TextServerExtension_font_draw_glyph__23__23__2__5__2__20__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            RID canvas = read_rid(payload, 16);
            int64_t size = read_int64(payload, 24);
            Vector2 pos = read_vector2(payload, 32);
            int64_t index = read_int64(payload, 40);
            Color color = read_color(payload, 48);
            double oversampling = read_double(payload, 64);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_draw_glyph");
            if (bind) {
                Variant args[7];
                args[0] = font_rid;
                args[1] = canvas;
                args[2] = size;
                args[3] = pos;
                args[4] = index;
                args[5] = color;
                args[6] = oversampling;
                const Variant *argptrs[7];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                argptrs[4] = &args[4];
                argptrs[5] = &args[5];
                argptrs[6] = &args[6];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 7, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_draw_glyph_outline__23__23__2__2__5__2__20__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            RID canvas = read_rid(payload, 16);
            int64_t size = read_int64(payload, 24);
            int64_t outline_size = read_int64(payload, 32);
            Vector2 pos = read_vector2(payload, 40);
            int64_t index = read_int64(payload, 48);
            Color color = read_color(payload, 56);
            double oversampling = read_double(payload, 72);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_draw_glyph_outline");
            if (bind) {
                Variant args[8];
                args[0] = font_rid;
                args[1] = canvas;
                args[2] = size;
                args[3] = outline_size;
                args[4] = pos;
                args[5] = index;
                args[6] = color;
                args[7] = oversampling;
                const Variant *argptrs[8];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                argptrs[4] = &args[4];
                argptrs[5] = &args[5];
                argptrs[6] = &args[6];
                argptrs[7] = &args[7];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 8, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_is_language_supported__23__4__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            String language = read_string_from_data(payload + 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_is_language_supported");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = language;
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

        case CMD_TextServerExtension_font_set_language_support_override__23__4__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            String language = read_string_from_data(payload + 16);
            bool supported = (read_int32(payload, 1044) != 0);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_set_language_support_override");
            if (bind) {
                Variant args[3];
                args[0] = font_rid;
                args[1] = language;
                args[2] = supported;
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

        case CMD_TextServerExtension_font_get_language_support_override__23__4__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            String language = read_string_from_data(payload + 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_get_language_support_override");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = language;
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

        case CMD_TextServerExtension_font_remove_language_support_override__23__4__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            String language = read_string_from_data(payload + 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_remove_language_support_override");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = language;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_get_language_support_overrides__23__r34: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_get_language_support_overrides");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_is_script_supported__23__4__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            String script = read_string_from_data(payload + 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_is_script_supported");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = script;
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

        case CMD_TextServerExtension_font_set_script_support_override__23__4__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            String script = read_string_from_data(payload + 16);
            bool supported = (read_int32(payload, 1044) != 0);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_set_script_support_override");
            if (bind) {
                Variant args[3];
                args[0] = font_rid;
                args[1] = script;
                args[2] = supported;
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

        case CMD_TextServerExtension_font_get_script_support_override__23__4__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            String script = read_string_from_data(payload + 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_get_script_support_override");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = script;
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

        case CMD_TextServerExtension_font_remove_script_support_override__23__4__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            String script = read_string_from_data(payload + 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_remove_script_support_override");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = script;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_get_script_support_overrides__23__r34: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_get_script_support_overrides");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_set_opentype_feature_overrides__23__27__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            Dictionary overrides = read_dictionary(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_set_opentype_feature_overrides");
            if (bind) {
                Variant args[2];
                args[0] = font_rid;
                args[1] = overrides;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_get_opentype_feature_overrides__23__r27: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_get_opentype_feature_overrides");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_supported_feature_list__23__r27: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_supported_feature_list");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_supported_variation_list__23__r27: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID font_rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_supported_variation_list");
            if (bind) {
                Variant args[1];
                args[0] = font_rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_get_global_oversampling__r3: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_get_global_oversampling");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
                write_double(payload, 0, ret_value.operator double());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_font_set_global_oversampling__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            double oversampling = read_double(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "font_set_global_oversampling");
            if (bind) {
                Variant args[1];
                args[0] = oversampling;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_get_hex_code_box_size__2__2__r5: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t size = read_int64(payload, 8);
            int64_t index = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "get_hex_code_box_size");
            if (bind) {
                Variant args[2];
                args[0] = size;
                args[1] = index;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
                Vector2 v2 = ret_value.operator Vector2();
                write_float(payload, 0, v2.x);
                write_float(payload, 4, v2.y);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_draw_hex_code_box__23__2__5__2__20__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID canvas = read_rid(payload, 8);
            int64_t size = read_int64(payload, 16);
            Vector2 pos = read_vector2(payload, 24);
            int64_t index = read_int64(payload, 32);
            Color color = read_color(payload, 40);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "draw_hex_code_box");
            if (bind) {
                Variant args[5];
                args[0] = canvas;
                args[1] = size;
                args[2] = pos;
                args[3] = index;
                args[4] = color;
                const Variant *argptrs[5];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                argptrs[4] = &args[4];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 5, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_create_shaped_text__2__2__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t direction = read_int64(payload, 8);
            int64_t orientation = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "create_shaped_text");
            if (bind) {
                Variant args[2];
                args[0] = direction;
                args[1] = orientation;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_text_clear__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_clear");
            if (bind) {
                Variant args[1];
                args[0] = rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_text_duplicate__23__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_duplicate");
            if (bind) {
                Variant args[1];
                args[0] = rid;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_text_set_direction__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            int64_t direction = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_set_direction");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = direction;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_text_get_direction__23__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_get_direction");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_text_get_inferred_direction__23__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_get_inferred_direction");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_text_set_bidi_override__23__28__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            Array override = read_array(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_set_bidi_override");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = override;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_text_set_custom_punctuation__23__4__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            String punct = read_string_from_data(payload + 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_set_custom_punctuation");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = punct;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_text_get_custom_punctuation__23__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_get_custom_punctuation");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_text_set_custom_ellipsis__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            int64_t char_ = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_set_custom_ellipsis");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = char_;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_text_get_custom_ellipsis__23__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_get_custom_ellipsis");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_text_set_orientation__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            int64_t orientation = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_set_orientation");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = orientation;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_text_get_orientation__23__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_get_orientation");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_text_set_preserve_invalid__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            bool enabled = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_set_preserve_invalid");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = enabled;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_text_get_preserve_invalid__23__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_get_preserve_invalid");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_text_set_preserve_control__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            bool enabled = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_set_preserve_control");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = enabled;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_text_get_preserve_control__23__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_get_preserve_control");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_text_set_spacing__23__2__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            int64_t spacing = read_int64(payload, 16);
            int64_t value = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_set_spacing");
            if (bind) {
                Variant args[3];
                args[0] = shaped;
                args[1] = spacing;
                args[2] = value;
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

        case CMD_TextServerExtension_shaped_text_get_spacing__23__2__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            int64_t spacing = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_get_spacing");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = spacing;
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

        case CMD_TextServerExtension_shaped_text_add_string__23__4__28__2__27__4__0__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            String text = read_string_from_data(payload + 16);
            Array fonts = read_array(payload, 1044);
            int64_t size = read_int64(payload, 1044);
            Dictionary opentype_features = read_dictionary(payload, 1052);
            String language = read_string_from_data(payload + 1052);
            Variant meta;
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_add_string");
            if (bind) {
                Variant args[7];
                args[0] = shaped;
                args[1] = text;
                args[2] = fonts;
                args[3] = size;
                args[4] = opentype_features;
                args[5] = language;
                args[6] = meta;
                const Variant *argptrs[7];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                argptrs[4] = &args[4];
                argptrs[5] = &args[5];
                argptrs[6] = &args[6];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 7, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_text_add_object__23__0__5__2__2__3__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            Variant key;
            Vector2 size = read_vector2(payload, 16);
            int64_t inline_align = read_int64(payload, 24);
            int64_t length = read_int64(payload, 32);
            double baseline = read_double(payload, 40);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_add_object");
            if (bind) {
                Variant args[6];
                args[0] = shaped;
                args[1] = key;
                args[2] = size;
                args[3] = inline_align;
                args[4] = length;
                args[5] = baseline;
                const Variant *argptrs[6];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                argptrs[4] = &args[4];
                argptrs[5] = &args[5];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 6, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_text_resize_object__23__0__5__2__3__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            Variant key;
            Vector2 size = read_vector2(payload, 16);
            int64_t inline_align = read_int64(payload, 24);
            double baseline = read_double(payload, 32);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_resize_object");
            if (bind) {
                Variant args[5];
                args[0] = shaped;
                args[1] = key;
                args[2] = size;
                args[3] = inline_align;
                args[4] = baseline;
                const Variant *argptrs[5];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                argptrs[4] = &args[4];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 5, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_text_has_object__23__0__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            Variant key;
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_has_object");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = key;
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

        case CMD_TextServerExtension_shaped_get_text__23__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_get_text");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_get_span_count__23__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_get_span_count");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_get_span_meta__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            int64_t index = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_get_span_meta");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = index;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_get_span_embedded_object__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            int64_t index = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_get_span_embedded_object");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = index;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_get_span_text__23__2__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            int64_t index = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_get_span_text");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = index;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_get_span_object__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            int64_t index = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_get_span_object");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = index;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_set_span_update_font__23__2__28__2__27__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            int64_t index = read_int64(payload, 16);
            Array fonts = read_array(payload, 24);
            int64_t size = read_int64(payload, 24);
            Dictionary opentype_features = read_dictionary(payload, 32);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_set_span_update_font");
            if (bind) {
                Variant args[5];
                args[0] = shaped;
                args[1] = index;
                args[2] = fonts;
                args[3] = size;
                args[4] = opentype_features;
                const Variant *argptrs[5];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                argptrs[4] = &args[4];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 5, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_get_run_count__23__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_get_run_count");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_get_run_text__23__2__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            int64_t index = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_get_run_text");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = index;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_get_run_range__23__2__r6: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            int64_t index = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_get_run_range");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = index;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_get_run_glyph_range__23__2__r6: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            int64_t index = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_get_run_glyph_range");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = index;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_get_run_font_rid__23__2__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            int64_t index = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_get_run_font_rid");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = index;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_get_run_font_size__23__2__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            int64_t index = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_get_run_font_size");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = index;
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

        case CMD_TextServerExtension_shaped_get_run_language__23__2__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            int64_t index = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_get_run_language");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = index;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_get_run_direction__23__2__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            int64_t index = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_get_run_direction");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = index;
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

        case CMD_TextServerExtension_shaped_get_run_object__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            int64_t index = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_get_run_object");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = index;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_text_substr__23__2__2__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            int64_t start = read_int64(payload, 16);
            int64_t length = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_substr");
            if (bind) {
                Variant args[3];
                args[0] = shaped;
                args[1] = start;
                args[2] = length;
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

        case CMD_TextServerExtension_shaped_text_get_parent__23__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_get_parent");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_text_fit_to_width__23__3__2__r3: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            double width = read_double(payload, 16);
            int64_t justification_flags = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_fit_to_width");
            if (bind) {
                Variant args[3];
                args[0] = shaped;
                args[1] = width;
                args[2] = justification_flags;
                const Variant *argptrs[3];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 3, error);
                write_double(payload, 0, ret_value.operator double());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_text_tab_align__23__32__r3: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            PackedFloat32Array tab_stops = read_packed_float32_array(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_tab_align");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = tab_stops;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
                write_double(payload, 0, ret_value.operator double());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_text_shape__23__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_shape");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_text_is_ready__23__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_is_ready");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_text_has_visible_chars__23__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_has_visible_chars");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_text_get_glyphs__23__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_get_glyphs");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_text_sort_logical__23__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_sort_logical");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_text_get_glyph_count__23__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_get_glyph_count");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_text_get_range__23__r6: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_get_range");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_text_get_line_breaks_adv__23__32__2__1__2__r30: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            PackedFloat32Array width = read_packed_float32_array(payload, 16);
            int64_t start = read_int64(payload, 16 + 4 + (width.size() * 4));
            bool once = (read_int32(payload, 16 + 4 + (width.size() * 4) + 8) != 0);
            int64_t break_flags = read_int64(payload, 16 + 4 + (width.size() * 4) + 8 + 4);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_get_line_breaks_adv");
            if (bind) {
                Variant args[5];
                args[0] = shaped;
                args[1] = width;
                args[2] = start;
                args[3] = once;
                args[4] = break_flags;
                const Variant *argptrs[5];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                argptrs[4] = &args[4];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 5, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_text_get_line_breaks__23__3__2__2__r30: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            double width = read_double(payload, 16);
            int64_t start = read_int64(payload, 24);
            int64_t break_flags = read_int64(payload, 32);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_get_line_breaks");
            if (bind) {
                Variant args[4];
                args[0] = shaped;
                args[1] = width;
                args[2] = start;
                args[3] = break_flags;
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

        case CMD_TextServerExtension_shaped_text_get_word_breaks__23__2__2__r30: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            int64_t grapheme_flags = read_int64(payload, 16);
            int64_t skip_grapheme_flags = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_get_word_breaks");
            if (bind) {
                Variant args[3];
                args[0] = shaped;
                args[1] = grapheme_flags;
                args[2] = skip_grapheme_flags;
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

        case CMD_TextServerExtension_shaped_text_get_trim_pos__23__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_get_trim_pos");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_text_get_ellipsis_pos__23__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_get_ellipsis_pos");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_text_get_ellipsis_glyphs__23__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_get_ellipsis_glyphs");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_text_get_ellipsis_glyph_count__23__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_get_ellipsis_glyph_count");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_text_overrun_trim_to_width__23__3__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            double width = read_double(payload, 16);
            int64_t overrun_trim_flags = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_overrun_trim_to_width");
            if (bind) {
                Variant args[3];
                args[0] = shaped;
                args[1] = width;
                args[2] = overrun_trim_flags;
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

        case CMD_TextServerExtension_shaped_text_get_objects__23__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_get_objects");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_text_get_object_rect__23__0__r7: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            Variant key;
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_get_object_rect");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = key;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_text_get_object_range__23__0__r6: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            Variant key;
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_get_object_range");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = key;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_text_get_object_glyph__23__0__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            Variant key;
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_get_object_glyph");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = key;
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

        case CMD_TextServerExtension_shaped_text_get_size__23__r5: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_get_size");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                Vector2 v2 = ret_value.operator Vector2();
                write_float(payload, 0, v2.x);
                write_float(payload, 4, v2.y);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_text_get_ascent__23__r3: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_get_ascent");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_double(payload, 0, ret_value.operator double());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_text_get_descent__23__r3: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_get_descent");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_double(payload, 0, ret_value.operator double());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_text_get_width__23__r3: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_get_width");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_double(payload, 0, ret_value.operator double());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_text_get_underline_position__23__r3: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_get_underline_position");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_double(payload, 0, ret_value.operator double());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_text_get_underline_thickness__23__r3: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_get_underline_thickness");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_double(payload, 0, ret_value.operator double());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_text_get_carets__23__2__r27: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            int64_t position = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_get_carets");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = position;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_text_get_selection__23__2__2__r35: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            int64_t start = read_int64(payload, 16);
            int64_t end = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_get_selection");
            if (bind) {
                Variant args[3];
                args[0] = shaped;
                args[1] = start;
                args[2] = end;
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

        case CMD_TextServerExtension_shaped_text_hit_test_grapheme__23__3__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            double coords = read_double(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_hit_test_grapheme");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = coords;
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

        case CMD_TextServerExtension_shaped_text_hit_test_position__23__3__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            double coords = read_double(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_hit_test_position");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = coords;
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

        case CMD_TextServerExtension_shaped_text_get_grapheme_bounds__23__2__r5: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            int64_t pos = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_get_grapheme_bounds");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = pos;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
                Vector2 v2 = ret_value.operator Vector2();
                write_float(payload, 0, v2.x);
                write_float(payload, 4, v2.y);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_text_next_grapheme_pos__23__2__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            int64_t pos = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_next_grapheme_pos");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = pos;
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

        case CMD_TextServerExtension_shaped_text_prev_grapheme_pos__23__2__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            int64_t pos = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_prev_grapheme_pos");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = pos;
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

        case CMD_TextServerExtension_shaped_text_get_character_breaks__23__r30: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_get_character_breaks");
            if (bind) {
                Variant args[1];
                args[0] = shaped;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_text_next_character_pos__23__2__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            int64_t pos = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_next_character_pos");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = pos;
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

        case CMD_TextServerExtension_shaped_text_prev_character_pos__23__2__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            int64_t pos = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_prev_character_pos");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = pos;
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

        case CMD_TextServerExtension_shaped_text_closest_character_pos__23__2__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            int64_t pos = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_closest_character_pos");
            if (bind) {
                Variant args[2];
                args[0] = shaped;
                args[1] = pos;
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

        case CMD_TextServerExtension_shaped_text_draw__23__23__5__3__3__20__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            RID canvas = read_rid(payload, 16);
            Vector2 pos = read_vector2(payload, 24);
            double clip_l = read_double(payload, 32);
            double clip_r = read_double(payload, 40);
            Color color = read_color(payload, 48);
            double oversampling = read_double(payload, 64);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_draw");
            if (bind) {
                Variant args[7];
                args[0] = shaped;
                args[1] = canvas;
                args[2] = pos;
                args[3] = clip_l;
                args[4] = clip_r;
                args[5] = color;
                args[6] = oversampling;
                const Variant *argptrs[7];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                argptrs[4] = &args[4];
                argptrs[5] = &args[5];
                argptrs[6] = &args[6];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 7, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_text_draw_outline__23__23__5__3__3__2__20__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            RID canvas = read_rid(payload, 16);
            Vector2 pos = read_vector2(payload, 24);
            double clip_l = read_double(payload, 32);
            double clip_r = read_double(payload, 40);
            int64_t outline_size = read_int64(payload, 48);
            Color color = read_color(payload, 56);
            double oversampling = read_double(payload, 72);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_draw_outline");
            if (bind) {
                Variant args[8];
                args[0] = shaped;
                args[1] = canvas;
                args[2] = pos;
                args[3] = clip_l;
                args[4] = clip_r;
                args[5] = outline_size;
                args[6] = color;
                args[7] = oversampling;
                const Variant *argptrs[8];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                argptrs[4] = &args[4];
                argptrs[5] = &args[5];
                argptrs[6] = &args[6];
                argptrs[7] = &args[7];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 8, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_shaped_text_get_dominant_direction_in_range__23__2__2__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shaped = read_rid(payload, 8);
            int64_t start = read_int64(payload, 16);
            int64_t end = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "shaped_text_get_dominant_direction_in_range");
            if (bind) {
                Variant args[3];
                args[0] = shaped;
                args[1] = start;
                args[2] = end;
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

        case CMD_TextServerExtension_format_number__4__4__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            String number = read_string_from_data(payload + 8);
            String language = read_string_from_data(payload + 1036);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "format_number");
            if (bind) {
                Variant args[2];
                args[0] = number;
                args[1] = language;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_parse_number__4__4__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            String number = read_string_from_data(payload + 8);
            String language = read_string_from_data(payload + 1036);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "parse_number");
            if (bind) {
                Variant args[2];
                args[0] = number;
                args[1] = language;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_percent_sign__4__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            String language = read_string_from_data(payload + 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "percent_sign");
            if (bind) {
                Variant args[1];
                args[0] = language;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_string_get_word_breaks__4__4__2__r30: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            String string = read_string_from_data(payload + 8);
            String language = read_string_from_data(payload + 1036);
            int64_t chars_per_line = read_int64(payload, 2064);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "string_get_word_breaks");
            if (bind) {
                Variant args[3];
                args[0] = string;
                args[1] = language;
                args[2] = chars_per_line;
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

        case CMD_TextServerExtension_string_get_character_breaks__4__4__r30: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            String string = read_string_from_data(payload + 8);
            String language = read_string_from_data(payload + 1036);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "string_get_character_breaks");
            if (bind) {
                Variant args[2];
                args[0] = string;
                args[1] = language;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_is_confusable__4__34__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            String string = read_string_from_data(payload + 8);
            PackedStringArray dict = read_packed_string_array(payload, 1036);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "is_confusable");
            if (bind) {
                Variant args[2];
                args[0] = string;
                args[1] = dict;
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

        case CMD_TextServerExtension_spoof_check__4__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            String string = read_string_from_data(payload + 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "spoof_check");
            if (bind) {
                Variant args[1];
                args[0] = string;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_strip_diacritics__4__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            String string = read_string_from_data(payload + 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "strip_diacritics");
            if (bind) {
                Variant args[1];
                args[0] = string;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_is_valid_identifier__4__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            String string = read_string_from_data(payload + 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "is_valid_identifier");
            if (bind) {
                Variant args[1];
                args[0] = string;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_is_valid_letter__2__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t unicode = read_int64(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "is_valid_letter");
            if (bind) {
                Variant args[1];
                args[0] = unicode;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_string_to_upper__4__4__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            String string = read_string_from_data(payload + 8);
            String language = read_string_from_data(payload + 1036);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "string_to_upper");
            if (bind) {
                Variant args[2];
                args[0] = string;
                args[1] = language;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_string_to_lower__4__4__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            String string = read_string_from_data(payload + 8);
            String language = read_string_from_data(payload + 1036);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "string_to_lower");
            if (bind) {
                Variant args[2];
                args[0] = string;
                args[1] = language;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_string_to_title__4__4__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            String string = read_string_from_data(payload + 8);
            String language = read_string_from_data(payload + 1036);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "string_to_title");
            if (bind) {
                Variant args[2];
                args[0] = string;
                args[1] = language;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_parse_structured_text__2__28__4__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t parser_type = read_int64(payload, 8);
            Array arg_args = read_array(payload, 16);
            String text = read_string_from_data(payload + 16);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "parse_structured_text");
            if (bind) {
                Variant args[3];
                args[0] = parser_type;
                args[1] = arg_args;
                args[2] = text;
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

        case CMD_TextServerExtension_init_ref__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("TextServerExtension", "init_ref");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_reference__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("TextServerExtension", "reference");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_unreference__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("TextServerExtension", "unreference");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_get_reference_count__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("TextServerExtension", "get_reference_count");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_free__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("TextServerExtension", "free");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__init__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_init");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__to_string__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_to_string");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__notification__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t what = read_int64(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_notification");
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

        case CMD_TextServerExtension__set__21__0__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName property = read_string_name(payload, 8);
            Variant value;
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_set");
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

        case CMD_TextServerExtension__get__21__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName property = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_get");
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

        case CMD_TextServerExtension__get_property_list__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_get_property_list");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension__validate_property__27__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            Dictionary property = read_dictionary(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_validate_property");
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

        case CMD_TextServerExtension__property_can_revert__21__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName property = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_property_can_revert");
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

        case CMD_TextServerExtension__property_get_revert__21__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName property = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_property_get_revert");
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

        case CMD_TextServerExtension__iter_init__28__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            Array iter = read_array(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_iter_init");
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

        case CMD_TextServerExtension__iter_next__28__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            Array iter = read_array(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_iter_next");
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

        case CMD_TextServerExtension__iter_get__0__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            Variant iter;
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "_iter_get");
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

        case CMD_TextServerExtension_get_class__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("TextServerExtension", "get_class");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_is_class__4__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            String class_ = read_string_from_data(payload + 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "is_class");
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

        case CMD_TextServerExtension_set__21__0__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName property = read_string_name(payload, 8);
            Variant value;
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "set");
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

        case CMD_TextServerExtension_get__21__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName property = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "get");
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

        case CMD_TextServerExtension_set_indexed__22__0__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            NodePath property_path = read_node_path(payload, 8);
            Variant value;
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "set_indexed");
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

        case CMD_TextServerExtension_get_indexed__22__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            NodePath property_path = read_node_path(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "get_indexed");
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

        case CMD_TextServerExtension_get_property_list__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("TextServerExtension", "get_property_list");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_get_method_list__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("TextServerExtension", "get_method_list");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_property_can_revert__21__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName property = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "property_can_revert");
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

        case CMD_TextServerExtension_property_get_revert__21__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName property = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "property_get_revert");
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

        case CMD_TextServerExtension_notification__2__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t what = read_int64(payload, 8);
            bool reversed = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "notification");
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

        case CMD_TextServerExtension_to_string__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("TextServerExtension", "to_string");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_get_instance_id__r24: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("TextServerExtension", "get_instance_id");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
                write_object_id(payload, 0, ret_value.operator ObjectID());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_set_script__0__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            Variant script;
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "set_script");
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

        case CMD_TextServerExtension_get_script__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("TextServerExtension", "get_script");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_set_meta__21__0__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName name = read_string_name(payload, 8);
            Variant value;
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "set_meta");
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

        case CMD_TextServerExtension_remove_meta__21__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName name = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "remove_meta");
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

        case CMD_TextServerExtension_get_meta__21__0__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName name = read_string_name(payload, 8);
            Variant default_;
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "get_meta");
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

        case CMD_TextServerExtension_has_meta__21__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName name = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "has_meta");
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

        case CMD_TextServerExtension_get_meta_list__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("TextServerExtension", "get_meta_list");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_add_user_signal__4__28__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            String signal = read_string_from_data(payload + 8);
            Array arguments = read_array(payload, 1036);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "add_user_signal");
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

        case CMD_TextServerExtension_has_user_signal__21__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName signal = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "has_user_signal");
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

        case CMD_TextServerExtension_remove_user_signal__21__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName signal = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "remove_user_signal");
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

        case CMD_TextServerExtension_emit_signal__21__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName signal = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "emit_signal");
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

        case CMD_TextServerExtension_call__21__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName method = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "call");
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

        case CMD_TextServerExtension_call_deferred__21__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName method = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "call_deferred");
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

        case CMD_TextServerExtension_set_deferred__21__0__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName property = read_string_name(payload, 8);
            Variant value;
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "set_deferred");
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

        case CMD_TextServerExtension_callv__21__28__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName method = read_string_name(payload, 8);
            Array arg_array = read_array(payload, 1036);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "callv");
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

        case CMD_TextServerExtension_has_method__21__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName method = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "has_method");
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

        case CMD_TextServerExtension_get_method_argument_count__21__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName method = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "get_method_argument_count");
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

        case CMD_TextServerExtension_has_signal__21__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName signal = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "has_signal");
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

        case CMD_TextServerExtension_get_signal_list__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("TextServerExtension", "get_signal_list");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_get_signal_connection_list__21__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName signal = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "get_signal_connection_list");
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

        case CMD_TextServerExtension_get_incoming_connections__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("TextServerExtension", "get_incoming_connections");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_connect__21__25__2__r2: {
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
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "connect");
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

        case CMD_TextServerExtension_disconnect__21__25__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName signal = read_string_name(payload, 8);
            Callable callable = read_callable(payload, 1036);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "disconnect");
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

        case CMD_TextServerExtension_is_connected__21__25__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName signal = read_string_name(payload, 8);
            Callable callable = read_callable(payload, 1036);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "is_connected");
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

        case CMD_TextServerExtension_has_connections__21__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName signal = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "has_connections");
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

        case CMD_TextServerExtension_set_block_signals__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            bool enable = (read_int32(payload, 8) != 0);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "set_block_signals");
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

        case CMD_TextServerExtension_is_blocking_signals__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("TextServerExtension", "is_blocking_signals");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_notify_property_list_changed__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("TextServerExtension", "notify_property_list_changed");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_set_message_translation__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            bool enable = (read_int32(payload, 8) != 0);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "set_message_translation");
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

        case CMD_TextServerExtension_can_translate_messages__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("TextServerExtension", "can_translate_messages");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_tr__21__21__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName message = read_string_name(payload, 8);
            StringName context = read_string_name(payload, 1036);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "tr");
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

        case CMD_TextServerExtension_tr_n__21__21__2__21__r4: {
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
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "tr_n");
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

        case CMD_TextServerExtension_get_translation_domain__r21: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("TextServerExtension", "get_translation_domain");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_set_translation_domain__21__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName domain = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("TextServerExtension", "set_translation_domain");
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

        case CMD_TextServerExtension_is_queued_for_deletion__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("TextServerExtension", "is_queued_for_deletion");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_TextServerExtension_cancel_free__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("TextServerExtension", "cancel_free");
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
