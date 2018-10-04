namespace org.telegram.api.phone.call
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using org.telegram.api.phone;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLPhoneCall : TLAbsPhoneCall
    {
        private long accessHash;
        private int adminId;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/phone/TLPhoneConnection;>;")]
        private TLVector alternativeConnections;
        public const int CLASS_ID = -1660057;
        private TLPhoneConnection connection;
        private int date;
        private TLBytes gAorB;
        private long id;
        private long keyFingerprint;
        private int participantId;
        private TLPhoneCallProtocol protocol;
        private int startDate;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xad, 0x68 })]
        public TLPhoneCall()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLPhoneCall(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 50, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6d, 0x6c, 0x77, 0x77, 0x72, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.id = StreamingUtils.readLong(stream);
            this.accessHash = StreamingUtils.readLong(stream);
            this.date = StreamingUtils.readInt(stream);
            this.adminId = StreamingUtils.readInt(stream);
            this.participantId = StreamingUtils.readInt(stream);
            this.gAorB = StreamingUtils.readTLBytes(stream, context);
            this.keyFingerprint = StreamingUtils.readLong(stream);
            this.protocol = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLPhoneCallProtocol>.Value);
            this.connection = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLPhoneConnection>.Value);
            this.alternativeConnections = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLPhoneConnection>.Value);
            this.startDate = StreamingUtils.readInt(stream);
        }

        public virtual long getAccessHash() => 
            this.accessHash;

        public virtual int getAdminId() => 
            this.adminId;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/phone/TLPhoneConnection;>;")]
        public virtual TLVector getAlternativeConnections() => 
            this.alternativeConnections;

        public override int getClassId() => 
            -1660057;

        public virtual TLPhoneConnection getConnection() => 
            this.connection;

        public virtual int getDate() => 
            this.date;

        public virtual TLBytes getgAorB() => 
            this.gAorB;

        public virtual long getId() => 
            this.id;

        public virtual long getKeyFingerprint() => 
            this.keyFingerprint;

        public virtual int getParticipantId() => 
            this.participantId;

        public virtual TLPhoneCallProtocol getProtocol() => 
            this.protocol;

        public virtual int getStartDate() => 
            this.startDate;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x23, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeLong(this.id, stream);
            StreamingUtils.writeLong(this.accessHash, stream);
            StreamingUtils.writeInt(this.date, stream);
            StreamingUtils.writeInt(this.adminId, stream);
            StreamingUtils.writeInt(this.participantId, stream);
            StreamingUtils.writeTLBytes(this.gAorB, stream);
            StreamingUtils.writeLong(this.keyFingerprint, stream);
            StreamingUtils.writeTLObject(this.protocol, stream);
            StreamingUtils.writeTLObject(this.connection, stream);
            StreamingUtils.writeTLVector(this.alternativeConnections, stream);
            StreamingUtils.writeInt(this.startDate, stream);
        }

        public override string toString() => 
            "phoneCall#ffe6ab67";
    }
}

