namespace org.telegram.mtproto.schedule
{
    using IKVM.Attributes;
    using java.lang;
    using System;
    using System.Runtime.CompilerServices;

    public class PreparedPackage : Object
    {
        private byte[] content;
        private bool isHighPriority;
        private long messageId;
        private int seqNo;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x8b, 0xa3, 0x68, 0x67, 0x67, 0x67, 0x67 })]
        public PreparedPackage(int seqNo, long messageId, byte[] content, bool isHighPriority)
        {
            int num = (int) isHighPriority;
            this.seqNo = seqNo;
            this.messageId = messageId;
            this.content = content;
            this.isHighPriority = (bool) num;
        }

        public virtual byte[] getContent() => 
            this.content;

        public virtual long getMessageId() => 
            this.messageId;

        public virtual int getSeqNo() => 
            this.seqNo;

        public virtual bool isHighPriority() => 
            this.isHighPriority;
    }
}

