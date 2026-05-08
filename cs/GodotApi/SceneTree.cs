using System;

namespace GodotWeb
{
    public class SceneTree : GodotObject
    {
        public SceneTree(ulong id) : base(id) { }

        public ulong get_root()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_SceneTree_get_root__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public bool has_group(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_SceneTree_has_group__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool is_accessibility_enabled()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_SceneTree_is_accessibility_enabled__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool is_accessibility_supported()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_SceneTree_is_accessibility_supported__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool is_auto_accept_quit()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_SceneTree_is_auto_accept_quit__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_auto_accept_quit(bool enabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_SceneTree_set_auto_accept_quit__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_quit_on_go_back()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_SceneTree_is_quit_on_go_back__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_quit_on_go_back(bool enabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_SceneTree_set_quit_on_go_back__1__r0);
            Helpers.WaitForCompletion();
        }

        public void set_debug_collisions_hint(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_SceneTree_set_debug_collisions_hint__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_debugging_collisions_hint()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_SceneTree_is_debugging_collisions_hint__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_debug_paths_hint(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_SceneTree_set_debug_paths_hint__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_debugging_paths_hint()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_SceneTree_is_debugging_paths_hint__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_debug_navigation_hint(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_SceneTree_set_debug_navigation_hint__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_debugging_navigation_hint()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_SceneTree_is_debugging_navigation_hint__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_edited_scene_root(ulong scene)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, scene);
            Helpers.SendCommand(Commands.CMD_SceneTree_set_edited_scene_root__24__r0);
            Helpers.WaitForCompletion();
        }

        public ulong get_edited_scene_root()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_SceneTree_get_edited_scene_root__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_pause(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_SceneTree_set_pause__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_paused()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_SceneTree_is_paused__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public ulong create_timer(double time_sec, bool process_always, bool process_in_physics, bool ignore_time_scale)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDouble(Commands.CMD_DATA + 8, time_sec);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, process_always ? 1 : 0);
            Helpers.WriteInt32(Commands.CMD_DATA + 20, process_in_physics ? 1 : 0);
            Helpers.WriteInt32(Commands.CMD_DATA + 24, ignore_time_scale ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_SceneTree_create_timer__3__1__1__1__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong create_tween()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_SceneTree_create_tween__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public object get_processed_tweens()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_SceneTree_get_processed_tweens__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public long get_node_count()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_SceneTree_get_node_count__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long get_frame()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_SceneTree_get_frame__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void quit(long exit_code)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, exit_code);
            Helpers.SendCommand(Commands.CMD_SceneTree_quit__2__r0);
            Helpers.WaitForCompletion();
        }

        public void set_physics_interpolation_enabled(bool enabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_SceneTree_set_physics_interpolation_enabled__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_physics_interpolation_enabled()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_SceneTree_is_physics_interpolation_enabled__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void queue_delete(ulong arg_obj)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, arg_obj);
            Helpers.SendCommand(Commands.CMD_SceneTree_queue_delete__24__r0);
            Helpers.WaitForCompletion();
        }

        public void call_group_flags(long flags, string group, string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, flags);
            Helpers.WriteStringName(Commands.CMD_DATA + 16, group);
            Helpers.WriteStringName(Commands.CMD_DATA + 1044, method);
            Helpers.SendCommand(Commands.CMD_SceneTree_call_group_flags__2__21__21__r0);
            Helpers.WaitForCompletion();
        }

