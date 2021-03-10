using System.Text.Unicode;

namespace UnicodeSMP
{
   public static partial class UnicodeRanges
   {
        public static UnicodeRange LinearBSyllabary =>
            LinearBSyllabary_Ref ?? CreateRange(ref LinearBSyllabary_Ref, 0x010000, 0x01007f);

        private static UnicodeRange? LinearBSyllabary_Ref;

        public static UnicodeRange LinearBIdeograms =>
            LinearBIdeograms_Ref ?? CreateRange(ref LinearBIdeograms_Ref, 0x010080, 0x0100ff);

        private static UnicodeRange? LinearBIdeograms_Ref;

        public static UnicodeRange AegeanNumbers =>
            AegeanNumbers_Ref ?? CreateRange(ref AegeanNumbers_Ref, 0x010100, 0x01013f);

        private static UnicodeRange? AegeanNumbers_Ref;

        public static UnicodeRange AncientGreekNumbers =>
            AncientGreekNumbers_Ref ?? CreateRange(ref AncientGreekNumbers_Ref, 0x010140, 0x01018f);

        private static UnicodeRange? AncientGreekNumbers_Ref;

        public static UnicodeRange AncientSymbols =>
            AncientSymbols_Ref ?? CreateRange(ref AncientSymbols_Ref, 0x010190, 0x0101cf);

        private static UnicodeRange? AncientSymbols_Ref;

        public static UnicodeRange PhaistosDisc =>
            PhaistosDisc_Ref ?? CreateRange(ref PhaistosDisc_Ref, 0x0101d0, 0x0101ff);

        private static UnicodeRange? PhaistosDisc_Ref;

        public static UnicodeRange Lycian =>
            Lycian_Ref ?? CreateRange(ref Lycian_Ref, 0x010280, 0x01029f);

        private static UnicodeRange? Lycian_Ref;

        public static UnicodeRange Carian =>
            Carian_Ref ?? CreateRange(ref Carian_Ref, 0x0102a0, 0x0102df);

        private static UnicodeRange? Carian_Ref;

        public static UnicodeRange CopticEpactNumbers =>
            CopticEpactNumbers_Ref ?? CreateRange(ref CopticEpactNumbers_Ref, 0x0102e0, 0x0102ff);

        private static UnicodeRange? CopticEpactNumbers_Ref;

        public static UnicodeRange OldItalic =>
            OldItalic_Ref ?? CreateRange(ref OldItalic_Ref, 0x010300, 0x01032f);

        private static UnicodeRange? OldItalic_Ref;

        public static UnicodeRange Gothic =>
            Gothic_Ref ?? CreateRange(ref Gothic_Ref, 0x010330, 0x01034f);

        private static UnicodeRange? Gothic_Ref;

        public static UnicodeRange OldPermic =>
            OldPermic_Ref ?? CreateRange(ref OldPermic_Ref, 0x010350, 0x01037f);

        private static UnicodeRange? OldPermic_Ref;

        public static UnicodeRange Ugaritic =>
            Ugaritic_Ref ?? CreateRange(ref Ugaritic_Ref, 0x010380, 0x01039f);

        private static UnicodeRange? Ugaritic_Ref;

        public static UnicodeRange OldPersian =>
            OldPersian_Ref ?? CreateRange(ref OldPersian_Ref, 0x0103a0, 0x0103df);

        private static UnicodeRange? OldPersian_Ref;

        public static UnicodeRange Deseret =>
            Deseret_Ref ?? CreateRange(ref Deseret_Ref, 0x010400, 0x01044f);

        private static UnicodeRange? Deseret_Ref;

        public static UnicodeRange Shavian =>
            Shavian_Ref ?? CreateRange(ref Shavian_Ref, 0x010450, 0x01047f);

        private static UnicodeRange? Shavian_Ref;

        public static UnicodeRange Osmanya =>
            Osmanya_Ref ?? CreateRange(ref Osmanya_Ref, 0x010480, 0x0104af);

        private static UnicodeRange? Osmanya_Ref;

        public static UnicodeRange Osage =>
            Osage_Ref ?? CreateRange(ref Osage_Ref, 0x0104b0, 0x0104ff);

        private static UnicodeRange? Osage_Ref;

        public static UnicodeRange Elbasan =>
            Elbasan_Ref ?? CreateRange(ref Elbasan_Ref, 0x010500, 0x01052f);

        private static UnicodeRange? Elbasan_Ref;

