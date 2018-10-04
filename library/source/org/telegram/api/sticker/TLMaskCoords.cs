namespace org.telegram.api.sticker
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLMaskCoords : TLObject
    {
        public const int CLASS_ID = -1361650766;
        private int n;
        private int x;
        private int y;
        private double zoom;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa7, 0x68 })]
        public TLMaskCoords()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLMaskCoords(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 9, 0x6c, 0x6c, 0x6c, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.n = StreamingUtils.readInt(stream);
            this.x = StreamingUtils.readInt(stream);
            this.y = StreamingUtils.readInt(stream);
            this.zoom = StreamingUtils.readDouble(stream);
        }

        public override int getClassId() => 
            -1361650766;

        public virtual int getN() => 
            this.n;

        public virtual int getX() => 
            this.x;

        public virtual int getY() => 
            this.y;

        public virtual double getZoom() => 
            this.zoom;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 1, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.n, stream);
            StreamingUtils.writeInt(this.x, stream);
            StreamingUtils.writeInt(this.y, stream);
            StreamingUtils.writeDouble(this.zoom, stream);
        }

        public override string toString() => 
            "maskCoords#aed6dbb2";
    }
}

