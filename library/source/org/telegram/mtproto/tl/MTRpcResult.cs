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
    public class MTRpcResult : TLObject
    {
        public const int CLASS_ID = -212046591;
        private byte[] content;
        private int contentLen;
        private long messageId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb2, 0x88 })]
        public MTRpcResult()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected MTRpcResult(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xac, 0x68, 0x67, 0x67, 0x67 })]
        public MTRpcResult(long messageId, byte[] content, int contentLen)
        {
            this.messageId = messageId;
            this.content = content;
            this.contentLen = contentLen;
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 15, 0x6c, 0x67, 0x71, 0x70 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.messageId = StreamingUtils.readLong(stream);
            int minSize = stream.available();
            this.content = BytesCache.getInstance().allocate(minSize);
            StreamingUtils.readBytes(this.content, 0, minSize, stream);
        }

        public override int getClassId() => 
            -212046591;

        public virtual byte[] getContent() => 
            this.content;

        public virtual int getContentLen() => 
            this.contentLen;

        public virtual long getMessageId() => 
            this.messageId;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 9, 0x6c, 0x75 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeLong(this.messageId, stream);
            StreamingUtils.writeByteArray(this.content, 0, this.contentLen, stream);
        }

        public override string toString() => 
            "rpc_result#f35c6d01";
    }
}

