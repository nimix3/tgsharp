namespace org.telegram.api.messages
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLAffectedMessages : TLObject
    {
        public const int CLASS_ID = -2066640507;
        private int pts;
        private int ptsCount;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xad, 0x68 })]
        public TLAffectedMessages()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAffectedMessages(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x21, 0x68, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            base.deserializeBody(stream, context);
            this.pts = StreamingUtils.readInt(stream);
            this.ptsCount = StreamingUtils.readInt(stream);
        }

        public override int getClassId() => 
            -2066640507;

        public virtual int getPts() => 
            this.pts;

        public virtual int getPtsCount() => 
            this.ptsCount;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x1b, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.pts, stream);
            StreamingUtils.writeInt(this.ptsCount, stream);
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
            "messages.affectedmessages#84d19185";
    }
}

