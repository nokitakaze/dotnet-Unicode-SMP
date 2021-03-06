namespace UnicodeSMP
{
    public static partial class UnicodeRanges
    {
        #region Basic Multilingual Plane

        public static UnicodeRangeExtended BasicLatin =>
            BasicLatin_Ref ?? CreateRange(ref BasicLatin_Ref, 0x00_0000, 0x00_007f);

        private static UnicodeRangeExtended? BasicLatin_Ref;

        public static UnicodeRangeExtended Latin_1Supplement =>
            Latin_1Supplement_Ref ?? CreateRange(ref Latin_1Supplement_Ref, 0x00_0080, 0x00_00ff);

        private static UnicodeRangeExtended? Latin_1Supplement_Ref;

        public static UnicodeRangeExtended LatinExtended_a =>
            LatinExtended_a_Ref ?? CreateRange(ref LatinExtended_a_Ref, 0x00_0100, 0x00_017f);

        private static UnicodeRangeExtended? LatinExtended_a_Ref;

        public static UnicodeRangeExtended LatinExtended_b =>
            LatinExtended_b_Ref ?? CreateRange(ref LatinExtended_b_Ref, 0x00_0180, 0x00_024f);

        private static UnicodeRangeExtended? LatinExtended_b_Ref;

        public static UnicodeRangeExtended IpaExtensions =>
            IpaExtensions_Ref ?? CreateRange(ref IpaExtensions_Ref, 0x00_0250, 0x00_02af);

        private static UnicodeRangeExtended? IpaExtensions_Ref;

        public static UnicodeRangeExtended SpacingModifierLetters =>
            SpacingModifierLetters_Ref ?? CreateRange(ref SpacingModifierLetters_Ref, 0x00_02b0, 0x00_02ff);

        private static UnicodeRangeExtended? SpacingModifierLetters_Ref;

        public static UnicodeRangeExtended CombiningDiacriticalMarks =>
            CombiningDiacriticalMarks_Ref ?? CreateRange(ref CombiningDiacriticalMarks_Ref, 0x00_0300, 0x00_036f);

        private static UnicodeRangeExtended? CombiningDiacriticalMarks_Ref;

        public static UnicodeRangeExtended GreekAndCoptic =>
            GreekAndCoptic_Ref ?? CreateRange(ref GreekAndCoptic_Ref, 0x00_0370, 0x00_03ff);

        private static UnicodeRangeExtended? GreekAndCoptic_Ref;

        public static UnicodeRangeExtended Cyrillic =>
            Cyrillic_Ref ?? CreateRange(ref Cyrillic_Ref, 0x00_0400, 0x00_04ff);

        private static UnicodeRangeExtended? Cyrillic_Ref;

        public static UnicodeRangeExtended CyrillicSupplement =>
            CyrillicSupplement_Ref ?? CreateRange(ref CyrillicSupplement_Ref, 0x00_0500, 0x00_052f);

        private static UnicodeRangeExtended? CyrillicSupplement_Ref;

        public static UnicodeRangeExtended Armenian =>
            Armenian_Ref ?? CreateRange(ref Armenian_Ref, 0x00_0530, 0x00_058f);

        private static UnicodeRangeExtended? Armenian_Ref;

        public static UnicodeRangeExtended Hebrew =>
            Hebrew_Ref ?? CreateRange(ref Hebrew_Ref, 0x00_0590, 0x00_05ff);

        private static UnicodeRangeExtended? Hebrew_Ref;

        public static UnicodeRangeExtended Arabic =>
            Arabic_Ref ?? CreateRange(ref Arabic_Ref, 0x00_0600, 0x00_06ff);

        private static UnicodeRangeExtended? Arabic_Ref;

        public static UnicodeRangeExtended Syriac =>
            Syriac_Ref ?? CreateRange(ref Syriac_Ref, 0x00_0700, 0x00_074f);

        private static UnicodeRangeExtended? Syriac_Ref;

        public static UnicodeRangeExtended ArabicSupplement =>
            ArabicSupplement_Ref ?? CreateRange(ref ArabicSupplement_Ref, 0x00_0750, 0x00_077f);

        private static UnicodeRangeExtended? ArabicSupplement_Ref;

        public static UnicodeRangeExtended Thaana =>
            Thaana_Ref ?? CreateRange(ref Thaana_Ref, 0x00_0780, 0x00_07bf);

        private static UnicodeRangeExtended? Thaana_Ref;

        public static UnicodeRangeExtended Nko =>
            Nko_Ref ?? CreateRange(ref Nko_Ref, 0x00_07c0, 0x00_07ff);

        private static UnicodeRangeExtended? Nko_Ref;

        public static UnicodeRangeExtended Samaritan =>
            Samaritan_Ref ?? CreateRange(ref Samaritan_Ref, 0x00_0800, 0x00_083f);

        private static UnicodeRangeExtended? Samaritan_Ref;

        public static UnicodeRangeExtended Mandaic =>
            Mandaic_Ref ?? CreateRange(ref Mandaic_Ref, 0x00_0840, 0x00_085f);

        private static UnicodeRangeExtended? Mandaic_Ref;

        public static UnicodeRangeExtended SyriacSupplement =>
            SyriacSupplement_Ref ?? CreateRange(ref SyriacSupplement_Ref, 0x00_0860, 0x00_086f);

        private static UnicodeRangeExtended? SyriacSupplement_Ref;

        public static UnicodeRangeExtended ArabicExtended_a =>
            ArabicExtended_a_Ref ?? CreateRange(ref ArabicExtended_a_Ref, 0x00_08a0, 0x00_08ff);

        private static UnicodeRangeExtended? ArabicExtended_a_Ref;

        public static UnicodeRangeExtended Devanagari =>
            Devanagari_Ref ?? CreateRange(ref Devanagari_Ref, 0x00_0900, 0x00_097f);

        private static UnicodeRangeExtended? Devanagari_Ref;

        public static UnicodeRangeExtended Bengali =>
            Bengali_Ref ?? CreateRange(ref Bengali_Ref, 0x00_0980, 0x00_09ff);

        private static UnicodeRangeExtended? Bengali_Ref;

        public static UnicodeRangeExtended Gurmukhi =>
            Gurmukhi_Ref ?? CreateRange(ref Gurmukhi_Ref, 0x00_0a00, 0x00_0a7f);

        private static UnicodeRangeExtended? Gurmukhi_Ref;

        public static UnicodeRangeExtended Gujarati =>
            Gujarati_Ref ?? CreateRange(ref Gujarati_Ref, 0x00_0a80, 0x00_0aff);

        private static UnicodeRangeExtended? Gujarati_Ref;

        public static UnicodeRangeExtended Oriya =>
            Oriya_Ref ?? CreateRange(ref Oriya_Ref, 0x00_0b00, 0x00_0b7f);

        private static UnicodeRangeExtended? Oriya_Ref;

        public static UnicodeRangeExtended Tamil =>
            Tamil_Ref ?? CreateRange(ref Tamil_Ref, 0x00_0b80, 0x00_0bff);

        private static UnicodeRangeExtended? Tamil_Ref;

        public static UnicodeRangeExtended Telugu =>
            Telugu_Ref ?? CreateRange(ref Telugu_Ref, 0x00_0c00, 0x00_0c7f);

        private static UnicodeRangeExtended? Telugu_Ref;

        public static UnicodeRangeExtended Kannada =>
            Kannada_Ref ?? CreateRange(ref Kannada_Ref, 0x00_0c80, 0x00_0cff);

        private static UnicodeRangeExtended? Kannada_Ref;

        public static UnicodeRangeExtended Malayalam =>
            Malayalam_Ref ?? CreateRange(ref Malayalam_Ref, 0x00_0d00, 0x00_0d7f);

        private static UnicodeRangeExtended? Malayalam_Ref;

        public static UnicodeRangeExtended Sinhala =>
            Sinhala_Ref ?? CreateRange(ref Sinhala_Ref, 0x00_0d80, 0x00_0dff);

        private static UnicodeRangeExtended? Sinhala_Ref;

        public static UnicodeRangeExtended Thai =>
            Thai_Ref ?? CreateRange(ref Thai_Ref, 0x00_0e00, 0x00_0e7f);

        private static UnicodeRangeExtended? Thai_Ref;

        public static UnicodeRangeExtended Lao =>
            Lao_Ref ?? CreateRange(ref Lao_Ref, 0x00_0e80, 0x00_0eff);

        private static UnicodeRangeExtended? Lao_Ref;

        public static UnicodeRangeExtended Tibetan =>
            Tibetan_Ref ?? CreateRange(ref Tibetan_Ref, 0x00_0f00, 0x00_0fff);

        private static UnicodeRangeExtended? Tibetan_Ref;

        public static UnicodeRangeExtended Myanmar =>
            Myanmar_Ref ?? CreateRange(ref Myanmar_Ref, 0x00_1000, 0x00_109f);

        private static UnicodeRangeExtended? Myanmar_Ref;

        public static UnicodeRangeExtended Georgian =>
            Georgian_Ref ?? CreateRange(ref Georgian_Ref, 0x00_10a0, 0x00_10ff);

        private static UnicodeRangeExtended? Georgian_Ref;

        public static UnicodeRangeExtended HangulJamo =>
            HangulJamo_Ref ?? CreateRange(ref HangulJamo_Ref, 0x00_1100, 0x00_11ff);

        private static UnicodeRangeExtended? HangulJamo_Ref;

        public static UnicodeRangeExtended Ethiopic =>
            Ethiopic_Ref ?? CreateRange(ref Ethiopic_Ref, 0x00_1200, 0x00_137f);

        private static UnicodeRangeExtended? Ethiopic_Ref;

        public static UnicodeRangeExtended EthiopicSupplement =>
            EthiopicSupplement_Ref ?? CreateRange(ref EthiopicSupplement_Ref, 0x00_1380, 0x00_139f);

        private static UnicodeRangeExtended? EthiopicSupplement_Ref;

        public static UnicodeRangeExtended Cherokee =>
            Cherokee_Ref ?? CreateRange(ref Cherokee_Ref, 0x00_13a0, 0x00_13ff);

        private static UnicodeRangeExtended? Cherokee_Ref;

        public static UnicodeRangeExtended UnifiedCanadianAboriginalSyllabics =>
            UnifiedCanadianAboriginalSyllabics_Ref ?? CreateRange(ref UnifiedCanadianAboriginalSyllabics_Ref, 0x00_1400, 0x00_167f);

        private static UnicodeRangeExtended? UnifiedCanadianAboriginalSyllabics_Ref;

        public static UnicodeRangeExtended Ogham =>
            Ogham_Ref ?? CreateRange(ref Ogham_Ref, 0x00_1680, 0x00_169f);

        private static UnicodeRangeExtended? Ogham_Ref;

        public static UnicodeRangeExtended Runic =>
            Runic_Ref ?? CreateRange(ref Runic_Ref, 0x00_16a0, 0x00_16ff);

        private static UnicodeRangeExtended? Runic_Ref;

        public static UnicodeRangeExtended Tagalog =>
            Tagalog_Ref ?? CreateRange(ref Tagalog_Ref, 0x00_1700, 0x00_171f);

        private static UnicodeRangeExtended? Tagalog_Ref;

        public static UnicodeRangeExtended Hanunoo =>
            Hanunoo_Ref ?? CreateRange(ref Hanunoo_Ref, 0x00_1720, 0x00_173f);

        private static UnicodeRangeExtended? Hanunoo_Ref;

        public static UnicodeRangeExtended Buhid =>
            Buhid_Ref ?? CreateRange(ref Buhid_Ref, 0x00_1740, 0x00_175f);

        private static UnicodeRangeExtended? Buhid_Ref;

        public static UnicodeRangeExtended Tagbanwa =>
            Tagbanwa_Ref ?? CreateRange(ref Tagbanwa_Ref, 0x00_1760, 0x00_177f);

        private static UnicodeRangeExtended? Tagbanwa_Ref;

        public static UnicodeRangeExtended Khmer =>
            Khmer_Ref ?? CreateRange(ref Khmer_Ref, 0x00_1780, 0x00_17ff);

        private static UnicodeRangeExtended? Khmer_Ref;

        public static UnicodeRangeExtended Mongolian =>
            Mongolian_Ref ?? CreateRange(ref Mongolian_Ref, 0x00_1800, 0x00_18af);

        private static UnicodeRangeExtended? Mongolian_Ref;

        public static UnicodeRangeExtended UnifiedCanadianAboriginalSyllabicsExtended =>
            UnifiedCanadianAboriginalSyllabicsExtended_Ref ?? CreateRange(ref UnifiedCanadianAboriginalSyllabicsExtended_Ref, 0x00_18b0, 0x00_18ff);

        private static UnicodeRangeExtended? UnifiedCanadianAboriginalSyllabicsExtended_Ref;

        public static UnicodeRangeExtended Limbu =>
            Limbu_Ref ?? CreateRange(ref Limbu_Ref, 0x00_1900, 0x00_194f);

        private static UnicodeRangeExtended? Limbu_Ref;

        public static UnicodeRangeExtended TaiLe =>
            TaiLe_Ref ?? CreateRange(ref TaiLe_Ref, 0x00_1950, 0x00_197f);

        private static UnicodeRangeExtended? TaiLe_Ref;

        public static UnicodeRangeExtended NewTaiLue =>
            NewTaiLue_Ref ?? CreateRange(ref NewTaiLue_Ref, 0x00_1980, 0x00_19df);

        private static UnicodeRangeExtended? NewTaiLue_Ref;

        public static UnicodeRangeExtended KhmerSymbols =>
            KhmerSymbols_Ref ?? CreateRange(ref KhmerSymbols_Ref, 0x00_19e0, 0x00_19ff);

        private static UnicodeRangeExtended? KhmerSymbols_Ref;

        public static UnicodeRangeExtended Buginese =>
            Buginese_Ref ?? CreateRange(ref Buginese_Ref, 0x00_1a00, 0x00_1a1f);

        private static UnicodeRangeExtended? Buginese_Ref;

        public static UnicodeRangeExtended TaiTham =>
            TaiTham_Ref ?? CreateRange(ref TaiTham_Ref, 0x00_1a20, 0x00_1aaf);

        private static UnicodeRangeExtended? TaiTham_Ref;

        public static UnicodeRangeExtended CombiningDiacriticalMarksExtended =>
            CombiningDiacriticalMarksExtended_Ref ?? CreateRange(ref CombiningDiacriticalMarksExtended_Ref, 0x00_1ab0, 0x00_1aff);

        private static UnicodeRangeExtended? CombiningDiacriticalMarksExtended_Ref;

        public static UnicodeRangeExtended Balinese =>
            Balinese_Ref ?? CreateRange(ref Balinese_Ref, 0x00_1b00, 0x00_1b7f);

        private static UnicodeRangeExtended? Balinese_Ref;

        public static UnicodeRangeExtended Sundanese =>
            Sundanese_Ref ?? CreateRange(ref Sundanese_Ref, 0x00_1b80, 0x00_1bbf);

        private static UnicodeRangeExtended? Sundanese_Ref;

        public static UnicodeRangeExtended Batak =>
            Batak_Ref ?? CreateRange(ref Batak_Ref, 0x00_1bc0, 0x00_1bff);

        private static UnicodeRangeExtended? Batak_Ref;

        public static UnicodeRangeExtended Lepcha =>
            Lepcha_Ref ?? CreateRange(ref Lepcha_Ref, 0x00_1c00, 0x00_1c4f);

        private static UnicodeRangeExtended? Lepcha_Ref;

        public static UnicodeRangeExtended OlChiki =>
            OlChiki_Ref ?? CreateRange(ref OlChiki_Ref, 0x00_1c50, 0x00_1c7f);

        private static UnicodeRangeExtended? OlChiki_Ref;

        public static UnicodeRangeExtended CyrillicExtended_c =>
            CyrillicExtended_c_Ref ?? CreateRange(ref CyrillicExtended_c_Ref, 0x00_1c80, 0x00_1c8f);

        private static UnicodeRangeExtended? CyrillicExtended_c_Ref;

        public static UnicodeRangeExtended GeorgianExtended =>
            GeorgianExtended_Ref ?? CreateRange(ref GeorgianExtended_Ref, 0x00_1c90, 0x00_1cbf);

        private static UnicodeRangeExtended? GeorgianExtended_Ref;

        public static UnicodeRangeExtended SundaneseSupplement =>
            SundaneseSupplement_Ref ?? CreateRange(ref SundaneseSupplement_Ref, 0x00_1cc0, 0x00_1ccf);

        private static UnicodeRangeExtended? SundaneseSupplement_Ref;

        public static UnicodeRangeExtended VedicExtensions =>
            VedicExtensions_Ref ?? CreateRange(ref VedicExtensions_Ref, 0x00_1cd0, 0x00_1cff);

        private static UnicodeRangeExtended? VedicExtensions_Ref;

        public static UnicodeRangeExtended PhoneticExtensions =>
            PhoneticExtensions_Ref ?? CreateRange(ref PhoneticExtensions_Ref, 0x00_1d00, 0x00_1d7f);

        private static UnicodeRangeExtended? PhoneticExtensions_Ref;

        public static UnicodeRangeExtended PhoneticExtensionsSupplement =>
            PhoneticExtensionsSupplement_Ref ?? CreateRange(ref PhoneticExtensionsSupplement_Ref, 0x00_1d80, 0x00_1dbf);

        private static UnicodeRangeExtended? PhoneticExtensionsSupplement_Ref;

        public static UnicodeRangeExtended CombiningDiacriticalMarksSupplement =>
            CombiningDiacriticalMarksSupplement_Ref ?? CreateRange(ref CombiningDiacriticalMarksSupplement_Ref, 0x00_1dc0, 0x00_1dff);

        private static UnicodeRangeExtended? CombiningDiacriticalMarksSupplement_Ref;

        public static UnicodeRangeExtended LatinExtendedAdditional =>
            LatinExtendedAdditional_Ref ?? CreateRange(ref LatinExtendedAdditional_Ref, 0x00_1e00, 0x00_1eff);

        private static UnicodeRangeExtended? LatinExtendedAdditional_Ref;

        public static UnicodeRangeExtended GreekExtended =>
            GreekExtended_Ref ?? CreateRange(ref GreekExtended_Ref, 0x00_1f00, 0x00_1fff);

        private static UnicodeRangeExtended? GreekExtended_Ref;

        public static UnicodeRangeExtended GeneralPunctuation =>
            GeneralPunctuation_Ref ?? CreateRange(ref GeneralPunctuation_Ref, 0x00_2000, 0x00_206f);

        private static UnicodeRangeExtended? GeneralPunctuation_Ref;

        public static UnicodeRangeExtended SuperscriptsAndSubscripts =>
            SuperscriptsAndSubscripts_Ref ?? CreateRange(ref SuperscriptsAndSubscripts_Ref, 0x00_2070, 0x00_209f);

        private static UnicodeRangeExtended? SuperscriptsAndSubscripts_Ref;

        public static UnicodeRangeExtended CurrencySymbols =>
            CurrencySymbols_Ref ?? CreateRange(ref CurrencySymbols_Ref, 0x00_20a0, 0x00_20cf);

        private static UnicodeRangeExtended? CurrencySymbols_Ref;

        public static UnicodeRangeExtended CombiningDiacriticalMarksForSymbols =>
            CombiningDiacriticalMarksForSymbols_Ref ?? CreateRange(ref CombiningDiacriticalMarksForSymbols_Ref, 0x00_20d0, 0x00_20ff);

        private static UnicodeRangeExtended? CombiningDiacriticalMarksForSymbols_Ref;

        public static UnicodeRangeExtended LetterlikeSymbols =>
            LetterlikeSymbols_Ref ?? CreateRange(ref LetterlikeSymbols_Ref, 0x00_2100, 0x00_214f);

        private static UnicodeRangeExtended? LetterlikeSymbols_Ref;

        public static UnicodeRangeExtended NumberForms =>
            NumberForms_Ref ?? CreateRange(ref NumberForms_Ref, 0x00_2150, 0x00_218f);

        private static UnicodeRangeExtended? NumberForms_Ref;

        public static UnicodeRangeExtended Arrows =>
            Arrows_Ref ?? CreateRange(ref Arrows_Ref, 0x00_2190, 0x00_21ff);

        private static UnicodeRangeExtended? Arrows_Ref;

        public static UnicodeRangeExtended MathematicalOperators =>
            MathematicalOperators_Ref ?? CreateRange(ref MathematicalOperators_Ref, 0x00_2200, 0x00_22ff);

        private static UnicodeRangeExtended? MathematicalOperators_Ref;

        public static UnicodeRangeExtended MiscellaneousTechnical =>
            MiscellaneousTechnical_Ref ?? CreateRange(ref MiscellaneousTechnical_Ref, 0x00_2300, 0x00_23ff);

        private static UnicodeRangeExtended? MiscellaneousTechnical_Ref;

        public static UnicodeRangeExtended ControlPictures =>
            ControlPictures_Ref ?? CreateRange(ref ControlPictures_Ref, 0x00_2400, 0x00_243f);

        private static UnicodeRangeExtended? ControlPictures_Ref;

        public static UnicodeRangeExtended OpticalCharacterRecognition =>
            OpticalCharacterRecognition_Ref ?? CreateRange(ref OpticalCharacterRecognition_Ref, 0x00_2440, 0x00_245f);

        private static UnicodeRangeExtended? OpticalCharacterRecognition_Ref;

        public static UnicodeRangeExtended EnclosedAlphanumerics =>
            EnclosedAlphanumerics_Ref ?? CreateRange(ref EnclosedAlphanumerics_Ref, 0x00_2460, 0x00_24ff);

        private static UnicodeRangeExtended? EnclosedAlphanumerics_Ref;

        public static UnicodeRangeExtended BoxDrawing =>
            BoxDrawing_Ref ?? CreateRange(ref BoxDrawing_Ref, 0x00_2500, 0x00_257f);

        private static UnicodeRangeExtended? BoxDrawing_Ref;

        public static UnicodeRangeExtended BlockElements =>
            BlockElements_Ref ?? CreateRange(ref BlockElements_Ref, 0x00_2580, 0x00_259f);

        private static UnicodeRangeExtended? BlockElements_Ref;

        public static UnicodeRangeExtended GeometricShapes =>
            GeometricShapes_Ref ?? CreateRange(ref GeometricShapes_Ref, 0x00_25a0, 0x00_25ff);

        private static UnicodeRangeExtended? GeometricShapes_Ref;

        public static UnicodeRangeExtended MiscellaneousSymbols =>
            MiscellaneousSymbols_Ref ?? CreateRange(ref MiscellaneousSymbols_Ref, 0x00_2600, 0x00_26ff);

        private static UnicodeRangeExtended? MiscellaneousSymbols_Ref;

        public static UnicodeRangeExtended Dingbats =>
            Dingbats_Ref ?? CreateRange(ref Dingbats_Ref, 0x00_2700, 0x00_27bf);

        private static UnicodeRangeExtended? Dingbats_Ref;

        public static UnicodeRangeExtended MiscellaneousMathematicalSymbols_a =>
            MiscellaneousMathematicalSymbols_a_Ref ?? CreateRange(ref MiscellaneousMathematicalSymbols_a_Ref, 0x00_27c0, 0x00_27ef);

        private static UnicodeRangeExtended? MiscellaneousMathematicalSymbols_a_Ref;

        public static UnicodeRangeExtended SupplementalArrows_a =>
            SupplementalArrows_a_Ref ?? CreateRange(ref SupplementalArrows_a_Ref, 0x00_27f0, 0x00_27ff);

        private static UnicodeRangeExtended? SupplementalArrows_a_Ref;

        public static UnicodeRangeExtended BraillePatterns =>
            BraillePatterns_Ref ?? CreateRange(ref BraillePatterns_Ref, 0x00_2800, 0x00_28ff);

        private static UnicodeRangeExtended? BraillePatterns_Ref;

        public static UnicodeRangeExtended SupplementalArrows_b =>
            SupplementalArrows_b_Ref ?? CreateRange(ref SupplementalArrows_b_Ref, 0x00_2900, 0x00_297f);

        private static UnicodeRangeExtended? SupplementalArrows_b_Ref;

        public static UnicodeRangeExtended MiscellaneousMathematicalSymbols_b =>
            MiscellaneousMathematicalSymbols_b_Ref ?? CreateRange(ref MiscellaneousMathematicalSymbols_b_Ref, 0x00_2980, 0x00_29ff);

        private static UnicodeRangeExtended? MiscellaneousMathematicalSymbols_b_Ref;

        public static UnicodeRangeExtended SupplementalMathematicalOperators =>
            SupplementalMathematicalOperators_Ref ?? CreateRange(ref SupplementalMathematicalOperators_Ref, 0x00_2a00, 0x00_2aff);

        private static UnicodeRangeExtended? SupplementalMathematicalOperators_Ref;

        public static UnicodeRangeExtended MiscellaneousSymbolsAndArrows =>
            MiscellaneousSymbolsAndArrows_Ref ?? CreateRange(ref MiscellaneousSymbolsAndArrows_Ref, 0x00_2b00, 0x00_2bff);

        private static UnicodeRangeExtended? MiscellaneousSymbolsAndArrows_Ref;

        public static UnicodeRangeExtended Glagolitic =>
            Glagolitic_Ref ?? CreateRange(ref Glagolitic_Ref, 0x00_2c00, 0x00_2c5f);

        private static UnicodeRangeExtended? Glagolitic_Ref;

        public static UnicodeRangeExtended LatinExtended_c =>
            LatinExtended_c_Ref ?? CreateRange(ref LatinExtended_c_Ref, 0x00_2c60, 0x00_2c7f);

        private static UnicodeRangeExtended? LatinExtended_c_Ref;

        public static UnicodeRangeExtended Coptic =>
            Coptic_Ref ?? CreateRange(ref Coptic_Ref, 0x00_2c80, 0x00_2cff);

        private static UnicodeRangeExtended? Coptic_Ref;

        public static UnicodeRangeExtended GeorgianSupplement =>
            GeorgianSupplement_Ref ?? CreateRange(ref GeorgianSupplement_Ref, 0x00_2d00, 0x00_2d2f);

        private static UnicodeRangeExtended? GeorgianSupplement_Ref;

        public static UnicodeRangeExtended Tifinagh =>
            Tifinagh_Ref ?? CreateRange(ref Tifinagh_Ref, 0x00_2d30, 0x00_2d7f);

        private static UnicodeRangeExtended? Tifinagh_Ref;

        public static UnicodeRangeExtended EthiopicExtended =>
            EthiopicExtended_Ref ?? CreateRange(ref EthiopicExtended_Ref, 0x00_2d80, 0x00_2ddf);

        private static UnicodeRangeExtended? EthiopicExtended_Ref;

        public static UnicodeRangeExtended CyrillicExtended_a =>
            CyrillicExtended_a_Ref ?? CreateRange(ref CyrillicExtended_a_Ref, 0x00_2de0, 0x00_2dff);

        private static UnicodeRangeExtended? CyrillicExtended_a_Ref;

        public static UnicodeRangeExtended SupplementalPunctuation =>
            SupplementalPunctuation_Ref ?? CreateRange(ref SupplementalPunctuation_Ref, 0x00_2e00, 0x00_2e7f);

        private static UnicodeRangeExtended? SupplementalPunctuation_Ref;

        public static UnicodeRangeExtended CjkRadicalsSupplement =>
            CjkRadicalsSupplement_Ref ?? CreateRange(ref CjkRadicalsSupplement_Ref, 0x00_2e80, 0x00_2eff);

        private static UnicodeRangeExtended? CjkRadicalsSupplement_Ref;

        public static UnicodeRangeExtended KangxiRadicals =>
            KangxiRadicals_Ref ?? CreateRange(ref KangxiRadicals_Ref, 0x00_2f00, 0x00_2fdf);

        private static UnicodeRangeExtended? KangxiRadicals_Ref;

        public static UnicodeRangeExtended IdeographicDescriptionCharacters =>
            IdeographicDescriptionCharacters_Ref ?? CreateRange(ref IdeographicDescriptionCharacters_Ref, 0x00_2ff0, 0x00_2fff);

        private static UnicodeRangeExtended? IdeographicDescriptionCharacters_Ref;

        public static UnicodeRangeExtended CjkSymbolsAndPunctuation =>
            CjkSymbolsAndPunctuation_Ref ?? CreateRange(ref CjkSymbolsAndPunctuation_Ref, 0x00_3000, 0x00_303f);

        private static UnicodeRangeExtended? CjkSymbolsAndPunctuation_Ref;

        public static UnicodeRangeExtended Hiragana =>
            Hiragana_Ref ?? CreateRange(ref Hiragana_Ref, 0x00_3040, 0x00_309f);

        private static UnicodeRangeExtended? Hiragana_Ref;

        public static UnicodeRangeExtended Katakana =>
            Katakana_Ref ?? CreateRange(ref Katakana_Ref, 0x00_30a0, 0x00_30ff);

        private static UnicodeRangeExtended? Katakana_Ref;

        public static UnicodeRangeExtended Bopomofo =>
            Bopomofo_Ref ?? CreateRange(ref Bopomofo_Ref, 0x00_3100, 0x00_312f);

        private static UnicodeRangeExtended? Bopomofo_Ref;

        public static UnicodeRangeExtended HangulCompatibilityJamo =>
            HangulCompatibilityJamo_Ref ?? CreateRange(ref HangulCompatibilityJamo_Ref, 0x00_3130, 0x00_318f);

        private static UnicodeRangeExtended? HangulCompatibilityJamo_Ref;

        public static UnicodeRangeExtended Kanbun =>
            Kanbun_Ref ?? CreateRange(ref Kanbun_Ref, 0x00_3190, 0x00_319f);

        private static UnicodeRangeExtended? Kanbun_Ref;

        public static UnicodeRangeExtended BopomofoExtended =>
            BopomofoExtended_Ref ?? CreateRange(ref BopomofoExtended_Ref, 0x00_31a0, 0x00_31bf);

        private static UnicodeRangeExtended? BopomofoExtended_Ref;

        public static UnicodeRangeExtended CjkStrokes =>
            CjkStrokes_Ref ?? CreateRange(ref CjkStrokes_Ref, 0x00_31c0, 0x00_31ef);

        private static UnicodeRangeExtended? CjkStrokes_Ref;

        public static UnicodeRangeExtended KatakanaPhoneticExtensions =>
            KatakanaPhoneticExtensions_Ref ?? CreateRange(ref KatakanaPhoneticExtensions_Ref, 0x00_31f0, 0x00_31ff);

        private static UnicodeRangeExtended? KatakanaPhoneticExtensions_Ref;

        public static UnicodeRangeExtended EnclosedCjkLettersAndMonths =>
            EnclosedCjkLettersAndMonths_Ref ?? CreateRange(ref EnclosedCjkLettersAndMonths_Ref, 0x00_3200, 0x00_32ff);

        private static UnicodeRangeExtended? EnclosedCjkLettersAndMonths_Ref;

        public static UnicodeRangeExtended CjkCompatibility =>
            CjkCompatibility_Ref ?? CreateRange(ref CjkCompatibility_Ref, 0x00_3300, 0x00_33ff);

        private static UnicodeRangeExtended? CjkCompatibility_Ref;

        public static UnicodeRangeExtended CjkUnifiedIdeographsExtensionA =>
            CjkUnifiedIdeographsExtensionA_Ref ?? CreateRange(ref CjkUnifiedIdeographsExtensionA_Ref, 0x00_3400, 0x00_4dbf);

        private static UnicodeRangeExtended? CjkUnifiedIdeographsExtensionA_Ref;

        public static UnicodeRangeExtended YijingHexagramSymbols =>
            YijingHexagramSymbols_Ref ?? CreateRange(ref YijingHexagramSymbols_Ref, 0x00_4dc0, 0x00_4dff);

        private static UnicodeRangeExtended? YijingHexagramSymbols_Ref;

        public static UnicodeRangeExtended CjkUnifiedIdeographs =>
            CjkUnifiedIdeographs_Ref ?? CreateRange(ref CjkUnifiedIdeographs_Ref, 0x00_4e00, 0x00_9fff);

        private static UnicodeRangeExtended? CjkUnifiedIdeographs_Ref;

        public static UnicodeRangeExtended YiSyllables =>
            YiSyllables_Ref ?? CreateRange(ref YiSyllables_Ref, 0x00_a000, 0x00_a48f);

        private static UnicodeRangeExtended? YiSyllables_Ref;

        public static UnicodeRangeExtended YiRadicals =>
            YiRadicals_Ref ?? CreateRange(ref YiRadicals_Ref, 0x00_a490, 0x00_a4cf);

        private static UnicodeRangeExtended? YiRadicals_Ref;

        public static UnicodeRangeExtended Lisu =>
            Lisu_Ref ?? CreateRange(ref Lisu_Ref, 0x00_a4d0, 0x00_a4ff);

        private static UnicodeRangeExtended? Lisu_Ref;

        public static UnicodeRangeExtended Vai =>
            Vai_Ref ?? CreateRange(ref Vai_Ref, 0x00_a500, 0x00_a63f);

        private static UnicodeRangeExtended? Vai_Ref;

        public static UnicodeRangeExtended CyrillicExtended_b =>
            CyrillicExtended_b_Ref ?? CreateRange(ref CyrillicExtended_b_Ref, 0x00_a640, 0x00_a69f);

        private static UnicodeRangeExtended? CyrillicExtended_b_Ref;

        public static UnicodeRangeExtended Bamum =>
            Bamum_Ref ?? CreateRange(ref Bamum_Ref, 0x00_a6a0, 0x00_a6ff);

        private static UnicodeRangeExtended? Bamum_Ref;

        public static UnicodeRangeExtended ModifierToneLetters =>
            ModifierToneLetters_Ref ?? CreateRange(ref ModifierToneLetters_Ref, 0x00_a700, 0x00_a71f);

        private static UnicodeRangeExtended? ModifierToneLetters_Ref;

        public static UnicodeRangeExtended LatinExtended_d =>
            LatinExtended_d_Ref ?? CreateRange(ref LatinExtended_d_Ref, 0x00_a720, 0x00_a7ff);

        private static UnicodeRangeExtended? LatinExtended_d_Ref;

        public static UnicodeRangeExtended SylotiNagri =>
            SylotiNagri_Ref ?? CreateRange(ref SylotiNagri_Ref, 0x00_a800, 0x00_a82f);

        private static UnicodeRangeExtended? SylotiNagri_Ref;

        public static UnicodeRangeExtended CommonIndicNumberForms =>
            CommonIndicNumberForms_Ref ?? CreateRange(ref CommonIndicNumberForms_Ref, 0x00_a830, 0x00_a83f);

        private static UnicodeRangeExtended? CommonIndicNumberForms_Ref;

        public static UnicodeRangeExtended Phags_pa =>
            Phags_pa_Ref ?? CreateRange(ref Phags_pa_Ref, 0x00_a840, 0x00_a87f);

        private static UnicodeRangeExtended? Phags_pa_Ref;

        public static UnicodeRangeExtended Saurashtra =>
            Saurashtra_Ref ?? CreateRange(ref Saurashtra_Ref, 0x00_a880, 0x00_a8df);

        private static UnicodeRangeExtended? Saurashtra_Ref;

        public static UnicodeRangeExtended DevanagariExtended =>
            DevanagariExtended_Ref ?? CreateRange(ref DevanagariExtended_Ref, 0x00_a8e0, 0x00_a8ff);

        private static UnicodeRangeExtended? DevanagariExtended_Ref;

        public static UnicodeRangeExtended KayahLi =>
            KayahLi_Ref ?? CreateRange(ref KayahLi_Ref, 0x00_a900, 0x00_a92f);

        private static UnicodeRangeExtended? KayahLi_Ref;

        public static UnicodeRangeExtended Rejang =>
            Rejang_Ref ?? CreateRange(ref Rejang_Ref, 0x00_a930, 0x00_a95f);

        private static UnicodeRangeExtended? Rejang_Ref;

        public static UnicodeRangeExtended HangulJamoExtended_a =>
            HangulJamoExtended_a_Ref ?? CreateRange(ref HangulJamoExtended_a_Ref, 0x00_a960, 0x00_a97f);

        private static UnicodeRangeExtended? HangulJamoExtended_a_Ref;

        public static UnicodeRangeExtended Javanese =>
            Javanese_Ref ?? CreateRange(ref Javanese_Ref, 0x00_a980, 0x00_a9df);

        private static UnicodeRangeExtended? Javanese_Ref;

        public static UnicodeRangeExtended MyanmarExtended_b =>
            MyanmarExtended_b_Ref ?? CreateRange(ref MyanmarExtended_b_Ref, 0x00_a9e0, 0x00_a9ff);

        private static UnicodeRangeExtended? MyanmarExtended_b_Ref;

        public static UnicodeRangeExtended Cham =>
            Cham_Ref ?? CreateRange(ref Cham_Ref, 0x00_aa00, 0x00_aa5f);

        private static UnicodeRangeExtended? Cham_Ref;

        public static UnicodeRangeExtended MyanmarExtended_a =>
            MyanmarExtended_a_Ref ?? CreateRange(ref MyanmarExtended_a_Ref, 0x00_aa60, 0x00_aa7f);

        private static UnicodeRangeExtended? MyanmarExtended_a_Ref;

        public static UnicodeRangeExtended TaiViet =>
            TaiViet_Ref ?? CreateRange(ref TaiViet_Ref, 0x00_aa80, 0x00_aadf);

        private static UnicodeRangeExtended? TaiViet_Ref;

        public static UnicodeRangeExtended MeeteiMayekExtensions =>
            MeeteiMayekExtensions_Ref ?? CreateRange(ref MeeteiMayekExtensions_Ref, 0x00_aae0, 0x00_aaff);

        private static UnicodeRangeExtended? MeeteiMayekExtensions_Ref;

        public static UnicodeRangeExtended EthiopicExtended_a =>
            EthiopicExtended_a_Ref ?? CreateRange(ref EthiopicExtended_a_Ref, 0x00_ab00, 0x00_ab2f);

        private static UnicodeRangeExtended? EthiopicExtended_a_Ref;

        public static UnicodeRangeExtended LatinExtended_e =>
            LatinExtended_e_Ref ?? CreateRange(ref LatinExtended_e_Ref, 0x00_ab30, 0x00_ab6f);

        private static UnicodeRangeExtended? LatinExtended_e_Ref;

        public static UnicodeRangeExtended CherokeeSupplement =>
            CherokeeSupplement_Ref ?? CreateRange(ref CherokeeSupplement_Ref, 0x00_ab70, 0x00_abbf);

        private static UnicodeRangeExtended? CherokeeSupplement_Ref;

        public static UnicodeRangeExtended MeeteiMayek =>
            MeeteiMayek_Ref ?? CreateRange(ref MeeteiMayek_Ref, 0x00_abc0, 0x00_abff);

        private static UnicodeRangeExtended? MeeteiMayek_Ref;

        public static UnicodeRangeExtended HangulSyllables =>
            HangulSyllables_Ref ?? CreateRange(ref HangulSyllables_Ref, 0x00_ac00, 0x00_d7af);

        private static UnicodeRangeExtended? HangulSyllables_Ref;

        public static UnicodeRangeExtended HangulJamoExtended_b =>
            HangulJamoExtended_b_Ref ?? CreateRange(ref HangulJamoExtended_b_Ref, 0x00_d7b0, 0x00_d7ff);

        private static UnicodeRangeExtended? HangulJamoExtended_b_Ref;

        public static UnicodeRangeExtended HighSurrogates =>
            HighSurrogates_Ref ?? CreateRange(ref HighSurrogates_Ref, 0x00_d800, 0x00_db7f);

        private static UnicodeRangeExtended? HighSurrogates_Ref;

        public static UnicodeRangeExtended HighPrivateUseSurrogates =>
            HighPrivateUseSurrogates_Ref ?? CreateRange(ref HighPrivateUseSurrogates_Ref, 0x00_db80, 0x00_dbff);

        private static UnicodeRangeExtended? HighPrivateUseSurrogates_Ref;

        public static UnicodeRangeExtended LowSurrogates =>
            LowSurrogates_Ref ?? CreateRange(ref LowSurrogates_Ref, 0x00_dc00, 0x00_dfff);

        private static UnicodeRangeExtended? LowSurrogates_Ref;

        public static UnicodeRangeExtended PrivateUseArea =>
            PrivateUseArea_Ref ?? CreateRange(ref PrivateUseArea_Ref, 0x00_e000, 0x00_f8ff);

        private static UnicodeRangeExtended? PrivateUseArea_Ref;

        public static UnicodeRangeExtended CjkCompatibilityIdeographs =>
            CjkCompatibilityIdeographs_Ref ?? CreateRange(ref CjkCompatibilityIdeographs_Ref, 0x00_f900, 0x00_faff);

        private static UnicodeRangeExtended? CjkCompatibilityIdeographs_Ref;

        public static UnicodeRangeExtended AlphabeticPresentationForms =>
            AlphabeticPresentationForms_Ref ?? CreateRange(ref AlphabeticPresentationForms_Ref, 0x00_fb00, 0x00_fb4f);

        private static UnicodeRangeExtended? AlphabeticPresentationForms_Ref;

        public static UnicodeRangeExtended ArabicPresentationForms_a =>
            ArabicPresentationForms_a_Ref ?? CreateRange(ref ArabicPresentationForms_a_Ref, 0x00_fb50, 0x00_fdff);

        private static UnicodeRangeExtended? ArabicPresentationForms_a_Ref;

        public static UnicodeRangeExtended VariationSelectors =>
            VariationSelectors_Ref ?? CreateRange(ref VariationSelectors_Ref, 0x00_fe00, 0x00_fe0f);

        private static UnicodeRangeExtended? VariationSelectors_Ref;

        public static UnicodeRangeExtended VerticalForms =>
            VerticalForms_Ref ?? CreateRange(ref VerticalForms_Ref, 0x00_fe10, 0x00_fe1f);

        private static UnicodeRangeExtended? VerticalForms_Ref;

        public static UnicodeRangeExtended CombiningHalfMarks =>
            CombiningHalfMarks_Ref ?? CreateRange(ref CombiningHalfMarks_Ref, 0x00_fe20, 0x00_fe2f);

        private static UnicodeRangeExtended? CombiningHalfMarks_Ref;

        public static UnicodeRangeExtended CjkCompatibilityForms =>
            CjkCompatibilityForms_Ref ?? CreateRange(ref CjkCompatibilityForms_Ref, 0x00_fe30, 0x00_fe4f);

        private static UnicodeRangeExtended? CjkCompatibilityForms_Ref;

        public static UnicodeRangeExtended SmallFormVariants =>
            SmallFormVariants_Ref ?? CreateRange(ref SmallFormVariants_Ref, 0x00_fe50, 0x00_fe6f);

        private static UnicodeRangeExtended? SmallFormVariants_Ref;

        public static UnicodeRangeExtended ArabicPresentationForms_b =>
            ArabicPresentationForms_b_Ref ?? CreateRange(ref ArabicPresentationForms_b_Ref, 0x00_fe70, 0x00_feff);

        private static UnicodeRangeExtended? ArabicPresentationForms_b_Ref;

        public static UnicodeRangeExtended HalfwidthAndFullwidthForms =>
            HalfwidthAndFullwidthForms_Ref ?? CreateRange(ref HalfwidthAndFullwidthForms_Ref, 0x00_ff00, 0x00_ffef);

        private static UnicodeRangeExtended? HalfwidthAndFullwidthForms_Ref;

        public static UnicodeRangeExtended Specials =>
            Specials_Ref ?? CreateRange(ref Specials_Ref, 0x00_fff0, 0x00_ffff);

        private static UnicodeRangeExtended? Specials_Ref;

        #endregion

        #region Supplementary Multilingual Plane

        public static UnicodeRangeExtended LinearBSyllabary =>
            LinearBSyllabary_Ref ?? CreateRange(ref LinearBSyllabary_Ref, 0x01_0000, 0x01_007f);

        private static UnicodeRangeExtended? LinearBSyllabary_Ref;

        public static UnicodeRangeExtended LinearBIdeograms =>
            LinearBIdeograms_Ref ?? CreateRange(ref LinearBIdeograms_Ref, 0x01_0080, 0x01_00ff);

        private static UnicodeRangeExtended? LinearBIdeograms_Ref;

        public static UnicodeRangeExtended AegeanNumbers =>
            AegeanNumbers_Ref ?? CreateRange(ref AegeanNumbers_Ref, 0x01_0100, 0x01_013f);

        private static UnicodeRangeExtended? AegeanNumbers_Ref;

        public static UnicodeRangeExtended AncientGreekNumbers =>
            AncientGreekNumbers_Ref ?? CreateRange(ref AncientGreekNumbers_Ref, 0x01_0140, 0x01_018f);

        private static UnicodeRangeExtended? AncientGreekNumbers_Ref;

        public static UnicodeRangeExtended AncientSymbols =>
            AncientSymbols_Ref ?? CreateRange(ref AncientSymbols_Ref, 0x01_0190, 0x01_01cf);

        private static UnicodeRangeExtended? AncientSymbols_Ref;

        public static UnicodeRangeExtended PhaistosDisc =>
            PhaistosDisc_Ref ?? CreateRange(ref PhaistosDisc_Ref, 0x01_01d0, 0x01_01ff);

        private static UnicodeRangeExtended? PhaistosDisc_Ref;

        public static UnicodeRangeExtended Lycian =>
            Lycian_Ref ?? CreateRange(ref Lycian_Ref, 0x01_0280, 0x01_029f);

        private static UnicodeRangeExtended? Lycian_Ref;

        public static UnicodeRangeExtended Carian =>
            Carian_Ref ?? CreateRange(ref Carian_Ref, 0x01_02a0, 0x01_02df);

        private static UnicodeRangeExtended? Carian_Ref;

        public static UnicodeRangeExtended CopticEpactNumbers =>
            CopticEpactNumbers_Ref ?? CreateRange(ref CopticEpactNumbers_Ref, 0x01_02e0, 0x01_02ff);

        private static UnicodeRangeExtended? CopticEpactNumbers_Ref;

        public static UnicodeRangeExtended OldItalic =>
            OldItalic_Ref ?? CreateRange(ref OldItalic_Ref, 0x01_0300, 0x01_032f);

        private static UnicodeRangeExtended? OldItalic_Ref;

        public static UnicodeRangeExtended Gothic =>
            Gothic_Ref ?? CreateRange(ref Gothic_Ref, 0x01_0330, 0x01_034f);

        private static UnicodeRangeExtended? Gothic_Ref;

        public static UnicodeRangeExtended OldPermic =>
            OldPermic_Ref ?? CreateRange(ref OldPermic_Ref, 0x01_0350, 0x01_037f);

        private static UnicodeRangeExtended? OldPermic_Ref;

        public static UnicodeRangeExtended Ugaritic =>
            Ugaritic_Ref ?? CreateRange(ref Ugaritic_Ref, 0x01_0380, 0x01_039f);

        private static UnicodeRangeExtended? Ugaritic_Ref;

        public static UnicodeRangeExtended OldPersian =>
            OldPersian_Ref ?? CreateRange(ref OldPersian_Ref, 0x01_03a0, 0x01_03df);

        private static UnicodeRangeExtended? OldPersian_Ref;

        public static UnicodeRangeExtended Deseret =>
            Deseret_Ref ?? CreateRange(ref Deseret_Ref, 0x01_0400, 0x01_044f);

        private static UnicodeRangeExtended? Deseret_Ref;

        public static UnicodeRangeExtended Shavian =>
            Shavian_Ref ?? CreateRange(ref Shavian_Ref, 0x01_0450, 0x01_047f);

        private static UnicodeRangeExtended? Shavian_Ref;

        public static UnicodeRangeExtended Osmanya =>
            Osmanya_Ref ?? CreateRange(ref Osmanya_Ref, 0x01_0480, 0x01_04af);

        private static UnicodeRangeExtended? Osmanya_Ref;

        public static UnicodeRangeExtended Osage =>
            Osage_Ref ?? CreateRange(ref Osage_Ref, 0x01_04b0, 0x01_04ff);

        private static UnicodeRangeExtended? Osage_Ref;

        public static UnicodeRangeExtended Elbasan =>
            Elbasan_Ref ?? CreateRange(ref Elbasan_Ref, 0x01_0500, 0x01_052f);

        private static UnicodeRangeExtended? Elbasan_Ref;

        public static UnicodeRangeExtended CaucasianAlbanian =>
            CaucasianAlbanian_Ref ?? CreateRange(ref CaucasianAlbanian_Ref, 0x01_0530, 0x01_056f);

        private static UnicodeRangeExtended? CaucasianAlbanian_Ref;

        public static UnicodeRangeExtended LinearA =>
            LinearA_Ref ?? CreateRange(ref LinearA_Ref, 0x01_0600, 0x01_077f);

        private static UnicodeRangeExtended? LinearA_Ref;

        public static UnicodeRangeExtended CypriotSyllabary =>
            CypriotSyllabary_Ref ?? CreateRange(ref CypriotSyllabary_Ref, 0x01_0800, 0x01_083f);

        private static UnicodeRangeExtended? CypriotSyllabary_Ref;

        public static UnicodeRangeExtended ImperialAramaic =>
            ImperialAramaic_Ref ?? CreateRange(ref ImperialAramaic_Ref, 0x01_0840, 0x01_085f);

        private static UnicodeRangeExtended? ImperialAramaic_Ref;

        public static UnicodeRangeExtended Palmyrene =>
            Palmyrene_Ref ?? CreateRange(ref Palmyrene_Ref, 0x01_0860, 0x01_087f);

        private static UnicodeRangeExtended? Palmyrene_Ref;

        public static UnicodeRangeExtended Nabataean =>
            Nabataean_Ref ?? CreateRange(ref Nabataean_Ref, 0x01_0880, 0x01_08af);

        private static UnicodeRangeExtended? Nabataean_Ref;

        public static UnicodeRangeExtended Hatran =>
            Hatran_Ref ?? CreateRange(ref Hatran_Ref, 0x01_08e0, 0x01_08ff);

        private static UnicodeRangeExtended? Hatran_Ref;

        public static UnicodeRangeExtended Phoenician =>
            Phoenician_Ref ?? CreateRange(ref Phoenician_Ref, 0x01_0900, 0x01_091f);

        private static UnicodeRangeExtended? Phoenician_Ref;

        public static UnicodeRangeExtended Lydian =>
            Lydian_Ref ?? CreateRange(ref Lydian_Ref, 0x01_0920, 0x01_093f);

        private static UnicodeRangeExtended? Lydian_Ref;

        public static UnicodeRangeExtended MeroiticHieroglyphs =>
            MeroiticHieroglyphs_Ref ?? CreateRange(ref MeroiticHieroglyphs_Ref, 0x01_0980, 0x01_099f);

        private static UnicodeRangeExtended? MeroiticHieroglyphs_Ref;

        public static UnicodeRangeExtended MeroiticCursive =>
            MeroiticCursive_Ref ?? CreateRange(ref MeroiticCursive_Ref, 0x01_09a0, 0x01_09ff);

        private static UnicodeRangeExtended? MeroiticCursive_Ref;

        public static UnicodeRangeExtended Kharoshthi =>
            Kharoshthi_Ref ?? CreateRange(ref Kharoshthi_Ref, 0x01_0a00, 0x01_0a5f);

        private static UnicodeRangeExtended? Kharoshthi_Ref;

        public static UnicodeRangeExtended OldSouthArabian =>
            OldSouthArabian_Ref ?? CreateRange(ref OldSouthArabian_Ref, 0x01_0a60, 0x01_0a7f);

        private static UnicodeRangeExtended? OldSouthArabian_Ref;

        public static UnicodeRangeExtended OldNorthArabian =>
            OldNorthArabian_Ref ?? CreateRange(ref OldNorthArabian_Ref, 0x01_0a80, 0x01_0a9f);

        private static UnicodeRangeExtended? OldNorthArabian_Ref;

        public static UnicodeRangeExtended Manichaean =>
            Manichaean_Ref ?? CreateRange(ref Manichaean_Ref, 0x01_0ac0, 0x01_0aff);

        private static UnicodeRangeExtended? Manichaean_Ref;

        public static UnicodeRangeExtended Avestan =>
            Avestan_Ref ?? CreateRange(ref Avestan_Ref, 0x01_0b00, 0x01_0b3f);

        private static UnicodeRangeExtended? Avestan_Ref;

        public static UnicodeRangeExtended InscriptionalParthian =>
            InscriptionalParthian_Ref ?? CreateRange(ref InscriptionalParthian_Ref, 0x01_0b40, 0x01_0b5f);

        private static UnicodeRangeExtended? InscriptionalParthian_Ref;

        public static UnicodeRangeExtended InscriptionalPahlavi =>
            InscriptionalPahlavi_Ref ?? CreateRange(ref InscriptionalPahlavi_Ref, 0x01_0b60, 0x01_0b7f);

        private static UnicodeRangeExtended? InscriptionalPahlavi_Ref;

        public static UnicodeRangeExtended PsalterPahlavi =>
            PsalterPahlavi_Ref ?? CreateRange(ref PsalterPahlavi_Ref, 0x01_0b80, 0x01_0baf);

        private static UnicodeRangeExtended? PsalterPahlavi_Ref;

        public static UnicodeRangeExtended OldTurkic =>
            OldTurkic_Ref ?? CreateRange(ref OldTurkic_Ref, 0x01_0c00, 0x01_0c4f);

        private static UnicodeRangeExtended? OldTurkic_Ref;

        public static UnicodeRangeExtended OldHungarian =>
            OldHungarian_Ref ?? CreateRange(ref OldHungarian_Ref, 0x01_0c80, 0x01_0cff);

        private static UnicodeRangeExtended? OldHungarian_Ref;

        public static UnicodeRangeExtended HanifiRohingya =>
            HanifiRohingya_Ref ?? CreateRange(ref HanifiRohingya_Ref, 0x01_0d00, 0x01_0d3f);

        private static UnicodeRangeExtended? HanifiRohingya_Ref;

        public static UnicodeRangeExtended RumiNumeralSymbols =>
            RumiNumeralSymbols_Ref ?? CreateRange(ref RumiNumeralSymbols_Ref, 0x01_0e60, 0x01_0e7f);

        private static UnicodeRangeExtended? RumiNumeralSymbols_Ref;

        public static UnicodeRangeExtended Yezidi =>
            Yezidi_Ref ?? CreateRange(ref Yezidi_Ref, 0x01_0e80, 0x01_0ebf);

        private static UnicodeRangeExtended? Yezidi_Ref;

        public static UnicodeRangeExtended OldSogdian =>
            OldSogdian_Ref ?? CreateRange(ref OldSogdian_Ref, 0x01_0f00, 0x01_0f2f);

        private static UnicodeRangeExtended? OldSogdian_Ref;

        public static UnicodeRangeExtended Sogdian =>
            Sogdian_Ref ?? CreateRange(ref Sogdian_Ref, 0x01_0f30, 0x01_0f6f);

        private static UnicodeRangeExtended? Sogdian_Ref;

        public static UnicodeRangeExtended Chorasmian =>
            Chorasmian_Ref ?? CreateRange(ref Chorasmian_Ref, 0x01_0fb0, 0x01_0fdf);

        private static UnicodeRangeExtended? Chorasmian_Ref;

        public static UnicodeRangeExtended Elymaic =>
            Elymaic_Ref ?? CreateRange(ref Elymaic_Ref, 0x01_0fe0, 0x01_0fff);

        private static UnicodeRangeExtended? Elymaic_Ref;

        public static UnicodeRangeExtended Brahmi =>
            Brahmi_Ref ?? CreateRange(ref Brahmi_Ref, 0x01_1000, 0x01_107f);

        private static UnicodeRangeExtended? Brahmi_Ref;

        public static UnicodeRangeExtended Kaithi =>
            Kaithi_Ref ?? CreateRange(ref Kaithi_Ref, 0x01_1080, 0x01_10cf);

        private static UnicodeRangeExtended? Kaithi_Ref;

        public static UnicodeRangeExtended SoraSompeng =>
            SoraSompeng_Ref ?? CreateRange(ref SoraSompeng_Ref, 0x01_10d0, 0x01_10ff);

        private static UnicodeRangeExtended? SoraSompeng_Ref;

        public static UnicodeRangeExtended Chakma =>
            Chakma_Ref ?? CreateRange(ref Chakma_Ref, 0x01_1100, 0x01_114f);

        private static UnicodeRangeExtended? Chakma_Ref;

        public static UnicodeRangeExtended Mahajani =>
            Mahajani_Ref ?? CreateRange(ref Mahajani_Ref, 0x01_1150, 0x01_117f);

        private static UnicodeRangeExtended? Mahajani_Ref;

        public static UnicodeRangeExtended Sharada =>
            Sharada_Ref ?? CreateRange(ref Sharada_Ref, 0x01_1180, 0x01_11df);

        private static UnicodeRangeExtended? Sharada_Ref;

        public static UnicodeRangeExtended SinhalaArchaicNumbers =>
            SinhalaArchaicNumbers_Ref ?? CreateRange(ref SinhalaArchaicNumbers_Ref, 0x01_11e0, 0x01_11ff);

        private static UnicodeRangeExtended? SinhalaArchaicNumbers_Ref;

        public static UnicodeRangeExtended Khojki =>
            Khojki_Ref ?? CreateRange(ref Khojki_Ref, 0x01_1200, 0x01_124f);

        private static UnicodeRangeExtended? Khojki_Ref;

        public static UnicodeRangeExtended Multani =>
            Multani_Ref ?? CreateRange(ref Multani_Ref, 0x01_1280, 0x01_12af);

        private static UnicodeRangeExtended? Multani_Ref;

        public static UnicodeRangeExtended Khudawadi =>
            Khudawadi_Ref ?? CreateRange(ref Khudawadi_Ref, 0x01_12b0, 0x01_12ff);

        private static UnicodeRangeExtended? Khudawadi_Ref;

        public static UnicodeRangeExtended Grantha =>
            Grantha_Ref ?? CreateRange(ref Grantha_Ref, 0x01_1300, 0x01_137f);

        private static UnicodeRangeExtended? Grantha_Ref;

        public static UnicodeRangeExtended Newa =>
            Newa_Ref ?? CreateRange(ref Newa_Ref, 0x01_1400, 0x01_147f);

        private static UnicodeRangeExtended? Newa_Ref;

        public static UnicodeRangeExtended Tirhuta =>
            Tirhuta_Ref ?? CreateRange(ref Tirhuta_Ref, 0x01_1480, 0x01_14df);

        private static UnicodeRangeExtended? Tirhuta_Ref;

        public static UnicodeRangeExtended Siddham =>
            Siddham_Ref ?? CreateRange(ref Siddham_Ref, 0x01_1580, 0x01_15ff);

        private static UnicodeRangeExtended? Siddham_Ref;

        public static UnicodeRangeExtended Modi =>
            Modi_Ref ?? CreateRange(ref Modi_Ref, 0x01_1600, 0x01_165f);

        private static UnicodeRangeExtended? Modi_Ref;

        public static UnicodeRangeExtended MongolianSupplement =>
            MongolianSupplement_Ref ?? CreateRange(ref MongolianSupplement_Ref, 0x01_1660, 0x01_167f);

        private static UnicodeRangeExtended? MongolianSupplement_Ref;

        public static UnicodeRangeExtended Takri =>
            Takri_Ref ?? CreateRange(ref Takri_Ref, 0x01_1680, 0x01_16cf);

        private static UnicodeRangeExtended? Takri_Ref;

        public static UnicodeRangeExtended Ahom =>
            Ahom_Ref ?? CreateRange(ref Ahom_Ref, 0x01_1700, 0x01_173f);

        private static UnicodeRangeExtended? Ahom_Ref;

        public static UnicodeRangeExtended Dogra =>
            Dogra_Ref ?? CreateRange(ref Dogra_Ref, 0x01_1800, 0x01_184f);

        private static UnicodeRangeExtended? Dogra_Ref;

        public static UnicodeRangeExtended WarangCiti =>
            WarangCiti_Ref ?? CreateRange(ref WarangCiti_Ref, 0x01_18a0, 0x01_18ff);

        private static UnicodeRangeExtended? WarangCiti_Ref;

        public static UnicodeRangeExtended DivesAkuru =>
            DivesAkuru_Ref ?? CreateRange(ref DivesAkuru_Ref, 0x01_1900, 0x01_195f);

        private static UnicodeRangeExtended? DivesAkuru_Ref;

        public static UnicodeRangeExtended Nandinagari =>
            Nandinagari_Ref ?? CreateRange(ref Nandinagari_Ref, 0x01_19a0, 0x01_19ff);

        private static UnicodeRangeExtended? Nandinagari_Ref;

        public static UnicodeRangeExtended ZanabazarSquare =>
            ZanabazarSquare_Ref ?? CreateRange(ref ZanabazarSquare_Ref, 0x01_1a00, 0x01_1a4f);

        private static UnicodeRangeExtended? ZanabazarSquare_Ref;

        public static UnicodeRangeExtended Soyombo =>
            Soyombo_Ref ?? CreateRange(ref Soyombo_Ref, 0x01_1a50, 0x01_1aaf);

        private static UnicodeRangeExtended? Soyombo_Ref;

        public static UnicodeRangeExtended PauCinHau =>
            PauCinHau_Ref ?? CreateRange(ref PauCinHau_Ref, 0x01_1ac0, 0x01_1aff);

        private static UnicodeRangeExtended? PauCinHau_Ref;

        public static UnicodeRangeExtended Bhaiksuki =>
            Bhaiksuki_Ref ?? CreateRange(ref Bhaiksuki_Ref, 0x01_1c00, 0x01_1c6f);

        private static UnicodeRangeExtended? Bhaiksuki_Ref;

        public static UnicodeRangeExtended Marchen =>
            Marchen_Ref ?? CreateRange(ref Marchen_Ref, 0x01_1c70, 0x01_1cbf);

        private static UnicodeRangeExtended? Marchen_Ref;

        public static UnicodeRangeExtended MasaramGondi =>
            MasaramGondi_Ref ?? CreateRange(ref MasaramGondi_Ref, 0x01_1d00, 0x01_1d5f);

        private static UnicodeRangeExtended? MasaramGondi_Ref;

        public static UnicodeRangeExtended GunjalaGondi =>
            GunjalaGondi_Ref ?? CreateRange(ref GunjalaGondi_Ref, 0x01_1d60, 0x01_1daf);

        private static UnicodeRangeExtended? GunjalaGondi_Ref;

        public static UnicodeRangeExtended Makasar =>
            Makasar_Ref ?? CreateRange(ref Makasar_Ref, 0x01_1ee0, 0x01_1eff);

        private static UnicodeRangeExtended? Makasar_Ref;

        public static UnicodeRangeExtended LisuSupplement =>
            LisuSupplement_Ref ?? CreateRange(ref LisuSupplement_Ref, 0x01_1fb0, 0x01_1fbf);

        private static UnicodeRangeExtended? LisuSupplement_Ref;

        public static UnicodeRangeExtended TamilSupplement =>
            TamilSupplement_Ref ?? CreateRange(ref TamilSupplement_Ref, 0x01_1fc0, 0x01_1fff);

        private static UnicodeRangeExtended? TamilSupplement_Ref;

        public static UnicodeRangeExtended Cuneiform =>
            Cuneiform_Ref ?? CreateRange(ref Cuneiform_Ref, 0x01_2000, 0x01_23ff);

        private static UnicodeRangeExtended? Cuneiform_Ref;

        public static UnicodeRangeExtended CuneiformNumbersAndPunctuation =>
            CuneiformNumbersAndPunctuation_Ref ?? CreateRange(ref CuneiformNumbersAndPunctuation_Ref, 0x01_2400, 0x01_247f);

        private static UnicodeRangeExtended? CuneiformNumbersAndPunctuation_Ref;

        public static UnicodeRangeExtended EarlyDynasticCuneiform =>
            EarlyDynasticCuneiform_Ref ?? CreateRange(ref EarlyDynasticCuneiform_Ref, 0x01_2480, 0x01_254f);

        private static UnicodeRangeExtended? EarlyDynasticCuneiform_Ref;

        public static UnicodeRangeExtended EgyptianHieroglyphs =>
            EgyptianHieroglyphs_Ref ?? CreateRange(ref EgyptianHieroglyphs_Ref, 0x01_3000, 0x01_342f);

        private static UnicodeRangeExtended? EgyptianHieroglyphs_Ref;

        public static UnicodeRangeExtended EgyptianHieroglyphFormatControls =>
            EgyptianHieroglyphFormatControls_Ref ?? CreateRange(ref EgyptianHieroglyphFormatControls_Ref, 0x01_3430, 0x01_343f);

        private static UnicodeRangeExtended? EgyptianHieroglyphFormatControls_Ref;

        public static UnicodeRangeExtended AnatolianHieroglyphs =>
            AnatolianHieroglyphs_Ref ?? CreateRange(ref AnatolianHieroglyphs_Ref, 0x01_4400, 0x01_467f);

        private static UnicodeRangeExtended? AnatolianHieroglyphs_Ref;

        public static UnicodeRangeExtended BamumSupplement =>
            BamumSupplement_Ref ?? CreateRange(ref BamumSupplement_Ref, 0x01_6800, 0x01_6a3f);

        private static UnicodeRangeExtended? BamumSupplement_Ref;

        public static UnicodeRangeExtended Mro =>
            Mro_Ref ?? CreateRange(ref Mro_Ref, 0x01_6a40, 0x01_6a6f);

        private static UnicodeRangeExtended? Mro_Ref;

        public static UnicodeRangeExtended BassaVah =>
            BassaVah_Ref ?? CreateRange(ref BassaVah_Ref, 0x01_6ad0, 0x01_6aff);

        private static UnicodeRangeExtended? BassaVah_Ref;

        public static UnicodeRangeExtended PahawhHmong =>
            PahawhHmong_Ref ?? CreateRange(ref PahawhHmong_Ref, 0x01_6b00, 0x01_6b8f);

        private static UnicodeRangeExtended? PahawhHmong_Ref;

        public static UnicodeRangeExtended Medefaidrin =>
            Medefaidrin_Ref ?? CreateRange(ref Medefaidrin_Ref, 0x01_6e40, 0x01_6e9f);

        private static UnicodeRangeExtended? Medefaidrin_Ref;

        public static UnicodeRangeExtended Miao =>
            Miao_Ref ?? CreateRange(ref Miao_Ref, 0x01_6f00, 0x01_6f9f);

        private static UnicodeRangeExtended? Miao_Ref;

        public static UnicodeRangeExtended IdeographicSymbolsAndPunctuation =>
            IdeographicSymbolsAndPunctuation_Ref ?? CreateRange(ref IdeographicSymbolsAndPunctuation_Ref, 0x01_6fe0, 0x01_6fff);

        private static UnicodeRangeExtended? IdeographicSymbolsAndPunctuation_Ref;

        public static UnicodeRangeExtended Tangut =>
            Tangut_Ref ?? CreateRange(ref Tangut_Ref, 0x01_7000, 0x01_87ff);

        private static UnicodeRangeExtended? Tangut_Ref;

        public static UnicodeRangeExtended TangutComponents =>
            TangutComponents_Ref ?? CreateRange(ref TangutComponents_Ref, 0x01_8800, 0x01_8aff);

        private static UnicodeRangeExtended? TangutComponents_Ref;

        public static UnicodeRangeExtended KhitanSmallScript =>
            KhitanSmallScript_Ref ?? CreateRange(ref KhitanSmallScript_Ref, 0x01_8b00, 0x01_8cff);

        private static UnicodeRangeExtended? KhitanSmallScript_Ref;

        public static UnicodeRangeExtended TangutSupplement =>
            TangutSupplement_Ref ?? CreateRange(ref TangutSupplement_Ref, 0x01_8d00, 0x01_8d8f);

        private static UnicodeRangeExtended? TangutSupplement_Ref;

        public static UnicodeRangeExtended KanaSupplement =>
            KanaSupplement_Ref ?? CreateRange(ref KanaSupplement_Ref, 0x01_b000, 0x01_b0ff);

        private static UnicodeRangeExtended? KanaSupplement_Ref;

        public static UnicodeRangeExtended KanaExtended_a =>
            KanaExtended_a_Ref ?? CreateRange(ref KanaExtended_a_Ref, 0x01_b100, 0x01_b12f);

        private static UnicodeRangeExtended? KanaExtended_a_Ref;

        public static UnicodeRangeExtended SmallKanaExtension =>
            SmallKanaExtension_Ref ?? CreateRange(ref SmallKanaExtension_Ref, 0x01_b130, 0x01_b16f);

        private static UnicodeRangeExtended? SmallKanaExtension_Ref;

        public static UnicodeRangeExtended Nushu =>
            Nushu_Ref ?? CreateRange(ref Nushu_Ref, 0x01_b170, 0x01_b2ff);

        private static UnicodeRangeExtended? Nushu_Ref;

        public static UnicodeRangeExtended Duployan =>
            Duployan_Ref ?? CreateRange(ref Duployan_Ref, 0x01_bc00, 0x01_bc9f);

        private static UnicodeRangeExtended? Duployan_Ref;

        public static UnicodeRangeExtended ShorthandFormatControls =>
            ShorthandFormatControls_Ref ?? CreateRange(ref ShorthandFormatControls_Ref, 0x01_bca0, 0x01_bcaf);

        private static UnicodeRangeExtended? ShorthandFormatControls_Ref;

        public static UnicodeRangeExtended ByzantineMusicalSymbols =>
            ByzantineMusicalSymbols_Ref ?? CreateRange(ref ByzantineMusicalSymbols_Ref, 0x01_d000, 0x01_d0ff);

        private static UnicodeRangeExtended? ByzantineMusicalSymbols_Ref;

        public static UnicodeRangeExtended MusicalSymbols =>
            MusicalSymbols_Ref ?? CreateRange(ref MusicalSymbols_Ref, 0x01_d100, 0x01_d1ff);

        private static UnicodeRangeExtended? MusicalSymbols_Ref;

        public static UnicodeRangeExtended AncientGreekMusicalNotation =>
            AncientGreekMusicalNotation_Ref ?? CreateRange(ref AncientGreekMusicalNotation_Ref, 0x01_d200, 0x01_d24f);

        private static UnicodeRangeExtended? AncientGreekMusicalNotation_Ref;

        public static UnicodeRangeExtended MayanNumerals =>
            MayanNumerals_Ref ?? CreateRange(ref MayanNumerals_Ref, 0x01_d2e0, 0x01_d2ff);

        private static UnicodeRangeExtended? MayanNumerals_Ref;

        public static UnicodeRangeExtended TaiXuanJingSymbols =>
            TaiXuanJingSymbols_Ref ?? CreateRange(ref TaiXuanJingSymbols_Ref, 0x01_d300, 0x01_d35f);

        private static UnicodeRangeExtended? TaiXuanJingSymbols_Ref;

        public static UnicodeRangeExtended CountingRodNumerals =>
            CountingRodNumerals_Ref ?? CreateRange(ref CountingRodNumerals_Ref, 0x01_d360, 0x01_d37f);

        private static UnicodeRangeExtended? CountingRodNumerals_Ref;

        public static UnicodeRangeExtended MathematicalAlphanumericSymbols =>
            MathematicalAlphanumericSymbols_Ref ?? CreateRange(ref MathematicalAlphanumericSymbols_Ref, 0x01_d400, 0x01_d7ff);

        private static UnicodeRangeExtended? MathematicalAlphanumericSymbols_Ref;

        public static UnicodeRangeExtended SuttonSignwriting =>
            SuttonSignwriting_Ref ?? CreateRange(ref SuttonSignwriting_Ref, 0x01_d800, 0x01_daaf);

        private static UnicodeRangeExtended? SuttonSignwriting_Ref;

        public static UnicodeRangeExtended GlagoliticSupplement =>
            GlagoliticSupplement_Ref ?? CreateRange(ref GlagoliticSupplement_Ref, 0x01_e000, 0x01_e02f);

        private static UnicodeRangeExtended? GlagoliticSupplement_Ref;

        public static UnicodeRangeExtended NyiakengPuachueHmong =>
            NyiakengPuachueHmong_Ref ?? CreateRange(ref NyiakengPuachueHmong_Ref, 0x01_e100, 0x01_e14f);

        private static UnicodeRangeExtended? NyiakengPuachueHmong_Ref;

        public static UnicodeRangeExtended Wancho =>
            Wancho_Ref ?? CreateRange(ref Wancho_Ref, 0x01_e2c0, 0x01_e2ff);

        private static UnicodeRangeExtended? Wancho_Ref;

        public static UnicodeRangeExtended MendeKikakui =>
            MendeKikakui_Ref ?? CreateRange(ref MendeKikakui_Ref, 0x01_e800, 0x01_e8df);

        private static UnicodeRangeExtended? MendeKikakui_Ref;

        public static UnicodeRangeExtended Adlam =>
            Adlam_Ref ?? CreateRange(ref Adlam_Ref, 0x01_e900, 0x01_e95f);

        private static UnicodeRangeExtended? Adlam_Ref;

        public static UnicodeRangeExtended IndicSiyaqNumbers =>
            IndicSiyaqNumbers_Ref ?? CreateRange(ref IndicSiyaqNumbers_Ref, 0x01_ec70, 0x01_ecbf);

        private static UnicodeRangeExtended? IndicSiyaqNumbers_Ref;

        public static UnicodeRangeExtended OttomanSiyaqNumbers =>
            OttomanSiyaqNumbers_Ref ?? CreateRange(ref OttomanSiyaqNumbers_Ref, 0x01_ed00, 0x01_ed4f);

        private static UnicodeRangeExtended? OttomanSiyaqNumbers_Ref;

        public static UnicodeRangeExtended ArabicMathematicalAlphabeticSymbols =>
            ArabicMathematicalAlphabeticSymbols_Ref ?? CreateRange(ref ArabicMathematicalAlphabeticSymbols_Ref, 0x01_ee00, 0x01_eeff);

        private static UnicodeRangeExtended? ArabicMathematicalAlphabeticSymbols_Ref;

        public static UnicodeRangeExtended MahjongTiles =>
            MahjongTiles_Ref ?? CreateRange(ref MahjongTiles_Ref, 0x01_f000, 0x01_f02f);

        private static UnicodeRangeExtended? MahjongTiles_Ref;

        public static UnicodeRangeExtended DominoTiles =>
            DominoTiles_Ref ?? CreateRange(ref DominoTiles_Ref, 0x01_f030, 0x01_f09f);

        private static UnicodeRangeExtended? DominoTiles_Ref;

        public static UnicodeRangeExtended PlayingCards =>
            PlayingCards_Ref ?? CreateRange(ref PlayingCards_Ref, 0x01_f0a0, 0x01_f0ff);

        private static UnicodeRangeExtended? PlayingCards_Ref;

        public static UnicodeRangeExtended EnclosedAlphanumericSupplement =>
            EnclosedAlphanumericSupplement_Ref ?? CreateRange(ref EnclosedAlphanumericSupplement_Ref, 0x01_f100, 0x01_f1ff);

        private static UnicodeRangeExtended? EnclosedAlphanumericSupplement_Ref;

        public static UnicodeRangeExtended EnclosedIdeographicSupplement =>
            EnclosedIdeographicSupplement_Ref ?? CreateRange(ref EnclosedIdeographicSupplement_Ref, 0x01_f200, 0x01_f2ff);

        private static UnicodeRangeExtended? EnclosedIdeographicSupplement_Ref;

        public static UnicodeRangeExtended MiscellaneousSymbolsAndPictographs =>
            MiscellaneousSymbolsAndPictographs_Ref ?? CreateRange(ref MiscellaneousSymbolsAndPictographs_Ref, 0x01_f300, 0x01_f5ff);

        private static UnicodeRangeExtended? MiscellaneousSymbolsAndPictographs_Ref;

        public static UnicodeRangeExtended Emoticons =>
            Emoticons_Ref ?? CreateRange(ref Emoticons_Ref, 0x01_f600, 0x01_f64f);

        private static UnicodeRangeExtended? Emoticons_Ref;

        public static UnicodeRangeExtended OrnamentalDingbats =>
            OrnamentalDingbats_Ref ?? CreateRange(ref OrnamentalDingbats_Ref, 0x01_f650, 0x01_f67f);

        private static UnicodeRangeExtended? OrnamentalDingbats_Ref;

        public static UnicodeRangeExtended TransportAndMapSymbols =>
            TransportAndMapSymbols_Ref ?? CreateRange(ref TransportAndMapSymbols_Ref, 0x01_f680, 0x01_f6ff);

        private static UnicodeRangeExtended? TransportAndMapSymbols_Ref;

        public static UnicodeRangeExtended AlchemicalSymbols =>
            AlchemicalSymbols_Ref ?? CreateRange(ref AlchemicalSymbols_Ref, 0x01_f700, 0x01_f77f);

        private static UnicodeRangeExtended? AlchemicalSymbols_Ref;

        public static UnicodeRangeExtended GeometricShapesExtended =>
            GeometricShapesExtended_Ref ?? CreateRange(ref GeometricShapesExtended_Ref, 0x01_f780, 0x01_f7ff);

        private static UnicodeRangeExtended? GeometricShapesExtended_Ref;

        public static UnicodeRangeExtended SupplementalArrows_c =>
            SupplementalArrows_c_Ref ?? CreateRange(ref SupplementalArrows_c_Ref, 0x01_f800, 0x01_f8ff);

        private static UnicodeRangeExtended? SupplementalArrows_c_Ref;

        public static UnicodeRangeExtended SupplementalSymbolsAndPictographs =>
            SupplementalSymbolsAndPictographs_Ref ?? CreateRange(ref SupplementalSymbolsAndPictographs_Ref, 0x01_f900, 0x01_f9ff);

        private static UnicodeRangeExtended? SupplementalSymbolsAndPictographs_Ref;

        public static UnicodeRangeExtended ChessSymbols =>
            ChessSymbols_Ref ?? CreateRange(ref ChessSymbols_Ref, 0x01_fa00, 0x01_fa6f);

        private static UnicodeRangeExtended? ChessSymbols_Ref;

        public static UnicodeRangeExtended SymbolsAndPictographsExtended_a =>
            SymbolsAndPictographsExtended_a_Ref ?? CreateRange(ref SymbolsAndPictographsExtended_a_Ref, 0x01_fa70, 0x01_faff);

        private static UnicodeRangeExtended? SymbolsAndPictographsExtended_a_Ref;

        public static UnicodeRangeExtended SymbolsForLegacyComputing =>
            SymbolsForLegacyComputing_Ref ?? CreateRange(ref SymbolsForLegacyComputing_Ref, 0x01_fb00, 0x01_fbff);

        private static UnicodeRangeExtended? SymbolsForLegacyComputing_Ref;

        #endregion

        #region Supplementary Ideographic Plane

        public static UnicodeRangeExtended CjkUnifiedIdeographsExtensionB =>
            CjkUnifiedIdeographsExtensionB_Ref ?? CreateRange(ref CjkUnifiedIdeographsExtensionB_Ref, 0x02_0000, 0x02_a6df);

        private static UnicodeRangeExtended? CjkUnifiedIdeographsExtensionB_Ref;

        public static UnicodeRangeExtended CjkUnifiedIdeographsExtensionC =>
            CjkUnifiedIdeographsExtensionC_Ref ?? CreateRange(ref CjkUnifiedIdeographsExtensionC_Ref, 0x02_a700, 0x02_b73f);

        private static UnicodeRangeExtended? CjkUnifiedIdeographsExtensionC_Ref;

        public static UnicodeRangeExtended CjkUnifiedIdeographsExtensionD =>
            CjkUnifiedIdeographsExtensionD_Ref ?? CreateRange(ref CjkUnifiedIdeographsExtensionD_Ref, 0x02_b740, 0x02_b81f);

        private static UnicodeRangeExtended? CjkUnifiedIdeographsExtensionD_Ref;

        public static UnicodeRangeExtended CjkUnifiedIdeographsExtensionE =>
            CjkUnifiedIdeographsExtensionE_Ref ?? CreateRange(ref CjkUnifiedIdeographsExtensionE_Ref, 0x02_b820, 0x02_ceaf);

        private static UnicodeRangeExtended? CjkUnifiedIdeographsExtensionE_Ref;

        public static UnicodeRangeExtended CjkUnifiedIdeographsExtensionF =>
            CjkUnifiedIdeographsExtensionF_Ref ?? CreateRange(ref CjkUnifiedIdeographsExtensionF_Ref, 0x02_ceb0, 0x02_ebef);

        private static UnicodeRangeExtended? CjkUnifiedIdeographsExtensionF_Ref;

        public static UnicodeRangeExtended CjkCompatibilityIdeographsSupplement =>
            CjkCompatibilityIdeographsSupplement_Ref ?? CreateRange(ref CjkCompatibilityIdeographsSupplement_Ref, 0x02_f800, 0x02_fa1f);

        private static UnicodeRangeExtended? CjkCompatibilityIdeographsSupplement_Ref;

        #endregion

        #region Tertiary Ideographic Plane

        public static UnicodeRangeExtended CjkUnifiedIdeographsExtensionG =>
            CjkUnifiedIdeographsExtensionG_Ref ?? CreateRange(ref CjkUnifiedIdeographsExtensionG_Ref, 0x03_0000, 0x03_134f);

        private static UnicodeRangeExtended? CjkUnifiedIdeographsExtensionG_Ref;

        #endregion

        #region Supplementary Special-purpose Plane

        public static UnicodeRangeExtended Tags =>
            Tags_Ref ?? CreateRange(ref Tags_Ref, 0x0e_0000, 0x0e_007f);

        private static UnicodeRangeExtended? Tags_Ref;

        public static UnicodeRangeExtended VariationSelectorsSupplement =>
            VariationSelectorsSupplement_Ref ?? CreateRange(ref VariationSelectorsSupplement_Ref, 0x0e_0100, 0x0e_01ef);

        private static UnicodeRangeExtended? VariationSelectorsSupplement_Ref;

        #endregion
    }
}