namespace org.telegram.api.updates.channel.differences
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLUpdatesChannelDifferencesTooLong : TLAbsUpdatesChannelDifferences
    {
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/chat/TLAbsChat;>;")]
        private TLVector chats;
        public const int CLASS_ID = 0x410dee07;
        private const int FLAG_FINAL = 1;
        private const int FLAG_TIMEOUT = 2;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/message/TLAbsMessage;>;")]
        private TLVector messages;
        private int readInboxMaxId;
        private int readOutboxMaxId;
        private int topMessage;
        private int unreadCount;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLAbsUser;>;")]
        private TLVector users;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb5, 0x68 })]
        public TLUpdatesChannelDifferencesTooLong()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLUpdatesChannelDifferencesTooLong(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x2a, 0x6c, 0x6c, 0x6a, 140, 0x6c, 0x6c, 0x6c, 0x6c, 0x72, 0x72, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            base.flags = StreamingUtils.readInt(stream);
            base.pts = StreamingUtils.readInt(stream);
            if ((base.flags & 2) != 0)
            {
                base.timeout = StreamingUtils.readInt(stream);
            }
            this.topMessage = StreamingUtils.readInt(stream);
            this.readInboxMaxId = StreamingUtils.readInt(stream);
            this.readOutboxMaxId = StreamingUtils.readInt(stream);
            this.unreadCount = StreamingUtils.readInt(stream);
            this.messages = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLAbsMessage>.Value);
            this.chats = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLAbsChat>.Value);
            this.users = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLAbsUser>.Value);
        }

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/chat/TLAbsChat;>;")]
        public virtual TLVector getChats() => 
            this.chats;

        public override int getClassId() => 
            0x410dee07;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/message/TLAbsMessage;>;")]
        public virtual TLVector getMessages() => 
            this.messages;

        public virtual int getReadInboxMaxId() => 
            this.readInboxMaxId;

        public virtual int getReadOutboxMaxId() => 
            this.readOutboxMaxId;

        public virtual int getTopMessage() => 
            this.topMessage;

        public virtual int getUnreadCount() => 
            this.unreadCount;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLAbsUser;>;")]
        public virtual TLVector getUsers() => 
            this.users;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x1a, 0x6c, 0x6c, 0x6a, 140, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(base.flags, stream);
            StreamingUtils.writeInt(base.pts, stream);
            if ((base.flags & 2) != 0)
            {
                StreamingUtils.writeInt(base.timeout, stream);
            }
            StreamingUtils.writeInt(this.topMessage, stream);
            StreamingUtils.writeInt(this.readInboxMaxId, stream);
            StreamingUtils.writeInt(this.readOutboxMaxId, stream);
            StreamingUtils.writeInt(this.unreadCount, stream);
            StreamingUtils.writeTLVector(this.messages, stream);
            StreamingUtils.writeTLVector(this.chats, stream);
            StreamingUtils.writeTLVector(this.users, stream);
        }

        public override string toString() => 
            "updates.channelDifferenceTooLong#410dee07";
    }
}

