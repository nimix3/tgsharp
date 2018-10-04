namespace org.telegram.api.update.encrypted
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.api.update;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLUpdateEncryptedChatTyping : TLAbsUpdate
    {
        private int chatId;
        public const int CLASS_ID = 0x1710f156;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa7, 0x68 })]
        public TLUpdateEncryptedChatTyping()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLUpdateEncryptedChatTyping(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 7, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.chatId = StreamingUtils.readInt(stream);
        }

        public virtual int getChatId() => 
            this.chatId;

        public override int getClassId() => 
            0x1710f156;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 2, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.chatId, stream);
        }

        public virtual void setChatId(int chatId)
        {
            this.chatId = chatId;
        }

        public override string toString() => 
            "updateEncryptedChatTyping#1710f156";
    }
}

