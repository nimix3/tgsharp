namespace org.telegram.api.updates.difference
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLDifferenceTooLong : TLAbsDifference
    {
        public const int CLASS_ID = 0x4afe8f6d;
        private int pts;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa4, 0x68 })]
        public TLDifferenceTooLong()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLDifferenceTooLong(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb9, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.pts = StreamingUtils.readInt(stream);
        }

        public override int getClassId() => 
            0x4afe8f6d;

        public virtual int getPts() => 
            this.pts;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb3, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.pts, stream);
        }

        public override string toString() => 
            "updates.differenceTooLong#4afe8f6d";
    }
}

