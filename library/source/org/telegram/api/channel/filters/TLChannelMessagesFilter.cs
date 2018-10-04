namespace org.telegram.api.channel.filters
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLChannelMessagesFilter : TLAbsChannelMessagesFilter
    {
        public const int CLASS_ID = -847783593;
        public const int FLAG_EXCLUDE_NEW_MESSAGES = 2;
        public const int FLAG_IMPORTANT_ONLY = 1;
        private int flags;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/message/TLMessageRange;>;")]
        private TLVector ranges;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 170, 0x68 })]
        public TLChannelMessagesFilter()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLChannelMessagesFilter(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 10, 0x6c, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.ranges = StreamingUtils.readTLVector(stream, context);
        }

        public override int getClassId() => 
            -847783593;

        public virtual int getFlags() => 
            this.flags;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/message/TLMessageRange;>;")]
        public virtual TLVector getRanges() => 
            this.ranges;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 4, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeTLVector(this.ranges, stream);
        }

        public virtual void setFlags(int flags)
        {
            this.flags = flags;
        }

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/message/TLMessageRange;>;)V")]
        public virtual void setRanges(TLVector ranges)
        {
            this.ranges = ranges;
        }

        public override string toString() => 
            "channel.messages.filter.TLChannelMessagesFilter#cd77d957";
    }
}

