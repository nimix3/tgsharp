namespace org.telegram.api.messages.stickers.featured
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
    public class TLMessagesFeaturedStickers : TLAbsMessagesFeaturedStickers
    {
        public const int CLASS_ID = -123893531;
        private int hash;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/sticker/stickersetconvered/TLAbsStickerSetCovered;>;")]
        private TLVector sets;
        private TLLongVector unread;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa9, 0x68 })]
        public TLMessagesFeaturedStickers()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLMessagesFeaturedStickers(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 6, 0x6c, 0x72, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.hash = StreamingUtils.readInt(stream);
            this.sets = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLAbsStickerSetCovered>.Value);
            this.unread = StreamingUtils.readTLLongVector(stream, context);
        }

        public override int getClassId() => 
            -123893531;

        public virtual int getHash() => 
            this.hash;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/sticker/stickersetconvered/TLAbsStickerSetCovered;>;")]
        public virtual TLVector getSets() => 
            this.sets;

        public virtual TLLongVector getUnread() => 
            this.unread;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xbf, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.hash, stream);
            StreamingUtils.writeTLVector(this.sets, stream);
            StreamingUtils.writeTLVector(this.unread, stream);
        }

        public override string toString() => 
            "messages.featuredStickers#f89d88e5";
    }
}

