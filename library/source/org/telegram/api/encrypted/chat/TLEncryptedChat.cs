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
    public class TLEncryptedChat : TLAbsEncryptedChat
    {
        private long accessHash;
        private int adminId;
        public const int CLASS_ID = -94974410;
        private int date;
        private TLBytes gAOrB;
        private long keyFingerprint;
        private int participantId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xbc, 0x68 })]
        public TLEncryptedChat()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLEncryptedChat(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x7c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6d, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            base.id = StreamingUtils.readInt(stream);
            this.accessHash = StreamingUtils.readLong(stream);
            this.date = StreamingUtils.readInt(stream);
            this.adminId = StreamingUtils.readInt(stream);
            this.participantId = StreamingUtils.readInt(stream);
            this.gAOrB = StreamingUtils.readTLBytes(stream, context);
            this.keyFingerprint = StreamingUtils.readLong(stream);
        }

        public virtual long getAccessHash() => 
            this.accessHash;

        public virtual int getAdminId() => 
            this.adminId;

        public override int getClassId() => 
            -94974410;

        public virtual int getDate() => 
            this.date;

        public virtual TLBytes getgAOrB() => 
            this.gAOrB;

        public virtual long getKeyFingerprint() => 
            this.keyFingerprint;

        public virtual int getParticipantId() => 
            this.participantId;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x71, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(base.id, stream);
            StreamingUtils.writeLong(this.accessHash, stream);
            StreamingUtils.writeInt(this.date, stream);
            StreamingUtils.writeInt(this.adminId, stream);
            StreamingUtils.writeInt(this.participantId, stream);
            StreamingUtils.writeTLBytes(this.gAOrB, stream);
            StreamingUtils.writeLong(this.keyFingerprint, stream);
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

        public virtual void setgAOrB(TLBytes gAOrB)
        {
            this.gAOrB = gAOrB;
        }

        public virtual void setKeyFingerprint(long keyFingerprint)
        {
            this.keyFingerprint = keyFingerprint;
        }

        public virtual void setParticipantId(int participantId)
        {
            this.participantId = participantId;
        }

        public override string toString() => 
            "encryptedChat#fa56ce36";
    }
}

