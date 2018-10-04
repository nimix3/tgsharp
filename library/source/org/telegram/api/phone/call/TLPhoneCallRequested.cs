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
    public class TLPhoneCallRequested : TLAbsPhoneCall
    {
        private long accessHash;
        private int adminId;
        public const int CLASS_ID = -2089411356;
        private int date;
        private TLBytes gAHash;
        private long id;
        private int participantId;
        private TLPhoneCallProtocol protocol;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 170, 0x68 })]
        public TLPhoneCallRequested()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLPhoneCallRequested(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x1b, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6d, 0x77 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.id = StreamingUtils.readLong(stream);
            this.accessHash = StreamingUtils.readLong(stream);
            this.date = StreamingUtils.readInt(stream);
            this.adminId = StreamingUtils.readInt(stream);
            this.participantId = StreamingUtils.readInt(stream);
            this.gAHash = StreamingUtils.readTLBytes(stream, context);
            this.protocol = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLPhoneCallProtocol>.Value);
        }

        public virtual long getAccessHash() => 
            this.accessHash;

        public virtual int getAdminId() => 
            this.adminId;

        public override int getClassId() => 
            -2089411356;

        public virtual int getDate() => 
            this.date;

        public virtual TLBytes getgAHash() => 
            this.gAHash;

        public virtual long getId() => 
            this.id;

        public virtual int getParticipantId() => 
            this.participantId;

        public virtual TLPhoneCallProtocol getProtocol() => 
            this.protocol;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x10, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeLong(this.id, stream);
            StreamingUtils.writeLong(this.accessHash, stream);
            StreamingUtils.writeInt(this.date, stream);
            StreamingUtils.writeInt(this.adminId, stream);
            StreamingUtils.writeInt(this.participantId, stream);
            StreamingUtils.writeTLBytes(this.gAHash, stream);
            StreamingUtils.writeTLObject(this.protocol, stream);
        }

        public override string toString() => 
            "phoneCallRequested#83761ce4";
    }
}

