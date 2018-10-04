namespace org.telegram.api.decryptedmessage
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLDecryptedMessageActionResend : TLDecryptedMessageAction
    {
        public const int CLASS_ID = 0x511110b0;
        private int endSeqNo;
        private int startSeqNo;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa7, 0x68 })]
        public TLDecryptedMessageActionResend()
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb0, 0x68, 0x67, 0x67 })]
        public TLDecryptedMessageActionResend(int startSeqNo, int endSeqNo)
        {
            this.startSeqNo = startSeqNo;
            this.endSeqNo = endSeqNo;
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLDecryptedMessageActionResend(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 40, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.startSeqNo = StreamingUtils.readInt(stream);
            this.endSeqNo = StreamingUtils.readInt(stream);
        }

        public override int getClassId() => 
            0x511110b0;

        public virtual int getEndSeqNo() => 
            this.endSeqNo;

        public virtual int getStartSeqNo() => 
            this.startSeqNo;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x21, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.startSeqNo, stream);
            StreamingUtils.writeInt(this.endSeqNo, stream);
        }

        public virtual void setEndSeqNo(int endSeqNo)
        {
            this.endSeqNo = endSeqNo;
        }

        public virtual void setStartSeqNo(int startSeqNo)
        {
            this.startSeqNo = startSeqNo;
        }

        public override string toString() => 
            "decryptedMessageActionResend#511110b0";
    }
}

