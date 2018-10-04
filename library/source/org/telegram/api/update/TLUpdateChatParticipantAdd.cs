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
    public class TLUpdateChatParticipantAdd : TLAbsUpdate
    {
        private int chatId;
        public const int CLASS_ID = -364179876;
        private int date;
        private int inviterId;
        private int userId;
        private int version;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 170, 0x68 })]
        public TLUpdateChatParticipantAdd()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLUpdateChatParticipantAdd(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x4c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.chatId = StreamingUtils.readInt(stream);
            this.userId = StreamingUtils.readInt(stream);
            this.inviterId = StreamingUtils.readInt(stream);
            this.date = StreamingUtils.readInt(stream);
            this.version = StreamingUtils.readInt(stream);
        }

        public virtual int getChatId() => 
            this.chatId;

        public override int getClassId() => 
            -364179876;

        public virtual int getDate() => 
            this.date;

        public virtual int getInviterId() => 
            this.inviterId;

        public virtual int getUserId() => 
            this.userId;

        public virtual int getVersion() => 
            this.version;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x43, 0x6c, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.chatId, stream);
            StreamingUtils.writeInt(this.userId, stream);
            StreamingUtils.writeInt(this.inviterId, stream);
            StreamingUtils.writeInt(this.date, stream);
            StreamingUtils.writeInt(this.version, stream);
        }

        public virtual void setChatId(int chatId)
        {
            this.chatId = chatId;
        }

        public virtual void setDate(int date)
        {
            this.date = date;
        }

        public virtual void setInviterId(int inviterId)
        {
            this.inviterId = inviterId;
        }

        public virtual void setUserId(int userId)
        {
            this.userId = userId;
        }

        public virtual void setVersion(int version)
        {
            this.version = version;
        }

        public override string toString() => 
            "updateChatParticipantAdd#ea4b0e5c";
    }
}

