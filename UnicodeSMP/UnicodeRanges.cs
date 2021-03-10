namespace UnicodeSMP
{
   public static partial class UnicodeRanges
   {
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

        public static UnicodeRangeExtended CjkUnifiedIdeographsExtensionG =>
            CjkUnifiedIdeographsExtensionG_Ref ?? CreateRange(ref CjkUnifiedIdeographsExtensionG_Ref, 0x03_0000, 0x03_134f);

        private static UnicodeRangeExtended? CjkUnifiedIdeographsExtensionG_Ref;

        public static UnicodeRangeExtended Tags =>
            Tags_Ref ?? CreateRange(ref Tags_Ref, 0x0e_0000, 0x0e_007f);

        private static UnicodeRangeExtended? Tags_Ref;

        public static UnicodeRangeExtended VariationSelectorsSupplement =>
            VariationSelectorsSupplement_Ref ?? CreateRange(ref VariationSelectorsSupplement_Ref, 0x0e_0100, 0x0e_01ef);

        private static UnicodeRangeExtended? VariationSelectorsSupplement_Ref;
   }
}