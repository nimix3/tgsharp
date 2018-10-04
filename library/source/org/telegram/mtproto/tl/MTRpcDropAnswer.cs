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
    public class MTRpcDropAnswer : TLObject
    {
        public const int CLASS_ID = 0x58e4a740;
        private Long req_msg_id;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 170, 0x68 })]
        public MTRpcDropAnswer()
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa6, 0x68, 0x67 })]
        public MTRpcDropAnswer(Long req_msg_id)
        {
            this.req_msg_id = req_msg_id;
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected MTRpcDropAnswer(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 1, 0x71 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.req_msg_id = Long.valueOf(StreamingUtils.readLong(stream));
        }

        public override int getClassId() => 
            0x58e4a740;

        public virtual Long getReq_msg_id() => 
            this.req_msg_id;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xbc, 0x73 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeLong(this.req_msg_id.longValue(), stream);
        }

        public virtual void setReq_msg_id(Long req_msg_id)
        {
            this.req_msg_id = req_msg_id;
        }

        public override string toString() => 
            "msg_resend_req#58e4a740";
    }
}

