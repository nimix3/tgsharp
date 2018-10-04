namespace org.telegram.api.updates.difference
{
    using IKVM.Attributes;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public abstract class TLAbsDifference : TLObject
    {
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/chat/TLAbsChat;>;")]
        protected internal TLVector chats;
        protected internal int date;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/encrypted/message/TLAbsEncryptedMessage;>;")]
        protected internal TLVector newEncryptedMessages;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/message/TLAbsMessage;>;")]
        protected internal TLVector newMessages;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/update/TLAbsUpdate;>;")]
        protected internal TLVector otherUpdates;
        protected internal int seq;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLAbsUser;>;")]
        protected internal TLVector users;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 190, 0xe8, 0x2a, 0xcb, 0xcb, 0xcb, 0xcb, 0xeb, 0x47 })]
        protected internal TLAbsDifference()
        {
            this.newMessages = new TLVector();
            this.newEncryptedMessages = new TLVector();
            this.otherUpdates = new TLVector();
            this.chats = new TLVector();
            this.users = new TLVector();
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAbsDifference(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/chat/TLAbsChat;>;")]
        public virtual TLVector getChats() => 
            this.chats;

        public virtual int getDate() => 
            this.date;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/encrypted/message/TLAbsEncryptedMessage;>;")]
        public virtual TLVector getNewEncryptedMessages() => 
            this.newEncryptedMessages;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/message/TLAbsMessage;>;")]
        public virtual TLVector getNewMessages() => 
            this.newMessages;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/update/TLAbsUpdate;>;")]
        public virtual TLVector getOtherUpdates() => 
            this.otherUpdates;

        public virtual int getSeq() => 
            this.seq;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLAbsUser;>;")]
        public virtual TLVector getUsers() => 
            this.users;

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/chat/TLAbsChat;>;)V")]
        public virtual void setChats(TLVector chats)
        {
            this.chats = chats;
        }

        public virtual void setDate(int date)
        {
            this.date = date;
        }

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/encrypted/message/TLAbsEncryptedMessage;>;)V")]
        public virtual void setNewEncryptedMessages(TLVector newEncryptedMessages)
        {
            this.newEncryptedMessages = newEncryptedMessages;
        }

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/message/TLAbsMessage;>;)V")]
        public virtual void setNewMessages(TLVector newMessages)
        {
            this.newMessages = newMessages;
        }

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/update/TLAbsUpdate;>;)V")]
        public virtual void setOtherUpdates(TLVector otherUpdates)
        {
            this.otherUpdates = otherUpdates;
        }

        public virtual void setSeq(int seq)
        {
            this.seq = seq;
        }

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLAbsUser;>;)V")]
        public virtual void setUsers(TLVector users)
        {
            this.users = users;
        }
    }
}

