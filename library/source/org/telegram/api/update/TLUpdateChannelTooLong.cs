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
    public class TLUpdateChannelTooLong : TLAbsUpdate
    {
        private int channelId;
        public const int CLASS_ID = -352032773;
        private const int FLAG_PTS = 1;
        private int flags;
        private int pts;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xab, 0x68 })]
        public TLUpdateChannelTooLong()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLUpdateChannelTooLong(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 14, 0x6c, 0x6c, 0x6a, 140 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.channelId = StreamingUtils.readInt(stream);
            if ((this.flags & 1) != 0)
            {
                this.pts = StreamingUtils.readInt(stream);
            }
        }

        public virtual int getChannelId() => 
            this.channelId;

        public override int getClassId() => 
            -352032773;

        public override int getPts() => 
            this.pts;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 5, 0x6c, 0x6c, 0x6a, 0x8e })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeInt(this.channelId, stream);
            if ((this.flags & 1) != 0)
            {
                StreamingUtils.writeInt(this.pts, stream);
            }
        }

        public virtual void setChannelId(int channelId)
        {
            this.channelId = channelId;
        }

        public virtual void setPts(int pts)
        {
            this.pts = pts;
        }

        public override string toString() => 
            "update.TLUpdateChannelTooLong#eb0467fb";
    }
}

