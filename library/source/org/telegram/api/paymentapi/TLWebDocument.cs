namespace org.telegram.api.paymentapi
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
    public class TLWebDocument : TLObject
    {
        private long accessHash;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/document/attribute/TLAbsDocumentAttribute;>;")]
        private TLVector attributes;
        public const int CLASS_ID = -971322408;
        private int dcId;
        private string mimeType;
        private int size;
        private string url;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 170, 0x68 })]
        public TLWebDocument()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLWebDocument(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x16, 0x6c, 0x6c, 0x6c, 0x6c, 0x72, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.url = StreamingUtils.readTLString(stream);
            this.accessHash = StreamingUtils.readLong(stream);
            this.size = StreamingUtils.readInt(stream);
            this.mimeType = StreamingUtils.readTLString(stream);
            this.attributes = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLAbsDocumentAttribute>.Value);
            this.dcId = StreamingUtils.readInt(stream);
        }

        public virtual long getAccessHash() => 
            this.accessHash;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/document/attribute/TLAbsDocumentAttribute;>;")]
        public virtual TLVector getAttributes() => 
            this.attributes;

        public override int getClassId() => 
            -971322408;

        public virtual int getDcId() => 
            this.dcId;

        public virtual string getMimeType() => 
            this.mimeType;

        public virtual int getSize() => 
            this.size;

        public virtual string getUrl() => 
            this.url;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 12, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLString(this.url, stream);
            StreamingUtils.writeLong(this.accessHash, stream);
            StreamingUtils.writeInt(this.size, stream);
            StreamingUtils.writeTLString(this.mimeType, stream);
            StreamingUtils.writeTLVector(this.attributes, stream);
            StreamingUtils.writeInt(this.dcId, stream);
        }

        public override string toString() => 
            "webDocument#c61acbd8";
    }
}

