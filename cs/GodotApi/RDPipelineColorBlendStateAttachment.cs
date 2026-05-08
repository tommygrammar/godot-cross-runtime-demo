using System;

namespace GodotWeb
{
    public class RDPipelineColorBlendStateAttachment : GodotObject
    {
        public RDPipelineColorBlendStateAttachment(ulong id) : base(id) { }

        public void set_as_mix()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_set_as_mix__r0);
            Helpers.WaitForCompletion();
        }

        public void set_enable_blend(bool p_member)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, p_member ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_set_enable_blend__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool get_enable_blend()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_get_enable_blend__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_src_color_blend_factor(long p_member)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, p_member);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_set_src_color_blend_factor__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_src_color_blend_factor()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_get_src_color_blend_factor__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_dst_color_blend_factor(long p_member)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, p_member);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_set_dst_color_blend_factor__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_dst_color_blend_factor()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_get_dst_color_blend_factor__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_color_blend_op(long p_member)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, p_member);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_set_color_blend_op__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_color_blend_op()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_get_color_blend_op__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_src_alpha_blend_factor(long p_member)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, p_member);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_set_src_alpha_blend_factor__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_src_alpha_blend_factor()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_get_src_alpha_blend_factor__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_dst_alpha_blend_factor(long p_member)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, p_member);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_set_dst_alpha_blend_factor__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_dst_alpha_blend_factor()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_get_dst_alpha_blend_factor__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_alpha_blend_op(long p_member)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, p_member);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_set_alpha_blend_op__2__r0);
            Helpers.WaitForCompletion();
        }

        public long get_alpha_blend_op()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_get_alpha_blend_op__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_write_r(bool p_member)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, p_member ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_set_write_r__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool get_write_r()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_get_write_r__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_write_g(bool p_member)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, p_member ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_set_write_g__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool get_write_g()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_get_write_g__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_write_b(bool p_member)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, p_member ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_set_write_b__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool get_write_b()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_get_write_b__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_write_a(bool p_member)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, p_member ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_set_write_a__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool get_write_a()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_get_write_a__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool init_ref()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_init_ref__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool reference()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_reference__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool unreference()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_unreference__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public long get_reference_count()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_get_reference_count__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void free()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_free__r0);
            Helpers.WaitForCompletion();
        }

        public void _init()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment__init__r0);
            Helpers.WaitForCompletion();
        }

        public string _to_string()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment__to_string__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void _notification(long what)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, what);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment__notification__2__r0);
            Helpers.WaitForCompletion();
        }

        public bool _set(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment__set__21__0__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _get(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment__get__21__r0);
            Helpers.WaitForCompletion();
        }

        public object _get_property_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment__get_property_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void _validate_property(object property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDictionary(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment__validate_property__27__r0);
            Helpers.WaitForCompletion();
        }

        public bool _property_can_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment__property_can_revert__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _property_get_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment__property_get_revert__21__r0);
            Helpers.WaitForCompletion();
        }

        public bool _iter_init(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteArray(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment__iter_init__28__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool _iter_next(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteArray(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment__iter_next__28__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _iter_get(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVariant(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment__iter_get__0__r0);
            Helpers.WaitForCompletion();
        }

        public string get_class()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_get_class__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public bool is_class(string class_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, class_);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_is_class__4__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_set__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_get__21__r0);
            Helpers.WaitForCompletion();
        }

        public void set_indexed(string property_path, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, property_path);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_set_indexed__22__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get_indexed(string property_path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, property_path);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_get_indexed__22__r0);
            Helpers.WaitForCompletion();
        }

        public object get_property_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_get_property_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_method_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_get_method_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public bool property_can_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_property_can_revert__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void property_get_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_property_get_revert__21__r0);
            Helpers.WaitForCompletion();
        }

        public void notification(long what, bool reversed)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, what);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, reversed ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_notification__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public string to_string()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_to_string__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public ulong get_instance_id()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_get_instance_id__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_script(object script)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVariant(Commands.CMD_DATA + 8, script);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_set_script__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get_script()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_get_script__r0);
            Helpers.WaitForCompletion();
        }

        public void set_meta(string name, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_set_meta__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void remove_meta(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_remove_meta__21__r0);
            Helpers.WaitForCompletion();
        }

        public void get_meta(string name, object default_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, default_);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_get_meta__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_meta(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_has_meta__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public object get_meta_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_get_meta_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void add_user_signal(string signal, object arguments)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, signal);
            Helpers.WriteArray(Commands.CMD_DATA + 1036, arguments);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_add_user_signal__4__28__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_user_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_has_user_signal__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void remove_user_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_remove_user_signal__21__r0);
            Helpers.WaitForCompletion();
        }

        public long emit_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_emit_signal__21__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void call(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_call__21__r0);
            Helpers.WaitForCompletion();
        }

        public void call_deferred(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_call_deferred__21__r0);
            Helpers.WaitForCompletion();
        }

        public void set_deferred(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_set_deferred__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void callv(string method, object arg_array)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.WriteArray(Commands.CMD_DATA + 1036, arg_array);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_callv__21__28__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_method(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_has_method__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public long get_method_argument_count(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_get_method_argument_count__21__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool has_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_has_signal__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public object get_signal_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_get_signal_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_signal_connection_list(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_get_signal_connection_list__21__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_incoming_connections()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_get_incoming_connections__r28);
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
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_connect__21__25__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void disconnect(string signal, object callable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.WriteCallable(Commands.CMD_DATA + 1036, callable);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_disconnect__21__25__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_connected(string signal, object callable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.WriteCallable(Commands.CMD_DATA + 1036, callable);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_is_connected__21__25__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool has_connections(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_has_connections__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_block_signals(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_set_block_signals__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_blocking_signals()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_is_blocking_signals__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void notify_property_list_changed()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_notify_property_list_changed__r0);
            Helpers.WaitForCompletion();
        }

        public void set_message_translation(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_set_message_translation__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool can_translate_messages()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_can_translate_messages__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public string tr(string message, string context)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, message);
            Helpers.WriteStringName(Commands.CMD_DATA + 1036, context);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_tr__21__21__r4);
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
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_tr_n__21__21__2__21__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public string get_translation_domain()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_get_translation_domain__r21);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadStringName(Commands.CMD_DATA);
            return result;
        }

        public void set_translation_domain(string domain)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, domain);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_set_translation_domain__21__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_queued_for_deletion()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_is_queued_for_deletion__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void cancel_free()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_RDPipelineColorBlendStateAttachment_cancel_free__r0);
            Helpers.WaitForCompletion();
        }

    }
}
