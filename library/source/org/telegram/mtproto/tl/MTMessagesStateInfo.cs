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
    public class MTMessagesStateInfo : TLObject
    {
        public const int CLASS_ID = 0x4deb57d;
        private string info;
        private Long req_msg_id;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa5, 0x68 })]
        public MTMessagesStateInfo()
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa8, 0x68, 0x67, 0x67 })]
        public MTMessagesStateInfo(Long reqMsgId, string info)
        {
            this.req_msg_id = reqMsgId;
            this.info = info;
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected MTMessagesStateInfo(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb8, 0x71, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.req_msg_id = Long.valueOf(StreamingUtils.readLong(stream));
            this.info = StreamingUtils.readTLString(stream);
        }

        public override int getClassId() => 
            0x4deb57d;

        public virtual string getInfo() => 
            this.info;

        public virtual Long getReqMsgId() => 
            this.req_msg_id;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb3, 0x71, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeLong(this.req_msg_id.longValue(), stream);
            StreamingUtils.writeTLString(this.info, stream);
        }

        public virtual void setInfo(string info)
        {
            this.info = info;
        }

        public virtual void setReqMsgId(Long req_msg_id)
        {
            this.req_msg_id = req_msg_id;
        }

        public override string toString() => 
            "mtMessagesStateInfo#04deb57d";
    }
}

