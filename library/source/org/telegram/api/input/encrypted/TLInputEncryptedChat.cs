namespace org.telegram.api.input.encrypted
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLInputEncryptedChat : TLObject
    {
        private long accessHash;
        private int chatId;
        public const int CLASS_ID = -247351839;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa9, 0x68 })]
        public TLInputEncryptedChat()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLInputEncryptedChat(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x1c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.chatId = StreamingUtils.readInt(stream);
            this.accessHash = StreamingUtils.readLong(stream);
        }

        public virtual long getAccessHash() => 
            this.accessHash;

        public virtual int getChatId() => 
            this.chatId;

        public override int getClassId() => 
            -247351839;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x16, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.chatId, stream);
            StreamingUtils.writeLong(this.accessHash, stream);
        }

        public virtual void setAccessHash(long value)
        {
            this.accessHash = value;
        }

        public virtual void setChatId(int value)
        {
            this.chatId = value;
        }

        public override string toString() => 
            "inputEncryptedChat#f141b5e1";
    }
}

