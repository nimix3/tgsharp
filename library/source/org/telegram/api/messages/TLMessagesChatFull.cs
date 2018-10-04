namespace org.telegram.api.messages
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
    public class TLMessagesChatFull : TLObject
    {
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/chat/TLAbsChat;>;")]
        private TLVector chats;
        public const int CLASS_ID = -438840932;
        private TLAbsChatFull fullChat;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLUser;>;")]
        private TLVector users;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xaf, 0xe8, 0x39, 0x6b, 0xeb, 0x47 })]
        public TLMessagesChatFull()
        {
            this.chats = new TLVector();
            this.users = new TLVector();
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLMessagesChatFull(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x38, 0x72, 0x6d, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.fullChat = StreamingUtils.readTLObject(stream, context);
            this.chats = StreamingUtils.readTLVector(stream, context);
            this.users = StreamingUtils.readTLVector(stream, context);
        }

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/chat/TLAbsChat;>;")]
        public virtual TLVector getChats() => 
            this.chats;

        public override int getClassId() => 
            -438840932;

        public virtual TLAbsChatFull getFullChat() => 
            this.fullChat;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLUser;>;")]
        public virtual TLVector getUsers() => 
            this.users;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x30, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.fullChat, stream);
            StreamingUtils.writeTLVector(this.chats, stream);
            StreamingUtils.writeTLVector(this.users, stream);
        }

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/chat/TLAbsChat;>;)V")]
        public virtual void setChats(TLVector value)
        {
            this.chats = value;
        }

        public virtual void setFullChat(TLAbsChatFull value)
        {
            this.fullChat = value;
        }

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLUser;>;)V")]
        public virtual void setUsers(TLVector value)
        {
            this.users = value;
        }

        public override string toString() => 
            "messages.chatFull#e5d7d19c";
    }
}

