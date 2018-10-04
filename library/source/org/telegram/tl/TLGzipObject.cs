namespace org.telegram.tl
{
    using IKVM.Attributes;
    using java.io;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLGzipObject : TLObject
    {
        public const int CLASS_ID = 0x3072cfa1;
        private byte[] packedData;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa5, 0x88 })]
        public TLGzipObject()
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa1, 0x68, 0x67 })]
        public TLGzipObject(byte[] packedData)
        {
            this.packedData = packedData;
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLGzipObject(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xbd, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.packedData = StreamingUtils.readTLBytes(stream);
        }

        public override int getClassId() => 
            0x3072cfa1;

        public virtual byte[] getPackedData() => 
            this.packedData;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb8, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLBytes(this.packedData, stream);
        }

        public virtual void setPackedData(byte[] packedData)
        {
            this.packedData = packedData;
        }

        public override string toString() => 
            "gzip_packed#3072cfa1";
    }
}

