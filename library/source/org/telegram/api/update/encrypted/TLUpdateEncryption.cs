namespace org.telegram.api.update.encrypted
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.api.encrypted.chat;
    using org.telegram.api.update;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLUpdateEncryption : TLAbsUpdate
    {
        private TLAbsEncryptedChat chat;
        public const int CLASS_ID = -1264392051;
        private int date;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 170, 0x68 })]
        public TLUpdateEncryption()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLUpdateEncryption(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x1d, 0x72, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.chat = StreamingUtils.readTLObject(stream, context);
            this.date = StreamingUtils.readInt(stream);
        }

        public virtual TLAbsEncryptedChat getChat() => 
            this.chat;

        public override int getClassId() => 
            -1264392051;

        public virtual int getDate() => 
            this.date;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x17, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.chat, stream);
            StreamingUtils.writeInt(this.date, stream);
        }

        public virtual void setChat(TLAbsEncryptedChat chat)
        {
            this.chat = chat;
        }

        public virtual void setDate(int date)
        {
            this.date = date;
        }

        public override string toString() => 
            "updateEncryption#b4a2e88d";
    }
}

