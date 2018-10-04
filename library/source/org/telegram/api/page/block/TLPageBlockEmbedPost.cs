namespace org.telegram.api.page.block
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using org.telegram.api.richtext;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLPageBlockEmbedPost : TLAbsPageBlock
    {
        private string author;
        private long authorPhotoId;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/page/block/TLAbsPageBlock;>;")]
        private TLVector blocks;
        private TLAbsRichText caption;
        public const int CLASS_ID = 0x292c7be9;
        private int date;
        private string url;
        private long webpageId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 170, 0x68 })]
        public TLPageBlockEmbedPost()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLPageBlockEmbedPost(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x1b, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x72, 0x77 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.url = StreamingUtils.readTLString(stream);
            this.webpageId = StreamingUtils.readLong(stream);
            this.authorPhotoId = StreamingUtils.readLong(stream);
            this.author = StreamingUtils.readTLString(stream);
            this.date = StreamingUtils.readInt(stream);
            this.blocks = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLAbsPageBlock>.Value);
            this.caption = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLAbsRichText>.Value);
        }

        public virtual string getAuthor() => 
            this.author;

        public virtual long getAuthorPhotoId() => 
            this.authorPhotoId;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/page/block/TLAbsPageBlock;>;")]
        public virtual TLVector getBlocks() => 
            this.blocks;

        public virtual TLAbsRichText getCaption() => 
            this.caption;

        public override int getClassId() => 
            0x292c7be9;

        public virtual int getDate() => 
            this.date;

        public virtual string getUrl() => 
            this.url;

        public virtual long getWebpageId() => 
            this.webpageId;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x10, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLString(this.url, stream);
            StreamingUtils.writeLong(this.webpageId, stream);
            StreamingUtils.writeLong(this.authorPhotoId, stream);
            StreamingUtils.writeTLString(this.author, stream);
            StreamingUtils.writeInt(this.date, stream);
            StreamingUtils.writeTLVector(this.blocks, stream);
            StreamingUtils.writeTLObject(this.caption, stream);
        }

        public override string toString() => 
            "pageBlockEmbedPost#292c7be9";
    }
}

