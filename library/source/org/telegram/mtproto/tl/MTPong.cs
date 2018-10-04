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
    public class MTPong : TLObject
    {
        public const int CLASS_ID = 0x347773c5;
        private long messageId;
        private long pingId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xad, 0x68 })]
        public MTPong()
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa8, 0x68, 0x67, 0x67 })]
        public MTPong(long messageId, long pingId)
        {
            this.messageId = messageId;
            this.pingId = pingId;
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected MTPong(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 5, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.messageId = StreamingUtils.readLong(stream);
            this.pingId = StreamingUtils.readLong(stream);
        }

        public override int getClassId() => 
            0x347773c5;

        public virtual long getMessageId() => 
            this.messageId;

        public virtual long getPingId() => 
            this.pingId;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xbf, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeLong(this.messageId, stream);
            StreamingUtils.writeLong(this.pingId, stream);
        }

        public override string toString() => 
            "pong#347773c5";
    }
}

