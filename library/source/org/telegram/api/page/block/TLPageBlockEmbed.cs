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
    public class TLPageBlockEmbed : TLAbsPageBlock
    {
        private TLAbsRichText caption;
        public const int CLASS_ID = -840826671;
        private const int FLAG_ALLOW_SCROLLING = 8;
        private const int FLAG_FULL_WIDTH = 1;
        private const int FLAG_HTML = 4;
        private const int FLAG_POSTER_PHOTO_ID = 0x10;
        private const int FLAG_URL = 2;
        private int flags;
        private int h;
        private string html;
        private long posterPhotoId;
        private string url;
        private int w;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xaf, 0x68 })]
        public TLPageBlockEmbed()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLPageBlockEmbed(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public virtual bool allowScrolling() => 
            ((this.flags & 8) != 0);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x2e, 0x6c, 0x6a, 140, 0x6a, 140, 0x6b, 140, 0x6c, 0x6c, 0x77 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            if ((this.flags & 2) != 0)
            {
                this.url = StreamingUtils.readTLString(stream);
            }
            if ((this.flags & 4) != 0)
            {
                this.html = StreamingUtils.readTLString(stream);
            }
            if ((this.flags & 0x10) != 0)
            {
                this.posterPhotoId = StreamingUtils.readLong(stream);
            }
            this.w = StreamingUtils.readInt(stream);
            this.h = StreamingUtils.readInt(stream);
            this.caption = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLAbsRichText>.Value);
        }

        public virtual TLAbsRichText getCaption() => 
            this.caption;

        public override int getClassId() => 
            -840826671;

        public virtual int getFlags() => 
            this.flags;

        public virtual int getH() => 
            this.h;

        public virtual string getHtml() => 
            this.html;

        public virtual long getPosterPhotoId() => 
            this.posterPhotoId;

        public virtual string getUrl() => 
            this.url;

        public virtual int getW() => 
            this.w;

        public virtual bool isFullWidth() => 
            ((this.flags & 1) != 0);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x1d, 0x6c, 0x6a, 140, 0x6a, 140, 0x6b, 140, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            if ((this.flags & 2) != 0)
            {
                StreamingUtils.writeTLString(this.url, stream);
            }
            if ((this.flags & 4) != 0)
            {
                StreamingUtils.writeTLString(this.html, stream);
            }
            if ((this.flags & 0x10) != 0)
            {
                StreamingUtils.writeLong(this.posterPhotoId, stream);
            }
            StreamingUtils.writeInt(this.w, stream);
            StreamingUtils.writeInt(this.h, stream);
            StreamingUtils.writeTLObject(this.caption, stream);
        }

        public override string toString() => 
            "pageBlockEmbed#cde200d1";
    }
}

