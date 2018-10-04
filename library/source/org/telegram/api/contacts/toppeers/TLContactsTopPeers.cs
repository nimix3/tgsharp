namespace org.telegram.api.contacts.toppeers
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
    public class TLContactsTopPeers : TLAbsContactsTopPeers
    {
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/toppeer/TLTopPeerCategoryPeers;>;")]
        private TLVector categories;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/chat/TLAbsChat;>;")]
        private TLVector chats;
        public const int CLASS_ID = 0x70b772a8;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLAbsUser;>;")]
        private TLVector users;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 170, 0x68 })]
        public TLContactsTopPeers()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLContactsTopPeers(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 7, 0x72, 0x72, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.categories = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLTopPeerCategoryPeers>.Value);
            this.chats = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLAbsChat>.Value);
            this.users = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLAbsUser>.Value);
        }

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/toppeer/TLTopPeerCategoryPeers;>;")]
        public virtual TLVector getCategories() => 
            this.categories;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/chat/TLAbsChat;>;")]
        public virtual TLVector getChats() => 
            this.chats;

        public override int getClassId() => 
            0x70b772a8;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLAbsUser;>;")]
        public virtual TLVector getUsers() => 
            this.users;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLVector(this.categories, stream);
            StreamingUtils.writeTLVector(this.chats, stream);
            StreamingUtils.writeTLVector(this.users, stream);
        }

        public override string toString() => 
            "contacts.topPeers#70b772a8";
    }
}

