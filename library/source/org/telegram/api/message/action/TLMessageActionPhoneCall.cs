namespace org.telegram.api.message.action
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
    public class TLMessageActionPhoneCall : TLAbsMessageAction
    {
        private long callId;
        public const int CLASS_ID = -2132731265;
        private int duration;
        private const int FLAG_DISCARD_REASON = 1;
        private const int FLAG_DURATION = 2;
        private int flags;
        private TLAbsPhoneCallDiscardReason reason;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa9, 0x68 })]
        public TLMessageActionPhoneCall()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLMessageActionPhoneCall(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 15, 0x6c, 0x6c, 0x6a, 0x97, 0x6a, 140 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.callId = StreamingUtils.readLong(stream);
            if ((this.flags & 1) != 0)
            {
                this.reason = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLAbsPhoneCallDiscardReason>.Value);
            }
            if ((this.flags & 2) != 0)
            {
                this.duration = StreamingUtils.readInt(stream);
            }
        }

        public virtual long getCallId() => 
            this.callId;

        public override int getClassId() => 
            -2132731265;

        public virtual int getDuration() => 
            this.duration;

        public virtual int getFlags() => 
            this.flags;

        public virtual TLAbsPhoneCallDiscardReason getReason() => 
            this.reason;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 3, 0x6c, 0x6c, 0x6a, 140, 0x6a, 0x8e })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeLong(this.callId, stream);
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
            "messageActionPhoneCall#80e11a7f";
    }
}

