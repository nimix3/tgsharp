namespace org.telegram.api.upload.cdn
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLCdnFileReuploadNeeded : TLAbsCdnFile
    {
        public const int CLASS_ID = -290921362;
        private TLBytes requestToken;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa3, 0x68 })]
        public TLCdnFileReuploadNeeded()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLCdnFileReuploadNeeded(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb6, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.requestToken = StreamingUtils.readTLBytes(stream, context);
        }

        public override int getClassId() => 
            -290921362;

        public virtual TLBytes getRequestToken() => 
            this.requestToken;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb1, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLBytes(this.requestToken, stream);
        }

        public override string toString() => 
            "upload.cdnFileReuploadNeeded#eea8e46e";
    }
}

