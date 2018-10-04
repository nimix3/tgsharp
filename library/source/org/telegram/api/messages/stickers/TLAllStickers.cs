namespace org.telegram.api.messages.stickers
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
    public class TLAllStickers : TLAbsAllStickers
    {
        public const int CLASS_ID = -302170017;
        private int hash;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/sticker/set/TLStickerSet;>;")]
        private TLVector sets;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb5, 0xe8, 0x3a, 0xeb, 0x47 })]
        public TLAllStickers()
        {
            this.sets = new TLVector();
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAllStickers(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x21, 0x6c, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.hash = StreamingUtils.readInt(stream);
            this.sets = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLStickerSet>.Value);
        }

        public override int getClassId() => 
            -302170017;

        public virtual int getHash() => 
            this.hash;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/sticker/set/TLStickerSet;>;")]
        public virtual TLVector getSets() => 
            this.sets;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x1a, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.hash, stream);
            StreamingUtils.writeTLVector(this.sets, stream);
        }

        public virtual void setHash(int hash)
        {
            this.hash = hash;
        }

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/sticker/set/TLStickerSet;>;)V")]
        public virtual void setSets(TLVector sets)
        {
            this.sets = sets;
        }

        public override string toString() => 
            "allStickers#edfd405f";
    }
}

