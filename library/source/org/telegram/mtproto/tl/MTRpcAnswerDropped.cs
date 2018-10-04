namespace org.telegram.mtproto.tl
{
    using IKVM.Attributes;
    using java.io;
    using java.lang;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class MTRpcAnswerDropped : TLObject
    {
        private int bytes;
        public const int CLASS_ID = -1539647305;
        private Long msg_id;
        private int seq_no;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa6, 0x68 })]
        public MTRpcAnswerDropped()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected MTRpcAnswerDropped(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa9, 0x68, 0x67, 0x67, 0x67 })]
        public MTRpcAnswerDropped(Long msg_id, int seq_no, int bytes)
        {
            this.msg_id = msg_id;
            this.seq_no = seq_no;
            this.bytes = bytes;
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb6, 0x71, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.msg_id = Long.valueOf(StreamingUtils.readLong(stream));
            this.seq_no = StreamingUtils.readInt(stream);
            this.bytes = StreamingUtils.readInt(stream);
        }

        public virtual int getBytes() => 
            this.bytes;

        public override int getClassId() => 
            -1539647305;

        public virtual Long getMsg_id() => 
            this.msg_id;

        public virtual int getSeq_no() => 
            this.seq_no;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb0, 0x71, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeLong(this.msg_id.longValue(), stream);
            StreamingUtils.writeInt(this.seq_no, stream);
            StreamingUtils.writeInt(this.bytes, stream);
        }

        public virtual void setBytes(int bytes)
        {
            this.bytes = bytes;
        }

        public virtual void setMsg_id(Long msg_id)
        {
            this.msg_id = msg_id;
        }

        public virtual void setSeq_no(int seq_no)
        {
            this.seq_no = seq_no;
        }

        public override string toString() => 
            "MTPRpcAnswerDropper#a43ad8b7";
    }
}

