namespace org.telegram.api.message.media
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.api.webpage;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLMessageMediaWebPage : TLAbsMessageMedia
    {
        public const int CLASS_ID = -1557277184;
        private TLAbsWebPage webPage;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa8, 0x68 })]
        public TLMessageMediaWebPage()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLMessageMediaWebPage(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 11, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.webPage = StreamingUtils.readTLObject(stream, context);
        }

        public override int getClassId() => 
            -1557277184;

        public virtual TLAbsWebPage getWebPage() => 
            this.webPage;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 5, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.webPage, stream);
        }

        public virtual void setWebPage(TLAbsWebPage webPage)
        {
            this.webPage = webPage;
        }

        public override string toString() => 
            "messageMediaDocument#a32dd600";
    }
}