        public static UnicodeRange CaucasianAlbanian =>
            CaucasianAlbanian_Ref ?? CreateRange(ref CaucasianAlbanian_Ref, 0x010530, 0x01056f);

        private static UnicodeRange? CaucasianAlbanian_Ref;

        public static UnicodeRange LinearA =>
            LinearA_Ref ?? CreateRange(ref LinearA_Ref, 0x010600, 0x01077f);

        private static UnicodeRange? LinearA_Ref;

        public static UnicodeRange CypriotSyllabary =>
            CypriotSyllabary_Ref ?? CreateRange(ref CypriotSyllabary_Ref, 0x010800, 0x01083f);

        private static UnicodeRange? CypriotSyllabary_Ref;

        public static UnicodeRange ImperialAramaic =>
            ImperialAramaic_Ref ?? CreateRange(ref ImperialAramaic_Ref, 0x010840, 0x01085f);

        private static UnicodeRange? ImperialAramaic_Ref;

        public static UnicodeRange Palmyrene =>
            Palmyrene_Ref ?? CreateRange(ref Palmyrene_Ref, 0x010860, 0x01087f);

        private static UnicodeRange? Palmyrene_Ref;

        public static UnicodeRange Nabataean =>
            Nabataean_Ref ?? CreateRange(ref Nabataean_Ref, 0x010880, 0x0108af);

        private static UnicodeRange? Nabataean_Ref;

        public static UnicodeRange Hatran =>
            Hatran_Ref ?? CreateRange(ref Hatran_Ref, 0x0108e0, 0x0108ff);

        private static UnicodeRange? Hatran_Ref;

        public static UnicodeRange Phoenician =>
            Phoenician_Ref ?? CreateRange(ref Phoenician_Ref, 0x010900, 0x01091f);

        private static UnicodeRange? Phoenician_Ref;

        public static UnicodeRange Lydian =>
            Lydian_Ref ?? CreateRange(ref Lydian_Ref, 0x010920, 0x01093f);

        private static UnicodeRange? Lydian_Ref;

        public static UnicodeRange MeroiticHieroglyphs =>
            MeroiticHieroglyphs_Ref ?? CreateRange(ref MeroiticHieroglyphs_Ref, 0x010980, 0x01099f);

        private static UnicodeRange? MeroiticHieroglyphs_Ref;

        public static UnicodeRange MeroiticCursive =>
            MeroiticCursive_Ref ?? CreateRange(ref MeroiticCursive_Ref, 0x0109a0, 0x0109ff);

        private static UnicodeRange? MeroiticCursive_Ref;

        public static UnicodeRange Kharoshthi =>
            Kharoshthi_Ref ?? CreateRange(ref Kharoshthi_Ref, 0x010a00, 0x010a5f);

        private static UnicodeRange? Kharoshthi_Ref;

        public static UnicodeRange OldSouthArabian =>
            OldSouthArabian_Ref ?? CreateRange(ref OldSouthArabian_Ref, 0x010a60, 0x010a7f);

        private static UnicodeRange? OldSouthArabian_Ref;

        public static UnicodeRange OldNorthArabian =>
            OldNorthArabian_Ref ?? CreateRange(ref OldNorthArabian_Ref, 0x010a80, 0x010a9f);

        private static UnicodeRange? OldNorthArabian_Ref;

        public static UnicodeRange Manichaean =>
            Manichaean_Ref ?? CreateRange(ref Manichaean_Ref, 0x010ac0, 0x010aff);

        private static UnicodeRange? Manichaean_Ref;

        public static UnicodeRange Avestan =>
            Avestan_Ref ?? CreateRange(ref Avestan_Ref, 0x010b00, 0x010b3f);

        private static UnicodeRange? Avestan_Ref;

        public static UnicodeRange InscriptionalParthian =>
            InscriptionalParthian_Ref ?? CreateRange(ref InscriptionalParthian_Ref, 0x010b40, 0x010b5f);

        private static UnicodeRange? InscriptionalParthian_Ref;

        public static UnicodeRange InscriptionalPahlavi =>
            InscriptionalPahlavi_Ref ?? CreateRange(ref InscriptionalPahlavi_Ref, 0x010b60, 0x010b7f);

        private static UnicodeRange? InscriptionalPahlavi_Ref;

        public static UnicodeRange PsalterPahlavi =>
            PsalterPahlavi_Ref ?? CreateRange(ref PsalterPahlavi_Ref, 0x010b80, 0x010baf);

        private static UnicodeRange? PsalterPahlavi_Ref;

