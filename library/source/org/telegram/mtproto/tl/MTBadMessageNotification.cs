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
    public class MTBadMessageNotification : MTBadMessage
    {
        public const int CLASS_ID = -1477445615;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa6, 0x88 })]
        public MTBadMessageNotification()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected MTBadMessageNotification(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 160, 0x68, 0x67, 0x67, 0x67 })]
        public MTBadMessageNotification(long badMsgId, int badMsqSeqno, int errorCode)
        {
            base.badMsgId = badMsgId;
            base.badMsqSeqno = badMsqSeqno;
            base.errorCode = errorCode;
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb8, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            base.badMsgId = StreamingUtils.readLong(stream);
            base.badMsqSeqno = StreamingUtils.readInt(stream);
            base.errorCode = StreamingUtils.readInt(stream);
        }

        public override int getClassId() => 
            -1477445615;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb1, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeLong(base.badMsgId, stream);
            StreamingUtils.writeInt(base.badMsqSeqno, stream);
            StreamingUtils.writeInt(base.errorCode, stream);
        }

        public override string toString() => 
            "bad_msg_notification#-1477445615";
    }
}

