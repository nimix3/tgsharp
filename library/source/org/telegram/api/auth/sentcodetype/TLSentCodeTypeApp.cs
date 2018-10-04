namespace org.telegram.api.auth.sentcodetype
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLSentCodeTypeApp : TLAbsSentCodeType
    {
        public const int CLASS_ID = 0x3dbb5986;
        private int length;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa4, 0x68 })]
        public TLSentCodeTypeApp()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLSentCodeTypeApp(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xbb, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.length = StreamingUtils.readInt(stream);
        }

        public override int getClassId() => 
            0x3dbb5986;

        public virtual int getLength() => 
            this.length;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb6, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.length, stream);
        }

        public virtual void setLength(int length)
        {
            this.length = length;
        }

        public override string toString() => 
            "auth.sentCodeTypeApp#3dbb5986";
    }
}

