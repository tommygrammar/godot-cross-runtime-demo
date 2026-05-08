using System;

namespace GodotWeb
{
    public class OpenXRAPIExtension : GodotObject
    {
        public OpenXRAPIExtension(ulong id) : base(id) { }

        public long get_openxr_version()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_get_openxr_version__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long get_instance()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_get_instance__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long get_system_id()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_get_system_id__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long get_session()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_get_session__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public Transform3D transform_from_pose(long pose)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, pose);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_transform_from_pose__2__r18);
            Helpers.WaitForCompletion();
            Transform3D result = Helpers.ReadTransform3D(Commands.CMD_DATA);
            return result;
        }

        public bool xr_result(long arg_result, string format, object args)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, arg_result);
            Helpers.WriteString(Commands.CMD_DATA + 16, format);
            Helpers.WriteArray(Commands.CMD_DATA + 1044, args);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_xr_result__2__4__28__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool openxr_is_enabled(bool check_run_in_editor)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, check_run_in_editor ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_openxr_is_enabled__1__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public long get_instance_proc_addr(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_get_instance_proc_addr__4__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public string get_error_string(long arg_result)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, arg_result);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_get_error_string__2__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public string get_swapchain_format_name(long swapchain_format)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, swapchain_format);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_get_swapchain_format_name__2__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void set_object_name(long object_type, long object_handle, string object_name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, object_type);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, object_handle);
            Helpers.WriteString(Commands.CMD_DATA + 24, object_name);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_set_object_name__2__2__4__r0);
            Helpers.WaitForCompletion();
        }

        public void begin_debug_label_region(string label_name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, label_name);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_begin_debug_label_region__4__r0);
            Helpers.WaitForCompletion();
        }

        public void end_debug_label_region()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_end_debug_label_region__r0);
            Helpers.WaitForCompletion();
        }

        public void insert_debug_label(string label_name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, label_name);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_insert_debug_label__4__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_initialized()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_is_initialized__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool is_running()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_is_running__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_custom_play_space(long space)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, space);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_set_custom_play_space__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_play_space()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_get_play_space__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long get_predicted_display_time()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_get_predicted_display_time__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long get_next_frame_time()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_get_next_frame_time__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool can_render()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_can_render__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public ulong find_action(string name, ulong action_set)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, name);
            Helpers.WriteRID(Commands.CMD_DATA + 1036, action_set);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_find_action__4__23__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public long action_get_handle(ulong action)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, action);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_action_get_handle__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long get_hand_tracker(long hand_index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, hand_index);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_get_hand_tracker__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void register_composition_layer_provider(ulong extension)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, extension);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_register_composition_layer_provider__24__r0);
            Helpers.WaitForCompletion();
        }

        public void unregister_composition_layer_provider(ulong extension)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, extension);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_unregister_composition_layer_provider__24__r0);
            Helpers.WaitForCompletion();
        }

        public void register_projection_views_extension(ulong extension)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, extension);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_register_projection_views_extension__24__r0);
            Helpers.WaitForCompletion();
        }

        public void unregister_projection_views_extension(ulong extension)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, extension);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_unregister_projection_views_extension__24__r0);
            Helpers.WaitForCompletion();
        }

        public void register_frame_info_extension(ulong extension)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, extension);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_register_frame_info_extension__24__r0);
            Helpers.WaitForCompletion();
        }

        public void unregister_frame_info_extension(ulong extension)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, extension);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_unregister_frame_info_extension__24__r0);
            Helpers.WaitForCompletion();
        }

        public double get_render_state_z_near()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_get_render_state_z_near__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public double get_render_state_z_far()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_get_render_state_z_far__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void set_velocity_texture(ulong render_target)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, render_target);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_set_velocity_texture__23__r0);
            Helpers.WaitForCompletion();
        }

        public void set_velocity_depth_texture(ulong render_target)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, render_target);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_set_velocity_depth_texture__23__r0);
            Helpers.WaitForCompletion();
        }

        public void set_velocity_target_size(Vector2i target_size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVector2i(Commands.CMD_DATA + 8, target_size);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_set_velocity_target_size__6__r0);
            Helpers.WaitForCompletion();
        }

        public long[] get_supported_swapchain_formats()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_get_supported_swapchain_formats__r31);
            Helpers.WaitForCompletion();
            long[] result = Helpers.ReadPackedInt64Array(Commands.CMD_DATA);
            return result;
        }

        public long openxr_swapchain_create(long create_flags, long usage_flags, long swapchain_format, long width, long height, long sample_count, long array_size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, create_flags);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, usage_flags);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, swapchain_format);
            Helpers.WriteInt64(Commands.CMD_DATA + 32, width);
            Helpers.WriteInt64(Commands.CMD_DATA + 40, height);
            Helpers.WriteInt64(Commands.CMD_DATA + 48, sample_count);
            Helpers.WriteInt64(Commands.CMD_DATA + 56, array_size);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_openxr_swapchain_create__2__2__2__2__2__2__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void openxr_swapchain_free(long swapchain)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, swapchain);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_openxr_swapchain_free__2__r0);
            Helpers.WaitForCompletion();
        }

        public long openxr_swapchain_get_swapchain(long swapchain)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, swapchain);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_openxr_swapchain_get_swapchain__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void openxr_swapchain_acquire(long swapchain)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, swapchain);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_openxr_swapchain_acquire__2__r0);
            Helpers.WaitForCompletion();
        }

        public ulong openxr_swapchain_get_image(long swapchain)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, swapchain);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_openxr_swapchain_get_image__2__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void openxr_swapchain_release(long swapchain)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, swapchain);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_openxr_swapchain_release__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_projection_layer()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_get_projection_layer__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_render_region(Rect2i render_region)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRect2i(Commands.CMD_DATA + 8, render_region);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_set_render_region__8__r0);
            Helpers.WaitForCompletion();
        }

        public void set_emulate_environment_blend_mode_alpha_blend(bool enabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_set_emulate_environment_blend_mode_alpha_blend__1__r0);
            Helpers.WaitForCompletion();
        }

        public long is_environment_blend_mode_alpha_supported()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_is_environment_blend_mode_alpha_supported__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void update_main_swapchain_size()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_update_main_swapchain_size__r0);
            Helpers.WaitForCompletion();
        }

        public bool init_ref()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_init_ref__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool reference()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_reference__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool unreference()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_unreference__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public long get_reference_count()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_get_reference_count__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void free()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_free__r0);
            Helpers.WaitForCompletion();
        }

        public void _init()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension__init__r0);
            Helpers.WaitForCompletion();
        }

        public string _to_string()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension__to_string__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void _notification(long what)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, what);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension__notification__2__r0);
            Helpers.WaitForCompletion();
        }

        public bool _set(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension__set__21__0__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _get(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension__get__21__r0);
            Helpers.WaitForCompletion();
        }

        public object _get_property_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension__get_property_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void _validate_property(object property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDictionary(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension__validate_property__27__r0);
            Helpers.WaitForCompletion();
        }

        public bool _property_can_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension__property_can_revert__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _property_get_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension__property_get_revert__21__r0);
            Helpers.WaitForCompletion();
        }

        public bool _iter_init(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteArray(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension__iter_init__28__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool _iter_next(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteArray(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension__iter_next__28__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _iter_get(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVariant(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension__iter_get__0__r0);
            Helpers.WaitForCompletion();
        }

        public string get_class()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_get_class__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public bool is_class(string class_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, class_);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_is_class__4__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_set__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_get__21__r0);
            Helpers.WaitForCompletion();
        }

        public void set_indexed(string property_path, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, property_path);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_set_indexed__22__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get_indexed(string property_path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, property_path);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_get_indexed__22__r0);
            Helpers.WaitForCompletion();
        }

        public object get_property_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_get_property_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_method_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_get_method_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public bool property_can_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_property_can_revert__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void property_get_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_property_get_revert__21__r0);
            Helpers.WaitForCompletion();
        }

        public void notification(long what, bool reversed)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, what);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, reversed ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_notification__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public string to_string()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_to_string__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public ulong get_instance_id()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_get_instance_id__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_script(object script)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVariant(Commands.CMD_DATA + 8, script);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_set_script__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get_script()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_get_script__r0);
            Helpers.WaitForCompletion();
        }

        public void set_meta(string name, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_set_meta__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void remove_meta(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_remove_meta__21__r0);
            Helpers.WaitForCompletion();
        }

        public void get_meta(string name, object default_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, default_);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_get_meta__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_meta(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_has_meta__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public object get_meta_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_get_meta_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void add_user_signal(string signal, object arguments)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, signal);
            Helpers.WriteArray(Commands.CMD_DATA + 1036, arguments);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_add_user_signal__4__28__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_user_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_has_user_signal__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void remove_user_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_remove_user_signal__21__r0);
            Helpers.WaitForCompletion();
        }

        public long emit_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_emit_signal__21__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void call(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_call__21__r0);
            Helpers.WaitForCompletion();
        }

        public void call_deferred(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_call_deferred__21__r0);
            Helpers.WaitForCompletion();
        }

        public void set_deferred(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_set_deferred__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void callv(string method, object arg_array)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.WriteArray(Commands.CMD_DATA + 1036, arg_array);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_callv__21__28__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_method(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_has_method__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public long get_method_argument_count(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_get_method_argument_count__21__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool has_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_has_signal__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public object get_signal_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_get_signal_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_signal_connection_list(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_get_signal_connection_list__21__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_incoming_connections()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_get_incoming_connections__r28);
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
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_connect__21__25__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void disconnect(string signal, object callable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.WriteCallable(Commands.CMD_DATA + 1036, callable);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_disconnect__21__25__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_connected(string signal, object callable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.WriteCallable(Commands.CMD_DATA + 1036, callable);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_is_connected__21__25__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool has_connections(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_has_connections__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_block_signals(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_set_block_signals__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_blocking_signals()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_is_blocking_signals__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void notify_property_list_changed()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_notify_property_list_changed__r0);
            Helpers.WaitForCompletion();
        }

        public void set_message_translation(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_set_message_translation__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool can_translate_messages()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_can_translate_messages__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public string tr(string message, string context)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, message);
            Helpers.WriteStringName(Commands.CMD_DATA + 1036, context);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_tr__21__21__r4);
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
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_tr_n__21__21__2__21__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public string get_translation_domain()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_get_translation_domain__r21);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadStringName(Commands.CMD_DATA);
            return result;
        }

        public void set_translation_domain(string domain)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, domain);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_set_translation_domain__21__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_queued_for_deletion()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_is_queued_for_deletion__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void cancel_free()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_OpenXRAPIExtension_cancel_free__r0);
            Helpers.WaitForCompletion();
        }

    }
}
