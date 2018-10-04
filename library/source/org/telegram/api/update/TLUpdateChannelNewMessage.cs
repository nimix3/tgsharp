namespace org.telegram.api.update
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.api.message;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Implements(new string[] { "org.telegram.api.update.TLChannelUpdate" })]
    public class TLUpdateChannelNewMessage : TLAbsUpdate, TLChannelUpdate
    {
        public const int CLASS_ID = 0x62ba04d9;
        private TLAbsMessage message;
        private int pts;
        private int ptsCount;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 170, 0x68 })]
        public TLUpdateChannelNewMessage()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLUpdateChannelNewMessage(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x19, 0x72, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.message = StreamingUtils.readTLObject(stream, context);
            this.pts = StreamingUtils.readInt(stream);
            this.ptsCount = StreamingUtils.readInt(stream);
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x3f)]
        public virtual int getChannelId() => 
            this.message.getChatId();

        public override int getClassId() => 
            0x62ba04d9;

        public virtual TLAbsMessage getMessage() => 
            this.message;

        public override int getPts() => 
            this.pts;

        public override int getPtsCount() => 
            this.ptsCount;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x12, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.message, stream);
            StreamingUtils.writeInt(this.pts, stream);
            StreamingUtils.writeInt(this.ptsCount, stream);
        }

        public virtual void setMessage(TLAbsMessage message)
        {
            this.message = message;
        }

        public virtual void setPts(int pts)
        {
            this.pts = pts;
        }

        public virtual void setPtsCount(int ptsCount)
        {
            this.ptsCount = ptsCount;
        }

        public override string toString() => 
            "update.TLUpdateChannelNewMessage#62ba04d9";
    }
}

