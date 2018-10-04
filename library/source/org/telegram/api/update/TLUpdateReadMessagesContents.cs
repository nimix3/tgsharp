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
    public class TLUpdateReadMessagesContents : TLAbsUpdate
    {
        public const int CLASS_ID = 0x68c13933;
        private TLIntVector messages;
        private int pts;
        private int ptsCount;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 170, 0x68 })]
        public TLUpdateReadMessagesContents()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLUpdateReadMessagesContents(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x30, 0x6d, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.messages = StreamingUtils.readTLIntVector(stream, context);
            this.pts = StreamingUtils.readInt(stream);
            this.ptsCount = StreamingUtils.readInt(stream);
        }

        public override int getClassId() => 
            0x68c13933;

        public virtual TLIntVector getMessages() => 
            this.messages;

        public override int getPts() => 
            this.pts;

        public override int getPtsCount() => 
            this.ptsCount;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x29, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLVector(this.messages, stream);
            StreamingUtils.writeInt(this.pts, stream);
            StreamingUtils.writeInt(this.ptsCount, stream);
        }

        public virtual void setMessages(TLIntVector messages)
        {
            this.messages = messages;
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
            "updates.updateReadMessagesContents#68c13933";
    }
}