        public static UnicodeRange OldTurkic =>
            OldTurkic_Ref ?? CreateRange(ref OldTurkic_Ref, 0x010c00, 0x010c4f);

        private static UnicodeRange? OldTurkic_Ref;

        public static UnicodeRange OldHungarian =>
            OldHungarian_Ref ?? CreateRange(ref OldHungarian_Ref, 0x010c80, 0x010cff);

        private static UnicodeRange? OldHungarian_Ref;

        public static UnicodeRange HanifiRohingya =>
            HanifiRohingya_Ref ?? CreateRange(ref HanifiRohingya_Ref, 0x010d00, 0x010d3f);

        private static UnicodeRange? HanifiRohingya_Ref;

        public static UnicodeRange RumiNumeralSymbols =>
            RumiNumeralSymbols_Ref ?? CreateRange(ref RumiNumeralSymbols_Ref, 0x010e60, 0x010e7f);

        private static UnicodeRange? RumiNumeralSymbols_Ref;

        public static UnicodeRange Yezidi =>
            Yezidi_Ref ?? CreateRange(ref Yezidi_Ref, 0x010e80, 0x010ebf);

        private static UnicodeRange? Yezidi_Ref;

        public static UnicodeRange OldSogdian =>
            OldSogdian_Ref ?? CreateRange(ref OldSogdian_Ref, 0x010f00, 0x010f2f);

        private static UnicodeRange? OldSogdian_Ref;

        public static UnicodeRange Sogdian =>
            Sogdian_Ref ?? CreateRange(ref Sogdian_Ref, 0x010f30, 0x010f6f);

        private static UnicodeRange? Sogdian_Ref;

        public static UnicodeRange Chorasmian =>
            Chorasmian_Ref ?? CreateRange(ref Chorasmian_Ref, 0x010fb0, 0x010fdf);

        private static UnicodeRange? Chorasmian_Ref;

        public static UnicodeRange Elymaic =>
            Elymaic_Ref ?? CreateRange(ref Elymaic_Ref, 0x010fe0, 0x010fff);

        private static UnicodeRange? Elymaic_Ref;

        public static UnicodeRange Brahmi =>
            Brahmi_Ref ?? CreateRange(ref Brahmi_Ref, 0x011000, 0x01107f);

        private static UnicodeRange? Brahmi_Ref;

        public static UnicodeRange Kaithi =>
            Kaithi_Ref ?? CreateRange(ref Kaithi_Ref, 0x011080, 0x0110cf);

        private static UnicodeRange? Kaithi_Ref;

        public static UnicodeRange SoraSompeng =>
            SoraSompeng_Ref ?? CreateRange(ref SoraSompeng_Ref, 0x0110d0, 0x0110ff);

        private static UnicodeRange? SoraSompeng_Ref;

        public static UnicodeRange Chakma =>
            Chakma_Ref ?? CreateRange(ref Chakma_Ref, 0x011100, 0x01114f);

        private static UnicodeRange? Chakma_Ref;

        public static UnicodeRange Mahajani =>
            Mahajani_Ref ?? CreateRange(ref Mahajani_Ref, 0x011150, 0x01117f);

        private static UnicodeRange? Mahajani_Ref;

        public static UnicodeRange Sharada =>
            Sharada_Ref ?? CreateRange(ref Sharada_Ref, 0x011180, 0x0111df);

        private static UnicodeRange? Sharada_Ref;

        public static UnicodeRange SinhalaArchaicNumbers =>
            SinhalaArchaicNumbers_Ref ?? CreateRange(ref SinhalaArchaicNumbers_Ref, 0x0111e0, 0x0111ff);

        private static UnicodeRange? SinhalaArchaicNumbers_Ref;

        public static UnicodeRange Khojki =>
            Khojki_Ref ?? CreateRange(ref Khojki_Ref, 0x011200, 0x01124f);

        private static UnicodeRange? Khojki_Ref;

        public static UnicodeRange Multani =>
            Multani_Ref ?? CreateRange(ref Multani_Ref, 0x011280, 0x0112af);

        private static UnicodeRange? Multani_Ref;

        public static UnicodeRange Khudawadi =>
            Khudawadi_Ref ?? CreateRange(ref Khudawadi_Ref, 0x0112b0, 0x0112ff);

        private static UnicodeRange? Khudawadi_Ref;

        public static UnicodeRange Grantha =>
            Grantha_Ref ?? CreateRange(ref Grantha_Ref, 0x011300, 0x01137f);

