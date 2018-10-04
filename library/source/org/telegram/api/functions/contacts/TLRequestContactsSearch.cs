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

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/api/contacts/TLContactsFound;>;")]
    public class TLRequestContactsSearch : TLMethod
    {
        public const int CLASS_ID = 0x11f812d8;
        private int limit;
        private string q;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xab, 0x68 })]
        public TLRequestContactsSearch()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestContactsSearch(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(0x10)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 40, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.q = StreamingUtils.readTLString(stream);
            this.limit = StreamingUtils.readInt(stream);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 180, 0x68, 0x63, 0x70, 0x68, 0x67 })]
        public virtual TLContactsFound deserializeResponse(InputStream stream, TLContext context)
        {
            TLObject obj2 = StreamingUtils.readTLObject(stream, context);
            if (obj2 == null)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IOException("Unable to parse response");
            }
            if (obj2 is TLContactsFound)
            {
                return (TLContactsFound) obj2;
            }
            Throwable.__<suppressFillInStackTrace>();
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected org.telegram.api.contacts.TLFound, got: ").append(Object.instancehelper_getClass(obj2).getCanonicalName()).toString());
        }

        public override int getClassId() => 
            0x11f812d8;

        public virtual int getLimit() => 
            this.limit;

        public virtual string getQ() => 
            this.q;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x22, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLString(this.q, stream);
            StreamingUtils.writeInt(this.limit, stream);
        }

        public virtual void setLimit(int value)
        {
            this.limit = value;
        }

        public virtual void setQ(string value)
        {
            this.q = value;
        }

        public override string toString() => 
            "contacts.search#11f812d8";
    }
}

