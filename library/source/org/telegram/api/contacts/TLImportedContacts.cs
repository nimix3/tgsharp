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
    public class TLImportedContacts : TLObject
    {
        public const int CLASS_ID = -1387117803;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/contact/TLImportedContact;>;")]
        private TLVector imported;
        private TLLongVector retryContacts;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLAbsUser;>;")]
        private TLVector users;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb8, 0xe8, 0x39, 0xeb, 0x48 })]
        public TLImportedContacts()
        {
            this.retryContacts = new TLLongVector();
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLImportedContacts(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x3e, 0x6d, 0x6d, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.imported = StreamingUtils.readTLVector(stream, context);
            this.retryContacts = StreamingUtils.readTLLongVector(stream, context);
            this.users = StreamingUtils.readTLVector(stream, context);
        }

        public override int getClassId() => 
            -1387117803;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/contact/TLImportedContact;>;")]
        public virtual TLVector getImported() => 
            this.imported;

        public virtual TLLongVector getRetryContacts() => 
            this.retryContacts;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLAbsUser;>;")]
        public virtual TLVector getUsers() => 
            this.users;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x37, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLVector(this.imported, stream);
            StreamingUtils.writeTLVector(this.retryContacts, stream);
            StreamingUtils.writeTLVector(this.users, stream);
        }

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/contact/TLImportedContact;>;)V")]
        public virtual void setImported(TLVector value)
        {
            this.imported = value;
        }

        public virtual void setRetryContacts(TLLongVector retryContacts)
        {
            this.retryContacts = retryContacts;
        }

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLAbsUser;>;)V")]
        public virtual void setUsers(TLVector value)
        {
            this.users = value;
        }

        public override string toString() => 
            "contacts.importedContacts#ad524315";
    }
}

