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
    public class TLUpdateEncryptedMessagesRead : TLAbsUpdate
    {
        private int chatId;
        public const int CLASS_ID = 0x38fe25b7;
        private int date;
        private int maxDate;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 170, 0x68 })]
        public TLUpdateEncryptedMessagesRead()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLUpdateEncryptedMessagesRead(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x31, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.chatId = StreamingUtils.readInt(stream);
            this.maxDate = StreamingUtils.readInt(stream);
            this.date = StreamingUtils.readInt(stream);
        }

        public virtual int getChatId() => 
            this.chatId;

        public override int getClassId() => 
            0x38fe25b7;

        public virtual int getDate() => 
            this.date;

        public virtual int getMaxDate() => 
            this.maxDate;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x2a, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.chatId, stream);
            StreamingUtils.writeInt(this.maxDate, stream);
            StreamingUtils.writeInt(this.date, stream);
        }

        public virtual void setChatId(int chatId)
        {
            this.chatId = chatId;
        }

        public virtual void setDate(int date)
        {
            this.date = date;
        }

        public virtual void setMaxDate(int maxDate)
        {
            this.maxDate = maxDate;
        }

        public override string toString() => 
            "updateEncryptedMessagesRead#38fe25b7";
    }
}

