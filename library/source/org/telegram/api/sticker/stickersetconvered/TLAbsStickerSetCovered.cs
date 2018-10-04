namespace org.telegram.api.sticker.stickersetconvered
{
    using IKVM.Attributes;
    using org.telegram.api.document;
    using org.telegram.api.sticker.set;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public abstract class TLAbsStickerSetCovered : TLObject
    {
        protected internal TLAbsDocument cover;
        protected internal TLStickerSet set;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(13)]
        public TLAbsStickerSetCovered()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAbsStickerSetCovered(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public virtual TLAbsDocument getCover() => 
            this.cover;

        public virtual TLStickerSet getSet() => 
            this.set;
    }
}

