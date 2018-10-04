namespace org.telegram.mtproto.tl
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.mtproto.util;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class MTMessage : TLObject
    {
        private byte[] content;
        private int contentLen;
        private long messageId;
        private int seqNo;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb7, 0x88 })]
        public MTMessage()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected MTMessage(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xad, 0x6d })]
        public MTMessage(long messageId, int seqNo, byte[] content) : this(messageId, seqNo, content, content.Length)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb0, 0x68, 0x67, 0x67, 0x67, 0x68 })]
        public MTMessage(long messageId, int seqNo, byte[] content, int contentLen)
        {
            this.messageId = messageId;
            this.seqNo = seqNo;
            this.content = content;
            this.contentLen = contentLen;
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x2a, 0x6c, 0x6c, 0x67, 0x71, 0x70 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.messageId = StreamingUtils.readLong(stream);
            this.seqNo = StreamingUtils.readInt(stream);
            int minSize = StreamingUtils.readInt(stream);
            this.content = BytesCache.getInstance().allocate(minSize);
            StreamingUtils.readBytes(this.content, 0, minSize, stream);
        }

        public override int getClassId() => 
            0;

        public virtual byte[] getContent() => 
            this.content;

        public virtual int getContentLen() => 
            this.contentLen;

        public virtual long getMessageId() => 
            this.messageId;

        public virtual int getSeqNo() => 
            this.seqNo;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x22, 0x6c, 0x6c, 0x6d, 0x75 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeLong(this.messageId, stream);
            StreamingUtils.writeInt(this.seqNo, stream);
            StreamingUtils.writeInt(this.content.Length, stream);
            StreamingUtils.writeByteArray(this.content, 0, this.contentLen, stream);
        }

        public virtual void setContent(byte[] content)
        {
            this.content = content;
        }

        public virtual void setContentLen(int contentLen)
        {
            this.contentLen = contentLen;
        }

        public virtual void setMessageId(long messageId)
        {
            this.messageId = messageId;
        }

        public virtual void setSeqNo(int seqNo)
        {
            this.seqNo = seqNo;
        }

        public override string toString() => 
            "message";
    }
}

