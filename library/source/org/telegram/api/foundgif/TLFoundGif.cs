namespace org.telegram.api.foundgif
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLFoundGif : TLAbsFoundGif
    {
        public const int CLASS_ID = 0x162ecc1f;
        private string contentType;
        private string contentUrl;
        private int h;
        private string thumbUrl;
        private string url;
        private int w;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb9, 0x68 })]
        public TLFoundGif()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLFoundGif(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x3d, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.url = StreamingUtils.readTLString(stream);
            this.thumbUrl = StreamingUtils.readTLString(stream);
            this.contentUrl = StreamingUtils.readTLString(stream);
            this.contentType = StreamingUtils.readTLString(stream);
            this.w = StreamingUtils.readInt(stream);
            this.h = StreamingUtils.readInt(stream);
        }

        public override int getClassId() => 
            0x162ecc1f;

        public virtual string getContentType() => 
            this.contentType;

        public virtual string getContentUrl() => 
            this.contentUrl;

        public virtual int getH() => 
            this.h;

        public virtual string getThumbUrl() => 
            this.thumbUrl;

        public virtual string getUrl() => 
            this.url;

        public virtual int getW() => 
            this.w;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x33, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLString(this.url, stream);
            StreamingUtils.writeTLString(this.thumbUrl, stream);
            StreamingUtils.writeTLString(this.contentUrl, stream);
            StreamingUtils.writeTLString(this.contentType, stream);
            StreamingUtils.writeInt(this.w, stream);
            StreamingUtils.writeInt(this.h, stream);
        }

        public virtual void setContentType(string contentType)
        {
            this.contentType = contentType;
        }

        public virtual void setContentUrl(string contentUrl)
        {
            this.contentUrl = contentUrl;
        }

        public virtual void setH(int h)
        {
            this.h = h;
        }

        public virtual void setThumbUrl(string thumbUrl)
        {
            this.thumbUrl = thumbUrl;
        }

        public virtual void setUrl(string url)
        {
            this.url = url;
        }

        public virtual void setW(int w)
        {
            this.w = w;
        }

        public override string toString() => 
            "foundGif#162ecc1f";
    }
}

