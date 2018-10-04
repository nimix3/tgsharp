namespace org.telegram.api.richtext
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
    public class TLTextUrl : TLAbsRichText
    {
        public const int CLASS_ID = 0x3c2884c1;
        private TLAbsRichText text;
        private string url;
        private long webpageId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa5, 0x68 })]
        public TLTextUrl()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLTextUrl(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 2, 0x77, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.text = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLAbsRichText>.Value);
            this.url = StreamingUtils.readTLString(stream);
            this.webpageId = StreamingUtils.readLong(stream);
        }

        public override int getClassId() => 
            0x3c2884c1;

        public virtual TLAbsRichText getText() => 
            this.text;

        public virtual string getUrl() => 
            this.url;

        public virtual long getWebpageId() => 
            this.webpageId;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xbb, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.text, stream);
            StreamingUtils.writeTLString(this.url, stream);
            StreamingUtils.writeLong(this.webpageId, stream);
        }

        public override string toString() => 
            "textUrl#3c2884c1";
    }
}

