namespace org.telegram.api.chat.invite
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.api.chat;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLChatInviteAlready : TLAbsChatInvite
    {
        private TLAbsChat chat;
        public const int CLASS_ID = 0x5a686d7c;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb2, 0x68 })]
        public TLChatInviteAlready()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLChatInviteAlready(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 20, 0x68, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            base.deserializeBody(stream, context);
            this.chat = StreamingUtils.readTLObject(stream, context);
        }

        public virtual TLAbsChat getChat() => 
            this.chat;

        public override int getClassId() => 
            0x5a686d7c;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 14, 0x67, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            base.serializeBody(stream);
            StreamingUtils.writeTLObject(this.chat, stream);
        }

        public virtual void setChat(TLAbsChat chat)
        {
            this.chat = chat;
        }

        public override string toString() => 
            "chat.chatInviteAlready#5a686d7c";
    }
}

