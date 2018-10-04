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
    public class MTNewMessageDetailedInfo : TLObject
    {
        private long answerMsgId;
        private int bytes;
        public const int CLASS_ID = -2137147681;
        private int status;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb1, 0x88 })]
        public MTNewMessageDetailedInfo()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected MTNewMessageDetailedInfo(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xab, 0x68, 0x67, 0x67, 0x67 })]
        public MTNewMessageDetailedInfo(long answerMsgId, int bytes, int status)
        {
            this.answerMsgId = answerMsgId;
            this.bytes = bytes;
            this.status = status;
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 15, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.answerMsgId = StreamingUtils.readLong(stream);
            this.bytes = StreamingUtils.readInt(stream);
            this.status = StreamingUtils.readInt(stream);
        }

        public virtual long getAnswerMsgId() => 
            this.answerMsgId;

        public virtual int getBytes() => 
            this.bytes;

        public override int getClassId() => 
            -2137147681;

        public virtual int getStatus() => 
            this.status;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 8, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeLong(this.answerMsgId, stream);
            StreamingUtils.writeInt(this.bytes, stream);
            StreamingUtils.writeInt(this.status, stream);
        }

        public override string toString() => 
            "msg_new_detailed_info#809db6df";
    }
}

