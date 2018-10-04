namespace org.telegram.api.document
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.api.photo.size;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLDocument : TLAbsDocument
    {
        private long accessHash;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/document/attribute/TLAbsDocumentAttribute;>;")]
        private TLVector attributes;
        public const int CLASS_ID = -2027738169;
        private int date;
        private int dcId;
        private string mimeType;
        private int size;
        private TLAbsPhotoSize thumb;
        private int version;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xbb, 0xe8, 0x3a, 0xeb, 0x47 })]
        public TLDocument()
        {
            this.attributes = new TLVector();
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLDocument(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x31, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x72, 0x6c, 0x6c, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            base.id = StreamingUtils.readLong(stream);
            this.accessHash = StreamingUtils.readLong(stream);
            this.date = StreamingUtils.readInt(stream);
            this.mimeType = StreamingUtils.readTLString(stream);
            this.size = StreamingUtils.readInt(stream);
            this.thumb = StreamingUtils.readTLObject(stream, context);
            this.dcId = StreamingUtils.readInt(stream);
            this.version = StreamingUtils.readInt(stream);
            this.attributes = StreamingUtils.readTLVector(stream, context);
        }

        public virtual long getAccessHash() => 
            this.accessHash;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/document/attribute/TLAbsDocumentAttribute;>;")]
        public virtual TLVector getAttributes() => 
            this.attributes;

        public override int getClassId() => 
            -2027738169;

        public virtual int getDate() => 
            this.date;

        public virtual int getDcId() => 
            this.dcId;

        public virtual string getMimeType() => 
            this.mimeType;

        public virtual int getSize() => 
            this.size;

        public virtual TLAbsPhotoSize getThumb() => 
            this.thumb;

        public virtual int getVersion() => 
            this.version;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x24, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeLong(base.id, stream);
            StreamingUtils.writeLong(this.accessHash, stream);
            StreamingUtils.writeInt(this.date, stream);
            StreamingUtils.writeTLString(this.mimeType, stream);
            StreamingUtils.writeInt(this.size, stream);
            StreamingUtils.writeTLObject(this.thumb, stream);
            StreamingUtils.writeInt(this.dcId, stream);
            StreamingUtils.writeInt(this.version, stream);
            StreamingUtils.writeTLVector(this.attributes, stream);
        }

        public override string toString() => 
            "document#87232bc7";
    }
}