        private static UnicodeRange? Grantha_Ref;

        public static UnicodeRange Newa =>
            Newa_Ref ?? CreateRange(ref Newa_Ref, 0x011400, 0x01147f);

        private static UnicodeRange? Newa_Ref;

        public static UnicodeRange Tirhuta =>
            Tirhuta_Ref ?? CreateRange(ref Tirhuta_Ref, 0x011480, 0x0114df);

        private static UnicodeRange? Tirhuta_Ref;

        public static UnicodeRange Siddham =>
            Siddham_Ref ?? CreateRange(ref Siddham_Ref, 0x011580, 0x0115ff);

        private static UnicodeRange? Siddham_Ref;

        public static UnicodeRange Modi =>
            Modi_Ref ?? CreateRange(ref Modi_Ref, 0x011600, 0x01165f);

        private static UnicodeRange? Modi_Ref;

        public static UnicodeRange MongolianSupplement =>
            MongolianSupplement_Ref ?? CreateRange(ref MongolianSupplement_Ref, 0x011660, 0x01167f);

        private static UnicodeRange? MongolianSupplement_Ref;

        public static UnicodeRange Takri =>
            Takri_Ref ?? CreateRange(ref Takri_Ref, 0x011680, 0x0116cf);

        private static UnicodeRange? Takri_Ref;

        public static UnicodeRange Ahom =>
            Ahom_Ref ?? CreateRange(ref Ahom_Ref, 0x011700, 0x01173f);

        private static UnicodeRange? Ahom_Ref;

        public static UnicodeRange Dogra =>
            Dogra_Ref ?? CreateRange(ref Dogra_Ref, 0x011800, 0x01184f);

        private static UnicodeRange? Dogra_Ref;

        public static UnicodeRange WarangCiti =>
            WarangCiti_Ref ?? CreateRange(ref WarangCiti_Ref, 0x0118a0, 0x0118ff);

        private static UnicodeRange? WarangCiti_Ref;

        public static UnicodeRange DivesAkuru =>
            DivesAkuru_Ref ?? CreateRange(ref DivesAkuru_Ref, 0x011900, 0x01195f);

        private static UnicodeRange? DivesAkuru_Ref;

        public static UnicodeRange Nandinagari =>
            Nandinagari_Ref ?? CreateRange(ref Nandinagari_Ref, 0x0119a0, 0x0119ff);

        private static UnicodeRange? Nandinagari_Ref;

        public static UnicodeRange ZanabazarSquare =>
            ZanabazarSquare_Ref ?? CreateRange(ref ZanabazarSquare_Ref, 0x011a00, 0x011a4f);

        private static UnicodeRange? ZanabazarSquare_Ref;

        public static UnicodeRange Soyombo =>
            Soyombo_Ref ?? CreateRange(ref Soyombo_Ref, 0x011a50, 0x011aaf);

        private static UnicodeRange? Soyombo_Ref;

        public static UnicodeRange PauCinHau =>
            PauCinHau_Ref ?? CreateRange(ref PauCinHau_Ref, 0x011ac0, 0x011aff);

        private static UnicodeRange? PauCinHau_Ref;

        public static UnicodeRange Bhaiksuki =>
            Bhaiksuki_Ref ?? CreateRange(ref Bhaiksuki_Ref, 0x011c00, 0x011c6f);

        private static UnicodeRange? Bhaiksuki_Ref;

        public static UnicodeRange Marchen =>
            Marchen_Ref ?? CreateRange(ref Marchen_Ref, 0x011c70, 0x011cbf);

        private static UnicodeRange? Marchen_Ref;

        public static UnicodeRange MasaramGondi =>
            MasaramGondi_Ref ?? CreateRange(ref MasaramGondi_Ref, 0x011d00, 0x011d5f);

        private static UnicodeRange? MasaramGondi_Ref;

        public static UnicodeRange GunjalaGondi =>
            GunjalaGondi_Ref ?? CreateRange(ref GunjalaGondi_Ref, 0x011d60, 0x011daf);

        private static UnicodeRange? GunjalaGondi_Ref;

        public static UnicodeRange Makasar =>
            Makasar_Ref ?? CreateRange(ref Makasar_Ref, 0x011ee0, 0x011eff);

        private static UnicodeRange? Makasar_Ref;

        public static UnicodeRange LisuSupplement =>
            LisuSupplement_Ref ?? CreateRange(ref LisuSupplement_Ref, 0x011fb0, 0x011fbf);

