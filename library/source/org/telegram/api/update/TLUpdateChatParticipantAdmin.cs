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
    public class TLUpdateChatParticipantAdmin : TLAbsUpdate
    {
        private int chatId;
        public const int CLASS_ID = -1232070311;
        private bool isAdmin;
        private int userId;
        private int version;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xbb, 0x68 })]
        public TLUpdateChatParticipantAdmin()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLUpdateChatParticipantAdmin(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x2c, 0x6c, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.chatId = StreamingUtils.readInt(stream);
            this.userId = StreamingUtils.readInt(stream);
            this.isAdmin = StreamingUtils.readTLBool(stream);
            this.version = StreamingUtils.readInt(stream);
        }

        public virtual int getChatId() => 
            this.chatId;

        public override int getClassId() => 
            -1232070311;

        public virtual int getUserId() => 
            this.userId;

        public virtual int getVersion() => 
            this.version;

        public virtual bool isAdmin() => 
            this.isAdmin;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x24, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.chatId, stream);
            StreamingUtils.writeInt(this.userId, stream);
            StreamingUtils.writeTLBool(this.isAdmin, stream);
            StreamingUtils.writeInt(this.version, stream);
        }

        public virtual void setAdmin(bool admin)
        {
            int num = (int) admin;
            this.isAdmin = (bool) num;
        }

        public virtual void setChatId(int chatId)
        {
            this.chatId = chatId;
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
            "update.TLUpdateChatParticipantAdmin#b6901959";
    }
}

