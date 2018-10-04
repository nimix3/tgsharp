namespace org.telegram.api.encrypted.chat
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLEncryptedChatRequested : TLAbsEncryptedChat
    {
        private long accessHash;
        private int adminId;
        public const int CLASS_ID = -931638658;
        private int date;
        private TLBytes gA;
        private int participantId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb8, 0x68 })]
        public TLEncryptedChatRequested()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLEncryptedChatRequested(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 100, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            base.id = StreamingUtils.readInt(stream);
            this.accessHash = StreamingUtils.readLong(stream);
            this.date = StreamingUtils.readInt(stream);
            this.adminId = StreamingUtils.readInt(stream);
            this.participantId = StreamingUtils.readInt(stream);
            this.gA = StreamingUtils.readTLBytes(stream, context);
        }

        public virtual long getAccessHash() => 
            this.accessHash;

        public virtual int getAdminId() => 
            this.adminId;

        public override int getClassId() => 
            -931638658;

        public virtual int getDate() => 
            this.date;

        public virtual TLBytes getgA() => 
            this.gA;

        public virtual int getParticipantId() => 
            this.participantId;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 90, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(base.id, stream);
            StreamingUtils.writeLong(this.accessHash, stream);
            StreamingUtils.writeInt(this.date, stream);
            StreamingUtils.writeInt(this.adminId, stream);
            StreamingUtils.writeInt(this.participantId, stream);
            StreamingUtils.writeTLBytes(this.gA, stream);
        }

        public virtual void setAccessHash(long accessHash)
        {
            this.accessHash = accessHash;
        }

        public virtual void setAdminId(int adminId)
        {
            this.adminId = adminId;
        }

        public virtual void setDate(int date)
        {
            this.date = date;
        }

        public virtual void setgA(TLBytes gA)
        {
            this.gA = gA;
        }

        public virtual void setParticipantId(int participantId)
        {
            this.participantId = participantId;
        }

        public override string toString() => 
            "encryptedChatRequested#c878527e";
    }
}

