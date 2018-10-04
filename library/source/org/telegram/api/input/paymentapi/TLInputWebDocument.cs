namespace org.telegram.api.input.paymentapi
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
    public class TLInputWebDocument : TLObject
    {
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/document/attribute/TLAbsDocumentAttribute;>;")]
        private TLVector attributes;
        public const int CLASS_ID = -1678949555;
        private string mimeType;
        private int size;
        private string url;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa9, 0x68 })]
        public TLInputWebDocument()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLInputWebDocument(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x1b, 0x6c, 0x6c, 0x6c, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.url = StreamingUtils.readTLString(stream);
            this.size = StreamingUtils.readInt(stream);
            this.mimeType = StreamingUtils.readTLString(stream);
            this.attributes = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLAbsDocumentAttribute>.Value);
        }

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/document/attribute/TLAbsDocumentAttribute;>;")]
        public virtual TLVector getAttributes() => 
            this.attributes;

        public override int getClassId() => 
            -1678949555;

        public virtual string getMimeType() => 
            this.mimeType;

        public virtual int getSize() => 
            this.size;

        public virtual string getUrl() => 
            this.url;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x13, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLString(this.url, stream);
            StreamingUtils.writeInt(this.size, stream);
            StreamingUtils.writeTLString(this.mimeType, stream);
            StreamingUtils.writeTLVector(this.attributes, stream);
        }

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/document/attribute/TLAbsDocumentAttribute;>;)V")]
        public virtual void setAttributes(TLVector attributes)
        {
            this.attributes = attributes;
        }

        public virtual void setMimeType(string mimeType)
        {
            this.mimeType = mimeType;
        }

        public virtual void setSize(int size)
        {
            this.size = size;
        }

        public virtual void setUrl(string url)
        {
            this.url = url;
        }

        public override string toString() => 
            "inputWebDocument#9bed434d";
    }
}