        private static UnicodeRange? LisuSupplement_Ref;

        public static UnicodeRange TamilSupplement =>
            TamilSupplement_Ref ?? CreateRange(ref TamilSupplement_Ref, 0x011fc0, 0x011fff);

        private static UnicodeRange? TamilSupplement_Ref;

        public static UnicodeRange Cuneiform =>
            Cuneiform_Ref ?? CreateRange(ref Cuneiform_Ref, 0x012000, 0x0123ff);

        private static UnicodeRange? Cuneiform_Ref;

        public static UnicodeRange CuneiformNumbersAndPunctuation =>
            CuneiformNumbersAndPunctuation_Ref ?? CreateRange(ref CuneiformNumbersAndPunctuation_Ref, 0x012400, 0x01247f);

        private static UnicodeRange? CuneiformNumbersAndPunctuation_Ref;

        public static UnicodeRange EarlyDynasticCuneiform =>
            EarlyDynasticCuneiform_Ref ?? CreateRange(ref EarlyDynasticCuneiform_Ref, 0x012480, 0x01254f);

        private static UnicodeRange? EarlyDynasticCuneiform_Ref;

        public static UnicodeRange EgyptianHieroglyphs =>
            EgyptianHieroglyphs_Ref ?? CreateRange(ref EgyptianHieroglyphs_Ref, 0x013000, 0x01342f);

        private static UnicodeRange? EgyptianHieroglyphs_Ref;

        public static UnicodeRange EgyptianHieroglyphFormatControls =>
            EgyptianHieroglyphFormatControls_Ref ?? CreateRange(ref EgyptianHieroglyphFormatControls_Ref, 0x013430, 0x01343f);

        private static UnicodeRange? EgyptianHieroglyphFormatControls_Ref;

        public static UnicodeRange AnatolianHieroglyphs =>
            AnatolianHieroglyphs_Ref ?? CreateRange(ref AnatolianHieroglyphs_Ref, 0x014400, 0x01467f);

        private static UnicodeRange? AnatolianHieroglyphs_Ref;

        public static UnicodeRange BamumSupplement =>
            BamumSupplement_Ref ?? CreateRange(ref BamumSupplement_Ref, 0x016800, 0x016a3f);

        private static UnicodeRange? BamumSupplement_Ref;

        public static UnicodeRange Mro =>
            Mro_Ref ?? CreateRange(ref Mro_Ref, 0x016a40, 0x016a6f);

        private static UnicodeRange? Mro_Ref;

        public static UnicodeRange BassaVah =>
            BassaVah_Ref ?? CreateRange(ref BassaVah_Ref, 0x016ad0, 0x016aff);

        private static UnicodeRange? BassaVah_Ref;

        public static UnicodeRange PahawhHmong =>
            PahawhHmong_Ref ?? CreateRange(ref PahawhHmong_Ref, 0x016b00, 0x016b8f);

        private static UnicodeRange? PahawhHmong_Ref;

        public static UnicodeRange Medefaidrin =>
            Medefaidrin_Ref ?? CreateRange(ref Medefaidrin_Ref, 0x016e40, 0x016e9f);

        private static UnicodeRange? Medefaidrin_Ref;

        public static UnicodeRange Miao =>
            Miao_Ref ?? CreateRange(ref Miao_Ref, 0x016f00, 0x016f9f);

        private static UnicodeRange? Miao_Ref;

        public static UnicodeRange IdeographicSymbolsAndPunctuation =>
            IdeographicSymbolsAndPunctuation_Ref ?? CreateRange(ref IdeographicSymbolsAndPunctuation_Ref, 0x016fe0, 0x016fff);

        private static UnicodeRange? IdeographicSymbolsAndPunctuation_Ref;

        public static UnicodeRange Tangut =>
            Tangut_Ref ?? CreateRange(ref Tangut_Ref, 0x017000, 0x0187ff);

        private static UnicodeRange? Tangut_Ref;

        public static UnicodeRange TangutComponents =>
            TangutComponents_Ref ?? CreateRange(ref TangutComponents_Ref, 0x018800, 0x018aff);

        private static UnicodeRange? TangutComponents_Ref;

        public static UnicodeRange KhitanSmallScript =>
            KhitanSmallScript_Ref ?? CreateRange(ref KhitanSmallScript_Ref, 0x018b00, 0x018cff);

        private static UnicodeRange? KhitanSmallScript_Ref;

        public static UnicodeRange TangutSupplement =>
            TangutSupplement_Ref ?? CreateRange(ref TangutSupplement_Ref, 0x018d00, 0x018d8f);

