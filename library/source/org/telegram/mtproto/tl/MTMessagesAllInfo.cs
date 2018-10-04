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
    public class MTMessagesAllInfo : TLObject
    {
        public const int CLASS_ID = -1933520591;
        private string info;
        private TLLongVector msgIds;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 170, 0x68 })]
        public MTMessagesAllInfo()
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xad, 0x68, 0x67, 0x67 })]
        public MTMessagesAllInfo(TLLongVector msgIds, string info)
        {
            this.msgIds = msgIds;
            this.info = info;
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected MTMessagesAllInfo(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xbb, 0x6d, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.msgIds = StreamingUtils.readTLLongVector(stream, context);
            this.info = StreamingUtils.readTLString(stream);
        }

        public override int getClassId() => 
            -1933520591;

        public virtual string getInfo() => 
            this.info;

        public virtual TLLongVector getMsgIds() => 
            this.msgIds;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb5, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLVector(this.msgIds, stream);
            StreamingUtils.writeTLString(this.info, stream);
        }

        public virtual void setInfo(string info)
        {
            this.info = info;
        }

        public virtual void setMsgIds(TLLongVector msgIds)
        {
            this.msgIds = msgIds;
        }

        public override string toString() => 
            "mtMessagesAllInfo#8cc0d131";
    }
}

