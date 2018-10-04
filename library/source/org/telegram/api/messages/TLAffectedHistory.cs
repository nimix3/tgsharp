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
    public class TLAffectedHistory : TLObject
    {
        public const int CLASS_ID = -1269012015;
        private int offset;
        private int pts;
        private int ptsCount;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 170, 0x68 })]
        public TLAffectedHistory()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAffectedHistory(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x30, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.pts = StreamingUtils.readInt(stream);
            this.ptsCount = StreamingUtils.readInt(stream);
            this.offset = StreamingUtils.readInt(stream);
        }

        public override int getClassId() => 
            -1269012015;

        public virtual int getOffset() => 
            this.offset;

        public virtual int getPts() => 
            this.pts;

        public virtual int getPtsCount() => 
            this.ptsCount;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x29, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.pts, stream);
            StreamingUtils.writeInt(this.ptsCount, stream);
            StreamingUtils.writeInt(this.offset, stream);
        }

        public virtual void setOffset(int value)
        {
            this.offset = value;
        }

        public virtual void setPts(int value)
        {
            this.pts = value;
        }

        public virtual void setPtsCount(int ptsCount)
        {
            this.ptsCount = ptsCount;
        }

        public override string toString() => 
            "messages.affectedHistory#b45c69d1";
    }
}