        private static UnicodeRange? TangutSupplement_Ref;

        public static UnicodeRange KanaSupplement =>
            KanaSupplement_Ref ?? CreateRange(ref KanaSupplement_Ref, 0x01b000, 0x01b0ff);

        private static UnicodeRange? KanaSupplement_Ref;

        public static UnicodeRange KanaExtended_a =>
            KanaExtended_a_Ref ?? CreateRange(ref KanaExtended_a_Ref, 0x01b100, 0x01b12f);

        private static UnicodeRange? KanaExtended_a_Ref;

        public static UnicodeRange SmallKanaExtension =>
            SmallKanaExtension_Ref ?? CreateRange(ref SmallKanaExtension_Ref, 0x01b130, 0x01b16f);

        private static UnicodeRange? SmallKanaExtension_Ref;

        public static UnicodeRange Nushu =>
            Nushu_Ref ?? CreateRange(ref Nushu_Ref, 0x01b170, 0x01b2ff);

        private static UnicodeRange? Nushu_Ref;

        public static UnicodeRange Duployan =>
            Duployan_Ref ?? CreateRange(ref Duployan_Ref, 0x01bc00, 0x01bc9f);

        private static UnicodeRange? Duployan_Ref;

        public static UnicodeRange ShorthandFormatControls =>
            ShorthandFormatControls_Ref ?? CreateRange(ref ShorthandFormatControls_Ref, 0x01bca0, 0x01bcaf);

        private static UnicodeRange? ShorthandFormatControls_Ref;

        public static UnicodeRange ByzantineMusicalSymbols =>
            ByzantineMusicalSymbols_Ref ?? CreateRange(ref ByzantineMusicalSymbols_Ref, 0x01d000, 0x01d0ff);

        private static UnicodeRange? ByzantineMusicalSymbols_Ref;

        public static UnicodeRange MusicalSymbols =>
            MusicalSymbols_Ref ?? CreateRange(ref MusicalSymbols_Ref, 0x01d100, 0x01d1ff);

        private static UnicodeRange? MusicalSymbols_Ref;

        public static UnicodeRange AncientGreekMusicalNotation =>
            AncientGreekMusicalNotation_Ref ?? CreateRange(ref AncientGreekMusicalNotation_Ref, 0x01d200, 0x01d24f);

        private static UnicodeRange? AncientGreekMusicalNotation_Ref;

        public static UnicodeRange MayanNumerals =>
            MayanNumerals_Ref ?? CreateRange(ref MayanNumerals_Ref, 0x01d2e0, 0x01d2ff);

        private static UnicodeRange? MayanNumerals_Ref;

        public static UnicodeRange TaiXuanJingSymbols =>
            TaiXuanJingSymbols_Ref ?? CreateRange(ref TaiXuanJingSymbols_Ref, 0x01d300, 0x01d35f);

        private static UnicodeRange? TaiXuanJingSymbols_Ref;

        public static UnicodeRange CountingRodNumerals =>
            CountingRodNumerals_Ref ?? CreateRange(ref CountingRodNumerals_Ref, 0x01d360, 0x01d37f);

        private static UnicodeRange? CountingRodNumerals_Ref;

        public static UnicodeRange MathematicalAlphanumericSymbols =>
            MathematicalAlphanumericSymbols_Ref ?? CreateRange(ref MathematicalAlphanumericSymbols_Ref, 0x01d400, 0x01d7ff);

        private static UnicodeRange? MathematicalAlphanumericSymbols_Ref;

        public static UnicodeRange SuttonSignwriting =>
            SuttonSignwriting_Ref ?? CreateRange(ref SuttonSignwriting_Ref, 0x01d800, 0x01daaf);

        private static UnicodeRange? SuttonSignwriting_Ref;

        public static UnicodeRange GlagoliticSupplement =>
            GlagoliticSupplement_Ref ?? CreateRange(ref GlagoliticSupplement_Ref, 0x01e000, 0x01e02f);

        private static UnicodeRange? GlagoliticSupplement_Ref;

        public static UnicodeRange NyiakengPuachueHmong =>
            NyiakengPuachueHmong_Ref ?? CreateRange(ref NyiakengPuachueHmong_Ref, 0x01e100, 0x01e14f);

        private static UnicodeRange? NyiakengPuachueHmong_Ref;

        public static UnicodeRange Wancho =>
            Wancho_Ref ?? CreateRange(ref Wancho_Ref, 0x01e2c0, 0x01e2ff);

