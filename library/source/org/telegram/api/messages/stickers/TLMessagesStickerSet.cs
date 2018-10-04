namespace org.telegram.api.messages.stickers
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using org.telegram.api.sticker.set;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLMessagesStickerSet : TLObject
    {
        public const int CLASS_ID = -1240849242;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/document/TLDocument;>;")]
        private TLVector documents;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/sticker/pack/TLStickerPack;>;")]
        private TLVector packs;
        private TLStickerSet set;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xbc, 0x68 })]
        public TLMessagesStickerSet()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLMessagesStickerSet(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x31, 0x77, 0x72, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.set = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLStickerSet>.Value);
            this.packs = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLStickerPack>.Value);
            this.documents = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLDocument>.Value);
        }

        public override int getClassId() => 
            -1240849242;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/document/TLDocument;>;")]
        public virtual TLVector getDocuments() => 
            this.documents;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/sticker/pack/TLStickerPack;>;")]
        public virtual TLVector getPacks() => 
            this.packs;

        public virtual TLStickerSet getSet() => 
            this.set;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x29, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.set, stream);
            StreamingUtils.writeTLVector(this.packs, stream);
            StreamingUtils.writeTLVector(this.documents, stream);
        }

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/document/TLDocument;>;)V")]
        public virtual void setDocuments(TLVector documents)
        {
            this.documents = documents;
        }

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/sticker/pack/TLStickerPack;>;)V")]
        public virtual void setPacks(TLVector packs)
        {
            this.packs = packs;
        }

        public virtual void setSet(TLStickerSet set)
        {
            this.set = set;
        }

        public override string toString() => 
            "stickersSet#b60a24a6";
    }
}

