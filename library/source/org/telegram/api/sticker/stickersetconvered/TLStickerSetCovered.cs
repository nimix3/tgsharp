namespace org.telegram.api.sticker.stickersetconvered
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLStickerSetCovered : TLAbsStickerSetCovered
    {
        public const int CLASS_ID = 0x6410a5d2;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x12)]
        public TLStickerSetCovered()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLStickerSetCovered(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb0, 0x77, 0x77 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            base.set = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLStickerSet>.Value);
            base.cover = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLAbsDocument>.Value);
        }

        public override int getClassId() => 
            0x6410a5d2;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 170, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(base.set, stream);
            StreamingUtils.writeTLObject(base.cover, stream);
        }

        public override string toString() => 
            "stickerSetCovered#6410a5d2";
    }
}

