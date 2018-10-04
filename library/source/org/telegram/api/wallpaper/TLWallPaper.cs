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
    public class TLWallPaper : TLAbsWallPaper
    {
        public const int CLASS_ID = -860866985;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/photo/size/TLAbsPhotoSize;>;")]
        private TLVector sizes;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa9, 0x68 })]
        public TLWallPaper()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLWallPaper(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xba, 0x6c, 0x6c, 0x6d, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            base.id = StreamingUtils.readInt(stream);
            base.title = StreamingUtils.readTLString(stream);
            this.sizes = StreamingUtils.readTLVector(stream, context);
            base.color = StreamingUtils.readInt(stream);
        }

        public override int getClassId() => 
            -860866985;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb2, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(base.id, stream);
            StreamingUtils.writeTLString(base.title, stream);
            StreamingUtils.writeTLVector(this.sizes, stream);
            StreamingUtils.writeInt(base.color, stream);
        }

        public override string toString() => 
            "wallPaper#ccb03657";
    }
}

