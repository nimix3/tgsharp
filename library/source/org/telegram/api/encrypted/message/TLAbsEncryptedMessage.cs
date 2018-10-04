namespace org.telegram.api.encrypted.message
{
    using IKVM.Attributes;
    using org.telegram.api.encrypted.file;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public abstract class TLAbsEncryptedMessage : TLObject
    {
        protected internal TLBytes bytes;
        protected internal int chatId;
        protected internal int date;
        protected internal TLAbsEncryptedFile file;
        protected internal long randomId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb2, 0x68 })]
        protected internal TLAbsEncryptedMessage()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAbsEncryptedMessage(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public virtual TLBytes getBytes() => 
            this.bytes;

        public virtual int getChatId() => 
            this.chatId;

        public virtual int getDate() => 
            this.date;

        public virtual TLAbsEncryptedFile getFile() => 
            this.file;

        public virtual long getRandomId() => 
            this.randomId;

        public virtual void setBytes(TLBytes value)
        {
            this.bytes = value;
        }

        public virtual void setChatId(int value)
        {
            this.chatId = value;
        }

        public virtual void setDate(int value)
        {
            this.date = value;
        }

        public virtual void setFile(TLAbsEncryptedFile file)
        {
            this.file = file;
        }

        public virtual void setRandomId(long value)
        {
            this.randomId = value;
        }
    }
}

