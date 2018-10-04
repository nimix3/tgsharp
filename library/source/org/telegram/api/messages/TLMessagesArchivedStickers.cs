namespace org.telegram.api.messages
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
    public class TLMessagesArchivedStickers : TLObject
    {
        public const int CLASS_ID = 0x4fcba9c8;
        private int count;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/sticker/stickersetconvered/TLAbsStickerSetCovered;>;")]
        private TLVector sets;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa8, 0x68 })]
        public TLMessagesArchivedStickers()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLMessagesArchivedStickers(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0, 0x6c, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.count = StreamingUtils.readInt(stream);
            this.sets = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLAbsStickerSetCovered>.Value);
        }

        public override int getClassId() => 
            0x4fcba9c8;

        public virtual int getCount() => 
            this.count;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/sticker/stickersetconvered/TLAbsStickerSetCovered;>;")]
        public virtual TLVector getSets() => 
            this.sets;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xba, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.count, stream);
            StreamingUtils.writeTLVector(this.sets, stream);
        }

        public override string toString() => 
            "messages.archivedStickers#4fcba9c8";
    }
}

