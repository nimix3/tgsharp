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
    public class MTBadServerSalt : MTBadMessage
    {
        public const int CLASS_ID = -307542917;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa8, 0x68, 0x68, 0x67, 0x67, 0x68 })]
        public MTBadServerSalt()
        {
            base.badMsgId = 0L;
            base.badMsqSeqno = 0;
            base.errorCode = 0;
            base.newServerSalt = 0L;
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected MTBadServerSalt(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa1, 0x68, 0x67, 0x67, 0x67, 0x68 })]
        public MTBadServerSalt(long messageId, int seqNo, int errorNo, long newSalt)
        {
            base.badMsgId = messageId;
            base.badMsqSeqno = seqNo;
            base.errorCode = errorNo;
            base.newServerSalt = newSalt;
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 2, 0x6c, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            base.badMsgId = StreamingUtils.readLong(stream);
            base.badMsqSeqno = StreamingUtils.readInt(stream);
            base.errorCode = StreamingUtils.readInt(stream);
            base.newServerSalt = StreamingUtils.readLong(stream);
        }

        public override int getClassId() => 
            -307542917;

        public override long getNewServerSalt() => 
            base.newServerSalt;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xba, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeLong(base.badMsgId, stream);
            StreamingUtils.writeInt(base.badMsqSeqno, stream);
            StreamingUtils.writeInt(base.errorCode, stream);
            StreamingUtils.writeLong(base.newServerSalt, stream);
        }

        public override string toString() => 
            "bad_server_salt#edab447b";
    }
}

