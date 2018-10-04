namespace org.telegram.api.chat.channel
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.api.chat;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLChannelFull : TLAbsChatFull
    {
        private string about;
        private int adminCount;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/bot/TLBotInfo;>;")]
        private TLVector botInfo;
        public const int CLASS_ID = -1009430225;
        private const int FLAG_ADMIN = 2;
        private const int FLAG_CAN_SET_USERNAME = 0x40;
        private const int FLAG_CAN_VIEW_PARTICIPANTS = 8;
        private const int FLAG_KICKED = 4;
        private const int FLAG_MIGRATED = 0x10;
        private const int FLAG_PARTICIPANTS = 1;
        private const int FLAG_PINNED_MESSAGE = 0x20;
        private int flags;
        private int kickedCount;
        private int migratedFromChatId;
        private int migratedFromMaxId;
        private int participantsCount;
        private int pinnedMessageId;
        private int readInboxMaxId;
        private int readOutboxMaxId;
        private int unreadCount;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xbd, 0x68 })]
        public TLChannelFull()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLChannelFull(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public virtual bool canSetUsername() => 
            ((this.flags & 0x40) != 0);

        public virtual bool canViewParticipants() => 
            ((this.flags & 8) != 0);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 
            0x59, 0x6c, 0x6c, 0x6c, 0x6a, 140, 0x6a, 140, 0x6a, 140, 0x6c, 0x6c, 0x6c, 0x72, 0x72, 0x72,
            0x6d, 0x6b, 0x6c, 140, 0x6b, 140
        })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            base.id = StreamingUtils.readInt(stream);
            this.about = StreamingUtils.readTLString(stream);
            if ((this.flags & 1) != 0)
            {
                this.participantsCount = StreamingUtils.readInt(stream);
            }
            if ((this.flags & 2) != 0)
            {
                this.adminCount = StreamingUtils.readInt(stream);
            }
            if ((this.flags & 4) != 0)
            {
                this.kickedCount = StreamingUtils.readInt(stream);
            }
            this.readInboxMaxId = StreamingUtils.readInt(stream);
            this.readOutboxMaxId = StreamingUtils.readInt(stream);
            this.unreadCount = StreamingUtils.readInt(stream);
            base.photo = StreamingUtils.readTLObject(stream, context);
            base.notifySettings = StreamingUtils.readTLObject(stream, context);
            base.exportedInvite = StreamingUtils.readTLObject(stream, context);
            this.botInfo = StreamingUtils.readTLVector(stream, context);
            if ((this.flags & 0x10) != 0)
            {
                this.migratedFromChatId = StreamingUtils.readInt(stream);
                this.migratedFromMaxId = StreamingUtils.readInt(stream);
            }
            if ((this.flags & 0x20) != 0)
            {
                this.pinnedMessageId = StreamingUtils.readInt(stream);
            }
        }

        public virtual string getAbout() => 
            this.about;

        public virtual int getAdminCount() => 
            this.adminCount;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/bot/TLBotInfo;>;")]
        public virtual TLVector getBotInfo() => 
            this.botInfo;

        public override int getClassId() => 
            -1009430225;

        public virtual int getKickedCount() => 
            this.kickedCount;

        public virtual int getMigratedFromChatId() => 
            this.migratedFromChatId;

        public virtual int getMigratedFromMaxId() => 
            this.migratedFromMaxId;

        public virtual int getParticipantsCount() => 
            this.participantsCount;

        public virtual int getPinnedMessageId() => 
            this.pinnedMessageId;

        public virtual int getReadInboxMaxId() => 
            this.readInboxMaxId;

        public virtual int getReadOutboxMaxId() => 
            this.readOutboxMaxId;

        public virtual int getUnreadCount() => 
            this.unreadCount;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 
            0x3b, 0x6c, 0x6c, 0x6c, 0x6a, 140, 0x6a, 140, 0x6a, 140, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c,
            0x6c, 0x6b, 0x6c, 140, 0x6b, 0x8e
        })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeInt(base.id, stream);
            StreamingUtils.writeTLString(this.about, stream);
            if ((this.flags & 1) != 0)
            {
                StreamingUtils.writeInt(this.participantsCount, stream);
            }
            if ((this.flags & 2) != 0)
            {
                StreamingUtils.writeInt(this.adminCount, stream);
            }
            if ((this.flags & 4) != 0)
            {
                StreamingUtils.writeInt(this.kickedCount, stream);
            }
            StreamingUtils.writeInt(this.readInboxMaxId, stream);
            StreamingUtils.writeInt(this.readOutboxMaxId, stream);
            StreamingUtils.writeInt(this.unreadCount, stream);
            StreamingUtils.writeTLObject(base.photo, stream);
            StreamingUtils.writeTLObject(base.notifySettings, stream);
            StreamingUtils.writeTLObject(base.exportedInvite, stream);
            StreamingUtils.writeTLVector(this.botInfo, stream);
            if ((this.flags & 0x10) != 0)
            {
                StreamingUtils.writeInt(this.migratedFromChatId, stream);
                StreamingUtils.writeInt(this.migratedFromMaxId, stream);
            }
            if ((this.flags & 0x20) != 0)
            {
                StreamingUtils.writeInt(this.pinnedMessageId, stream);
            }
        }

        public override string toString() => 
            "channelFull#c3d5512f";
    }
}

