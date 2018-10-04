namespace org.telegram.api.message.action
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLMessageActionChannelMigratedFrom : TLAbsMessageAction
    {
        private int chatId;
        public const int CLASS_ID = -1336546578;
        private string title;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb9, 0x68 })]
        public TLMessageActionChannelMigratedFrom()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLMessageActionChannelMigratedFrom(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x19, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.title = StreamingUtils.readTLString(stream);
            this.chatId = StreamingUtils.readInt(stream);
        }

        public virtual int getChatId() => 
            this.chatId;

        public override int getClassId() => 
            -1336546578;

        public virtual string getTitle() => 
            this.title;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x13, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLString(this.title, stream);
            StreamingUtils.writeInt(this.chatId, stream);
        }

        public virtual void setChatId(int chatId)
        {
            this.chatId = chatId;
        }

        public virtual void setTitle(string title)
        {
            this.title = title;
        }

        public override string toString() => 
            "messageActionChannelMigratedFrom#b055eaee";
    }
}

