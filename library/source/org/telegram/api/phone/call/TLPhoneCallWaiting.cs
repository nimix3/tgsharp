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
    public class TLPhoneCallWaiting : TLAbsPhoneCall
    {
        private long accessHash;
        private int adminId;
        public const int CLASS_ID = 0x1b8f4ad1;
        private int date;
        private const int FLAG_RECEIVE_DATE = 1;
        private int flags;
        private long id;
        private int participantId;
        private TLPhoneCallProtocol protocol;
        private int receiveDate;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xac, 0x68 })]
        public TLPhoneCallWaiting()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLPhoneCallWaiting(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x24, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x77, 0x6a, 140 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.id = StreamingUtils.readLong(stream);
            this.accessHash = StreamingUtils.readLong(stream);
            this.date = StreamingUtils.readInt(stream);
            this.adminId = StreamingUtils.readInt(stream);
            this.participantId = StreamingUtils.readInt(stream);
            this.protocol = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLPhoneCallProtocol>.Value);
            if ((this.flags & 1) != 0)
            {
                this.receiveDate = StreamingUtils.readInt(stream);
            }
        }

        public virtual long getAccessHash() => 
            this.accessHash;

        public virtual int getAdminId() => 
            this.adminId;

        public override int getClassId() => 
            0x1b8f4ad1;

        public virtual int getDate() => 
            this.date;

        public virtual int getFlags() => 
            this.flags;

        public virtual long getId() => 
            this.id;

        public virtual int getParticipantId() => 
            this.participantId;

        public virtual TLPhoneCallProtocol getProtocol() => 
            this.protocol;

        public virtual int getReceiveDate() => 
            this.receiveDate;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x16, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6a, 0x8e })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeLong(this.id, stream);
            StreamingUtils.writeLong(this.accessHash, stream);
            StreamingUtils.writeInt(this.date, stream);
            StreamingUtils.writeInt(this.adminId, stream);
            StreamingUtils.writeInt(this.participantId, stream);
            StreamingUtils.writeTLObject(this.protocol, stream);
            if ((this.flags & 1) != 0)
            {
                StreamingUtils.writeInt(this.receiveDate, stream);
            }
        }

        public override string toString() => 
            "phoneCallWaiting#1b8f4ad1";
    }
}

