#include "headers/bridge_helpers.h"
void handle_RenderingServer(uint32_t cmd, volatile uint8_t *payload, volatile uint32_t *cmd_ptr, volatile uint8_t *status_ptr) {
    switch (cmd) {
        case CMD_RenderingServer_texture_2d_create__24__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            ObjectID image = read_object_id(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "texture_2d_create");
            if (bind) {
                Variant args[1];
                args[0] = image;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_texture_2d_layered_create__28__2__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            Array layers = read_array(payload, 8);
            int64_t layered_type = read_int64(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "texture_2d_layered_create");
            if (bind) {
                Variant args[2];
                args[0] = layers;
                args[1] = layered_type;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_texture_3d_create__2__2__2__2__1__28__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t format = read_int64(payload, 8);
            int64_t width = read_int64(payload, 16);
            int64_t height = read_int64(payload, 24);
            int64_t depth = read_int64(payload, 32);
            bool mipmaps = (read_int32(payload, 40) != 0);
            Array arg_data = read_array(payload, 44);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "texture_3d_create");
            if (bind) {
                Variant args[6];
                args[0] = format;
                args[1] = width;
                args[2] = height;
                args[3] = depth;
                args[4] = mipmaps;
                args[5] = arg_data;
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

        case CMD_RenderingServer_texture_proxy_create__23__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID base = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "texture_proxy_create");
            if (bind) {
                Variant args[1];
                args[0] = base;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_texture_create_from_native_handle__2__2__2__2__2__2__2__2__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t type = read_int64(payload, 8);
            int64_t format = read_int64(payload, 16);
            int64_t native_handle = read_int64(payload, 24);
            int64_t width = read_int64(payload, 32);
            int64_t height = read_int64(payload, 40);
            int64_t depth = read_int64(payload, 48);
            int64_t layers = read_int64(payload, 56);
            int64_t layered_type = read_int64(payload, 64);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "texture_create_from_native_handle");
            if (bind) {
                Variant args[8];
                args[0] = type;
                args[1] = format;
                args[2] = native_handle;
                args[3] = width;
                args[4] = height;
                args[5] = depth;
                args[6] = layers;
                args[7] = layered_type;
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
                Variant ret_value = bind->call(target_obj, argptrs, 8, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_texture_2d_update__23__24__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID texture = read_rid(payload, 8);
            ObjectID image = read_object_id(payload, 16);
            int64_t layer = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "texture_2d_update");
            if (bind) {
                Variant args[3];
                args[0] = texture;
                args[1] = image;
                args[2] = layer;
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

        case CMD_RenderingServer_texture_3d_update__23__28__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID texture = read_rid(payload, 8);
            Array arg_data = read_array(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "texture_3d_update");
            if (bind) {
                Variant args[2];
                args[0] = texture;
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

        case CMD_RenderingServer_texture_proxy_update__23__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID texture = read_rid(payload, 8);
            RID proxy_to = read_rid(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "texture_proxy_update");
            if (bind) {
                Variant args[2];
                args[0] = texture;
                args[1] = proxy_to;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_texture_2d_placeholder_create__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "texture_2d_placeholder_create");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_texture_2d_layered_placeholder_create__2__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t layered_type = read_int64(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "texture_2d_layered_placeholder_create");
            if (bind) {
                Variant args[1];
                args[0] = layered_type;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_texture_3d_placeholder_create__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "texture_3d_placeholder_create");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_texture_2d_get__23__r24: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID texture = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "texture_2d_get");
            if (bind) {
                Variant args[1];
                args[0] = texture;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_object_id(payload, 0, ret_value.operator ObjectID());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_texture_2d_layer_get__23__2__r24: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID texture = read_rid(payload, 8);
            int64_t layer = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "texture_2d_layer_get");
            if (bind) {
                Variant args[2];
                args[0] = texture;
                args[1] = layer;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
                write_object_id(payload, 0, ret_value.operator ObjectID());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_texture_3d_get__23__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID texture = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "texture_3d_get");
            if (bind) {
                Variant args[1];
                args[0] = texture;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_texture_replace__23__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID texture = read_rid(payload, 8);
            RID by_texture = read_rid(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "texture_replace");
            if (bind) {
                Variant args[2];
                args[0] = texture;
                args[1] = by_texture;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_texture_set_size_override__23__2__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID texture = read_rid(payload, 8);
            int64_t width = read_int64(payload, 16);
            int64_t height = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "texture_set_size_override");
            if (bind) {
                Variant args[3];
                args[0] = texture;
                args[1] = width;
                args[2] = height;
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

        case CMD_RenderingServer_texture_set_path__23__4__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID texture = read_rid(payload, 8);
            String path = read_string_from_data(payload + 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "texture_set_path");
            if (bind) {
                Variant args[2];
                args[0] = texture;
                args[1] = path;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_texture_get_path__23__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID texture = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "texture_get_path");
            if (bind) {
                Variant args[1];
                args[0] = texture;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_texture_get_format__23__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID texture = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "texture_get_format");
            if (bind) {
                Variant args[1];
                args[0] = texture;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_texture_set_force_redraw_if_visible__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID texture = read_rid(payload, 8);
            bool enable = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "texture_set_force_redraw_if_visible");
            if (bind) {
                Variant args[2];
                args[0] = texture;
                args[1] = enable;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_texture_rd_create__23__2__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID rd_texture = read_rid(payload, 8);
            int64_t layer_type = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "texture_rd_create");
            if (bind) {
                Variant args[2];
                args[0] = rd_texture;
                args[1] = layer_type;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_texture_get_rd_texture__23__1__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID texture = read_rid(payload, 8);
            bool srgb = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "texture_get_rd_texture");
            if (bind) {
                Variant args[2];
                args[0] = texture;
                args[1] = srgb;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_texture_get_native_handle__23__1__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID texture = read_rid(payload, 8);
            bool srgb = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "texture_get_native_handle");
            if (bind) {
                Variant args[2];
                args[0] = texture;
                args[1] = srgb;
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

        case CMD_RenderingServer_shader_create__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "shader_create");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_shader_set_code__23__4__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shader = read_rid(payload, 8);
            String code = read_string_from_data(payload + 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "shader_set_code");
            if (bind) {
                Variant args[2];
                args[0] = shader;
                args[1] = code;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_shader_set_path_hint__23__4__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shader = read_rid(payload, 8);
            String path = read_string_from_data(payload + 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "shader_set_path_hint");
            if (bind) {
                Variant args[2];
                args[0] = shader;
                args[1] = path;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_shader_get_code__23__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shader = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "shader_get_code");
            if (bind) {
                Variant args[1];
                args[0] = shader;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_get_shader_parameter_list__23__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shader = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "get_shader_parameter_list");
            if (bind) {
                Variant args[1];
                args[0] = shader;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_shader_get_parameter_default__23__21__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shader = read_rid(payload, 8);
            StringName name = read_string_name(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "shader_get_parameter_default");
            if (bind) {
                Variant args[2];
                args[0] = shader;
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

        case CMD_RenderingServer_shader_set_default_texture_parameter__23__21__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shader = read_rid(payload, 8);
            StringName name = read_string_name(payload, 16);
            RID texture = read_rid(payload, 1044);
            int64_t index = read_int64(payload, 1052);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "shader_set_default_texture_parameter");
            if (bind) {
                Variant args[4];
                args[0] = shader;
                args[1] = name;
                args[2] = texture;
                args[3] = index;
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

        case CMD_RenderingServer_shader_get_default_texture_parameter__23__21__2__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shader = read_rid(payload, 8);
            StringName name = read_string_name(payload, 16);
            int64_t index = read_int64(payload, 1044);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "shader_get_default_texture_parameter");
            if (bind) {
                Variant args[3];
                args[0] = shader;
                args[1] = name;
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

        case CMD_RenderingServer_material_create__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "material_create");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_material_set_shader__23__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID shader_material = read_rid(payload, 8);
            RID shader = read_rid(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "material_set_shader");
            if (bind) {
                Variant args[2];
                args[0] = shader_material;
                args[1] = shader;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_material_set_param__23__21__0__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID material = read_rid(payload, 8);
            StringName parameter = read_string_name(payload, 16);
            Variant value;
            MethodBind *bind = ClassDB::get_method("RenderingServer", "material_set_param");
            if (bind) {
                Variant args[3];
                args[0] = material;
                args[1] = parameter;
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

        case CMD_RenderingServer_material_get_param__23__21__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID material = read_rid(payload, 8);
            StringName parameter = read_string_name(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "material_get_param");
            if (bind) {
                Variant args[2];
                args[0] = material;
                args[1] = parameter;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_material_set_render_priority__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID material = read_rid(payload, 8);
            int64_t priority = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "material_set_render_priority");
            if (bind) {
                Variant args[2];
                args[0] = material;
                args[1] = priority;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_material_set_next_pass__23__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID material = read_rid(payload, 8);
            RID next_material = read_rid(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "material_set_next_pass");
            if (bind) {
                Variant args[2];
                args[0] = material;
                args[1] = next_material;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_material_set_use_debanding__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            bool enable = (read_int32(payload, 8) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "material_set_use_debanding");
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

        case CMD_RenderingServer_mesh_create_from_surfaces__28__2__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            Array surfaces = read_array(payload, 8);
            int64_t blend_shape_count = read_int64(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "mesh_create_from_surfaces");
            if (bind) {
                Variant args[2];
                args[0] = surfaces;
                args[1] = blend_shape_count;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_mesh_create__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "mesh_create");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_mesh_surface_get_format_offset__2__2__2__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t format = read_int64(payload, 8);
            int64_t vertex_count = read_int64(payload, 16);
            int64_t array_index = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "mesh_surface_get_format_offset");
            if (bind) {
                Variant args[3];
                args[0] = format;
                args[1] = vertex_count;
                args[2] = array_index;
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

        case CMD_RenderingServer_mesh_surface_get_format_vertex_stride__2__2__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t format = read_int64(payload, 8);
            int64_t vertex_count = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "mesh_surface_get_format_vertex_stride");
            if (bind) {
                Variant args[2];
                args[0] = format;
                args[1] = vertex_count;
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

        case CMD_RenderingServer_mesh_surface_get_format_normal_tangent_stride__2__2__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t format = read_int64(payload, 8);
            int64_t vertex_count = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "mesh_surface_get_format_normal_tangent_stride");
            if (bind) {
                Variant args[2];
                args[0] = format;
                args[1] = vertex_count;
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

        case CMD_RenderingServer_mesh_surface_get_format_attribute_stride__2__2__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t format = read_int64(payload, 8);
            int64_t vertex_count = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "mesh_surface_get_format_attribute_stride");
            if (bind) {
                Variant args[2];
                args[0] = format;
                args[1] = vertex_count;
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

        case CMD_RenderingServer_mesh_surface_get_format_skin_stride__2__2__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t format = read_int64(payload, 8);
            int64_t vertex_count = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "mesh_surface_get_format_skin_stride");
            if (bind) {
                Variant args[2];
                args[0] = format;
                args[1] = vertex_count;
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

        case CMD_RenderingServer_mesh_surface_get_format_index_stride__2__2__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t format = read_int64(payload, 8);
            int64_t vertex_count = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "mesh_surface_get_format_index_stride");
            if (bind) {
                Variant args[2];
                args[0] = format;
                args[1] = vertex_count;
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

        case CMD_RenderingServer_mesh_add_surface__23__27__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID mesh = read_rid(payload, 8);
            Dictionary surface = read_dictionary(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "mesh_add_surface");
            if (bind) {
                Variant args[2];
                args[0] = mesh;
                args[1] = surface;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_mesh_add_surface_from_arrays__23__2__28__28__27__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID mesh = read_rid(payload, 8);
            int64_t primitive = read_int64(payload, 16);
            Array arrays = read_array(payload, 24);
            Array blend_shapes = read_array(payload, 24);
            Dictionary lods = read_dictionary(payload, 24);
            int64_t compress_format = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "mesh_add_surface_from_arrays");
            if (bind) {
                Variant args[6];
                args[0] = mesh;
                args[1] = primitive;
                args[2] = arrays;
                args[3] = blend_shapes;
                args[4] = lods;
                args[5] = compress_format;
                const Variant *argptrs[6];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                argptrs[4] = &args[4];
                argptrs[5] = &args[5];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 6, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_mesh_get_blend_shape_count__23__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID mesh = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "mesh_get_blend_shape_count");
            if (bind) {
                Variant args[1];
                args[0] = mesh;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_mesh_set_blend_shape_mode__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID mesh = read_rid(payload, 8);
            int64_t mode = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "mesh_set_blend_shape_mode");
            if (bind) {
                Variant args[2];
                args[0] = mesh;
                args[1] = mode;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_mesh_get_blend_shape_mode__23__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID mesh = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "mesh_get_blend_shape_mode");
            if (bind) {
                Variant args[1];
                args[0] = mesh;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_mesh_surface_set_material__23__2__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID mesh = read_rid(payload, 8);
            int64_t surface = read_int64(payload, 16);
            RID material = read_rid(payload, 24);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "mesh_surface_set_material");
            if (bind) {
                Variant args[3];
                args[0] = mesh;
                args[1] = surface;
                args[2] = material;
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

        case CMD_RenderingServer_mesh_surface_get_material__23__2__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID mesh = read_rid(payload, 8);
            int64_t surface = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "mesh_surface_get_material");
            if (bind) {
                Variant args[2];
                args[0] = mesh;
                args[1] = surface;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_mesh_get_surface__23__2__r27: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID mesh = read_rid(payload, 8);
            int64_t surface = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "mesh_get_surface");
            if (bind) {
                Variant args[2];
                args[0] = mesh;
                args[1] = surface;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_mesh_surface_get_arrays__23__2__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID mesh = read_rid(payload, 8);
            int64_t surface = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "mesh_surface_get_arrays");
            if (bind) {
                Variant args[2];
                args[0] = mesh;
                args[1] = surface;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_mesh_surface_get_blend_shape_arrays__23__2__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID mesh = read_rid(payload, 8);
            int64_t surface = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "mesh_surface_get_blend_shape_arrays");
            if (bind) {
                Variant args[2];
                args[0] = mesh;
                args[1] = surface;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_mesh_get_surface_count__23__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID mesh = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "mesh_get_surface_count");
            if (bind) {
                Variant args[1];
                args[0] = mesh;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_mesh_set_custom_aabb__23__16__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID mesh = read_rid(payload, 8);
            AABB aabb = read_aabb(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "mesh_set_custom_aabb");
            if (bind) {
                Variant args[2];
                args[0] = mesh;
                args[1] = aabb;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_mesh_get_custom_aabb__23__r16: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID mesh = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "mesh_get_custom_aabb");
            if (bind) {
                Variant args[1];
                args[0] = mesh;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_mesh_surface_remove__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID mesh = read_rid(payload, 8);
            int64_t surface = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "mesh_surface_remove");
            if (bind) {
                Variant args[2];
                args[0] = mesh;
                args[1] = surface;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_mesh_clear__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID mesh = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "mesh_clear");
            if (bind) {
                Variant args[1];
                args[0] = mesh;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_mesh_surface_update_vertex_region__23__2__2__29__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID mesh = read_rid(payload, 8);
            int64_t surface = read_int64(payload, 16);
            int64_t offset = read_int64(payload, 24);
            PackedByteArray arg_data = read_packed_byte_array(payload, 32);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "mesh_surface_update_vertex_region");
            if (bind) {
                Variant args[4];
                args[0] = mesh;
                args[1] = surface;
                args[2] = offset;
                args[3] = arg_data;
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

        case CMD_RenderingServer_mesh_surface_update_attribute_region__23__2__2__29__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID mesh = read_rid(payload, 8);
            int64_t surface = read_int64(payload, 16);
            int64_t offset = read_int64(payload, 24);
            PackedByteArray arg_data = read_packed_byte_array(payload, 32);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "mesh_surface_update_attribute_region");
            if (bind) {
                Variant args[4];
                args[0] = mesh;
                args[1] = surface;
                args[2] = offset;
                args[3] = arg_data;
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

        case CMD_RenderingServer_mesh_surface_update_skin_region__23__2__2__29__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID mesh = read_rid(payload, 8);
            int64_t surface = read_int64(payload, 16);
            int64_t offset = read_int64(payload, 24);
            PackedByteArray arg_data = read_packed_byte_array(payload, 32);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "mesh_surface_update_skin_region");
            if (bind) {
                Variant args[4];
                args[0] = mesh;
                args[1] = surface;
                args[2] = offset;
                args[3] = arg_data;
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

        case CMD_RenderingServer_mesh_surface_update_index_region__23__2__2__29__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID mesh = read_rid(payload, 8);
            int64_t surface = read_int64(payload, 16);
            int64_t offset = read_int64(payload, 24);
            PackedByteArray arg_data = read_packed_byte_array(payload, 32);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "mesh_surface_update_index_region");
            if (bind) {
                Variant args[4];
                args[0] = mesh;
                args[1] = surface;
                args[2] = offset;
                args[3] = arg_data;
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

        case CMD_RenderingServer_mesh_set_shadow_mesh__23__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID mesh = read_rid(payload, 8);
            RID shadow_mesh = read_rid(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "mesh_set_shadow_mesh");
            if (bind) {
                Variant args[2];
                args[0] = mesh;
                args[1] = shadow_mesh;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_multimesh_create__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "multimesh_create");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_multimesh_allocate_data__23__2__2__1__1__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID multimesh = read_rid(payload, 8);
            int64_t instances = read_int64(payload, 16);
            int64_t transform_format = read_int64(payload, 24);
            bool color_format = (read_int32(payload, 32) != 0);
            bool custom_data_format = (read_int32(payload, 36) != 0);
            bool use_indirect = (read_int32(payload, 40) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "multimesh_allocate_data");
            if (bind) {
                Variant args[6];
                args[0] = multimesh;
                args[1] = instances;
                args[2] = transform_format;
                args[3] = color_format;
                args[4] = custom_data_format;
                args[5] = use_indirect;
                const Variant *argptrs[6];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                argptrs[4] = &args[4];
                argptrs[5] = &args[5];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 6, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_multimesh_get_instance_count__23__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID multimesh = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "multimesh_get_instance_count");
            if (bind) {
                Variant args[1];
                args[0] = multimesh;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_multimesh_set_mesh__23__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID multimesh = read_rid(payload, 8);
            RID mesh = read_rid(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "multimesh_set_mesh");
            if (bind) {
                Variant args[2];
                args[0] = multimesh;
                args[1] = mesh;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_multimesh_instance_set_transform__23__2__18__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID multimesh = read_rid(payload, 8);
            int64_t index = read_int64(payload, 16);
            Transform3D transform = read_transform3d(payload, 24);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "multimesh_instance_set_transform");
            if (bind) {
                Variant args[3];
                args[0] = multimesh;
                args[1] = index;
                args[2] = transform;
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

        case CMD_RenderingServer_multimesh_instance_set_transform_2d__23__2__11__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID multimesh = read_rid(payload, 8);
            int64_t index = read_int64(payload, 16);
            Transform2D transform = read_transform2d(payload, 24);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "multimesh_instance_set_transform_2d");
            if (bind) {
                Variant args[3];
                args[0] = multimesh;
                args[1] = index;
                args[2] = transform;
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

        case CMD_RenderingServer_multimesh_instance_set_color__23__2__20__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID multimesh = read_rid(payload, 8);
            int64_t index = read_int64(payload, 16);
            Color color = read_color(payload, 24);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "multimesh_instance_set_color");
            if (bind) {
                Variant args[3];
                args[0] = multimesh;
                args[1] = index;
                args[2] = color;
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

        case CMD_RenderingServer_multimesh_instance_set_custom_data__23__2__20__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID multimesh = read_rid(payload, 8);
            int64_t index = read_int64(payload, 16);
            Color custom_data = read_color(payload, 24);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "multimesh_instance_set_custom_data");
            if (bind) {
                Variant args[3];
                args[0] = multimesh;
                args[1] = index;
                args[2] = custom_data;
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

        case CMD_RenderingServer_multimesh_get_mesh__23__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID multimesh = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "multimesh_get_mesh");
            if (bind) {
                Variant args[1];
                args[0] = multimesh;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_multimesh_get_aabb__23__r16: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID multimesh = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "multimesh_get_aabb");
            if (bind) {
                Variant args[1];
                args[0] = multimesh;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_multimesh_set_custom_aabb__23__16__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID multimesh = read_rid(payload, 8);
            AABB aabb = read_aabb(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "multimesh_set_custom_aabb");
            if (bind) {
                Variant args[2];
                args[0] = multimesh;
                args[1] = aabb;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_multimesh_get_custom_aabb__23__r16: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID multimesh = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "multimesh_get_custom_aabb");
            if (bind) {
                Variant args[1];
                args[0] = multimesh;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_multimesh_instance_get_transform__23__2__r18: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID multimesh = read_rid(payload, 8);
            int64_t index = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "multimesh_instance_get_transform");
            if (bind) {
                Variant args[2];
                args[0] = multimesh;
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

        case CMD_RenderingServer_multimesh_instance_get_transform_2d__23__2__r11: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID multimesh = read_rid(payload, 8);
            int64_t index = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "multimesh_instance_get_transform_2d");
            if (bind) {
                Variant args[2];
                args[0] = multimesh;
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

        case CMD_RenderingServer_multimesh_instance_get_color__23__2__r20: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID multimesh = read_rid(payload, 8);
            int64_t index = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "multimesh_instance_get_color");
            if (bind) {
                Variant args[2];
                args[0] = multimesh;
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

        case CMD_RenderingServer_multimesh_instance_get_custom_data__23__2__r20: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID multimesh = read_rid(payload, 8);
            int64_t index = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "multimesh_instance_get_custom_data");
            if (bind) {
                Variant args[2];
                args[0] = multimesh;
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

        case CMD_RenderingServer_multimesh_set_visible_instances__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID multimesh = read_rid(payload, 8);
            int64_t visible = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "multimesh_set_visible_instances");
            if (bind) {
                Variant args[2];
                args[0] = multimesh;
                args[1] = visible;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_multimesh_get_visible_instances__23__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID multimesh = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "multimesh_get_visible_instances");
            if (bind) {
                Variant args[1];
                args[0] = multimesh;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_multimesh_set_buffer__23__32__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID multimesh = read_rid(payload, 8);
            PackedFloat32Array arg_buffer = read_packed_float32_array(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "multimesh_set_buffer");
            if (bind) {
                Variant args[2];
                args[0] = multimesh;
                args[1] = arg_buffer;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_multimesh_get_command_buffer_rd_rid__23__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID multimesh = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "multimesh_get_command_buffer_rd_rid");
            if (bind) {
                Variant args[1];
                args[0] = multimesh;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_multimesh_get_buffer_rd_rid__23__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID multimesh = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "multimesh_get_buffer_rd_rid");
            if (bind) {
                Variant args[1];
                args[0] = multimesh;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_multimesh_get_buffer__23__r32: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID multimesh = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "multimesh_get_buffer");
            if (bind) {
                Variant args[1];
                args[0] = multimesh;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_multimesh_set_buffer_interpolated__23__32__32__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID multimesh = read_rid(payload, 8);
            PackedFloat32Array arg_buffer = read_packed_float32_array(payload, 16);
            PackedFloat32Array buffer_previous = read_packed_float32_array(payload, 16 + 4 + (arg_buffer.size() * 4));
            MethodBind *bind = ClassDB::get_method("RenderingServer", "multimesh_set_buffer_interpolated");
            if (bind) {
                Variant args[3];
                args[0] = multimesh;
                args[1] = arg_buffer;
                args[2] = buffer_previous;
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

        case CMD_RenderingServer_multimesh_set_physics_interpolated__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID multimesh = read_rid(payload, 8);
            bool interpolated = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "multimesh_set_physics_interpolated");
            if (bind) {
                Variant args[2];
                args[0] = multimesh;
                args[1] = interpolated;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_multimesh_set_physics_interpolation_quality__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID multimesh = read_rid(payload, 8);
            int64_t quality = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "multimesh_set_physics_interpolation_quality");
            if (bind) {
                Variant args[2];
                args[0] = multimesh;
                args[1] = quality;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_multimesh_instance_reset_physics_interpolation__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID multimesh = read_rid(payload, 8);
            int64_t index = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "multimesh_instance_reset_physics_interpolation");
            if (bind) {
                Variant args[2];
                args[0] = multimesh;
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

        case CMD_RenderingServer_multimesh_instances_reset_physics_interpolation__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID multimesh = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "multimesh_instances_reset_physics_interpolation");
            if (bind) {
                Variant args[1];
                args[0] = multimesh;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_skeleton_create__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "skeleton_create");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_skeleton_allocate_data__23__2__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID skeleton = read_rid(payload, 8);
            int64_t bones = read_int64(payload, 16);
            bool is_2d_skeleton = (read_int32(payload, 24) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "skeleton_allocate_data");
            if (bind) {
                Variant args[3];
                args[0] = skeleton;
                args[1] = bones;
                args[2] = is_2d_skeleton;
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

        case CMD_RenderingServer_skeleton_get_bone_count__23__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID skeleton = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "skeleton_get_bone_count");
            if (bind) {
                Variant args[1];
                args[0] = skeleton;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_skeleton_bone_set_transform__23__2__18__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID skeleton = read_rid(payload, 8);
            int64_t bone = read_int64(payload, 16);
            Transform3D transform = read_transform3d(payload, 24);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "skeleton_bone_set_transform");
            if (bind) {
                Variant args[3];
                args[0] = skeleton;
                args[1] = bone;
                args[2] = transform;
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

        case CMD_RenderingServer_skeleton_bone_get_transform__23__2__r18: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID skeleton = read_rid(payload, 8);
            int64_t bone = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "skeleton_bone_get_transform");
            if (bind) {
                Variant args[2];
                args[0] = skeleton;
                args[1] = bone;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_skeleton_bone_set_transform_2d__23__2__11__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID skeleton = read_rid(payload, 8);
            int64_t bone = read_int64(payload, 16);
            Transform2D transform = read_transform2d(payload, 24);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "skeleton_bone_set_transform_2d");
            if (bind) {
                Variant args[3];
                args[0] = skeleton;
                args[1] = bone;
                args[2] = transform;
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

        case CMD_RenderingServer_skeleton_bone_get_transform_2d__23__2__r11: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID skeleton = read_rid(payload, 8);
            int64_t bone = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "skeleton_bone_get_transform_2d");
            if (bind) {
                Variant args[2];
                args[0] = skeleton;
                args[1] = bone;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_skeleton_set_base_transform_2d__23__11__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID skeleton = read_rid(payload, 8);
            Transform2D base_transform = read_transform2d(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "skeleton_set_base_transform_2d");
            if (bind) {
                Variant args[2];
                args[0] = skeleton;
                args[1] = base_transform;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_directional_light_create__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "directional_light_create");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_omni_light_create__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "omni_light_create");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_spot_light_create__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "spot_light_create");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_light_set_color__23__20__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID light = read_rid(payload, 8);
            Color color = read_color(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "light_set_color");
            if (bind) {
                Variant args[2];
                args[0] = light;
                args[1] = color;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_light_set_param__23__2__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID light = read_rid(payload, 8);
            int64_t param = read_int64(payload, 16);
            double value = read_double(payload, 24);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "light_set_param");
            if (bind) {
                Variant args[3];
                args[0] = light;
                args[1] = param;
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

        case CMD_RenderingServer_light_set_shadow__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID light = read_rid(payload, 8);
            bool enabled = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "light_set_shadow");
            if (bind) {
                Variant args[2];
                args[0] = light;
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

        case CMD_RenderingServer_light_set_projector__23__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID light = read_rid(payload, 8);
            RID texture = read_rid(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "light_set_projector");
            if (bind) {
                Variant args[2];
                args[0] = light;
                args[1] = texture;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_light_set_negative__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID light = read_rid(payload, 8);
            bool enable = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "light_set_negative");
            if (bind) {
                Variant args[2];
                args[0] = light;
                args[1] = enable;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_light_set_cull_mask__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID light = read_rid(payload, 8);
            int64_t mask = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "light_set_cull_mask");
            if (bind) {
                Variant args[2];
                args[0] = light;
                args[1] = mask;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_light_set_distance_fade__23__1__3__3__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID decal = read_rid(payload, 8);
            bool enabled = (read_int32(payload, 16) != 0);
            double begin = read_double(payload, 20);
            double shadow = read_double(payload, 28);
            double length = read_double(payload, 36);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "light_set_distance_fade");
            if (bind) {
                Variant args[5];
                args[0] = decal;
                args[1] = enabled;
                args[2] = begin;
                args[3] = shadow;
                args[4] = length;
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

        case CMD_RenderingServer_light_set_reverse_cull_face_mode__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID light = read_rid(payload, 8);
            bool enabled = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "light_set_reverse_cull_face_mode");
            if (bind) {
                Variant args[2];
                args[0] = light;
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

        case CMD_RenderingServer_light_set_shadow_caster_mask__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID light = read_rid(payload, 8);
            int64_t mask = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "light_set_shadow_caster_mask");
            if (bind) {
                Variant args[2];
                args[0] = light;
                args[1] = mask;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_light_set_bake_mode__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID light = read_rid(payload, 8);
            int64_t bake_mode = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "light_set_bake_mode");
            if (bind) {
                Variant args[2];
                args[0] = light;
                args[1] = bake_mode;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_light_set_max_sdfgi_cascade__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID light = read_rid(payload, 8);
            int64_t cascade = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "light_set_max_sdfgi_cascade");
            if (bind) {
                Variant args[2];
                args[0] = light;
                args[1] = cascade;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_light_omni_set_shadow_mode__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID light = read_rid(payload, 8);
            int64_t mode = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "light_omni_set_shadow_mode");
            if (bind) {
                Variant args[2];
                args[0] = light;
                args[1] = mode;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_light_directional_set_shadow_mode__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID light = read_rid(payload, 8);
            int64_t mode = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "light_directional_set_shadow_mode");
            if (bind) {
                Variant args[2];
                args[0] = light;
                args[1] = mode;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_light_directional_set_blend_splits__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID light = read_rid(payload, 8);
            bool enable = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "light_directional_set_blend_splits");
            if (bind) {
                Variant args[2];
                args[0] = light;
                args[1] = enable;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_light_directional_set_sky_mode__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID light = read_rid(payload, 8);
            int64_t mode = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "light_directional_set_sky_mode");
            if (bind) {
                Variant args[2];
                args[0] = light;
                args[1] = mode;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_light_projectors_set_filter__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t filter = read_int64(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "light_projectors_set_filter");
            if (bind) {
                Variant args[1];
                args[0] = filter;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_lightmaps_set_bicubic_filter__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            bool enable = (read_int32(payload, 8) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "lightmaps_set_bicubic_filter");
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

        case CMD_RenderingServer_positional_soft_shadow_filter_set_quality__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t quality = read_int64(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "positional_soft_shadow_filter_set_quality");
            if (bind) {
                Variant args[1];
                args[0] = quality;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_directional_soft_shadow_filter_set_quality__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t quality = read_int64(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "directional_soft_shadow_filter_set_quality");
            if (bind) {
                Variant args[1];
                args[0] = quality;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_directional_shadow_atlas_set_size__2__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t size = read_int64(payload, 8);
            bool is_16bits = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "directional_shadow_atlas_set_size");
            if (bind) {
                Variant args[2];
                args[0] = size;
                args[1] = is_16bits;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_reflection_probe_create__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "reflection_probe_create");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_reflection_probe_set_update_mode__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID probe = read_rid(payload, 8);
            int64_t mode = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "reflection_probe_set_update_mode");
            if (bind) {
                Variant args[2];
                args[0] = probe;
                args[1] = mode;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_reflection_probe_set_intensity__23__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID probe = read_rid(payload, 8);
            double intensity = read_double(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "reflection_probe_set_intensity");
            if (bind) {
                Variant args[2];
                args[0] = probe;
                args[1] = intensity;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_reflection_probe_set_blend_distance__23__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID probe = read_rid(payload, 8);
            double blend_distance = read_double(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "reflection_probe_set_blend_distance");
            if (bind) {
                Variant args[2];
                args[0] = probe;
                args[1] = blend_distance;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_reflection_probe_set_ambient_mode__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID probe = read_rid(payload, 8);
            int64_t mode = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "reflection_probe_set_ambient_mode");
            if (bind) {
                Variant args[2];
                args[0] = probe;
                args[1] = mode;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_reflection_probe_set_ambient_color__23__20__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID probe = read_rid(payload, 8);
            Color color = read_color(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "reflection_probe_set_ambient_color");
            if (bind) {
                Variant args[2];
                args[0] = probe;
                args[1] = color;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_reflection_probe_set_ambient_energy__23__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID probe = read_rid(payload, 8);
            double energy = read_double(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "reflection_probe_set_ambient_energy");
            if (bind) {
                Variant args[2];
                args[0] = probe;
                args[1] = energy;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_reflection_probe_set_max_distance__23__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID probe = read_rid(payload, 8);
            double distance = read_double(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "reflection_probe_set_max_distance");
            if (bind) {
                Variant args[2];
                args[0] = probe;
                args[1] = distance;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_reflection_probe_set_size__23__9__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID probe = read_rid(payload, 8);
            Vector3 size = read_vector3(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "reflection_probe_set_size");
            if (bind) {
                Variant args[2];
                args[0] = probe;
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

        case CMD_RenderingServer_reflection_probe_set_origin_offset__23__9__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID probe = read_rid(payload, 8);
            Vector3 offset = read_vector3(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "reflection_probe_set_origin_offset");
            if (bind) {
                Variant args[2];
                args[0] = probe;
                args[1] = offset;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_reflection_probe_set_as_interior__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID probe = read_rid(payload, 8);
            bool enable = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "reflection_probe_set_as_interior");
            if (bind) {
                Variant args[2];
                args[0] = probe;
                args[1] = enable;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_reflection_probe_set_enable_box_projection__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID probe = read_rid(payload, 8);
            bool enable = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "reflection_probe_set_enable_box_projection");
            if (bind) {
                Variant args[2];
                args[0] = probe;
                args[1] = enable;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_reflection_probe_set_enable_shadows__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID probe = read_rid(payload, 8);
            bool enable = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "reflection_probe_set_enable_shadows");
            if (bind) {
                Variant args[2];
                args[0] = probe;
                args[1] = enable;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_reflection_probe_set_cull_mask__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID probe = read_rid(payload, 8);
            int64_t layers = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "reflection_probe_set_cull_mask");
            if (bind) {
                Variant args[2];
                args[0] = probe;
                args[1] = layers;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_reflection_probe_set_reflection_mask__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID probe = read_rid(payload, 8);
            int64_t layers = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "reflection_probe_set_reflection_mask");
            if (bind) {
                Variant args[2];
                args[0] = probe;
                args[1] = layers;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_reflection_probe_set_resolution__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID probe = read_rid(payload, 8);
            int64_t resolution = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "reflection_probe_set_resolution");
            if (bind) {
                Variant args[2];
                args[0] = probe;
                args[1] = resolution;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_reflection_probe_set_mesh_lod_threshold__23__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID probe = read_rid(payload, 8);
            double pixels = read_double(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "reflection_probe_set_mesh_lod_threshold");
            if (bind) {
                Variant args[2];
                args[0] = probe;
                args[1] = pixels;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_decal_create__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "decal_create");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_decal_set_size__23__9__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID decal = read_rid(payload, 8);
            Vector3 size = read_vector3(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "decal_set_size");
            if (bind) {
                Variant args[2];
                args[0] = decal;
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

        case CMD_RenderingServer_decal_set_texture__23__2__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID decal = read_rid(payload, 8);
            int64_t type = read_int64(payload, 16);
            RID texture = read_rid(payload, 24);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "decal_set_texture");
            if (bind) {
                Variant args[3];
                args[0] = decal;
                args[1] = type;
                args[2] = texture;
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

        case CMD_RenderingServer_decal_set_emission_energy__23__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID decal = read_rid(payload, 8);
            double energy = read_double(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "decal_set_emission_energy");
            if (bind) {
                Variant args[2];
                args[0] = decal;
                args[1] = energy;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_decal_set_albedo_mix__23__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID decal = read_rid(payload, 8);
            double albedo_mix = read_double(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "decal_set_albedo_mix");
            if (bind) {
                Variant args[2];
                args[0] = decal;
                args[1] = albedo_mix;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_decal_set_modulate__23__20__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID decal = read_rid(payload, 8);
            Color color = read_color(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "decal_set_modulate");
            if (bind) {
                Variant args[2];
                args[0] = decal;
                args[1] = color;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_decal_set_cull_mask__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID decal = read_rid(payload, 8);
            int64_t mask = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "decal_set_cull_mask");
            if (bind) {
                Variant args[2];
                args[0] = decal;
                args[1] = mask;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_decal_set_distance_fade__23__1__3__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID decal = read_rid(payload, 8);
            bool enabled = (read_int32(payload, 16) != 0);
            double begin = read_double(payload, 20);
            double length = read_double(payload, 28);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "decal_set_distance_fade");
            if (bind) {
                Variant args[4];
                args[0] = decal;
                args[1] = enabled;
                args[2] = begin;
                args[3] = length;
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

        case CMD_RenderingServer_decal_set_fade__23__3__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID decal = read_rid(payload, 8);
            double above = read_double(payload, 16);
            double below = read_double(payload, 24);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "decal_set_fade");
            if (bind) {
                Variant args[3];
                args[0] = decal;
                args[1] = above;
                args[2] = below;
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

        case CMD_RenderingServer_decal_set_normal_fade__23__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID decal = read_rid(payload, 8);
            double fade = read_double(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "decal_set_normal_fade");
            if (bind) {
                Variant args[2];
                args[0] = decal;
                args[1] = fade;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_decals_set_filter__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t filter = read_int64(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "decals_set_filter");
            if (bind) {
                Variant args[1];
                args[0] = filter;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_gi_set_use_half_resolution__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            bool half_resolution = (read_int32(payload, 8) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "gi_set_use_half_resolution");
            if (bind) {
                Variant args[1];
                args[0] = half_resolution;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_voxel_gi_create__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "voxel_gi_create");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_voxel_gi_allocate_data__23__18__16__10__29__29__29__30__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID voxel_gi = read_rid(payload, 8);
            Transform3D to_cell_xform = read_transform3d(payload, 16);
            AABB aabb = read_aabb(payload, 64);
            Vector3i octree_size = read_vector3i(payload, 88);
            PackedByteArray octree_cells = read_packed_byte_array(payload, 100);
            PackedByteArray data_cells = read_packed_byte_array(payload, 100 + 4 + octree_cells.size());
            PackedByteArray distance_field = read_packed_byte_array(payload, 100 + 4 + octree_cells.size() + 4 + data_cells.size());
            PackedInt32Array level_counts = read_packed_int32_array(payload, 100 + 4 + octree_cells.size() + 4 + data_cells.size() + 4 + distance_field.size());
            MethodBind *bind = ClassDB::get_method("RenderingServer", "voxel_gi_allocate_data");
            if (bind) {
                Variant args[8];
                args[0] = voxel_gi;
                args[1] = to_cell_xform;
                args[2] = aabb;
                args[3] = octree_size;
                args[4] = octree_cells;
                args[5] = data_cells;
                args[6] = distance_field;
                args[7] = level_counts;
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

        case CMD_RenderingServer_voxel_gi_get_octree_size__23__r10: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID voxel_gi = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "voxel_gi_get_octree_size");
            if (bind) {
                Variant args[1];
                args[0] = voxel_gi;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_voxel_gi_get_octree_cells__23__r29: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID voxel_gi = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "voxel_gi_get_octree_cells");
            if (bind) {
                Variant args[1];
                args[0] = voxel_gi;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_voxel_gi_get_data_cells__23__r29: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID voxel_gi = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "voxel_gi_get_data_cells");
            if (bind) {
                Variant args[1];
                args[0] = voxel_gi;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_voxel_gi_get_distance_field__23__r29: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID voxel_gi = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "voxel_gi_get_distance_field");
            if (bind) {
                Variant args[1];
                args[0] = voxel_gi;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_voxel_gi_get_level_counts__23__r30: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID voxel_gi = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "voxel_gi_get_level_counts");
            if (bind) {
                Variant args[1];
                args[0] = voxel_gi;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_voxel_gi_get_to_cell_xform__23__r18: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID voxel_gi = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "voxel_gi_get_to_cell_xform");
            if (bind) {
                Variant args[1];
                args[0] = voxel_gi;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_voxel_gi_set_dynamic_range__23__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID voxel_gi = read_rid(payload, 8);
            double range = read_double(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "voxel_gi_set_dynamic_range");
            if (bind) {
                Variant args[2];
                args[0] = voxel_gi;
                args[1] = range;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_voxel_gi_set_propagation__23__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID voxel_gi = read_rid(payload, 8);
            double amount = read_double(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "voxel_gi_set_propagation");
            if (bind) {
                Variant args[2];
                args[0] = voxel_gi;
                args[1] = amount;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_voxel_gi_set_energy__23__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID voxel_gi = read_rid(payload, 8);
            double energy = read_double(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "voxel_gi_set_energy");
            if (bind) {
                Variant args[2];
                args[0] = voxel_gi;
                args[1] = energy;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_voxel_gi_set_baked_exposure_normalization__23__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID voxel_gi = read_rid(payload, 8);
            double baked_exposure = read_double(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "voxel_gi_set_baked_exposure_normalization");
            if (bind) {
                Variant args[2];
                args[0] = voxel_gi;
                args[1] = baked_exposure;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_voxel_gi_set_bias__23__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID voxel_gi = read_rid(payload, 8);
            double bias = read_double(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "voxel_gi_set_bias");
            if (bind) {
                Variant args[2];
                args[0] = voxel_gi;
                args[1] = bias;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_voxel_gi_set_normal_bias__23__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID voxel_gi = read_rid(payload, 8);
            double bias = read_double(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "voxel_gi_set_normal_bias");
            if (bind) {
                Variant args[2];
                args[0] = voxel_gi;
                args[1] = bias;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_voxel_gi_set_interior__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID voxel_gi = read_rid(payload, 8);
            bool enable = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "voxel_gi_set_interior");
            if (bind) {
                Variant args[2];
                args[0] = voxel_gi;
                args[1] = enable;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_voxel_gi_set_use_two_bounces__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID voxel_gi = read_rid(payload, 8);
            bool enable = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "voxel_gi_set_use_two_bounces");
            if (bind) {
                Variant args[2];
                args[0] = voxel_gi;
                args[1] = enable;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_voxel_gi_set_quality__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t quality = read_int64(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "voxel_gi_set_quality");
            if (bind) {
                Variant args[1];
                args[0] = quality;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_lightmap_create__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "lightmap_create");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_lightmap_set_textures__23__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID lightmap = read_rid(payload, 8);
            RID light = read_rid(payload, 16);
            bool uses_sh = (read_int32(payload, 24) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "lightmap_set_textures");
            if (bind) {
                Variant args[3];
                args[0] = lightmap;
                args[1] = light;
                args[2] = uses_sh;
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

        case CMD_RenderingServer_lightmap_set_probe_bounds__23__16__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID lightmap = read_rid(payload, 8);
            AABB bounds = read_aabb(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "lightmap_set_probe_bounds");
            if (bind) {
                Variant args[2];
                args[0] = lightmap;
                args[1] = bounds;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_lightmap_set_probe_interior__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID lightmap = read_rid(payload, 8);
            bool interior = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "lightmap_set_probe_interior");
            if (bind) {
                Variant args[2];
                args[0] = lightmap;
                args[1] = interior;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_lightmap_set_probe_capture_data__23__36__37__30__30__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID lightmap = read_rid(payload, 8);
            PackedVector3Array points = read_packed_vector3_array(payload, 16);
            PackedColorArray point_sh = read_packed_color_array(payload, 16);
            PackedInt32Array tetrahedra = read_packed_int32_array(payload, 16);
            PackedInt32Array bsp_tree = read_packed_int32_array(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "lightmap_set_probe_capture_data");
            if (bind) {
                Variant args[5];
                args[0] = lightmap;
                args[1] = points;
                args[2] = point_sh;
                args[3] = tetrahedra;
                args[4] = bsp_tree;
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

        case CMD_RenderingServer_lightmap_get_probe_capture_points__23__r36: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID lightmap = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "lightmap_get_probe_capture_points");
            if (bind) {
                Variant args[1];
                args[0] = lightmap;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_lightmap_get_probe_capture_sh__23__r37: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID lightmap = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "lightmap_get_probe_capture_sh");
            if (bind) {
                Variant args[1];
                args[0] = lightmap;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_lightmap_get_probe_capture_tetrahedra__23__r30: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID lightmap = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "lightmap_get_probe_capture_tetrahedra");
            if (bind) {
                Variant args[1];
                args[0] = lightmap;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_lightmap_get_probe_capture_bsp_tree__23__r30: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID lightmap = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "lightmap_get_probe_capture_bsp_tree");
            if (bind) {
                Variant args[1];
                args[0] = lightmap;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_lightmap_set_baked_exposure_normalization__23__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID lightmap = read_rid(payload, 8);
            double baked_exposure = read_double(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "lightmap_set_baked_exposure_normalization");
            if (bind) {
                Variant args[2];
                args[0] = lightmap;
                args[1] = baked_exposure;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_lightmap_set_probe_capture_update_speed__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            double speed = read_double(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "lightmap_set_probe_capture_update_speed");
            if (bind) {
                Variant args[1];
                args[0] = speed;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_particles_create__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "particles_create");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_particles_set_mode__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID particles = read_rid(payload, 8);
            int64_t mode = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "particles_set_mode");
            if (bind) {
                Variant args[2];
                args[0] = particles;
                args[1] = mode;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_particles_set_emitting__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID particles = read_rid(payload, 8);
            bool emitting = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "particles_set_emitting");
            if (bind) {
                Variant args[2];
                args[0] = particles;
                args[1] = emitting;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_particles_get_emitting__23__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID particles = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "particles_get_emitting");
            if (bind) {
                Variant args[1];
                args[0] = particles;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_particles_set_amount__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID particles = read_rid(payload, 8);
            int64_t amount = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "particles_set_amount");
            if (bind) {
                Variant args[2];
                args[0] = particles;
                args[1] = amount;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_particles_set_amount_ratio__23__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID particles = read_rid(payload, 8);
            double ratio = read_double(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "particles_set_amount_ratio");
            if (bind) {
                Variant args[2];
                args[0] = particles;
                args[1] = ratio;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_particles_set_lifetime__23__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID particles = read_rid(payload, 8);
            double lifetime = read_double(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "particles_set_lifetime");
            if (bind) {
                Variant args[2];
                args[0] = particles;
                args[1] = lifetime;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_particles_set_one_shot__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID particles = read_rid(payload, 8);
            bool one_shot = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "particles_set_one_shot");
            if (bind) {
                Variant args[2];
                args[0] = particles;
                args[1] = one_shot;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_particles_set_pre_process_time__23__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID particles = read_rid(payload, 8);
            double time = read_double(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "particles_set_pre_process_time");
            if (bind) {
                Variant args[2];
                args[0] = particles;
                args[1] = time;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_particles_request_process_time__23__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID particles = read_rid(payload, 8);
            double time = read_double(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "particles_request_process_time");
            if (bind) {
                Variant args[2];
                args[0] = particles;
                args[1] = time;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_particles_set_explosiveness_ratio__23__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID particles = read_rid(payload, 8);
            double ratio = read_double(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "particles_set_explosiveness_ratio");
            if (bind) {
                Variant args[2];
                args[0] = particles;
                args[1] = ratio;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_particles_set_randomness_ratio__23__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID particles = read_rid(payload, 8);
            double ratio = read_double(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "particles_set_randomness_ratio");
            if (bind) {
                Variant args[2];
                args[0] = particles;
                args[1] = ratio;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_particles_set_interp_to_end__23__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID particles = read_rid(payload, 8);
            double factor = read_double(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "particles_set_interp_to_end");
            if (bind) {
                Variant args[2];
                args[0] = particles;
                args[1] = factor;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_particles_set_emitter_velocity__23__9__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID particles = read_rid(payload, 8);
            Vector3 velocity = read_vector3(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "particles_set_emitter_velocity");
            if (bind) {
                Variant args[2];
                args[0] = particles;
                args[1] = velocity;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_particles_set_custom_aabb__23__16__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID particles = read_rid(payload, 8);
            AABB aabb = read_aabb(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "particles_set_custom_aabb");
            if (bind) {
                Variant args[2];
                args[0] = particles;
                args[1] = aabb;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_particles_set_speed_scale__23__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID particles = read_rid(payload, 8);
            double scale = read_double(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "particles_set_speed_scale");
            if (bind) {
                Variant args[2];
                args[0] = particles;
                args[1] = scale;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_particles_set_use_local_coordinates__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID particles = read_rid(payload, 8);
            bool enable = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "particles_set_use_local_coordinates");
            if (bind) {
                Variant args[2];
                args[0] = particles;
                args[1] = enable;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_particles_set_process_material__23__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID particles = read_rid(payload, 8);
            RID material = read_rid(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "particles_set_process_material");
            if (bind) {
                Variant args[2];
                args[0] = particles;
                args[1] = material;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_particles_set_fixed_fps__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID particles = read_rid(payload, 8);
            int64_t fps = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "particles_set_fixed_fps");
            if (bind) {
                Variant args[2];
                args[0] = particles;
                args[1] = fps;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_particles_set_interpolate__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID particles = read_rid(payload, 8);
            bool enable = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "particles_set_interpolate");
            if (bind) {
                Variant args[2];
                args[0] = particles;
                args[1] = enable;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_particles_set_fractional_delta__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID particles = read_rid(payload, 8);
            bool enable = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "particles_set_fractional_delta");
            if (bind) {
                Variant args[2];
                args[0] = particles;
                args[1] = enable;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_particles_set_collision_base_size__23__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID particles = read_rid(payload, 8);
            double size = read_double(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "particles_set_collision_base_size");
            if (bind) {
                Variant args[2];
                args[0] = particles;
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

        case CMD_RenderingServer_particles_set_transform_align__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID particles = read_rid(payload, 8);
            int64_t align = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "particles_set_transform_align");
            if (bind) {
                Variant args[2];
                args[0] = particles;
                args[1] = align;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_particles_set_trails__23__1__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID particles = read_rid(payload, 8);
            bool enable = (read_int32(payload, 16) != 0);
            double length_sec = read_double(payload, 20);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "particles_set_trails");
            if (bind) {
                Variant args[3];
                args[0] = particles;
                args[1] = enable;
                args[2] = length_sec;
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

        case CMD_RenderingServer_particles_set_trail_bind_poses__23__28__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID particles = read_rid(payload, 8);
            Array bind_poses = read_array(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "particles_set_trail_bind_poses");
            if (bind) {
                Variant args[2];
                args[0] = particles;
                args[1] = bind_poses;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_particles_is_inactive__23__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID particles = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "particles_is_inactive");
            if (bind) {
                Variant args[1];
                args[0] = particles;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_particles_request_process__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID particles = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "particles_request_process");
            if (bind) {
                Variant args[1];
                args[0] = particles;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_particles_restart__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID particles = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "particles_restart");
            if (bind) {
                Variant args[1];
                args[0] = particles;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_particles_set_subemitter__23__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID particles = read_rid(payload, 8);
            RID subemitter_particles = read_rid(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "particles_set_subemitter");
            if (bind) {
                Variant args[2];
                args[0] = particles;
                args[1] = subemitter_particles;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_particles_emit__23__18__9__20__20__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID particles = read_rid(payload, 8);
            Transform3D transform = read_transform3d(payload, 16);
            Vector3 velocity = read_vector3(payload, 64);
            Color color = read_color(payload, 76);
            Color custom = read_color(payload, 92);
            int64_t emit_flags = read_int64(payload, 108);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "particles_emit");
            if (bind) {
                Variant args[6];
                args[0] = particles;
                args[1] = transform;
                args[2] = velocity;
                args[3] = color;
                args[4] = custom;
                args[5] = emit_flags;
                const Variant *argptrs[6];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                argptrs[4] = &args[4];
                argptrs[5] = &args[5];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 6, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_particles_set_draw_order__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID particles = read_rid(payload, 8);
            int64_t order = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "particles_set_draw_order");
            if (bind) {
                Variant args[2];
                args[0] = particles;
                args[1] = order;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_particles_set_draw_passes__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID particles = read_rid(payload, 8);
            int64_t count = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "particles_set_draw_passes");
            if (bind) {
                Variant args[2];
                args[0] = particles;
                args[1] = count;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_particles_set_draw_pass_mesh__23__2__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID particles = read_rid(payload, 8);
            int64_t pass = read_int64(payload, 16);
            RID mesh = read_rid(payload, 24);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "particles_set_draw_pass_mesh");
            if (bind) {
                Variant args[3];
                args[0] = particles;
                args[1] = pass;
                args[2] = mesh;
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

        case CMD_RenderingServer_particles_get_current_aabb__23__r16: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID particles = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "particles_get_current_aabb");
            if (bind) {
                Variant args[1];
                args[0] = particles;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_particles_set_emission_transform__23__18__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID particles = read_rid(payload, 8);
            Transform3D transform = read_transform3d(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "particles_set_emission_transform");
            if (bind) {
                Variant args[2];
                args[0] = particles;
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

        case CMD_RenderingServer_particles_collision_create__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "particles_collision_create");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_particles_collision_set_collision_type__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID particles_collision = read_rid(payload, 8);
            int64_t type = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "particles_collision_set_collision_type");
            if (bind) {
                Variant args[2];
                args[0] = particles_collision;
                args[1] = type;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_particles_collision_set_cull_mask__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID particles_collision = read_rid(payload, 8);
            int64_t mask = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "particles_collision_set_cull_mask");
            if (bind) {
                Variant args[2];
                args[0] = particles_collision;
                args[1] = mask;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_particles_collision_set_sphere_radius__23__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID particles_collision = read_rid(payload, 8);
            double radius = read_double(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "particles_collision_set_sphere_radius");
            if (bind) {
                Variant args[2];
                args[0] = particles_collision;
                args[1] = radius;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_particles_collision_set_box_extents__23__9__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID particles_collision = read_rid(payload, 8);
            Vector3 extents = read_vector3(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "particles_collision_set_box_extents");
            if (bind) {
                Variant args[2];
                args[0] = particles_collision;
                args[1] = extents;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_particles_collision_set_attractor_strength__23__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID particles_collision = read_rid(payload, 8);
            double strength = read_double(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "particles_collision_set_attractor_strength");
            if (bind) {
                Variant args[2];
                args[0] = particles_collision;
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

        case CMD_RenderingServer_particles_collision_set_attractor_directionality__23__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID particles_collision = read_rid(payload, 8);
            double amount = read_double(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "particles_collision_set_attractor_directionality");
            if (bind) {
                Variant args[2];
                args[0] = particles_collision;
                args[1] = amount;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_particles_collision_set_attractor_attenuation__23__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID particles_collision = read_rid(payload, 8);
            double curve = read_double(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "particles_collision_set_attractor_attenuation");
            if (bind) {
                Variant args[2];
                args[0] = particles_collision;
                args[1] = curve;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_particles_collision_set_field_texture__23__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID particles_collision = read_rid(payload, 8);
            RID texture = read_rid(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "particles_collision_set_field_texture");
            if (bind) {
                Variant args[2];
                args[0] = particles_collision;
                args[1] = texture;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_particles_collision_height_field_update__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID particles_collision = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "particles_collision_height_field_update");
            if (bind) {
                Variant args[1];
                args[0] = particles_collision;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_particles_collision_set_height_field_resolution__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID particles_collision = read_rid(payload, 8);
            int64_t resolution = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "particles_collision_set_height_field_resolution");
            if (bind) {
                Variant args[2];
                args[0] = particles_collision;
                args[1] = resolution;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_particles_collision_set_height_field_mask__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID particles_collision = read_rid(payload, 8);
            int64_t mask = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "particles_collision_set_height_field_mask");
            if (bind) {
                Variant args[2];
                args[0] = particles_collision;
                args[1] = mask;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_fog_volume_create__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "fog_volume_create");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_fog_volume_set_shape__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID fog_volume = read_rid(payload, 8);
            int64_t shape = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "fog_volume_set_shape");
            if (bind) {
                Variant args[2];
                args[0] = fog_volume;
                args[1] = shape;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_fog_volume_set_size__23__9__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID fog_volume = read_rid(payload, 8);
            Vector3 size = read_vector3(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "fog_volume_set_size");
            if (bind) {
                Variant args[2];
                args[0] = fog_volume;
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

        case CMD_RenderingServer_fog_volume_set_material__23__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID fog_volume = read_rid(payload, 8);
            RID material = read_rid(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "fog_volume_set_material");
            if (bind) {
                Variant args[2];
                args[0] = fog_volume;
                args[1] = material;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_visibility_notifier_create__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "visibility_notifier_create");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_visibility_notifier_set_aabb__23__16__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID notifier = read_rid(payload, 8);
            AABB aabb = read_aabb(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "visibility_notifier_set_aabb");
            if (bind) {
                Variant args[2];
                args[0] = notifier;
                args[1] = aabb;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_visibility_notifier_set_callbacks__23__25__25__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID notifier = read_rid(payload, 8);
            Callable enter_callable = read_callable(payload, 16);
            Callable exit_callable = read_callable(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "visibility_notifier_set_callbacks");
            if (bind) {
                Variant args[3];
                args[0] = notifier;
                args[1] = enter_callable;
                args[2] = exit_callable;
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

        case CMD_RenderingServer_occluder_create__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "occluder_create");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_occluder_set_mesh__23__36__30__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID occluder = read_rid(payload, 8);
            PackedVector3Array vertices = read_packed_vector3_array(payload, 16);
            PackedInt32Array indices = read_packed_int32_array(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "occluder_set_mesh");
            if (bind) {
                Variant args[3];
                args[0] = occluder;
                args[1] = vertices;
                args[2] = indices;
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

        case CMD_RenderingServer_camera_create__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "camera_create");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_camera_set_perspective__23__3__3__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID camera = read_rid(payload, 8);
            double fovy_degrees = read_double(payload, 16);
            double z_near = read_double(payload, 24);
            double z_far = read_double(payload, 32);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "camera_set_perspective");
            if (bind) {
                Variant args[4];
                args[0] = camera;
                args[1] = fovy_degrees;
                args[2] = z_near;
                args[3] = z_far;
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

        case CMD_RenderingServer_camera_set_orthogonal__23__3__3__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID camera = read_rid(payload, 8);
            double size = read_double(payload, 16);
            double z_near = read_double(payload, 24);
            double z_far = read_double(payload, 32);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "camera_set_orthogonal");
            if (bind) {
                Variant args[4];
                args[0] = camera;
                args[1] = size;
                args[2] = z_near;
                args[3] = z_far;
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

        case CMD_RenderingServer_camera_set_frustum__23__3__5__3__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID camera = read_rid(payload, 8);
            double size = read_double(payload, 16);
            Vector2 offset = read_vector2(payload, 24);
            double z_near = read_double(payload, 32);
            double z_far = read_double(payload, 40);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "camera_set_frustum");
            if (bind) {
                Variant args[5];
                args[0] = camera;
                args[1] = size;
                args[2] = offset;
                args[3] = z_near;
                args[4] = z_far;
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

        case CMD_RenderingServer_camera_set_transform__23__18__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID camera = read_rid(payload, 8);
            Transform3D transform = read_transform3d(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "camera_set_transform");
            if (bind) {
                Variant args[2];
                args[0] = camera;
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

        case CMD_RenderingServer_camera_set_cull_mask__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID camera = read_rid(payload, 8);
            int64_t layers = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "camera_set_cull_mask");
            if (bind) {
                Variant args[2];
                args[0] = camera;
                args[1] = layers;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_camera_set_environment__23__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID camera = read_rid(payload, 8);
            RID env = read_rid(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "camera_set_environment");
            if (bind) {
                Variant args[2];
                args[0] = camera;
                args[1] = env;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_camera_set_camera_attributes__23__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID camera = read_rid(payload, 8);
            RID effects = read_rid(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "camera_set_camera_attributes");
            if (bind) {
                Variant args[2];
                args[0] = camera;
                args[1] = effects;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_camera_set_compositor__23__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID camera = read_rid(payload, 8);
            RID compositor = read_rid(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "camera_set_compositor");
            if (bind) {
                Variant args[2];
                args[0] = camera;
                args[1] = compositor;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_camera_set_use_vertical_aspect__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID camera = read_rid(payload, 8);
            bool enable = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "camera_set_use_vertical_aspect");
            if (bind) {
                Variant args[2];
                args[0] = camera;
                args[1] = enable;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_viewport_create__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "viewport_create");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_viewport_set_use_xr__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID viewport = read_rid(payload, 8);
            bool use_xr = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "viewport_set_use_xr");
            if (bind) {
                Variant args[2];
                args[0] = viewport;
                args[1] = use_xr;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_viewport_set_size__23__2__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID viewport = read_rid(payload, 8);
            int64_t width = read_int64(payload, 16);
            int64_t height = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "viewport_set_size");
            if (bind) {
                Variant args[3];
                args[0] = viewport;
                args[1] = width;
                args[2] = height;
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

        case CMD_RenderingServer_viewport_set_active__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID viewport = read_rid(payload, 8);
            bool active = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "viewport_set_active");
            if (bind) {
                Variant args[2];
                args[0] = viewport;
                args[1] = active;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_viewport_set_parent_viewport__23__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID viewport = read_rid(payload, 8);
            RID parent_viewport = read_rid(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "viewport_set_parent_viewport");
            if (bind) {
                Variant args[2];
                args[0] = viewport;
                args[1] = parent_viewport;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_viewport_attach_to_screen__23__7__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID viewport = read_rid(payload, 8);
            Rect2 rect = read_rect2(payload, 16);
            int64_t screen = read_int64(payload, 32);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "viewport_attach_to_screen");
            if (bind) {
                Variant args[3];
                args[0] = viewport;
                args[1] = rect;
                args[2] = screen;
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

        case CMD_RenderingServer_viewport_set_render_direct_to_screen__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID viewport = read_rid(payload, 8);
            bool enabled = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "viewport_set_render_direct_to_screen");
            if (bind) {
                Variant args[2];
                args[0] = viewport;
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

        case CMD_RenderingServer_viewport_set_canvas_cull_mask__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID viewport = read_rid(payload, 8);
            int64_t canvas_cull_mask = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "viewport_set_canvas_cull_mask");
            if (bind) {
                Variant args[2];
                args[0] = viewport;
                args[1] = canvas_cull_mask;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_viewport_set_scaling_3d_mode__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID viewport = read_rid(payload, 8);
            int64_t scaling_3d_mode = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "viewport_set_scaling_3d_mode");
            if (bind) {
                Variant args[2];
                args[0] = viewport;
                args[1] = scaling_3d_mode;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_viewport_set_scaling_3d_scale__23__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID viewport = read_rid(payload, 8);
            double scale = read_double(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "viewport_set_scaling_3d_scale");
            if (bind) {
                Variant args[2];
                args[0] = viewport;
                args[1] = scale;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_viewport_set_fsr_sharpness__23__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID viewport = read_rid(payload, 8);
            double sharpness = read_double(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "viewport_set_fsr_sharpness");
            if (bind) {
                Variant args[2];
                args[0] = viewport;
                args[1] = sharpness;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_viewport_set_texture_mipmap_bias__23__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID viewport = read_rid(payload, 8);
            double mipmap_bias = read_double(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "viewport_set_texture_mipmap_bias");
            if (bind) {
                Variant args[2];
                args[0] = viewport;
                args[1] = mipmap_bias;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_viewport_set_anisotropic_filtering_level__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID viewport = read_rid(payload, 8);
            int64_t anisotropic_filtering_level = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "viewport_set_anisotropic_filtering_level");
            if (bind) {
                Variant args[2];
                args[0] = viewport;
                args[1] = anisotropic_filtering_level;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_viewport_set_update_mode__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID viewport = read_rid(payload, 8);
            int64_t update_mode = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "viewport_set_update_mode");
            if (bind) {
                Variant args[2];
                args[0] = viewport;
                args[1] = update_mode;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_viewport_get_update_mode__23__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID viewport = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "viewport_get_update_mode");
            if (bind) {
                Variant args[1];
                args[0] = viewport;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_viewport_set_clear_mode__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID viewport = read_rid(payload, 8);
            int64_t clear_mode = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "viewport_set_clear_mode");
            if (bind) {
                Variant args[2];
                args[0] = viewport;
                args[1] = clear_mode;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_viewport_get_render_target__23__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID viewport = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "viewport_get_render_target");
            if (bind) {
                Variant args[1];
                args[0] = viewport;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_viewport_get_texture__23__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID viewport = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "viewport_get_texture");
            if (bind) {
                Variant args[1];
                args[0] = viewport;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_viewport_set_disable_3d__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID viewport = read_rid(payload, 8);
            bool disable = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "viewport_set_disable_3d");
            if (bind) {
                Variant args[2];
                args[0] = viewport;
                args[1] = disable;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_viewport_set_disable_2d__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID viewport = read_rid(payload, 8);
            bool disable = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "viewport_set_disable_2d");
            if (bind) {
                Variant args[2];
                args[0] = viewport;
                args[1] = disable;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_viewport_set_environment_mode__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID viewport = read_rid(payload, 8);
            int64_t mode = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "viewport_set_environment_mode");
            if (bind) {
                Variant args[2];
                args[0] = viewport;
                args[1] = mode;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_viewport_attach_camera__23__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID viewport = read_rid(payload, 8);
            RID camera = read_rid(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "viewport_attach_camera");
            if (bind) {
                Variant args[2];
                args[0] = viewport;
                args[1] = camera;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_viewport_set_scenario__23__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID viewport = read_rid(payload, 8);
            RID scenario = read_rid(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "viewport_set_scenario");
            if (bind) {
                Variant args[2];
                args[0] = viewport;
                args[1] = scenario;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_viewport_attach_canvas__23__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID viewport = read_rid(payload, 8);
            RID canvas = read_rid(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "viewport_attach_canvas");
            if (bind) {
                Variant args[2];
                args[0] = viewport;
                args[1] = canvas;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_viewport_remove_canvas__23__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID viewport = read_rid(payload, 8);
            RID canvas = read_rid(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "viewport_remove_canvas");
            if (bind) {
                Variant args[2];
                args[0] = viewport;
                args[1] = canvas;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_viewport_set_snap_2d_transforms_to_pixel__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID viewport = read_rid(payload, 8);
            bool enabled = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "viewport_set_snap_2d_transforms_to_pixel");
            if (bind) {
                Variant args[2];
                args[0] = viewport;
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

        case CMD_RenderingServer_viewport_set_snap_2d_vertices_to_pixel__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID viewport = read_rid(payload, 8);
            bool enabled = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "viewport_set_snap_2d_vertices_to_pixel");
            if (bind) {
                Variant args[2];
                args[0] = viewport;
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

        case CMD_RenderingServer_viewport_set_default_canvas_item_texture_filter__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID viewport = read_rid(payload, 8);
            int64_t filter = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "viewport_set_default_canvas_item_texture_filter");
            if (bind) {
                Variant args[2];
                args[0] = viewport;
                args[1] = filter;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_viewport_set_default_canvas_item_texture_repeat__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID viewport = read_rid(payload, 8);
            int64_t repeat = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "viewport_set_default_canvas_item_texture_repeat");
            if (bind) {
                Variant args[2];
                args[0] = viewport;
                args[1] = repeat;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_viewport_set_canvas_transform__23__23__11__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID viewport = read_rid(payload, 8);
            RID canvas = read_rid(payload, 16);
            Transform2D offset = read_transform2d(payload, 24);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "viewport_set_canvas_transform");
            if (bind) {
                Variant args[3];
                args[0] = viewport;
                args[1] = canvas;
                args[2] = offset;
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

        case CMD_RenderingServer_viewport_set_canvas_stacking__23__23__2__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID viewport = read_rid(payload, 8);
            RID canvas = read_rid(payload, 16);
            int64_t layer = read_int64(payload, 24);
            int64_t sublayer = read_int64(payload, 32);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "viewport_set_canvas_stacking");
            if (bind) {
                Variant args[4];
                args[0] = viewport;
                args[1] = canvas;
                args[2] = layer;
                args[3] = sublayer;
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

        case CMD_RenderingServer_viewport_set_transparent_background__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID viewport = read_rid(payload, 8);
            bool enabled = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "viewport_set_transparent_background");
            if (bind) {
                Variant args[2];
                args[0] = viewport;
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

        case CMD_RenderingServer_viewport_set_global_canvas_transform__23__11__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID viewport = read_rid(payload, 8);
            Transform2D transform = read_transform2d(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "viewport_set_global_canvas_transform");
            if (bind) {
                Variant args[2];
                args[0] = viewport;
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

        case CMD_RenderingServer_viewport_set_sdf_oversize_and_scale__23__2__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID viewport = read_rid(payload, 8);
            int64_t oversize = read_int64(payload, 16);
            int64_t scale = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "viewport_set_sdf_oversize_and_scale");
            if (bind) {
                Variant args[3];
                args[0] = viewport;
                args[1] = oversize;
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

        case CMD_RenderingServer_viewport_set_positional_shadow_atlas_size__23__2__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID viewport = read_rid(payload, 8);
            int64_t size = read_int64(payload, 16);
            bool use_16_bits = (read_int32(payload, 24) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "viewport_set_positional_shadow_atlas_size");
            if (bind) {
                Variant args[3];
                args[0] = viewport;
                args[1] = size;
                args[2] = use_16_bits;
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

        case CMD_RenderingServer_viewport_set_positional_shadow_atlas_quadrant_subdivision__23__2__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID viewport = read_rid(payload, 8);
            int64_t quadrant = read_int64(payload, 16);
            int64_t subdivision = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "viewport_set_positional_shadow_atlas_quadrant_subdivision");
            if (bind) {
                Variant args[3];
                args[0] = viewport;
                args[1] = quadrant;
                args[2] = subdivision;
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

        case CMD_RenderingServer_viewport_set_msaa_3d__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID viewport = read_rid(payload, 8);
            int64_t msaa = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "viewport_set_msaa_3d");
            if (bind) {
                Variant args[2];
                args[0] = viewport;
                args[1] = msaa;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_viewport_set_msaa_2d__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID viewport = read_rid(payload, 8);
            int64_t msaa = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "viewport_set_msaa_2d");
            if (bind) {
                Variant args[2];
                args[0] = viewport;
                args[1] = msaa;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_viewport_set_use_hdr_2d__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID viewport = read_rid(payload, 8);
            bool enabled = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "viewport_set_use_hdr_2d");
            if (bind) {
                Variant args[2];
                args[0] = viewport;
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

        case CMD_RenderingServer_viewport_set_screen_space_aa__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID viewport = read_rid(payload, 8);
            int64_t mode = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "viewport_set_screen_space_aa");
            if (bind) {
                Variant args[2];
                args[0] = viewport;
                args[1] = mode;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_viewport_set_use_taa__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID viewport = read_rid(payload, 8);
            bool enable = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "viewport_set_use_taa");
            if (bind) {
                Variant args[2];
                args[0] = viewport;
                args[1] = enable;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_viewport_set_use_debanding__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID viewport = read_rid(payload, 8);
            bool enable = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "viewport_set_use_debanding");
            if (bind) {
                Variant args[2];
                args[0] = viewport;
                args[1] = enable;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_viewport_set_use_occlusion_culling__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID viewport = read_rid(payload, 8);
            bool enable = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "viewport_set_use_occlusion_culling");
            if (bind) {
                Variant args[2];
                args[0] = viewport;
                args[1] = enable;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_viewport_set_occlusion_rays_per_thread__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t rays_per_thread = read_int64(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "viewport_set_occlusion_rays_per_thread");
            if (bind) {
                Variant args[1];
                args[0] = rays_per_thread;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_viewport_set_occlusion_culling_build_quality__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t quality = read_int64(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "viewport_set_occlusion_culling_build_quality");
            if (bind) {
                Variant args[1];
                args[0] = quality;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_viewport_get_render_info__23__2__2__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID viewport = read_rid(payload, 8);
            int64_t type = read_int64(payload, 16);
            int64_t info = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "viewport_get_render_info");
            if (bind) {
                Variant args[3];
                args[0] = viewport;
                args[1] = type;
                args[2] = info;
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

        case CMD_RenderingServer_viewport_set_debug_draw__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID viewport = read_rid(payload, 8);
            int64_t draw = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "viewport_set_debug_draw");
            if (bind) {
                Variant args[2];
                args[0] = viewport;
                args[1] = draw;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_viewport_set_measure_render_time__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID viewport = read_rid(payload, 8);
            bool enable = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "viewport_set_measure_render_time");
            if (bind) {
                Variant args[2];
                args[0] = viewport;
                args[1] = enable;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_viewport_get_measured_render_time_cpu__23__r3: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID viewport = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "viewport_get_measured_render_time_cpu");
            if (bind) {
                Variant args[1];
                args[0] = viewport;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_double(payload, 0, ret_value.operator double());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_viewport_get_measured_render_time_gpu__23__r3: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID viewport = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "viewport_get_measured_render_time_gpu");
            if (bind) {
                Variant args[1];
                args[0] = viewport;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_double(payload, 0, ret_value.operator double());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_viewport_set_vrs_mode__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID viewport = read_rid(payload, 8);
            int64_t mode = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "viewport_set_vrs_mode");
            if (bind) {
                Variant args[2];
                args[0] = viewport;
                args[1] = mode;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_viewport_set_vrs_update_mode__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID viewport = read_rid(payload, 8);
            int64_t mode = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "viewport_set_vrs_update_mode");
            if (bind) {
                Variant args[2];
                args[0] = viewport;
                args[1] = mode;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_viewport_set_vrs_texture__23__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID viewport = read_rid(payload, 8);
            RID texture = read_rid(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "viewport_set_vrs_texture");
            if (bind) {
                Variant args[2];
                args[0] = viewport;
                args[1] = texture;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_sky_create__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "sky_create");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_sky_set_radiance_size__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID sky = read_rid(payload, 8);
            int64_t radiance_size = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "sky_set_radiance_size");
            if (bind) {
                Variant args[2];
                args[0] = sky;
                args[1] = radiance_size;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_sky_set_mode__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID sky = read_rid(payload, 8);
            int64_t mode = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "sky_set_mode");
            if (bind) {
                Variant args[2];
                args[0] = sky;
                args[1] = mode;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_sky_set_material__23__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID sky = read_rid(payload, 8);
            RID material = read_rid(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "sky_set_material");
            if (bind) {
                Variant args[2];
                args[0] = sky;
                args[1] = material;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_sky_bake_panorama__23__3__1__6__r24: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID sky = read_rid(payload, 8);
            double energy = read_double(payload, 16);
            bool bake_irradiance = (read_int32(payload, 24) != 0);
            Vector2i size = read_vector2i(payload, 28);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "sky_bake_panorama");
            if (bind) {
                Variant args[4];
                args[0] = sky;
                args[1] = energy;
                args[2] = bake_irradiance;
                args[3] = size;
                const Variant *argptrs[4];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 4, error);
                write_object_id(payload, 0, ret_value.operator ObjectID());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_compositor_effect_create__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "compositor_effect_create");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_compositor_effect_set_enabled__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID effect = read_rid(payload, 8);
            bool enabled = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "compositor_effect_set_enabled");
            if (bind) {
                Variant args[2];
                args[0] = effect;
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

        case CMD_RenderingServer_compositor_effect_set_callback__23__2__25__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID effect = read_rid(payload, 8);
            int64_t callback_type = read_int64(payload, 16);
            Callable callback = read_callable(payload, 24);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "compositor_effect_set_callback");
            if (bind) {
                Variant args[3];
                args[0] = effect;
                args[1] = callback_type;
                args[2] = callback;
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

        case CMD_RenderingServer_compositor_effect_set_flag__23__2__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID effect = read_rid(payload, 8);
            int64_t flag = read_int64(payload, 16);
            bool set = (read_int32(payload, 24) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "compositor_effect_set_flag");
            if (bind) {
                Variant args[3];
                args[0] = effect;
                args[1] = flag;
                args[2] = set;
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

        case CMD_RenderingServer_compositor_create__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "compositor_create");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_compositor_set_compositor_effects__23__28__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID compositor = read_rid(payload, 8);
            Array effects = read_array(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "compositor_set_compositor_effects");
            if (bind) {
                Variant args[2];
                args[0] = compositor;
                args[1] = effects;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_environment_create__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "environment_create");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_environment_set_background__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID env = read_rid(payload, 8);
            int64_t bg = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "environment_set_background");
            if (bind) {
                Variant args[2];
                args[0] = env;
                args[1] = bg;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_environment_set_camera_id__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID env = read_rid(payload, 8);
            int64_t id = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "environment_set_camera_id");
            if (bind) {
                Variant args[2];
                args[0] = env;
                args[1] = id;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_environment_set_sky__23__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID env = read_rid(payload, 8);
            RID sky = read_rid(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "environment_set_sky");
            if (bind) {
                Variant args[2];
                args[0] = env;
                args[1] = sky;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_environment_set_sky_custom_fov__23__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID env = read_rid(payload, 8);
            double scale = read_double(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "environment_set_sky_custom_fov");
            if (bind) {
                Variant args[2];
                args[0] = env;
                args[1] = scale;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_environment_set_sky_orientation__23__17__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID env = read_rid(payload, 8);
            Basis orientation = read_basis(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "environment_set_sky_orientation");
            if (bind) {
                Variant args[2];
                args[0] = env;
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

        case CMD_RenderingServer_environment_set_bg_color__23__20__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID env = read_rid(payload, 8);
            Color color = read_color(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "environment_set_bg_color");
            if (bind) {
                Variant args[2];
                args[0] = env;
                args[1] = color;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_environment_set_bg_energy__23__3__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID env = read_rid(payload, 8);
            double multiplier = read_double(payload, 16);
            double exposure_value = read_double(payload, 24);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "environment_set_bg_energy");
            if (bind) {
                Variant args[3];
                args[0] = env;
                args[1] = multiplier;
                args[2] = exposure_value;
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

        case CMD_RenderingServer_environment_set_canvas_max_layer__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID env = read_rid(payload, 8);
            int64_t max_layer = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "environment_set_canvas_max_layer");
            if (bind) {
                Variant args[2];
                args[0] = env;
                args[1] = max_layer;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_environment_set_ambient_light__23__20__2__3__3__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID env = read_rid(payload, 8);
            Color color = read_color(payload, 16);
            int64_t ambient = read_int64(payload, 32);
            double energy = read_double(payload, 40);
            double sky_contribution = read_double(payload, 48);
            int64_t reflection_source = read_int64(payload, 56);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "environment_set_ambient_light");
            if (bind) {
                Variant args[6];
                args[0] = env;
                args[1] = color;
                args[2] = ambient;
                args[3] = energy;
                args[4] = sky_contribution;
                args[5] = reflection_source;
                const Variant *argptrs[6];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                argptrs[4] = &args[4];
                argptrs[5] = &args[5];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 6, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_environment_set_glow__23__1__32__3__3__3__3__2__3__3__3__3__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID env = read_rid(payload, 8);
            bool enable = (read_int32(payload, 16) != 0);
            PackedFloat32Array levels = read_packed_float32_array(payload, 20);
            double intensity = read_double(payload, 20 + 4 + (levels.size() * 4));
            double strength = read_double(payload, 20 + 4 + (levels.size() * 4) + 8);
            double mix = read_double(payload, 20 + 4 + (levels.size() * 4) + 8 + 8);
            double bloom_threshold = read_double(payload, 20 + 4 + (levels.size() * 4) + 8 + 8 + 8);
            int64_t blend_mode = read_int64(payload, 20 + 4 + (levels.size() * 4) + 8 + 8 + 8 + 8);
            double hdr_bleed_threshold = read_double(payload, 20 + 4 + (levels.size() * 4) + 8 + 8 + 8 + 8 + 8);
            double hdr_bleed_scale = read_double(payload, 20 + 4 + (levels.size() * 4) + 8 + 8 + 8 + 8 + 8 + 8);
            double hdr_luminance_cap = read_double(payload, 20 + 4 + (levels.size() * 4) + 8 + 8 + 8 + 8 + 8 + 8 + 8);
            double glow_map_strength = read_double(payload, 20 + 4 + (levels.size() * 4) + 8 + 8 + 8 + 8 + 8 + 8 + 8 + 8);
            RID glow_map = read_rid(payload, 20 + 4 + (levels.size() * 4) + 8 + 8 + 8 + 8 + 8 + 8 + 8 + 8 + 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "environment_set_glow");
            if (bind) {
                Variant args[13];
                args[0] = env;
                args[1] = enable;
                args[2] = levels;
                args[3] = intensity;
                args[4] = strength;
                args[5] = mix;
                args[6] = bloom_threshold;
                args[7] = blend_mode;
                args[8] = hdr_bleed_threshold;
                args[9] = hdr_bleed_scale;
                args[10] = hdr_luminance_cap;
                args[11] = glow_map_strength;
                args[12] = glow_map;
                const Variant *argptrs[13];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                argptrs[4] = &args[4];
                argptrs[5] = &args[5];
                argptrs[6] = &args[6];
                argptrs[7] = &args[7];
                argptrs[8] = &args[8];
                argptrs[9] = &args[9];
                argptrs[10] = &args[10];
                argptrs[11] = &args[11];
                argptrs[12] = &args[12];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 13, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_environment_set_tonemap__23__2__3__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID env = read_rid(payload, 8);
            int64_t tone_mapper = read_int64(payload, 16);
            double exposure = read_double(payload, 24);
            double white = read_double(payload, 32);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "environment_set_tonemap");
            if (bind) {
                Variant args[4];
                args[0] = env;
                args[1] = tone_mapper;
                args[2] = exposure;
                args[3] = white;
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

        case CMD_RenderingServer_environment_set_tonemap_agx_contrast__23__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID env = read_rid(payload, 8);
            double agx_contrast = read_double(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "environment_set_tonemap_agx_contrast");
            if (bind) {
                Variant args[2];
                args[0] = env;
                args[1] = agx_contrast;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_environment_set_adjustment__23__1__3__3__3__1__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID env = read_rid(payload, 8);
            bool enable = (read_int32(payload, 16) != 0);
            double brightness = read_double(payload, 20);
            double contrast = read_double(payload, 28);
            double saturation = read_double(payload, 36);
            bool use_1d_color_correction = (read_int32(payload, 44) != 0);
            RID color_correction = read_rid(payload, 48);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "environment_set_adjustment");
            if (bind) {
                Variant args[7];
                args[0] = env;
                args[1] = enable;
                args[2] = brightness;
                args[3] = contrast;
                args[4] = saturation;
                args[5] = use_1d_color_correction;
                args[6] = color_correction;
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

        case CMD_RenderingServer_environment_set_ssr__23__1__2__3__3__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID env = read_rid(payload, 8);
            bool enable = (read_int32(payload, 16) != 0);
            int64_t max_steps = read_int64(payload, 20);
            double fade_in = read_double(payload, 28);
            double fade_out = read_double(payload, 36);
            double depth_tolerance = read_double(payload, 44);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "environment_set_ssr");
            if (bind) {
                Variant args[6];
                args[0] = env;
                args[1] = enable;
                args[2] = max_steps;
                args[3] = fade_in;
                args[4] = fade_out;
                args[5] = depth_tolerance;
                const Variant *argptrs[6];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                argptrs[4] = &args[4];
                argptrs[5] = &args[5];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 6, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_environment_set_ssao__23__1__3__3__3__3__3__3__3__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID env = read_rid(payload, 8);
            bool enable = (read_int32(payload, 16) != 0);
            double radius = read_double(payload, 20);
            double intensity = read_double(payload, 28);
            double power = read_double(payload, 36);
            double detail = read_double(payload, 44);
            double horizon = read_double(payload, 52);
            double sharpness = read_double(payload, 60);
            double light_affect = read_double(payload, 68);
            double ao_channel_affect = read_double(payload, 76);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "environment_set_ssao");
            if (bind) {
                Variant args[10];
                args[0] = env;
                args[1] = enable;
                args[2] = radius;
                args[3] = intensity;
                args[4] = power;
                args[5] = detail;
                args[6] = horizon;
                args[7] = sharpness;
                args[8] = light_affect;
                args[9] = ao_channel_affect;
                const Variant *argptrs[10];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                argptrs[4] = &args[4];
                argptrs[5] = &args[5];
                argptrs[6] = &args[6];
                argptrs[7] = &args[7];
                argptrs[8] = &args[8];
                argptrs[9] = &args[9];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 10, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_environment_set_fog__23__1__20__3__3__3__3__3__3__3__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID env = read_rid(payload, 8);
            bool enable = (read_int32(payload, 16) != 0);
            Color light_color = read_color(payload, 20);
            double light_energy = read_double(payload, 36);
            double sun_scatter = read_double(payload, 44);
            double density = read_double(payload, 52);
            double height = read_double(payload, 60);
            double height_density = read_double(payload, 68);
            double aerial_perspective = read_double(payload, 76);
            double sky_affect = read_double(payload, 84);
            int64_t fog_mode = read_int64(payload, 92);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "environment_set_fog");
            if (bind) {
                Variant args[11];
                args[0] = env;
                args[1] = enable;
                args[2] = light_color;
                args[3] = light_energy;
                args[4] = sun_scatter;
                args[5] = density;
                args[6] = height;
                args[7] = height_density;
                args[8] = aerial_perspective;
                args[9] = sky_affect;
                args[10] = fog_mode;
                const Variant *argptrs[11];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                argptrs[4] = &args[4];
                argptrs[5] = &args[5];
                argptrs[6] = &args[6];
                argptrs[7] = &args[7];
                argptrs[8] = &args[8];
                argptrs[9] = &args[9];
                argptrs[10] = &args[10];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 11, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_environment_set_fog_depth__23__3__3__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID env = read_rid(payload, 8);
            double curve = read_double(payload, 16);
            double begin = read_double(payload, 24);
            double end = read_double(payload, 32);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "environment_set_fog_depth");
            if (bind) {
                Variant args[4];
                args[0] = env;
                args[1] = curve;
                args[2] = begin;
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

        case CMD_RenderingServer_environment_set_sdfgi__23__1__2__3__2__1__3__1__3__3__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID env = read_rid(payload, 8);
            bool enable = (read_int32(payload, 16) != 0);
            int64_t cascades = read_int64(payload, 20);
            double min_cell_size = read_double(payload, 28);
            int64_t y_scale = read_int64(payload, 36);
            bool use_occlusion = (read_int32(payload, 44) != 0);
            double bounce_feedback = read_double(payload, 48);
            bool read_sky = (read_int32(payload, 56) != 0);
            double energy = read_double(payload, 60);
            double normal_bias = read_double(payload, 68);
            double probe_bias = read_double(payload, 76);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "environment_set_sdfgi");
            if (bind) {
                Variant args[11];
                args[0] = env;
                args[1] = enable;
                args[2] = cascades;
                args[3] = min_cell_size;
                args[4] = y_scale;
                args[5] = use_occlusion;
                args[6] = bounce_feedback;
                args[7] = read_sky;
                args[8] = energy;
                args[9] = normal_bias;
                args[10] = probe_bias;
                const Variant *argptrs[11];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                argptrs[4] = &args[4];
                argptrs[5] = &args[5];
                argptrs[6] = &args[6];
                argptrs[7] = &args[7];
                argptrs[8] = &args[8];
                argptrs[9] = &args[9];
                argptrs[10] = &args[10];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 11, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_environment_set_volumetric_fog__23__1__3__20__20__3__3__3__3__3__1__3__3__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID env = read_rid(payload, 8);
            bool enable = (read_int32(payload, 16) != 0);
            double density = read_double(payload, 20);
            Color albedo = read_color(payload, 28);
            Color emission = read_color(payload, 44);
            double emission_energy = read_double(payload, 60);
            double anisotropy = read_double(payload, 68);
            double length = read_double(payload, 76);
            double p_detail_spread = read_double(payload, 84);
            double gi_inject = read_double(payload, 92);
            bool temporal_reprojection = (read_int32(payload, 100) != 0);
            double temporal_reprojection_amount = read_double(payload, 104);
            double ambient_inject = read_double(payload, 112);
            double sky_affect = read_double(payload, 120);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "environment_set_volumetric_fog");
            if (bind) {
                Variant args[14];
                args[0] = env;
                args[1] = enable;
                args[2] = density;
                args[3] = albedo;
                args[4] = emission;
                args[5] = emission_energy;
                args[6] = anisotropy;
                args[7] = length;
                args[8] = p_detail_spread;
                args[9] = gi_inject;
                args[10] = temporal_reprojection;
                args[11] = temporal_reprojection_amount;
                args[12] = ambient_inject;
                args[13] = sky_affect;
                const Variant *argptrs[14];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                argptrs[4] = &args[4];
                argptrs[5] = &args[5];
                argptrs[6] = &args[6];
                argptrs[7] = &args[7];
                argptrs[8] = &args[8];
                argptrs[9] = &args[9];
                argptrs[10] = &args[10];
                argptrs[11] = &args[11];
                argptrs[12] = &args[12];
                argptrs[13] = &args[13];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 14, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_environment_glow_set_use_bicubic_upscale__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            bool enable = (read_int32(payload, 8) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "environment_glow_set_use_bicubic_upscale");
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

        case CMD_RenderingServer_environment_set_ssr_half_size__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            bool half_size = (read_int32(payload, 8) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "environment_set_ssr_half_size");
            if (bind) {
                Variant args[1];
                args[0] = half_size;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_environment_set_ssr_roughness_quality__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t quality = read_int64(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "environment_set_ssr_roughness_quality");
            if (bind) {
                Variant args[1];
                args[0] = quality;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_environment_set_ssao_quality__2__1__3__2__3__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t quality = read_int64(payload, 8);
            bool half_size = (read_int32(payload, 16) != 0);
            double adaptive_target = read_double(payload, 20);
            int64_t blur_passes = read_int64(payload, 28);
            double fadeout_from = read_double(payload, 36);
            double fadeout_to = read_double(payload, 44);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "environment_set_ssao_quality");
            if (bind) {
                Variant args[6];
                args[0] = quality;
                args[1] = half_size;
                args[2] = adaptive_target;
                args[3] = blur_passes;
                args[4] = fadeout_from;
                args[5] = fadeout_to;
                const Variant *argptrs[6];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                argptrs[4] = &args[4];
                argptrs[5] = &args[5];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 6, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_environment_set_ssil_quality__2__1__3__2__3__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t quality = read_int64(payload, 8);
            bool half_size = (read_int32(payload, 16) != 0);
            double adaptive_target = read_double(payload, 20);
            int64_t blur_passes = read_int64(payload, 28);
            double fadeout_from = read_double(payload, 36);
            double fadeout_to = read_double(payload, 44);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "environment_set_ssil_quality");
            if (bind) {
                Variant args[6];
                args[0] = quality;
                args[1] = half_size;
                args[2] = adaptive_target;
                args[3] = blur_passes;
                args[4] = fadeout_from;
                args[5] = fadeout_to;
                const Variant *argptrs[6];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                argptrs[4] = &args[4];
                argptrs[5] = &args[5];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 6, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_environment_set_sdfgi_ray_count__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t ray_count = read_int64(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "environment_set_sdfgi_ray_count");
            if (bind) {
                Variant args[1];
                args[0] = ray_count;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_environment_set_sdfgi_frames_to_converge__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t frames = read_int64(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "environment_set_sdfgi_frames_to_converge");
            if (bind) {
                Variant args[1];
                args[0] = frames;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_environment_set_sdfgi_frames_to_update_light__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t frames = read_int64(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "environment_set_sdfgi_frames_to_update_light");
            if (bind) {
                Variant args[1];
                args[0] = frames;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_environment_set_volumetric_fog_volume_size__2__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t size = read_int64(payload, 8);
            int64_t depth = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "environment_set_volumetric_fog_volume_size");
            if (bind) {
                Variant args[2];
                args[0] = size;
                args[1] = depth;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_environment_set_volumetric_fog_filter_active__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            bool active = (read_int32(payload, 8) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "environment_set_volumetric_fog_filter_active");
            if (bind) {
                Variant args[1];
                args[0] = active;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_environment_bake_panorama__23__1__6__r24: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID environment = read_rid(payload, 8);
            bool bake_irradiance = (read_int32(payload, 16) != 0);
            Vector2i size = read_vector2i(payload, 20);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "environment_bake_panorama");
            if (bind) {
                Variant args[3];
                args[0] = environment;
                args[1] = bake_irradiance;
                args[2] = size;
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

        case CMD_RenderingServer_screen_space_roughness_limiter_set_active__1__3__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            bool enable = (read_int32(payload, 8) != 0);
            double amount = read_double(payload, 12);
            double limit = read_double(payload, 20);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "screen_space_roughness_limiter_set_active");
            if (bind) {
                Variant args[3];
                args[0] = enable;
                args[1] = amount;
                args[2] = limit;
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

        case CMD_RenderingServer_sub_surface_scattering_set_quality__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t quality = read_int64(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "sub_surface_scattering_set_quality");
            if (bind) {
                Variant args[1];
                args[0] = quality;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_sub_surface_scattering_set_scale__3__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            double scale = read_double(payload, 8);
            double depth_scale = read_double(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "sub_surface_scattering_set_scale");
            if (bind) {
                Variant args[2];
                args[0] = scale;
                args[1] = depth_scale;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_camera_attributes_create__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "camera_attributes_create");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_camera_attributes_set_dof_blur_quality__2__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t quality = read_int64(payload, 8);
            bool use_jitter = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "camera_attributes_set_dof_blur_quality");
            if (bind) {
                Variant args[2];
                args[0] = quality;
                args[1] = use_jitter;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_camera_attributes_set_dof_blur_bokeh_shape__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t shape = read_int64(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "camera_attributes_set_dof_blur_bokeh_shape");
            if (bind) {
                Variant args[1];
                args[0] = shape;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_camera_attributes_set_dof_blur__23__1__3__3__1__3__3__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID camera_attributes = read_rid(payload, 8);
            bool far_enable = (read_int32(payload, 16) != 0);
            double far_distance = read_double(payload, 20);
            double far_transition = read_double(payload, 28);
            bool near_enable = (read_int32(payload, 36) != 0);
            double near_distance = read_double(payload, 40);
            double near_transition = read_double(payload, 48);
            double amount = read_double(payload, 56);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "camera_attributes_set_dof_blur");
            if (bind) {
                Variant args[8];
                args[0] = camera_attributes;
                args[1] = far_enable;
                args[2] = far_distance;
                args[3] = far_transition;
                args[4] = near_enable;
                args[5] = near_distance;
                args[6] = near_transition;
                args[7] = amount;
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

        case CMD_RenderingServer_camera_attributes_set_exposure__23__3__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID camera_attributes = read_rid(payload, 8);
            double multiplier = read_double(payload, 16);
            double normalization = read_double(payload, 24);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "camera_attributes_set_exposure");
            if (bind) {
                Variant args[3];
                args[0] = camera_attributes;
                args[1] = multiplier;
                args[2] = normalization;
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

        case CMD_RenderingServer_camera_attributes_set_auto_exposure__23__1__3__3__3__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID camera_attributes = read_rid(payload, 8);
            bool enable = (read_int32(payload, 16) != 0);
            double min_sensitivity = read_double(payload, 20);
            double max_sensitivity = read_double(payload, 28);
            double speed = read_double(payload, 36);
            double scale = read_double(payload, 44);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "camera_attributes_set_auto_exposure");
            if (bind) {
                Variant args[6];
                args[0] = camera_attributes;
                args[1] = enable;
                args[2] = min_sensitivity;
                args[3] = max_sensitivity;
                args[4] = speed;
                args[5] = scale;
                const Variant *argptrs[6];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                argptrs[4] = &args[4];
                argptrs[5] = &args[5];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 6, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_scenario_create__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "scenario_create");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_scenario_set_environment__23__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID scenario = read_rid(payload, 8);
            RID environment = read_rid(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "scenario_set_environment");
            if (bind) {
                Variant args[2];
                args[0] = scenario;
                args[1] = environment;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_scenario_set_fallback_environment__23__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID scenario = read_rid(payload, 8);
            RID environment = read_rid(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "scenario_set_fallback_environment");
            if (bind) {
                Variant args[2];
                args[0] = scenario;
                args[1] = environment;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_scenario_set_camera_attributes__23__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID scenario = read_rid(payload, 8);
            RID effects = read_rid(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "scenario_set_camera_attributes");
            if (bind) {
                Variant args[2];
                args[0] = scenario;
                args[1] = effects;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_scenario_set_compositor__23__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID scenario = read_rid(payload, 8);
            RID compositor = read_rid(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "scenario_set_compositor");
            if (bind) {
                Variant args[2];
                args[0] = scenario;
                args[1] = compositor;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_instance_create2__23__23__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID base = read_rid(payload, 8);
            RID scenario = read_rid(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "instance_create2");
            if (bind) {
                Variant args[2];
                args[0] = base;
                args[1] = scenario;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_instance_create__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "instance_create");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_instance_set_base__23__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID instance = read_rid(payload, 8);
            RID base = read_rid(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "instance_set_base");
            if (bind) {
                Variant args[2];
                args[0] = instance;
                args[1] = base;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_instance_set_scenario__23__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID instance = read_rid(payload, 8);
            RID scenario = read_rid(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "instance_set_scenario");
            if (bind) {
                Variant args[2];
                args[0] = instance;
                args[1] = scenario;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_instance_set_layer_mask__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID instance = read_rid(payload, 8);
            int64_t mask = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "instance_set_layer_mask");
            if (bind) {
                Variant args[2];
                args[0] = instance;
                args[1] = mask;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_instance_set_pivot_data__23__3__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID instance = read_rid(payload, 8);
            double sorting_offset = read_double(payload, 16);
            bool use_aabb_center = (read_int32(payload, 24) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "instance_set_pivot_data");
            if (bind) {
                Variant args[3];
                args[0] = instance;
                args[1] = sorting_offset;
                args[2] = use_aabb_center;
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

        case CMD_RenderingServer_instance_set_transform__23__18__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID instance = read_rid(payload, 8);
            Transform3D transform = read_transform3d(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "instance_set_transform");
            if (bind) {
                Variant args[2];
                args[0] = instance;
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

        case CMD_RenderingServer_instance_attach_object_instance_id__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID instance = read_rid(payload, 8);
            int64_t id = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "instance_attach_object_instance_id");
            if (bind) {
                Variant args[2];
                args[0] = instance;
                args[1] = id;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_instance_set_blend_shape_weight__23__2__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID instance = read_rid(payload, 8);
            int64_t shape = read_int64(payload, 16);
            double weight = read_double(payload, 24);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "instance_set_blend_shape_weight");
            if (bind) {
                Variant args[3];
                args[0] = instance;
                args[1] = shape;
                args[2] = weight;
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

        case CMD_RenderingServer_instance_set_surface_override_material__23__2__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID instance = read_rid(payload, 8);
            int64_t surface = read_int64(payload, 16);
            RID material = read_rid(payload, 24);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "instance_set_surface_override_material");
            if (bind) {
                Variant args[3];
                args[0] = instance;
                args[1] = surface;
                args[2] = material;
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

        case CMD_RenderingServer_instance_set_visible__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID instance = read_rid(payload, 8);
            bool visible = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "instance_set_visible");
            if (bind) {
                Variant args[2];
                args[0] = instance;
                args[1] = visible;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_instance_geometry_set_transparency__23__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID instance = read_rid(payload, 8);
            double transparency = read_double(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "instance_geometry_set_transparency");
            if (bind) {
                Variant args[2];
                args[0] = instance;
                args[1] = transparency;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_instance_teleport__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID instance = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "instance_teleport");
            if (bind) {
                Variant args[1];
                args[0] = instance;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_instance_set_custom_aabb__23__16__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID instance = read_rid(payload, 8);
            AABB aabb = read_aabb(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "instance_set_custom_aabb");
            if (bind) {
                Variant args[2];
                args[0] = instance;
                args[1] = aabb;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_instance_attach_skeleton__23__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID instance = read_rid(payload, 8);
            RID skeleton = read_rid(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "instance_attach_skeleton");
            if (bind) {
                Variant args[2];
                args[0] = instance;
                args[1] = skeleton;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_instance_set_extra_visibility_margin__23__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID instance = read_rid(payload, 8);
            double margin = read_double(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "instance_set_extra_visibility_margin");
            if (bind) {
                Variant args[2];
                args[0] = instance;
                args[1] = margin;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_instance_set_visibility_parent__23__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID instance = read_rid(payload, 8);
            RID parent = read_rid(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "instance_set_visibility_parent");
            if (bind) {
                Variant args[2];
                args[0] = instance;
                args[1] = parent;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_instance_set_ignore_culling__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID instance = read_rid(payload, 8);
            bool enabled = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "instance_set_ignore_culling");
            if (bind) {
                Variant args[2];
                args[0] = instance;
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

        case CMD_RenderingServer_instance_geometry_set_flag__23__2__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID instance = read_rid(payload, 8);
            int64_t flag = read_int64(payload, 16);
            bool enabled = (read_int32(payload, 24) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "instance_geometry_set_flag");
            if (bind) {
                Variant args[3];
                args[0] = instance;
                args[1] = flag;
                args[2] = enabled;
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

        case CMD_RenderingServer_instance_geometry_set_cast_shadows_setting__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID instance = read_rid(payload, 8);
            int64_t shadow_casting_setting = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "instance_geometry_set_cast_shadows_setting");
            if (bind) {
                Variant args[2];
                args[0] = instance;
                args[1] = shadow_casting_setting;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_instance_geometry_set_material_override__23__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID instance = read_rid(payload, 8);
            RID material = read_rid(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "instance_geometry_set_material_override");
            if (bind) {
                Variant args[2];
                args[0] = instance;
                args[1] = material;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_instance_geometry_set_material_overlay__23__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID instance = read_rid(payload, 8);
            RID material = read_rid(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "instance_geometry_set_material_overlay");
            if (bind) {
                Variant args[2];
                args[0] = instance;
                args[1] = material;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_instance_geometry_set_visibility_range__23__3__3__3__3__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID instance = read_rid(payload, 8);
            double min = read_double(payload, 16);
            double max = read_double(payload, 24);
            double min_margin = read_double(payload, 32);
            double max_margin = read_double(payload, 40);
            int64_t fade_mode = read_int64(payload, 48);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "instance_geometry_set_visibility_range");
            if (bind) {
                Variant args[6];
                args[0] = instance;
                args[1] = min;
                args[2] = max;
                args[3] = min_margin;
                args[4] = max_margin;
                args[5] = fade_mode;
                const Variant *argptrs[6];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                argptrs[4] = &args[4];
                argptrs[5] = &args[5];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 6, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_instance_geometry_set_lightmap__23__23__7__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID instance = read_rid(payload, 8);
            RID lightmap = read_rid(payload, 16);
            Rect2 lightmap_uv_scale = read_rect2(payload, 24);
            int64_t lightmap_slice = read_int64(payload, 40);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "instance_geometry_set_lightmap");
            if (bind) {
                Variant args[4];
                args[0] = instance;
                args[1] = lightmap;
                args[2] = lightmap_uv_scale;
                args[3] = lightmap_slice;
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

        case CMD_RenderingServer_instance_geometry_set_lod_bias__23__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID instance = read_rid(payload, 8);
            double lod_bias = read_double(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "instance_geometry_set_lod_bias");
            if (bind) {
                Variant args[2];
                args[0] = instance;
                args[1] = lod_bias;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_instance_geometry_set_shader_parameter__23__21__0__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID instance = read_rid(payload, 8);
            StringName parameter = read_string_name(payload, 16);
            Variant value;
            MethodBind *bind = ClassDB::get_method("RenderingServer", "instance_geometry_set_shader_parameter");
            if (bind) {
                Variant args[3];
                args[0] = instance;
                args[1] = parameter;
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

        case CMD_RenderingServer_instance_geometry_get_shader_parameter__23__21__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID instance = read_rid(payload, 8);
            StringName parameter = read_string_name(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "instance_geometry_get_shader_parameter");
            if (bind) {
                Variant args[2];
                args[0] = instance;
                args[1] = parameter;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_instance_geometry_get_shader_parameter_default_value__23__21__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID instance = read_rid(payload, 8);
            StringName parameter = read_string_name(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "instance_geometry_get_shader_parameter_default_value");
            if (bind) {
                Variant args[2];
                args[0] = instance;
                args[1] = parameter;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_instance_geometry_get_shader_parameter_list__23__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID instance = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "instance_geometry_get_shader_parameter_list");
            if (bind) {
                Variant args[1];
                args[0] = instance;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_instances_cull_aabb__16__23__r31: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            AABB aabb = read_aabb(payload, 8);
            RID scenario = read_rid(payload, 32);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "instances_cull_aabb");
            if (bind) {
                Variant args[2];
                args[0] = aabb;
                args[1] = scenario;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_instances_cull_ray__9__9__23__r31: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            Vector3 from = read_vector3(payload, 8);
            Vector3 to = read_vector3(payload, 20);
            RID scenario = read_rid(payload, 32);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "instances_cull_ray");
            if (bind) {
                Variant args[3];
                args[0] = from;
                args[1] = to;
                args[2] = scenario;
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

        case CMD_RenderingServer_instances_cull_convex__28__23__r31: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            Array convex = read_array(payload, 8);
            RID scenario = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "instances_cull_convex");
            if (bind) {
                Variant args[2];
                args[0] = convex;
                args[1] = scenario;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_bake_render_uv2__23__28__6__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID base = read_rid(payload, 8);
            Array material_overrides = read_array(payload, 16);
            Vector2i image_size = read_vector2i(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "bake_render_uv2");
            if (bind) {
                Variant args[3];
                args[0] = base;
                args[1] = material_overrides;
                args[2] = image_size;
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

        case CMD_RenderingServer_canvas_create__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_create");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_canvas_set_item_mirroring__23__23__5__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID canvas = read_rid(payload, 8);
            RID item = read_rid(payload, 16);
            Vector2 mirroring = read_vector2(payload, 24);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_set_item_mirroring");
            if (bind) {
                Variant args[3];
                args[0] = canvas;
                args[1] = item;
                args[2] = mirroring;
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

        case CMD_RenderingServer_canvas_set_item_repeat__23__5__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID item = read_rid(payload, 8);
            Vector2 repeat_size = read_vector2(payload, 16);
            int64_t repeat_times = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_set_item_repeat");
            if (bind) {
                Variant args[3];
                args[0] = item;
                args[1] = repeat_size;
                args[2] = repeat_times;
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

        case CMD_RenderingServer_canvas_set_modulate__23__20__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID canvas = read_rid(payload, 8);
            Color color = read_color(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_set_modulate");
            if (bind) {
                Variant args[2];
                args[0] = canvas;
                args[1] = color;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_canvas_set_disable_scale__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            bool disable = (read_int32(payload, 8) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_set_disable_scale");
            if (bind) {
                Variant args[1];
                args[0] = disable;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_canvas_texture_create__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_texture_create");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_canvas_texture_set_channel__23__2__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID canvas_texture = read_rid(payload, 8);
            int64_t channel = read_int64(payload, 16);
            RID texture = read_rid(payload, 24);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_texture_set_channel");
            if (bind) {
                Variant args[3];
                args[0] = canvas_texture;
                args[1] = channel;
                args[2] = texture;
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

        case CMD_RenderingServer_canvas_texture_set_shading_parameters__23__20__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID canvas_texture = read_rid(payload, 8);
            Color base_color = read_color(payload, 16);
            double shininess = read_double(payload, 32);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_texture_set_shading_parameters");
            if (bind) {
                Variant args[3];
                args[0] = canvas_texture;
                args[1] = base_color;
                args[2] = shininess;
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

        case CMD_RenderingServer_canvas_texture_set_texture_filter__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID canvas_texture = read_rid(payload, 8);
            int64_t filter = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_texture_set_texture_filter");
            if (bind) {
                Variant args[2];
                args[0] = canvas_texture;
                args[1] = filter;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_canvas_texture_set_texture_repeat__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID canvas_texture = read_rid(payload, 8);
            int64_t repeat = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_texture_set_texture_repeat");
            if (bind) {
                Variant args[2];
                args[0] = canvas_texture;
                args[1] = repeat;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_canvas_item_create__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_item_create");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_canvas_item_set_parent__23__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID item = read_rid(payload, 8);
            RID parent = read_rid(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_item_set_parent");
            if (bind) {
                Variant args[2];
                args[0] = item;
                args[1] = parent;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_canvas_item_set_default_texture_filter__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID item = read_rid(payload, 8);
            int64_t filter = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_item_set_default_texture_filter");
            if (bind) {
                Variant args[2];
                args[0] = item;
                args[1] = filter;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_canvas_item_set_default_texture_repeat__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID item = read_rid(payload, 8);
            int64_t repeat = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_item_set_default_texture_repeat");
            if (bind) {
                Variant args[2];
                args[0] = item;
                args[1] = repeat;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_canvas_item_set_visible__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID item = read_rid(payload, 8);
            bool visible = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_item_set_visible");
            if (bind) {
                Variant args[2];
                args[0] = item;
                args[1] = visible;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_canvas_item_set_light_mask__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID item = read_rid(payload, 8);
            int64_t mask = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_item_set_light_mask");
            if (bind) {
                Variant args[2];
                args[0] = item;
                args[1] = mask;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_canvas_item_set_visibility_layer__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID item = read_rid(payload, 8);
            int64_t visibility_layer = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_item_set_visibility_layer");
            if (bind) {
                Variant args[2];
                args[0] = item;
                args[1] = visibility_layer;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_canvas_item_set_transform__23__11__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID item = read_rid(payload, 8);
            Transform2D transform = read_transform2d(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_item_set_transform");
            if (bind) {
                Variant args[2];
                args[0] = item;
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

        case CMD_RenderingServer_canvas_item_set_clip__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID item = read_rid(payload, 8);
            bool clip = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_item_set_clip");
            if (bind) {
                Variant args[2];
                args[0] = item;
                args[1] = clip;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_canvas_item_set_distance_field_mode__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID item = read_rid(payload, 8);
            bool enabled = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_item_set_distance_field_mode");
            if (bind) {
                Variant args[2];
                args[0] = item;
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

        case CMD_RenderingServer_canvas_item_set_custom_rect__23__1__7__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID item = read_rid(payload, 8);
            bool use_custom_rect = (read_int32(payload, 16) != 0);
            Rect2 rect = read_rect2(payload, 20);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_item_set_custom_rect");
            if (bind) {
                Variant args[3];
                args[0] = item;
                args[1] = use_custom_rect;
                args[2] = rect;
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

        case CMD_RenderingServer_canvas_item_set_modulate__23__20__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID item = read_rid(payload, 8);
            Color color = read_color(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_item_set_modulate");
            if (bind) {
                Variant args[2];
                args[0] = item;
                args[1] = color;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_canvas_item_set_self_modulate__23__20__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID item = read_rid(payload, 8);
            Color color = read_color(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_item_set_self_modulate");
            if (bind) {
                Variant args[2];
                args[0] = item;
                args[1] = color;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_canvas_item_set_draw_behind_parent__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID item = read_rid(payload, 8);
            bool enabled = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_item_set_draw_behind_parent");
            if (bind) {
                Variant args[2];
                args[0] = item;
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

        case CMD_RenderingServer_canvas_item_set_interpolated__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID item = read_rid(payload, 8);
            bool interpolated = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_item_set_interpolated");
            if (bind) {
                Variant args[2];
                args[0] = item;
                args[1] = interpolated;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_canvas_item_reset_physics_interpolation__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID item = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_item_reset_physics_interpolation");
            if (bind) {
                Variant args[1];
                args[0] = item;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_canvas_item_transform_physics_interpolation__23__11__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID item = read_rid(payload, 8);
            Transform2D transform = read_transform2d(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_item_transform_physics_interpolation");
            if (bind) {
                Variant args[2];
                args[0] = item;
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

        case CMD_RenderingServer_canvas_item_add_line__23__5__5__20__3__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID item = read_rid(payload, 8);
            Vector2 from = read_vector2(payload, 16);
            Vector2 to = read_vector2(payload, 24);
            Color color = read_color(payload, 32);
            double width = read_double(payload, 48);
            bool antialiased = (read_int32(payload, 56) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_item_add_line");
            if (bind) {
                Variant args[6];
                args[0] = item;
                args[1] = from;
                args[2] = to;
                args[3] = color;
                args[4] = width;
                args[5] = antialiased;
                const Variant *argptrs[6];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                argptrs[4] = &args[4];
                argptrs[5] = &args[5];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 6, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_canvas_item_add_polyline__23__35__37__3__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID item = read_rid(payload, 8);
            PackedVector2Array points = read_packed_vector2_array(payload, 16);
            PackedColorArray colors = read_packed_color_array(payload, 16);
            double width = read_double(payload, 16);
            bool antialiased = (read_int32(payload, 24) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_item_add_polyline");
            if (bind) {
                Variant args[5];
                args[0] = item;
                args[1] = points;
                args[2] = colors;
                args[3] = width;
                args[4] = antialiased;
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

        case CMD_RenderingServer_canvas_item_add_multiline__23__35__37__3__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID item = read_rid(payload, 8);
            PackedVector2Array points = read_packed_vector2_array(payload, 16);
            PackedColorArray colors = read_packed_color_array(payload, 16);
            double width = read_double(payload, 16);
            bool antialiased = (read_int32(payload, 24) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_item_add_multiline");
            if (bind) {
                Variant args[5];
                args[0] = item;
                args[1] = points;
                args[2] = colors;
                args[3] = width;
                args[4] = antialiased;
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

        case CMD_RenderingServer_canvas_item_add_rect__23__7__20__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID item = read_rid(payload, 8);
            Rect2 rect = read_rect2(payload, 16);
            Color color = read_color(payload, 32);
            bool antialiased = (read_int32(payload, 48) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_item_add_rect");
            if (bind) {
                Variant args[4];
                args[0] = item;
                args[1] = rect;
                args[2] = color;
                args[3] = antialiased;
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

        case CMD_RenderingServer_canvas_item_add_circle__23__5__3__20__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID item = read_rid(payload, 8);
            Vector2 pos = read_vector2(payload, 16);
            double radius = read_double(payload, 24);
            Color color = read_color(payload, 32);
            bool antialiased = (read_int32(payload, 48) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_item_add_circle");
            if (bind) {
                Variant args[5];
                args[0] = item;
                args[1] = pos;
                args[2] = radius;
                args[3] = color;
                args[4] = antialiased;
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

        case CMD_RenderingServer_canvas_item_add_ellipse__23__5__3__3__20__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID item = read_rid(payload, 8);
            Vector2 pos = read_vector2(payload, 16);
            double major = read_double(payload, 24);
            double minor = read_double(payload, 32);
            Color color = read_color(payload, 40);
            bool antialiased = (read_int32(payload, 56) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_item_add_ellipse");
            if (bind) {
                Variant args[6];
                args[0] = item;
                args[1] = pos;
                args[2] = major;
                args[3] = minor;
                args[4] = color;
                args[5] = antialiased;
                const Variant *argptrs[6];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                argptrs[4] = &args[4];
                argptrs[5] = &args[5];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 6, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_canvas_item_add_texture_rect__23__7__23__1__20__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID item = read_rid(payload, 8);
            Rect2 rect = read_rect2(payload, 16);
            RID texture = read_rid(payload, 32);
            bool tile = (read_int32(payload, 40) != 0);
            Color modulate = read_color(payload, 44);
            bool transpose = (read_int32(payload, 60) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_item_add_texture_rect");
            if (bind) {
                Variant args[6];
                args[0] = item;
                args[1] = rect;
                args[2] = texture;
                args[3] = tile;
                args[4] = modulate;
                args[5] = transpose;
                const Variant *argptrs[6];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                argptrs[4] = &args[4];
                argptrs[5] = &args[5];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 6, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_canvas_item_add_msdf_texture_rect_region__23__7__23__7__20__2__3__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID item = read_rid(payload, 8);
            Rect2 rect = read_rect2(payload, 16);
            RID texture = read_rid(payload, 32);
            Rect2 src_rect = read_rect2(payload, 40);
            Color modulate = read_color(payload, 56);
            int64_t outline_size = read_int64(payload, 72);
            double px_range = read_double(payload, 80);
            double scale = read_double(payload, 88);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_item_add_msdf_texture_rect_region");
            if (bind) {
                Variant args[8];
                args[0] = item;
                args[1] = rect;
                args[2] = texture;
                args[3] = src_rect;
                args[4] = modulate;
                args[5] = outline_size;
                args[6] = px_range;
                args[7] = scale;
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

        case CMD_RenderingServer_canvas_item_add_lcd_texture_rect_region__23__7__23__7__20__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID item = read_rid(payload, 8);
            Rect2 rect = read_rect2(payload, 16);
            RID texture = read_rid(payload, 32);
            Rect2 src_rect = read_rect2(payload, 40);
            Color modulate = read_color(payload, 56);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_item_add_lcd_texture_rect_region");
            if (bind) {
                Variant args[5];
                args[0] = item;
                args[1] = rect;
                args[2] = texture;
                args[3] = src_rect;
                args[4] = modulate;
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

        case CMD_RenderingServer_canvas_item_add_texture_rect_region__23__7__23__7__20__1__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID item = read_rid(payload, 8);
            Rect2 rect = read_rect2(payload, 16);
            RID texture = read_rid(payload, 32);
            Rect2 src_rect = read_rect2(payload, 40);
            Color modulate = read_color(payload, 56);
            bool transpose = (read_int32(payload, 72) != 0);
            bool clip_uv = (read_int32(payload, 76) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_item_add_texture_rect_region");
            if (bind) {
                Variant args[7];
                args[0] = item;
                args[1] = rect;
                args[2] = texture;
                args[3] = src_rect;
                args[4] = modulate;
                args[5] = transpose;
                args[6] = clip_uv;
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

        case CMD_RenderingServer_canvas_item_add_nine_patch__23__7__7__23__5__5__2__2__1__20__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID item = read_rid(payload, 8);
            Rect2 rect = read_rect2(payload, 16);
            Rect2 source = read_rect2(payload, 32);
            RID texture = read_rid(payload, 48);
            Vector2 topleft = read_vector2(payload, 56);
            Vector2 bottomright = read_vector2(payload, 64);
            int64_t x_axis_mode = read_int64(payload, 72);
            int64_t y_axis_mode = read_int64(payload, 80);
            bool draw_center = (read_int32(payload, 88) != 0);
            Color modulate = read_color(payload, 92);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_item_add_nine_patch");
            if (bind) {
                Variant args[10];
                args[0] = item;
                args[1] = rect;
                args[2] = source;
                args[3] = texture;
                args[4] = topleft;
                args[5] = bottomright;
                args[6] = x_axis_mode;
                args[7] = y_axis_mode;
                args[8] = draw_center;
                args[9] = modulate;
                const Variant *argptrs[10];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                argptrs[4] = &args[4];
                argptrs[5] = &args[5];
                argptrs[6] = &args[6];
                argptrs[7] = &args[7];
                argptrs[8] = &args[8];
                argptrs[9] = &args[9];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 10, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_canvas_item_add_primitive__23__35__37__35__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID item = read_rid(payload, 8);
            PackedVector2Array points = read_packed_vector2_array(payload, 16);
            PackedColorArray colors = read_packed_color_array(payload, 16);
            PackedVector2Array uvs = read_packed_vector2_array(payload, 16);
            RID texture = read_rid(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_item_add_primitive");
            if (bind) {
                Variant args[5];
                args[0] = item;
                args[1] = points;
                args[2] = colors;
                args[3] = uvs;
                args[4] = texture;
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

        case CMD_RenderingServer_canvas_item_add_polygon__23__35__37__35__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID item = read_rid(payload, 8);
            PackedVector2Array points = read_packed_vector2_array(payload, 16);
            PackedColorArray colors = read_packed_color_array(payload, 16);
            PackedVector2Array uvs = read_packed_vector2_array(payload, 16);
            RID texture = read_rid(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_item_add_polygon");
            if (bind) {
                Variant args[5];
                args[0] = item;
                args[1] = points;
                args[2] = colors;
                args[3] = uvs;
                args[4] = texture;
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

        case CMD_RenderingServer_canvas_item_add_triangle_array__23__30__35__37__35__30__32__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID item = read_rid(payload, 8);
            PackedInt32Array indices = read_packed_int32_array(payload, 16);
            PackedVector2Array points = read_packed_vector2_array(payload, 16);
            PackedColorArray colors = read_packed_color_array(payload, 16);
            PackedVector2Array uvs = read_packed_vector2_array(payload, 16);
            PackedInt32Array bones = read_packed_int32_array(payload, 16);
            PackedFloat32Array weights = read_packed_float32_array(payload, 16);
            RID texture = read_rid(payload, 16 + 4 + (weights.size() * 4));
            int64_t count = read_int64(payload, 16 + 4 + (weights.size() * 4) + 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_item_add_triangle_array");
            if (bind) {
                Variant args[9];
                args[0] = item;
                args[1] = indices;
                args[2] = points;
                args[3] = colors;
                args[4] = uvs;
                args[5] = bones;
                args[6] = weights;
                args[7] = texture;
                args[8] = count;
                const Variant *argptrs[9];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                argptrs[4] = &args[4];
                argptrs[5] = &args[5];
                argptrs[6] = &args[6];
                argptrs[7] = &args[7];
                argptrs[8] = &args[8];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 9, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_canvas_item_add_mesh__23__23__11__20__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID item = read_rid(payload, 8);
            RID mesh = read_rid(payload, 16);
            Transform2D transform = read_transform2d(payload, 24);
            Color modulate = read_color(payload, 48);
            RID texture = read_rid(payload, 64);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_item_add_mesh");
            if (bind) {
                Variant args[5];
                args[0] = item;
                args[1] = mesh;
                args[2] = transform;
                args[3] = modulate;
                args[4] = texture;
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

        case CMD_RenderingServer_canvas_item_add_multimesh__23__23__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID item = read_rid(payload, 8);
            RID mesh = read_rid(payload, 16);
            RID texture = read_rid(payload, 24);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_item_add_multimesh");
            if (bind) {
                Variant args[3];
                args[0] = item;
                args[1] = mesh;
                args[2] = texture;
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

        case CMD_RenderingServer_canvas_item_add_particles__23__23__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID item = read_rid(payload, 8);
            RID particles = read_rid(payload, 16);
            RID texture = read_rid(payload, 24);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_item_add_particles");
            if (bind) {
                Variant args[3];
                args[0] = item;
                args[1] = particles;
                args[2] = texture;
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

        case CMD_RenderingServer_canvas_item_add_set_transform__23__11__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID item = read_rid(payload, 8);
            Transform2D transform = read_transform2d(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_item_add_set_transform");
            if (bind) {
                Variant args[2];
                args[0] = item;
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

        case CMD_RenderingServer_canvas_item_add_clip_ignore__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID item = read_rid(payload, 8);
            bool ignore = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_item_add_clip_ignore");
            if (bind) {
                Variant args[2];
                args[0] = item;
                args[1] = ignore;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_canvas_item_add_animation_slice__23__3__3__3__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID item = read_rid(payload, 8);
            double animation_length = read_double(payload, 16);
            double slice_begin = read_double(payload, 24);
            double slice_end = read_double(payload, 32);
            double offset = read_double(payload, 40);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_item_add_animation_slice");
            if (bind) {
                Variant args[5];
                args[0] = item;
                args[1] = animation_length;
                args[2] = slice_begin;
                args[3] = slice_end;
                args[4] = offset;
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

        case CMD_RenderingServer_canvas_item_set_sort_children_by_y__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID item = read_rid(payload, 8);
            bool enabled = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_item_set_sort_children_by_y");
            if (bind) {
                Variant args[2];
                args[0] = item;
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

        case CMD_RenderingServer_canvas_item_set_z_index__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID item = read_rid(payload, 8);
            int64_t z_index = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_item_set_z_index");
            if (bind) {
                Variant args[2];
                args[0] = item;
                args[1] = z_index;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_canvas_item_set_z_as_relative_to_parent__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID item = read_rid(payload, 8);
            bool enabled = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_item_set_z_as_relative_to_parent");
            if (bind) {
                Variant args[2];
                args[0] = item;
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

        case CMD_RenderingServer_canvas_item_set_copy_to_backbuffer__23__1__7__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID item = read_rid(payload, 8);
            bool enabled = (read_int32(payload, 16) != 0);
            Rect2 rect = read_rect2(payload, 20);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_item_set_copy_to_backbuffer");
            if (bind) {
                Variant args[3];
                args[0] = item;
                args[1] = enabled;
                args[2] = rect;
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

        case CMD_RenderingServer_canvas_item_attach_skeleton__23__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID item = read_rid(payload, 8);
            RID skeleton = read_rid(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_item_attach_skeleton");
            if (bind) {
                Variant args[2];
                args[0] = item;
                args[1] = skeleton;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_canvas_item_clear__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID item = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_item_clear");
            if (bind) {
                Variant args[1];
                args[0] = item;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_canvas_item_set_draw_index__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID item = read_rid(payload, 8);
            int64_t index = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_item_set_draw_index");
            if (bind) {
                Variant args[2];
                args[0] = item;
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

        case CMD_RenderingServer_canvas_item_set_material__23__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID item = read_rid(payload, 8);
            RID material = read_rid(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_item_set_material");
            if (bind) {
                Variant args[2];
                args[0] = item;
                args[1] = material;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_canvas_item_set_use_parent_material__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID item = read_rid(payload, 8);
            bool enabled = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_item_set_use_parent_material");
            if (bind) {
                Variant args[2];
                args[0] = item;
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

        case CMD_RenderingServer_canvas_item_set_instance_shader_parameter__23__21__0__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID instance = read_rid(payload, 8);
            StringName parameter = read_string_name(payload, 16);
            Variant value;
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_item_set_instance_shader_parameter");
            if (bind) {
                Variant args[3];
                args[0] = instance;
                args[1] = parameter;
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

        case CMD_RenderingServer_canvas_item_get_instance_shader_parameter__23__21__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID instance = read_rid(payload, 8);
            StringName parameter = read_string_name(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_item_get_instance_shader_parameter");
            if (bind) {
                Variant args[2];
                args[0] = instance;
                args[1] = parameter;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_canvas_item_get_instance_shader_parameter_default_value__23__21__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID instance = read_rid(payload, 8);
            StringName parameter = read_string_name(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_item_get_instance_shader_parameter_default_value");
            if (bind) {
                Variant args[2];
                args[0] = instance;
                args[1] = parameter;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_canvas_item_get_instance_shader_parameter_list__23__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID instance = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_item_get_instance_shader_parameter_list");
            if (bind) {
                Variant args[1];
                args[0] = instance;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_canvas_item_set_visibility_notifier__23__1__7__25__25__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID item = read_rid(payload, 8);
            bool enable = (read_int32(payload, 16) != 0);
            Rect2 area = read_rect2(payload, 20);
            Callable enter_callable = read_callable(payload, 36);
            Callable exit_callable = read_callable(payload, 36);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_item_set_visibility_notifier");
            if (bind) {
                Variant args[5];
                args[0] = item;
                args[1] = enable;
                args[2] = area;
                args[3] = enter_callable;
                args[4] = exit_callable;
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

        case CMD_RenderingServer_canvas_item_set_canvas_group_mode__23__2__3__1__3__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID item = read_rid(payload, 8);
            int64_t mode = read_int64(payload, 16);
            double clear_margin = read_double(payload, 24);
            bool fit_empty = (read_int32(payload, 32) != 0);
            double fit_margin = read_double(payload, 36);
            bool blur_mipmaps = (read_int32(payload, 44) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_item_set_canvas_group_mode");
            if (bind) {
                Variant args[6];
                args[0] = item;
                args[1] = mode;
                args[2] = clear_margin;
                args[3] = fit_empty;
                args[4] = fit_margin;
                args[5] = blur_mipmaps;
                const Variant *argptrs[6];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                argptrs[2] = &args[2];
                argptrs[3] = &args[3];
                argptrs[4] = &args[4];
                argptrs[5] = &args[5];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 6, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_debug_canvas_item_get_rect__23__r7: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID item = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "debug_canvas_item_get_rect");
            if (bind) {
                Variant args[1];
                args[0] = item;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_canvas_light_create__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_light_create");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_canvas_light_attach_to_canvas__23__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID light = read_rid(payload, 8);
            RID canvas = read_rid(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_light_attach_to_canvas");
            if (bind) {
                Variant args[2];
                args[0] = light;
                args[1] = canvas;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_canvas_light_set_enabled__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID light = read_rid(payload, 8);
            bool enabled = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_light_set_enabled");
            if (bind) {
                Variant args[2];
                args[0] = light;
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

        case CMD_RenderingServer_canvas_light_set_texture_scale__23__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID light = read_rid(payload, 8);
            double scale = read_double(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_light_set_texture_scale");
            if (bind) {
                Variant args[2];
                args[0] = light;
                args[1] = scale;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_canvas_light_set_transform__23__11__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID light = read_rid(payload, 8);
            Transform2D transform = read_transform2d(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_light_set_transform");
            if (bind) {
                Variant args[2];
                args[0] = light;
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

        case CMD_RenderingServer_canvas_light_set_texture__23__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID light = read_rid(payload, 8);
            RID texture = read_rid(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_light_set_texture");
            if (bind) {
                Variant args[2];
                args[0] = light;
                args[1] = texture;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_canvas_light_set_texture_offset__23__5__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID light = read_rid(payload, 8);
            Vector2 offset = read_vector2(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_light_set_texture_offset");
            if (bind) {
                Variant args[2];
                args[0] = light;
                args[1] = offset;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_canvas_light_set_color__23__20__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID light = read_rid(payload, 8);
            Color color = read_color(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_light_set_color");
            if (bind) {
                Variant args[2];
                args[0] = light;
                args[1] = color;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_canvas_light_set_height__23__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID light = read_rid(payload, 8);
            double height = read_double(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_light_set_height");
            if (bind) {
                Variant args[2];
                args[0] = light;
                args[1] = height;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_canvas_light_set_energy__23__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID light = read_rid(payload, 8);
            double energy = read_double(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_light_set_energy");
            if (bind) {
                Variant args[2];
                args[0] = light;
                args[1] = energy;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_canvas_light_set_z_range__23__2__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID light = read_rid(payload, 8);
            int64_t min_z = read_int64(payload, 16);
            int64_t max_z = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_light_set_z_range");
            if (bind) {
                Variant args[3];
                args[0] = light;
                args[1] = min_z;
                args[2] = max_z;
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

        case CMD_RenderingServer_canvas_light_set_layer_range__23__2__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID light = read_rid(payload, 8);
            int64_t min_layer = read_int64(payload, 16);
            int64_t max_layer = read_int64(payload, 24);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_light_set_layer_range");
            if (bind) {
                Variant args[3];
                args[0] = light;
                args[1] = min_layer;
                args[2] = max_layer;
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

        case CMD_RenderingServer_canvas_light_set_item_cull_mask__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID light = read_rid(payload, 8);
            int64_t mask = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_light_set_item_cull_mask");
            if (bind) {
                Variant args[2];
                args[0] = light;
                args[1] = mask;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_canvas_light_set_item_shadow_cull_mask__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID light = read_rid(payload, 8);
            int64_t mask = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_light_set_item_shadow_cull_mask");
            if (bind) {
                Variant args[2];
                args[0] = light;
                args[1] = mask;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_canvas_light_set_mode__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID light = read_rid(payload, 8);
            int64_t mode = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_light_set_mode");
            if (bind) {
                Variant args[2];
                args[0] = light;
                args[1] = mode;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_canvas_light_set_shadow_enabled__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID light = read_rid(payload, 8);
            bool enabled = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_light_set_shadow_enabled");
            if (bind) {
                Variant args[2];
                args[0] = light;
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

        case CMD_RenderingServer_canvas_light_set_shadow_filter__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID light = read_rid(payload, 8);
            int64_t filter = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_light_set_shadow_filter");
            if (bind) {
                Variant args[2];
                args[0] = light;
                args[1] = filter;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_canvas_light_set_shadow_color__23__20__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID light = read_rid(payload, 8);
            Color color = read_color(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_light_set_shadow_color");
            if (bind) {
                Variant args[2];
                args[0] = light;
                args[1] = color;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_canvas_light_set_shadow_smooth__23__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID light = read_rid(payload, 8);
            double smooth = read_double(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_light_set_shadow_smooth");
            if (bind) {
                Variant args[2];
                args[0] = light;
                args[1] = smooth;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_canvas_light_set_blend_mode__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID light = read_rid(payload, 8);
            int64_t mode = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_light_set_blend_mode");
            if (bind) {
                Variant args[2];
                args[0] = light;
                args[1] = mode;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_canvas_light_set_interpolated__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID light = read_rid(payload, 8);
            bool interpolated = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_light_set_interpolated");
            if (bind) {
                Variant args[2];
                args[0] = light;
                args[1] = interpolated;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_canvas_light_reset_physics_interpolation__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID light = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_light_reset_physics_interpolation");
            if (bind) {
                Variant args[1];
                args[0] = light;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_canvas_light_transform_physics_interpolation__23__11__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID light = read_rid(payload, 8);
            Transform2D transform = read_transform2d(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_light_transform_physics_interpolation");
            if (bind) {
                Variant args[2];
                args[0] = light;
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

        case CMD_RenderingServer_canvas_light_occluder_create__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_light_occluder_create");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_canvas_light_occluder_attach_to_canvas__23__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID occluder = read_rid(payload, 8);
            RID canvas = read_rid(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_light_occluder_attach_to_canvas");
            if (bind) {
                Variant args[2];
                args[0] = occluder;
                args[1] = canvas;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_canvas_light_occluder_set_enabled__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID occluder = read_rid(payload, 8);
            bool enabled = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_light_occluder_set_enabled");
            if (bind) {
                Variant args[2];
                args[0] = occluder;
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

        case CMD_RenderingServer_canvas_light_occluder_set_polygon__23__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID occluder = read_rid(payload, 8);
            RID polygon = read_rid(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_light_occluder_set_polygon");
            if (bind) {
                Variant args[2];
                args[0] = occluder;
                args[1] = polygon;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_canvas_light_occluder_set_as_sdf_collision__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID occluder = read_rid(payload, 8);
            bool enable = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_light_occluder_set_as_sdf_collision");
            if (bind) {
                Variant args[2];
                args[0] = occluder;
                args[1] = enable;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_canvas_light_occluder_set_transform__23__11__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID occluder = read_rid(payload, 8);
            Transform2D transform = read_transform2d(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_light_occluder_set_transform");
            if (bind) {
                Variant args[2];
                args[0] = occluder;
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

        case CMD_RenderingServer_canvas_light_occluder_set_light_mask__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID occluder = read_rid(payload, 8);
            int64_t mask = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_light_occluder_set_light_mask");
            if (bind) {
                Variant args[2];
                args[0] = occluder;
                args[1] = mask;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_canvas_light_occluder_set_interpolated__23__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID occluder = read_rid(payload, 8);
            bool interpolated = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_light_occluder_set_interpolated");
            if (bind) {
                Variant args[2];
                args[0] = occluder;
                args[1] = interpolated;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_canvas_light_occluder_reset_physics_interpolation__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID occluder = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_light_occluder_reset_physics_interpolation");
            if (bind) {
                Variant args[1];
                args[0] = occluder;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_canvas_light_occluder_transform_physics_interpolation__23__11__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID occluder = read_rid(payload, 8);
            Transform2D transform = read_transform2d(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_light_occluder_transform_physics_interpolation");
            if (bind) {
                Variant args[2];
                args[0] = occluder;
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

        case CMD_RenderingServer_canvas_occluder_polygon_create__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_occluder_polygon_create");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_canvas_occluder_polygon_set_shape__23__35__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID occluder_polygon = read_rid(payload, 8);
            PackedVector2Array shape = read_packed_vector2_array(payload, 16);
            bool closed = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_occluder_polygon_set_shape");
            if (bind) {
                Variant args[3];
                args[0] = occluder_polygon;
                args[1] = shape;
                args[2] = closed;
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

        case CMD_RenderingServer_canvas_occluder_polygon_set_cull_mode__23__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID occluder_polygon = read_rid(payload, 8);
            int64_t mode = read_int64(payload, 16);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_occluder_polygon_set_cull_mode");
            if (bind) {
                Variant args[2];
                args[0] = occluder_polygon;
                args[1] = mode;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_canvas_set_shadow_texture_size__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t size = read_int64(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "canvas_set_shadow_texture_size");
            if (bind) {
                Variant args[1];
                args[0] = size;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_global_shader_parameter_add__21__2__0__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName name = read_string_name(payload, 8);
            int64_t type = read_int64(payload, 1036);
            Variant default_value;
            MethodBind *bind = ClassDB::get_method("RenderingServer", "global_shader_parameter_add");
            if (bind) {
                Variant args[3];
                args[0] = name;
                args[1] = type;
                args[2] = default_value;
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

        case CMD_RenderingServer_global_shader_parameter_remove__21__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName name = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "global_shader_parameter_remove");
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

        case CMD_RenderingServer_global_shader_parameter_get_list__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "global_shader_parameter_get_list");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_global_shader_parameter_set__21__0__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName name = read_string_name(payload, 8);
            Variant value;
            MethodBind *bind = ClassDB::get_method("RenderingServer", "global_shader_parameter_set");
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

        case CMD_RenderingServer_global_shader_parameter_set_override__21__0__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName name = read_string_name(payload, 8);
            Variant value;
            MethodBind *bind = ClassDB::get_method("RenderingServer", "global_shader_parameter_set_override");
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

        case CMD_RenderingServer_global_shader_parameter_get__21__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName name = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "global_shader_parameter_get");
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

        case CMD_RenderingServer_global_shader_parameter_get_type__21__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName name = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "global_shader_parameter_get_type");
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

        case CMD_RenderingServer_free_rid__23__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            RID rid = read_rid(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "free_rid");
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

        case CMD_RenderingServer_request_frame_drawn_callback__25__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            Callable callable = read_callable(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "request_frame_drawn_callback");
            if (bind) {
                Variant args[1];
                args[0] = callable;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_has_changed__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "has_changed");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_get_rendering_info__2__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t info = read_int64(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "get_rendering_info");
            if (bind) {
                Variant args[1];
                args[0] = info;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 1, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_get_video_adapter_name__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "get_video_adapter_name");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_get_video_adapter_vendor__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "get_video_adapter_vendor");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_get_video_adapter_type__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "get_video_adapter_type");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
                write_int64(payload, 0, ret_value.operator int64_t());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_get_video_adapter_api_version__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "get_video_adapter_api_version");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_get_current_rendering_driver_name__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "get_current_rendering_driver_name");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_get_current_rendering_method__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "get_current_rendering_method");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_make_sphere_mesh__2__2__3__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t latitudes = read_int64(payload, 8);
            int64_t longitudes = read_int64(payload, 16);
            double radius = read_double(payload, 24);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "make_sphere_mesh");
            if (bind) {
                Variant args[3];
                args[0] = latitudes;
                args[1] = longitudes;
                args[2] = radius;
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

        case CMD_RenderingServer_get_test_cube__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "get_test_cube");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_get_test_texture__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "get_test_texture");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_get_white_texture__r23: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "get_white_texture");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_set_boot_image_with_stretch__24__20__2__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            ObjectID image = read_object_id(payload, 8);
            Color color = read_color(payload, 16);
            int64_t stretch_mode = read_int64(payload, 32);
            bool use_filter = (read_int32(payload, 40) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "set_boot_image_with_stretch");
            if (bind) {
                Variant args[4];
                args[0] = image;
                args[1] = color;
                args[2] = stretch_mode;
                args[3] = use_filter;
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

        case CMD_RenderingServer_set_boot_image__24__20__1__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            ObjectID image = read_object_id(payload, 8);
            Color color = read_color(payload, 16);
            bool scale = (read_int32(payload, 32) != 0);
            bool use_filter = (read_int32(payload, 36) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "set_boot_image");
            if (bind) {
                Variant args[4];
                args[0] = image;
                args[1] = color;
                args[2] = scale;
                args[3] = use_filter;
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

        case CMD_RenderingServer_get_default_clear_color__r20: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "get_default_clear_color");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_set_default_clear_color__20__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            Color color = read_color(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "set_default_clear_color");
            if (bind) {
                Variant args[1];
                args[0] = color;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_has_os_feature__4__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            String feature = read_string_from_data(payload + 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "has_os_feature");
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

        case CMD_RenderingServer_set_debug_generate_wireframes__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            bool generate = (read_int32(payload, 8) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "set_debug_generate_wireframes");
            if (bind) {
                Variant args[1];
                args[0] = generate;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_is_render_loop_enabled__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "is_render_loop_enabled");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_set_render_loop_enabled__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            bool enabled = (read_int32(payload, 8) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "set_render_loop_enabled");
            if (bind) {
                Variant args[1];
                args[0] = enabled;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_get_frame_setup_time_cpu__r3: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "get_frame_setup_time_cpu");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
                write_double(payload, 0, ret_value.operator double());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_force_sync__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "force_sync");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_force_draw__1__3__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            bool swap_buffers = (read_int32(payload, 8) != 0);
            double frame_step = read_double(payload, 12);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "force_draw");
            if (bind) {
                Variant args[2];
                args[0] = swap_buffers;
                args[1] = frame_step;
                const Variant *argptrs[2];
                argptrs[0] = &args[0];
                argptrs[1] = &args[1];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 2, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_get_rendering_device__r24: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "get_rendering_device");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
                write_object_id(payload, 0, ret_value.operator ObjectID());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_create_local_rendering_device__r24: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "create_local_rendering_device");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
                write_object_id(payload, 0, ret_value.operator ObjectID());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_is_on_render_thread__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "is_on_render_thread");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_call_on_render_thread__25__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            Callable callable = read_callable(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "call_on_render_thread");
            if (bind) {
                Variant args[1];
                args[0] = callable;
                const Variant *argptrs[1];
                argptrs[0] = &args[0];
                Callable::CallError error;
                bind->call(target_obj, argptrs, 1, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_has_feature__2__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t feature = read_int64(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "has_feature");
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

        case CMD_RenderingServer_free__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "free");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer__init__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "_init");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer__to_string__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "_to_string");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer__notification__2__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t what = read_int64(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "_notification");
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

        case CMD_RenderingServer__set__21__0__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName property = read_string_name(payload, 8);
            Variant value;
            MethodBind *bind = ClassDB::get_method("RenderingServer", "_set");
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

        case CMD_RenderingServer__get__21__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName property = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "_get");
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

        case CMD_RenderingServer__get_property_list__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "_get_property_list");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer__validate_property__27__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            Dictionary property = read_dictionary(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "_validate_property");
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

        case CMD_RenderingServer__property_can_revert__21__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName property = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "_property_can_revert");
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

        case CMD_RenderingServer__property_get_revert__21__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName property = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "_property_get_revert");
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

        case CMD_RenderingServer__iter_init__28__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            Array iter = read_array(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "_iter_init");
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

        case CMD_RenderingServer__iter_next__28__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            Array iter = read_array(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "_iter_next");
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

        case CMD_RenderingServer__iter_get__0__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            Variant iter;
            MethodBind *bind = ClassDB::get_method("RenderingServer", "_iter_get");
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

        case CMD_RenderingServer_get_class__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "get_class");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_is_class__4__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            String class_ = read_string_from_data(payload + 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "is_class");
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

        case CMD_RenderingServer_set__21__0__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName property = read_string_name(payload, 8);
            Variant value;
            MethodBind *bind = ClassDB::get_method("RenderingServer", "set");
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

        case CMD_RenderingServer_get__21__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName property = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "get");
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

        case CMD_RenderingServer_set_indexed__22__0__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            NodePath property_path = read_node_path(payload, 8);
            Variant value;
            MethodBind *bind = ClassDB::get_method("RenderingServer", "set_indexed");
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

        case CMD_RenderingServer_get_indexed__22__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            NodePath property_path = read_node_path(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "get_indexed");
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

        case CMD_RenderingServer_get_property_list__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "get_property_list");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_get_method_list__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "get_method_list");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_property_can_revert__21__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName property = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "property_can_revert");
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

        case CMD_RenderingServer_property_get_revert__21__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName property = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "property_get_revert");
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

        case CMD_RenderingServer_notification__2__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            int64_t what = read_int64(payload, 8);
            bool reversed = (read_int32(payload, 16) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "notification");
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

        case CMD_RenderingServer_to_string__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "to_string");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_get_instance_id__r24: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "get_instance_id");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
                write_object_id(payload, 0, ret_value.operator ObjectID());
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_set_script__0__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            Variant script;
            MethodBind *bind = ClassDB::get_method("RenderingServer", "set_script");
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

        case CMD_RenderingServer_get_script__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "get_script");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_set_meta__21__0__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName name = read_string_name(payload, 8);
            Variant value;
            MethodBind *bind = ClassDB::get_method("RenderingServer", "set_meta");
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

        case CMD_RenderingServer_remove_meta__21__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName name = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "remove_meta");
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

        case CMD_RenderingServer_get_meta__21__0__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName name = read_string_name(payload, 8);
            Variant default_;
            MethodBind *bind = ClassDB::get_method("RenderingServer", "get_meta");
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

        case CMD_RenderingServer_has_meta__21__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName name = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "has_meta");
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

        case CMD_RenderingServer_get_meta_list__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "get_meta_list");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_add_user_signal__4__28__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            String signal = read_string_from_data(payload + 8);
            Array arguments = read_array(payload, 1036);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "add_user_signal");
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

        case CMD_RenderingServer_has_user_signal__21__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName signal = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "has_user_signal");
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

        case CMD_RenderingServer_remove_user_signal__21__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName signal = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "remove_user_signal");
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

        case CMD_RenderingServer_emit_signal__21__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName signal = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "emit_signal");
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

        case CMD_RenderingServer_call__21__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName method = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "call");
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

        case CMD_RenderingServer_call_deferred__21__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName method = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "call_deferred");
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

        case CMD_RenderingServer_set_deferred__21__0__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName property = read_string_name(payload, 8);
            Variant value;
            MethodBind *bind = ClassDB::get_method("RenderingServer", "set_deferred");
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

        case CMD_RenderingServer_callv__21__28__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName method = read_string_name(payload, 8);
            Array arg_array = read_array(payload, 1036);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "callv");
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

        case CMD_RenderingServer_has_method__21__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName method = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "has_method");
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

        case CMD_RenderingServer_get_method_argument_count__21__r2: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName method = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "get_method_argument_count");
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

        case CMD_RenderingServer_has_signal__21__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName signal = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "has_signal");
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

        case CMD_RenderingServer_get_signal_list__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "get_signal_list");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_get_signal_connection_list__21__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName signal = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "get_signal_connection_list");
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

        case CMD_RenderingServer_get_incoming_connections__r28: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "get_incoming_connections");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_connect__21__25__2__r2: {
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
            MethodBind *bind = ClassDB::get_method("RenderingServer", "connect");
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

        case CMD_RenderingServer_disconnect__21__25__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName signal = read_string_name(payload, 8);
            Callable callable = read_callable(payload, 1036);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "disconnect");
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

        case CMD_RenderingServer_is_connected__21__25__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName signal = read_string_name(payload, 8);
            Callable callable = read_callable(payload, 1036);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "is_connected");
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

        case CMD_RenderingServer_has_connections__21__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName signal = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "has_connections");
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

        case CMD_RenderingServer_set_block_signals__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            bool enable = (read_int32(payload, 8) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "set_block_signals");
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

        case CMD_RenderingServer_is_blocking_signals__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "is_blocking_signals");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_notify_property_list_changed__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "notify_property_list_changed");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_set_message_translation__1__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            bool enable = (read_int32(payload, 8) != 0);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "set_message_translation");
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

        case CMD_RenderingServer_can_translate_messages__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "can_translate_messages");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_tr__21__21__r4: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName message = read_string_name(payload, 8);
            StringName context = read_string_name(payload, 1036);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "tr");
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

        case CMD_RenderingServer_tr_n__21__21__2__21__r4: {
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
            MethodBind *bind = ClassDB::get_method("RenderingServer", "tr_n");
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

        case CMD_RenderingServer_get_translation_domain__r21: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "get_translation_domain");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_set_translation_domain__21__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            StringName domain = read_string_name(payload, 8);
            MethodBind *bind = ClassDB::get_method("RenderingServer", "set_translation_domain");
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

        case CMD_RenderingServer_is_queued_for_deletion__r1: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "is_queued_for_deletion");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                Variant ret_value = bind->call(target_obj, argptrs, 0, error);
                write_int32(payload, 0, ret_value.operator bool() ? 1 : 0);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_cancel_free__r0: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "cancel_free");
            if (bind) {
                const Variant **argptrs = nullptr;
                Callable::CallError error;
                bind->call(target_obj, argptrs, 0, error);
            }
            *status_ptr = STATUS_DONE;
            *cmd_ptr = CMD_NONE;
        } break;

        case CMD_RenderingServer_get_singleton__r24: {
            ObjectID target_id = read_object_id(payload, 0);
            Object *target_obj = ObjectDB::get_instance(target_id);
            if (!target_obj) {
                *status_ptr = STATUS_DONE;
                *cmd_ptr = CMD_NONE;
                break;
            }

            MethodBind *bind = ClassDB::get_method("RenderingServer", "get_singleton");
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
