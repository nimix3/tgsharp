namespace org.telegram.api.messages.chats
{
    using IKVM.Attributes;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public abstract class TLAbsMessagesChats : TLObject
    {
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/chat/TLAbsChat;>;")]
        protected internal TLVector chats;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(11)]
        public TLAbsMessagesChats()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAbsMessagesChats(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/chat/TLAbsChat;>;")]
        public virtual TLVector getChats() => 
            this.chats;
    }
}

