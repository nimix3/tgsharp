namespace org.telegram.api.sticker.set
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLStickerSet : TLObject
    {
        private long accessHash;
        public const int CLASS_ID = -852477119;
        private int count;
        private const int FLAG_ARCHIVED = 2;
        private const int FLAG_INSTALLED = 1;
        private const int FLAG_MASK = 8;
        private const int FLAG_OFFICIAL = 4;
        private int flags;
        private int hash;
        private long id;
        private string shortName;
        private string title;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x11)]
        public TLStickerSet()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLStickerSet(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x29, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.id = StreamingUtils.readLong(stream);
            this.accessHash = StreamingUtils.readLong(stream);
            this.title = StreamingUtils.readTLString(stream);
            this.shortName = StreamingUtils.readTLString(stream);
            this.count = StreamingUtils.readInt(stream);
            this.hash = StreamingUtils.readInt(stream);
        }

        public virtual long getAccessHash() => 
            this.accessHash;

        public override int getClassId() => 
            -852477119;

        public virtual int getCount() => 
            this.count;

        public virtual int getHash() => 
            this.hash;

        public virtual long getId() => 
            this.id;

        public virtual string getShortName() => 
            this.shortName;

        public virtual string getTitle() => 
            this.title;

        public virtual bool isArchived() => 
            ((this.flags & 2) != 0);

        public virtual bool isInstalled() => 
            ((this.flags & 1) != 0);

        public virtual bool isMask() => 
            ((this.flags & 8) != 0);

        public virtual bool isOffcial() => 
            ((this.flags & 4) != 0);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 30, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeLong(this.id, stream);
            StreamingUtils.writeLong(this.accessHash, stream);
            StreamingUtils.writeTLString(this.title, stream);
            StreamingUtils.writeTLString(this.shortName, stream);
            StreamingUtils.writeInt(this.count, stream);
            StreamingUtils.writeInt(this.hash, stream);
        }

        public override string toString() => 
            "stickerSet#cd303b41";
    }
}

