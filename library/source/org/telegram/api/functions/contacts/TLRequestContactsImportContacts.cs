namespace org.telegram.api.functions.contacts
{
    using IKVM.Attributes;
    using java.io;
    using java.lang;
    using org.telegram.api.contacts;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/api/contacts/TLImportedContacts;>;")]
    public class TLRequestContactsImportContacts : TLMethod
    {
        public const int CLASS_ID = -634342611;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/input/TLInputPhoneContact;>;")]
        private TLVector contacts;
        private bool replace;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xad, 0x68 })]
        public TLRequestContactsImportContacts()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestContactsImportContacts(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(0x12)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x2a, 0x6d, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.contacts = StreamingUtils.readTLVector(stream, context);
            this.replace = StreamingUtils.readTLBool(stream);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb6, 0x68, 0x63, 0x70, 0x68, 0x67 })]
        public virtual TLImportedContacts deserializeResponse(InputStream stream, TLContext context)
        {
            TLObject obj2 = StreamingUtils.readTLObject(stream, context);
            if (obj2 == null)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IOException("Unable to parse response");
            }
            if (obj2 is TLImportedContacts)
            {
                return (TLImportedContacts) obj2;
            }
            Throwable.__<suppressFillInStackTrace>();
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected org.telegram.api.contacts.TLImportedContacts, got: ").append(Object.instancehelper_getClass(obj2).getCanonicalName()).toString());
        }

        public override int getClassId() => 
            -634342611;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/input/TLInputPhoneContact;>;")]
        public virtual TLVector getContacts() => 
            this.contacts;

        public virtual bool getReplace() => 
            this.replace;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x24, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLVector(this.contacts, stream);
            StreamingUtils.writeTLBool(this.replace, stream);
        }

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/input/TLInputPhoneContact;>;)V")]
        public virtual void setContacts(TLVector value)
        {
            this.contacts = value;
        }

        public virtual void setReplace(bool value)
        {
            int num = (int) value;
            this.replace = (bool) num;
        }

        public override string toString() => 
            "contacts.importContacts#da30b32d";
    }
}

