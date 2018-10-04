namespace org.telegram.mtproto.tl
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class MTPing : TLObject
    {
        public const int CLASS_ID = 0x7abe77ec;
        private long pingId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 170, 0x88 })]
        public MTPing()
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa6, 0x68, 0x67 })]
        public MTPing(long pingId)
        {
            this.pingId = pingId;
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected MTPing(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xba, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.pingId = StreamingUtils.readLong(stream);
        }

        public override int getClassId() => 
            0x7abe77ec;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb5, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeLong(this.pingId, stream);
        }

        public override string toString() => 
            "ping#7abe77ec";
    }
}

