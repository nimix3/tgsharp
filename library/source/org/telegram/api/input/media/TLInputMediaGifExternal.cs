namespace org.telegram.api.input.media
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLInputMediaGifExternal : TLAbsInputMedia
    {
        public const int CLASS_ID = 0x4843b0fd;
        private string q;
        protected internal string url;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xbc, 0x68 })]
        public TLInputMediaGifExternal()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLInputMediaGifExternal(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x1b, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.url = StreamingUtils.readTLString(stream);
            this.q = StreamingUtils.readTLString(stream);
        }

        public override int getClassId() => 
            0x4843b0fd;

        public virtual string getQ() => 
            this.q;

        public virtual string getUrl() => 
            this.url;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x15, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLString(this.url, stream);
            StreamingUtils.writeTLString(this.q, stream);
        }

        public virtual void setQ(string q)
        {
            this.q = q;
        }

        public virtual void setUrl(string url)
        {
            this.url = url;
        }

        public override string toString() => 
            "inputMediaGifExternal#4843b0fd";
    }
}

