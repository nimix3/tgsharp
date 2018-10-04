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
    public class MTMessageDetailedInfo : TLObject
    {
        private long answerMsgId;
        private int bytes;
        public const int CLASS_ID = 0x276d3ec6;
        private long msgId;
        private int state;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb2, 0x88 })]
        public MTMessageDetailedInfo()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected MTMessageDetailedInfo(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xab, 0x68, 0x67, 0x67, 0x67, 0x68 })]
        public MTMessageDetailedInfo(long msgId, long answerMsgId, int bytes, int state)
        {
            this.msgId = msgId;
            this.answerMsgId = answerMsgId;
            this.bytes = bytes;
            this.state = state;
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x15, 0x6c, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.msgId = StreamingUtils.readLong(stream);
            this.answerMsgId = StreamingUtils.readLong(stream);
            this.bytes = StreamingUtils.readInt(stream);
            this.state = StreamingUtils.readInt(stream);
        }

        public virtual long getAnswerMsgId() => 
            this.answerMsgId;

        public virtual int getBytes() => 
            this.bytes;

        public override int getClassId() => 
            0x276d3ec6;

        public virtual long getMsgId() => 
            this.msgId;

        public virtual int getState() => 
            this.state;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 13, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeLong(this.msgId, stream);
            StreamingUtils.writeLong(this.answerMsgId, stream);
            StreamingUtils.writeInt(this.bytes, stream);
            StreamingUtils.writeInt(this.state, stream);
        }

        public override string toString() => 
            "msg_detailed_info#276d3ec6";
    }
}

