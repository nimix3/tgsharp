namespace org.telegram.api.contacts
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLContactsFound : TLObject
    {
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/chat/TLAbsChat;>;")]
        private TLVector chats;
        public const int CLASS_ID = 0x1aa1f784;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/peer/TLAbsPeer;>;")]
        private TLVector results;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLAbsUser;>;")]
        private TLVector users;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb8, 0x68 })]
        public TLContactsFound()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLContactsFound(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x2a, 0x6d, 0x6d, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.results = StreamingUtils.readTLVector(stream, context);
            this.chats = StreamingUtils.readTLVector(stream, context);
            this.users = StreamingUtils.readTLVector(stream, context);
        }

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/chat/TLAbsChat;>;")]
        public virtual TLVector getChats() => 
            this.chats;

        public override int getClassId() => 
            0x1aa1f784;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/peer/TLAbsPeer;>;")]
        public virtual TLVector getResults() => 
            this.results;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLAbsUser;>;")]
        public virtual TLVector getUsers() => 
            this.users;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x23, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLVector(this.results, stream);
            StreamingUtils.writeTLVector(this.chats, stream);
            StreamingUtils.writeTLVector(this.users, stream);
        }

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/chat/TLAbsChat;>;)V")]
        public virtual void setChats(TLVector chats)
        {
            this.chats = chats;
        }

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/peer/TLAbsPeer;>;)V")]
        public virtual void setResults(TLVector results)
        {
            this.results = results;
        }

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLAbsUser;>;)V")]
        public virtual void setUsers(TLVector value)
        {
            this.users = value;
        }

        public override string toString() => 
            "contacts.found#1aa1f784";
    }
}