        private static UnicodeRange? Wancho_Ref;

        public static UnicodeRange MendeKikakui =>
            MendeKikakui_Ref ?? CreateRange(ref MendeKikakui_Ref, 0x01e800, 0x01e8df);

        private static UnicodeRange? MendeKikakui_Ref;

        public static UnicodeRange Adlam =>
            Adlam_Ref ?? CreateRange(ref Adlam_Ref, 0x01e900, 0x01e95f);

        private static UnicodeRange? Adlam_Ref;

        public static UnicodeRange IndicSiyaqNumbers =>
            IndicSiyaqNumbers_Ref ?? CreateRange(ref IndicSiyaqNumbers_Ref, 0x01ec70, 0x01ecbf);

        private static UnicodeRange? IndicSiyaqNumbers_Ref;

        public static UnicodeRange OttomanSiyaqNumbers =>
            OttomanSiyaqNumbers_Ref ?? CreateRange(ref OttomanSiyaqNumbers_Ref, 0x01ed00, 0x01ed4f);

        private static UnicodeRange? OttomanSiyaqNumbers_Ref;

        public static UnicodeRange ArabicMathematicalAlphabeticSymbols =>
            ArabicMathematicalAlphabeticSymbols_Ref ?? CreateRange(ref ArabicMathematicalAlphabeticSymbols_Ref, 0x01ee00, 0x01eeff);

        private static UnicodeRange? ArabicMathematicalAlphabeticSymbols_Ref;

        public static UnicodeRange MahjongTiles =>
            MahjongTiles_Ref ?? CreateRange(ref MahjongTiles_Ref, 0x01f000, 0x01f02f);

        private static UnicodeRange? MahjongTiles_Ref;

        public static UnicodeRange DominoTiles =>
            DominoTiles_Ref ?? CreateRange(ref DominoTiles_Ref, 0x01f030, 0x01f09f);

        private static UnicodeRange? DominoTiles_Ref;

        public static UnicodeRange PlayingCards =>
            PlayingCards_Ref ?? CreateRange(ref PlayingCards_Ref, 0x01f0a0, 0x01f0ff);

        private static UnicodeRange? PlayingCards_Ref;

        public static UnicodeRange EnclosedAlphanumericSupplement =>
            EnclosedAlphanumericSupplement_Ref ?? CreateRange(ref EnclosedAlphanumericSupplement_Ref, 0x01f100, 0x01f1ff);

        private static UnicodeRange? EnclosedAlphanumericSupplement_Ref;

        public static UnicodeRange EnclosedIdeographicSupplement =>
            EnclosedIdeographicSupplement_Ref ?? CreateRange(ref EnclosedIdeographicSupplement_Ref, 0x01f200, 0x01f2ff);

        private static UnicodeRange? EnclosedIdeographicSupplement_Ref;

        public static UnicodeRange MiscellaneousSymbolsAndPictographs =>
            MiscellaneousSymbolsAndPictographs_Ref ?? CreateRange(ref MiscellaneousSymbolsAndPictographs_Ref, 0x01f300, 0x01f5ff);

        private static UnicodeRange? MiscellaneousSymbolsAndPictographs_Ref;

        public static UnicodeRange Emoticons =>
            Emoticons_Ref ?? CreateRange(ref Emoticons_Ref, 0x01f600, 0x01f64f);

        private static UnicodeRange? Emoticons_Ref;

        public static UnicodeRange OrnamentalDingbats =>
            OrnamentalDingbats_Ref ?? CreateRange(ref OrnamentalDingbats_Ref, 0x01f650, 0x01f67f);

        private static UnicodeRange? OrnamentalDingbats_Ref;

        public static UnicodeRange TransportAndMapSymbols =>
            TransportAndMapSymbols_Ref ?? CreateRange(ref TransportAndMapSymbols_Ref, 0x01f680, 0x01f6ff);

        private static UnicodeRange? TransportAndMapSymbols_Ref;

        public static UnicodeRange AlchemicalSymbols =>
            AlchemicalSymbols_Ref ?? CreateRange(ref AlchemicalSymbols_Ref, 0x01f700, 0x01f77f);

        private static UnicodeRange? AlchemicalSymbols_Ref;

        public static UnicodeRange GeometricShapesExtended =>
            GeometricShapesExtended_Ref ?? CreateRange(ref GeometricShapesExtended_Ref, 0x01f780, 0x01f7ff);

