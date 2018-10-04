namespace org.telegram.api.update
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.api.sendmessage.action;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLUpdateChatUserTyping : TLAbsUpdate
    {
        private TLAbsSendMessageAction action;
        private int chatId;
        public const int CLASS_ID = -1704596961;
        private int userId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 170, 0x68 })]
        public TLUpdateChatUserTyping()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLUpdateChatUserTyping(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 6, 0x6c, 0x6c, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.chatId = StreamingUtils.readInt(stream);
            this.userId = StreamingUtils.readInt(stream);
            this.action = StreamingUtils.readTLObject(stream, context);
        }

        public virtual TLAbsSendMessageAction getAction() => 
            this.action;

        public virtual int getChatId() => 
            this.chatId;

        public override int getClassId() => 
            -1704596961;

        public virtual int getUserId() => 
            this.userId;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xbf, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.chatId, stream);
            StreamingUtils.writeInt(this.userId, stream);
            StreamingUtils.writeTLObject(this.action, stream);
        }

        public override string toString() => 
            "updateChatUserTyping#9a65ea1f";
    }
}

