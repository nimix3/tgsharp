namespace org.telegram.api.update
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLUpdateChatAdmin : TLAbsUpdate
    {
        private int chatId;
        public const int CLASS_ID = 0x6e947941;
        private bool enabled;
        private int version;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xba, 0x68 })]
        public TLUpdateChatAdmin()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLUpdateChatAdmin(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x22, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.chatId = StreamingUtils.readInt(stream);
            this.enabled = StreamingUtils.readTLBool(stream);
            this.version = StreamingUtils.readInt(stream);
        }

        public virtual int getChatId() => 
            this.chatId;

        public override int getClassId() => 
            0x6e947941;

        public virtual int getVersion() => 
            this.version;

        public virtual bool isEnabled() => 
            this.enabled;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x1b, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.chatId, stream);
            StreamingUtils.writeTLBool(this.enabled, stream);
            StreamingUtils.writeInt(this.version, stream);
        }

        public virtual void setChatId(int chatId)
        {
            this.chatId = chatId;
        }

        public virtual void setEnabled(bool enabled)
        {
            int num = (int) enabled;
            this.enabled = (bool) num;
        }

        public virtual void setVersion(int version)
        {
            this.version = version;
        }

        public override string toString() => 
            "update.TLUpdateChatAdmin#6e947941";
    }
}

