namespace org.telegram.api.document.attribute
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using org.telegram.api.input.sticker.set;
    using org.telegram.api.sticker;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLDocumentAttributeSticker : TLAbsDocumentAttribute
    {
        private string alt;
        public const int CLASS_ID = 0x6319d612;
        private const int FLAG_COORDS = 1;
        private const int FLAG_MASK = 2;
        private int flags;
        private TLMaskCoords maskCoords;
        private TLAbsInputStickerSet stickerset;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb8, 0x68 })]
        public TLDocumentAttributeSticker()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLDocumentAttributeSticker(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x2a, 0x6c, 0x6c, 0x77, 0x6a, 0x97 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.alt = StreamingUtils.readTLString(stream);
            this.stickerset = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLAbsInputStickerSet>.Value);
            if ((this.flags & 1) != 0)
            {
                this.maskCoords = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLMaskCoords>.Value);
            }
        }

        public virtual string getAlt() => 
            this.alt;

        public override int getClassId() => 
            0x6319d612;

        public virtual TLMaskCoords getMaskCoords() => 
            this.maskCoords;

        public virtual TLAbsInputStickerSet getStickerset() => 
            this.stickerset;

        public virtual bool isMask() => 
            ((this.flags & 2) != 0);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x20, 0x6c, 0x6c, 0x6c, 0x6a, 0x8e })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeTLString(this.alt, stream);
            StreamingUtils.writeTLObject(this.stickerset, stream);
            if ((this.flags & 1) != 0)
            {
                StreamingUtils.writeTLObject(this.stickerset, stream);
            }
        }

        public virtual void setAlt(string alt)
        {
            this.alt = alt;
        }

        public virtual void setStickerset(TLAbsInputStickerSet stickerset)
        {
            this.stickerset = stickerset;
        }

        public override string toString() => 
            "documentAttributeSticker#6319d612";
    }
}

