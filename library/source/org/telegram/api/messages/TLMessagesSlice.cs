namespace org.telegram.api.messages
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLMessagesSlice : TLAbsMessages
    {
        public const int CLASS_ID = 0xb446ae3;
        private int count;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xab, 0x68 })]
        public TLMessagesSlice()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLMessagesSlice(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x11, 0x6c, 0x6d, 0x6d, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.count = StreamingUtils.readInt(stream);
            base.messages = StreamingUtils.readTLVector(stream, context);
            base.chats = StreamingUtils.readTLVector(stream, context);
            base.users = StreamingUtils.readTLVector(stream, context);
        }

        public override int getClassId() => 
            0xb446ae3;

        public virtual int getCount() => 
            this.count;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 8, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.count, stream);
            StreamingUtils.writeTLVector(base.messages, stream);
            StreamingUtils.writeTLVector(base.chats, stream);
            StreamingUtils.writeTLVector(base.users, stream);
        }

        public virtual void setCount(int value)
        {
            this.count = value;
        }

        public override string toString() => 
            "messages.messagesSlice#b446ae3";
    }
}

