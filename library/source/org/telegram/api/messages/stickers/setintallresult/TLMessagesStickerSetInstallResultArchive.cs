namespace org.telegram.api.messages.stickers.setintallresult
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
    public class TLMessagesStickerSetInstallResultArchive : TLAbsMessagesStickerSetInstallResult
    {
        public const int CLASS_ID = 0x35e410a8;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/sticker/stickersetconvered/TLAbsStickerSetCovered;>;")]
        private TLVector sets;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa6, 0x68 })]
        public TLMessagesStickerSetInstallResultArchive()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLMessagesStickerSetInstallResultArchive(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb9, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.sets = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLAbsStickerSetCovered>.Value);
        }

        public override int getClassId() => 
            0x35e410a8;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/sticker/stickersetconvered/TLAbsStickerSetCovered;>;")]
        public virtual TLVector getSets() => 
            this.sets;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 180, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLVector(this.sets, stream);
        }

        public override string toString() => 
            "messages.stickerSetInstallResultArchive#35e410a8";
    }
}

