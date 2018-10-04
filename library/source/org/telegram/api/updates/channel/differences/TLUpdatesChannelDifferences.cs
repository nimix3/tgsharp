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
    public class TLUpdatesChannelDifferences : TLAbsUpdatesChannelDifferences
    {
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/chat/TLAbsChat;>;")]
        private TLVector chats;
        public const int CLASS_ID = 0x2064674e;
        private const int FLAG_FINAL = 1;
        private const int FLAG_TIMEOUT = 2;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/message/TLAbsMessage;>;")]
        private TLVector newMessages;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/update/TLAbsUpdate;>;")]
        private TLVector otherUpdates;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLAbsUser;>;")]
        private TLVector users;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb3, 0x68 })]
        public TLUpdatesChannelDifferences()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLUpdatesChannelDifferences(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x2d, 0x6c, 0x6c, 0x6a, 140, 0x72, 0x72, 0x72, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            base.flags = StreamingUtils.readInt(stream);
            base.pts = StreamingUtils.readInt(stream);
            if ((base.flags & 2) != 0)
            {
                base.timeout = StreamingUtils.readInt(stream);
            }
            this.newMessages = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLAbsMessage>.Value);
            this.otherUpdates = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLAbsUpdate>.Value);
            this.chats = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLAbsChat>.Value);
            this.users = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLAbsUser>.Value);
        }

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/chat/TLAbsChat;>;")]
        public virtual TLVector getChats() => 
            this.chats;

        public override int getClassId() => 
            0x2064674e;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/message/TLAbsMessage;>;")]
        public virtual TLVector getNewMessages() => 
            this.newMessages;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/update/TLAbsUpdate;>;")]
        public virtual TLVector getOtherUpdates() => 
            this.otherUpdates;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLAbsUser;>;")]
        public virtual TLVector getUsers() => 
            this.users;

        public virtual bool isFinal() => 
            ((base.flags & 1) != 0);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x20, 0x6c, 0x6c, 0x6a, 140, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(base.flags, stream);
            StreamingUtils.writeInt(base.pts, stream);
            if ((base.flags & 2) != 0)
            {
                StreamingUtils.writeInt(base.timeout, stream);
            }
            StreamingUtils.writeTLVector(this.newMessages, stream);
            StreamingUtils.writeTLVector(this.otherUpdates, stream);
            StreamingUtils.writeTLVector(this.chats, stream);
            StreamingUtils.writeTLVector(this.users, stream);
        }

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/chat/TLAbsChat;>;)V")]
        public virtual void setChats(TLVector chats)
        {
            this.chats = chats;
        }

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/message/TLAbsMessage;>;)V")]
        public virtual void setNewMessages(TLVector newMessages)
        {
            this.newMessages = newMessages;
        }

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/update/TLAbsUpdate;>;)V")]
        public virtual void setOtherUpdates(TLVector otherUpdates)
        {
            this.otherUpdates = otherUpdates;
        }

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLAbsUser;>;)V")]
        public virtual void setUsers(TLVector users)
        {
            this.users = users;
        }

        public override string toString() => 
            "updates.channelDifference#2064674e";
    }
}

