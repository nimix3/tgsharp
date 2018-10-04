namespace org.telegram.api
{
    using IKVM.Attributes;
    using ikvm.internal;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;

    public class TLApiContext : TLContext
    {
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 
            0xa2, 2, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70,
            0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x72
        })]
        private void addApiLayer19()
        {
            this.registerClass(-1137792208, ClassLiteral<TLPrivacyKeyStatusTimestamp>.Value);
            this.registerClass(0x554abb6f, ClassLiteral<TLAccountPrivacyRules>.Value);
            this.registerClass(0x4d5bbe0c, ClassLiteral<TLPrivacyValueAllowUsers>.Value);
            this.registerClass(-1955338397, ClassLiteral<TLPrivacyValueDisallowAll>.Value);
            this.registerClass(-123988, ClassLiteral<TLPrivacyValueAllowContacts>.Value);
            this.registerClass(-125240806, ClassLiteral<TLPrivacyValueDisallowContacts>.Value);
            this.registerClass(0x65427b82, ClassLiteral<TLPrivacyValueAllowAll>.Value);
            this.registerClass(0xc7f49b7, ClassLiteral<TLPrivacyValueDisallowUsers>.Value);
            this.registerClass(0x4f96cb18, ClassLiteral<TLInputPrivacyKeyStatusTimestamp>.Value);
            this.registerClass(-1877932953, ClassLiteral<TLInputPrivacyValueDisallowUsers>.Value);
            this.registerClass(-697604407, ClassLiteral<TLInputPrivacyValueDisallowAll>.Value);
            this.registerClass(0xba52007, ClassLiteral<TLInputPrivacyValueDisallowContacts>.Value);
            this.registerClass(0x184b35ce, ClassLiteral<TLInputPrivacyValueAllowAll>.Value);
            this.registerClass(0xd09e07b, ClassLiteral<TLInputPrivacyValueAllowContacts>.Value);
            this.registerClass(0x131cc67f, ClassLiteral<TLInputPrivacyValueAllowUsers>.Value);
            this.registerClass(-298113238, ClassLiteral<TLUpdatePrivacy>.Value);
            this.registerClass(-623130288, ClassLiteral<TLRequestAccountGetPrivacy>.Value);
            this.registerClass(-906486552, ClassLiteral<TLRequestAccountSetPrivacy>.Value);
            this.registerClass(-1194283041, ClassLiteral<TLAccountDaysTTL>.Value);
            this.registerClass(0x2442485e, ClassLiteral<TLRequestAccountSetAccountTTL>.Value);
            this.registerClass(0x8fc711d, ClassLiteral<TLRequestAccountGetAccountTTL>.Value);
            this.registerClass(0x7bf09fc, ClassLiteral<TLUserStatusLastWeek>.Value);
            this.registerClass(0x77ebc742, ClassLiteral<TLUserStatusLastMonth>.Value);
            this.registerClass(-496024847, ClassLiteral<TLUserStatusRecently>.Value);
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 
            0xa2, 0x1d, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70,
            0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x72
        })]
        private void addApiLayer22()
        {
            this.registerClass(0x11b58939, ClassLiteral<TLDocumentAttributeAnimated>.Value);
            this.registerClass(0x15590068, ClassLiteral<TLDocumentAttributeFilename>.Value);
            this.registerClass(0xef02ce6, ClassLiteral<TLDocumentAttributeVideo>.Value);
            this.registerClass(0x6319d612, ClassLiteral<TLDocumentAttributeSticker>.Value);
            this.registerClass(0x6c37c15c, ClassLiteral<TLDocumentAttributeImageSize>.Value);
            this.registerClass(-1739392570, ClassLiteral<TLDocumentAttributeAudio>.Value);
            this.registerClass(-2027738169, ClassLiteral<TLDocument>.Value);
            this.registerClass(0x50d88cae, ClassLiteral<TLInputMediaUploadedThumbDocument>.Value);
            this.registerClass(0x12b9417b, ClassLiteral<TLUpdateUserPhone>.Value);
            this.registerClass(0x6fe1735b, ClassLiteral<TLDecryptedMessageActionAcceptKey>.Value);
            this.registerClass(-204906213, ClassLiteral<TLDecryptedMessageActionRequestKey>.Value);
            this.registerClass(-302170017, ClassLiteral<TLAllStickers>.Value);
            this.registerClass(-395967805, ClassLiteral<TLAllStickersNotModified>.Value);
            this.registerClass(0x7c18141c, ClassLiteral<TLAccountPassword>.Value);
            this.registerClass(-1764049896, ClassLiteral<TLAccountNoPassword>.Value);
            this.registerClass(0x8e57deb, ClassLiteral<TLRequestAccountSendChangePhoneCode>.Value);
            this.registerClass(0x70c32edb, ClassLiteral<TLRequestAccountChangePhone>.Value);
            this.registerClass(0x548a30f5, ClassLiteral<TLRequestAccountGetPassword>.Value);
            this.registerClass(0xa63011e, ClassLiteral<TLRequestAuthCheckPassword>.Value);
            this.registerClass(0x1c9618b1, ClassLiteral<TLRequestMessagesGetAllStickers>.Value);
            this.registerClass(-113456221, ClassLiteral<TLRequestContactsResolveUsername>.Value);
            this.registerClass(-90853155, ClassLiteral<TLDecryptedMessageMediaExternalDocument>.Value);
            this.registerClass(0x12b299d4, ClassLiteral<TLStickerPack>.Value);
            this.registerClass(-1473258141, ClassLiteral<TLDecryptedMessageActionNoop>.Value);
            this.registerClass(-586814357, ClassLiteral<TLDecryptedMessageActionAbortKey>.Value);
            this.registerClass(-332526693, ClassLiteral<TLDecryptedMessageActionCommitKey>.Value);
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 
            0xa2, 0x3a, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70,
            0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70,
            0x70, 0x70, 0x72
        })]
        private void addApiLayer26()
        {
            this.registerClass(-1212732749, ClassLiteral<TLAccountPasswordSettings>.Value);
            this.registerClass(-2066640507, ClassLiteral<TLAffectedMessages>.Value);
            this.registerClass(-855308010, ClassLiteral<TLAuthorization>.Value);
            this.registerClass(-1557277184, ClassLiteral<TLMessageMediaWebPage>.Value);
            this.registerClass(-981018084, ClassLiteral<TLWebPagePending>.Value);
            this.registerClass(-350980120, ClassLiteral<TLWebPageEmpty>.Value);
            this.registerClass(0x137948a5, ClassLiteral<TLPasswordRecovery>.Value);
            this.registerClass(0x5f07b4bc, ClassLiteral<TLWebPage>.Value);
            this.registerClass(-17968211, ClassLiteral<TLContactLinkNone>.Value);
            this.registerClass(-721239344, ClassLiteral<TLContactLinkContact>.Value);
            this.registerClass(0x268f3f59, ClassLiteral<TLContactLinkHasPhone>.Value);
            this.registerClass(0x5f4f9247, ClassLiteral<TLContactLinkUnknown>.Value);
            this.registerClass(-1369215196, ClassLiteral<TLDisabledFeature>.Value);
            this.registerClass(-1721631396, ClassLiteral<TLUpdateReadMessagesInbox>.Value);
            this.registerClass(0x7f891213, ClassLiteral<TLUpdateWebPage>.Value);
            this.registerClass(0x2f2f21bf, ClassLiteral<TLUpdateReadMessagesOutbox>.Value);
            this.registerClass(0x38df3532, ClassLiteral<TLRequestAccountUpdateDeviceLocked>.Value);
            this.registerClass(-484392616, ClassLiteral<TLRequestAccountGetAuthorizations>.Value);
            this.registerClass(-545786948, ClassLiteral<TLRequestAccountResetAuthorization>.Value);
            this.registerClass(0x25223e24, ClassLiteral<TLRequestMessagesGetWebPagePreview>.Value);
            this.registerClass(-2037289493, ClassLiteral<TLAccountPasswordInputSettings>.Value);
            this.registerClass(0x1250abde, ClassLiteral<TLAccountAuthorizations>.Value);
            this.registerClass(-443640366, ClassLiteral<TLRequestMessagesDeleteMessages>.Value);
            this.registerClass(-1131605573, ClassLiteral<TLRequestAccountGetPasswordSettings>.Value);
            this.registerClass(-92517498, ClassLiteral<TLRequestAccountUpdatePasswordSettings>.Value);
            this.registerClass(-661144474, ClassLiteral<TLRequestAuthRequestPasswordRecovery>.Value);
            this.registerClass(0x4ea56e92, ClassLiteral<TLRequestAuthRecoverPassword>.Value);
            this.registerClass(-648121413, ClassLiteral<TLMessagesFilterPhotoVideoDocuments>.Value);
            this.registerClass(-244016606, ClassLiteral<TLStickersNotModified>.Value);
            this.registerClass(-1970352846, ClassLiteral<TLStickers>.Value);
            this.registerClass(-841733627, ClassLiteral<TLRequestAuthBindTempAuthKey>.Value);
            this.registerClass(0x4fe196fe, ClassLiteral<TLRequestContactsImportCard>.Value);
            this.registerClass(-2065352905, ClassLiteral<TLRequestContactsExportCard>.Value);
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0xa2, 0x5e, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x72 })]
        private void addApiLayer28()
        {
            this.registerClass(0x2827a81a, ClassLiteral<TLInputMediaVenue>.Value);
            this.registerClass(0x7912b71f, ClassLiteral<TLMessageMediaVenue>.Value);
            this.registerClass(-1551583367, ClassLiteral<TLReceivedNotifyMessage>.Value);
            this.registerClass(0x69df3769, ClassLiteral<TLChatInviteEmpty>.Value);
            this.registerClass(-64092740, ClassLiteral<TLChatInviteExported>.Value);
            this.registerClass(0x5a686d7c, ClassLiteral<TLChatInviteAlready>.Value);
            this.registerClass(-613092008, ClassLiteral<TLChatInvite>.Value);
            this.registerClass(-123931160, ClassLiteral<TLMessageActionChatJoinedByLink>.Value);
            this.registerClass(0x68c13933, ClassLiteral<TLUpdateReadMessagesContents>.Value);
            this.registerClass(-1080796745, ClassLiteral<TLRequestInvokeWithoutUpdates>.Value);
            this.registerClass(0x7d885289, ClassLiteral<TLRequestMessagesExportChatInvite>.Value);
            this.registerClass(0x3eadb1bb, ClassLiteral<TLRequestMessagesCheckChatInvite>.Value);
            this.registerClass(0x6c50051c, ClassLiteral<TLRequestMessagesImportChatInvite>.Value);
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 
            0xa2, 110, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70,
            0x70, 0x70, 0x70, 0x70, 0x70, 0x72
        })]
        private void addApiLayer32()
        {
            this.registerClass(-1032140601, ClassLiteral<TLBotCommand>.Value);
            this.registerClass(-1729618630, ClassLiteral<TLBotInfo>.Value);
            this.registerClass(-4838507, ClassLiteral<TLInputStickerSetEmpty>.Value);
            this.registerClass(-1645763991, ClassLiteral<TLInputStickerSetId>.Value);
            this.registerClass(-2044933984, ClassLiteral<TLInputStickerSetShortName>.Value);
            this.registerClass(-1560655744, ClassLiteral<TLKeyboardButton>.Value);
            this.registerClass(0x77608b83, ClassLiteral<TLKeyboardButtonRow>.Value);
            this.registerClass(-200242528, ClassLiteral<TLReplayKeyboardForceReply>.Value);
            this.registerClass(-1606526075, ClassLiteral<TLReplayKeyboardHide>.Value);
            this.registerClass(0x3502758c, ClassLiteral<TLReplayKeyboardMarkup>.Value);
            this.registerClass(-852477119, ClassLiteral<TLStickerSet>.Value);
            this.registerClass(0x2e13f4c3, ClassLiteral<TLUser>.Value);
            this.registerClass(0x7ef0dd87, ClassLiteral<TLMessagesFilterUrl>.Value);
            this.registerClass(-1240849242, ClassLiteral<TLMessagesStickerSet>.Value);
            this.registerClass(0x67a3ff2c, ClassLiteral<TLRequestAuthImportBotAuthorization>.Value);
            this.registerClass(0x2619a90e, ClassLiteral<TLRequestMessagesGetStickersSet>.Value);
            this.registerClass(-946871200, ClassLiteral<TLRequestMessagesInstallStickersSet>.Value);
            this.registerClass(-110209570, ClassLiteral<TLRequestMessagesUninstallStickersSet>.Value);
            this.registerClass(-421563528, ClassLiteral<TLRequestMessagesStartBot>.Value);
            this.registerClass(0x418d4e0b, ClassLiteral<TLRequestAccountDeleteAccount>.Value);
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 
            0xa2, 0x85, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70,
            0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70,
            0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70,
            0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70,
            0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x72
        })]
        private void addApiLayer38()
        {
            this.registerClass(-1588737454, ClassLiteral<TLChannel>.Value);
            this.registerClass(-2059962289, ClassLiteral<TLChannelForbidden>.Value);
            this.registerClass(-1009430225, ClassLiteral<TLChannelFull>.Value);
            this.registerClass(-847783593, ClassLiteral<TLChannelMessagesFilter>.Value);
            this.registerClass(-1798033689, ClassLiteral<TLChannelMessagesFilterEmpty>.Value);
            this.registerClass(-1343524562, ClassLiteral<TLInputChannel>.Value);
            this.registerClass(-292807034, ClassLiteral<TLInputChannelEmpty>.Value);
            this.registerClass(0x20adaef8, ClassLiteral<TLInputPeerChannel>.Value);
            this.registerClass(-1781355374, ClassLiteral<TLMessageActionChannelCreate>.Value);
            this.registerClass(-1117713463, ClassLiteral<TLMessageEntityBold>.Value);
            this.registerClass(0x6cef8ac7, ClassLiteral<TLMessageEntityBotCommand>.Value);
            this.registerClass(0x28a20571, ClassLiteral<TLMessageEntityCode>.Value);
            this.registerClass(0x64e475c2, ClassLiteral<TLMessageEntityEmail>.Value);
            this.registerClass(0x6f635b0d, ClassLiteral<TLMessageEntityHashtag>.Value);
            this.registerClass(-2106619040, ClassLiteral<TLMessageEntityItalic>.Value);
            this.registerClass(-100378723, ClassLiteral<TLMessageEntityMention>.Value);
            this.registerClass(0x73924be0, ClassLiteral<TLMessageEntityPre>.Value);
            this.registerClass(0x76a6d327, ClassLiteral<TLMessageEntityTextUrl>.Value);
            this.registerClass(-1148011883, ClassLiteral<TLMessageEntityUnknown>.Value);
            this.registerClass(0x6ed02538, ClassLiteral<TLMessageEntityUrl>.Value);
            this.registerClass(0xae30253, ClassLiteral<TLMessageRange>.Value);
            this.registerClass(-1109531342, ClassLiteral<TLPeerChannel>.Value);
            this.registerClass(-1877938321, ClassLiteral<TLRequestHelpGetAppChangelog>.Value);
            this.registerClass(-192332417, ClassLiteral<TLRequestChannelsCreateChannel>.Value);
            this.registerClass(-2067661490, ClassLiteral<TLRequestChannelsDeleteMessages>.Value);
            this.registerClass(-871347913, ClassLiteral<TLRequestChannelsReadHistory>.Value);
            this.registerClass(0x3173d78, ClassLiteral<TLRequestUpdatesGetChannelDifference>.Value);
            this.registerClass(-1227598250, ClassLiteral<TLUpdateChannel>.Value);
            this.registerClass(0x62ba04d9, ClassLiteral<TLUpdateChannelNewMessage>.Value);
            this.registerClass(-352032773, ClassLiteral<TLUpdateChannelTooLong>.Value);
            this.registerClass(-1734268085, ClassLiteral<TLUpdateChannelMessageViews>.Value);
            this.registerClass(-1015733815, ClassLiteral<TLUpdateDeleteChannelMessages>.Value);
            this.registerClass(0x4214f37f, ClassLiteral<TLUpdateReadChannelInbox>.Value);
            this.registerClass(0x2064674e, ClassLiteral<TLUpdatesChannelDifferences>.Value);
            this.registerClass(0x3e11affb, ClassLiteral<TLUpdatesChannelDifferencesEmpty>.Value);
            this.registerClass(0x410dee07, ClassLiteral<TLUpdatesChannelDifferencesTooLong>.Value);
            this.registerClass(0x11f1331c, ClassLiteral<TLUpdateShortSentMessage>.Value);
            this.registerClass(0x7f077ad9, ClassLiteral<TLResolvedPeer>.Value);
            this.registerClass(-1725551049, ClassLiteral<TLChannelMessages>.Value);
            this.registerClass(0x15ebac1d, ClassLiteral<TLChannelParticipant>.Value);
            this.registerClass(-1557620115, ClassLiteral<TLChannelParticipantSelf>.Value);
            this.registerClass(-1861910545, ClassLiteral<TLChannelParticipantModerator>.Value);
            this.registerClass(-1743180447, ClassLiteral<TLChannelParticipantEditor>.Value);
            this.registerClass(-1933187430, ClassLiteral<TLChannelParticipantKicked>.Value);
            this.registerClass(-471670279, ClassLiteral<TLChannelParticipantCreator>.Value);
            this.registerClass(-566281095, ClassLiteral<TLChannelParticipantsFilterRecent>.Value);
            this.registerClass(-1268741783, ClassLiteral<TLChannelParticipantsFilterAdmins>.Value);
            this.registerClass(0x3c37bb7a, ClassLiteral<TLChannelParticipantsFilterKicked>.Value);
            this.registerClass(-1299865402, ClassLiteral<TLChannelParticipantRoleEmpty>.Value);
            this.registerClass(-1776756363, ClassLiteral<TLChannelParticipantRoleModerator>.Value);
            this.registerClass(-2113143156, ClassLiteral<TLChannelParticipantRoleEditor>.Value);
            this.registerClass(-177282392, ClassLiteral<TLChannelParticipants>.Value);
            this.registerClass(-791039645, ClassLiteral<TLChannelParticipant>.Value);
            this.registerClass(-820669733, ClassLiteral<TLRequestMessagesReportSpam>.Value);
            this.registerClass(-993483427, ClassLiteral<TLRequestMessagesGetMessagesViews>.Value);
            this.registerClass(-787622117, ClassLiteral<TLRequestChannelsDeleteUserHistory>.Value);
            this.registerClass(-32999408, ClassLiteral<TLRequestChannelsReportSpam>.Value);
            this.registerClass(-1814580409, ClassLiteral<TLRequestChannelsGetMessages>.Value);
            this.registerClass(0x24d98f92, ClassLiteral<TLRequestChannelsGetParticipants>.Value);
            this.registerClass(0x546dd7a6, ClassLiteral<TLRequestChannelsGetParticipant>.Value);
            this.registerClass(0xa7f6bbb, ClassLiteral<TLRequestChannelsGetParticipant>.Value);
            this.registerClass(0x8736a09, ClassLiteral<TLRequestChannelsGetFullChannel>.Value);
            this.registerClass(0x13e27f1e, ClassLiteral<TLRequestChannelsEditAbout>.Value);
            this.registerClass(0x566decd0, ClassLiteral<TLRequestChannelsEditTitle>.Value);
            this.registerClass(0x10e6bd2c, ClassLiteral<TLRequestChannelsCheckUsername>.Value);
            this.registerClass(0x3514b3de, ClassLiteral<TLRequestChannelsUpdateUsername>.Value);
            this.registerClass(-344583728, ClassLiteral<TLRequestChannelsEditAdmin>.Value);
            this.registerClass(-248621111, ClassLiteral<TLRequestChannelsEditPhoto>.Value);
            this.registerClass(0x24b524c5, ClassLiteral<TLRequestChannelsJoinChannel>.Value);
            this.registerClass(-130635115, ClassLiteral<TLRequestChannelsLeaveChannel>.Value);
            this.registerClass(-950663035, ClassLiteral<TLRequestChannelsExportInvite>.Value);
            this.registerClass(-1072619549, ClassLiteral<TLRequestChannelsDeleteChannel>.Value);
            this.registerClass(0x199f3a6c, ClassLiteral<TLRequestChannelsInviteToChannel>.Value);
            this.registerClass(-1502421484, ClassLiteral<TLRequestChannelsKickFromChannel>.Value);
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 
            0xa2, 210, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70,
            0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70,
            0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70,
            0x70, 0x70, 0x70, 0x70, 0x70, 0x72
        })]
        private void addApiLayer45()
        {
            this.registerClass(0x3fedd339, ClassLiteral<TLTrue>.Value);
            this.registerClass(0x4843b0fd, ClassLiteral<TLInputMediaGifExternal>.Value);
            this.registerClass(-636267638, ClassLiteral<TLChatParticipantCreator>.Value);
            this.registerClass(-489233354, ClassLiteral<TLChatParticipantAdmin>.Value);
            this.registerClass(0x51bdb021, ClassLiteral<TLMessageActionMigrateTo>.Value);
            this.registerClass(-1336546578, ClassLiteral<TLMessageActionChannelMigratedFrom>.Value);
            this.registerClass(0x58dbcab8, ClassLiteral<TLReportSpamReasonSpam>.Value);
            this.registerClass(0x1e22c78d, ClassLiteral<TLReportSpamReasonViolence>.Value);
            this.registerClass(0x2e59d922, ClassLiteral<TLReportSpamReasonPornography>.Value);
            this.registerClass(-512463606, ClassLiteral<TLReportSpamReasonOther>.Value);
            this.registerClass(-3644025, ClassLiteral<TLMessagesFilterGif>.Value);
            this.registerClass(0x50f5c392, ClassLiteral<TLMessagesFilterVoice>.Value);
            this.registerClass(0x3751b49e, ClassLiteral<TLMessagesFilterMusic>.Value);
            this.registerClass(0x6e947941, ClassLiteral<TLUpdateChatAdmin>.Value);
            this.registerClass(-1232070311, ClassLiteral<TLUpdateChatParticipantAdmin>.Value);
            this.registerClass(0x688a30aa, ClassLiteral<TLUpdateNewStickerSet>.Value);
            this.registerClass(0xbb2d201, ClassLiteral<TLUpdateStickerSetsOrder>.Value);
            this.registerClass(0x43ae3dec, ClassLiteral<TLUpdateStickerSets>.Value);
            this.registerClass(-1821035490, ClassLiteral<TLUpdateSavedGifs>.Value);
            this.registerClass(0x54826690, ClassLiteral<TLUpdateBotInlineQuery>.Value);
            this.registerClass(0xe48f964, ClassLiteral<TLUpdateBotInlineSend>.Value);
            this.registerClass(-1107622874, ClassLiteral<TLInputPrivacyKeyChatInvite>.Value);
            this.registerClass(0x500e6dfa, ClassLiteral<TLPrivacyKeyChatInvite>.Value);
            this.registerClass(-1328445861, ClassLiteral<TLChannelParticipantsFilterBots>.Value);
            this.registerClass(-236044656, ClassLiteral<TLTermsOfService>.Value);
            this.registerClass(0x162ecc1f, ClassLiteral<TLFoundGif>.Value);
            this.registerClass(-1670052855, ClassLiteral<TLFoundGifCached>.Value);
            this.registerClass(0x450a1c0a, ClassLiteral<TLFoundGifs>.Value);
            this.registerClass(0x2e0709a5, ClassLiteral<TLSavedGifs>.Value);
            this.registerClass(-402498398, ClassLiteral<TLSavedGifsNotModified>.Value);
            this.registerClass(0x292fed13, ClassLiteral<TLInputBotInlineMessageMediaAuto>.Value);
            this.registerClass(0x3dcd7a87, ClassLiteral<TLInputBotInlineMessageText>.Value);
            this.registerClass(0x2cbbe15a, ClassLiteral<TLInputBotInlineResult>.Value);
            this.registerClass(0xa74b15b, ClassLiteral<TLBotInlineMessageMediaAuto>.Value);
            this.registerClass(-1937807902, ClassLiteral<TLBotInlineMessageText>.Value);
            this.registerClass(-1679053127, ClassLiteral<TLBotInlineResult>.Value);
            this.registerClass(0x17db940b, ClassLiteral<TLBotInlineMediaResult>.Value);
            this.registerClass(-858565059, ClassLiteral<TLBotResults>.Value);
            this.registerClass(-1374118561, ClassLiteral<TLRequestAccountReportPeer>.Value);
            this.registerClass(0x350170f3, ClassLiteral<TLRequestHelpGetTermsOfService>.Value);
            this.registerClass(-326379039, ClassLiteral<TLRequestMessagesToggleChatAdmins>.Value);
            this.registerClass(-1444503762, ClassLiteral<TLRequestMessagesEditChatAdmin>.Value);
            this.registerClass(0x15a3b8e3, ClassLiteral<TLRequestMessagesMigrateChat>.Value);
            this.registerClass(-1640190800, ClassLiteral<TLRequestMessagesSearchGlobal>.Value);
            this.registerClass(0x78337739, ClassLiteral<TLRequestMessagesReorderStickerSets>.Value);
            this.registerClass(0x338e2464, ClassLiteral<TLRequestMessagesGetDocumentByHash>.Value);
            this.registerClass(-1080395925, ClassLiteral<TLRequestMessagesSearchGifs>.Value);
            this.registerClass(-2084618926, ClassLiteral<TLRequestMessagesGetSavedGifs>.Value);
            this.registerClass(0x327a30cb, ClassLiteral<TLRequestMessagesSaveGif>.Value);
            this.registerClass(0x514e999d, ClassLiteral<TLRequestMessagesGetInlineBotResults>.Value);
            this.registerClass(-346119674, ClassLiteral<TLRequestMessagesSetInlineBotResults>.Value);
            this.registerClass(-1318189314, ClassLiteral<TLRequestMessagesSendInlineBotResults>.Value);
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 
            0xa3, 9, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70,
            0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x72
        })]
        private void addApiLayer50()
        {
            this.registerClass(-1799538451, ClassLiteral<TLMessageActionPinMessage>.Value);
            this.registerClass(0x3dbb5986, ClassLiteral<TLSentCodeTypeApp>.Value);
            this.registerClass(-1073693790, ClassLiteral<TLSentCodeTypeSms>.Value);
            this.registerClass(0x5353e5a7, ClassLiteral<TLSentCodeTypeCall>.Value);
            this.registerClass(-1425815847, ClassLiteral<TLSentCodeTypeFlashCall>.Value);
            this.registerClass(-2122045747, ClassLiteral<TLPeerSettings>.Value);
            this.registerClass(0x1b3f4df7, ClassLiteral<TLUpdateEditChannelMessage>.Value);
            this.registerClass(-1738988427, ClassLiteral<TLUpdateChannelPinnedMessage>.Value);
            this.registerClass(0x1f486803, ClassLiteral<TLExportedMessageLink>.Value);
            this.registerClass(-947462709, ClassLiteral<TLMessageFwdHeader>.Value);
            this.registerClass(0x72a3158c, ClassLiteral<TLCodeTypeSms>.Value);
            this.registerClass(0x741cd3e3, ClassLiteral<TLCodeTypeCall>.Value);
            this.registerClass(0x226ccefb, ClassLiteral<TLCodeTypeFlashCall>.Value);
            this.registerClass(0x3ef1a9bf, ClassLiteral<TLRequestAuthResendCode>.Value);
            this.registerClass(0x1f040578, ClassLiteral<TLRequestAuthCancelCode>.Value);
            this.registerClass(-1460572005, ClassLiteral<TLRequestMessagesHideReportSpam>.Value);
            this.registerClass(0x3672e09c, ClassLiteral<TLRequestMessagesGetPeerSettings>.Value);
            this.registerClass(-934882771, ClassLiteral<TLRequestChannelsExportMessageLink>.Value);
            this.registerClass(0x1f69b606, ClassLiteral<TLRequestChannelsToggleSignatures>.Value);
            this.registerClass(-39416522, ClassLiteral<TLRequestMessagesGetMessageEditData>.Value);
            this.registerClass(-829299510, ClassLiteral<TLRequestMessagesEditMessage>.Value);
            this.registerClass(-1490162350, ClassLiteral<TLRequestChannelsUpdatePinnedMessage>.Value);
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 
            0xa3, 0x22, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70,
            0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x72
        })]
        private void addApiLayer51()
        {
            this.registerClass(-415938591, ClassLiteral<TLUpdateBotCallbackQuery>.Value);
            this.registerClass(-469536605, ClassLiteral<TLUpdateEditMessage>.Value);
            this.registerClass(-103646630, ClassLiteral<TLUpdateInlineBotCallbackQuery>.Value);
            this.registerClass(0x683a5e46, ClassLiteral<TLKeyboardButtonCallback>.Value);
            this.registerClass(0x258aff05, ClassLiteral<TLKeyboardButtonUrl>.Value);
            this.registerClass(-1318425559, ClassLiteral<TLKeyboardButtonRequestPhone>.Value);
            this.registerClass(-59151553, ClassLiteral<TLKeyboardButtonRequestGeoLocation>.Value);
            this.registerClass(0x568a748, ClassLiteral<TLKeyboardButtonRequestSwitchInline>.Value);
            this.registerClass(0x48a30254, ClassLiteral<TLReplayInlineKeyboardMarkup>.Value);
            this.registerClass(-190472735, ClassLiteral<TLInputBotInlineMessageMediaGeo>.Value);
            this.registerClass(-1431327288, ClassLiteral<TLInputBotInlineMessageMediaVenue>.Value);
            this.registerClass(0x2daf01a7, ClassLiteral<TLInputBotInlineMessageMediaContact>.Value);
            this.registerClass(-1462213465, ClassLiteral<TLInputBotInlineResultPhoto>.Value);
            this.registerClass(-459324, ClassLiteral<TLInputBotInlineResultDocument>.Value);
            this.registerClass(0x3a8fd8b8, ClassLiteral<TLBotInlineMessageMediaGeo>.Value);
            this.registerClass(0x4366232e, ClassLiteral<TLBotInlineMessageMediaVenue>.Value);
            this.registerClass(0x35edb4d4, ClassLiteral<TLBotInlineMessageMediaContact>.Value);
            this.registerClass(0x26b5dde6, ClassLiteral<TLMessagesEditData>.Value);
            this.registerClass(0x36585ea4, ClassLiteral<TLMessagesBotCallbackAnswer>.Value);
            this.registerClass(-1995686519, ClassLiteral<TLInputBotInlineMessageId>.Value);
            this.registerClass(0x3c20629f, ClassLiteral<TLInlineBotSwitchPm>.Value);
            this.registerClass(0x130c2c85, ClassLiteral<TLRequestMessagesEditInlineBotMessage>.Value);
            this.registerClass(-2130010132, ClassLiteral<TLRequestMessagesGetBotCallbackAnswer>.Value);
            this.registerClass(-712043766, ClassLiteral<TLRequestMessagesSetBotCallbackAnswer>.Value);
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 
            0xa3, 0x3d, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70,
            0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70,
            0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x72
        })]
        private void addApiLayer55()
        {
            this.registerClass(0x70b772a8, ClassLiteral<TLContactsTopPeers>.Value);
            this.registerClass(-567906571, ClassLiteral<TLContactsTopPeersNotModified>.Value);
            this.registerClass(-40996577, ClassLiteral<TLDraftMessage>.Value);
            this.registerClass(-1169445179, ClassLiteral<TLDraftMessageEmpty>.Value);
            this.registerClass(-437690244, ClassLiteral<TLInputMediaDocumentExternal>.Value);
            this.registerClass(-1252045032, ClassLiteral<TLInputMediaPhotoExternal>.Value);
            this.registerClass(0x208e68c9, ClassLiteral<TLInputMessageEntityMentionName>.Value);
            this.registerClass(-1615153660, ClassLiteral<TLMessageActionHistoryClear>.Value);
            this.registerClass(0x352dca58, ClassLiteral<TLMessageEntityMentionName>.Value);
            this.registerClass(0x4fcba9c8, ClassLiteral<TLMessagesArchivedStickers>.Value);
            this.registerClass(-123893531, ClassLiteral<TLMessagesFeaturedStickers>.Value);
            this.registerClass(0x4ede3cf, ClassLiteral<TLMessagesFeaturedStickersNotModified>.Value);
            this.registerClass(0x3a20ecb8, ClassLiteral<TLMessagesFilterChatPhoto>.Value);
            this.registerClass(0x3371c354, ClassLiteral<TLMessagesPeerDialogs>.Value);
            this.registerClass(0x5ce20970, ClassLiteral<TLMessagesRecentStickers>.Value);
            this.registerClass(0xb17f890, ClassLiteral<TLMessagesRecentStickersNotModified>.Value);
            this.registerClass(0x35e410a8, ClassLiteral<TLMessagesStickerSetInstallResultArchive>.Value);
            this.registerClass(0x38641628, ClassLiteral<TLMessagesStickerSetInstallResultSuccess>.Value);
            this.registerClass(-305282981, ClassLiteral<TLTopPeer>.Value);
            this.registerClass(0x148677e2, ClassLiteral<TLTopPeerCategoryBotsInline>.Value);
            this.registerClass(-1419371685, ClassLiteral<TLTopPeerCategoryBotsPM>.Value);
            this.registerClass(0x161d9628, ClassLiteral<TLTopPeerCategoryChannels>.Value);
            this.registerClass(0x637b7ed, ClassLiteral<TLTopPeerCategoryCorrespondents>.Value);
            this.registerClass(-1122524854, ClassLiteral<TLTopPeerCategoryGroups>.Value);
            this.registerClass(-75283823, ClassLiteral<TLTopPeerCategoryPeers>.Value);
            this.registerClass(-1574314746, ClassLiteral<TLUpdateConfig>.Value);
            this.registerClass(-299124375, ClassLiteral<TLUpdateDraftMessage>.Value);
            this.registerClass(0x3354678f, ClassLiteral<TLUpdatePtsChanged>.Value);
            this.registerClass(0x25d6c9c7, ClassLiteral<TLUpdateReadChannelOutbox>.Value);
            this.registerClass(0x571d2742, ClassLiteral<TLUpdateReadFeaturedStickers>.Value);
            this.registerClass(-1706939360, ClassLiteral<TLUpdateRecentStickers>.Value);
            this.registerClass(0x1516d7bd, ClassLiteral<TLRequestAccountSendConfirmPhoneCode>.Value);
            this.registerClass(0x5f2178c3, ClassLiteral<TLRequestAccountConfirmPhone>.Value);
            this.registerClass(-728224331, ClassLiteral<TLRequestContactsGetTopPeers>.Value);
            this.registerClass(0x1ae373ac, ClassLiteral<TLRequestContactsResetTopPeerRating>.Value);
            this.registerClass(0x2d9776b9, ClassLiteral<TLRequestMessagesGetPeerDialogs>.Value);
            this.registerClass(-1137057461, ClassLiteral<TLRequestMessagesSaveDraft>.Value);
            this.registerClass(0x6a3f8d65, ClassLiteral<TLRequestMessagesGetAllDrafts>.Value);
            this.registerClass(0x2dacca4f, ClassLiteral<TLRequestMessagesGetFeaturedStickers>.Value);
            this.registerClass(0x5b118126, ClassLiteral<TLRequestMessagesReadFeaturedStickers>.Value);
            this.registerClass(0x5ea192c9, ClassLiteral<TLRequestMessagesGetRecentStickers>.Value);
            this.registerClass(0x392718f8, ClassLiteral<TLRequestMessagesSaveRecentStickers>.Value);
            this.registerClass(-1986437075, ClassLiteral<TLRequestMessagesClearRecentStickers>.Value);
            this.registerClass(0x57f17692, ClassLiteral<TLRequestMessagesGetArchivedStickers>.Value);
            this.registerClass(-1920105769, ClassLiteral<TLRequestChannelsGetAdminedPublicChannels>.Value);
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 
            0xa3, 0x6d, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70,
            0x70, 0x72
        })]
        private void addApiLayer56()
        {
            this.registerClass(-1834538890, ClassLiteral<TLMessageActionGameScore>.Value);
            this.registerClass(-1744710921, ClassLiteral<TLDocumentAttributeHasStickers>.Value);
            this.registerClass(0x50f41ccf, ClassLiteral<TLKeyboardButtonGame>.Value);
            this.registerClass(0x6410a5d2, ClassLiteral<TLStickerSetCovered>.Value);
            this.registerClass(0x3407e51b, ClassLiteral<TLStickerSetMultiCovered>.Value);
            this.registerClass(-1361650766, ClassLiteral<TLMaskCoords>.Value);
            this.registerClass(0x4a992157, ClassLiteral<TLInputStickeredMediaPhoto>.Value);
            this.registerClass(0x438865b, ClassLiteral<TLInputStickeredMediaDocument>.Value);
            this.registerClass(0x58fffcd0, ClassLiteral<TLHighScore>.Value);
            this.registerClass(-1707344487, ClassLiteral<TLMessagesHighScores>.Value);
            this.registerClass(-1907842680, ClassLiteral<TLRequestAuthDropTempAuthKeys>.Value);
            this.registerClass(-1896289088, ClassLiteral<TLRequestMessagesSetGameScore>.Value);
            this.registerClass(-400399203, ClassLiteral<TLRequestMessagesGetGameHighScores>.Value);
            this.registerClass(0xf635e1b, ClassLiteral<TLRequestMessagesGetInlineGameHighScores>.Value);
            this.registerClass(0x65b8c79f, ClassLiteral<TLRequestMessagesGetMaskStickers>.Value);
            this.registerClass(-866424884, ClassLiteral<TLRequestMessagesGetAttachedStickers>.Value);
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0xa3, 0x80, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x72 })]
        private void addApiLayer57()
        {
            this.registerClass(-750828557, ClassLiteral<TLInputMediaGame>.Value);
            this.registerClass(-38694904, ClassLiteral<TLMessageMediaGame>.Value);
            this.registerClass(-580219064, ClassLiteral<TLSendMessageGamePlayAction>.Value);
            this.registerClass(0x4b425864, ClassLiteral<TLInputBotInlineMessageGame>.Value);
            this.registerClass(0x4fa417f2, ClassLiteral<TLInputBotInlineResultGame>.Value);
            this.registerClass(-1107729093, ClassLiteral<TLGame>.Value);
            this.registerClass(0x32c3e77, ClassLiteral<TLInputGameId>.Value);
            this.registerClass(-1020139510, ClassLiteral<TLInputGameShortName>.Value);
            this.registerClass(0x15ad9f64, ClassLiteral<TLRequestMessagesSetInlineGameScore>.Value);
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 
            0xa3, 140, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70,
            0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70,
            0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70,
            0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x72
        })]
        private void addApiLayer60()
        {
            this.registerClass(-1663561404, ClassLiteral<TLMessagesChatsSlice>.Value);
            this.registerClass(0x40771900, ClassLiteral<TLUpdateChannelWebPage>.Value);
            this.registerClass(-1425052898, ClassLiteral<TLUpdatePhoneCall>.Value);
            this.registerClass(0x4afe8f6d, ClassLiteral<TLDifferenceTooLong>.Value);
            this.registerClass(-88417185, ClassLiteral<TLInputPrivacyKeyPhoneCall>.Value);
            this.registerClass(0x3d662b7b, ClassLiteral<TLPrivacyKeyPhoneCall>.Value);
            this.registerClass(-2054908813, ClassLiteral<TLWebPageNotModified>.Value);
            this.registerClass(-599948721, ClassLiteral<TLTextEmpty>.Value);
            this.registerClass(0x744694e0, ClassLiteral<TLTextPlain>.Value);
            this.registerClass(0x6724abc4, ClassLiteral<TLTextBold>.Value);
            this.registerClass(-653089380, ClassLiteral<TLTextItalic>.Value);
            this.registerClass(-1054465340, ClassLiteral<TLTextUnderline>.Value);
            this.registerClass(-1678197867, ClassLiteral<TLTextStrike>.Value);
            this.registerClass(0x6c3f19b9, ClassLiteral<TLTextFixed>.Value);
            this.registerClass(0x3c2884c1, ClassLiteral<TLTextUrl>.Value);
            this.registerClass(-564523562, ClassLiteral<TLTextEmail>.Value);
            this.registerClass(0x7e6260d7, ClassLiteral<TLTextConcat>.Value);
            this.registerClass(0x13567e8a, ClassLiteral<TLPageBlockUnsupported>.Value);
            this.registerClass(0x70abc3fd, ClassLiteral<TLPageBlockTitle>.Value);
            this.registerClass(-1879401953, ClassLiteral<TLPageBlockSubtitle>.Value);
            this.registerClass(-1162877472, ClassLiteral<TLPageBlockAuthorDate>.Value);
            this.registerClass(-1076861716, ClassLiteral<TLPageBlockHeader>.Value);
            this.registerClass(-248793375, ClassLiteral<TLPageBlockSubheader>.Value);
            this.registerClass(0x467a0766, ClassLiteral<TLPageBlockParagraph>.Value);
            this.registerClass(-1066346178, ClassLiteral<TLPageBlockPreformatted>.Value);
            this.registerClass(0x48870999, ClassLiteral<TLPageBlockFooter>.Value);
            this.registerClass(-618614392, ClassLiteral<TLPageBlockDivider>.Value);
            this.registerClass(-837994576, ClassLiteral<TLPageBlockAnchor>.Value);
            this.registerClass(0x3a58c7f4, ClassLiteral<TLPageBlockList>.Value);
            this.registerClass(0x263d7c26, ClassLiteral<TLPageBlockBlockquote>.Value);
            this.registerClass(0x4f4456d3, ClassLiteral<TLPageBlockPullquote>.Value);
            this.registerClass(-372860542, ClassLiteral<TLPageBlockPhoto>.Value);
            this.registerClass(-640214938, ClassLiteral<TLPageBlockVideo>.Value);
            this.registerClass(0x39f23300, ClassLiteral<TLPageBlockCover>.Value);
            this.registerClass(-840826671, ClassLiteral<TLPageBlockEmbed>.Value);
            this.registerClass(0x292c7be9, ClassLiteral<TLPageBlockEmbedPost>.Value);
            this.registerClass(0x8b31c4f, ClassLiteral<TLPageBlockCollage>.Value);
            this.registerClass(0x130c8963, ClassLiteral<TLPageBlockSlideshow>.Value);
            this.registerClass(-1913754556, ClassLiteral<TLPagePart>.Value);
            this.registerClass(-677274263, ClassLiteral<TLPageFull>.Value);
            this.registerClass(0x1e36fded, ClassLiteral<TLInputPhoneCall>.Value);
            this.registerClass(0x5366c915, ClassLiteral<TLPhoneCallEmpty>.Value);
            this.registerClass(0x1b8f4ad1, ClassLiteral<TLPhoneCallWaiting>.Value);
            this.registerClass(-2089411356, ClassLiteral<TLPhoneCallRequested>.Value);
            this.registerClass(-1660057, ClassLiteral<TLPhoneCall>.Value);
            this.registerClass(0x50ca4de1, ClassLiteral<TLPhoneCallDiscarded>.Value);
            this.registerClass(-1655957568, ClassLiteral<TLPhoneConnection>.Value);
            this.registerClass(-1564789301, ClassLiteral<TLPhoneCallProtocol>.Value);
            this.registerClass(-326966976, ClassLiteral<TLPhonePhoneCall>.Value);
            this.registerClass(0x4b0c8c0f, ClassLiteral<TLRequestMessagesReportEncryptedSpam>.Value);
            this.registerClass(0xd0a48c4, ClassLiteral<TLRequestMessagesGetCommonChats>.Value);
            this.registerClass(-341307408, ClassLiteral<TLRequestMessagesGetAllChats>.Value);
            this.registerClass(0x32ca8f91, ClassLiteral<TLRequestMessagesGetWebPage>.Value);
            this.registerClass(-333262899, ClassLiteral<TLRequestHelpSetBotUpdatesStatus>.Value);
            this.registerClass(0x5b95b3d4, ClassLiteral<TLRequestPhoneRequestCall>.Value);
            this.registerClass(0x3bd2b4a0, ClassLiteral<TLRequestPhoneAcceptCall>.Value);
            this.registerClass(0x78d413a6, ClassLiteral<TLRequestPhoneDiscardCall>.Value);
            this.registerClass(0x17d54f61, ClassLiteral<TLRequestPhoneReceivedCall>.Value);
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 
            0xa3, 0xc9, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70,
            0x70, 0x72
        })]
        private void addApiLayer62()
        {
            this.registerClass(-2132731265, ClassLiteral<TLMessageActionPhoneCall>.Value);
            this.registerClass(-2134272152, ClassLiteral<TLMessagesFilterPhoneCalls>.Value);
            this.registerClass(-686710068, ClassLiteral<TLUpdateDialogPinned>.Value);
            this.registerClass(-657787251, ClassLiteral<TLUpdatePinnedDialogs>.Value);
            this.registerClass(-2095595325, ClassLiteral<TLUpdateBotWebhookJSON>.Value);
            this.registerClass(-1684914010, ClassLiteral<TLUpdateBotWebhookJSONQuery>.Value);
            this.registerClass(-2048646399, ClassLiteral<TLPhoneCallDiscardReasonMissed>.Value);
            this.registerClass(-527056480, ClassLiteral<TLPhoneCallDiscardReasonDisconnect>.Value);
            this.registerClass(0x57adc690, ClassLiteral<TLPhoneCallDiscardReasonHangup>.Value);
            this.registerClass(-84416311, ClassLiteral<TLPhoneCallDiscardReasonBusy>.Value);
            this.registerClass(0x7d748d04, ClassLiteral<TLDataJSON>.Value);
            this.registerClass(0x3289be6a, ClassLiteral<TLRequestMessagesToggleDialogPin>.Value);
            this.registerClass(-1784678844, ClassLiteral<TLRequestMessagesReorderPinnedDialogs>.Value);
            this.registerClass(-497756594, ClassLiteral<TLRequestMessagesGetPinnedDialogs>.Value);
            this.registerClass(-1440257555, ClassLiteral<TLRequestBotsSendCustomRequest>.Value);
            this.registerClass(-434028723, ClassLiteral<TLRequestBotsAnswerWebhookJSONQuery>.Value);
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0xa3, 220, 0x72 })]
        private void addApiLayer63()
        {
            this.registerClass(0x1c536a34, ClassLiteral<TLRequestPhoneSetCallRating>.Value);
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 
            0xa3, 0xe0, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70,
            0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70,
            0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x72
        })]
        private void addApiLayer64()
        {
            this.registerClass(-1844103547, ClassLiteral<TLInputMediaInvoice>.Value);
            this.registerClass(-2074799289, ClassLiteral<TLMessageMediaInvoice>.Value);
            this.registerClass(0x40699cd0, ClassLiteral<TLMessageActionPaymentSent>.Value);
            this.registerClass(-1892568281, ClassLiteral<TLMessageActionPaymentSentMe>.Value);
            this.registerClass(-523384512, ClassLiteral<TLUpdateBotShippingQuery>.Value);
            this.registerClass(0x5d2f3aa9, ClassLiteral<TLUpdateBotPrecheckoutQuery>.Value);
            this.registerClass(-1344716869, ClassLiteral<TLKeyboardButtonBuy>.Value);
            this.registerClass(-886477832, ClassLiteral<TLLabeledPrice>.Value);
            this.registerClass(-1022713000, ClassLiteral<TLInvoice>.Value);
            this.registerClass(-368917890, ClassLiteral<TLPaymentCharge>.Value);
            this.registerClass(0x1e8caaeb, ClassLiteral<TLPostAddress>.Value);
            this.registerClass(-1868808300, ClassLiteral<TLPaymentRequestedInfo>.Value);
            this.registerClass(-842892769, ClassLiteral<TLPaymentSavedCredentialsCard>.Value);
            this.registerClass(-971322408, ClassLiteral<TLWebDocument>.Value);
            this.registerClass(-1678949555, ClassLiteral<TLInputWebDocument>.Value);
            this.registerClass(-1036396922, ClassLiteral<TLInputWebFileLocation>.Value);
            this.registerClass(0x21e753bc, ClassLiteral<TLWebFile>.Value);
            this.registerClass(0x3f56aea3, ClassLiteral<TLPaymentsPaymentForm>.Value);
            this.registerClass(-784000893, ClassLiteral<TLPaymentsValidatedRequestedInfo>.Value);
            this.registerClass(0x6b56b921, ClassLiteral<TLPaymentsPaymentVerificationNeeded>.Value);
            this.registerClass(0x4e5f810d, ClassLiteral<TLPaymentsPaymentResult>.Value);
            this.registerClass(-74456004, ClassLiteral<TLPaymentsSavedInfo>.Value);
            this.registerClass(0x500911e1, ClassLiteral<TLPaymentsPaymentReceipt>.Value);
            this.registerClass(-1056001329, ClassLiteral<TLInputPaymentCredentialsSaved>.Value);
            this.registerClass(0x3417d728, ClassLiteral<TLInputPaymentCredentials>.Value);
            this.registerClass(-1239335713, ClassLiteral<TLShippingOption>.Value);
            this.registerClass(-614138572, ClassLiteral<TLAccountTmpPassword>.Value);
            this.registerClass(0x4a82327e, ClassLiteral<TLRequestGetTmpPassword>.Value);
            this.registerClass(-436833542, ClassLiteral<TLRequestMessagesSetBotShippingResults>.Value);
            this.registerClass(0x9c2dd95, ClassLiteral<TLRequestMessagesSetBotPrecheckoutResults>.Value);
            this.registerClass(0x24e6818d, ClassLiteral<TLRequestUploadGetWebFile>.Value);
            this.registerClass(-1712285883, ClassLiteral<TLRequestPaymentsGetPaymentForm>.Value);
            this.registerClass(-1601001088, ClassLiteral<TLRequestPaymentsGetPaymentReceipt>.Value);
            this.registerClass(0x770a8e74, ClassLiteral<TLRequestPaymentsValidateRequestedInfo>.Value);
            this.registerClass(0x2b8879b3, ClassLiteral<TLRequestPaymentsSendPaymentForm>.Value);
            this.registerClass(0x227d824b, ClassLiteral<TLRequestPaymentsGetSavedInfo>.Value);
            this.registerClass(-667062079, ClassLiteral<TLRequestPaymentsClearSavedInfo>.Value);
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0xa4, 8, 0x70, 0x70, 0x70, 0x72 })]
        private void addApiLayer65()
        {
            this.registerClass(0x6d003d3f, ClassLiteral<TLPhoneCallAccepted>.Value);
            this.registerClass(0x2efe1722, ClassLiteral<TLRequestPhoneConfirmCall>.Value);
            this.registerClass(0x277add7e, ClassLiteral<TLRequestPhoneSaveCallDebug>.Value);
            this.registerClass(0x55451fa9, ClassLiteral<TLRequestPhoneGetCallConfig>.Value);
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0xa4, 15, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x72 })]
        private void addApiLayer66()
        {
            this.registerClass(0x7a7c17a4, ClassLiteral<TLMessagesFilterRoundVoice>.Value);
            this.registerClass(-1253451181, ClassLiteral<TLMessagesFilterRoundVideo>.Value);
            this.registerClass(0x1508485a, ClassLiteral<TLFileCdnRedirect>.Value);
            this.registerClass(-1997373508, ClassLiteral<TLSendMessageRecordRoundAction>.Value);
            this.registerClass(0x243e1c66, ClassLiteral<TLSendMessageUploadRoundAction>.Value);
            this.registerClass(-283684427, ClassLiteral<TLPageBlockChannel>.Value);
            this.registerClass(-1449145777, ClassLiteral<TLCdnFile>.Value);
            this.registerClass(-290921362, ClassLiteral<TLCdnFileReuploadNeeded>.Value);
            this.registerClass(-914167110, ClassLiteral<TLCdnPublicKey>.Value);
            this.registerClass(0x5725e40a, ClassLiteral<TLCdnConfig>.Value);
            this.registerClass(0x2000bcc3, ClassLiteral<TLRequestUploadGetCdnFile>.Value);
            this.registerClass(0x2e7a2020, ClassLiteral<TLRequestReuploadCdnFile>.Value);
            this.registerClass(0x52029342, ClassLiteral<TLRequestHelpGetCdnConfig>.Value);
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 
            160, 0xaf, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70,
            0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70,
            0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70,
            0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70,
            0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70,
            0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70,
            0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70,
            0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70,
            0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70,
            0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70,
            0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70,
            0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70,
            0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70,
            0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70,
            0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70,
            0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70,
            0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70,
            0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70,
            0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x90, 0x90, 0x86, 0x86, 0x86,
            0x86, 0x86, 0x86, 0x86, 0x86, 0x86, 0x86, 0x86, 0x86, 0x86, 0x86, 0x86, 0x86, 0x86, 0x68
        })]
        protected internal override void init()
        {
            this.registerClass(0x56730bcc, ClassLiteral<TLNull>.Value);
            this.registerClass(-994444869, ClassLiteral<TLError>.Value);
            this.registerClass(-1132882121, ClassLiteral<TLBoolFalse>.Value);
            this.registerClass(-1720552011, ClassLiteral<TLBoolTrue>.Value);
            this.registerClass(0x1cb5c415, ClassLiteral<TLVector>.Value);
            this.registerClass(0x200250ba, ClassLiteral<TLUserEmpty>.Value);
            this.registerClass(-1195615476, ClassLiteral<TLInputNotifyPeer>.Value);
            this.registerClass(0x193b4417, ClassLiteral<TLInputNotifyUsers>.Value);
            this.registerClass(0x4a95e84e, ClassLiteral<TLInputNotifyChats>.Value);
            this.registerClass(-1540769658, ClassLiteral<TLInputNotifyAll>.Value);
            this.registerClass(0x96a18d5, ClassLiteral<TLFile>.Value);
            this.registerClass(0x204d3878, ClassLiteral<TLDecryptedMessage>.Value);
            this.registerClass(0x73164160, ClassLiteral<TLDecryptedMessageService>.Value);
            this.registerClass(0x1117dd5f, ClassLiteral<TLGeoPointEmpty>.Value);
            this.registerClass(0x2049d70c, ClassLiteral<TLGeoPoint>.Value);
            this.registerClass(0x7f3b18ea, ClassLiteral<TLInputPeerEmpty>.Value);
            this.registerClass(0x7da07ec9, ClassLiteral<TLInputPeerSelf>.Value);
            this.registerClass(0x7b8e7de6, ClassLiteral<TLInputPeerUser>.Value);
            this.registerClass(0x179be863, ClassLiteral<TLInputPeerChat>.Value);
            this.registerClass(0x6f8b8cb2, ClassLiteral<TLContacts>.Value);
            this.registerClass(-1219778094, ClassLiteral<TLContactsNotModified>.Value);
            this.registerClass(-317144808, ClassLiteral<TLEncryptedMessage>.Value);
            this.registerClass(0x23734b06, ClassLiteral<TLEncryptedMessageService>.Value);
            this.registerClass(0x5d75a138, ClassLiteral<TLDifferenceEmpty>.Value);
            this.registerClass(0xf49ca0, ClassLiteral<TLDifference>.Value);
            this.registerClass(-1459938943, ClassLiteral<TLDifferenceSlice>.Value);
            this.registerClass(0x1cd7bf0d, ClassLiteral<TLInputPhotoEmpty>.Value);
            this.registerClass(-74070332, ClassLiteral<TLInputPhoto>.Value);
            this.registerClass(-2128698738, ClassLiteral<TLCheckedPhone>.Value);
            this.registerClass(0x89f5c4a, ClassLiteral<TLDecryptedMessageMediaEmpty>.Value);
            this.registerClass(0x32798a8c, ClassLiteral<TLDecryptedMessageMediaPhoto>.Value);
            this.registerClass(0x524a415d, ClassLiteral<TLDecryptedMessageMediaVideo>.Value);
            this.registerClass(0x35480a59, ClassLiteral<TLDecryptedMessageMediaGeoPoint>.Value);
            this.registerClass(0x588a0a97, ClassLiteral<TLDecryptedMessageMediaContact>.Value);
            this.registerClass(-1332395189, ClassLiteral<TLDecryptedMessageMediaDocument>.Value);
            this.registerClass(0x57e0a9cb, ClassLiteral<TLDecryptedMessageMediaAudio>.Value);
            this.registerClass(-208488460, ClassLiteral<TLInputPhoneContact>.Value);
            this.registerClass(-860866985, ClassLiteral<TLWallPaper>.Value);
            this.registerClass(0x63117f24, ClassLiteral<TLWallPaperSolid>.Value);
            this.registerClass(0x5d8c6cc, ClassLiteral<TLDcOption>.Value);
            this.registerClass(0x561bc879, ClassLiteral<TLContactBlocked>.Value);
            this.registerClass(-1683826688, ClassLiteral<TLChatEmpty>.Value);
            this.registerClass(-652419756, ClassLiteral<TLChat>.Value);
            this.registerClass(0x7328bdb, ClassLiteral<TLChatForbidden>.Value);
            this.registerClass(0x2e02a614, ClassLiteral<TLChatFull>.Value);
            this.registerClass(0xe17e23c, ClassLiteral<TLPhotoSizeEmpty>.Value);
            this.registerClass(0x77bfb61b, ClassLiteral<TLPhotoSize>.Value);
            this.registerClass(-374917894, ClassLiteral<TLPhotoCachedSize>.Value);
            this.registerClass(0x1c138d15, ClassLiteral<TLBlocked>.Value);
            this.registerClass(-1878523231, ClassLiteral<TLBlockedSlice>.Value);
            this.registerClass(0x37c1011c, ClassLiteral<TLChatPhotoEmpty>.Value);
            this.registerClass(0x6153276a, ClassLiteral<TLChatPhoto>.Value);
            this.registerClass(-1586283796, ClassLiteral<TLDecryptedMessageActionSetMessageTTL>.Value);
            this.registerClass(-882895228, ClassLiteral<TLConfig>.Value);
            this.registerClass(0x3ace484c, ClassLiteral<TLContactsLink>.Value);
            this.registerClass(-1519637954, ClassLiteral<TLUpdatesState>.Value);
            this.registerClass(-1387117803, ClassLiteral<TLImportedContacts>.Value);
            this.registerClass(-1417756512, ClassLiteral<TLEncryptedChatEmpty>.Value);
            this.registerClass(0x3bf703dc, ClassLiteral<TLEncryptedChatWaiting>.Value);
            this.registerClass(-931638658, ClassLiteral<TLEncryptedChatRequested>.Value);
            this.registerClass(-94974410, ClassLiteral<TLEncryptedChat>.Value);
            this.registerClass(0x13d6dd27, ClassLiteral<TLEncryptedChatDiscarded>.Value);
            this.registerClass(-181407105, ClassLiteral<TLInputFile>.Value);
            this.registerClass(-95482955, ClassLiteral<TLInputFileBig>.Value);
            this.registerClass(-1938715001, ClassLiteral<TLMessages>.Value);
            this.registerClass(0xb446ae3, ClassLiteral<TLMessagesSlice>.Value);
            this.registerClass(-2082087340, ClassLiteral<TLMessageEmpty>.Value);
            this.registerClass(-1063525281, ClassLiteral<TLMessage>.Value);
            this.registerClass(-1642487306, ClassLiteral<TLMessageService>.Value);
            this.registerClass(-1916114267, ClassLiteral<TLPhotos>.Value);
            this.registerClass(0x15051f54, ClassLiteral<TLPhotosSlice>.Value);
            this.registerClass(0x64ff9fd5, ClassLiteral<TLMessagesChats>.Value);
            this.registerClass(0x1837c364, ClassLiteral<TLInputEncryptedFileEmpty>.Value);
            this.registerClass(0x64bd0306, ClassLiteral<TLInputEncryptedFileUploaded>.Value);
            this.registerClass(0x5a17b5e5, ClassLiteral<TLInputEncryptedFile>.Value);
            this.registerClass(0x2dc173c8, ClassLiteral<TLInputEncryptedFileBigUploaded>.Value);
            this.registerClass(-1649296275, ClassLiteral<TLPeerUser>.Value);
            this.registerClass(-1160714821, ClassLiteral<TLPeerChat>.Value);
            this.registerClass(0x70a68512, ClassLiteral<TLPeerNotifySettingsEmpty>.Value);
            this.registerClass(-1697798976, ClassLiteral<TLPeerNotifySettings>.Value);
            this.registerClass(-1230047312, ClassLiteral<TLMessageActionEmpty>.Value);
            this.registerClass(-1503425638, ClassLiteral<TLMessageActionChatCreate>.Value);
            this.registerClass(-1247687078, ClassLiteral<TLMessageActionChatEditTitle>.Value);
            this.registerClass(0x7fcb13a8, ClassLiteral<TLMessageActionChatEditPhoto>.Value);
            this.registerClass(-1780220945, ClassLiteral<TLMessageActionChatDeletePhoto>.Value);
            this.registerClass(0x488a7337, ClassLiteral<TLMessageActionChatAddUser>.Value);
            this.registerClass(-1297179892, ClassLiteral<TLMessageActionChatDeleteUser>.Value);
            this.registerClass(0x57e2f66c, ClassLiteral<TLMessagesFilterEmpty>.Value);
            this.registerClass(-1777752804, ClassLiteral<TLMessagesFilterPhotos>.Value);
            this.registerClass(-1614803355, ClassLiteral<TLMessagesFilterVideo>.Value);
            this.registerClass(0x56e9f0e4, ClassLiteral<TLMessagesFilterPhotoVideo>.Value);
            this.registerClass(-1629621880, ClassLiteral<TLMessagesFilterDocument>.Value);
            this.registerClass(0x1be31789, ClassLiteral<TLDecryptedMessageLayer>.Value);
            this.registerClass(-1432995067, ClassLiteral<TLFileUnknown>.Value);
            this.registerClass(0x7efe0e, ClassLiteral<TLFileJpeg>.Value);
            this.registerClass(-891180321, ClassLiteral<TLFileGif>.Value);
            this.registerClass(0xa4f63c0, ClassLiteral<TLFilePng>.Value);
            this.registerClass(-1373745011, ClassLiteral<TLFilePdf>.Value);
            this.registerClass(0x528a0677, ClassLiteral<TLFileMp3>.Value);
            this.registerClass(0x4b09ebbc, ClassLiteral<TLFileMov>.Value);
            this.registerClass(0x40bc6f52, ClassLiteral<TLFilePartial>.Value);
            this.registerClass(-1278304028, ClassLiteral<TLFileMp4>.Value);
            this.registerClass(0x1081464c, ClassLiteral<TLFileWebp>.Value);
            this.registerClass(0x7c596b46, ClassLiteral<TLFileLocationUnavailable>.Value);
            this.registerClass(0x53d69076, ClassLiteral<TLFileLocation>.Value);
            this.registerClass(-265263912, ClassLiteral<TLInputPeerNotifyEventsEmpty>.Value);
            this.registerClass(-395694988, ClassLiteral<TLInputPeerNotifyEventsAll>.Value);
            this.registerClass(-805141448, ClassLiteral<TLImportedContact>.Value);
            this.registerClass(-1910892683, ClassLiteral<TLNearestDc>.Value);
            this.registerClass(0x4f11bae1, ClassLiteral<TLUserProfilePhotoEmpty>.Value);
            this.registerClass(-715532088, ClassLiteral<TLUserProfilePhoto>.Value);
            this.registerClass(-438840932, ClassLiteral<TLMessagesChatFull>.Value);
            this.registerClass(0x5e002502, ClassLiteral<TLSentCode>.Value);
            this.registerClass(-925415106, ClassLiteral<TLChatParticipant>.Value);
            this.registerClass(0x3ded6320, ClassLiteral<TLMessageMediaEmpty>.Value);
            this.registerClass(0x3d8ce53d, ClassLiteral<TLMessageMediaPhoto>.Value);
            this.registerClass(0x56e0d474, ClassLiteral<TLMessageMediaGeo>.Value);
            this.registerClass(0x5e7d2f39, ClassLiteral<TLMessageMediaContact>.Value);
            this.registerClass(-1618676578, ClassLiteral<TLMessageMediaUnsupported>.Value);
            this.registerClass(-203411800, ClassLiteral<TLMessageMediaDocument>.Value);
            this.registerClass(-1038136962, ClassLiteral<TLEncryptedFileEmpty>.Value);
            this.registerClass(0x4a70994c, ClassLiteral<TLEncryptedFile>.Value);
            this.registerClass(0x9d05049, ClassLiteral<TLUserStatusEmpty>.Value);
            this.registerClass(-306628279, ClassLiteral<TLUserStatusOnline>.Value);
            this.registerClass(0x8c703f, ClassLiteral<TLUserStatusOffline>.Value);
            this.registerClass(0x1aa1f784, ClassLiteral<TLContactsFound>.Value);
            this.registerClass(0x18cb9f78, ClassLiteral<TLInviteText>.Value);
            this.registerClass(-1058912715, ClassLiteral<TLDhConfigNotModified>.Value);
            this.registerClass(0x2c221edd, ClassLiteral<TLDhConfig>.Value);
            this.registerClass(0x560f8935, ClassLiteral<TLSentEncryptedMessage>.Value);
            this.registerClass(-1802240206, ClassLiteral<TLSentEncryptedFile>.Value);
            this.registerClass(0x2331b22d, ClassLiteral<TLPhotoEmpty>.Value);
            this.registerClass(-1836524247, ClassLiteral<TLPhoto>.Value);
            this.registerClass(-57668565, ClassLiteral<TLChatParticipantsForbidden>.Value);
            this.registerClass(0x3f460fed, ClassLiteral<TLChatParticipants>.Value);
            this.registerClass(-1771768449, ClassLiteral<TLInputMediaEmpty>.Value);
            this.registerClass(0x630c9af1, ClassLiteral<TLInputMediaUploadedPhoto>.Value);
            this.registerClass(-373312269, ClassLiteral<TLInputMediaPhoto>.Value);
            this.registerClass(-104578748, ClassLiteral<TLInputMediaGeoPoint>.Value);
            this.registerClass(-1494984313, ClassLiteral<TLInputMediaContact>.Value);
            this.registerClass(-797904407, ClassLiteral<TLInputMediaUploadedDocument>.Value);
            this.registerClass(0x1a77f29c, ClassLiteral<TLInputMediaDocument>.Value);
            this.registerClass(-484987010, ClassLiteral<TLUpdatesTooLong>.Value);
            this.registerClass(-1857044719, ClassLiteral<TLUpdateShortMessage>.Value);
            this.registerClass(0x16812688, ClassLiteral<TLUpdateShortChatMessage>.Value);
            this.registerClass(0x78d4dec1, ClassLiteral<TLUpdateShort>.Value);
            this.registerClass(0x725b04c3, ClassLiteral<TLUpdatesCombined>.Value);
            this.registerClass(0x74ae4240, ClassLiteral<TLUpdates>.Value);
            this.registerClass(0x7bf2e6f6, ClassLiteral<TLAuthorization>.Value);
            this.registerClass(0x15ba6c40, ClassLiteral<TLDialogs>.Value);
            this.registerClass(0x71e094f3, ClassLiteral<TLDialogsSlice>.Value);
            this.registerClass(-1378534221, ClassLiteral<TLPeerNotifyEventsEmpty>.Value);
            this.registerClass(0x6d1ded88, ClassLiteral<TLPeerNotifyEventsAll>.Value);
            this.registerClass(0x38935eb2, ClassLiteral<TLInputPeerNotifySettings>.Value);
            this.registerClass(-457104426, ClassLiteral<TLInputGeoPointEmpty>.Value);
            this.registerClass(-206066487, ClassLiteral<TLInputGeoPoint>.Value);
            this.registerClass(-748155807, ClassLiteral<TLContactStatus>.Value);
            this.registerClass(0x1f2b0afd, ClassLiteral<TLUpdateNewMessage>.Value);
            this.registerClass(0x4e90bfd6, ClassLiteral<TLUpdateMessageId>.Value);
            this.registerClass(-1576161051, ClassLiteral<TLUpdateDeleteMessages>.Value);
            this.registerClass(0x5c486927, ClassLiteral<TLUpdateUserTyping>.Value);
            this.registerClass(-1704596961, ClassLiteral<TLUpdateChatUserTyping>.Value);
            this.registerClass(0x7761198, ClassLiteral<TLUpdateChatParticipants>.Value);
            this.registerClass(0x1bfbd823, ClassLiteral<TLUpdateUserStatus>.Value);
            this.registerClass(-1489818765, ClassLiteral<TLUpdateUserName>.Value);
            this.registerClass(-1791935732, ClassLiteral<TLUpdateUserPhoto>.Value);
            this.registerClass(0x2575bbb9, ClassLiteral<TLUpdateContactRegistered>.Value);
            this.registerClass(-1657903163, ClassLiteral<TLUpdateContactLink>.Value);
            this.registerClass(0x12bcbd9a, ClassLiteral<TLUpdateNewEncryptedMessage>.Value);
            this.registerClass(0x1710f156, ClassLiteral<TLUpdateEncryptedChatTyping>.Value);
            this.registerClass(-1264392051, ClassLiteral<TLUpdateEncryption>.Value);
            this.registerClass(0x38fe25b7, ClassLiteral<TLUpdateEncryptedMessagesRead>.Value);
            this.registerClass(-364179876, ClassLiteral<TLUpdateChatParticipantAdd>.Value);
            this.registerClass(0x6e5f8c22, ClassLiteral<TLUpdateChatParticipantDelete>.Value);
            this.registerClass(-1906403213, ClassLiteral<TLUpdateDcOptions>.Value);
            this.registerClass(0x770656a8, ClassLiteral<TLInputAppEvent>.Value);
            this.registerClass(-247351839, ClassLiteral<TLInputEncryptedChat>.Value);
            this.registerClass(0x14637196, ClassLiteral<TLInputFileLocation>.Value);
            this.registerClass(-182231723, ClassLiteral<TLInputEncryptedFileLocation>.Value);
            this.registerClass(0x430f0724, ClassLiteral<TLInputDocumentFileLocation>.Value);
            this.registerClass(0x17c6b5f6, ClassLiteral<TLSupport>.Value);
            this.registerClass(0x36f8c871, ClassLiteral<TLDocumentEmpty>.Value);
            this.registerClass(-1987579119, ClassLiteral<TLAppUpdate>.Value);
            this.registerClass(-1000708810, ClassLiteral<TLNoAppUpdate>.Value);
            this.registerClass(-1269012015, ClassLiteral<TLAffectedHistory>.Value);
            this.registerClass(-116274796, ClassLiteral<TLContact>.Value);
            this.registerClass(0xf220f3f, ClassLiteral<TLUserFull>.Value);
            this.registerClass(0x66ffba14, ClassLiteral<TLDialog>.Value);
            this.registerClass(-1182234929, ClassLiteral<TLInputUserEmpty>.Value);
            this.registerClass(-138301121, ClassLiteral<TLInputUserSelf>.Value);
            this.registerClass(-668391402, ClassLiteral<TLInputUser>.Value);
            this.registerClass(0x72f0eaae, ClassLiteral<TLInputDocumentEmpty>.Value);
            this.registerClass(0x18798952, ClassLiteral<TLInputDocument>.Value);
            this.registerClass(-543777747, ClassLiteral<TLExportedAuthorization>.Value);
            this.registerClass(0x1ca48f57, ClassLiteral<TLInputChatPhotoEmpty>.Value);
            this.registerClass(-1837345356, ClassLiteral<TLInputChatUploadedPhoto>.Value);
            this.registerClass(-1991004873, ClassLiteral<TLInputChatPhoto>.Value);
            this.registerClass(0x6719e45c, ClassLiteral<TLDecryptedMessageActionFlushHistory>.Value);
            this.registerClass(-217806717, ClassLiteral<TLDecryptedMessageActionNotifyLayer>.Value);
            this.registerClass(0xc4f40be, ClassLiteral<TLDecryptedMessageActionReadMessages>.Value);
            this.registerClass(0x511110b0, ClassLiteral<TLDecryptedMessageActionResend>.Value);
            this.registerClass(-1261946036, ClassLiteral<TLNotifyUsers>.Value);
            this.registerClass(0x74d07c60, ClassLiteral<TLNotifyAll>.Value);
            this.registerClass(-1073230141, ClassLiteral<TLNotifyChats>.Value);
            this.registerClass(-1613493288, ClassLiteral<TLNotifyPeer>.Value);
            this.registerClass(0x20212ca8, ClassLiteral<TLPhotosPhoto>.Value);
            this.registerClass(0x12b3ad31, ClassLiteral<TLRequestAccountGetNotifySettings>.Value);
            this.registerClass(-1068696894, ClassLiteral<TLRequestAccountGetWallPapers>.Value);
            this.registerClass(0x637ea878, ClassLiteral<TLRequestAccountRegisterDevice>.Value);
            this.registerClass(-612493497, ClassLiteral<TLRequestAccountResetNotifySettings>.Value);
            this.registerClass(0x65c55b40, ClassLiteral<TLRequestAccountUnregisterDevice>.Value);
            this.registerClass(-2067899501, ClassLiteral<TLRequestAccountUpdateNotifySettings>.Value);
            this.registerClass(0x78515775, ClassLiteral<TLRequestAccountUpdateProfile>.Value);
            this.registerClass(0x6628562c, ClassLiteral<TLRequestAccountUpdateStatus>.Value);
            this.registerClass(0x6fe51dfb, ClassLiteral<TLRequestAuthCheckPhone>.Value);
            this.registerClass(-440401971, ClassLiteral<TLRequestAuthExportAuthorization>.Value);
            this.registerClass(-470837741, ClassLiteral<TLRequestAuthImportAuthorization>.Value);
            this.registerClass(0x5717da40, ClassLiteral<TLRequestAuthLogOut>.Value);
            this.registerClass(-1616179942, ClassLiteral<TLRequestAuthResetAuthorizations>.Value);
            this.registerClass(-2035355412, ClassLiteral<TLRequestAuthSendCode>.Value);
            this.registerClass(0x771c1d97, ClassLiteral<TLRequestAuthSendInvites>.Value);
            this.registerClass(-1126886015, ClassLiteral<TLRequestAuthSignIn>.Value);
            this.registerClass(0x1b067634, ClassLiteral<TLRequestAuthSignUp>.Value);
            this.registerClass(0x332b49fc, ClassLiteral<TLRequestContactsBlock>.Value);
            this.registerClass(-1902823612, ClassLiteral<TLRequestContactsDeleteContact>.Value);
            this.registerClass(0x59ab389e, ClassLiteral<TLRequestContactsDeleteContacts>.Value);
            this.registerClass(-176409329, ClassLiteral<TLRequestContactsGetBlocked>.Value);
            this.registerClass(0x22c6aa08, ClassLiteral<TLRequestContactsGetContacts>.Value);
            this.registerClass(-995929106, ClassLiteral<TLRequestContactsGetStatuses>.Value);
            this.registerClass(0x11f812d8, ClassLiteral<TLRequestContactsSearch>.Value);
            this.registerClass(-634342611, ClassLiteral<TLRequestContactsImportContacts>.Value);
            this.registerClass(-448724803, ClassLiteral<TLRequestContactsUnblock>.Value);
            this.registerClass(-1372724842, ClassLiteral<TLRequestHelpGetAppUpdate>.Value);
            this.registerClass(-990308245, ClassLiteral<TLRequestHelpGetConfig>.Value);
            this.registerClass(0x4d392343, ClassLiteral<TLRequestHelpGetInviteText>.Value);
            this.registerClass(0x1fb33026, ClassLiteral<TLRequestHelpGetNearestDc>.Value);
            this.registerClass(-1663104819, ClassLiteral<TLRequestHelpGetSupport>.Value);
            this.registerClass(0x6f02f748, ClassLiteral<TLRequestHelpSaveAppLog>.Value);
            this.registerClass(0x69796de9, ClassLiteral<TLRequestInitConnection>.Value);
            this.registerClass(-878758099, ClassLiteral<TLRequestInvokeAfterMsg>.Value);
            this.registerClass(0x3dc4b4f0, ClassLiteral<TLRequestInvokeAfterMsgs>.Value);
            this.registerClass(0x3dbc0415, ClassLiteral<TLRequestMessagesAcceptEncryption>.Value);
            this.registerClass(-106911223, ClassLiteral<TLRequestMessagesAddChatUser>.Value);
            this.registerClass(0x9cb126e, ClassLiteral<TLRequestMessagesCreateChat>.Value);
            this.registerClass(-530505962, ClassLiteral<TLRequestMessagesDeleteChatUser>.Value);
            this.registerClass(0x1c015b09, ClassLiteral<TLRequestMessagesDeleteHistory>.Value);
            this.registerClass(-304536635, ClassLiteral<TLRequestMessagesDiscardEncryption>.Value);
            this.registerClass(-900957736, ClassLiteral<TLRequestMessagesEditChatPhoto>.Value);
            this.registerClass(-599447467, ClassLiteral<TLRequestMessagesEditChatTitle>.Value);
            this.registerClass(0x33963bf9, ClassLiteral<TLRequestMessagesForwardMessage>.Value);
            this.registerClass(0x708e0195, ClassLiteral<TLRequestMessagesForwardMessages>.Value);
            this.registerClass(0x3c6aa187, ClassLiteral<TLRequestMessagesGetChats>.Value);
            this.registerClass(0x26cf8950, ClassLiteral<TLRequestMessagesGetDhConfig>.Value);
            this.registerClass(0x191ba9c5, ClassLiteral<TLRequestMessagesGetDialogs>.Value);
            this.registerClass(0x3b831c66, ClassLiteral<TLRequestMessagesGetFullChat>.Value);
            this.registerClass(-1347868602, ClassLiteral<TLRequestMessagesGetHistory>.Value);
            this.registerClass(0x4222fa74, ClassLiteral<TLRequestMessagesGetMessages>.Value);
            this.registerClass(0x7f4b690a, ClassLiteral<TLRequestMessagesReadEncryptedHistory>.Value);
            this.registerClass(0xe306d3a, ClassLiteral<TLRequestMessagesReadHistory>.Value);
            this.registerClass(0x5a954c0, ClassLiteral<TLRequestMessagesReceivedMessages>.Value);
            this.registerClass(0x55a5bb66, ClassLiteral<TLRequestMessagesReceivedQueue>.Value);
            this.registerClass(-162681021, ClassLiteral<TLRequestMessagesRequestEncryption>.Value);
            this.registerClass(-732523960, ClassLiteral<TLRequestMessagesSearch>.Value);
            this.registerClass(-1451792525, ClassLiteral<TLRequestMessagesSendEncrypted>.Value);
            this.registerClass(-1701831834, ClassLiteral<TLRequestMessagesSendEncryptedFile>.Value);
            this.registerClass(0x32d439a4, ClassLiteral<TLRequestMessagesSendEncryptedService>.Value);
            this.registerClass(-923703407, ClassLiteral<TLRequestMessagesSendMedia>.Value);
            this.registerClass(-91733382, ClassLiteral<TLRequestMessagesSendMessage>.Value);
            this.registerClass(0x791451ed, ClassLiteral<TLRequestMessagesSetEncryptedTyping>.Value);
            this.registerClass(-1551737264, ClassLiteral<TLRequestMessagesSetTyping>.Value);
            this.registerClass(-1848823128, ClassLiteral<TLRequestPhotosGetUserPhotos>.Value);
            this.registerClass(-256159406, ClassLiteral<TLRequestPhotosUpdateProfilePhoto>.Value);
            this.registerClass(0x4f32c098, ClassLiteral<TLRequestPhotosUploadProfilePhoto>.Value);
            this.registerClass(0x25939651, ClassLiteral<TLRequestUpdatesGetDifference>.Value);
            this.registerClass(-304838614, ClassLiteral<TLRequestUpdatesGetState>.Value);
            this.registerClass(-475607115, ClassLiteral<TLRequestUploadGetFile>.Value);
            this.registerClass(-562337987, ClassLiteral<TLRequestUploadSaveBigFilePart>.Value);
            this.registerClass(-1291540959, ClassLiteral<TLRequestUploadSaveFilePart>.Value);
            this.registerClass(-902781519, ClassLiteral<TLRequestUsersGetFullUser>.Value);
            this.registerClass(0xd91a548, ClassLiteral<TLRequestUsersGetUsers>.Value);
            this.registerClass(-44119819, ClassLiteral<TLSendMessageCancelAction>.Value);
            this.registerClass(0x628cbc6f, ClassLiteral<TLSendMessageChooseContactAction>.Value);
            this.registerClass(0x176f8ba1, ClassLiteral<TLSendMessageGeoLocationAction>.Value);
            this.registerClass(-718310409, ClassLiteral<TLSendMessageRecordAudioAction>.Value);
            this.registerClass(-1584933265, ClassLiteral<TLSendMessageRecordVideoAction>.Value);
            this.registerClass(0x16bf744e, ClassLiteral<TLSendMessageTypingAction>.Value);
            this.registerClass(-212740181, ClassLiteral<TLSendMessageUploadAudioAction>.Value);
            this.registerClass(-1441998364, ClassLiteral<TLSendMessageUploadDocumentAction>.Value);
            this.registerClass(-774682074, ClassLiteral<TLSendMessageUploadPhotoAction>.Value);
            this.registerClass(-378127636, ClassLiteral<TLSendMessageUploadVideoAction>.Value);
            this.registerClass(-1094555409, ClassLiteral<TLUpdateNotifySettings>.Value);
            this.registerClass(-337352679, ClassLiteral<TLUpdateServiceNotification>.Value);
            this.registerClass(-2131957734, ClassLiteral<TLUpdateUserBlocked>.Value);
            this.registerClass(0x36a73f77, ClassLiteral<TLRequestMessagesReadContents>.Value);
            this.registerClass(0x3e0bdd7c, ClassLiteral<TLRequestAccountUpdateUsername>.Value);
            this.registerClass(0x2714d86c, ClassLiteral<TLRequestAccountCheckUsername>.Value);
            this.registerClass(-2016444625, ClassLiteral<TLRequestPhotosDeletePhotos>.Value);
            this.registerClass(0x49609307, ClassLiteral<TLRequestChannelsToggleInvites>.Value);
            this.registerClass(-627372787, ClassLiteral<TLRequestInvokeWithLayer>.Value);
            this.addApiLayer19();
            this.addApiLayer22();
            this.addApiLayer26();
            this.addApiLayer28();
            this.addApiLayer32();
            this.addApiLayer38();
            this.addApiLayer45();
            this.addApiLayer50();
            this.addApiLayer51();
            this.addApiLayer55();
            this.addApiLayer56();
            this.addApiLayer57();
            this.addApiLayer60();
            this.addApiLayer62();
            this.addApiLayer63();
            this.addApiLayer64();
            this.addApiLayer65();
            this.addApiLayer66();
        }
    }
}