        public void notify_group_flags(long call_flags, string group, long notification)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, call_flags);
            Helpers.WriteStringName(Commands.CMD_DATA + 16, group);
            Helpers.WriteInt64(Commands.CMD_DATA + 1044, notification);
            Helpers.SendCommand(Commands.CMD_SceneTree_notify_group_flags__2__21__2__r0);
            Helpers.WaitForCompletion();
        }

        public void set_group_flags(long call_flags, string group, string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, call_flags);
            Helpers.WriteStringName(Commands.CMD_DATA + 16, group);
            Helpers.WriteString(Commands.CMD_DATA + 1044, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 2072, value);
            Helpers.SendCommand(Commands.CMD_SceneTree_set_group_flags__2__21__4__0__r0);
            Helpers.WaitForCompletion();
        }

        public void call_group(string group, string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, group);
            Helpers.WriteStringName(Commands.CMD_DATA + 1036, method);
            Helpers.SendCommand(Commands.CMD_SceneTree_call_group__21__21__r0);
            Helpers.WaitForCompletion();
        }

        public void notify_group(string group, long notification)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, group);
            Helpers.WriteInt64(Commands.CMD_DATA + 1036, notification);
            Helpers.SendCommand(Commands.CMD_SceneTree_notify_group__21__2__r0);
            Helpers.WaitForCompletion();
        }

        public void set_group(string group, string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, group);
            Helpers.WriteString(Commands.CMD_DATA + 1036, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 2064, value);
            Helpers.SendCommand(Commands.CMD_SceneTree_set_group__21__4__0__r0);
            Helpers.WaitForCompletion();
        }

        public object get_nodes_in_group(string group)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, group);
            Helpers.SendCommand(Commands.CMD_SceneTree_get_nodes_in_group__21__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public ulong get_first_node_in_group(string group)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, group);
            Helpers.SendCommand(Commands.CMD_SceneTree_get_first_node_in_group__21__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public long get_node_count_in_group(string group)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, group);
            Helpers.SendCommand(Commands.CMD_SceneTree_get_node_count_in_group__21__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_current_scene(ulong child_node)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, child_node);
            Helpers.SendCommand(Commands.CMD_SceneTree_set_current_scene__24__r0);
            Helpers.WaitForCompletion();
        }

        public ulong get_current_scene()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_SceneTree_get_current_scene__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public long change_scene_to_file(string path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, path);
            Helpers.SendCommand(Commands.CMD_SceneTree_change_scene_to_file__4__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long change_scene_to_packed(ulong packed_scene)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, packed_scene);
            Helpers.SendCommand(Commands.CMD_SceneTree_change_scene_to_packed__24__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long change_scene_to_node(ulong node)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, node);
            Helpers.SendCommand(Commands.CMD_SceneTree_change_scene_to_node__24__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long reload_current_scene()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_SceneTree_reload_current_scene__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void unload_current_scene()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_SceneTree_unload_current_scene__r0);
            Helpers.WaitForCompletion();
        }

        public void set_multiplayer(ulong multiplayer, string root_path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, multiplayer);
            Helpers.WriteNodePath(Commands.CMD_DATA + 16, root_path);
            Helpers.SendCommand(Commands.CMD_SceneTree_set_multiplayer__24__22__r0);
            Helpers.WaitForCompletion();
        }

        public ulong get_multiplayer(string for_path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, for_path);
            Helpers.SendCommand(Commands.CMD_SceneTree_get_multiplayer__22__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_multiplayer_poll_enabled(bool enabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_SceneTree_set_multiplayer_poll_enabled__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_multiplayer_poll_enabled()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_SceneTree_is_multiplayer_poll_enabled__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _initialize()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_SceneTree__initialize__r0);
            Helpers.WaitForCompletion();
        }

        public bool _physics_process(double delta)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDouble(Commands.CMD_DATA + 8, delta);
            Helpers.SendCommand(Commands.CMD_SceneTree__physics_process__3__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool _process(double delta)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDouble(Commands.CMD_DATA + 8, delta);
            Helpers.SendCommand(Commands.CMD_SceneTree__process__3__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _finalize()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_SceneTree__finalize__r0);
            Helpers.WaitForCompletion();
        }

        public void free()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_SceneTree_free__r0);
            Helpers.WaitForCompletion();
        }

        public void _init()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_SceneTree__init__r0);
            Helpers.WaitForCompletion();
        }

        public string _to_string()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_SceneTree__to_string__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void _notification(long what)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, what);
            Helpers.SendCommand(Commands.CMD_SceneTree__notification__2__r0);
            Helpers.WaitForCompletion();
        }

        public bool _set(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_SceneTree__set__21__0__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _get(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_SceneTree__get__21__r0);
            Helpers.WaitForCompletion();
        }

        public object _get_property_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_SceneTree__get_property_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void _validate_property(object property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDictionary(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_SceneTree__validate_property__27__r0);
            Helpers.WaitForCompletion();
        }

        public bool _property_can_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_SceneTree__property_can_revert__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _property_get_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_SceneTree__property_get_revert__21__r0);
            Helpers.WaitForCompletion();
        }

        public bool _iter_init(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteArray(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_SceneTree__iter_init__28__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool _iter_next(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteArray(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_SceneTree__iter_next__28__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _iter_get(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVariant(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_SceneTree__iter_get__0__r0);
            Helpers.WaitForCompletion();
        }

        public string get_class()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_SceneTree_get_class__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public bool is_class(string class_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, class_);
            Helpers.SendCommand(Commands.CMD_SceneTree_is_class__4__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_SceneTree_set__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_SceneTree_get__21__r0);
            Helpers.WaitForCompletion();
        }

        public void set_indexed(string property_path, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, property_path);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_SceneTree_set_indexed__22__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get_indexed(string property_path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, property_path);
            Helpers.SendCommand(Commands.CMD_SceneTree_get_indexed__22__r0);
            Helpers.WaitForCompletion();
        }

        public object get_property_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_SceneTree_get_property_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_method_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_SceneTree_get_method_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public bool property_can_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_SceneTree_property_can_revert__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void property_get_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_SceneTree_property_get_revert__21__r0);
            Helpers.WaitForCompletion();
        }

        public void notification(long what, bool reversed)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, what);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, reversed ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_SceneTree_notification__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public string to_string()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_SceneTree_to_string__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public ulong get_instance_id()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_SceneTree_get_instance_id__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_script(object script)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVariant(Commands.CMD_DATA + 8, script);
            Helpers.SendCommand(Commands.CMD_SceneTree_set_script__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get_script()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_SceneTree_get_script__r0);
            Helpers.WaitForCompletion();
        }

        public void set_meta(string name, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_SceneTree_set_meta__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void remove_meta(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_SceneTree_remove_meta__21__r0);
            Helpers.WaitForCompletion();
        }

        public void get_meta(string name, object default_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, default_);
            Helpers.SendCommand(Commands.CMD_SceneTree_get_meta__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_meta(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_SceneTree_has_meta__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public object get_meta_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_SceneTree_get_meta_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void add_user_signal(string signal, object arguments)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, signal);
            Helpers.WriteArray(Commands.CMD_DATA + 1036, arguments);
            Helpers.SendCommand(Commands.CMD_SceneTree_add_user_signal__4__28__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_user_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_SceneTree_has_user_signal__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void remove_user_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_SceneTree_remove_user_signal__21__r0);
            Helpers.WaitForCompletion();
        }

        public long emit_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_SceneTree_emit_signal__21__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void call(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_SceneTree_call__21__r0);
            Helpers.WaitForCompletion();
        }

        public void call_deferred(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_SceneTree_call_deferred__21__r0);
            Helpers.WaitForCompletion();
        }

        public void set_deferred(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_SceneTree_set_deferred__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void callv(string method, object arg_array)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.WriteArray(Commands.CMD_DATA + 1036, arg_array);
            Helpers.SendCommand(Commands.CMD_SceneTree_callv__21__28__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_method(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_SceneTree_has_method__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public long get_method_argument_count(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_SceneTree_get_method_argument_count__21__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool has_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_SceneTree_has_signal__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public object get_signal_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_SceneTree_get_signal_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_signal_connection_list(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_SceneTree_get_signal_connection_list__21__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_incoming_connections()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_SceneTree_get_incoming_connections__r28);
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
            Helpers.SendCommand(Commands.CMD_SceneTree_connect__21__25__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void disconnect(string signal, object callable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.WriteCallable(Commands.CMD_DATA + 1036, callable);
            Helpers.SendCommand(Commands.CMD_SceneTree_disconnect__21__25__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_connected(string signal, object callable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.WriteCallable(Commands.CMD_DATA + 1036, callable);
            Helpers.SendCommand(Commands.CMD_SceneTree_is_connected__21__25__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool has_connections(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_SceneTree_has_connections__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_block_signals(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_SceneTree_set_block_signals__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_blocking_signals()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_SceneTree_is_blocking_signals__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void notify_property_list_changed()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_SceneTree_notify_property_list_changed__r0);
            Helpers.WaitForCompletion();
        }

        public void set_message_translation(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_SceneTree_set_message_translation__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool can_translate_messages()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_SceneTree_can_translate_messages__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public string tr(string message, string context)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, message);
            Helpers.WriteStringName(Commands.CMD_DATA + 1036, context);
            Helpers.SendCommand(Commands.CMD_SceneTree_tr__21__21__r4);
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
            Helpers.SendCommand(Commands.CMD_SceneTree_tr_n__21__21__2__21__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public string get_translation_domain()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_SceneTree_get_translation_domain__r21);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadStringName(Commands.CMD_DATA);
            return result;
        }

        public void set_translation_domain(string domain)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, domain);
            Helpers.SendCommand(Commands.CMD_SceneTree_set_translation_domain__21__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_queued_for_deletion()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_SceneTree_is_queued_for_deletion__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void cancel_free()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_SceneTree_cancel_free__r0);
            Helpers.WaitForCompletion();
        }

    }
}
