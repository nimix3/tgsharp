namespace org.telegram.api.updates
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLUpdates : TLAbsUpdates
    {
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/chat/TLAbsChat;>;")]
        private TLVector chats;
        public const int CLASS_ID = 0x74ae4240;
        private int date;
        private int seq;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/update/TLAbsUpdate;>;")]
        private TLVector updates;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLAbsUser;>;")]
        private TLVector users;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xaf, 0x68 })]
        public TLUpdates()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLUpdates(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x5b, 0x6d, 0x6d, 0x6d, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.updates = StreamingUtils.readTLVector(stream, context);
            this.users = StreamingUtils.readTLVector(stream, context);
            this.chats = StreamingUtils.readTLVector(stream, context);
            this.date = StreamingUtils.readInt(stream);
            this.seq = StreamingUtils.readInt(stream);
        }

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/chat/TLAbsChat;>;")]
        public virtual TLVector getChats() => 
            this.chats;

        public override int getClassId() => 
            0x74ae4240;

        public virtual int getDate() => 
            this.date;

        public virtual int getSeq() => 
            this.seq;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/update/TLAbsUpdate;>;")]
        public virtual TLVector getUpdates() => 
            this.updates;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLAbsUser;>;")]
        public virtual TLVector getUsers() => 
            this.users;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x52, 0x6c, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLVector(this.updates, stream);
            StreamingUtils.writeTLVector(this.users, stream);
            StreamingUtils.writeTLVector(this.chats, stream);
            StreamingUtils.writeInt(this.date, stream);
            StreamingUtils.writeInt(this.seq, stream);
        }

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/chat/TLAbsChat;>;)V")]
        public virtual void setChats(TLVector chats)
        {
            this.chats = chats;
        }

        public virtual void setDate(int date)
        {
            this.date = date;
        }

        public virtual void setSeq(int seq)
        {
            this.seq = seq;
        }

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/update/TLAbsUpdate;>;)V")]
        public virtual void setUpdates(TLVector updates)
        {
            this.updates = updates;
        }

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLAbsUser;>;)V")]
        public virtual void setUsers(TLVector users)
        {
            this.users = users;
        }

        public override string toString() => 
            "updates#74ae4240";
    }
}

