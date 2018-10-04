namespace org.telegram.mtproto.tl
{
    using IKVM.Attributes;
    using java.io;
    using java.lang;
    using java.util;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class MTMsgsAck : TLObject
    {
        public const int CLASS_ID = 0x62d6b459;
        private TLLongVector messages;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xad, 0xe8, 0x3a, 0xeb, 0x47 })]
        public MTMsgsAck()
        {
            this.messages = new TLLongVector();
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb7, 0xe8, 0x30, 0xeb, 0x51, 0x6b, 0x6d })]
        public MTMsgsAck(Long[] msgIds)
        {
            this.messages = new TLLongVector();
            this.messages = new TLLongVector();
            Collections.addAll(this.messages, msgIds);
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa9, 8, 0xab, 0x67 })]
        public MTMsgsAck(TLLongVector messages)
        {
            this.messages = new TLLongVector();
            this.messages = messages;
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb0, 0xe8, 0x37, 0xeb, 0x4a, 0x6b, 0x70, 0x33, 0xa6 })]
        public MTMsgsAck(long[] msgIds)
        {
            this.messages = new TLLongVector();
            this.messages = new TLLongVector();
            long[] numArray = msgIds;
            int length = numArray.Length;
            int index = 0;
            while (true)
            {
                if (index >= length)
                {
                    break;
                }
                long num3 = numArray[index];
                this.messages.add(Long.valueOf(num3));
                index++;
            }
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected MTMsgsAck(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 12, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.messages = StreamingUtils.readTLLongVector(stream, context);
        }

        public override int getClassId() => 
            0x62d6b459;

        public virtual TLLongVector getMessages() => 
            this.messages;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 7, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLVector(this.messages, stream);
        }

        public override string toString() => 
            "msgs_ack#62d6b459";
    }
}

