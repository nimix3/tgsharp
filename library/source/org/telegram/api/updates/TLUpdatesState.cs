namespace org.telegram.api.updates
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLUpdatesState : TLObject
    {
        public const int CLASS_ID = -1519637954;
        private int date;
        private int pts;
        private int qts;
        private int seq;
        private int unreadCount;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xac, 0x68 })]
        public TLUpdatesState()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLUpdatesState(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x58, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.pts = StreamingUtils.readInt(stream);
            this.qts = StreamingUtils.readInt(stream);
            this.date = StreamingUtils.readInt(stream);
            this.seq = StreamingUtils.readInt(stream);
            this.unreadCount = StreamingUtils.readInt(stream);
        }

        public override int getClassId() => 
            -1519637954;

        public virtual int getDate() => 
            this.date;

        public virtual int getPts() => 
            this.pts;

        public virtual int getQts() => 
            this.qts;

        public virtual int getSeq() => 
            this.seq;

        public virtual int getUnreadCount() => 
            this.unreadCount;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x4f, 0x6c, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.pts, stream);
            StreamingUtils.writeInt(this.qts, stream);
            StreamingUtils.writeInt(this.date, stream);
            StreamingUtils.writeInt(this.seq, stream);
            StreamingUtils.writeInt(this.unreadCount, stream);
        }

        public virtual void setDate(int value)
        {
            this.date = value;
        }

        public virtual void setPts(int value)
        {
            this.pts = value;
        }

        public virtual void setQts(int value)
        {
            this.qts = value;
        }

        public virtual void setSeq(int value)
        {
            this.seq = value;
        }

        public virtual void setUnreadCount(int value)
        {
            this.unreadCount = value;
        }

        public override string toString() => 
            "updates.state#a56c2a3e";
    }
}

