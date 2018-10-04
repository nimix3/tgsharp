namespace org.telegram.api.messages.dialogs
{
    using IKVM.Attributes;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public abstract class TLAbsDialogs : TLObject
    {
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/chat/TLAbsChat;>;")]
        protected internal TLVector chats;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/dialog/TLDialog;>;")]
        protected internal TLVector dialogs;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/message/TLAbsMessage;>;")]
        protected internal TLVector messages;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLAbsUser;>;")]
        protected internal TLVector users;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb1, 0x68 })]
        protected internal TLAbsDialogs()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAbsDialogs(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/chat/TLAbsChat;>;")]
        public virtual TLVector getChats() => 
            this.chats;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/dialog/TLDialog;>;")]
        public virtual TLVector getDialogs() => 
            this.dialogs;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/message/TLAbsMessage;>;")]
        public virtual TLVector getMessages() => 
            this.messages;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLAbsUser;>;")]
        public virtual TLVector getUsers() => 
            this.users;

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/chat/TLAbsChat;>;)V")]
        public virtual void setChats(TLVector value)
        {
            this.chats = value;
        }

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/dialog/TLDialog;>;)V")]
        public virtual void setDialogs(TLVector value)
        {
            this.dialogs = value;
        }

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/message/TLAbsMessage;>;)V")]
        public virtual void setMessages(TLVector value)
        {
            this.messages = value;
        }

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLAbsUser;>;)V")]
        public virtual void setUsers(TLVector value)
        {
            this.users = value;
        }
    }
}