        private static UnicodeRange? GeometricShapesExtended_Ref;

        public static UnicodeRange SupplementalArrows_c =>
            SupplementalArrows_c_Ref ?? CreateRange(ref SupplementalArrows_c_Ref, 0x01f800, 0x01f8ff);

        private static UnicodeRange? SupplementalArrows_c_Ref;

        public static UnicodeRange SupplementalSymbolsAndPictographs =>
            SupplementalSymbolsAndPictographs_Ref ?? CreateRange(ref SupplementalSymbolsAndPictographs_Ref, 0x01f900, 0x01f9ff);

        private static UnicodeRange? SupplementalSymbolsAndPictographs_Ref;

        public static UnicodeRange ChessSymbols =>
            ChessSymbols_Ref ?? CreateRange(ref ChessSymbols_Ref, 0x01fa00, 0x01fa6f);

        private static UnicodeRange? ChessSymbols_Ref;

        public static UnicodeRange SymbolsAndPictographsExtended_a =>
            SymbolsAndPictographsExtended_a_Ref ?? CreateRange(ref SymbolsAndPictographsExtended_a_Ref, 0x01fa70, 0x01faff);

        private static UnicodeRange? SymbolsAndPictographsExtended_a_Ref;

        public static UnicodeRange SymbolsForLegacyComputing =>
            SymbolsForLegacyComputing_Ref ?? CreateRange(ref SymbolsForLegacyComputing_Ref, 0x01fb00, 0x01fbff);

        private static UnicodeRange? SymbolsForLegacyComputing_Ref;

        public static UnicodeRange CjkUnifiedIdeographsExtensionB =>
            CjkUnifiedIdeographsExtensionB_Ref ?? CreateRange(ref CjkUnifiedIdeographsExtensionB_Ref, 0x020000, 0x02a6df);

        private static UnicodeRange? CjkUnifiedIdeographsExtensionB_Ref;

        public static UnicodeRange CjkUnifiedIdeographsExtensionC =>
            CjkUnifiedIdeographsExtensionC_Ref ?? CreateRange(ref CjkUnifiedIdeographsExtensionC_Ref, 0x02a700, 0x02b73f);

        private static UnicodeRange? CjkUnifiedIdeographsExtensionC_Ref;

        public static UnicodeRange CjkUnifiedIdeographsExtensionD =>
            CjkUnifiedIdeographsExtensionD_Ref ?? CreateRange(ref CjkUnifiedIdeographsExtensionD_Ref, 0x02b740, 0x02b81f);

        private static UnicodeRange? CjkUnifiedIdeographsExtensionD_Ref;

        public static UnicodeRange CjkUnifiedIdeographsExtensionE =>
            CjkUnifiedIdeographsExtensionE_Ref ?? CreateRange(ref CjkUnifiedIdeographsExtensionE_Ref, 0x02b820, 0x02ceaf);

        private static UnicodeRange? CjkUnifiedIdeographsExtensionE_Ref;

        public static UnicodeRange CjkUnifiedIdeographsExtensionF =>
            CjkUnifiedIdeographsExtensionF_Ref ?? CreateRange(ref CjkUnifiedIdeographsExtensionF_Ref, 0x02ceb0, 0x02ebef);

        private static UnicodeRange? CjkUnifiedIdeographsExtensionF_Ref;

        public static UnicodeRange CjkCompatibilityIdeographsSupplement =>
            CjkCompatibilityIdeographsSupplement_Ref ?? CreateRange(ref CjkCompatibilityIdeographsSupplement_Ref, 0x02f800, 0x02fa1f);

        private static UnicodeRange? CjkCompatibilityIdeographsSupplement_Ref;

        public static UnicodeRange CjkUnifiedIdeographsExtensionG =>
            CjkUnifiedIdeographsExtensionG_Ref ?? CreateRange(ref CjkUnifiedIdeographsExtensionG_Ref, 0x030000, 0x03134f);

        private static UnicodeRange? CjkUnifiedIdeographsExtensionG_Ref;

        public static UnicodeRange Tags =>
            Tags_Ref ?? CreateRange(ref Tags_Ref, 0x0e0000, 0x0e007f);

        private static UnicodeRange? Tags_Ref;

        public static UnicodeRange VariationSelectorsSupplement =>
            VariationSelectorsSupplement_Ref ?? CreateRange(ref VariationSelectorsSupplement_Ref, 0x0e0100, 0x0e01ef);

        private static UnicodeRange? VariationSelectorsSupplement_Ref;
   }
}