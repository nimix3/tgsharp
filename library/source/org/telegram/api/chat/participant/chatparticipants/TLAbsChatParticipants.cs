namespace org.telegram.api.chat.participant.chatparticipants
{
    using IKVM.Attributes;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public abstract class TLAbsChatParticipants : TLObject
    {
        protected internal int chatId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb8, 0x68 })]
        protected internal TLAbsChatParticipants()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAbsChatParticipants(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public virtual int getChatId() => 
            this.chatId;

        public virtual void setChatId(int chatId)
        {
            this.chatId = chatId;
        }
    }
}

