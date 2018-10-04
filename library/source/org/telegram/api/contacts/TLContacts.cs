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
    public class TLContacts : TLAbsContacts
    {
        public const int CLASS_ID = 0x6f8b8cb2;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/contact/TLContact;>;")]
        private TLVector contacts;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLAbsUser;>;")]
        private TLVector users;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb5, 0x68 })]
        public TLContacts()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLContacts(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 40, 0x6d, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.contacts = StreamingUtils.readTLVector(stream, context);
            this.users = StreamingUtils.readTLVector(stream, context);
        }

        public override int getClassId() => 
            0x6f8b8cb2;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/contact/TLContact;>;")]
        public virtual TLVector getContacts() => 
            this.contacts;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLAbsUser;>;")]
        public virtual TLVector getUsers() => 
            this.users;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x22, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLVector(this.contacts, stream);
            StreamingUtils.writeTLVector(this.users, stream);
        }

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/contact/TLContact;>;)V")]
        public virtual void setContacts(TLVector contacts)
        {
            this.contacts = contacts;
        }

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLAbsUser;>;)V")]
        public virtual void setUsers(TLVector users)
        {
            this.users = users;
        }

        public override string toString() => 
            "contacts.contacts#6f8b8cb2";
    }
}

