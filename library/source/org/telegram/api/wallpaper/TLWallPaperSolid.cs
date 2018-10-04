namespace org.telegram.api.wallpaper
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLWallPaperSolid : TLAbsWallPaper
    {
        private int bgColor;
        public const int CLASS_ID = 0x63117f24;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa7, 0x68 })]
        public TLWallPaperSolid()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLWallPaperSolid(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 12, 0x6c, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            base.id = StreamingUtils.readInt(stream);
            base.title = StreamingUtils.readTLString(stream);
            this.bgColor = StreamingUtils.readInt(stream);
            base.color = StreamingUtils.readInt(stream);
        }

        public virtual int getBgColor() => 
            this.bgColor;

        public override int getClassId() => 
            0x63117f24;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 3, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(base.id, stream);
            StreamingUtils.writeTLString(base.title, stream);
            StreamingUtils.writeInt(this.bgColor, stream);
            StreamingUtils.writeInt(base.color, stream);
        }

        public virtual void setBgColor(int bgColor)
        {
            this.bgColor = bgColor;
        }

        public override string toString() => 
            "wallPaperSolid#63117f24";
    }
}

