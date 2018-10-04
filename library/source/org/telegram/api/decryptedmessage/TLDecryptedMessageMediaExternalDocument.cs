namespace org.telegram.api.decryptedmessage
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
    public class TLDecryptedMessageMediaExternalDocument : TLAbsDecryptedMessageMedia
    {
        private long accessHash;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/document/attribute/TLAbsDocumentAttribute;>;")]
        private TLVector attributes;
        public const int CLASS_ID = -90853155;
        private int date;
        private int dcId;
        private long id;
        private string mimetype;
        private int size;
        private TLAbsPhotoSize thumb;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xbc, 0xe8, 0x39, 0xeb, 0x48 })]
        public TLDecryptedMessageMediaExternalDocument()
        {
            this.attributes = new TLVector();
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLDecryptedMessageMediaExternalDocument(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 160, 100, 0x6d, 0x6c, 0x6c, 0x6c, 0x6c, 0x72, 0x6c, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.id = StreamingUtils.readInt(stream);
            this.accessHash = StreamingUtils.readLong(stream);
            this.date = StreamingUtils.readInt(stream);
            this.mimetype = StreamingUtils.readTLString(stream);
            this.size = StreamingUtils.readInt(stream);
            this.thumb = StreamingUtils.readTLObject(stream, context);
            this.dcId = StreamingUtils.readInt(stream);
            this.attributes = StreamingUtils.readTLVector(stream, context);
        }

        public virtual long getAccessHash() => 
            this.accessHash;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/document/attribute/TLAbsDocumentAttribute;>;")]
        public virtual TLVector getAttributes() => 
            this.attributes;

        public override int getClassId() => 
            -90853155;

        public virtual int getDate() => 
            this.date;

        public virtual int getDcId() => 
            this.dcId;

        public virtual long getId() => 
            this.id;

        public virtual string getMimetype() => 
            this.mimetype;

        public virtual int getSize() => 
            this.size;

        public virtual TLAbsPhotoSize getThumb() => 
            this.thumb;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 160, 0x57, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeLong(this.id, stream);
            StreamingUtils.writeLong(this.accessHash, stream);
            StreamingUtils.writeInt(this.date, stream);
            StreamingUtils.writeTLString(this.mimetype, stream);
            StreamingUtils.writeInt(this.size, stream);
            StreamingUtils.writeTLObject(this.thumb, stream);
            StreamingUtils.writeInt(this.dcId, stream);
            StreamingUtils.writeTLVector(this.attributes, stream);
        }

        public virtual void setAccessHash(long accessHash)
        {
            this.accessHash = accessHash;
        }

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/document/attribute/TLAbsDocumentAttribute;>;)V")]
        public virtual void setAttributes(TLVector attributes)
        {
            this.attributes = attributes;
        }

        public virtual void setDate(int date)
        {
            this.date = date;
        }

        public virtual void setDcId(int dcId)
        {
            this.dcId = dcId;
        }

        public virtual void setId(long id)
        {
            this.id = id;
        }

        public virtual void setMimetype(string mimetype)
        {
            this.mimetype = mimetype;
        }

        public virtual void setSize(int size)
        {
            this.size = size;
        }

        public virtual void setThumb(TLAbsPhotoSize thumb)
        {
            this.thumb = thumb;
        }

        public override string toString() => 
            "decryptedMessageMediaExternalDocument#fa95b0dd";
    }
}

