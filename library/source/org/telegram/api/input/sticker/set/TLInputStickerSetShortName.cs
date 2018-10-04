namespace org.telegram.api.input.sticker.set
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLInputStickerSetShortName : TLAbsInputStickerSet
    {
        public const int CLASS_ID = -2044933984;
        private string shortName;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x10)]
        public TLInputStickerSetShortName()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLInputStickerSetShortName(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xaf, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.shortName = StreamingUtils.readTLString(stream);
        }

        public override int getClassId() => 
            -2044933984;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 170, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLString(this.shortName, stream);
        }

        public override string toString() => 
            "sticker.set.inputStickerSetShortName#861cc8a0";
    }
}

