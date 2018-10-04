namespace ir.telegramp
{
    using IKVM.Attributes;
    using java.lang;
    using java.util;
    using java.util.function;
    using org.telegram.api.message;
    using org.telegram.api.notify.peer;
    using org.telegram.api.peer;
    using org.telegram.api.update;
    using org.telegram.api.update.encrypted;
    using org.telegram.api.updates;
    using org.telegram.api.updates.difference;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;

    public abstract class UpdatesHandlerBase : Object, IUpdatesHandler
    {
        private const string LOGTAG = "UPDATESHANDLERBASE";

        private bool checkPts(UpdateWrapper)
        {
            int num = 0;
            return (bool) num;
        }

        public bool checkSeq(int seq, int seqStart, int date)
        {
            int num = 0;
            return (bool) num;
        }

        public void getDifferences()
        {
        }

        private bool isChatMissing(int) => 
            true;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0xa2, 0xf1, 0x62, 0x68, 0xb2 })]
        private bool isNotifyPeerMissing(TLAbsNotifyPeer peer1)
        {
            int num = 0;
            if (peer1 is TLNotifyPeer)
            {
                num = (int) this.isPeerMissing(((TLNotifyPeer) peer1).getPeer());
            }
            return (bool) num;
        }

        [LineNumberTable(new byte[] { 0xa2, 0xe8, 0xe8, 0x45 })]
        private bool isPeerMissing(TLAbsPeer peer1)
        {
            if (peer1 is TLPeerUser)
            {
            }
            return true;
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x34d)]
        private bool isUserFromMessageMissing(TLAbsMessage message1) => 
            this.isUserFromMessageMissing(message1, false);

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 
            0x9e, 0xc6, 0x42, 130, 0x6b, 0x67, 0x62, 0x68, 0xad, 0x63, 0x6d, 0x75, 0x63, 0xae, 0x63, 0x68,
            0xb3, 0x70, 0x70, 0x88, 0x62, 0x69, 0xae, 0x63, 110, 0x76, 0x63, 0xaf, 0xac
        })]
        private bool isUserFromMessageMissing(TLAbsMessage message1, bool flag1)
        {
            int num3;
            int num4;
            int num = (int) flag1;
            int num2 = 1;
            if (message1 is TLMessage)
            {
                TLMessage message = message1;
                num3 = 1;
                if (message.hasFromId())
                {
                    num3 = (int) this.isUserMissing(message.getFromId());
                }
                num4 = 1;
                if (message.getToId() is TLPeerUser)
                {
                    num4 = (int) this.isUserMissing(message.getToId().getId());
                }
                else if (num != 0)
                {
                    num4 = (int) this.isChatMissing(message.getChatId());
                }
                int num5 = 1;
                if (message.isForwarded())
                {
                    num5 = (int) this.isUserMissing(message.getFwdFrom().getFromId());
                }
                num2 = (((num3 == 0) || (num4 == 0)) || (num5 == 0)) ? 0 : 1;
            }
            else if (message1 is TLMessageService)
            {
                TLMessageService service = message1;
                num3 = 1;
                if (service.hasFromId())
                {
                    num3 = (int) this.isUserMissing(service.getFromId());
                }
                num4 = 1;
                if (service.getToId() is TLPeerUser)
                {
                    num4 = (int) this.isUserMissing(service.getToId().getId());
                }
                else if (num != 0)
                {
                    num4 = (int) this.isChatMissing(service.getChatId());
                }
                num2 = ((num3 == 0) || (num4 == 0)) ? 0 : 1;
            }
            return (bool) num2;
        }

        private bool isUserFromShortMessageMissing(TLUpdateShortMessage) => 
            true;

        private bool isUserMissing(int) => 
            true;

        [MethodImpl(MethodImplOptions.NoInlining), Modifiers(0x100a), LineNumberTable(new byte[] { 0xa2, 0x8e, 0x67, 0x66, 0x66, 0x66 })]
        private static UpdateWrapper lambda$onTLAbsDifference$0(TLAbsUpdate update1)
        {
            UpdateWrapper wrapper = new UpdateWrapper(update1);
            wrapper.disablePtsCheck();
            wrapper.disableUpdatePts();
            wrapper.enableGettingDifferences();
            return wrapper;
        }

        [MethodImpl(MethodImplOptions.NoInlining), Modifiers(0x100a), LineNumberTable(new byte[] { 0xa2, 0x9c, 0x67, 0x66, 0x66 })]
        private static UpdateWrapper lambda$onTLChannelDifferences$1(TLAbsUpdate update1)
        {
            UpdateWrapper wrapper = new UpdateWrapper(update1);
            wrapper.disablePtsCheck();
            wrapper.disableUpdatePts();
            return wrapper;
        }

        [MethodImpl(MethodImplOptions.NoInlining), Signature("(Ljava/util/List<Lorg/telegram/api/chat/TLAbsChat;>;)V"), LineNumberTable(new byte[] { 0xa2, 170, 0x69 })]
        public void onChats(List chats)
        {
            this.onChatsCustom(chats);
        }

        [Signature("(Ljava/util/List<Lorg/telegram/api/chat/TLAbsChat;>;)V")]
        protected internal abstract void onChatsCustom(List l);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0xa2, 0x8a, 0x6c, 0x6c, 0x7b, 0xff, 6, 70, 0x67 })]
        public void onTLAbsDifference(TLAbsDifference absDifference)
        {
            this.onUsers(absDifference.getUsers());
            this.onChats(absDifference.getChats());
            absDifference.getNewMessages().stream().forEach((Consumer) new __<>Anon0(this));
            absDifference.getOtherUpdates().stream().map((Function) new __<>Anon1()).forEach((Consumer) new __<>Anon2(this));
        }

        protected internal abstract void onTLAbsMessageCustom(TLAbsMessage tlam);
        [MethodImpl(MethodImplOptions.NoInlining), Signature("(Ljava/util/List<Lorg/telegram/api/user/TLAbsUser;>;Ljava/util/List<Lorg/telegram/api/message/TLAbsMessage;>;Ljava/util/List<Lorg/telegram/api/update/TLAbsUpdate;>;Ljava/util/List<Lorg/telegram/api/chat/TLAbsChat;>;)V"), LineNumberTable(new byte[] { 0xa2, 0x98, 0x67, 0x68, 0x76, 0xff, 1, 0x45, 0x67 })]
        public void onTLChannelDifferences(List users, List messages, List newUpdates, List chats)
        {
            this.onUsers(users);
            this.onChats(chats);
            messages.stream().forEach((Consumer) new __<>Anon0(this));
            newUpdates.stream().map((Function) new __<>Anon3()).forEach((Consumer) new __<>Anon2(this));
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0xa2, 0x85, 0x69 })]
        private void onTLFakeUpdate(TLFakeUpdate update1)
        {
            this.onTLFakeUpdateCustom(update1);
        }

        protected internal abstract void onTLFakeUpdateCustom(TLFakeUpdate tlfu);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9e, 0xe8, 0xa2, 0x7c, 0xc5, 0x89 })]
        private void onTLUpdateBotCallbackQuery(TLUpdateBotCallbackQuery query1, bool flag1)
        {
            int num = (int) flag1;
            if (this.isUserMissing(query1.getUserId()) || this.isPeerMissing(query1.getPeer()))
            {
                if (num == 0)
                {
                }
            }
            else
            {
                this.onTLUpdateBotCallbackQueryCustom(query1);
            }
        }

        protected internal abstract void onTLUpdateBotCallbackQueryCustom(TLUpdateBotCallbackQuery tlubcq);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x31, 0x62, 110, 0xc5, 0x89 })]
        private void onTLUpdateBotInlineQuery(TLUpdateBotInlineQuery query1, bool flag1)
        {
            int num = (int) flag1;
            if (this.isUserMissing(query1.getUserId()))
            {
                if (num == 0)
                {
                }
            }
            else
            {
                this.onTLUpdateBotInlineQueryCustom(query1);
            }
        }

        protected internal abstract void onTLUpdateBotInlineQueryCustom(TLUpdateBotInlineQuery tlubiq);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x2f, 0xa2, 110, 0xc5, 0x89 })]
        private void onTLUpdateBotInlineSend(TLUpdateBotInlineSend send1, bool flag1)
        {
            int num = (int) flag1;
            if (this.isUserMissing(send1.getUserId()))
            {
                if (num == 0)
                {
                }
            }
            else
            {
                this.onTLUpdateBotInlineSendCustom(send1);
            }
        }

        protected internal abstract void onTLUpdateBotInlineSendCustom(TLUpdateBotInlineSend tlubis);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x3a, 0x42, 110, 0xc5, 0x89 })]
        private void onTLUpdateBotPrecheckoutQuery(TLUpdateBotPrecheckoutQuery query1, bool flag1)
        {
            int num = (int) flag1;
            if (this.isUserMissing(query1.getUserId()))
            {
                if (num == 0)
                {
                }
            }
            else
            {
                this.onTLUpdateBotPrecheckoutQueryCustom(query1);
            }
        }

        protected internal abstract void onTLUpdateBotPrecheckoutQueryCustom(TLUpdateBotPrecheckoutQuery tlubpq);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x3d, 130, 110, 0xc5, 0x89 })]
        private void onTLUpdateBotShippingQuery(TLUpdateBotShippingQuery query1, bool flag1)
        {
            int num = (int) flag1;
            if (this.isUserMissing(query1.getUserId()))
            {
                if (num == 0)
                {
                }
            }
            else
            {
                this.onTLUpdateBotShippingQueryCustom(query1);
            }
        }

        protected internal abstract void onTLUpdateBotShippingQueryCustom(TLUpdateBotShippingQuery tlubsq);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 160, 170, 0x69 })]
        private void onTLUpdateBotWebhookJSON(TLUpdateBotWebhookJSON kjson1)
        {
            this.onTLUpdateBotWebhookJSONCustom(kjson1);
        }

        protected internal abstract void onTLUpdateBotWebhookJSONCustom(TLUpdateBotWebhookJSON tlubwjson);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 160, 0xae, 0x69 })]
        private void onTLUpdateBotWebhookJSONQuery(TLUpdateBotWebhookJSONQuery query1)
        {
            this.onTLUpdateBotWebhookJSONQueryCustom(query1);
        }

        protected internal abstract void onTLUpdateBotWebhookJSONQueryCustom(TLUpdateBotWebhookJSONQuery tlubwjsonq);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x34, 0xa2, 110, 0xc5, 0x89 })]
        private void onTLUpdateChannel(TLUpdateChannel channel1, bool flag1)
        {
            int num = (int) flag1;
            if (this.isChatMissing(channel1.getChannelId()))
            {
                if (num == 0)
                {
                }
            }
            else
            {
                this.onTLUpdateChannelCustom(channel1);
            }
        }

        protected internal abstract void onTLUpdateChannelCustom(TLUpdateChannel tluc);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x2c, 0x62, 110, 0xc5, 0x89 })]
        private void onTLUpdateChannelMessageViews(TLUpdateChannelMessageViews views1, bool flag1)
        {
            int num = (int) flag1;
            if (this.isChatMissing(views1.getChannelId()))
            {
                if (num == 0)
                {
                }
            }
            else
            {
                this.onTLUpdateChannelMessageViewsCustom(views1);
            }
        }

        protected internal abstract void onTLUpdateChannelMessageViewsCustom(TLUpdateChannelMessageViews tlucmv);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x38, 130, 0x6f, 110, 0xe5, 0x4a, 0x89 })]
        private void onTLUpdateChannelNewMessage(TLUpdateChannelNewMessage message1, bool flag1)
        {
            int num = (int) flag1;
            if (this.isUserFromMessageMissing(message1.getMessage(), false))
            {
                if (!this.isChatMissing(message1.getChannelId()) || (num != 0))
                {
                }
            }
            else
            {
                this.onTLUpdateChannelNewMessageCustom(message1);
            }
        }

        protected internal abstract void onTLUpdateChannelNewMessageCustom(TLUpdateChannelNewMessage tlucnm);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x2a, 0xa2, 110, 0xc5, 0x89 })]
        private void onTLUpdateChannelPinnedMessage(TLUpdateChannelPinnedMessage message1, bool flag1)
        {
            int num = (int) flag1;
            if (this.isChatMissing(message1.getChannelId()))
            {
                if (num == 0)
                {
                }
            }
            else
            {
                this.onTLUpdateChannelPinnedMessageCustom(message1);
            }
        }

        protected internal abstract void onTLUpdateChannelPinnedMessageCustom(TLUpdateChannelPinnedMessage tlucpm);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x27, 0x62, 110, 0xe3, 0x49 })]
        private void onTLUpdateChannelTooLong(TLUpdateChannelTooLong long1, bool flag1)
        {
            int num = (int) flag1;
            if (this.isChatMissing(long1.getChannelId()) && (num == 0))
            {
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x44, 0x42, 110, 0xc5, 0x89 })]
        private void onTLUpdateChannelWebPage(TLUpdateChannelWebPage page1, bool flag1)
        {
            int num = (int) flag1;
            if (this.isChatMissing(page1.getChannelId()))
            {
                if (num == 0)
                {
                }
            }
            else
            {
                this.onTLUpdateChannelWebPageCustom(page1);
            }
        }

        protected internal abstract void onTLUpdateChannelWebPageCustom(TLUpdateChannelWebPage tlucwp);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x24, 130, 110, 0xc5, 0x89 })]
        private void onTLUpdateChatAdmin(TLUpdateChatAdmin admin1, bool flag1)
        {
            int num = (int) flag1;
            if (this.isChatMissing(admin1.getChatId()))
            {
                if (num == 0)
                {
                }
            }
            else
            {
                this.onTLUpdateChatAdminCustom(admin1);
            }
        }

        protected internal abstract void onTLUpdateChatAdminCustom(TLUpdateChatAdmin tluca);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x21, 0x42, 0x7f, 11, 0xc5, 0x89 })]
        private void onTLUpdateChatParticipantAdd(TLUpdateChatParticipantAdd add1, bool flag1)
        {
            int num = (int) flag1;
            if ((this.isChatMissing(add1.getChatId()) || this.isUserMissing(add1.getUserId())) || this.isUserMissing(add1.getInviterId()))
            {
                if (num == 0)
                {
                }
            }
            else
            {
                this.onTLUpdateChatParticipantAddCustom(add1);
            }
        }

        protected internal abstract void onTLUpdateChatParticipantAddCustom(TLUpdateChatParticipantAdd tlucpa);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x1f, 130, 0x7c, 0xc5, 0x89 })]
        private void onTLUpdateChatParticipantAdmin(TLUpdateChatParticipantAdmin admin1, bool flag1)
        {
            int num = (int) flag1;
            if (this.isChatMissing(admin1.getChatId()) || this.isUserMissing(admin1.getUserId()))
            {
                if (num == 0)
                {
                }
            }
            else
            {
                this.onTLUpdateChatParticipantAdminCustom(admin1);
            }
        }

        protected internal abstract void onTLUpdateChatParticipantAdminCustom(TLUpdateChatParticipantAdmin tlucpa);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x1c, 0x42, 0x7c, 0xc5, 0x89 })]
        private void onTLUpdateChatParticipantDelete(TLUpdateChatParticipantDelete delete1, bool flag1)
        {
            int num = (int) flag1;
            if (this.isChatMissing(delete1.getChatId()) || this.isUserMissing(delete1.getUserId()))
            {
                if (num == 0)
                {
                }
            }
            else
            {
                this.onTLUpdateChatParticipantDeleteCustom(delete1);
            }
        }

        protected internal abstract void onTLUpdateChatParticipantDeleteCustom(TLUpdateChatParticipantDelete tlucpd);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x42, 130, 0x73, 0xc5, 0x89 })]
        private void onTLUpdateChatParticipants(TLUpdateChatParticipants participants1, bool flag1)
        {
            int num = (int) flag1;
            if (this.isChatMissing(participants1.getParticipants().getChatId()))
            {
                if (num == 0)
                {
                }
            }
            else
            {
                this.onTLUpdateChatParticipantsCustom(participants1);
            }
        }

        protected internal abstract void onTLUpdateChatParticipantsCustom(TLUpdateChatParticipants tlucp);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x1a, 130, 0x7c, 0xc5, 0x89 })]
        private void onTLUpdateChatUserTyping(TLUpdateChatUserTyping typing1, bool flag1)
        {
            int num = (int) flag1;
            if (this.isChatMissing(typing1.getChatId()) || this.isUserMissing(typing1.getUserId()))
            {
                if (num == 0)
                {
                }
            }
            else
            {
                this.onTLUpdateChatUserTypingCustom(typing1);
            }
        }

        protected internal abstract void onTLUpdateChatUserTypingCustom(TLUpdateChatUserTyping tlucut);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0xa2, 0x57, 0x69 })]
        private void onTLUpdateConfig(TLUpdateConfig config1)
        {
            this.onTLUpdateConfigCustom(config1);
        }

        protected internal abstract void onTLUpdateConfigCustom(TLUpdateConfig tluc);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x17, 0x42, 110, 0xc5, 0x89 })]
        private void onTLUpdateContactLink(TLUpdateContactLink link1, bool flag1)
        {
            int num = (int) flag1;
            if (this.isUserMissing(link1.getUserId()))
            {
                if (num == 0)
                {
                }
            }
            else
            {
                this.onTLUpdateContactLinkCustom(link1);
            }
        }

        protected internal abstract void onTLUpdateContactLinkCustom(TLUpdateContactLink tlucl);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x15, 130, 110, 0xc5, 0x89 })]
        private void onTLUpdateContactRegistered(TLUpdateContactRegistered registered1, bool flag1)
        {
            int num = (int) flag1;
            if (this.isUserMissing(registered1.getUserId()))
            {
                if (num == 0)
                {
                }
            }
            else
            {
                this.onTLUpdateContactRegisteredCustom(registered1);
            }
        }

        protected internal abstract void onTLUpdateContactRegisteredCustom(TLUpdateContactRegistered tlucr);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0xa1, 0x7e, 0x69 })]
        private void onTLUpdateDcOptions(TLUpdateDcOptions options1)
        {
            this.onTLUpdateDcOptionsCustom(options1);
        }

        protected internal abstract void onTLUpdateDcOptionsCustom(TLUpdateDcOptions tludo);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x11, 0x42, 110, 0xc5, 0x89 })]
        private void onTLUpdateDeleteChannelMessages(TLUpdateDeleteChannelMessages messages1, bool flag1)
        {
            int num = (int) flag1;
            if (this.isChatMissing(messages1.getChannelId()))
            {
                if (num == 0)
                {
                }
            }
            else
            {
                this.onTLUpdateDeleteChannelMessagesCustom(messages1);
            }
        }

        protected internal abstract void onTLUpdateDeleteChannelMessagesCustom(TLUpdateDeleteChannelMessages tludcm);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0xa1, 140, 0x69 })]
        private void onTLUpdateDeleteMessages(TLUpdateDeleteMessages messages1, bool)
        {
            this.onTLUpdateDeleteMessagesCustom(messages1);
        }

        protected internal abstract void onTLUpdateDeleteMessagesCustom(TLUpdateDeleteMessages tludm);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 160, 0xa2, 0x69 })]
        private void onTLUpdateDialogPinned(TLUpdateDialogPinned pinned1)
        {
            this.onTLUpdateDialogPinnedCustom(pinned1);
        }

        protected internal abstract void onTLUpdateDialogPinnedCustom(TLUpdateDialogPinned tludp);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9e, 0xdb, 0x62, 110, 0xc5, 0x89 })]
        private void onTLUpdateDraftMessage(TLUpdateDraftMessage message1, bool flag1)
        {
            int num = (int) flag1;
            if (this.isPeerMissing(message1.getPeer()))
            {
                if (num == 0)
                {
                }
            }
            else
            {
                this.onTLUpdateDraftMessageCustom(message1);
            }
        }

        protected internal abstract void onTLUpdateDraftMessageCustom(TLUpdateDraftMessage tludm);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 14, 130, 0x6f, 110, 0xe5, 0x4a, 0x89 })]
        private void onTLUpdateEditChannelMessage(TLUpdateEditChannelMessage message1, bool flag1)
        {
            int num = (int) flag1;
            if (this.isUserFromMessageMissing(message1.getMessage(), false))
            {
                if (!this.isChatMissing(message1.getChannelId()) || (num != 0))
                {
                }
            }
            else
            {
                this.onTLUpdateEditChannelMessageCustom(message1);
            }
        }

        protected internal abstract void onTLUpdateEditChannelMessageCustom(TLUpdateEditChannelMessage tluecm);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9e, 0xe5, 0x62, 110, 0xc5, 0x89 })]
        private void onTLUpdateEditMessage(TLUpdateEditMessage message1, bool flag1)
        {
            int num = (int) flag1;
            if (this.isUserFromMessageMissing(message1.getMessage()))
            {
                if (num == 0)
                {
                }
            }
            else
            {
                this.onTLUpdateEditMessageCustom(message1);
            }
        }

        protected internal abstract void onTLUpdateEditMessageCustom(TLUpdateEditMessage tluem);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0xa2, 0x4b, 0x69 })]
        private void onTLUpdateEncryptedChatTyping(TLUpdateEncryptedChatTyping typing1)
        {
            this.onTLUpdateEncryptedChatTypingCustom(typing1);
        }

        protected internal abstract void onTLUpdateEncryptedChatTypingCustom(TLUpdateEncryptedChatTyping tluect);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0xa2, 0x4f, 0x69 })]
        private void onTLUpdateEncryptedMessagesRead(TLUpdateEncryptedMessagesRead read1)
        {
            this.onTLUpdateEncryptedMessagesReadCustom(read1);
        }

        protected internal abstract void onTLUpdateEncryptedMessagesReadCustom(TLUpdateEncryptedMessagesRead tluemr);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0xa2, 0x47, 0x69 })]
        private void onTLUpdateEncryption(TLUpdateEncryption encryption1)
        {
            this.onTLUpdateEncryptionCustom(encryption1);
        }

        protected internal abstract void onTLUpdateEncryptionCustom(TLUpdateEncryption tlue);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9e, 0xe3, 0xa2, 110, 0xc5, 0x89 })]
        private void onTLUpdateInlineBotCallbackQuery(TLUpdateInlineBotCallbackQuery query1, bool flag1)
        {
            int num = (int) flag1;
            if (this.isUserMissing(query1.getUserId()))
            {
                if (num == 0)
                {
                }
            }
            else
            {
                this.onTLUpdateInlineBotCallbackQueryCustom(query1);
            }
        }

        protected internal abstract void onTLUpdateInlineBotCallbackQueryCustom(TLUpdateInlineBotCallbackQuery tluibcq);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0xa1, 0xa1, 0x69 })]
        private void onTLUpdateMessageId(TLUpdateMessageId id1)
        {
            this.onTLUpdateMessageIdCustom(id1);
        }

        protected internal abstract void onTLUpdateMessageIdCustom(TLUpdateMessageId tlumi);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0xa2, 0x53, 0x69 })]
        private void onTLUpdateNewEncryptedMessage(TLUpdateNewEncryptedMessage message1)
        {
            this.onTLUpdateNewEncryptedMessageCustom(message1);
        }

        protected internal abstract void onTLUpdateNewEncryptedMessageCustom(TLUpdateNewEncryptedMessage tlunem);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x3f, 0x42, 110, 0xc5, 0x89 })]
        private void onTLUpdateNewMessage(TLUpdateNewMessage message1, bool flag1)
        {
            int num = (int) flag1;
            if (this.isUserFromMessageMissing(message1.getMessage()))
            {
                if (num == 0)
                {
                }
            }
            else
            {
                this.onTLUpdateNewMessageCustom(message1);
            }
        }

        protected internal abstract void onTLUpdateNewMessageCustom(TLUpdateNewMessage tlunm);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0xa1, 0xa5, 0x69 })]
        private void onTLUpdateNewStickerSet(TLUpdateNewStickerSet set1)
        {
            this.onTLUpdateNewStickerSetCustom(set1);
        }

        protected internal abstract void onTLUpdateNewStickerSetCustom(TLUpdateNewStickerSet tlunss);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 8, 0xa2, 110, 0xc5, 0x89 })]
        private void onTLUpdateNotifySettings(TLUpdateNotifySettings settings1, bool flag1)
        {
            int num = (int) flag1;
            if (this.isNotifyPeerMissing(settings1.getPeer()))
            {
                if (num == 0)
                {
                }
            }
            else
            {
                this.onTLUpdateNotifySettingsCustom(settings1);
            }
        }

        protected internal abstract void onTLUpdateNotifySettingsCustom(TLUpdateNotifySettings tluns);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 160, 0xb2, 0x69 })]
        private void onTLUpdatePhoneCall(TLUpdatePhoneCall call1)
        {
            this.onTLUpdatePhoneCallCustom(call1);
        }

        protected internal abstract void onTLUpdatePhoneCallCustom(TLUpdatePhoneCall tlupc);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 160, 0xa6, 0x69 })]
        private void onTLUpdatePinnedDialogs(TLUpdatePinnedDialogs dialogs1)
        {
            this.onTLUpdatePinnedDialogsCustom(dialogs1);
        }

        protected internal abstract void onTLUpdatePinnedDialogsCustom(TLUpdatePinnedDialogs tlupd);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0xa1, 0xb3, 0x69 })]
        private void onTLUpdatePrivacy(TLUpdatePrivacy privacy1)
        {
            this.onTLUpdatePrivacyCustom(privacy1);
        }

        protected internal abstract void onTLUpdatePrivacyCustom(TLUpdatePrivacy tlup);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0xa2, 0x65, 0x69 })]
        private void onTLUpdatePtsChanged(TLUpdatePtsChanged changed1)
        {
            this.onTLUpdatePtsChangedCustom(changed1);
        }

        protected internal abstract void onTLUpdatePtsChangedCustom(TLUpdatePtsChanged tlupc);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 4, 0x62, 110, 0xc5, 0x89 })]
        private void onTLUpdateReadChannelInbox(TLUpdateReadChannelInbox inbox1, bool flag1)
        {
            int num = (int) flag1;
            if (this.isChatMissing(inbox1.getChannelId()))
            {
                if (num == 0)
                {
                }
            }
            else
            {
                this.onTLUpdateReadChannelInboxCustom(inbox1);
            }
        }

        protected internal abstract void onTLUpdateReadChannelInboxCustom(TLUpdateReadChannelInbox tlurci);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9e, 0xd8, 0xa2, 110, 0xc5, 0x89 })]
        private void onTLUpdateReadChannelOutbox(TLUpdateReadChannelOutbox outbox1, bool flag1)
        {
            int num = (int) flag1;
            if (this.isChatMissing(outbox1.getChannelId()))
            {
                if (num == 0)
                {
                }
            }
            else
            {
                this.onTLUpdateReadChannelOutboxCustom(outbox1);
            }
        }

        protected internal abstract void onTLUpdateReadChannelOutboxCustom(TLUpdateReadChannelOutbox tlurco);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0xa2, 0x73, 0x69 })]
        private void onTLUpdateReadFeaturedStickers(TLUpdateReadFeaturedStickers stickers1)
        {
            this.onTLUpdateReadFeaturedStickersCustom(stickers1);
        }

        protected internal abstract void onTLUpdateReadFeaturedStickersCustom(TLUpdateReadFeaturedStickers tlurfs);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0xa1, 0xc1, 0x69 })]
        private void onTLUpdateReadMessagesContents(TLUpdateReadMessagesContents contents1)
        {
            this.onTLUpdateReadMessagesContentsCustom(contents1);
        }

        protected internal abstract void onTLUpdateReadMessagesContentsCustom(TLUpdateReadMessagesContents tlurmc);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 1, 0xa2, 110, 0xc5, 0x89 })]
        private void onTLUpdateReadMessagesInbox(TLUpdateReadMessagesInbox inbox1, bool flag1)
        {
            int num = (int) flag1;
            if (this.isPeerMissing(inbox1.getPeer()))
            {
                if (num == 0)
                {
                }
            }
            else
            {
                this.onTLUpdateReadMessagesInboxCustom(inbox1);
            }
        }

        protected internal abstract void onTLUpdateReadMessagesInboxCustom(TLUpdateReadMessagesInbox tlurmi);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9e, 0xfe, 0x62, 110, 0xc5, 0x89 })]
        private void onTLUpdateReadMessagesOutbox(TLUpdateReadMessagesOutbox outbox1, bool flag1)
        {
            int num = (int) flag1;
            if (this.isPeerMissing(outbox1.getPeer()))
            {
                if (num == 0)
                {
                }
            }
            else
            {
                this.onTLUpdateReadMessagesOutboxCustom(outbox1);
            }
        }

        protected internal abstract void onTLUpdateReadMessagesOutboxCustom(TLUpdateReadMessagesOutbox tlurmo);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0xa2, 0x77, 0x69 })]
        private void onTLUpdateRecentStickers(TLUpdateRecentStickers stickers1)
        {
            this.onTLUpdateRecentStickersCustom(stickers1);
        }

        protected internal abstract void onTLUpdateRecentStickersCustom(TLUpdateRecentStickers tlurs);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0xa1, 0xd9, 0x69 })]
        private void onTLUpdateSavedGifs(TLUpdateSavedGifs gifs1)
        {
            this.onTLUpdateSavedGifsCustom(gifs1);
        }

        protected internal abstract void onTLUpdateSavedGifsCustom(TLUpdateSavedGifs tlusg);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0xa1, 0xdd, 0x69 })]
        private void onTLUpdateServiceNotification(TLUpdateServiceNotification notification1)
        {
            this.onTLUpdateServiceNotificationCustom(notification1);
        }

        protected internal abstract void onTLUpdateServiceNotificationCustom(TLUpdateServiceNotification tlusn);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x4d, 130, 0x7c, 0xc5, 0x89 })]
        private void onTLUpdateShortChatMessage(TLUpdateShortChatMessage message1, bool flag1)
        {
            int num = (int) flag1;
            if (this.isChatMissing(message1.getChatId()) || this.isUserMissing(message1.getFromId()))
            {
                if (num == 0)
                {
                }
            }
            else
            {
                this.onTLUpdateShortChatMessageCustom(message1);
            }
        }

        protected internal abstract void onTLUpdateShortChatMessageCustom(TLUpdateShortChatMessage tluscm);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x4f, 0x42, 0x69, 0xc5, 0x89 })]
        private void onTLUpdateShortMessage(TLUpdateShortMessage message1, bool flag1)
        {
            int num = (int) flag1;
            if (this.isUserFromShortMessageMissing(message1))
            {
                if (num == 0)
                {
                }
            }
            else
            {
                this.onTLUpdateShortMessageCustom(message1);
            }
        }

        protected internal abstract void onTLUpdateShortMessageCustom(TLUpdateShortMessage tlusm);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 160, 0x9e, 0x69 })]
        private void onTLUpdateShortSentMessage(TLUpdateShortSentMessage message1)
        {
            this.onTLUpdateShortSentMessageCustom(message1);
        }

        protected internal abstract void onTLUpdateShortSentMessageCustom(TLUpdateShortSentMessage tlussm);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0xa1, 0xe1, 0x69 })]
        private void onTLUpdateStickerSets(TLUpdateStickerSets sets1)
        {
            this.onTLUpdateStickerSetsCustom(sets1);
        }

        protected internal abstract void onTLUpdateStickerSetsCustom(TLUpdateStickerSets tluss);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0xa1, 0xe5, 0x69 })]
        private void onTLUpdateStickerSetsOrder(TLUpdateStickerSetsOrder order1)
        {
            this.onTLUpdateStickerSetsOrderCustom(order1);
        }

        protected internal abstract void onTLUpdateStickerSetsOrderCustom(TLUpdateStickerSetsOrder tlusso);
        public void onTLUpdatesTooLong()
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9e, 0xf8, 0xa2, 110, 0xc5, 0x89 })]
        private void onTLUpdateUserBlocked(TLUpdateUserBlocked blocked1, bool flag1)
        {
            int num = (int) flag1;
            if (this.isUserMissing(blocked1.getUserId()))
            {
                if (num == 0)
                {
                }
            }
            else
            {
                this.onTLUpdateUserBlockedCustom(blocked1);
            }
        }

        protected internal abstract void onTLUpdateUserBlockedCustom(TLUpdateUserBlocked tluub);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9e, 0xf5, 0x62, 110, 0xc5, 0x89 })]
        private void onTLUpdateUserName(TLUpdateUserName name1, bool flag1)
        {
            int num = (int) flag1;
            if (this.isUserMissing(name1.getUserId()))
            {
                if (num == 0)
                {
                }
            }
            else
            {
                this.onTLUpdateUserNameCustom(name1);
            }
        }

        protected internal abstract void onTLUpdateUserNameCustom(TLUpdateUserName tluun);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9e, 0xf3, 0xa2, 110, 0xc5, 0x89 })]
        private void onTLUpdateUserPhone(TLUpdateUserPhone phone1, bool flag1)
        {
            int num = (int) flag1;
            if (this.isUserMissing(phone1.getUserId()))
            {
                if (num == 0)
                {
                }
            }
            else
            {
                this.onTLUpdateUserPhoneCustom(phone1);
            }
        }

        protected internal abstract void onTLUpdateUserPhoneCustom(TLUpdateUserPhone tluup);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9e, 240, 0x62, 110, 0xc5, 0x89 })]
        private void onTLUpdateUserPhoto(TLUpdateUserPhoto photo1, bool flag1)
        {
            int num = (int) flag1;
            if (this.isUserMissing(photo1.getUserId()))
            {
                if (num == 0)
                {
                }
            }
            else
            {
                this.onTLUpdateUserPhotoCustom(photo1);
            }
        }

        protected internal abstract void onTLUpdateUserPhotoCustom(TLUpdateUserPhoto tluup);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9e, 0xee, 0xa2, 110, 0xc5, 0x89 })]
        private void onTLUpdateUserStatus(TLUpdateUserStatus status1, bool flag1)
        {
            int num = (int) flag1;
            if (this.isUserMissing(status1.getUserId()))
            {
                if (num == 0)
                {
                }
            }
            else
            {
                this.onTLUpdateUserStatusCustom(status1);
            }
        }

        protected internal abstract void onTLUpdateUserStatusCustom(TLUpdateUserStatus tluus);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9e, 0xeb, 0x62, 110, 0xc5, 0x89 })]
        private void onTLUpdateUserTyping(TLUpdateUserTyping typing1, bool flag1)
        {
            int num = (int) flag1;
            if (this.isUserMissing(typing1.getUserId()))
            {
                if (num == 0)
                {
                }
            }
            else
            {
                this.onTLUpdateUserTypingCustom(typing1);
            }
        }

        protected internal abstract void onTLUpdateUserTypingCustom(TLUpdateUserTyping tluut);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0xa2, 0x25, 0x69 })]
        private void onTLUpdateWebPage(TLUpdateWebPage page1)
        {
            this.onTLUpdateWebPageCustom(page1);
        }

        protected internal abstract void onTLUpdateWebPageCustom(TLUpdateWebPage tluwp);
        [MethodImpl(MethodImplOptions.NoInlining), Signature("(Ljava/util/List<Lorg/telegram/api/user/TLAbsUser;>;)V"), LineNumberTable(new byte[] { 0xa2, 0xa5, 0x69 })]
        public void onUsers(List users)
        {
            this.onUsersCustom(users);
        }

        [Signature("(Ljava/util/List<Lorg/telegram/api/user/TLAbsUser;>;)V")]
        protected internal abstract void onUsersCustom(List l);
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 
            7, 0x62, 0x68, 0xa8, 0x66, 0x87, 0x68, 0x77, 0x68, 0x77, 0x68, 0x71, 0x68, 0x77, 0x68, 0x77,
            0x68, 0x77, 0x68, 0x77, 0x68, 0x77, 0x68, 0x77, 0x68, 0x77, 0x68, 0x77, 0x68, 0x77, 0x68, 0x77,
            0x68, 0x77, 0x68, 0x77, 0x68, 0x77, 0x68, 0x77, 0x68, 0x77, 0x68, 0x77, 0x68, 0x71, 0x68, 0x77,
            0x68, 0x77, 0x68, 0x77, 0x68, 0x71, 0x68, 0x71, 0x68, 0x77, 0x68, 0x71, 0x68, 0x77, 0x68, 0x71,
            0x68, 0x77, 0x68, 0x77, 0x68, 0x71, 0x68, 0x71, 0x68, 0x71, 0x68, 0x71, 0x68, 0x77, 0x68, 0x77,
            0x68, 0x77, 0x68, 0x77, 0x68, 0x77, 0x68, 0x77, 0x68, 0x71, 0x68, 0x71, 0x68, 0x77, 0x68, 0x77,
            0x68, 0x77, 0x68, 0x71, 0x68, 0x71, 0x68, 0x71, 0x68, 0x71, 0x68, 0x71, 0x68, 0x77, 0x68, 0x71,
            0x68, 0x77, 0x68, 0x71, 0x68, 0x71, 0x68, 0x77, 0x68, 0x71, 0x68, 0x71, 0x68, 0x71, 0x68, 110,
            0x68, 110, 0x68, 0x74, 0x68, 210, 0x68, 0xa9
        })]
        public void processUpdate(UpdateWrapper updateWrapper)
        {
            int num = 1;
            if (updateWrapper.isCheckPts())
            {
                num = (int) this.checkPts(updateWrapper);
            }
            if (num != 0)
            {
                TLObject obj2 = updateWrapper.getUpdate();
                if (obj2 is TLUpdateShortMessage)
                {
                    this.onTLUpdateShortMessage((TLUpdateShortMessage) obj2, updateWrapper.isGettingDifferences());
                }
                else if (obj2 is TLUpdateShortChatMessage)
                {
                    this.onTLUpdateShortChatMessage((TLUpdateShortChatMessage) obj2, updateWrapper.isGettingDifferences());
                }
                else if (obj2 is TLUpdateShortSentMessage)
                {
                    this.onTLUpdateShortSentMessage((TLUpdateShortSentMessage) obj2);
                }
                else if (obj2 is TLUpdateNewMessage)
                {
                    this.onTLUpdateNewMessage((TLUpdateNewMessage) obj2, updateWrapper.isGettingDifferences());
                }
                else if (obj2 is TLUpdateChatParticipants)
                {
                    this.onTLUpdateChatParticipants((TLUpdateChatParticipants) obj2, updateWrapper.isGettingDifferences());
                }
                else if (obj2 is TLUpdateChannelNewMessage)
                {
                    this.onTLUpdateChannelNewMessage((TLUpdateChannelNewMessage) obj2, updateWrapper.isGettingDifferences());
                }
                else if (obj2 is TLUpdateChannel)
                {
                    this.onTLUpdateChannel((TLUpdateChannel) obj2, updateWrapper.isGettingDifferences());
                }
                else if (obj2 is TLUpdateBotInlineQuery)
                {
                    this.onTLUpdateBotInlineQuery((TLUpdateBotInlineQuery) obj2, updateWrapper.isGettingDifferences());
                }
                else if (obj2 is TLUpdateBotInlineSend)
                {
                    this.onTLUpdateBotInlineSend((TLUpdateBotInlineSend) obj2, updateWrapper.isGettingDifferences());
                }
                else if (obj2 is TLUpdateChannelMessageViews)
                {
                    this.onTLUpdateChannelMessageViews((TLUpdateChannelMessageViews) obj2, updateWrapper.isGettingDifferences());
                }
                else if (obj2 is TLUpdateChannelPinnedMessage)
                {
                    this.onTLUpdateChannelPinnedMessage((TLUpdateChannelPinnedMessage) obj2, updateWrapper.isGettingDifferences());
                }
                else if (obj2 is TLUpdateChannelTooLong)
                {
                    this.onTLUpdateChannelTooLong((TLUpdateChannelTooLong) obj2, updateWrapper.isGettingDifferences());
                }
                else if (obj2 is TLUpdateChatAdmin)
                {
                    this.onTLUpdateChatAdmin((TLUpdateChatAdmin) obj2, updateWrapper.isGettingDifferences());
                }
                else if (obj2 is TLUpdateChatParticipantAdd)
                {
                    this.onTLUpdateChatParticipantAdd((TLUpdateChatParticipantAdd) obj2, updateWrapper.isGettingDifferences());
                }
                else if (obj2 is TLUpdateChatParticipantAdmin)
                {
                    this.onTLUpdateChatParticipantAdmin((TLUpdateChatParticipantAdmin) obj2, updateWrapper.isGettingDifferences());
                }
                else if (obj2 is TLUpdateChatParticipantDelete)
                {
                    this.onTLUpdateChatParticipantDelete((TLUpdateChatParticipantDelete) obj2, updateWrapper.isGettingDifferences());
                }
                else if (obj2 is TLUpdateChatUserTyping)
                {
                    this.onTLUpdateChatUserTyping((TLUpdateChatUserTyping) obj2, updateWrapper.isGettingDifferences());
                }
                else if (obj2 is TLUpdateContactLink)
                {
                    this.onTLUpdateContactLink((TLUpdateContactLink) obj2, updateWrapper.isGettingDifferences());
                }
                else if (obj2 is TLUpdateContactRegistered)
                {
                    this.onTLUpdateContactRegistered((TLUpdateContactRegistered) obj2, updateWrapper.isGettingDifferences());
                }
                else if (obj2 is TLUpdateDcOptions)
                {
                    this.onTLUpdateDcOptions((TLUpdateDcOptions) obj2);
                }
                else if (obj2 is TLUpdateDeleteChannelMessages)
                {
                    this.onTLUpdateDeleteChannelMessages((TLUpdateDeleteChannelMessages) obj2, updateWrapper.isGettingDifferences());
                }
                else if (obj2 is TLUpdateDeleteMessages)
                {
                    this.onTLUpdateDeleteMessages((TLUpdateDeleteMessages) obj2, updateWrapper.isGettingDifferences());
                }
                else if (obj2 is TLUpdateEditChannelMessage)
                {
                    this.onTLUpdateEditChannelMessage((TLUpdateEditChannelMessage) obj2, updateWrapper.isGettingDifferences());
                }
                else if (obj2 is TLUpdateMessageId)
                {
                    this.onTLUpdateMessageId((TLUpdateMessageId) obj2);
                }
                else if (obj2 is TLUpdateNewStickerSet)
                {
                    this.onTLUpdateNewStickerSet((TLUpdateNewStickerSet) obj2);
                }
                else if (obj2 is TLUpdateNotifySettings)
                {
                    this.onTLUpdateNotifySettings((TLUpdateNotifySettings) obj2, updateWrapper.isGettingDifferences());
                }
                else if (obj2 is TLUpdatePrivacy)
                {
                    this.onTLUpdatePrivacy((TLUpdatePrivacy) obj2);
                }
                else if (obj2 is TLUpdateReadChannelInbox)
                {
                    this.onTLUpdateReadChannelInbox((TLUpdateReadChannelInbox) obj2, updateWrapper.isGettingDifferences());
                }
                else if (obj2 is TLUpdateReadMessagesContents)
                {
                    this.onTLUpdateReadMessagesContents((TLUpdateReadMessagesContents) obj2);
                }
                else if (obj2 is TLUpdateReadMessagesInbox)
                {
                    this.onTLUpdateReadMessagesInbox((TLUpdateReadMessagesInbox) obj2, updateWrapper.isGettingDifferences());
                }
                else if (obj2 is TLUpdateReadMessagesOutbox)
                {
                    this.onTLUpdateReadMessagesOutbox((TLUpdateReadMessagesOutbox) obj2, updateWrapper.isGettingDifferences());
                }
                else if (obj2 is TLUpdateSavedGifs)
                {
                    this.onTLUpdateSavedGifs((TLUpdateSavedGifs) obj2);
                }
                else if (obj2 is TLUpdateServiceNotification)
                {
                    this.onTLUpdateServiceNotification((TLUpdateServiceNotification) obj2);
                }
                else if (obj2 is TLUpdateStickerSets)
                {
                    this.onTLUpdateStickerSets((TLUpdateStickerSets) obj2);
                }
                else if (obj2 is TLUpdateStickerSetsOrder)
                {
                    this.onTLUpdateStickerSetsOrder((TLUpdateStickerSetsOrder) obj2);
                }
                else if (obj2 is TLUpdateUserBlocked)
                {
                    this.onTLUpdateUserBlocked((TLUpdateUserBlocked) obj2, updateWrapper.isGettingDifferences());
                }
                else if (obj2 is TLUpdateUserName)
                {
                    this.onTLUpdateUserName((TLUpdateUserName) obj2, updateWrapper.isGettingDifferences());
                }
                else if (obj2 is TLUpdateUserPhone)
                {
                    this.onTLUpdateUserPhone((TLUpdateUserPhone) obj2, updateWrapper.isGettingDifferences());
                }
                else if (obj2 is TLUpdateUserPhoto)
                {
                    this.onTLUpdateUserPhoto((TLUpdateUserPhoto) obj2, updateWrapper.isGettingDifferences());
                }
                else if (obj2 is TLUpdateUserStatus)
                {
                    this.onTLUpdateUserStatus((TLUpdateUserStatus) obj2, updateWrapper.isGettingDifferences());
                }
                else if (obj2 is TLUpdateUserTyping)
                {
                    this.onTLUpdateUserTyping((TLUpdateUserTyping) obj2, updateWrapper.isGettingDifferences());
                }
                else if (obj2 is TLUpdateWebPage)
                {
                    this.onTLUpdateWebPage((TLUpdateWebPage) obj2);
                }
                else if (obj2 is TLFakeUpdate)
                {
                    this.onTLFakeUpdate((TLFakeUpdate) obj2);
                }
                else if (obj2 is TLUpdateBotCallbackQuery)
                {
                    this.onTLUpdateBotCallbackQuery((TLUpdateBotCallbackQuery) obj2, updateWrapper.isGettingDifferences());
                }
                else if (obj2 is TLUpdateEditMessage)
                {
                    this.onTLUpdateEditMessage((TLUpdateEditMessage) obj2, updateWrapper.isGettingDifferences());
                }
                else if (obj2 is TLUpdateInlineBotCallbackQuery)
                {
                    this.onTLUpdateInlineBotCallbackQuery((TLUpdateInlineBotCallbackQuery) obj2, updateWrapper.isGettingDifferences());
                }
                else if (obj2 is TLUpdateEncryption)
                {
                    this.onTLUpdateEncryption((TLUpdateEncryption) obj2);
                }
                else if (obj2 is TLUpdateEncryptedChatTyping)
                {
                    this.onTLUpdateEncryptedChatTyping((TLUpdateEncryptedChatTyping) obj2);
                }
                else if (obj2 is TLUpdateEncryptedMessagesRead)
                {
                    this.onTLUpdateEncryptedMessagesRead((TLUpdateEncryptedMessagesRead) obj2);
                }
                else if (obj2 is TLUpdateNewEncryptedMessage)
                {
                    this.onTLUpdateNewEncryptedMessage((TLUpdateNewEncryptedMessage) obj2);
                }
                else if (obj2 is TLUpdateConfig)
                {
                    this.onTLUpdateConfig((TLUpdateConfig) obj2);
                }
                else if (obj2 is TLUpdateDraftMessage)
                {
                    this.onTLUpdateDraftMessage((TLUpdateDraftMessage) obj2, updateWrapper.isGettingDifferences());
                }
                else if (obj2 is TLUpdatePtsChanged)
                {
                    this.onTLUpdatePtsChanged((TLUpdatePtsChanged) obj2);
                }
                else if (obj2 is TLUpdateReadChannelOutbox)
                {
                    this.onTLUpdateReadChannelOutbox((TLUpdateReadChannelOutbox) obj2, updateWrapper.isGettingDifferences());
                }
                else if (obj2 is TLUpdateReadFeaturedStickers)
                {
                    this.onTLUpdateReadFeaturedStickers((TLUpdateReadFeaturedStickers) obj2);
                }
                else if (obj2 is TLUpdateRecentStickers)
                {
                    this.onTLUpdateRecentStickers((TLUpdateRecentStickers) obj2);
                }
                else if (obj2 is TLUpdateChannelWebPage)
                {
                    this.onTLUpdateChannelWebPage((TLUpdateChannelWebPage) obj2, updateWrapper.isGettingDifferences());
                }
                else if (obj2 is TLUpdatePhoneCall)
                {
                    this.onTLUpdatePhoneCall((TLUpdatePhoneCall) obj2);
                }
                else if (obj2 is TLUpdateDialogPinned)
                {
                    this.onTLUpdateDialogPinned((TLUpdateDialogPinned) obj2);
                }
                else if (obj2 is TLUpdatePinnedDialogs)
                {
                    this.onTLUpdatePinnedDialogs((TLUpdatePinnedDialogs) obj2);
                }
                else if (obj2 is TLUpdateBotWebhookJSON)
                {
                    this.onTLUpdateBotWebhookJSON((TLUpdateBotWebhookJSON) obj2);
                }
                else if (obj2 is TLUpdateBotWebhookJSONQuery)
                {
                    this.onTLUpdateBotWebhookJSONQuery((TLUpdateBotWebhookJSONQuery) obj2);
                }
                else if (obj2 is TLUpdateBotShippingQuery)
                {
                    this.onTLUpdateBotShippingQuery((TLUpdateBotShippingQuery) obj2, updateWrapper.isGettingDifferences());
                }
                else if (obj2 is TLUpdateBotPrecheckoutQuery)
                {
                    this.onTLUpdateBotPrecheckoutQuery((TLUpdateBotPrecheckoutQuery) obj2, updateWrapper.isGettingDifferences());
                }
                if (updateWrapper.isUpdatePts())
                {
                    this.updatePts(updateWrapper);
                }
            }
        }

        private void updatePts(UpdateWrapper)
        {
        }

        public void updateStateModification(TLUpdatesState state)
        {
        }

        private sealed class __<>Anon0 : Consumer
        {
            private readonly UpdatesHandlerBase arg$1;

            internal __<>Anon0(UpdatesHandlerBase base1)
            {
                this.arg$1 = base1;
            }

            public void accept(object obj1)
            {
                this.arg$1.onTLAbsMessageCustom((TLAbsMessage) obj1);
            }

            public Consumer andThen(Consumer consumer1) => 
                Consumer.<default>andThen(this, consumer1);
        }

        private sealed class __<>Anon1 : Function
        {
            internal __<>Anon1()
            {
            }

            public Function andThen(Function function1) => 
                Function.<default>andThen(this, function1);

            public object apply(object obj1) => 
                UpdatesHandlerBase.lambda$onTLAbsDifference$0((TLAbsUpdate) obj1);

            public Function compose(Function function1) => 
                Function.<default>compose(this, function1);
        }

        private sealed class __<>Anon2 : Consumer
        {
            private readonly UpdatesHandlerBase arg$1;

            internal __<>Anon2(UpdatesHandlerBase base1)
            {
                this.arg$1 = base1;
            }

            public void accept(object obj1)
            {
                this.arg$1.processUpdate((UpdateWrapper) obj1);
            }

            public Consumer andThen(Consumer consumer1) => 
                Consumer.<default>andThen(this, consumer1);
        }

        private sealed class __<>Anon3 : Function
        {
            internal __<>Anon3()
            {
            }

            public Function andThen(Function function1) => 
                Function.<default>andThen(this, function1);

            public object apply(object obj1) => 
                UpdatesHandlerBase.lambda$onTLChannelDifferences$1((TLAbsUpdate) obj1);

            public Function compose(Function function1) => 
                Function.<default>compose(this, function1);
        }
    }
}

