﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using NPOI.OpenXmlFormats.Shared;

namespace NPOI.OpenXmlFormats.Wordprocessing
{


    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute("settings", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = false)]
    public class CT_Settings
    {

        private CT_WriteProtection writeProtectionField;

        private CT_View viewField;

        private CT_Zoom zoomField;

        private CT_OnOff removePersonalInformationField;

        private CT_OnOff removeDateAndTimeField;

        private CT_OnOff doNotDisplayPageBoundariesField;

        private CT_OnOff displayBackgroundShapeField;

        private CT_OnOff printPostScriptOverTextField;

        private CT_OnOff printFractionalCharacterWidthField;

        private CT_OnOff printFormsDataField;

        private CT_OnOff embedTrueTypeFontsField;

        private CT_OnOff embedSystemFontsField;

        private CT_OnOff saveSubsetFontsField;

        private CT_OnOff saveFormsDataField;

        private CT_OnOff mirrorMarginsField;

        private CT_OnOff alignBordersAndEdgesField;

        private CT_OnOff bordersDoNotSurroundHeaderField;

        private CT_OnOff bordersDoNotSurroundFooterField;

        private CT_OnOff gutterAtTopField;

        private CT_OnOff hideSpellingErrorsField;

        private CT_OnOff hideGrammaticalErrorsField;

        private List<CT_WritingStyle> activeWritingStyleField;

        private CT_Proof proofStateField;

        private CT_OnOff formsDesignField;

        private CT_Rel attachedTemplateField;

        private CT_OnOff linkStylesField;

        private CT_ShortHexNumber stylePaneFormatFilterField;

        private CT_ShortHexNumber stylePaneSortMethodField;

        private CT_DocType documentTypeField;

        private CT_MailMerge mailMergeField;

        private CT_TrackChangesView revisionViewField;

        private CT_OnOff trackRevisionsField;

        private CT_OnOff doNotTrackMovesField;

        private CT_OnOff doNotTrackFormattingField;

        private CT_DocProtect documentProtectionField;

        private CT_OnOff autoFormatOverrideField;

        private CT_OnOff styleLockThemeField;

        private CT_OnOff styleLockQFSetField;

        private CT_TwipsMeasure defaultTabStopField;

        private CT_OnOff autoHyphenationField;

        private CT_DecimalNumber consecutiveHyphenLimitField;

        private CT_TwipsMeasure hyphenationZoneField;

        private CT_OnOff doNotHyphenateCapsField;

        private CT_OnOff showEnvelopeField;

        private CT_DecimalNumber summaryLengthField;

        private CT_String clickAndTypeStyleField;

        private CT_String defaultTableStyleField;

        private CT_OnOff evenAndOddHeadersField;

        private CT_OnOff bookFoldRevPrintingField;

        private CT_OnOff bookFoldPrintingField;

        private CT_DecimalNumber bookFoldPrintingSheetsField;

        private CT_TwipsMeasure drawingGridHorizontalSpacingField;

        private CT_TwipsMeasure drawingGridVerticalSpacingField;

        private CT_DecimalNumber displayHorizontalDrawingGridEveryField;

        private CT_DecimalNumber displayVerticalDrawingGridEveryField;

        private CT_OnOff doNotUseMarginsForDrawingGridOriginField;

        private CT_TwipsMeasure drawingGridHorizontalOriginField;

        private CT_TwipsMeasure drawingGridVerticalOriginField;

        private CT_OnOff doNotShadeFormDataField;

        private CT_OnOff noPunctuationKerningField;

        private CT_CharacterSpacing characterSpacingControlField;

        private CT_OnOff printTwoOnOneField;

        private CT_OnOff strictFirstAndLastCharsField;

        private CT_Kinsoku noLineBreaksAfterField;

        private CT_Kinsoku noLineBreaksBeforeField;

        private CT_OnOff savePreviewPictureField;

        private CT_OnOff doNotValidateAgainstSchemaField;

        private CT_OnOff saveInvalidXmlField;

        private CT_OnOff ignoreMixedContentField;

        private CT_OnOff alwaysShowPlaceholderTextField;

        private CT_OnOff doNotDemarcateInvalidXmlField;

        private CT_OnOff saveXmlDataOnlyField;

        private CT_OnOff useXSLTWhenSavingField;

        private CT_SaveThroughXslt saveThroughXsltField;

        private CT_OnOff showXMLTagsField;

        private CT_OnOff alwaysMergeEmptyNamespaceField;

        private CT_OnOff updateFieldsField;

        private List<System.Xml.XmlElement> hdrShapeDefaultsField;

        private CT_FtnDocProps footnotePrField;

        private CT_EdnDocProps endnotePrField;

        private CT_Compat compatField;

        private List<CT_DocVar> docVarsField;

        private CT_DocRsids rsidsField;

        private CT_MathPr mathPrField;

        private CT_OnOff uiCompat97To2003Field;

        private List<CT_String> attachedSchemaField;

        private CT_Language themeFontLangField;

        private CT_ColorSchemeMapping clrSchemeMappingField;

        private CT_OnOff doNotIncludeSubdocsInStatsField;

        private CT_OnOff doNotAutoCompressPicturesField;

        private CT_Empty forceUpgradeField;

        private CT_Captions captionsField;

        private CT_ReadingModeInkLockDown readModeInkLockDownField;

        private List<CT_SmartTagType> smartTagTypeField;

        private List<CT_Schema> schemaLibraryField;

        private List<System.Xml.XmlElement> shapeDefaultsField;

        private CT_OnOff doNotEmbedSmartTagsField;

        private CT_String decimalSymbolField;

        private CT_String listSeparatorField;

        public CT_Settings()
        {
            this.listSeparatorField = new CT_String();
            this.decimalSymbolField = new CT_String();
            this.doNotEmbedSmartTagsField = new CT_OnOff();
            this.shapeDefaultsField = new List<System.Xml.XmlElement>();
            this.schemaLibraryField = new List<CT_Schema>();
            this.smartTagTypeField = new List<CT_SmartTagType>();
            this.readModeInkLockDownField = new CT_ReadingModeInkLockDown();
            this.captionsField = new CT_Captions();
            this.forceUpgradeField = new CT_Empty();
            this.doNotAutoCompressPicturesField = new CT_OnOff();
            this.doNotIncludeSubdocsInStatsField = new CT_OnOff();
            this.clrSchemeMappingField = new CT_ColorSchemeMapping();
            this.themeFontLangField = new CT_Language();
            this.attachedSchemaField = new List<CT_String>();
            this.uiCompat97To2003Field = new CT_OnOff();
            this.mathPrField = new CT_MathPr();
            this.rsidsField = new CT_DocRsids();
            this.docVarsField = new List<CT_DocVar>();
            this.compatField = new CT_Compat();
            this.endnotePrField = new CT_EdnDocProps();
            this.footnotePrField = new CT_FtnDocProps();
            this.hdrShapeDefaultsField = new List<System.Xml.XmlElement>();
            this.updateFieldsField = new CT_OnOff();
            this.alwaysMergeEmptyNamespaceField = new CT_OnOff();
            this.showXMLTagsField = new CT_OnOff();
            this.saveThroughXsltField = new CT_SaveThroughXslt();
            this.useXSLTWhenSavingField = new CT_OnOff();
            this.saveXmlDataOnlyField = new CT_OnOff();
            this.doNotDemarcateInvalidXmlField = new CT_OnOff();
            this.alwaysShowPlaceholderTextField = new CT_OnOff();
            this.ignoreMixedContentField = new CT_OnOff();
            this.saveInvalidXmlField = new CT_OnOff();
            this.doNotValidateAgainstSchemaField = new CT_OnOff();
            this.savePreviewPictureField = new CT_OnOff();
            this.noLineBreaksBeforeField = new CT_Kinsoku();
            this.noLineBreaksAfterField = new CT_Kinsoku();
            this.strictFirstAndLastCharsField = new CT_OnOff();
            this.printTwoOnOneField = new CT_OnOff();
            this.characterSpacingControlField = new CT_CharacterSpacing();
            this.noPunctuationKerningField = new CT_OnOff();
            this.doNotShadeFormDataField = new CT_OnOff();
            this.drawingGridVerticalOriginField = new CT_TwipsMeasure();
            this.drawingGridHorizontalOriginField = new CT_TwipsMeasure();
            this.doNotUseMarginsForDrawingGridOriginField = new CT_OnOff();
            this.displayVerticalDrawingGridEveryField = new CT_DecimalNumber();
            this.displayHorizontalDrawingGridEveryField = new CT_DecimalNumber();
            this.drawingGridVerticalSpacingField = new CT_TwipsMeasure();
            this.drawingGridHorizontalSpacingField = new CT_TwipsMeasure();
            this.bookFoldPrintingSheetsField = new CT_DecimalNumber();
            this.bookFoldPrintingField = new CT_OnOff();
            this.bookFoldRevPrintingField = new CT_OnOff();
            this.evenAndOddHeadersField = new CT_OnOff();
            this.defaultTableStyleField = new CT_String();
            this.clickAndTypeStyleField = new CT_String();
            this.summaryLengthField = new CT_DecimalNumber();
            this.showEnvelopeField = new CT_OnOff();
            this.doNotHyphenateCapsField = new CT_OnOff();
            this.hyphenationZoneField = new CT_TwipsMeasure();
            this.consecutiveHyphenLimitField = new CT_DecimalNumber();
            this.autoHyphenationField = new CT_OnOff();
            this.defaultTabStopField = new CT_TwipsMeasure();
            this.styleLockQFSetField = new CT_OnOff();
            this.styleLockThemeField = new CT_OnOff();
            this.autoFormatOverrideField = new CT_OnOff();
            this.documentProtectionField = new CT_DocProtect();
            this.doNotTrackFormattingField = new CT_OnOff();
            this.doNotTrackMovesField = new CT_OnOff();
            this.trackRevisionsField = new CT_OnOff();
            this.revisionViewField = new CT_TrackChangesView();
            this.mailMergeField = new CT_MailMerge();
            this.documentTypeField = new CT_DocType();
            this.stylePaneSortMethodField = new CT_ShortHexNumber();
            this.stylePaneFormatFilterField = new CT_ShortHexNumber();
            this.linkStylesField = new CT_OnOff();
            this.attachedTemplateField = new CT_Rel();
            this.formsDesignField = new CT_OnOff();
            this.proofStateField = new CT_Proof();
            this.activeWritingStyleField = new List<CT_WritingStyle>();
            this.hideGrammaticalErrorsField = new CT_OnOff();
            this.hideSpellingErrorsField = new CT_OnOff();
            this.gutterAtTopField = new CT_OnOff();
            this.bordersDoNotSurroundFooterField = new CT_OnOff();
            this.bordersDoNotSurroundHeaderField = new CT_OnOff();
            this.alignBordersAndEdgesField = new CT_OnOff();
            this.mirrorMarginsField = new CT_OnOff();
            this.saveFormsDataField = new CT_OnOff();
            this.saveSubsetFontsField = new CT_OnOff();
            this.embedSystemFontsField = new CT_OnOff();
            this.embedTrueTypeFontsField = new CT_OnOff();
            this.printFormsDataField = new CT_OnOff();
            this.printFractionalCharacterWidthField = new CT_OnOff();
            this.printPostScriptOverTextField = new CT_OnOff();
            this.displayBackgroundShapeField = new CT_OnOff();
            this.doNotDisplayPageBoundariesField = new CT_OnOff();
            this.removeDateAndTimeField = new CT_OnOff();
            this.removePersonalInformationField = new CT_OnOff();
            this.zoomField = new CT_Zoom();
            this.viewField = new CT_View();
            this.writeProtectionField = new CT_WriteProtection();
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public CT_WriteProtection writeProtection
        {
            get
            {
                return this.writeProtectionField;
            }
            set
            {
                this.writeProtectionField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public CT_View view
        {
            get
            {
                return this.viewField;
            }
            set
            {
                this.viewField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public CT_Zoom zoom
        {
            get
            {
                return this.zoomField;
            }
            set
            {
                this.zoomField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public CT_OnOff removePersonalInformation
        {
            get
            {
                return this.removePersonalInformationField;
            }
            set
            {
                this.removePersonalInformationField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public CT_OnOff removeDateAndTime
        {
            get
            {
                return this.removeDateAndTimeField;
            }
            set
            {
                this.removeDateAndTimeField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public CT_OnOff doNotDisplayPageBoundaries
        {
            get
            {
                return this.doNotDisplayPageBoundariesField;
            }
            set
            {
                this.doNotDisplayPageBoundariesField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public CT_OnOff displayBackgroundShape
        {
            get
            {
                return this.displayBackgroundShapeField;
            }
            set
            {
                this.displayBackgroundShapeField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public CT_OnOff printPostScriptOverText
        {
            get
            {
                return this.printPostScriptOverTextField;
            }
            set
            {
                this.printPostScriptOverTextField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public CT_OnOff printFractionalCharacterWidth
        {
            get
            {
                return this.printFractionalCharacterWidthField;
            }
            set
            {
                this.printFractionalCharacterWidthField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public CT_OnOff printFormsData
        {
            get
            {
                return this.printFormsDataField;
            }
            set
            {
                this.printFormsDataField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public CT_OnOff embedTrueTypeFonts
        {
            get
            {
                return this.embedTrueTypeFontsField;
            }
            set
            {
                this.embedTrueTypeFontsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public CT_OnOff embedSystemFonts
        {
            get
            {
                return this.embedSystemFontsField;
            }
            set
            {
                this.embedSystemFontsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public CT_OnOff saveSubsetFonts
        {
            get
            {
                return this.saveSubsetFontsField;
            }
            set
            {
                this.saveSubsetFontsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public CT_OnOff saveFormsData
        {
            get
            {
                return this.saveFormsDataField;
            }
            set
            {
                this.saveFormsDataField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public CT_OnOff mirrorMargins
        {
            get
            {
                return this.mirrorMarginsField;
            }
            set
            {
                this.mirrorMarginsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
        public CT_OnOff alignBordersAndEdges
        {
            get
            {
                return this.alignBordersAndEdgesField;
            }
            set
            {
                this.alignBordersAndEdgesField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 16)]
        public CT_OnOff bordersDoNotSurroundHeader
        {
            get
            {
                return this.bordersDoNotSurroundHeaderField;
            }
            set
            {
                this.bordersDoNotSurroundHeaderField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 17)]
        public CT_OnOff bordersDoNotSurroundFooter
        {
            get
            {
                return this.bordersDoNotSurroundFooterField;
            }
            set
            {
                this.bordersDoNotSurroundFooterField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 18)]
        public CT_OnOff gutterAtTop
        {
            get
            {
                return this.gutterAtTopField;
            }
            set
            {
                this.gutterAtTopField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 19)]
        public CT_OnOff hideSpellingErrors
        {
            get
            {
                return this.hideSpellingErrorsField;
            }
            set
            {
                this.hideSpellingErrorsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 20)]
        public CT_OnOff hideGrammaticalErrors
        {
            get
            {
                return this.hideGrammaticalErrorsField;
            }
            set
            {
                this.hideGrammaticalErrorsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("activeWritingStyle", Order = 21)]
        public List<CT_WritingStyle> activeWritingStyle
        {
            get
            {
                return this.activeWritingStyleField;
            }
            set
            {
                this.activeWritingStyleField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 22)]
        public CT_Proof proofState
        {
            get
            {
                return this.proofStateField;
            }
            set
            {
                this.proofStateField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 23)]
        public CT_OnOff formsDesign
        {
            get
            {
                return this.formsDesignField;
            }
            set
            {
                this.formsDesignField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 24)]
        public CT_Rel attachedTemplate
        {
            get
            {
                return this.attachedTemplateField;
            }
            set
            {
                this.attachedTemplateField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 25)]
        public CT_OnOff linkStyles
        {
            get
            {
                return this.linkStylesField;
            }
            set
            {
                this.linkStylesField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 26)]
        public CT_ShortHexNumber stylePaneFormatFilter
        {
            get
            {
                return this.stylePaneFormatFilterField;
            }
            set
            {
                this.stylePaneFormatFilterField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 27)]
        public CT_ShortHexNumber stylePaneSortMethod
        {
            get
            {
                return this.stylePaneSortMethodField;
            }
            set
            {
                this.stylePaneSortMethodField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 28)]
        public CT_DocType documentType
        {
            get
            {
                return this.documentTypeField;
            }
            set
            {
                this.documentTypeField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 29)]
        public CT_MailMerge mailMerge
        {
            get
            {
                return this.mailMergeField;
            }
            set
            {
                this.mailMergeField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 30)]
        public CT_TrackChangesView revisionView
        {
            get
            {
                return this.revisionViewField;
            }
            set
            {
                this.revisionViewField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 31)]
        public CT_OnOff trackRevisions
        {
            get
            {
                return this.trackRevisionsField;
            }
            set
            {
                this.trackRevisionsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 32)]
        public CT_OnOff doNotTrackMoves
        {
            get
            {
                return this.doNotTrackMovesField;
            }
            set
            {
                this.doNotTrackMovesField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 33)]
        public CT_OnOff doNotTrackFormatting
        {
            get
            {
                return this.doNotTrackFormattingField;
            }
            set
            {
                this.doNotTrackFormattingField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 34)]
        public CT_DocProtect documentProtection
        {
            get
            {
                return this.documentProtectionField;
            }
            set
            {
                this.documentProtectionField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 35)]
        public CT_OnOff autoFormatOverride
        {
            get
            {
                return this.autoFormatOverrideField;
            }
            set
            {
                this.autoFormatOverrideField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 36)]
        public CT_OnOff styleLockTheme
        {
            get
            {
                return this.styleLockThemeField;
            }
            set
            {
                this.styleLockThemeField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 37)]
        public CT_OnOff styleLockQFSet
        {
            get
            {
                return this.styleLockQFSetField;
            }
            set
            {
                this.styleLockQFSetField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 38)]
        public CT_TwipsMeasure defaultTabStop
        {
            get
            {
                return this.defaultTabStopField;
            }
            set
            {
                this.defaultTabStopField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 39)]
        public CT_OnOff autoHyphenation
        {
            get
            {
                return this.autoHyphenationField;
            }
            set
            {
                this.autoHyphenationField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 40)]
        public CT_DecimalNumber consecutiveHyphenLimit
        {
            get
            {
                return this.consecutiveHyphenLimitField;
            }
            set
            {
                this.consecutiveHyphenLimitField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 41)]
        public CT_TwipsMeasure hyphenationZone
        {
            get
            {
                return this.hyphenationZoneField;
            }
            set
            {
                this.hyphenationZoneField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 42)]
        public CT_OnOff doNotHyphenateCaps
        {
            get
            {
                return this.doNotHyphenateCapsField;
            }
            set
            {
                this.doNotHyphenateCapsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 43)]
        public CT_OnOff showEnvelope
        {
            get
            {
                return this.showEnvelopeField;
            }
            set
            {
                this.showEnvelopeField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 44)]
        public CT_DecimalNumber summaryLength
        {
            get
            {
                return this.summaryLengthField;
            }
            set
            {
                this.summaryLengthField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 45)]
        public CT_String clickAndTypeStyle
        {
            get
            {
                return this.clickAndTypeStyleField;
            }
            set
            {
                this.clickAndTypeStyleField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 46)]
        public CT_String defaultTableStyle
        {
            get
            {
                return this.defaultTableStyleField;
            }
            set
            {
                this.defaultTableStyleField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 47)]
        public CT_OnOff evenAndOddHeaders
        {
            get
            {
                return this.evenAndOddHeadersField;
            }
            set
            {
                this.evenAndOddHeadersField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 48)]
        public CT_OnOff bookFoldRevPrinting
        {
            get
            {
                return this.bookFoldRevPrintingField;
            }
            set
            {
                this.bookFoldRevPrintingField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 49)]
        public CT_OnOff bookFoldPrinting
        {
            get
            {
                return this.bookFoldPrintingField;
            }
            set
            {
                this.bookFoldPrintingField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 50)]
        public CT_DecimalNumber bookFoldPrintingSheets
        {
            get
            {
                return this.bookFoldPrintingSheetsField;
            }
            set
            {
                this.bookFoldPrintingSheetsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 51)]
        public CT_TwipsMeasure drawingGridHorizontalSpacing
        {
            get
            {
                return this.drawingGridHorizontalSpacingField;
            }
            set
            {
                this.drawingGridHorizontalSpacingField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 52)]
        public CT_TwipsMeasure drawingGridVerticalSpacing
        {
            get
            {
                return this.drawingGridVerticalSpacingField;
            }
            set
            {
                this.drawingGridVerticalSpacingField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 53)]
        public CT_DecimalNumber displayHorizontalDrawingGridEvery
        {
            get
            {
                return this.displayHorizontalDrawingGridEveryField;
            }
            set
            {
                this.displayHorizontalDrawingGridEveryField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 54)]
        public CT_DecimalNumber displayVerticalDrawingGridEvery
        {
            get
            {
                return this.displayVerticalDrawingGridEveryField;
            }
            set
            {
                this.displayVerticalDrawingGridEveryField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 55)]
        public CT_OnOff doNotUseMarginsForDrawingGridOrigin
        {
            get
            {
                return this.doNotUseMarginsForDrawingGridOriginField;
            }
            set
            {
                this.doNotUseMarginsForDrawingGridOriginField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 56)]
        public CT_TwipsMeasure drawingGridHorizontalOrigin
        {
            get
            {
                return this.drawingGridHorizontalOriginField;
            }
            set
            {
                this.drawingGridHorizontalOriginField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 57)]
        public CT_TwipsMeasure drawingGridVerticalOrigin
        {
            get
            {
                return this.drawingGridVerticalOriginField;
            }
            set
            {
                this.drawingGridVerticalOriginField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 58)]
        public CT_OnOff doNotShadeFormData
        {
            get
            {
                return this.doNotShadeFormDataField;
            }
            set
            {
                this.doNotShadeFormDataField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 59)]
        public CT_OnOff noPunctuationKerning
        {
            get
            {
                return this.noPunctuationKerningField;
            }
            set
            {
                this.noPunctuationKerningField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 60)]
        public CT_CharacterSpacing characterSpacingControl
        {
            get
            {
                return this.characterSpacingControlField;
            }
            set
            {
                this.characterSpacingControlField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 61)]
        public CT_OnOff printTwoOnOne
        {
            get
            {
                return this.printTwoOnOneField;
            }
            set
            {
                this.printTwoOnOneField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 62)]
        public CT_OnOff strictFirstAndLastChars
        {
            get
            {
                return this.strictFirstAndLastCharsField;
            }
            set
            {
                this.strictFirstAndLastCharsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 63)]
        public CT_Kinsoku noLineBreaksAfter
        {
            get
            {
                return this.noLineBreaksAfterField;
            }
            set
            {
                this.noLineBreaksAfterField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 64)]
        public CT_Kinsoku noLineBreaksBefore
        {
            get
            {
                return this.noLineBreaksBeforeField;
            }
            set
            {
                this.noLineBreaksBeforeField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 65)]
        public CT_OnOff savePreviewPicture
        {
            get
            {
                return this.savePreviewPictureField;
            }
            set
            {
                this.savePreviewPictureField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 66)]
        public CT_OnOff doNotValidateAgainstSchema
        {
            get
            {
                return this.doNotValidateAgainstSchemaField;
            }
            set
            {
                this.doNotValidateAgainstSchemaField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 67)]
        public CT_OnOff saveInvalidXml
        {
            get
            {
                return this.saveInvalidXmlField;
            }
            set
            {
                this.saveInvalidXmlField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 68)]
        public CT_OnOff ignoreMixedContent
        {
            get
            {
                return this.ignoreMixedContentField;
            }
            set
            {
                this.ignoreMixedContentField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 69)]
        public CT_OnOff alwaysShowPlaceholderText
        {
            get
            {
                return this.alwaysShowPlaceholderTextField;
            }
            set
            {
                this.alwaysShowPlaceholderTextField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 70)]
        public CT_OnOff doNotDemarcateInvalidXml
        {
            get
            {
                return this.doNotDemarcateInvalidXmlField;
            }
            set
            {
                this.doNotDemarcateInvalidXmlField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 71)]
        public CT_OnOff saveXmlDataOnly
        {
            get
            {
                return this.saveXmlDataOnlyField;
            }
            set
            {
                this.saveXmlDataOnlyField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 72)]
        public CT_OnOff useXSLTWhenSaving
        {
            get
            {
                return this.useXSLTWhenSavingField;
            }
            set
            {
                this.useXSLTWhenSavingField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 73)]
        public CT_SaveThroughXslt saveThroughXslt
        {
            get
            {
                return this.saveThroughXsltField;
            }
            set
            {
                this.saveThroughXsltField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 74)]
        public CT_OnOff showXMLTags
        {
            get
            {
                return this.showXMLTagsField;
            }
            set
            {
                this.showXMLTagsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 75)]
        public CT_OnOff alwaysMergeEmptyNamespace
        {
            get
            {
                return this.alwaysMergeEmptyNamespaceField;
            }
            set
            {
                this.alwaysMergeEmptyNamespaceField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 76)]
        public CT_OnOff updateFields
        {
            get
            {
                return this.updateFieldsField;
            }
            set
            {
                this.updateFieldsField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayAttribute(Order = 77)]
        [System.Xml.Serialization.XmlArrayItemAttribute("", Namespace = "urn:schemas-microsoft-com:office:office", IsNullable = false)]
        public List<System.Xml.XmlElement> hdrShapeDefaults
        {
            get
            {
                return this.hdrShapeDefaultsField;
            }
            set
            {
                this.hdrShapeDefaultsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 78)]
        public CT_FtnDocProps footnotePr
        {
            get
            {
                return this.footnotePrField;
            }
            set
            {
                this.footnotePrField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 79)]
        public CT_EdnDocProps endnotePr
        {
            get
            {
                return this.endnotePrField;
            }
            set
            {
                this.endnotePrField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 80)]
        public CT_Compat compat
        {
            get
            {
                return this.compatField;
            }
            set
            {
                this.compatField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayAttribute(Order = 81)]
        [System.Xml.Serialization.XmlArrayItemAttribute("docVar", IsNullable = false)]
        public List<CT_DocVar> docVars
        {
            get
            {
                return this.docVarsField;
            }
            set
            {
                this.docVarsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 82)]
        public CT_DocRsids rsids
        {
            get
            {
                return this.rsidsField;
            }
            set
            {
                this.rsidsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", Order = 83)]
        public CT_MathPr mathPr
        {
            get
            {
                return this.mathPrField;
            }
            set
            {
                this.mathPrField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 84)]
        public CT_OnOff uiCompat97To2003
        {
            get
            {
                return this.uiCompat97To2003Field;
            }
            set
            {
                this.uiCompat97To2003Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("attachedSchema", Order = 85)]
        public List<CT_String> attachedSchema
        {
            get
            {
                return this.attachedSchemaField;
            }
            set
            {
                this.attachedSchemaField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 86)]
        public CT_Language themeFontLang
        {
            get
            {
                return this.themeFontLangField;
            }
            set
            {
                this.themeFontLangField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 87)]
        public CT_ColorSchemeMapping clrSchemeMapping
        {
            get
            {
                return this.clrSchemeMappingField;
            }
            set
            {
                this.clrSchemeMappingField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 88)]
        public CT_OnOff doNotIncludeSubdocsInStats
        {
            get
            {
                return this.doNotIncludeSubdocsInStatsField;
            }
            set
            {
                this.doNotIncludeSubdocsInStatsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 89)]
        public CT_OnOff doNotAutoCompressPictures
        {
            get
            {
                return this.doNotAutoCompressPicturesField;
            }
            set
            {
                this.doNotAutoCompressPicturesField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 90)]
        public CT_Empty forceUpgrade
        {
            get
            {
                return this.forceUpgradeField;
            }
            set
            {
                this.forceUpgradeField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 91)]
        public CT_Captions captions
        {
            get
            {
                return this.captionsField;
            }
            set
            {
                this.captionsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 92)]
        public CT_ReadingModeInkLockDown readModeInkLockDown
        {
            get
            {
                return this.readModeInkLockDownField;
            }
            set
            {
                this.readModeInkLockDownField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("smartTagType", Order = 93)]
        public List<CT_SmartTagType> smartTagType
        {
            get
            {
                return this.smartTagTypeField;
            }
            set
            {
                this.smartTagTypeField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayAttribute(Namespace = "http://schemas.openxmlformats.org/schemaLibrary/2006/main", Order = 94)]
        [System.Xml.Serialization.XmlArrayItemAttribute("schema", IsNullable = false)]
        public List<CT_Schema> schemaLibrary
        {
            get
            {
                return this.schemaLibraryField;
            }
            set
            {
                this.schemaLibraryField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayAttribute(Order = 95)]
        [System.Xml.Serialization.XmlArrayItemAttribute("", Namespace = "urn:schemas-microsoft-com:office:office", IsNullable = false)]
        public List<System.Xml.XmlElement> shapeDefaults
        {
            get
            {
                return this.shapeDefaultsField;
            }
            set
            {
                this.shapeDefaultsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 96)]
        public CT_OnOff doNotEmbedSmartTags
        {
            get
            {
                return this.doNotEmbedSmartTagsField;
            }
            set
            {
                this.doNotEmbedSmartTagsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 97)]
        public CT_String decimalSymbol
        {
            get
            {
                return this.decimalSymbolField;
            }
            set
            {
                this.decimalSymbolField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 98)]
        public CT_String listSeparator
        {
            get
            {
                return this.listSeparatorField;
            }
            set
            {
                this.listSeparatorField = value;
            }
        }
    }


    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_WriteProtection
    {

        private ST_OnOff recommendedField;

        private bool recommendedFieldSpecified;

        private ST_CryptProv cryptProviderTypeField;

        private bool cryptProviderTypeFieldSpecified;

        private ST_AlgClass cryptAlgorithmClassField;

        private bool cryptAlgorithmClassFieldSpecified;

        private ST_AlgType cryptAlgorithmTypeField;

        private bool cryptAlgorithmTypeFieldSpecified;

        private string cryptAlgorithmSidField;

        private string cryptSpinCountField;

        private string cryptProviderField;

        private byte[] algIdExtField;

        private string algIdExtSourceField;

        private byte[] cryptProviderTypeExtField;

        private string cryptProviderTypeExtSourceField;

        private byte[] hashField;

        private byte[] saltField;

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_OnOff recommended
        {
            get
            {
                return this.recommendedField;
            }
            set
            {
                this.recommendedField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool recommendedSpecified
        {
            get
            {
                return this.recommendedFieldSpecified;
            }
            set
            {
                this.recommendedFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_CryptProv cryptProviderType
        {
            get
            {
                return this.cryptProviderTypeField;
            }
            set
            {
                this.cryptProviderTypeField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cryptProviderTypeSpecified
        {
            get
            {
                return this.cryptProviderTypeFieldSpecified;
            }
            set
            {
                this.cryptProviderTypeFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_AlgClass cryptAlgorithmClass
        {
            get
            {
                return this.cryptAlgorithmClassField;
            }
            set
            {
                this.cryptAlgorithmClassField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cryptAlgorithmClassSpecified
        {
            get
            {
                return this.cryptAlgorithmClassFieldSpecified;
            }
            set
            {
                this.cryptAlgorithmClassFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_AlgType cryptAlgorithmType
        {
            get
            {
                return this.cryptAlgorithmTypeField;
            }
            set
            {
                this.cryptAlgorithmTypeField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cryptAlgorithmTypeSpecified
        {
            get
            {
                return this.cryptAlgorithmTypeFieldSpecified;
            }
            set
            {
                this.cryptAlgorithmTypeFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
        public string cryptAlgorithmSid
        {
            get
            {
                return this.cryptAlgorithmSidField;
            }
            set
            {
                this.cryptAlgorithmSidField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
        public string cryptSpinCount
        {
            get
            {
                return this.cryptSpinCountField;
            }
            set
            {
                this.cryptSpinCountField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string cryptProvider
        {
            get
            {
                return this.cryptProviderField;
            }
            set
            {
                this.cryptProviderField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "hexBinary")]
        public byte[] algIdExt
        {
            get
            {
                return this.algIdExtField;
            }
            set
            {
                this.algIdExtField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string algIdExtSource
        {
            get
            {
                return this.algIdExtSourceField;
            }
            set
            {
                this.algIdExtSourceField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "hexBinary")]
        public byte[] cryptProviderTypeExt
        {
            get
            {
                return this.cryptProviderTypeExtField;
            }
            set
            {
                this.cryptProviderTypeExtField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string cryptProviderTypeExtSource
        {
            get
            {
                return this.cryptProviderTypeExtSourceField;
            }
            set
            {
                this.cryptProviderTypeExtSourceField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "base64Binary")]
        public byte[] hash
        {
            get
            {
                return this.hashField;
            }
            set
            {
                this.hashField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "base64Binary")]
        public byte[] salt
        {
            get
            {
                return this.saltField;
            }
            set
            {
                this.saltField = value;
            }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    public enum ST_CryptProv
    {

        /// <remarks/>
        rsaAES,

        /// <remarks/>
        rsaFull,
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    public enum ST_AlgClass
    {

        /// <remarks/>
        hash,
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    public enum ST_AlgType
    {

        /// <remarks/>
        typeAny,
    }


    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_View
    {

        private ST_View valField;

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_View val
        {
            get
            {
                return this.valField;
            }
            set
            {
                this.valField = value;
            }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    public enum ST_View
    {

        /// <remarks/>
        none,

        /// <remarks/>
        print,

        /// <remarks/>
        outline,

        /// <remarks/>
        masterPages,

        /// <remarks/>
        normal,

        /// <remarks/>
        web,
    }


    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_Zoom
    {

        private ST_Zoom valField;

        private bool valFieldSpecified;

        private string percentField;

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_Zoom val
        {
            get
            {
                return this.valField;
            }
            set
            {
                this.valField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool valSpecified
        {
            get
            {
                return this.valFieldSpecified;
            }
            set
            {
                this.valFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
        public string percent
        {
            get
            {
                return this.percentField;
            }
            set
            {
                this.percentField = value;
            }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    public enum ST_Zoom
    {

        /// <remarks/>
        none,

        /// <remarks/>
        fullPage,

        /// <remarks/>
        bestFit,

        /// <remarks/>
        textFit,
    }


    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_WritingStyle
    {

        private string langField;

        private string vendorIDField;

        private string dllVersionField;

        private ST_OnOff nlCheckField;

        private bool nlCheckFieldSpecified;

        private ST_OnOff checkStyleField;

        private string appNameField;

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
        public string vendorID
        {
            get
            {
                return this.vendorIDField;
            }
            set
            {
                this.vendorIDField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
        public string dllVersion
        {
            get
            {
                return this.dllVersionField;
            }
            set
            {
                this.dllVersionField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_OnOff nlCheck
        {
            get
            {
                return this.nlCheckField;
            }
            set
            {
                this.nlCheckField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool nlCheckSpecified
        {
            get
            {
                return this.nlCheckFieldSpecified;
            }
            set
            {
                this.nlCheckFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_OnOff checkStyle
        {
            get
            {
                return this.checkStyleField;
            }
            set
            {
                this.checkStyleField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string appName
        {
            get
            {
                return this.appNameField;
            }
            set
            {
                this.appNameField = value;
            }
        }
    }


    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_Proof
    {

        private ST_Proof spellingField;

        private bool spellingFieldSpecified;

        private ST_Proof grammarField;

        private bool grammarFieldSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_Proof spelling
        {
            get
            {
                return this.spellingField;
            }
            set
            {
                this.spellingField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool spellingSpecified
        {
            get
            {
                return this.spellingFieldSpecified;
            }
            set
            {
                this.spellingFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_Proof grammar
        {
            get
            {
                return this.grammarField;
            }
            set
            {
                this.grammarField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool grammarSpecified
        {
            get
            {
                return this.grammarFieldSpecified;
            }
            set
            {
                this.grammarFieldSpecified = value;
            }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    public enum ST_Proof
    {

        /// <remarks/>
        clean,

        /// <remarks/>
        dirty,
    }


    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_DocType
    {

        private ST_DocType valField;

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_DocType val
        {
            get
            {
                return this.valField;
            }
            set
            {
                this.valField = value;
            }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    public enum ST_DocType
    {

        /// <remarks/>
        notSpecified,

        /// <remarks/>
        letter,

        /// <remarks/>
        eMail,
    }


    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_MailMerge
    {

        private CT_MailMergeDocType mainDocumentTypeField;

        private CT_OnOff linkToQueryField;

        private CT_MailMergeDataType dataTypeField;

        private CT_String connectStringField;

        private CT_String queryField;

        private CT_Rel dataSourceField;

        private CT_Rel headerSourceField;

        private CT_OnOff doNotSuppressBlankLinesField;

        private CT_MailMergeDest destinationField;

        private CT_String addressFieldNameField;

        private CT_String mailSubjectField;

        private CT_OnOff mailAsAttachmentField;

        private CT_OnOff viewMergedDataField;

        private CT_DecimalNumber activeRecordField;

        private CT_DecimalNumber checkErrorsField;

        private CT_Odso odsoField;

        public CT_MailMerge()
        {
            this.odsoField = new CT_Odso();
            this.checkErrorsField = new CT_DecimalNumber();
            this.activeRecordField = new CT_DecimalNumber();
            this.viewMergedDataField = new CT_OnOff();
            this.mailAsAttachmentField = new CT_OnOff();
            this.mailSubjectField = new CT_String();
            this.addressFieldNameField = new CT_String();
            this.destinationField = new CT_MailMergeDest();
            this.doNotSuppressBlankLinesField = new CT_OnOff();
            this.headerSourceField = new CT_Rel();
            this.dataSourceField = new CT_Rel();
            this.queryField = new CT_String();
            this.connectStringField = new CT_String();
            this.dataTypeField = new CT_MailMergeDataType();
            this.linkToQueryField = new CT_OnOff();
            this.mainDocumentTypeField = new CT_MailMergeDocType();
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public CT_MailMergeDocType mainDocumentType
        {
            get
            {
                return this.mainDocumentTypeField;
            }
            set
            {
                this.mainDocumentTypeField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public CT_OnOff linkToQuery
        {
            get
            {
                return this.linkToQueryField;
            }
            set
            {
                this.linkToQueryField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public CT_MailMergeDataType dataType
        {
            get
            {
                return this.dataTypeField;
            }
            set
            {
                this.dataTypeField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public CT_String connectString
        {
            get
            {
                return this.connectStringField;
            }
            set
            {
                this.connectStringField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public CT_String query
        {
            get
            {
                return this.queryField;
            }
            set
            {
                this.queryField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public CT_Rel dataSource
        {
            get
            {
                return this.dataSourceField;
            }
            set
            {
                this.dataSourceField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public CT_Rel headerSource
        {
            get
            {
                return this.headerSourceField;
            }
            set
            {
                this.headerSourceField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public CT_OnOff doNotSuppressBlankLines
        {
            get
            {
                return this.doNotSuppressBlankLinesField;
            }
            set
            {
                this.doNotSuppressBlankLinesField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public CT_MailMergeDest destination
        {
            get
            {
                return this.destinationField;
            }
            set
            {
                this.destinationField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public CT_String addressFieldName
        {
            get
            {
                return this.addressFieldNameField;
            }
            set
            {
                this.addressFieldNameField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public CT_String mailSubject
        {
            get
            {
                return this.mailSubjectField;
            }
            set
            {
                this.mailSubjectField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public CT_OnOff mailAsAttachment
        {
            get
            {
                return this.mailAsAttachmentField;
            }
            set
            {
                this.mailAsAttachmentField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public CT_OnOff viewMergedData
        {
            get
            {
                return this.viewMergedDataField;
            }
            set
            {
                this.viewMergedDataField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public CT_DecimalNumber activeRecord
        {
            get
            {
                return this.activeRecordField;
            }
            set
            {
                this.activeRecordField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public CT_DecimalNumber checkErrors
        {
            get
            {
                return this.checkErrorsField;
            }
            set
            {
                this.checkErrorsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
        public CT_Odso odso
        {
            get
            {
                return this.odsoField;
            }
            set
            {
                this.odsoField = value;
            }
        }
    }


    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_MailMergeDocType
    {

        private ST_MailMergeDocType valField;

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_MailMergeDocType val
        {
            get
            {
                return this.valField;
            }
            set
            {
                this.valField = value;
            }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    public enum ST_MailMergeDocType
    {

        /// <remarks/>
        catalog,

        /// <remarks/>
        envelopes,

        /// <remarks/>
        mailingLabels,

        /// <remarks/>
        formLetters,

        /// <remarks/>
        email,

        /// <remarks/>
        fax,
    }


    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_MailMergeDataType
    {

        private ST_MailMergeDataType valField;

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_MailMergeDataType val
        {
            get
            {
                return this.valField;
            }
            set
            {
                this.valField = value;
            }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    public enum ST_MailMergeDataType
    {

        /// <remarks/>
        textFile,

        /// <remarks/>
        database,

        /// <remarks/>
        spreadsheet,

        /// <remarks/>
        query,

        /// <remarks/>
        odbc,

        /// <remarks/>
        native,
    }


    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_MailMergeDest
    {

        private ST_MailMergeDest valField;

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_MailMergeDest val
        {
            get
            {
                return this.valField;
            }
            set
            {
                this.valField = value;
            }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    public enum ST_MailMergeDest
    {

        /// <remarks/>
        newDocument,

        /// <remarks/>
        printer,

        /// <remarks/>
        email,

        /// <remarks/>
        fax,
    }


    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_Odso
    {

        private CT_String udlField;

        private CT_String tableField;

        private CT_Rel srcField;

        private CT_DecimalNumber colDelimField;

        private CT_MailMergeSourceType typeField;

        private CT_OnOff fHdrField;

        private List<CT_OdsoFieldMapData> fieldMapDataField;

        private List<CT_Rel> recipientDataField;

        public CT_Odso()
        {
            this.recipientDataField = new List<CT_Rel>();
            this.fieldMapDataField = new List<CT_OdsoFieldMapData>();
            this.fHdrField = new CT_OnOff();
            this.typeField = new CT_MailMergeSourceType();
            this.colDelimField = new CT_DecimalNumber();
            this.srcField = new CT_Rel();
            this.tableField = new CT_String();
            this.udlField = new CT_String();
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public CT_String udl
        {
            get
            {
                return this.udlField;
            }
            set
            {
                this.udlField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public CT_String table
        {
            get
            {
                return this.tableField;
            }
            set
            {
                this.tableField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public CT_Rel src
        {
            get
            {
                return this.srcField;
            }
            set
            {
                this.srcField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public CT_DecimalNumber colDelim
        {
            get
            {
                return this.colDelimField;
            }
            set
            {
                this.colDelimField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public CT_MailMergeSourceType type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public CT_OnOff fHdr
        {
            get
            {
                return this.fHdrField;
            }
            set
            {
                this.fHdrField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("fieldMapData", Order = 6)]
        public List<CT_OdsoFieldMapData> fieldMapData
        {
            get
            {
                return this.fieldMapDataField;
            }
            set
            {
                this.fieldMapDataField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("recipientData", Order = 7)]
        public List<CT_Rel> recipientData
        {
            get
            {
                return this.recipientDataField;
            }
            set
            {
                this.recipientDataField = value;
            }
        }
    }


    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_MailMergeSourceType
    {

        private ST_MailMergeSourceType valField;

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_MailMergeSourceType val
        {
            get
            {
                return this.valField;
            }
            set
            {
                this.valField = value;
            }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    public enum ST_MailMergeSourceType
    {

        /// <remarks/>
        database,

        /// <remarks/>
        addressBook,

        /// <remarks/>
        document1,

        /// <remarks/>
        document2,

        /// <remarks/>
        text,

        /// <remarks/>
        email,

        /// <remarks/>
        native,

        /// <remarks/>
        legacy,

        /// <remarks/>
        master,
    }


    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_OdsoFieldMapData
    {

        private CT_MailMergeOdsoFMDFieldType typeField;

        private CT_String nameField;

        private CT_String mappedNameField;

        private CT_DecimalNumber columnField;

        private CT_Lang lidField;

        private CT_OnOff dynamicAddressField;

        public CT_OdsoFieldMapData()
        {
            this.dynamicAddressField = new CT_OnOff();
            this.lidField = new CT_Lang();
            this.columnField = new CT_DecimalNumber();
            this.mappedNameField = new CT_String();
            this.nameField = new CT_String();
            this.typeField = new CT_MailMergeOdsoFMDFieldType();
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public CT_MailMergeOdsoFMDFieldType type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public CT_String name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public CT_String mappedName
        {
            get
            {
                return this.mappedNameField;
            }
            set
            {
                this.mappedNameField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public CT_DecimalNumber column
        {
            get
            {
                return this.columnField;
            }
            set
            {
                this.columnField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public CT_Lang lid
        {
            get
            {
                return this.lidField;
            }
            set
            {
                this.lidField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public CT_OnOff dynamicAddress
        {
            get
            {
                return this.dynamicAddressField;
            }
            set
            {
                this.dynamicAddressField = value;
            }
        }
    }


    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_MailMergeOdsoFMDFieldType
    {

        private ST_MailMergeOdsoFMDFieldType valField;

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_MailMergeOdsoFMDFieldType val
        {
            get
            {
                return this.valField;
            }
            set
            {
                this.valField = value;
            }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    public enum ST_MailMergeOdsoFMDFieldType
    {

        /// <remarks/>
        @null,

        /// <remarks/>
        dbColumn,
    }





    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_TrackChangesView
    {

        private ST_OnOff markupField;

        private bool markupFieldSpecified;

        private ST_OnOff commentsField;

        private bool commentsFieldSpecified;

        private ST_OnOff insDelField;

        private bool insDelFieldSpecified;

        private ST_OnOff formattingField;

        private bool formattingFieldSpecified;

        private ST_OnOff inkAnnotationsField;

        private bool inkAnnotationsFieldSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_OnOff markup
        {
            get
            {
                return this.markupField;
            }
            set
            {
                this.markupField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool markupSpecified
        {
            get
            {
                return this.markupFieldSpecified;
            }
            set
            {
                this.markupFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_OnOff comments
        {
            get
            {
                return this.commentsField;
            }
            set
            {
                this.commentsField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool commentsSpecified
        {
            get
            {
                return this.commentsFieldSpecified;
            }
            set
            {
                this.commentsFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_OnOff insDel
        {
            get
            {
                return this.insDelField;
            }
            set
            {
                this.insDelField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool insDelSpecified
        {
            get
            {
                return this.insDelFieldSpecified;
            }
            set
            {
                this.insDelFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_OnOff formatting
        {
            get
            {
                return this.formattingField;
            }
            set
            {
                this.formattingField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool formattingSpecified
        {
            get
            {
                return this.formattingFieldSpecified;
            }
            set
            {
                this.formattingFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_OnOff inkAnnotations
        {
            get
            {
                return this.inkAnnotationsField;
            }
            set
            {
                this.inkAnnotationsField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool inkAnnotationsSpecified
        {
            get
            {
                return this.inkAnnotationsFieldSpecified;
            }
            set
            {
                this.inkAnnotationsFieldSpecified = value;
            }
        }
    }


    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_DocProtect
    {

        private ST_DocProtect editField;

        private bool editFieldSpecified;

        private ST_OnOff formattingField;

        private bool formattingFieldSpecified;

        private ST_OnOff enforcementField;

        private bool enforcementFieldSpecified;

        private ST_CryptProv cryptProviderTypeField;

        private bool cryptProviderTypeFieldSpecified;

        private ST_AlgClass cryptAlgorithmClassField;

        private bool cryptAlgorithmClassFieldSpecified;

        private ST_AlgType cryptAlgorithmTypeField;

        private bool cryptAlgorithmTypeFieldSpecified;

        private string cryptAlgorithmSidField;

        private string cryptSpinCountField;

        private string cryptProviderField;

        private byte[] algIdExtField;

        private string algIdExtSourceField;

        private byte[] cryptProviderTypeExtField;

        private string cryptProviderTypeExtSourceField;

        private byte[] hashField;

        private byte[] saltField;

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_DocProtect edit
        {
            get
            {
                return this.editField;
            }
            set
            {
                this.editField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool editSpecified
        {
            get
            {
                return this.editFieldSpecified;
            }
            set
            {
                this.editFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_OnOff formatting
        {
            get
            {
                return this.formattingField;
            }
            set
            {
                this.formattingField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool formattingSpecified
        {
            get
            {
                return this.formattingFieldSpecified;
            }
            set
            {
                this.formattingFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_OnOff enforcement
        {
            get
            {
                return this.enforcementField;
            }
            set
            {
                this.enforcementField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool enforcementSpecified
        {
            get
            {
                return this.enforcementFieldSpecified;
            }
            set
            {
                this.enforcementFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_CryptProv cryptProviderType
        {
            get
            {
                return this.cryptProviderTypeField;
            }
            set
            {
                this.cryptProviderTypeField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cryptProviderTypeSpecified
        {
            get
            {
                return this.cryptProviderTypeFieldSpecified;
            }
            set
            {
                this.cryptProviderTypeFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_AlgClass cryptAlgorithmClass
        {
            get
            {
                return this.cryptAlgorithmClassField;
            }
            set
            {
                this.cryptAlgorithmClassField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cryptAlgorithmClassSpecified
        {
            get
            {
                return this.cryptAlgorithmClassFieldSpecified;
            }
            set
            {
                this.cryptAlgorithmClassFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_AlgType cryptAlgorithmType
        {
            get
            {
                return this.cryptAlgorithmTypeField;
            }
            set
            {
                this.cryptAlgorithmTypeField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cryptAlgorithmTypeSpecified
        {
            get
            {
                return this.cryptAlgorithmTypeFieldSpecified;
            }
            set
            {
                this.cryptAlgorithmTypeFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
        public string cryptAlgorithmSid
        {
            get
            {
                return this.cryptAlgorithmSidField;
            }
            set
            {
                this.cryptAlgorithmSidField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
        public string cryptSpinCount
        {
            get
            {
                return this.cryptSpinCountField;
            }
            set
            {
                this.cryptSpinCountField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string cryptProvider
        {
            get
            {
                return this.cryptProviderField;
            }
            set
            {
                this.cryptProviderField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "hexBinary")]
        public byte[] algIdExt
        {
            get
            {
                return this.algIdExtField;
            }
            set
            {
                this.algIdExtField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string algIdExtSource
        {
            get
            {
                return this.algIdExtSourceField;
            }
            set
            {
                this.algIdExtSourceField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "hexBinary")]
        public byte[] cryptProviderTypeExt
        {
            get
            {
                return this.cryptProviderTypeExtField;
            }
            set
            {
                this.cryptProviderTypeExtField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string cryptProviderTypeExtSource
        {
            get
            {
                return this.cryptProviderTypeExtSourceField;
            }
            set
            {
                this.cryptProviderTypeExtSourceField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "base64Binary")]
        public byte[] hash
        {
            get
            {
                return this.hashField;
            }
            set
            {
                this.hashField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "base64Binary")]
        public byte[] salt
        {
            get
            {
                return this.saltField;
            }
            set
            {
                this.saltField = value;
            }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    public enum ST_DocProtect
    {

        /// <remarks/>
        none,

        /// <remarks/>
        readOnly,

        /// <remarks/>
        comments,

        /// <remarks/>
        trackedChanges,

        /// <remarks/>
        forms,
    }




    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_CharacterSpacing
    {

        private ST_CharacterSpacing valField;

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_CharacterSpacing val
        {
            get
            {
                return this.valField;
            }
            set
            {
                this.valField = value;
            }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    public enum ST_CharacterSpacing
    {

        /// <remarks/>
        doNotCompress,

        /// <remarks/>
        compressPunctuation,

        /// <remarks/>
        compressPunctuationAndJapaneseKana,
    }


    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_Kinsoku
    {

        private string langField;

        private string valField;

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string val
        {
            get
            {
                return this.valField;
            }
            set
            {
                this.valField = value;
            }
        }
    }


    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_SaveThroughXslt
    {

        private string idField;

        private string solutionIDField;

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/relationships")]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string solutionID
        {
            get
            {
                return this.solutionIDField;
            }
            set
            {
                this.solutionIDField = value;
            }
        }
    }


    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_Compat
    {

        private CT_OnOff useSingleBorderforContiguousCellsField;

        private CT_OnOff wpJustificationField;

        private CT_OnOff noTabHangIndField;

        private CT_OnOff noLeadingField;

        private CT_OnOff spaceForULField;

        private CT_OnOff noColumnBalanceField;

        private CT_OnOff balanceSingleByteDoubleByteWidthField;

        private CT_OnOff noExtraLineSpacingField;

        private CT_OnOff doNotLeaveBackslashAloneField;

        private CT_OnOff ulTrailSpaceField;

        private CT_OnOff doNotExpandShiftReturnField;

        private CT_OnOff spacingInWholePointsField;

        private CT_OnOff lineWrapLikeWord6Field;

        private CT_OnOff printBodyTextBeforeHeaderField;

        private CT_OnOff printColBlackField;

        private CT_OnOff wpSpaceWidthField;

        private CT_OnOff showBreaksInFramesField;

        private CT_OnOff subFontBySizeField;

        private CT_OnOff suppressBottomSpacingField;

        private CT_OnOff suppressTopSpacingField;

        private CT_OnOff suppressSpacingAtTopOfPageField;

        private CT_OnOff suppressTopSpacingWPField;

        private CT_OnOff suppressSpBfAfterPgBrkField;

        private CT_OnOff swapBordersFacingPagesField;

        private CT_OnOff convMailMergeEscField;

        private CT_OnOff truncateFontHeightsLikeWP6Field;

        private CT_OnOff mwSmallCapsField;

        private CT_OnOff usePrinterMetricsField;

        private CT_OnOff doNotSuppressParagraphBordersField;

        private CT_OnOff wrapTrailSpacesField;

        private CT_OnOff footnoteLayoutLikeWW8Field;

        private CT_OnOff shapeLayoutLikeWW8Field;

        private CT_OnOff alignTablesRowByRowField;

        private CT_OnOff forgetLastTabAlignmentField;

        private CT_OnOff adjustLineHeightInTableField;

        private CT_OnOff autoSpaceLikeWord95Field;

        private CT_OnOff noSpaceRaiseLowerField;

        private CT_OnOff doNotUseHTMLParagraphAutoSpacingField;

        private CT_OnOff layoutRawTableWidthField;

        private CT_OnOff layoutTableRowsApartField;

        private CT_OnOff useWord97LineBreakRulesField;

        private CT_OnOff doNotBreakWrappedTablesField;

        private CT_OnOff doNotSnapToGridInCellField;

        private CT_OnOff selectFldWithFirstOrLastCharField;

        private CT_OnOff applyBreakingRulesField;

        private CT_OnOff doNotWrapTextWithPunctField;

        private CT_OnOff doNotUseEastAsianBreakRulesField;

        private CT_OnOff useWord2002TableStyleRulesField;

        private CT_OnOff growAutofitField;

        private CT_OnOff useFELayoutField;

        private CT_OnOff useNormalStyleForListField;

        private CT_OnOff doNotUseIndentAsNumberingTabStopField;

        private CT_OnOff useAltKinsokuLineBreakRulesField;

        private CT_OnOff allowSpaceOfSameStyleInTableField;

        private CT_OnOff doNotSuppressIndentationField;

        private CT_OnOff doNotAutofitConstrainedTablesField;

        private CT_OnOff autofitToFirstFixedWidthCellField;

        private CT_OnOff underlineTabInNumListField;

        private CT_OnOff displayHangulFixedWidthField;

        private CT_OnOff splitPgBreakAndParaMarkField;

        private CT_OnOff doNotVertAlignCellWithSpField;

        private CT_OnOff doNotBreakConstrainedForcedTableField;

        private CT_OnOff doNotVertAlignInTxbxField;

        private CT_OnOff useAnsiKerningPairsField;

        private CT_OnOff cachedColBalanceField;

        public CT_Compat()
        {
            this.cachedColBalanceField = new CT_OnOff();
            this.useAnsiKerningPairsField = new CT_OnOff();
            this.doNotVertAlignInTxbxField = new CT_OnOff();
            this.doNotBreakConstrainedForcedTableField = new CT_OnOff();
            this.doNotVertAlignCellWithSpField = new CT_OnOff();
            this.splitPgBreakAndParaMarkField = new CT_OnOff();
            this.displayHangulFixedWidthField = new CT_OnOff();
            this.underlineTabInNumListField = new CT_OnOff();
            this.autofitToFirstFixedWidthCellField = new CT_OnOff();
            this.doNotAutofitConstrainedTablesField = new CT_OnOff();
            this.doNotSuppressIndentationField = new CT_OnOff();
            this.allowSpaceOfSameStyleInTableField = new CT_OnOff();
            this.useAltKinsokuLineBreakRulesField = new CT_OnOff();
            this.doNotUseIndentAsNumberingTabStopField = new CT_OnOff();
            this.useNormalStyleForListField = new CT_OnOff();
            this.useFELayoutField = new CT_OnOff();
            this.growAutofitField = new CT_OnOff();
            this.useWord2002TableStyleRulesField = new CT_OnOff();
            this.doNotUseEastAsianBreakRulesField = new CT_OnOff();
            this.doNotWrapTextWithPunctField = new CT_OnOff();
            this.applyBreakingRulesField = new CT_OnOff();
            this.selectFldWithFirstOrLastCharField = new CT_OnOff();
            this.doNotSnapToGridInCellField = new CT_OnOff();
            this.doNotBreakWrappedTablesField = new CT_OnOff();
            this.useWord97LineBreakRulesField = new CT_OnOff();
            this.layoutTableRowsApartField = new CT_OnOff();
            this.layoutRawTableWidthField = new CT_OnOff();
            this.doNotUseHTMLParagraphAutoSpacingField = new CT_OnOff();
            this.noSpaceRaiseLowerField = new CT_OnOff();
            this.autoSpaceLikeWord95Field = new CT_OnOff();
            this.adjustLineHeightInTableField = new CT_OnOff();
            this.forgetLastTabAlignmentField = new CT_OnOff();
            this.alignTablesRowByRowField = new CT_OnOff();
            this.shapeLayoutLikeWW8Field = new CT_OnOff();
            this.footnoteLayoutLikeWW8Field = new CT_OnOff();
            this.wrapTrailSpacesField = new CT_OnOff();
            this.doNotSuppressParagraphBordersField = new CT_OnOff();
            this.usePrinterMetricsField = new CT_OnOff();
            this.mwSmallCapsField = new CT_OnOff();
            this.truncateFontHeightsLikeWP6Field = new CT_OnOff();
            this.convMailMergeEscField = new CT_OnOff();
            this.swapBordersFacingPagesField = new CT_OnOff();
            this.suppressSpBfAfterPgBrkField = new CT_OnOff();
            this.suppressTopSpacingWPField = new CT_OnOff();
            this.suppressSpacingAtTopOfPageField = new CT_OnOff();
            this.suppressTopSpacingField = new CT_OnOff();
            this.suppressBottomSpacingField = new CT_OnOff();
            this.subFontBySizeField = new CT_OnOff();
            this.showBreaksInFramesField = new CT_OnOff();
            this.wpSpaceWidthField = new CT_OnOff();
            this.printColBlackField = new CT_OnOff();
            this.printBodyTextBeforeHeaderField = new CT_OnOff();
            this.lineWrapLikeWord6Field = new CT_OnOff();
            this.spacingInWholePointsField = new CT_OnOff();
            this.doNotExpandShiftReturnField = new CT_OnOff();
            this.ulTrailSpaceField = new CT_OnOff();
            this.doNotLeaveBackslashAloneField = new CT_OnOff();
            this.noExtraLineSpacingField = new CT_OnOff();
            this.balanceSingleByteDoubleByteWidthField = new CT_OnOff();
            this.noColumnBalanceField = new CT_OnOff();
            this.spaceForULField = new CT_OnOff();
            this.noLeadingField = new CT_OnOff();
            this.noTabHangIndField = new CT_OnOff();
            this.wpJustificationField = new CT_OnOff();
            this.useSingleBorderforContiguousCellsField = new CT_OnOff();
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public CT_OnOff useSingleBorderforContiguousCells
        {
            get
            {
                return this.useSingleBorderforContiguousCellsField;
            }
            set
            {
                this.useSingleBorderforContiguousCellsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public CT_OnOff wpJustification
        {
            get
            {
                return this.wpJustificationField;
            }
            set
            {
                this.wpJustificationField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public CT_OnOff noTabHangInd
        {
            get
            {
                return this.noTabHangIndField;
            }
            set
            {
                this.noTabHangIndField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public CT_OnOff noLeading
        {
            get
            {
                return this.noLeadingField;
            }
            set
            {
                this.noLeadingField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public CT_OnOff spaceForUL
        {
            get
            {
                return this.spaceForULField;
            }
            set
            {
                this.spaceForULField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public CT_OnOff noColumnBalance
        {
            get
            {
                return this.noColumnBalanceField;
            }
            set
            {
                this.noColumnBalanceField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public CT_OnOff balanceSingleByteDoubleByteWidth
        {
            get
            {
                return this.balanceSingleByteDoubleByteWidthField;
            }
            set
            {
                this.balanceSingleByteDoubleByteWidthField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public CT_OnOff noExtraLineSpacing
        {
            get
            {
                return this.noExtraLineSpacingField;
            }
            set
            {
                this.noExtraLineSpacingField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public CT_OnOff doNotLeaveBackslashAlone
        {
            get
            {
                return this.doNotLeaveBackslashAloneField;
            }
            set
            {
                this.doNotLeaveBackslashAloneField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public CT_OnOff ulTrailSpace
        {
            get
            {
                return this.ulTrailSpaceField;
            }
            set
            {
                this.ulTrailSpaceField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public CT_OnOff doNotExpandShiftReturn
        {
            get
            {
                return this.doNotExpandShiftReturnField;
            }
            set
            {
                this.doNotExpandShiftReturnField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public CT_OnOff spacingInWholePoints
        {
            get
            {
                return this.spacingInWholePointsField;
            }
            set
            {
                this.spacingInWholePointsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public CT_OnOff lineWrapLikeWord6
        {
            get
            {
                return this.lineWrapLikeWord6Field;
            }
            set
            {
                this.lineWrapLikeWord6Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public CT_OnOff printBodyTextBeforeHeader
        {
            get
            {
                return this.printBodyTextBeforeHeaderField;
            }
            set
            {
                this.printBodyTextBeforeHeaderField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public CT_OnOff printColBlack
        {
            get
            {
                return this.printColBlackField;
            }
            set
            {
                this.printColBlackField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
        public CT_OnOff wpSpaceWidth
        {
            get
            {
                return this.wpSpaceWidthField;
            }
            set
            {
                this.wpSpaceWidthField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 16)]
        public CT_OnOff showBreaksInFrames
        {
            get
            {
                return this.showBreaksInFramesField;
            }
            set
            {
                this.showBreaksInFramesField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 17)]
        public CT_OnOff subFontBySize
        {
            get
            {
                return this.subFontBySizeField;
            }
            set
            {
                this.subFontBySizeField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 18)]
        public CT_OnOff suppressBottomSpacing
        {
            get
            {
                return this.suppressBottomSpacingField;
            }
            set
            {
                this.suppressBottomSpacingField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 19)]
        public CT_OnOff suppressTopSpacing
        {
            get
            {
                return this.suppressTopSpacingField;
            }
            set
            {
                this.suppressTopSpacingField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 20)]
        public CT_OnOff suppressSpacingAtTopOfPage
        {
            get
            {
                return this.suppressSpacingAtTopOfPageField;
            }
            set
            {
                this.suppressSpacingAtTopOfPageField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 21)]
        public CT_OnOff suppressTopSpacingWP
        {
            get
            {
                return this.suppressTopSpacingWPField;
            }
            set
            {
                this.suppressTopSpacingWPField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 22)]
        public CT_OnOff suppressSpBfAfterPgBrk
        {
            get
            {
                return this.suppressSpBfAfterPgBrkField;
            }
            set
            {
                this.suppressSpBfAfterPgBrkField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 23)]
        public CT_OnOff swapBordersFacingPages
        {
            get
            {
                return this.swapBordersFacingPagesField;
            }
            set
            {
                this.swapBordersFacingPagesField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 24)]
        public CT_OnOff convMailMergeEsc
        {
            get
            {
                return this.convMailMergeEscField;
            }
            set
            {
                this.convMailMergeEscField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 25)]
        public CT_OnOff truncateFontHeightsLikeWP6
        {
            get
            {
                return this.truncateFontHeightsLikeWP6Field;
            }
            set
            {
                this.truncateFontHeightsLikeWP6Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 26)]
        public CT_OnOff mwSmallCaps
        {
            get
            {
                return this.mwSmallCapsField;
            }
            set
            {
                this.mwSmallCapsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 27)]
        public CT_OnOff usePrinterMetrics
        {
            get
            {
                return this.usePrinterMetricsField;
            }
            set
            {
                this.usePrinterMetricsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 28)]
        public CT_OnOff doNotSuppressParagraphBorders
        {
            get
            {
                return this.doNotSuppressParagraphBordersField;
            }
            set
            {
                this.doNotSuppressParagraphBordersField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 29)]
        public CT_OnOff wrapTrailSpaces
        {
            get
            {
                return this.wrapTrailSpacesField;
            }
            set
            {
                this.wrapTrailSpacesField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 30)]
        public CT_OnOff footnoteLayoutLikeWW8
        {
            get
            {
                return this.footnoteLayoutLikeWW8Field;
            }
            set
            {
                this.footnoteLayoutLikeWW8Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 31)]
        public CT_OnOff shapeLayoutLikeWW8
        {
            get
            {
                return this.shapeLayoutLikeWW8Field;
            }
            set
            {
                this.shapeLayoutLikeWW8Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 32)]
        public CT_OnOff alignTablesRowByRow
        {
            get
            {
                return this.alignTablesRowByRowField;
            }
            set
            {
                this.alignTablesRowByRowField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 33)]
        public CT_OnOff forgetLastTabAlignment
        {
            get
            {
                return this.forgetLastTabAlignmentField;
            }
            set
            {
                this.forgetLastTabAlignmentField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 34)]
        public CT_OnOff adjustLineHeightInTable
        {
            get
            {
                return this.adjustLineHeightInTableField;
            }
            set
            {
                this.adjustLineHeightInTableField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 35)]
        public CT_OnOff autoSpaceLikeWord95
        {
            get
            {
                return this.autoSpaceLikeWord95Field;
            }
            set
            {
                this.autoSpaceLikeWord95Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 36)]
        public CT_OnOff noSpaceRaiseLower
        {
            get
            {
                return this.noSpaceRaiseLowerField;
            }
            set
            {
                this.noSpaceRaiseLowerField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 37)]
        public CT_OnOff doNotUseHTMLParagraphAutoSpacing
        {
            get
            {
                return this.doNotUseHTMLParagraphAutoSpacingField;
            }
            set
            {
                this.doNotUseHTMLParagraphAutoSpacingField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 38)]
        public CT_OnOff layoutRawTableWidth
        {
            get
            {
                return this.layoutRawTableWidthField;
            }
            set
            {
                this.layoutRawTableWidthField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 39)]
        public CT_OnOff layoutTableRowsApart
        {
            get
            {
                return this.layoutTableRowsApartField;
            }
            set
            {
                this.layoutTableRowsApartField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 40)]
        public CT_OnOff useWord97LineBreakRules
        {
            get
            {
                return this.useWord97LineBreakRulesField;
            }
            set
            {
                this.useWord97LineBreakRulesField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 41)]
        public CT_OnOff doNotBreakWrappedTables
        {
            get
            {
                return this.doNotBreakWrappedTablesField;
            }
            set
            {
                this.doNotBreakWrappedTablesField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 42)]
        public CT_OnOff doNotSnapToGridInCell
        {
            get
            {
                return this.doNotSnapToGridInCellField;
            }
            set
            {
                this.doNotSnapToGridInCellField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 43)]
        public CT_OnOff selectFldWithFirstOrLastChar
        {
            get
            {
                return this.selectFldWithFirstOrLastCharField;
            }
            set
            {
                this.selectFldWithFirstOrLastCharField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 44)]
        public CT_OnOff applyBreakingRules
        {
            get
            {
                return this.applyBreakingRulesField;
            }
            set
            {
                this.applyBreakingRulesField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 45)]
        public CT_OnOff doNotWrapTextWithPunct
        {
            get
            {
                return this.doNotWrapTextWithPunctField;
            }
            set
            {
                this.doNotWrapTextWithPunctField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 46)]
        public CT_OnOff doNotUseEastAsianBreakRules
        {
            get
            {
                return this.doNotUseEastAsianBreakRulesField;
            }
            set
            {
                this.doNotUseEastAsianBreakRulesField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 47)]
        public CT_OnOff useWord2002TableStyleRules
        {
            get
            {
                return this.useWord2002TableStyleRulesField;
            }
            set
            {
                this.useWord2002TableStyleRulesField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 48)]
        public CT_OnOff growAutofit
        {
            get
            {
                return this.growAutofitField;
            }
            set
            {
                this.growAutofitField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 49)]
        public CT_OnOff useFELayout
        {
            get
            {
                return this.useFELayoutField;
            }
            set
            {
                this.useFELayoutField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 50)]
        public CT_OnOff useNormalStyleForList
        {
            get
            {
                return this.useNormalStyleForListField;
            }
            set
            {
                this.useNormalStyleForListField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 51)]
        public CT_OnOff doNotUseIndentAsNumberingTabStop
        {
            get
            {
                return this.doNotUseIndentAsNumberingTabStopField;
            }
            set
            {
                this.doNotUseIndentAsNumberingTabStopField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 52)]
        public CT_OnOff useAltKinsokuLineBreakRules
        {
            get
            {
                return this.useAltKinsokuLineBreakRulesField;
            }
            set
            {
                this.useAltKinsokuLineBreakRulesField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 53)]
        public CT_OnOff allowSpaceOfSameStyleInTable
        {
            get
            {
                return this.allowSpaceOfSameStyleInTableField;
            }
            set
            {
                this.allowSpaceOfSameStyleInTableField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 54)]
        public CT_OnOff doNotSuppressIndentation
        {
            get
            {
                return this.doNotSuppressIndentationField;
            }
            set
            {
                this.doNotSuppressIndentationField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 55)]
        public CT_OnOff doNotAutofitConstrainedTables
        {
            get
            {
                return this.doNotAutofitConstrainedTablesField;
            }
            set
            {
                this.doNotAutofitConstrainedTablesField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 56)]
        public CT_OnOff autofitToFirstFixedWidthCell
        {
            get
            {
                return this.autofitToFirstFixedWidthCellField;
            }
            set
            {
                this.autofitToFirstFixedWidthCellField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 57)]
        public CT_OnOff underlineTabInNumList
        {
            get
            {
                return this.underlineTabInNumListField;
            }
            set
            {
                this.underlineTabInNumListField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 58)]
        public CT_OnOff displayHangulFixedWidth
        {
            get
            {
                return this.displayHangulFixedWidthField;
            }
            set
            {
                this.displayHangulFixedWidthField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 59)]
        public CT_OnOff splitPgBreakAndParaMark
        {
            get
            {
                return this.splitPgBreakAndParaMarkField;
            }
            set
            {
                this.splitPgBreakAndParaMarkField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 60)]
        public CT_OnOff doNotVertAlignCellWithSp
        {
            get
            {
                return this.doNotVertAlignCellWithSpField;
            }
            set
            {
                this.doNotVertAlignCellWithSpField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 61)]
        public CT_OnOff doNotBreakConstrainedForcedTable
        {
            get
            {
                return this.doNotBreakConstrainedForcedTableField;
            }
            set
            {
                this.doNotBreakConstrainedForcedTableField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 62)]
        public CT_OnOff doNotVertAlignInTxbx
        {
            get
            {
                return this.doNotVertAlignInTxbxField;
            }
            set
            {
                this.doNotVertAlignInTxbxField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 63)]
        public CT_OnOff useAnsiKerningPairs
        {
            get
            {
                return this.useAnsiKerningPairsField;
            }
            set
            {
                this.useAnsiKerningPairsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 64)]
        public CT_OnOff cachedColBalance
        {
            get
            {
                return this.cachedColBalanceField;
            }
            set
            {
                this.cachedColBalanceField = value;
            }
        }
    }


    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_DocVar
    {

        private string nameField;

        private string valField;

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string val
        {
            get
            {
                return this.valField;
            }
            set
            {
                this.valField = value;
            }
        }
    }


    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_DocRsids
    {

        private CT_LongHexNumber rsidRootField;

        private List<CT_LongHexNumber> rsidField;

        public CT_DocRsids()
        {
            this.rsidField = new List<CT_LongHexNumber>();
            this.rsidRootField = new CT_LongHexNumber();
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public CT_LongHexNumber rsidRoot
        {
            get
            {
                return this.rsidRootField;
            }
            set
            {
                this.rsidRootField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("rsid", Order = 1)]
        public List<CT_LongHexNumber> rsid
        {
            get
            {
                return this.rsidField;
            }
            set
            {
                this.rsidField = value;
            }
        }
    }





    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_ColorSchemeMapping
    {

        private ST_ColorSchemeIndex bg1Field;

        private bool bg1FieldSpecified;

        private ST_ColorSchemeIndex t1Field;

        private bool t1FieldSpecified;

        private ST_ColorSchemeIndex bg2Field;

        private bool bg2FieldSpecified;

        private ST_ColorSchemeIndex t2Field;

        private bool t2FieldSpecified;

        private ST_ColorSchemeIndex accent1Field;

        private bool accent1FieldSpecified;

        private ST_ColorSchemeIndex accent2Field;

        private bool accent2FieldSpecified;

        private ST_ColorSchemeIndex accent3Field;

        private bool accent3FieldSpecified;

        private ST_ColorSchemeIndex accent4Field;

        private bool accent4FieldSpecified;

        private ST_ColorSchemeIndex accent5Field;

        private bool accent5FieldSpecified;

        private ST_ColorSchemeIndex accent6Field;

        private bool accent6FieldSpecified;

        private ST_ColorSchemeIndex hyperlinkField;

        private bool hyperlinkFieldSpecified;

        private ST_ColorSchemeIndex followedHyperlinkField;

        private bool followedHyperlinkFieldSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_ColorSchemeIndex bg1
        {
            get
            {
                return this.bg1Field;
            }
            set
            {
                this.bg1Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bg1Specified
        {
            get
            {
                return this.bg1FieldSpecified;
            }
            set
            {
                this.bg1FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_ColorSchemeIndex t1
        {
            get
            {
                return this.t1Field;
            }
            set
            {
                this.t1Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool t1Specified
        {
            get
            {
                return this.t1FieldSpecified;
            }
            set
            {
                this.t1FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_ColorSchemeIndex bg2
        {
            get
            {
                return this.bg2Field;
            }
            set
            {
                this.bg2Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bg2Specified
        {
            get
            {
                return this.bg2FieldSpecified;
            }
            set
            {
                this.bg2FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_ColorSchemeIndex t2
        {
            get
            {
                return this.t2Field;
            }
            set
            {
                this.t2Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool t2Specified
        {
            get
            {
                return this.t2FieldSpecified;
            }
            set
            {
                this.t2FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_ColorSchemeIndex accent1
        {
            get
            {
                return this.accent1Field;
            }
            set
            {
                this.accent1Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool accent1Specified
        {
            get
            {
                return this.accent1FieldSpecified;
            }
            set
            {
                this.accent1FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_ColorSchemeIndex accent2
        {
            get
            {
                return this.accent2Field;
            }
            set
            {
                this.accent2Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool accent2Specified
        {
            get
            {
                return this.accent2FieldSpecified;
            }
            set
            {
                this.accent2FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_ColorSchemeIndex accent3
        {
            get
            {
                return this.accent3Field;
            }
            set
            {
                this.accent3Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool accent3Specified
        {
            get
            {
                return this.accent3FieldSpecified;
            }
            set
            {
                this.accent3FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_ColorSchemeIndex accent4
        {
            get
            {
                return this.accent4Field;
            }
            set
            {
                this.accent4Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool accent4Specified
        {
            get
            {
                return this.accent4FieldSpecified;
            }
            set
            {
                this.accent4FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_ColorSchemeIndex accent5
        {
            get
            {
                return this.accent5Field;
            }
            set
            {
                this.accent5Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool accent5Specified
        {
            get
            {
                return this.accent5FieldSpecified;
            }
            set
            {
                this.accent5FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_ColorSchemeIndex accent6
        {
            get
            {
                return this.accent6Field;
            }
            set
            {
                this.accent6Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool accent6Specified
        {
            get
            {
                return this.accent6FieldSpecified;
            }
            set
            {
                this.accent6FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_ColorSchemeIndex hyperlink
        {
            get
            {
                return this.hyperlinkField;
            }
            set
            {
                this.hyperlinkField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hyperlinkSpecified
        {
            get
            {
                return this.hyperlinkFieldSpecified;
            }
            set
            {
                this.hyperlinkFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_ColorSchemeIndex followedHyperlink
        {
            get
            {
                return this.followedHyperlinkField;
            }
            set
            {
                this.followedHyperlinkField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool followedHyperlinkSpecified
        {
            get
            {
                return this.followedHyperlinkFieldSpecified;
            }
            set
            {
                this.followedHyperlinkFieldSpecified = value;
            }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    public enum ST_ColorSchemeIndex
    {

        /// <remarks/>
        dark1,

        /// <remarks/>
        light1,

        /// <remarks/>
        dark2,

        /// <remarks/>
        light2,

        /// <remarks/>
        accent1,

        /// <remarks/>
        accent2,

        /// <remarks/>
        accent3,

        /// <remarks/>
        accent4,

        /// <remarks/>
        accent5,

        /// <remarks/>
        accent6,

        /// <remarks/>
        hyperlink,

        /// <remarks/>
        followedHyperlink,
    }




    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_Captions
    {

        private List<CT_Caption> captionField;

        private List<CT_AutoCaption> autoCaptionsField;

        public CT_Captions()
        {
            this.autoCaptionsField = new List<CT_AutoCaption>();
            this.captionField = new List<CT_Caption>();
        }

        [System.Xml.Serialization.XmlElementAttribute("caption", Order = 0)]
        public List<CT_Caption> caption
        {
            get
            {
                return this.captionField;
            }
            set
            {
                this.captionField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayAttribute(Order = 1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("autoCaption", IsNullable = false)]
        public List<CT_AutoCaption> autoCaptions
        {
            get
            {
                return this.autoCaptionsField;
            }
            set
            {
                this.autoCaptionsField = value;
            }
        }
    }


    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_Caption
    {

        private string nameField;

        private ST_CaptionPos posField;

        private bool posFieldSpecified;

        private ST_OnOff chapNumField;

        private bool chapNumFieldSpecified;

        private string headingField;

        private ST_OnOff noLabelField;

        private bool noLabelFieldSpecified;

        private ST_NumberFormat numFmtField;

        private bool numFmtFieldSpecified;

        private ST_ChapterSep sepField;

        private bool sepFieldSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_CaptionPos pos
        {
            get
            {
                return this.posField;
            }
            set
            {
                this.posField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool posSpecified
        {
            get
            {
                return this.posFieldSpecified;
            }
            set
            {
                this.posFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_OnOff chapNum
        {
            get
            {
                return this.chapNumField;
            }
            set
            {
                this.chapNumField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool chapNumSpecified
        {
            get
            {
                return this.chapNumFieldSpecified;
            }
            set
            {
                this.chapNumFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
        public string heading
        {
            get
            {
                return this.headingField;
            }
            set
            {
                this.headingField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_OnOff noLabel
        {
            get
            {
                return this.noLabelField;
            }
            set
            {
                this.noLabelField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool noLabelSpecified
        {
            get
            {
                return this.noLabelFieldSpecified;
            }
            set
            {
                this.noLabelFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_NumberFormat numFmt
        {
            get
            {
                return this.numFmtField;
            }
            set
            {
                this.numFmtField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numFmtSpecified
        {
            get
            {
                return this.numFmtFieldSpecified;
            }
            set
            {
                this.numFmtFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_ChapterSep sep
        {
            get
            {
                return this.sepField;
            }
            set
            {
                this.sepField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sepSpecified
        {
            get
            {
                return this.sepFieldSpecified;
            }
            set
            {
                this.sepFieldSpecified = value;
            }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    public enum ST_CaptionPos
    {

        /// <remarks/>
        above,

        /// <remarks/>
        below,

        /// <remarks/>
        left,

        /// <remarks/>
        right,
    }


    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_AutoCaption
    {

        private string nameField;

        private string captionField;

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string caption
        {
            get
            {
                return this.captionField;
            }
            set
            {
                this.captionField = value;
            }
        }
    }


    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_ReadingModeInkLockDown
    {

        private ST_OnOff actualPgField;

        private ulong wField;

        private ulong hField;

        private string fontSzField;

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_OnOff actualPg
        {
            get
            {
                return this.actualPgField;
            }
            set
            {
                this.actualPgField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ulong w
        {
            get
            {
                return this.wField;
            }
            set
            {
                this.wField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ulong h
        {
            get
            {
                return this.hField;
            }
            set
            {
                this.hField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
        public string fontSz
        {
            get
            {
                return this.fontSzField;
            }
            set
            {
                this.fontSzField = value;
            }
        }
    }


    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_SmartTagType
    {

        private string namespaceuriField;

        private string nameField;

        private string urlField;

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string namespaceuri
        {
            get
            {
                return this.namespaceuriField;
            }
            set
            {
                this.namespaceuriField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
            }
        }
    }


    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute("webSettings", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = false)]
    public class CT_WebSettings
    {

        private CT_Frameset framesetField;

        private CT_Divs divsField;

        private CT_String encodingField;

        private CT_OnOff optimizeForBrowserField;

        private CT_OnOff relyOnVMLField;

        private CT_OnOff allowPNGField;

        private CT_OnOff doNotRelyOnCSSField;

        private CT_OnOff doNotSaveAsSingleFileField;

        private CT_OnOff doNotOrganizeInFolderField;

        private CT_OnOff doNotUseLongFileNamesField;

        private CT_DecimalNumber pixelsPerInchField;

        private CT_TargetScreenSz targetScreenSzField;

        private CT_OnOff saveSmartTagsAsXmlField;

        public CT_WebSettings()
        {
            this.saveSmartTagsAsXmlField = new CT_OnOff();
            this.targetScreenSzField = new CT_TargetScreenSz();
            this.pixelsPerInchField = new CT_DecimalNumber();
            this.doNotUseLongFileNamesField = new CT_OnOff();
            this.doNotOrganizeInFolderField = new CT_OnOff();
            this.doNotSaveAsSingleFileField = new CT_OnOff();
            this.doNotRelyOnCSSField = new CT_OnOff();
            this.allowPNGField = new CT_OnOff();
            this.relyOnVMLField = new CT_OnOff();
            this.optimizeForBrowserField = new CT_OnOff();
            this.encodingField = new CT_String();
            this.divsField = new CT_Divs();
            this.framesetField = new CT_Frameset();
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public CT_Frameset frameset
        {
            get
            {
                return this.framesetField;
            }
            set
            {
                this.framesetField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public CT_Divs divs
        {
            get
            {
                return this.divsField;
            }
            set
            {
                this.divsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public CT_String encoding
        {
            get
            {
                return this.encodingField;
            }
            set
            {
                this.encodingField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public CT_OnOff optimizeForBrowser
        {
            get
            {
                return this.optimizeForBrowserField;
            }
            set
            {
                this.optimizeForBrowserField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public CT_OnOff relyOnVML
        {
            get
            {
                return this.relyOnVMLField;
            }
            set
            {
                this.relyOnVMLField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public CT_OnOff allowPNG
        {
            get
            {
                return this.allowPNGField;
            }
            set
            {
                this.allowPNGField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public CT_OnOff doNotRelyOnCSS
        {
            get
            {
                return this.doNotRelyOnCSSField;
            }
            set
            {
                this.doNotRelyOnCSSField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public CT_OnOff doNotSaveAsSingleFile
        {
            get
            {
                return this.doNotSaveAsSingleFileField;
            }
            set
            {
                this.doNotSaveAsSingleFileField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public CT_OnOff doNotOrganizeInFolder
        {
            get
            {
                return this.doNotOrganizeInFolderField;
            }
            set
            {
                this.doNotOrganizeInFolderField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public CT_OnOff doNotUseLongFileNames
        {
            get
            {
                return this.doNotUseLongFileNamesField;
            }
            set
            {
                this.doNotUseLongFileNamesField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public CT_DecimalNumber pixelsPerInch
        {
            get
            {
                return this.pixelsPerInchField;
            }
            set
            {
                this.pixelsPerInchField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public CT_TargetScreenSz targetScreenSz
        {
            get
            {
                return this.targetScreenSzField;
            }
            set
            {
                this.targetScreenSzField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public CT_OnOff saveSmartTagsAsXml
        {
            get
            {
                return this.saveSmartTagsAsXmlField;
            }
            set
            {
                this.saveSmartTagsAsXmlField = value;
            }
        }
    }

    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_ShapeDefaults
    {

        private List<System.Xml.XmlElement> itemsField;

        public CT_ShapeDefaults()
        {
            this.itemsField = new List<System.Xml.XmlElement>();
        }

        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace = "urn:schemas-microsoft-com:office:office", Order = 0)]
        public List<System.Xml.XmlElement> Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }


    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_AutoCaptions
    {

        private List<CT_AutoCaption> autoCaptionField;

        public CT_AutoCaptions()
        {
            this.autoCaptionField = new List<CT_AutoCaption>();
        }

        [System.Xml.Serialization.XmlElementAttribute("autoCaption", Order = 0)]
        public List<CT_AutoCaption> autoCaption
        {
            get
            {
                return this.autoCaptionField;
            }
            set
            {
                this.autoCaptionField = value;
            }
        }
    }

}