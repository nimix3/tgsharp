namespace org.telegram.api.messages.stickers.recent
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
    public class TLMessagesRecentStickers : TLObject
    {
        public const int CLASS_ID = 0x5ce20970;
        private int hash;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/document/TLAbsDocument;>;")]
        private TLVector stickers;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa8, 0x68 })]
        public TLMessagesRecentStickers()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLMessagesRecentStickers(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0, 0x6c, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.hash = StreamingUtils.readInt(stream);
            this.stickers = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLAbsDocument>.Value);
        }

        public override int getClassId() => 
            0x5ce20970;

        public virtual int getHash() => 
            this.hash;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/document/TLAbsDocument;>;")]
        public virtual TLVector getStickers() => 
            this.stickers;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xba, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.hash, stream);
            StreamingUtils.writeTLVector(this.stickers, stream);
        }

        public override string toString() => 
            "messages.recentStickers#5ce20970";
    }
}

