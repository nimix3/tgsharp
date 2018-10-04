namespace org.telegram.api.phone.call
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using org.telegram.api.phone.call.discardreason;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLPhoneCallDiscarded : TLAbsPhoneCall
    {
        public const int CLASS_ID = 0x50ca4de1;
        private int duration;
        private const int FLAG_DISCARD_REASON = 1;
        private const int FLAG_DURATION = 2;
        private const int FLAG_NEED_RATING = 2;
        private int flags;
        private long id;
        private TLAbsPhoneCallDiscardReason reason;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 170, 0x68 })]
        public TLPhoneCallDiscarded()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLPhoneCallDiscarded(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x18, 0x6c, 0x6c, 0x6a, 0x97, 0x6a, 140 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.id = StreamingUtils.readLong(stream);
            if ((this.flags & 1) != 0)
            {
                this.reason = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLAbsPhoneCallDiscardReason>.Value);
            }
            if ((this.flags & 2) != 0)
            {
                this.duration = StreamingUtils.readInt(stream);
            }
        }

        public override int getClassId() => 
            0x50ca4de1;

        public virtual int getDuration() => 
            this.duration;

        public virtual long getId() => 
            this.id;

        public virtual TLAbsPhoneCallDiscardReason getReason() => 
            this.reason;

        public virtual bool hasDiscardReason() => 
            ((this.flags & 1) != 0);

        public virtual bool hasDuration() => 
            ((this.flags & 2) != 0);

        public virtual bool needRatting() => 
            ((this.flags & 2) != 0);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 12, 0x6c, 0x6c, 0x6a, 140, 0x6a, 0x8e })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeLong(this.id, stream);
            if ((this.flags & 1) != 0)
            {
                StreamingUtils.writeTLObject(this.reason, stream);
            }
            if ((this.flags & 2) != 0)
            {
                StreamingUtils.writeInt(this.duration, stream);
            }
        }

        public override string toString() => 
            "phoneCallDiscarded#50ca4de1";
    }
}

