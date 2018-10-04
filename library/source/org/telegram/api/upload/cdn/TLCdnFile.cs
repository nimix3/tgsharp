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
    public class TLCdnFile : TLAbsCdnFile
    {
        private TLBytes bytes;
        public const int CLASS_ID = -1449145777;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa3, 0x68 })]
        public TLCdnFile()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLCdnFile(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb6, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.bytes = StreamingUtils.readTLBytes(stream, context);
        }

        public virtual TLBytes getBytes() => 
            this.bytes;

        public override int getClassId() => 
            -1449145777;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb1, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLBytes(this.bytes, stream);
        }

        public override string toString() => 
            "upload.cdnFile#a99fca4f";
    }
}

