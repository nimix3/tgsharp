namespace org.telegram.api.photo
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
    public class TLPhoto : TLAbsPhoto
    {
        private long accessHash;
        public const int CLASS_ID = -1836524247;
        private int date;
        private const int FLAG_STICKERS = 1;
        private int flags;
        private long id;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/photo/size/TLAbsPhotoSize;>;")]
        private TLVector sizes;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xaf, 0x68 })]
        public TLPhoto()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLPhoto(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x4f, 0x6c, 0x6c, 0x6c, 0x6c, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.id = StreamingUtils.readLong(stream);
            this.accessHash = StreamingUtils.readLong(stream);
            this.date = StreamingUtils.readInt(stream);
            this.sizes = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLAbsPhotoSize>.Value);
        }

        public virtual long getAccessHash() => 
            this.accessHash;

        public override int getClassId() => 
            -1836524247;

        public virtual int getDate() => 
            this.date;

        public virtual long getId() => 
            this.id;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/photo/size/TLAbsPhotoSize;>;")]
        public virtual TLVector getSizes() => 
            this.sizes;

        public virtual bool hasStickers() => 
            ((this.flags & 1) != 0);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x45, 0x6c, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeLong(this.id, stream);
            StreamingUtils.writeLong(this.accessHash, stream);
            StreamingUtils.writeInt(this.date, stream);
            StreamingUtils.writeTLObject(this.sizes, stream);
        }

        public virtual void setAccessHash(long accessHash)
        {
            this.accessHash = accessHash;
        }

        public virtual void setDate(int date)
        {
            this.date = date;
        }

        public virtual void setId(long id)
        {
            this.id = id;
        }

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/photo/size/TLAbsPhotoSize;>;)V")]
        public virtual void setSizes(TLVector sizes)
        {
            this.sizes = sizes;
        }

        public override string toString() => 
            "photo#9288dd29";
    }
}

