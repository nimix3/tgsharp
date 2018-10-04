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
    public class TLSentCodeTypeFlashCall : TLAbsSentCodeType
    {
        public const int CLASS_ID = -1425815847;
        protected internal int pattern;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa4, 0x68 })]
        public TLSentCodeTypeFlashCall()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLSentCodeTypeFlashCall(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xbb, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.pattern = StreamingUtils.readInt(stream);
        }

        public override int getClassId() => 
            -1425815847;

        public virtual int getPattern() => 
            this.pattern;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb6, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.pattern, stream);
        }

        public virtual void setPattern(int pattern)
        {
            this.pattern = pattern;
        }

        public override string toString() => 
            "auth.sentCodeTypeFlashCall#ab03c6d9";
    }
}

