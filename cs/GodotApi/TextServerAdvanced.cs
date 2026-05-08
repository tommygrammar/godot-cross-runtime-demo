using System;

namespace GodotWeb
{
    public class TextServerAdvanced : GodotObject
    {
        public TextServerAdvanced(ulong id) : base(id) { }

        public bool _has_feature(long feature)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, feature);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__has_feature__2__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public string _get_name()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__get_name__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public long _get_features()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__get_features__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void _free_rid(ulong rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__free_rid__23__r0);
            Helpers.WaitForCompletion();
        }

        public bool _has(ulong rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__has__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool _load_support_data(string filename)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, filename);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__load_support_data__4__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public string _get_support_data_filename()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__get_support_data_filename__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public string _get_support_data_info()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__get_support_data_info__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public bool _save_support_data(string filename)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, filename);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__save_support_data__4__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public byte[] _get_support_data()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__get_support_data__r29);
            Helpers.WaitForCompletion();
            byte[] result = Helpers.ReadPackedByteArray(Commands.CMD_DATA);
            return result;
        }

        public bool _is_locale_using_support_data(string locale)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, locale);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__is_locale_using_support_data__4__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool _is_locale_right_to_left(string locale)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, locale);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__is_locale_right_to_left__4__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public long _name_to_tag(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__name_to_tag__4__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public string _tag_to_name(long tag)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, tag);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__tag_to_name__2__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public ulong _create_font()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__create_font__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public ulong _create_font_linked_variation(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__create_font_linked_variation__23__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void _font_set_data(ulong font_rid, byte[] arg_data)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WritePackedByteArray(Commands.CMD_DATA + 16, arg_data);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_set_data__23__29__r0);
            Helpers.WaitForCompletion();
        }

        public void _font_set_data_ptr(ulong font_rid, long data_ptr, long data_size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, data_ptr);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, data_size);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_set_data_ptr__23__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public void _font_set_face_index(ulong font_rid, long face_index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, face_index);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_set_face_index__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long _font_get_face_index(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_get_face_index__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long _font_get_face_count(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_get_face_count__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void _font_set_style(ulong font_rid, long style)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, style);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_set_style__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long _font_get_style(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_get_style__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void _font_set_name(ulong font_rid, string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteString(Commands.CMD_DATA + 16, name);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_set_name__23__4__r0);
            Helpers.WaitForCompletion();
        }

        public string _font_get_name(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_get_name__23__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public object _font_get_ot_name_strings(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_get_ot_name_strings__23__r27);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadDictionary(Commands.CMD_DATA);
            return result;
        }

        public void _font_set_style_name(ulong font_rid, string name_style)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteString(Commands.CMD_DATA + 16, name_style);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_set_style_name__23__4__r0);
            Helpers.WaitForCompletion();
        }

        public string _font_get_style_name(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_get_style_name__23__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void _font_set_weight(ulong font_rid, long weight)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, weight);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_set_weight__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long _font_get_weight(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_get_weight__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void _font_set_stretch(ulong font_rid, long stretch)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, stretch);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_set_stretch__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long _font_get_stretch(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_get_stretch__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void _font_set_antialiasing(ulong font_rid, long antialiasing)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, antialiasing);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_set_antialiasing__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long _font_get_antialiasing(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_get_antialiasing__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void _font_set_disable_embedded_bitmaps(ulong font_rid, bool disable_embedded_bitmaps)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, disable_embedded_bitmaps ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_set_disable_embedded_bitmaps__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool _font_get_disable_embedded_bitmaps(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_get_disable_embedded_bitmaps__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _font_set_generate_mipmaps(ulong font_rid, bool generate_mipmaps)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, generate_mipmaps ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_set_generate_mipmaps__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool _font_get_generate_mipmaps(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_get_generate_mipmaps__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _font_set_multichannel_signed_distance_field(ulong font_rid, bool msdf)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, msdf ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_set_multichannel_signed_distance_field__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool _font_is_multichannel_signed_distance_field(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_is_multichannel_signed_distance_field__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _font_set_msdf_pixel_range(ulong font_rid, long msdf_pixel_range)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, msdf_pixel_range);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_set_msdf_pixel_range__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long _font_get_msdf_pixel_range(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_get_msdf_pixel_range__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void _font_set_msdf_size(ulong font_rid, long msdf_size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, msdf_size);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_set_msdf_size__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long _font_get_msdf_size(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_get_msdf_size__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void _font_set_fixed_size(ulong font_rid, long fixed_size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, fixed_size);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_set_fixed_size__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long _font_get_fixed_size(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_get_fixed_size__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void _font_set_fixed_size_scale_mode(ulong font_rid, long fixed_size_scale_mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, fixed_size_scale_mode);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_set_fixed_size_scale_mode__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long _font_get_fixed_size_scale_mode(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_get_fixed_size_scale_mode__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void _font_set_allow_system_fallback(ulong font_rid, bool allow_system_fallback)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, allow_system_fallback ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_set_allow_system_fallback__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool _font_is_allow_system_fallback(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_is_allow_system_fallback__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _font_clear_system_fallback_cache()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_clear_system_fallback_cache__r0);
            Helpers.WaitForCompletion();
        }

        public void _font_set_force_autohinter(ulong font_rid, bool force_autohinter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, force_autohinter ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_set_force_autohinter__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool _font_is_force_autohinter(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_is_force_autohinter__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _font_set_modulate_color_glyphs(ulong font_rid, bool modulate)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, modulate ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_set_modulate_color_glyphs__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool _font_is_modulate_color_glyphs(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_is_modulate_color_glyphs__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _font_set_hinting(ulong font_rid, long hinting)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, hinting);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_set_hinting__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long _font_get_hinting(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_get_hinting__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void _font_set_subpixel_positioning(ulong font_rid, long subpixel_positioning)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, subpixel_positioning);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_set_subpixel_positioning__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long _font_get_subpixel_positioning(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_get_subpixel_positioning__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void _font_set_keep_rounding_remainders(ulong font_rid, bool keep_rounding_remainders)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, keep_rounding_remainders ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_set_keep_rounding_remainders__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool _font_get_keep_rounding_remainders(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_get_keep_rounding_remainders__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _font_set_embolden(ulong font_rid, double strength)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, strength);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_set_embolden__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public double _font_get_embolden(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_get_embolden__23__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void _font_set_spacing(ulong font_rid, long spacing, long value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, spacing);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, value);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_set_spacing__23__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public long _font_get_spacing(ulong font_rid, long spacing)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, spacing);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_get_spacing__23__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void _font_set_baseline_offset(ulong font_rid, double baseline_offset)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, baseline_offset);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_set_baseline_offset__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public double _font_get_baseline_offset(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_get_baseline_offset__23__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void _font_set_transform(ulong font_rid, Transform2D transform)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteTransform2D(Commands.CMD_DATA + 16, transform);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_set_transform__23__11__r0);
            Helpers.WaitForCompletion();
        }

        public Transform2D _font_get_transform(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_get_transform__23__r11);
            Helpers.WaitForCompletion();
            Transform2D result = Helpers.ReadTransform2D(Commands.CMD_DATA);
            return result;
        }

        public void _font_set_variation_coordinates(ulong font_rid, object variation_coordinates)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteDictionary(Commands.CMD_DATA + 16, variation_coordinates);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_set_variation_coordinates__23__27__r0);
            Helpers.WaitForCompletion();
        }

        public object _font_get_variation_coordinates(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_get_variation_coordinates__23__r27);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadDictionary(Commands.CMD_DATA);
            return result;
        }

        public void _font_set_oversampling(ulong font_rid, double oversampling)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, oversampling);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_set_oversampling__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public double _font_get_oversampling(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_get_oversampling__23__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public object _font_get_size_cache_list(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_get_size_cache_list__23__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void _font_clear_size_cache(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_clear_size_cache__23__r0);
            Helpers.WaitForCompletion();
        }

        public void _font_remove_size_cache(ulong font_rid, Vector2i size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteVector2i(Commands.CMD_DATA + 16, size);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_remove_size_cache__23__6__r0);
            Helpers.WaitForCompletion();
        }

        public object _font_get_size_cache_info(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_get_size_cache_info__23__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void _font_set_ascent(ulong font_rid, long size, double ascent)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, size);
            Helpers.WriteDouble(Commands.CMD_DATA + 24, ascent);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_set_ascent__23__2__3__r0);
            Helpers.WaitForCompletion();
        }

        public double _font_get_ascent(ulong font_rid, long size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, size);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_get_ascent__23__2__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void _font_set_descent(ulong font_rid, long size, double descent)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, size);
            Helpers.WriteDouble(Commands.CMD_DATA + 24, descent);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_set_descent__23__2__3__r0);
            Helpers.WaitForCompletion();
        }

        public double _font_get_descent(ulong font_rid, long size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, size);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_get_descent__23__2__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void _font_set_underline_position(ulong font_rid, long size, double underline_position)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, size);
            Helpers.WriteDouble(Commands.CMD_DATA + 24, underline_position);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_set_underline_position__23__2__3__r0);
            Helpers.WaitForCompletion();
        }

        public double _font_get_underline_position(ulong font_rid, long size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, size);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_get_underline_position__23__2__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void _font_set_underline_thickness(ulong font_rid, long size, double underline_thickness)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, size);
            Helpers.WriteDouble(Commands.CMD_DATA + 24, underline_thickness);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_set_underline_thickness__23__2__3__r0);
            Helpers.WaitForCompletion();
        }

        public double _font_get_underline_thickness(ulong font_rid, long size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, size);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_get_underline_thickness__23__2__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void _font_set_scale(ulong font_rid, long size, double scale)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, size);
            Helpers.WriteDouble(Commands.CMD_DATA + 24, scale);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_set_scale__23__2__3__r0);
            Helpers.WaitForCompletion();
        }

        public double _font_get_scale(ulong font_rid, long size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, size);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_get_scale__23__2__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public long _font_get_texture_count(ulong font_rid, Vector2i size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteVector2i(Commands.CMD_DATA + 16, size);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_get_texture_count__23__6__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void _font_clear_textures(ulong font_rid, Vector2i size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteVector2i(Commands.CMD_DATA + 16, size);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_clear_textures__23__6__r0);
            Helpers.WaitForCompletion();
        }

        public void _font_remove_texture(ulong font_rid, Vector2i size, long texture_index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteVector2i(Commands.CMD_DATA + 16, size);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, texture_index);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_remove_texture__23__6__2__r0);
            Helpers.WaitForCompletion();
        }

        public void _font_set_texture_image(ulong font_rid, Vector2i size, long texture_index, ulong image)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteVector2i(Commands.CMD_DATA + 16, size);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, texture_index);
            Helpers.WriteUInt64(Commands.CMD_DATA + 32, image);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_set_texture_image__23__6__2__24__r0);
            Helpers.WaitForCompletion();
        }

        public ulong _font_get_texture_image(ulong font_rid, Vector2i size, long texture_index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteVector2i(Commands.CMD_DATA + 16, size);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, texture_index);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_get_texture_image__23__6__2__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void _font_set_texture_offsets(ulong font_rid, Vector2i size, long texture_index, int[] offset)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteVector2i(Commands.CMD_DATA + 16, size);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, texture_index);
            Helpers.WritePackedInt32Array(Commands.CMD_DATA + 32, offset);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_set_texture_offsets__23__6__2__30__r0);
            Helpers.WaitForCompletion();
        }

        public int[] _font_get_texture_offsets(ulong font_rid, Vector2i size, long texture_index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteVector2i(Commands.CMD_DATA + 16, size);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, texture_index);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_get_texture_offsets__23__6__2__r30);
            Helpers.WaitForCompletion();
            int[] result = Helpers.ReadPackedInt32Array(Commands.CMD_DATA);
            return result;
        }

        public int[] _font_get_glyph_list(ulong font_rid, Vector2i size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteVector2i(Commands.CMD_DATA + 16, size);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_get_glyph_list__23__6__r30);
            Helpers.WaitForCompletion();
            int[] result = Helpers.ReadPackedInt32Array(Commands.CMD_DATA);
            return result;
        }

        public void _font_clear_glyphs(ulong font_rid, Vector2i size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteVector2i(Commands.CMD_DATA + 16, size);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_clear_glyphs__23__6__r0);
            Helpers.WaitForCompletion();
        }

        public void _font_remove_glyph(ulong font_rid, Vector2i size, long glyph)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteVector2i(Commands.CMD_DATA + 16, size);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, glyph);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_remove_glyph__23__6__2__r0);
            Helpers.WaitForCompletion();
        }

        public Vector2 _font_get_glyph_advance(ulong font_rid, long size, long glyph)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, size);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, glyph);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_get_glyph_advance__23__2__2__r5);
            Helpers.WaitForCompletion();
            Vector2 result = Helpers.ReadVector2(Commands.CMD_DATA);
            return result;
        }

        public void _font_set_glyph_advance(ulong font_rid, long size, long glyph, Vector2 advance)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, size);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, glyph);
            Helpers.WriteVector2(Commands.CMD_DATA + 32, advance);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_set_glyph_advance__23__2__2__5__r0);
            Helpers.WaitForCompletion();
        }

        public Vector2 _font_get_glyph_offset(ulong font_rid, Vector2i size, long glyph)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteVector2i(Commands.CMD_DATA + 16, size);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, glyph);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_get_glyph_offset__23__6__2__r5);
            Helpers.WaitForCompletion();
            Vector2 result = Helpers.ReadVector2(Commands.CMD_DATA);
            return result;
        }

        public void _font_set_glyph_offset(ulong font_rid, Vector2i size, long glyph, Vector2 offset)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteVector2i(Commands.CMD_DATA + 16, size);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, glyph);
            Helpers.WriteVector2(Commands.CMD_DATA + 32, offset);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_set_glyph_offset__23__6__2__5__r0);
            Helpers.WaitForCompletion();
        }

        public Vector2 _font_get_glyph_size(ulong font_rid, Vector2i size, long glyph)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteVector2i(Commands.CMD_DATA + 16, size);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, glyph);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_get_glyph_size__23__6__2__r5);
            Helpers.WaitForCompletion();
            Vector2 result = Helpers.ReadVector2(Commands.CMD_DATA);
            return result;
        }

        public void _font_set_glyph_size(ulong font_rid, Vector2i size, long glyph, Vector2 gl_size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteVector2i(Commands.CMD_DATA + 16, size);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, glyph);
            Helpers.WriteVector2(Commands.CMD_DATA + 32, gl_size);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_set_glyph_size__23__6__2__5__r0);
            Helpers.WaitForCompletion();
        }

        public Rect2 _font_get_glyph_uv_rect(ulong font_rid, Vector2i size, long glyph)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteVector2i(Commands.CMD_DATA + 16, size);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, glyph);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_get_glyph_uv_rect__23__6__2__r7);
            Helpers.WaitForCompletion();
            Rect2 result = Helpers.ReadRect2(Commands.CMD_DATA);
            return result;
        }

        public void _font_set_glyph_uv_rect(ulong font_rid, Vector2i size, long glyph, Rect2 uv_rect)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteVector2i(Commands.CMD_DATA + 16, size);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, glyph);
            Helpers.WriteRect2(Commands.CMD_DATA + 32, uv_rect);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_set_glyph_uv_rect__23__6__2__7__r0);
            Helpers.WaitForCompletion();
        }

        public long _font_get_glyph_texture_idx(ulong font_rid, Vector2i size, long glyph)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteVector2i(Commands.CMD_DATA + 16, size);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, glyph);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_get_glyph_texture_idx__23__6__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void _font_set_glyph_texture_idx(ulong font_rid, Vector2i size, long glyph, long texture_idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteVector2i(Commands.CMD_DATA + 16, size);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, glyph);
            Helpers.WriteInt64(Commands.CMD_DATA + 32, texture_idx);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_set_glyph_texture_idx__23__6__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public ulong _font_get_glyph_texture_rid(ulong font_rid, Vector2i size, long glyph)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteVector2i(Commands.CMD_DATA + 16, size);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, glyph);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_get_glyph_texture_rid__23__6__2__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public Vector2 _font_get_glyph_texture_size(ulong font_rid, Vector2i size, long glyph)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteVector2i(Commands.CMD_DATA + 16, size);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, glyph);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_get_glyph_texture_size__23__6__2__r5);
            Helpers.WaitForCompletion();
            Vector2 result = Helpers.ReadVector2(Commands.CMD_DATA);
            return result;
        }

        public object _font_get_glyph_contours(ulong font_rid, long size, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, size);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, index);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_get_glyph_contours__23__2__2__r27);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadDictionary(Commands.CMD_DATA);
            return result;
        }

        public object _font_get_kerning_list(ulong font_rid, long size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, size);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_get_kerning_list__23__2__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void _font_clear_kerning_map(ulong font_rid, long size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, size);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_clear_kerning_map__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void _font_remove_kerning(ulong font_rid, long size, Vector2i glyph_pair)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, size);
            Helpers.WriteVector2i(Commands.CMD_DATA + 24, glyph_pair);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_remove_kerning__23__2__6__r0);
            Helpers.WaitForCompletion();
        }

        public void _font_set_kerning(ulong font_rid, long size, Vector2i glyph_pair, Vector2 kerning)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, size);
            Helpers.WriteVector2i(Commands.CMD_DATA + 24, glyph_pair);
            Helpers.WriteVector2(Commands.CMD_DATA + 32, kerning);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_set_kerning__23__2__6__5__r0);
            Helpers.WaitForCompletion();
        }

        public Vector2 _font_get_kerning(ulong font_rid, long size, Vector2i glyph_pair)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, size);
            Helpers.WriteVector2i(Commands.CMD_DATA + 24, glyph_pair);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_get_kerning__23__2__6__r5);
            Helpers.WaitForCompletion();
            Vector2 result = Helpers.ReadVector2(Commands.CMD_DATA);
            return result;
        }

        public long _font_get_glyph_index(ulong font_rid, long size, long char_, long variation_selector)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, size);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, char_);
            Helpers.WriteInt64(Commands.CMD_DATA + 32, variation_selector);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_get_glyph_index__23__2__2__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long _font_get_char_from_glyph_index(ulong font_rid, long size, long glyph_index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, size);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, glyph_index);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_get_char_from_glyph_index__23__2__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool _font_has_char(ulong font_rid, long char_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, char_);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_has_char__23__2__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public string _font_get_supported_chars(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_get_supported_chars__23__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public int[] _font_get_supported_glyphs(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_get_supported_glyphs__23__r30);
            Helpers.WaitForCompletion();
            int[] result = Helpers.ReadPackedInt32Array(Commands.CMD_DATA);
            return result;
        }

        public void _font_render_range(ulong font_rid, Vector2i size, long start, long end)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteVector2i(Commands.CMD_DATA + 16, size);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, start);
            Helpers.WriteInt64(Commands.CMD_DATA + 32, end);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_render_range__23__6__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public void _font_render_glyph(ulong font_rid, Vector2i size, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteVector2i(Commands.CMD_DATA + 16, size);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, index);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_render_glyph__23__6__2__r0);
            Helpers.WaitForCompletion();
        }

        public void _font_draw_glyph(ulong font_rid, ulong canvas, long size, Vector2 pos, long index, Color color, double oversampling)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteRID(Commands.CMD_DATA + 16, canvas);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, size);
            Helpers.WriteVector2(Commands.CMD_DATA + 32, pos);
            Helpers.WriteInt64(Commands.CMD_DATA + 40, index);
            Helpers.WriteColor(Commands.CMD_DATA + 48, color);
            Helpers.WriteDouble(Commands.CMD_DATA + 64, oversampling);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_draw_glyph__23__23__2__5__2__20__3__r0);
            Helpers.WaitForCompletion();
        }

        public void _font_draw_glyph_outline(ulong font_rid, ulong canvas, long size, long outline_size, Vector2 pos, long index, Color color, double oversampling)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteRID(Commands.CMD_DATA + 16, canvas);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, size);
            Helpers.WriteInt64(Commands.CMD_DATA + 32, outline_size);
            Helpers.WriteVector2(Commands.CMD_DATA + 40, pos);
            Helpers.WriteInt64(Commands.CMD_DATA + 48, index);
            Helpers.WriteColor(Commands.CMD_DATA + 56, color);
            Helpers.WriteDouble(Commands.CMD_DATA + 72, oversampling);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_draw_glyph_outline__23__23__2__2__5__2__20__3__r0);
            Helpers.WaitForCompletion();
        }

        public bool _font_is_language_supported(ulong font_rid, string language)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteString(Commands.CMD_DATA + 16, language);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_is_language_supported__23__4__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _font_set_language_support_override(ulong font_rid, string language, bool supported)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteString(Commands.CMD_DATA + 16, language);
            Helpers.WriteInt32(Commands.CMD_DATA + 1044, supported ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_set_language_support_override__23__4__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool _font_get_language_support_override(ulong font_rid, string language)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteString(Commands.CMD_DATA + 16, language);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_get_language_support_override__23__4__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _font_remove_language_support_override(ulong font_rid, string language)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteString(Commands.CMD_DATA + 16, language);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_remove_language_support_override__23__4__r0);
            Helpers.WaitForCompletion();
        }

        public string[] _font_get_language_support_overrides(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_get_language_support_overrides__23__r34);
            Helpers.WaitForCompletion();
            string[] result = Helpers.ReadPackedStringArray(Commands.CMD_DATA);
            return result;
        }

        public bool _font_is_script_supported(ulong font_rid, string script)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteString(Commands.CMD_DATA + 16, script);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_is_script_supported__23__4__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _font_set_script_support_override(ulong font_rid, string script, bool supported)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteString(Commands.CMD_DATA + 16, script);
            Helpers.WriteInt32(Commands.CMD_DATA + 1044, supported ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_set_script_support_override__23__4__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool _font_get_script_support_override(ulong font_rid, string script)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteString(Commands.CMD_DATA + 16, script);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_get_script_support_override__23__4__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _font_remove_script_support_override(ulong font_rid, string script)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteString(Commands.CMD_DATA + 16, script);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_remove_script_support_override__23__4__r0);
            Helpers.WaitForCompletion();
        }

        public string[] _font_get_script_support_overrides(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_get_script_support_overrides__23__r34);
            Helpers.WaitForCompletion();
            string[] result = Helpers.ReadPackedStringArray(Commands.CMD_DATA);
            return result;
        }

        public void _font_set_opentype_feature_overrides(ulong font_rid, object overrides)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteDictionary(Commands.CMD_DATA + 16, overrides);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_set_opentype_feature_overrides__23__27__r0);
            Helpers.WaitForCompletion();
        }

        public object _font_get_opentype_feature_overrides(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_get_opentype_feature_overrides__23__r27);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadDictionary(Commands.CMD_DATA);
            return result;
        }

        public object _font_supported_feature_list(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_supported_feature_list__23__r27);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadDictionary(Commands.CMD_DATA);
            return result;
        }

        public object _font_supported_variation_list(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_supported_variation_list__23__r27);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadDictionary(Commands.CMD_DATA);
            return result;
        }

        public double _font_get_global_oversampling()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_get_global_oversampling__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void _font_set_global_oversampling(double oversampling)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDouble(Commands.CMD_DATA + 8, oversampling);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__font_set_global_oversampling__3__r0);
            Helpers.WaitForCompletion();
        }

        public void _reference_oversampling_level(double oversampling)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDouble(Commands.CMD_DATA + 8, oversampling);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__reference_oversampling_level__3__r0);
            Helpers.WaitForCompletion();
        }

        public void _unreference_oversampling_level(double oversampling)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDouble(Commands.CMD_DATA + 8, oversampling);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__unreference_oversampling_level__3__r0);
            Helpers.WaitForCompletion();
        }

        public Vector2 _get_hex_code_box_size(long size, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, size);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, index);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__get_hex_code_box_size__2__2__r5);
            Helpers.WaitForCompletion();
            Vector2 result = Helpers.ReadVector2(Commands.CMD_DATA);
            return result;
        }

        public void _draw_hex_code_box(ulong canvas, long size, Vector2 pos, long index, Color color)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, canvas);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, size);
            Helpers.WriteVector2(Commands.CMD_DATA + 24, pos);
            Helpers.WriteInt64(Commands.CMD_DATA + 32, index);
            Helpers.WriteColor(Commands.CMD_DATA + 40, color);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__draw_hex_code_box__23__2__5__2__20__r0);
            Helpers.WaitForCompletion();
        }

        public ulong _create_shaped_text(long direction, long orientation)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, direction);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, orientation);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__create_shaped_text__2__2__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void _shaped_text_clear(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_clear__23__r0);
            Helpers.WaitForCompletion();
        }

        public ulong _shaped_text_duplicate(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_duplicate__23__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void _shaped_text_set_direction(ulong shaped, long direction)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, direction);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_set_direction__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long _shaped_text_get_direction(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_get_direction__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long _shaped_text_get_inferred_direction(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_get_inferred_direction__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void _shaped_text_set_bidi_override(ulong shaped, object override_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteArray(Commands.CMD_DATA + 16, override_);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_set_bidi_override__23__28__r0);
            Helpers.WaitForCompletion();
        }

        public void _shaped_text_set_custom_punctuation(ulong shaped, string punct)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteString(Commands.CMD_DATA + 16, punct);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_set_custom_punctuation__23__4__r0);
            Helpers.WaitForCompletion();
        }

        public string _shaped_text_get_custom_punctuation(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_get_custom_punctuation__23__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void _shaped_text_set_custom_ellipsis(ulong shaped, long char_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, char_);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_set_custom_ellipsis__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long _shaped_text_get_custom_ellipsis(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_get_custom_ellipsis__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void _shaped_text_set_orientation(ulong shaped, long orientation)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, orientation);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_set_orientation__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long _shaped_text_get_orientation(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_get_orientation__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void _shaped_text_set_preserve_invalid(ulong shaped, bool enabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_set_preserve_invalid__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool _shaped_text_get_preserve_invalid(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_get_preserve_invalid__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _shaped_text_set_preserve_control(ulong shaped, bool enabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_set_preserve_control__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool _shaped_text_get_preserve_control(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_get_preserve_control__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _shaped_text_set_spacing(ulong shaped, long spacing, long value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, spacing);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, value);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_set_spacing__23__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public long _shaped_text_get_spacing(ulong shaped, long spacing)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, spacing);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_get_spacing__23__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool _shaped_text_add_string(ulong shaped, string text, object fonts, long size, object opentype_features, string language, object meta)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteString(Commands.CMD_DATA + 16, text);
            Helpers.WriteArray(Commands.CMD_DATA + 1044, fonts);
            Helpers.WriteInt64(Commands.CMD_DATA + 1044, size);
            Helpers.WriteDictionary(Commands.CMD_DATA + 1052, opentype_features);
            Helpers.WriteString(Commands.CMD_DATA + 1052, language);
            Helpers.WriteVariant(Commands.CMD_DATA + 2080, meta);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_add_string__23__4__28__2__27__4__0__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool _shaped_text_add_object(ulong shaped, object key, Vector2 size, long inline_align, long length, double baseline)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteVariant(Commands.CMD_DATA + 16, key);
            Helpers.WriteVector2(Commands.CMD_DATA + 16, size);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, inline_align);
            Helpers.WriteInt64(Commands.CMD_DATA + 32, length);
            Helpers.WriteDouble(Commands.CMD_DATA + 40, baseline);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_add_object__23__0__5__2__2__3__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool _shaped_text_resize_object(ulong shaped, object key, Vector2 size, long inline_align, double baseline)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteVariant(Commands.CMD_DATA + 16, key);
            Helpers.WriteVector2(Commands.CMD_DATA + 16, size);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, inline_align);
            Helpers.WriteDouble(Commands.CMD_DATA + 32, baseline);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_resize_object__23__0__5__2__3__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool _shaped_text_has_object(ulong shaped, object key)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteVariant(Commands.CMD_DATA + 16, key);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_has_object__23__0__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public string _shaped_get_text(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_get_text__23__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public long _shaped_get_span_count(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_get_span_count__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void _shaped_get_span_meta(ulong shaped, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, index);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_get_span_meta__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void _shaped_get_span_embedded_object(ulong shaped, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, index);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_get_span_embedded_object__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public string _shaped_get_span_text(ulong shaped, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, index);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_get_span_text__23__2__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void _shaped_get_span_object(ulong shaped, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, index);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_get_span_object__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void _shaped_set_span_update_font(ulong shaped, long index, object fonts, long size, object opentype_features)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, index);
            Helpers.WriteArray(Commands.CMD_DATA + 24, fonts);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, size);
            Helpers.WriteDictionary(Commands.CMD_DATA + 32, opentype_features);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_set_span_update_font__23__2__28__2__27__r0);
            Helpers.WaitForCompletion();
        }

        public long _shaped_get_run_count(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_get_run_count__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public string _shaped_get_run_text(ulong shaped, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, index);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_get_run_text__23__2__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public Vector2i _shaped_get_run_range(ulong shaped, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, index);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_get_run_range__23__2__r6);
            Helpers.WaitForCompletion();
            Vector2i result = Helpers.ReadVector2i(Commands.CMD_DATA);
            return result;
        }

        public Vector2i _shaped_get_run_glyph_range(ulong shaped, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, index);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_get_run_glyph_range__23__2__r6);
            Helpers.WaitForCompletion();
            Vector2i result = Helpers.ReadVector2i(Commands.CMD_DATA);
            return result;
        }

        public ulong _shaped_get_run_font_rid(ulong shaped, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, index);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_get_run_font_rid__23__2__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public long _shaped_get_run_font_size(ulong shaped, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, index);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_get_run_font_size__23__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public string _shaped_get_run_language(ulong shaped, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, index);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_get_run_language__23__2__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public long _shaped_get_run_direction(ulong shaped, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, index);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_get_run_direction__23__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void _shaped_get_run_object(ulong shaped, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, index);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_get_run_object__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public ulong _shaped_text_substr(ulong shaped, long start, long length)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, start);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, length);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_substr__23__2__2__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public ulong _shaped_text_get_parent(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_get_parent__23__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public double _shaped_text_fit_to_width(ulong shaped, double width, long justification_flags)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, width);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, justification_flags);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_fit_to_width__23__3__2__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public double _shaped_text_tab_align(ulong shaped, float[] tab_stops)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WritePackedFloat32Array(Commands.CMD_DATA + 16, tab_stops);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_tab_align__23__32__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public bool _shaped_text_shape(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_shape__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool _shaped_text_update_breaks(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_update_breaks__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool _shaped_text_update_justification_ops(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_update_justification_ops__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool _shaped_text_is_ready(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_is_ready__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public long _shaped_text_get_glyphs(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_get_glyphs__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long _shaped_text_sort_logical(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_sort_logical__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long _shaped_text_get_glyph_count(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_get_glyph_count__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public Vector2i _shaped_text_get_range(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_get_range__23__r6);
            Helpers.WaitForCompletion();
            Vector2i result = Helpers.ReadVector2i(Commands.CMD_DATA);
            return result;
        }

        public int[] _shaped_text_get_line_breaks_adv(ulong shaped, float[] width, long start, bool once, long break_flags)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WritePackedFloat32Array(Commands.CMD_DATA + 16, width);
            Helpers.WriteInt64(Commands.CMD_DATA + 16 + 4 + (width.Length * 4), start);
            Helpers.WriteInt32(Commands.CMD_DATA + 16 + 4 + (width.Length * 4) + 8, once ? 1 : 0);
            Helpers.WriteInt64(Commands.CMD_DATA + 16 + 4 + (width.Length * 4) + 8 + 4, break_flags);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_get_line_breaks_adv__23__32__2__1__2__r30);
            Helpers.WaitForCompletion();
            int[] result = Helpers.ReadPackedInt32Array(Commands.CMD_DATA);
            return result;
        }

        public int[] _shaped_text_get_line_breaks(ulong shaped, double width, long start, long break_flags)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, width);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, start);
            Helpers.WriteInt64(Commands.CMD_DATA + 32, break_flags);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_get_line_breaks__23__3__2__2__r30);
            Helpers.WaitForCompletion();
            int[] result = Helpers.ReadPackedInt32Array(Commands.CMD_DATA);
            return result;
        }

        public int[] _shaped_text_get_word_breaks(ulong shaped, long grapheme_flags, long skip_grapheme_flags)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, grapheme_flags);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, skip_grapheme_flags);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_get_word_breaks__23__2__2__r30);
            Helpers.WaitForCompletion();
            int[] result = Helpers.ReadPackedInt32Array(Commands.CMD_DATA);
            return result;
        }

        public long _shaped_text_get_trim_pos(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_get_trim_pos__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long _shaped_text_get_ellipsis_pos(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_get_ellipsis_pos__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long _shaped_text_get_ellipsis_glyph_count(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_get_ellipsis_glyph_count__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long _shaped_text_get_ellipsis_glyphs(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_get_ellipsis_glyphs__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void _shaped_text_overrun_trim_to_width(ulong shaped, double width, long trim_flags)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, width);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, trim_flags);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_overrun_trim_to_width__23__3__2__r0);
            Helpers.WaitForCompletion();
        }

        public object _shaped_text_get_objects(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_get_objects__23__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public Rect2 _shaped_text_get_object_rect(ulong shaped, object key)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteVariant(Commands.CMD_DATA + 16, key);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_get_object_rect__23__0__r7);
            Helpers.WaitForCompletion();
            Rect2 result = Helpers.ReadRect2(Commands.CMD_DATA);
            return result;
        }

        public Vector2i _shaped_text_get_object_range(ulong shaped, object key)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteVariant(Commands.CMD_DATA + 16, key);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_get_object_range__23__0__r6);
            Helpers.WaitForCompletion();
            Vector2i result = Helpers.ReadVector2i(Commands.CMD_DATA);
            return result;
        }

        public long _shaped_text_get_object_glyph(ulong shaped, object key)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteVariant(Commands.CMD_DATA + 16, key);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_get_object_glyph__23__0__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public Vector2 _shaped_text_get_size(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_get_size__23__r5);
            Helpers.WaitForCompletion();
            Vector2 result = Helpers.ReadVector2(Commands.CMD_DATA);
            return result;
        }

        public double _shaped_text_get_ascent(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_get_ascent__23__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public double _shaped_text_get_descent(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_get_descent__23__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public double _shaped_text_get_width(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_get_width__23__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public double _shaped_text_get_underline_position(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_get_underline_position__23__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public double _shaped_text_get_underline_thickness(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_get_underline_thickness__23__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public long _shaped_text_get_dominant_direction_in_range(ulong shaped, long start, long end)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, start);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, end);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_get_dominant_direction_in_range__23__2__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void _shaped_text_get_carets(ulong shaped, long position, long caret)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, position);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, caret);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_get_carets__23__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public Vector2[] _shaped_text_get_selection(ulong shaped, long start, long end)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, start);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, end);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_get_selection__23__2__2__r35);
            Helpers.WaitForCompletion();
            Vector2[] result = Helpers.ReadPackedVector2Array(Commands.CMD_DATA);
            return result;
        }

        public long _shaped_text_hit_test_grapheme(ulong shaped, double coord)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, coord);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_hit_test_grapheme__23__3__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long _shaped_text_hit_test_position(ulong shaped, double coord)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, coord);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_hit_test_position__23__3__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void _shaped_text_draw(ulong shaped, ulong canvas, Vector2 pos, double clip_l, double clip_r, Color color, double oversampling)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteRID(Commands.CMD_DATA + 16, canvas);
            Helpers.WriteVector2(Commands.CMD_DATA + 24, pos);
            Helpers.WriteDouble(Commands.CMD_DATA + 32, clip_l);
            Helpers.WriteDouble(Commands.CMD_DATA + 40, clip_r);
            Helpers.WriteColor(Commands.CMD_DATA + 48, color);
            Helpers.WriteDouble(Commands.CMD_DATA + 64, oversampling);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_draw__23__23__5__3__3__20__3__r0);
            Helpers.WaitForCompletion();
        }

        public void _shaped_text_draw_outline(ulong shaped, ulong canvas, Vector2 pos, double clip_l, double clip_r, long outline_size, Color color, double oversampling)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteRID(Commands.CMD_DATA + 16, canvas);
            Helpers.WriteVector2(Commands.CMD_DATA + 24, pos);
            Helpers.WriteDouble(Commands.CMD_DATA + 32, clip_l);
            Helpers.WriteDouble(Commands.CMD_DATA + 40, clip_r);
            Helpers.WriteInt64(Commands.CMD_DATA + 48, outline_size);
            Helpers.WriteColor(Commands.CMD_DATA + 56, color);
            Helpers.WriteDouble(Commands.CMD_DATA + 72, oversampling);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_draw_outline__23__23__5__3__3__2__20__3__r0);
            Helpers.WaitForCompletion();
        }

        public Vector2 _shaped_text_get_grapheme_bounds(ulong shaped, long pos)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, pos);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_get_grapheme_bounds__23__2__r5);
            Helpers.WaitForCompletion();
            Vector2 result = Helpers.ReadVector2(Commands.CMD_DATA);
            return result;
        }

        public long _shaped_text_next_grapheme_pos(ulong shaped, long pos)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, pos);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_next_grapheme_pos__23__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long _shaped_text_prev_grapheme_pos(ulong shaped, long pos)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, pos);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_prev_grapheme_pos__23__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public int[] _shaped_text_get_character_breaks(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_get_character_breaks__23__r30);
            Helpers.WaitForCompletion();
            int[] result = Helpers.ReadPackedInt32Array(Commands.CMD_DATA);
            return result;
        }

        public long _shaped_text_next_character_pos(ulong shaped, long pos)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, pos);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_next_character_pos__23__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long _shaped_text_prev_character_pos(ulong shaped, long pos)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, pos);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_prev_character_pos__23__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long _shaped_text_closest_character_pos(ulong shaped, long pos)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, pos);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__shaped_text_closest_character_pos__23__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public string _format_number(string number, string language)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, number);
            Helpers.WriteString(Commands.CMD_DATA + 1036, language);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__format_number__4__4__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public string _parse_number(string number, string language)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, number);
            Helpers.WriteString(Commands.CMD_DATA + 1036, language);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__parse_number__4__4__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public string _percent_sign(string language)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, language);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__percent_sign__4__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public string _strip_diacritics(string string_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, string_);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__strip_diacritics__4__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public bool _is_valid_identifier(string string_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, string_);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__is_valid_identifier__4__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool _is_valid_letter(long unicode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, unicode);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__is_valid_letter__2__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public int[] _string_get_word_breaks(string string_, string language, long chars_per_line)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, string_);
            Helpers.WriteString(Commands.CMD_DATA + 1036, language);
            Helpers.WriteInt64(Commands.CMD_DATA + 2064, chars_per_line);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__string_get_word_breaks__4__4__2__r30);
            Helpers.WaitForCompletion();
            int[] result = Helpers.ReadPackedInt32Array(Commands.CMD_DATA);
            return result;
        }

        public int[] _string_get_character_breaks(string string_, string language)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, string_);
            Helpers.WriteString(Commands.CMD_DATA + 1036, language);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__string_get_character_breaks__4__4__r30);
            Helpers.WaitForCompletion();
            int[] result = Helpers.ReadPackedInt32Array(Commands.CMD_DATA);
            return result;
        }

        public long _is_confusable(string string_, string[] dict)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, string_);
            Helpers.WritePackedStringArray(Commands.CMD_DATA + 1036, dict);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__is_confusable__4__34__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool _spoof_check(string string_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, string_);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__spoof_check__4__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public string _string_to_upper(string string_, string language)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, string_);
            Helpers.WriteString(Commands.CMD_DATA + 1036, language);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__string_to_upper__4__4__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public string _string_to_lower(string string_, string language)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, string_);
            Helpers.WriteString(Commands.CMD_DATA + 1036, language);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__string_to_lower__4__4__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public string _string_to_title(string string_, string language)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, string_);
            Helpers.WriteString(Commands.CMD_DATA + 1036, language);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__string_to_title__4__4__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public object _parse_structured_text(long parser_type, object args, string text)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, parser_type);
            Helpers.WriteArray(Commands.CMD_DATA + 16, args);
            Helpers.WriteString(Commands.CMD_DATA + 16, text);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__parse_structured_text__2__28__4__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void _cleanup()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__cleanup__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_feature(long feature)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, feature);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_has_feature__2__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public string get_name()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_get_name__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public long get_features()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_get_features__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool load_support_data(string filename)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, filename);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_load_support_data__4__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public string get_support_data_filename()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_get_support_data_filename__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public string get_support_data_info()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_get_support_data_info__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public bool save_support_data(string filename)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, filename);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_save_support_data__4__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public byte[] get_support_data()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_get_support_data__r29);
            Helpers.WaitForCompletion();
            byte[] result = Helpers.ReadPackedByteArray(Commands.CMD_DATA);
            return result;
        }

        public bool is_locale_using_support_data(string locale)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, locale);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_is_locale_using_support_data__4__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool is_locale_right_to_left(string locale)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, locale);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_is_locale_right_to_left__4__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public long name_to_tag(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_name_to_tag__4__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public string tag_to_name(long tag)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, tag);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_tag_to_name__2__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public bool has(ulong rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_has__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void free_rid(ulong rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_free_rid__23__r0);
            Helpers.WaitForCompletion();
        }

        public ulong create_font()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_create_font__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public ulong create_font_linked_variation(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_create_font_linked_variation__23__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void font_set_data(ulong font_rid, byte[] arg_data)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WritePackedByteArray(Commands.CMD_DATA + 16, arg_data);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_set_data__23__29__r0);
            Helpers.WaitForCompletion();
        }

        public void font_set_face_index(ulong font_rid, long face_index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, face_index);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_set_face_index__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long font_get_face_index(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_get_face_index__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long font_get_face_count(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_get_face_count__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void font_set_style(ulong font_rid, long style)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, style);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_set_style__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long font_get_style(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_get_style__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void font_set_name(ulong font_rid, string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteString(Commands.CMD_DATA + 16, name);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_set_name__23__4__r0);
            Helpers.WaitForCompletion();
        }

        public string font_get_name(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_get_name__23__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public object font_get_ot_name_strings(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_get_ot_name_strings__23__r27);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadDictionary(Commands.CMD_DATA);
            return result;
        }

        public void font_set_style_name(ulong font_rid, string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteString(Commands.CMD_DATA + 16, name);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_set_style_name__23__4__r0);
            Helpers.WaitForCompletion();
        }

        public string font_get_style_name(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_get_style_name__23__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void font_set_weight(ulong font_rid, long weight)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, weight);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_set_weight__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long font_get_weight(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_get_weight__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void font_set_stretch(ulong font_rid, long weight)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, weight);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_set_stretch__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long font_get_stretch(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_get_stretch__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void font_set_antialiasing(ulong font_rid, long antialiasing)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, antialiasing);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_set_antialiasing__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long font_get_antialiasing(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_get_antialiasing__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void font_set_disable_embedded_bitmaps(ulong font_rid, bool disable_embedded_bitmaps)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, disable_embedded_bitmaps ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_set_disable_embedded_bitmaps__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool font_get_disable_embedded_bitmaps(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_get_disable_embedded_bitmaps__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void font_set_generate_mipmaps(ulong font_rid, bool generate_mipmaps)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, generate_mipmaps ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_set_generate_mipmaps__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool font_get_generate_mipmaps(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_get_generate_mipmaps__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void font_set_multichannel_signed_distance_field(ulong font_rid, bool msdf)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, msdf ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_set_multichannel_signed_distance_field__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool font_is_multichannel_signed_distance_field(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_is_multichannel_signed_distance_field__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void font_set_msdf_pixel_range(ulong font_rid, long msdf_pixel_range)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, msdf_pixel_range);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_set_msdf_pixel_range__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long font_get_msdf_pixel_range(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_get_msdf_pixel_range__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void font_set_msdf_size(ulong font_rid, long msdf_size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, msdf_size);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_set_msdf_size__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long font_get_msdf_size(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_get_msdf_size__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void font_set_fixed_size(ulong font_rid, long fixed_size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, fixed_size);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_set_fixed_size__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long font_get_fixed_size(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_get_fixed_size__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void font_set_fixed_size_scale_mode(ulong font_rid, long fixed_size_scale_mode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, fixed_size_scale_mode);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_set_fixed_size_scale_mode__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long font_get_fixed_size_scale_mode(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_get_fixed_size_scale_mode__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void font_set_allow_system_fallback(ulong font_rid, bool allow_system_fallback)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, allow_system_fallback ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_set_allow_system_fallback__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool font_is_allow_system_fallback(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_is_allow_system_fallback__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void font_clear_system_fallback_cache()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_clear_system_fallback_cache__r0);
            Helpers.WaitForCompletion();
        }

        public void font_set_force_autohinter(ulong font_rid, bool force_autohinter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, force_autohinter ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_set_force_autohinter__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool font_is_force_autohinter(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_is_force_autohinter__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void font_set_modulate_color_glyphs(ulong font_rid, bool force_autohinter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, force_autohinter ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_set_modulate_color_glyphs__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool font_is_modulate_color_glyphs(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_is_modulate_color_glyphs__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void font_set_hinting(ulong font_rid, long hinting)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, hinting);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_set_hinting__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long font_get_hinting(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_get_hinting__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void font_set_subpixel_positioning(ulong font_rid, long subpixel_positioning)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, subpixel_positioning);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_set_subpixel_positioning__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long font_get_subpixel_positioning(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_get_subpixel_positioning__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void font_set_keep_rounding_remainders(ulong font_rid, bool keep_rounding_remainders)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, keep_rounding_remainders ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_set_keep_rounding_remainders__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool font_get_keep_rounding_remainders(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_get_keep_rounding_remainders__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void font_set_embolden(ulong font_rid, double strength)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, strength);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_set_embolden__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public double font_get_embolden(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_get_embolden__23__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void font_set_spacing(ulong font_rid, long spacing, long value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, spacing);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, value);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_set_spacing__23__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public long font_get_spacing(ulong font_rid, long spacing)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, spacing);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_get_spacing__23__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void font_set_baseline_offset(ulong font_rid, double baseline_offset)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, baseline_offset);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_set_baseline_offset__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public double font_get_baseline_offset(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_get_baseline_offset__23__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void font_set_transform(ulong font_rid, Transform2D transform)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteTransform2D(Commands.CMD_DATA + 16, transform);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_set_transform__23__11__r0);
            Helpers.WaitForCompletion();
        }

        public Transform2D font_get_transform(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_get_transform__23__r11);
            Helpers.WaitForCompletion();
            Transform2D result = Helpers.ReadTransform2D(Commands.CMD_DATA);
            return result;
        }

        public void font_set_variation_coordinates(ulong font_rid, object variation_coordinates)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteDictionary(Commands.CMD_DATA + 16, variation_coordinates);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_set_variation_coordinates__23__27__r0);
            Helpers.WaitForCompletion();
        }

        public object font_get_variation_coordinates(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_get_variation_coordinates__23__r27);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadDictionary(Commands.CMD_DATA);
            return result;
        }

        public void font_set_oversampling(ulong font_rid, double oversampling)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, oversampling);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_set_oversampling__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public double font_get_oversampling(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_get_oversampling__23__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public object font_get_size_cache_list(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_get_size_cache_list__23__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void font_clear_size_cache(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_clear_size_cache__23__r0);
            Helpers.WaitForCompletion();
        }

        public void font_remove_size_cache(ulong font_rid, Vector2i size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteVector2i(Commands.CMD_DATA + 16, size);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_remove_size_cache__23__6__r0);
            Helpers.WaitForCompletion();
        }

        public object font_get_size_cache_info(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_get_size_cache_info__23__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void font_set_ascent(ulong font_rid, long size, double ascent)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, size);
            Helpers.WriteDouble(Commands.CMD_DATA + 24, ascent);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_set_ascent__23__2__3__r0);
            Helpers.WaitForCompletion();
        }

        public double font_get_ascent(ulong font_rid, long size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, size);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_get_ascent__23__2__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void font_set_descent(ulong font_rid, long size, double descent)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, size);
            Helpers.WriteDouble(Commands.CMD_DATA + 24, descent);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_set_descent__23__2__3__r0);
            Helpers.WaitForCompletion();
        }

        public double font_get_descent(ulong font_rid, long size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, size);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_get_descent__23__2__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void font_set_underline_position(ulong font_rid, long size, double underline_position)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, size);
            Helpers.WriteDouble(Commands.CMD_DATA + 24, underline_position);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_set_underline_position__23__2__3__r0);
            Helpers.WaitForCompletion();
        }

        public double font_get_underline_position(ulong font_rid, long size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, size);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_get_underline_position__23__2__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void font_set_underline_thickness(ulong font_rid, long size, double underline_thickness)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, size);
            Helpers.WriteDouble(Commands.CMD_DATA + 24, underline_thickness);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_set_underline_thickness__23__2__3__r0);
            Helpers.WaitForCompletion();
        }

        public double font_get_underline_thickness(ulong font_rid, long size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, size);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_get_underline_thickness__23__2__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void font_set_scale(ulong font_rid, long size, double scale)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, size);
            Helpers.WriteDouble(Commands.CMD_DATA + 24, scale);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_set_scale__23__2__3__r0);
            Helpers.WaitForCompletion();
        }

        public double font_get_scale(ulong font_rid, long size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, size);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_get_scale__23__2__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public long font_get_texture_count(ulong font_rid, Vector2i size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteVector2i(Commands.CMD_DATA + 16, size);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_get_texture_count__23__6__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void font_clear_textures(ulong font_rid, Vector2i size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteVector2i(Commands.CMD_DATA + 16, size);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_clear_textures__23__6__r0);
            Helpers.WaitForCompletion();
        }

        public void font_remove_texture(ulong font_rid, Vector2i size, long texture_index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteVector2i(Commands.CMD_DATA + 16, size);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, texture_index);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_remove_texture__23__6__2__r0);
            Helpers.WaitForCompletion();
        }

        public void font_set_texture_image(ulong font_rid, Vector2i size, long texture_index, ulong image)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteVector2i(Commands.CMD_DATA + 16, size);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, texture_index);
            Helpers.WriteUInt64(Commands.CMD_DATA + 32, image);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_set_texture_image__23__6__2__24__r0);
            Helpers.WaitForCompletion();
        }

        public ulong font_get_texture_image(ulong font_rid, Vector2i size, long texture_index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteVector2i(Commands.CMD_DATA + 16, size);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, texture_index);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_get_texture_image__23__6__2__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void font_set_texture_offsets(ulong font_rid, Vector2i size, long texture_index, int[] offset)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteVector2i(Commands.CMD_DATA + 16, size);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, texture_index);
            Helpers.WritePackedInt32Array(Commands.CMD_DATA + 32, offset);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_set_texture_offsets__23__6__2__30__r0);
            Helpers.WaitForCompletion();
        }

        public int[] font_get_texture_offsets(ulong font_rid, Vector2i size, long texture_index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteVector2i(Commands.CMD_DATA + 16, size);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, texture_index);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_get_texture_offsets__23__6__2__r30);
            Helpers.WaitForCompletion();
            int[] result = Helpers.ReadPackedInt32Array(Commands.CMD_DATA);
            return result;
        }

        public int[] font_get_glyph_list(ulong font_rid, Vector2i size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteVector2i(Commands.CMD_DATA + 16, size);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_get_glyph_list__23__6__r30);
            Helpers.WaitForCompletion();
            int[] result = Helpers.ReadPackedInt32Array(Commands.CMD_DATA);
            return result;
        }

        public void font_clear_glyphs(ulong font_rid, Vector2i size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteVector2i(Commands.CMD_DATA + 16, size);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_clear_glyphs__23__6__r0);
            Helpers.WaitForCompletion();
        }

        public void font_remove_glyph(ulong font_rid, Vector2i size, long glyph)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteVector2i(Commands.CMD_DATA + 16, size);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, glyph);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_remove_glyph__23__6__2__r0);
            Helpers.WaitForCompletion();
        }

        public Vector2 font_get_glyph_advance(ulong font_rid, long size, long glyph)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, size);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, glyph);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_get_glyph_advance__23__2__2__r5);
            Helpers.WaitForCompletion();
            Vector2 result = Helpers.ReadVector2(Commands.CMD_DATA);
            return result;
        }

        public void font_set_glyph_advance(ulong font_rid, long size, long glyph, Vector2 advance)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, size);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, glyph);
            Helpers.WriteVector2(Commands.CMD_DATA + 32, advance);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_set_glyph_advance__23__2__2__5__r0);
            Helpers.WaitForCompletion();
        }

        public Vector2 font_get_glyph_offset(ulong font_rid, Vector2i size, long glyph)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteVector2i(Commands.CMD_DATA + 16, size);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, glyph);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_get_glyph_offset__23__6__2__r5);
            Helpers.WaitForCompletion();
            Vector2 result = Helpers.ReadVector2(Commands.CMD_DATA);
            return result;
        }

        public void font_set_glyph_offset(ulong font_rid, Vector2i size, long glyph, Vector2 offset)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteVector2i(Commands.CMD_DATA + 16, size);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, glyph);
            Helpers.WriteVector2(Commands.CMD_DATA + 32, offset);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_set_glyph_offset__23__6__2__5__r0);
            Helpers.WaitForCompletion();
        }

        public Vector2 font_get_glyph_size(ulong font_rid, Vector2i size, long glyph)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteVector2i(Commands.CMD_DATA + 16, size);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, glyph);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_get_glyph_size__23__6__2__r5);
            Helpers.WaitForCompletion();
            Vector2 result = Helpers.ReadVector2(Commands.CMD_DATA);
            return result;
        }

        public void font_set_glyph_size(ulong font_rid, Vector2i size, long glyph, Vector2 gl_size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteVector2i(Commands.CMD_DATA + 16, size);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, glyph);
            Helpers.WriteVector2(Commands.CMD_DATA + 32, gl_size);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_set_glyph_size__23__6__2__5__r0);
            Helpers.WaitForCompletion();
        }

        public Rect2 font_get_glyph_uv_rect(ulong font_rid, Vector2i size, long glyph)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteVector2i(Commands.CMD_DATA + 16, size);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, glyph);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_get_glyph_uv_rect__23__6__2__r7);
            Helpers.WaitForCompletion();
            Rect2 result = Helpers.ReadRect2(Commands.CMD_DATA);
            return result;
        }

        public void font_set_glyph_uv_rect(ulong font_rid, Vector2i size, long glyph, Rect2 uv_rect)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteVector2i(Commands.CMD_DATA + 16, size);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, glyph);
            Helpers.WriteRect2(Commands.CMD_DATA + 32, uv_rect);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_set_glyph_uv_rect__23__6__2__7__r0);
            Helpers.WaitForCompletion();
        }

        public long font_get_glyph_texture_idx(ulong font_rid, Vector2i size, long glyph)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteVector2i(Commands.CMD_DATA + 16, size);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, glyph);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_get_glyph_texture_idx__23__6__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void font_set_glyph_texture_idx(ulong font_rid, Vector2i size, long glyph, long texture_idx)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteVector2i(Commands.CMD_DATA + 16, size);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, glyph);
            Helpers.WriteInt64(Commands.CMD_DATA + 32, texture_idx);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_set_glyph_texture_idx__23__6__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public ulong font_get_glyph_texture_rid(ulong font_rid, Vector2i size, long glyph)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteVector2i(Commands.CMD_DATA + 16, size);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, glyph);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_get_glyph_texture_rid__23__6__2__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public Vector2 font_get_glyph_texture_size(ulong font_rid, Vector2i size, long glyph)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteVector2i(Commands.CMD_DATA + 16, size);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, glyph);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_get_glyph_texture_size__23__6__2__r5);
            Helpers.WaitForCompletion();
            Vector2 result = Helpers.ReadVector2(Commands.CMD_DATA);
            return result;
        }

        public object font_get_glyph_contours(ulong font, long size, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, size);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, index);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_get_glyph_contours__23__2__2__r27);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadDictionary(Commands.CMD_DATA);
            return result;
        }

        public object font_get_kerning_list(ulong font_rid, long size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, size);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_get_kerning_list__23__2__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void font_clear_kerning_map(ulong font_rid, long size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, size);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_clear_kerning_map__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void font_remove_kerning(ulong font_rid, long size, Vector2i glyph_pair)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, size);
            Helpers.WriteVector2i(Commands.CMD_DATA + 24, glyph_pair);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_remove_kerning__23__2__6__r0);
            Helpers.WaitForCompletion();
        }

        public void font_set_kerning(ulong font_rid, long size, Vector2i glyph_pair, Vector2 kerning)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, size);
            Helpers.WriteVector2i(Commands.CMD_DATA + 24, glyph_pair);
            Helpers.WriteVector2(Commands.CMD_DATA + 32, kerning);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_set_kerning__23__2__6__5__r0);
            Helpers.WaitForCompletion();
        }

        public Vector2 font_get_kerning(ulong font_rid, long size, Vector2i glyph_pair)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, size);
            Helpers.WriteVector2i(Commands.CMD_DATA + 24, glyph_pair);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_get_kerning__23__2__6__r5);
            Helpers.WaitForCompletion();
            Vector2 result = Helpers.ReadVector2(Commands.CMD_DATA);
            return result;
        }

        public long font_get_glyph_index(ulong font_rid, long size, long char_, long variation_selector)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, size);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, char_);
            Helpers.WriteInt64(Commands.CMD_DATA + 32, variation_selector);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_get_glyph_index__23__2__2__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long font_get_char_from_glyph_index(ulong font_rid, long size, long glyph_index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, size);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, glyph_index);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_get_char_from_glyph_index__23__2__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool font_has_char(ulong font_rid, long char_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, char_);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_has_char__23__2__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public string font_get_supported_chars(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_get_supported_chars__23__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public int[] font_get_supported_glyphs(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_get_supported_glyphs__23__r30);
            Helpers.WaitForCompletion();
            int[] result = Helpers.ReadPackedInt32Array(Commands.CMD_DATA);
            return result;
        }

        public void font_render_range(ulong font_rid, Vector2i size, long start, long end)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteVector2i(Commands.CMD_DATA + 16, size);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, start);
            Helpers.WriteInt64(Commands.CMD_DATA + 32, end);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_render_range__23__6__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public void font_render_glyph(ulong font_rid, Vector2i size, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteVector2i(Commands.CMD_DATA + 16, size);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, index);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_render_glyph__23__6__2__r0);
            Helpers.WaitForCompletion();
        }

        public void font_draw_glyph(ulong font_rid, ulong canvas, long size, Vector2 pos, long index, Color color, double oversampling)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteRID(Commands.CMD_DATA + 16, canvas);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, size);
            Helpers.WriteVector2(Commands.CMD_DATA + 32, pos);
            Helpers.WriteInt64(Commands.CMD_DATA + 40, index);
            Helpers.WriteColor(Commands.CMD_DATA + 48, color);
            Helpers.WriteDouble(Commands.CMD_DATA + 64, oversampling);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_draw_glyph__23__23__2__5__2__20__3__r0);
            Helpers.WaitForCompletion();
        }

        public void font_draw_glyph_outline(ulong font_rid, ulong canvas, long size, long outline_size, Vector2 pos, long index, Color color, double oversampling)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteRID(Commands.CMD_DATA + 16, canvas);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, size);
            Helpers.WriteInt64(Commands.CMD_DATA + 32, outline_size);
            Helpers.WriteVector2(Commands.CMD_DATA + 40, pos);
            Helpers.WriteInt64(Commands.CMD_DATA + 48, index);
            Helpers.WriteColor(Commands.CMD_DATA + 56, color);
            Helpers.WriteDouble(Commands.CMD_DATA + 72, oversampling);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_draw_glyph_outline__23__23__2__2__5__2__20__3__r0);
            Helpers.WaitForCompletion();
        }

        public bool font_is_language_supported(ulong font_rid, string language)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteString(Commands.CMD_DATA + 16, language);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_is_language_supported__23__4__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void font_set_language_support_override(ulong font_rid, string language, bool supported)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteString(Commands.CMD_DATA + 16, language);
            Helpers.WriteInt32(Commands.CMD_DATA + 1044, supported ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_set_language_support_override__23__4__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool font_get_language_support_override(ulong font_rid, string language)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteString(Commands.CMD_DATA + 16, language);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_get_language_support_override__23__4__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void font_remove_language_support_override(ulong font_rid, string language)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteString(Commands.CMD_DATA + 16, language);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_remove_language_support_override__23__4__r0);
            Helpers.WaitForCompletion();
        }

        public string[] font_get_language_support_overrides(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_get_language_support_overrides__23__r34);
            Helpers.WaitForCompletion();
            string[] result = Helpers.ReadPackedStringArray(Commands.CMD_DATA);
            return result;
        }

        public bool font_is_script_supported(ulong font_rid, string script)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteString(Commands.CMD_DATA + 16, script);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_is_script_supported__23__4__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void font_set_script_support_override(ulong font_rid, string script, bool supported)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteString(Commands.CMD_DATA + 16, script);
            Helpers.WriteInt32(Commands.CMD_DATA + 1044, supported ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_set_script_support_override__23__4__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool font_get_script_support_override(ulong font_rid, string script)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteString(Commands.CMD_DATA + 16, script);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_get_script_support_override__23__4__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void font_remove_script_support_override(ulong font_rid, string script)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteString(Commands.CMD_DATA + 16, script);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_remove_script_support_override__23__4__r0);
            Helpers.WaitForCompletion();
        }

        public string[] font_get_script_support_overrides(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_get_script_support_overrides__23__r34);
            Helpers.WaitForCompletion();
            string[] result = Helpers.ReadPackedStringArray(Commands.CMD_DATA);
            return result;
        }

        public void font_set_opentype_feature_overrides(ulong font_rid, object overrides)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.WriteDictionary(Commands.CMD_DATA + 16, overrides);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_set_opentype_feature_overrides__23__27__r0);
            Helpers.WaitForCompletion();
        }

        public object font_get_opentype_feature_overrides(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_get_opentype_feature_overrides__23__r27);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadDictionary(Commands.CMD_DATA);
            return result;
        }

        public object font_supported_feature_list(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_supported_feature_list__23__r27);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadDictionary(Commands.CMD_DATA);
            return result;
        }

        public object font_supported_variation_list(ulong font_rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, font_rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_supported_variation_list__23__r27);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadDictionary(Commands.CMD_DATA);
            return result;
        }

        public double font_get_global_oversampling()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_get_global_oversampling__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void font_set_global_oversampling(double oversampling)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDouble(Commands.CMD_DATA + 8, oversampling);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_font_set_global_oversampling__3__r0);
            Helpers.WaitForCompletion();
        }

        public Vector2 get_hex_code_box_size(long size, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, size);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, index);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_get_hex_code_box_size__2__2__r5);
            Helpers.WaitForCompletion();
            Vector2 result = Helpers.ReadVector2(Commands.CMD_DATA);
            return result;
        }

        public void draw_hex_code_box(ulong canvas, long size, Vector2 pos, long index, Color color)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, canvas);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, size);
            Helpers.WriteVector2(Commands.CMD_DATA + 24, pos);
            Helpers.WriteInt64(Commands.CMD_DATA + 32, index);
            Helpers.WriteColor(Commands.CMD_DATA + 40, color);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_draw_hex_code_box__23__2__5__2__20__r0);
            Helpers.WaitForCompletion();
        }

        public ulong create_shaped_text(long direction, long orientation)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, direction);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, orientation);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_create_shaped_text__2__2__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void shaped_text_clear(ulong rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_clear__23__r0);
            Helpers.WaitForCompletion();
        }

        public ulong shaped_text_duplicate(ulong rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_duplicate__23__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void shaped_text_set_direction(ulong shaped, long direction)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, direction);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_set_direction__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long shaped_text_get_direction(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_get_direction__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long shaped_text_get_inferred_direction(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_get_inferred_direction__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void shaped_text_set_bidi_override(ulong shaped, object override_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteArray(Commands.CMD_DATA + 16, override_);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_set_bidi_override__23__28__r0);
            Helpers.WaitForCompletion();
        }

        public void shaped_text_set_custom_punctuation(ulong shaped, string punct)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteString(Commands.CMD_DATA + 16, punct);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_set_custom_punctuation__23__4__r0);
            Helpers.WaitForCompletion();
        }

        public string shaped_text_get_custom_punctuation(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_get_custom_punctuation__23__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void shaped_text_set_custom_ellipsis(ulong shaped, long char_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, char_);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_set_custom_ellipsis__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long shaped_text_get_custom_ellipsis(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_get_custom_ellipsis__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void shaped_text_set_orientation(ulong shaped, long orientation)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, orientation);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_set_orientation__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long shaped_text_get_orientation(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_get_orientation__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void shaped_text_set_preserve_invalid(ulong shaped, bool enabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_set_preserve_invalid__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool shaped_text_get_preserve_invalid(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_get_preserve_invalid__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void shaped_text_set_preserve_control(ulong shaped, bool enabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_set_preserve_control__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool shaped_text_get_preserve_control(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_get_preserve_control__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void shaped_text_set_spacing(ulong shaped, long spacing, long value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, spacing);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, value);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_set_spacing__23__2__2__r0);
            Helpers.WaitForCompletion();
        }

        public long shaped_text_get_spacing(ulong shaped, long spacing)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, spacing);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_get_spacing__23__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool shaped_text_add_string(ulong shaped, string text, object fonts, long size, object opentype_features, string language, object meta)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteString(Commands.CMD_DATA + 16, text);
            Helpers.WriteArray(Commands.CMD_DATA + 1044, fonts);
            Helpers.WriteInt64(Commands.CMD_DATA + 1044, size);
            Helpers.WriteDictionary(Commands.CMD_DATA + 1052, opentype_features);
            Helpers.WriteString(Commands.CMD_DATA + 1052, language);
            Helpers.WriteVariant(Commands.CMD_DATA + 2080, meta);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_add_string__23__4__28__2__27__4__0__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool shaped_text_add_object(ulong shaped, object key, Vector2 size, long inline_align, long length, double baseline)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteVariant(Commands.CMD_DATA + 16, key);
            Helpers.WriteVector2(Commands.CMD_DATA + 16, size);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, inline_align);
            Helpers.WriteInt64(Commands.CMD_DATA + 32, length);
            Helpers.WriteDouble(Commands.CMD_DATA + 40, baseline);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_add_object__23__0__5__2__2__3__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool shaped_text_resize_object(ulong shaped, object key, Vector2 size, long inline_align, double baseline)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteVariant(Commands.CMD_DATA + 16, key);
            Helpers.WriteVector2(Commands.CMD_DATA + 16, size);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, inline_align);
            Helpers.WriteDouble(Commands.CMD_DATA + 32, baseline);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_resize_object__23__0__5__2__3__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool shaped_text_has_object(ulong shaped, object key)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteVariant(Commands.CMD_DATA + 16, key);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_has_object__23__0__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public string shaped_get_text(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_get_text__23__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public long shaped_get_span_count(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_get_span_count__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void shaped_get_span_meta(ulong shaped, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, index);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_get_span_meta__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void shaped_get_span_embedded_object(ulong shaped, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, index);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_get_span_embedded_object__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public string shaped_get_span_text(ulong shaped, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, index);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_get_span_text__23__2__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void shaped_get_span_object(ulong shaped, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, index);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_get_span_object__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public void shaped_set_span_update_font(ulong shaped, long index, object fonts, long size, object opentype_features)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, index);
            Helpers.WriteArray(Commands.CMD_DATA + 24, fonts);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, size);
            Helpers.WriteDictionary(Commands.CMD_DATA + 32, opentype_features);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_set_span_update_font__23__2__28__2__27__r0);
            Helpers.WaitForCompletion();
        }

        public long shaped_get_run_count(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_get_run_count__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public string shaped_get_run_text(ulong shaped, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, index);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_get_run_text__23__2__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public Vector2i shaped_get_run_range(ulong shaped, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, index);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_get_run_range__23__2__r6);
            Helpers.WaitForCompletion();
            Vector2i result = Helpers.ReadVector2i(Commands.CMD_DATA);
            return result;
        }

        public Vector2i shaped_get_run_glyph_range(ulong shaped, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, index);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_get_run_glyph_range__23__2__r6);
            Helpers.WaitForCompletion();
            Vector2i result = Helpers.ReadVector2i(Commands.CMD_DATA);
            return result;
        }

        public ulong shaped_get_run_font_rid(ulong shaped, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, index);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_get_run_font_rid__23__2__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public long shaped_get_run_font_size(ulong shaped, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, index);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_get_run_font_size__23__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public string shaped_get_run_language(ulong shaped, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, index);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_get_run_language__23__2__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public long shaped_get_run_direction(ulong shaped, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, index);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_get_run_direction__23__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void shaped_get_run_object(ulong shaped, long index)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, index);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_get_run_object__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public ulong shaped_text_substr(ulong shaped, long start, long length)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, start);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, length);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_substr__23__2__2__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public ulong shaped_text_get_parent(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_get_parent__23__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public double shaped_text_fit_to_width(ulong shaped, double width, long justification_flags)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, width);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, justification_flags);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_fit_to_width__23__3__2__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public double shaped_text_tab_align(ulong shaped, float[] tab_stops)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WritePackedFloat32Array(Commands.CMD_DATA + 16, tab_stops);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_tab_align__23__32__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public bool shaped_text_shape(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_shape__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool shaped_text_is_ready(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_is_ready__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool shaped_text_has_visible_chars(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_has_visible_chars__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public object shaped_text_get_glyphs(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_get_glyphs__23__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object shaped_text_sort_logical(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_sort_logical__23__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public long shaped_text_get_glyph_count(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_get_glyph_count__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public Vector2i shaped_text_get_range(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_get_range__23__r6);
            Helpers.WaitForCompletion();
            Vector2i result = Helpers.ReadVector2i(Commands.CMD_DATA);
            return result;
        }

        public int[] shaped_text_get_line_breaks_adv(ulong shaped, float[] width, long start, bool once, long break_flags)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WritePackedFloat32Array(Commands.CMD_DATA + 16, width);
            Helpers.WriteInt64(Commands.CMD_DATA + 16 + 4 + (width.Length * 4), start);
            Helpers.WriteInt32(Commands.CMD_DATA + 16 + 4 + (width.Length * 4) + 8, once ? 1 : 0);
            Helpers.WriteInt64(Commands.CMD_DATA + 16 + 4 + (width.Length * 4) + 8 + 4, break_flags);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_get_line_breaks_adv__23__32__2__1__2__r30);
            Helpers.WaitForCompletion();
            int[] result = Helpers.ReadPackedInt32Array(Commands.CMD_DATA);
            return result;
        }

        public int[] shaped_text_get_line_breaks(ulong shaped, double width, long start, long break_flags)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, width);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, start);
            Helpers.WriteInt64(Commands.CMD_DATA + 32, break_flags);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_get_line_breaks__23__3__2__2__r30);
            Helpers.WaitForCompletion();
            int[] result = Helpers.ReadPackedInt32Array(Commands.CMD_DATA);
            return result;
        }

        public int[] shaped_text_get_word_breaks(ulong shaped, long grapheme_flags, long skip_grapheme_flags)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, grapheme_flags);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, skip_grapheme_flags);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_get_word_breaks__23__2__2__r30);
            Helpers.WaitForCompletion();
            int[] result = Helpers.ReadPackedInt32Array(Commands.CMD_DATA);
            return result;
        }

        public long shaped_text_get_trim_pos(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_get_trim_pos__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long shaped_text_get_ellipsis_pos(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_get_ellipsis_pos__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public object shaped_text_get_ellipsis_glyphs(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_get_ellipsis_glyphs__23__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public long shaped_text_get_ellipsis_glyph_count(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_get_ellipsis_glyph_count__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void shaped_text_overrun_trim_to_width(ulong shaped, double width, long overrun_trim_flags)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, width);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, overrun_trim_flags);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_overrun_trim_to_width__23__3__2__r0);
            Helpers.WaitForCompletion();
        }

        public object shaped_text_get_objects(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_get_objects__23__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public Rect2 shaped_text_get_object_rect(ulong shaped, object key)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteVariant(Commands.CMD_DATA + 16, key);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_get_object_rect__23__0__r7);
            Helpers.WaitForCompletion();
            Rect2 result = Helpers.ReadRect2(Commands.CMD_DATA);
            return result;
        }

        public Vector2i shaped_text_get_object_range(ulong shaped, object key)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteVariant(Commands.CMD_DATA + 16, key);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_get_object_range__23__0__r6);
            Helpers.WaitForCompletion();
            Vector2i result = Helpers.ReadVector2i(Commands.CMD_DATA);
            return result;
        }

        public long shaped_text_get_object_glyph(ulong shaped, object key)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteVariant(Commands.CMD_DATA + 16, key);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_get_object_glyph__23__0__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public Vector2 shaped_text_get_size(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_get_size__23__r5);
            Helpers.WaitForCompletion();
            Vector2 result = Helpers.ReadVector2(Commands.CMD_DATA);
            return result;
        }

        public double shaped_text_get_ascent(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_get_ascent__23__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public double shaped_text_get_descent(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_get_descent__23__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public double shaped_text_get_width(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_get_width__23__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public double shaped_text_get_underline_position(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_get_underline_position__23__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public double shaped_text_get_underline_thickness(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_get_underline_thickness__23__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public object shaped_text_get_carets(ulong shaped, long position)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, position);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_get_carets__23__2__r27);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadDictionary(Commands.CMD_DATA);
            return result;
        }

        public Vector2[] shaped_text_get_selection(ulong shaped, long start, long end)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, start);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, end);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_get_selection__23__2__2__r35);
            Helpers.WaitForCompletion();
            Vector2[] result = Helpers.ReadPackedVector2Array(Commands.CMD_DATA);
            return result;
        }

        public long shaped_text_hit_test_grapheme(ulong shaped, double coords)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, coords);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_hit_test_grapheme__23__3__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long shaped_text_hit_test_position(ulong shaped, double coords)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, coords);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_hit_test_position__23__3__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public Vector2 shaped_text_get_grapheme_bounds(ulong shaped, long pos)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, pos);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_get_grapheme_bounds__23__2__r5);
            Helpers.WaitForCompletion();
            Vector2 result = Helpers.ReadVector2(Commands.CMD_DATA);
            return result;
        }

        public long shaped_text_next_grapheme_pos(ulong shaped, long pos)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, pos);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_next_grapheme_pos__23__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long shaped_text_prev_grapheme_pos(ulong shaped, long pos)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, pos);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_prev_grapheme_pos__23__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public int[] shaped_text_get_character_breaks(ulong shaped)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_get_character_breaks__23__r30);
            Helpers.WaitForCompletion();
            int[] result = Helpers.ReadPackedInt32Array(Commands.CMD_DATA);
            return result;
        }

        public long shaped_text_next_character_pos(ulong shaped, long pos)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, pos);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_next_character_pos__23__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long shaped_text_prev_character_pos(ulong shaped, long pos)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, pos);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_prev_character_pos__23__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public long shaped_text_closest_character_pos(ulong shaped, long pos)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, pos);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_closest_character_pos__23__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void shaped_text_draw(ulong shaped, ulong canvas, Vector2 pos, double clip_l, double clip_r, Color color, double oversampling)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteRID(Commands.CMD_DATA + 16, canvas);
            Helpers.WriteVector2(Commands.CMD_DATA + 24, pos);
            Helpers.WriteDouble(Commands.CMD_DATA + 32, clip_l);
            Helpers.WriteDouble(Commands.CMD_DATA + 40, clip_r);
            Helpers.WriteColor(Commands.CMD_DATA + 48, color);
            Helpers.WriteDouble(Commands.CMD_DATA + 64, oversampling);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_draw__23__23__5__3__3__20__3__r0);
            Helpers.WaitForCompletion();
        }

        public void shaped_text_draw_outline(ulong shaped, ulong canvas, Vector2 pos, double clip_l, double clip_r, long outline_size, Color color, double oversampling)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteRID(Commands.CMD_DATA + 16, canvas);
            Helpers.WriteVector2(Commands.CMD_DATA + 24, pos);
            Helpers.WriteDouble(Commands.CMD_DATA + 32, clip_l);
            Helpers.WriteDouble(Commands.CMD_DATA + 40, clip_r);
            Helpers.WriteInt64(Commands.CMD_DATA + 48, outline_size);
            Helpers.WriteColor(Commands.CMD_DATA + 56, color);
            Helpers.WriteDouble(Commands.CMD_DATA + 72, oversampling);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_draw_outline__23__23__5__3__3__2__20__3__r0);
            Helpers.WaitForCompletion();
        }

        public long shaped_text_get_dominant_direction_in_range(ulong shaped, long start, long end)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, shaped);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, start);
            Helpers.WriteInt64(Commands.CMD_DATA + 24, end);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_shaped_text_get_dominant_direction_in_range__23__2__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public string format_number(string number, string language)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, number);
            Helpers.WriteString(Commands.CMD_DATA + 1036, language);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_format_number__4__4__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public string parse_number(string number, string language)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, number);
            Helpers.WriteString(Commands.CMD_DATA + 1036, language);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_parse_number__4__4__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public string percent_sign(string language)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, language);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_percent_sign__4__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public int[] string_get_word_breaks(string string_, string language, long chars_per_line)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, string_);
            Helpers.WriteString(Commands.CMD_DATA + 1036, language);
            Helpers.WriteInt64(Commands.CMD_DATA + 2064, chars_per_line);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_string_get_word_breaks__4__4__2__r30);
            Helpers.WaitForCompletion();
            int[] result = Helpers.ReadPackedInt32Array(Commands.CMD_DATA);
            return result;
        }

        public int[] string_get_character_breaks(string string_, string language)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, string_);
            Helpers.WriteString(Commands.CMD_DATA + 1036, language);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_string_get_character_breaks__4__4__r30);
            Helpers.WaitForCompletion();
            int[] result = Helpers.ReadPackedInt32Array(Commands.CMD_DATA);
            return result;
        }

        public long is_confusable(string string_, string[] dict)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, string_);
            Helpers.WritePackedStringArray(Commands.CMD_DATA + 1036, dict);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_is_confusable__4__34__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool spoof_check(string string_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, string_);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_spoof_check__4__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public string strip_diacritics(string string_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, string_);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_strip_diacritics__4__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public bool is_valid_identifier(string string_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, string_);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_is_valid_identifier__4__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool is_valid_letter(long unicode)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, unicode);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_is_valid_letter__2__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public string string_to_upper(string string_, string language)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, string_);
            Helpers.WriteString(Commands.CMD_DATA + 1036, language);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_string_to_upper__4__4__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public string string_to_lower(string string_, string language)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, string_);
            Helpers.WriteString(Commands.CMD_DATA + 1036, language);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_string_to_lower__4__4__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public string string_to_title(string string_, string language)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, string_);
            Helpers.WriteString(Commands.CMD_DATA + 1036, language);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_string_to_title__4__4__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public object parse_structured_text(long parser_type, object args, string text)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, parser_type);
            Helpers.WriteArray(Commands.CMD_DATA + 16, args);
            Helpers.WriteString(Commands.CMD_DATA + 16, text);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_parse_structured_text__2__28__4__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public bool init_ref()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_init_ref__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool reference()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_reference__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool unreference()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_unreference__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public long get_reference_count()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_get_reference_count__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void free()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_free__r0);
            Helpers.WaitForCompletion();
        }

        public void _init()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__init__r0);
            Helpers.WaitForCompletion();
        }

        public string _to_string()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__to_string__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void _notification(long what)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, what);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__notification__2__r0);
            Helpers.WaitForCompletion();
        }

        public bool _set(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__set__21__0__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _get(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__get__21__r0);
            Helpers.WaitForCompletion();
        }

        public object _get_property_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__get_property_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void _validate_property(object property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDictionary(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__validate_property__27__r0);
            Helpers.WaitForCompletion();
        }

        public bool _property_can_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__property_can_revert__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _property_get_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__property_get_revert__21__r0);
            Helpers.WaitForCompletion();
        }

        public bool _iter_init(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteArray(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__iter_init__28__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool _iter_next(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteArray(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__iter_next__28__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _iter_get(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVariant(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced__iter_get__0__r0);
            Helpers.WaitForCompletion();
        }

        public string get_class()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_get_class__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public bool is_class(string class_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, class_);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_is_class__4__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_set__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_get__21__r0);
            Helpers.WaitForCompletion();
        }

        public void set_indexed(string property_path, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, property_path);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_set_indexed__22__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get_indexed(string property_path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, property_path);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_get_indexed__22__r0);
            Helpers.WaitForCompletion();
        }

        public object get_property_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_get_property_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_method_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_get_method_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public bool property_can_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_property_can_revert__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void property_get_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_property_get_revert__21__r0);
            Helpers.WaitForCompletion();
        }

        public void notification(long what, bool reversed)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, what);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, reversed ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_notification__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public string to_string()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_to_string__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public ulong get_instance_id()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_get_instance_id__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_script(object script)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVariant(Commands.CMD_DATA + 8, script);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_set_script__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get_script()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_get_script__r0);
            Helpers.WaitForCompletion();
        }

        public void set_meta(string name, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_set_meta__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void remove_meta(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_remove_meta__21__r0);
            Helpers.WaitForCompletion();
        }

        public void get_meta(string name, object default_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, default_);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_get_meta__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_meta(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_has_meta__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public object get_meta_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_get_meta_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void add_user_signal(string signal, object arguments)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, signal);
            Helpers.WriteArray(Commands.CMD_DATA + 1036, arguments);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_add_user_signal__4__28__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_user_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_has_user_signal__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void remove_user_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_remove_user_signal__21__r0);
            Helpers.WaitForCompletion();
        }

        public long emit_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_emit_signal__21__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void call(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_call__21__r0);
            Helpers.WaitForCompletion();
        }

        public void call_deferred(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_call_deferred__21__r0);
            Helpers.WaitForCompletion();
        }

        public void set_deferred(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_set_deferred__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void callv(string method, object arg_array)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.WriteArray(Commands.CMD_DATA + 1036, arg_array);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_callv__21__28__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_method(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_has_method__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public long get_method_argument_count(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_get_method_argument_count__21__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool has_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_has_signal__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public object get_signal_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_get_signal_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_signal_connection_list(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_get_signal_connection_list__21__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_incoming_connections()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_get_incoming_connections__r28);
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
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_connect__21__25__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void disconnect(string signal, object callable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.WriteCallable(Commands.CMD_DATA + 1036, callable);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_disconnect__21__25__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_connected(string signal, object callable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.WriteCallable(Commands.CMD_DATA + 1036, callable);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_is_connected__21__25__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool has_connections(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_has_connections__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_block_signals(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_set_block_signals__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_blocking_signals()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_is_blocking_signals__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void notify_property_list_changed()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_notify_property_list_changed__r0);
            Helpers.WaitForCompletion();
        }

        public void set_message_translation(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_set_message_translation__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool can_translate_messages()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_can_translate_messages__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public string tr(string message, string context)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, message);
            Helpers.WriteStringName(Commands.CMD_DATA + 1036, context);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_tr__21__21__r4);
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
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_tr_n__21__21__2__21__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public string get_translation_domain()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_get_translation_domain__r21);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadStringName(Commands.CMD_DATA);
            return result;
        }

        public void set_translation_domain(string domain)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, domain);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_set_translation_domain__21__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_queued_for_deletion()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_is_queued_for_deletion__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void cancel_free()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_TextServerAdvanced_cancel_free__r0);
            Helpers.WaitForCompletion();
        }

    }
}
