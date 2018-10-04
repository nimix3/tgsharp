namespace org.telegram.api.update
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using org.telegram.api.messages.stickers;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLUpdateNewStickerSet : TLAbsUpdate
    {
        public const int CLASS_ID = 0x688a30aa;
        private TLMessagesStickerSet stickerSet;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb9, 0x68 })]
        public TLUpdateNewStickerSet()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLUpdateNewStickerSet(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 15, 0x77 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.stickerSet = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLMessagesStickerSet>.Value);
        }

        public override int getClassId() => 
            0x688a30aa;

        public virtual TLMessagesStickerSet getStickerSet() => 
            this.stickerSet;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 10, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.stickerSet, stream);
        }

        public virtual void setStickerSet(TLMessagesStickerSet stickerSet)
        {
            this.stickerSet = stickerSet;
        }

        public override string toString() => 
            "updateNewStickerSet#688a30aa";
    }
}

