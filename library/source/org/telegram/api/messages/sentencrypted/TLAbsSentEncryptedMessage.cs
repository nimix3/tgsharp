namespace org.telegram.api.messages.sentencrypted
{
    using IKVM.Attributes;
    using org.telegram.api.encrypted.file;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public abstract class TLAbsSentEncryptedMessage : TLObject
    {
        protected internal int date;
        protected internal TLAbsEncryptedFile file;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa5, 0x68 })]
        protected internal TLAbsSentEncryptedMessage()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAbsSentEncryptedMessage(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public virtual int getDate() => 
            this.date;

        public virtual TLAbsEncryptedFile getFile() => 
            this.file;

        public virtual void setDate(int value)
        {
            this.date = value;
        }

        public virtual void setFile(TLAbsEncryptedFile file)
        {
            this.file = file;
        }
    }
}

