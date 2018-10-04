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
    public class TLStickers : TLAbsStickers
    {
        public const int CLASS_ID = -1970352846;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/document/TLDocument;>;")]
        private TLVector documents;
        private string hash;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb5, 0x68 })]
        public TLStickers()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLStickers(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x2b, 0x6c, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.hash = StreamingUtils.readTLString(stream);
            this.documents = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLDocument>.Value);
        }

        public override int getClassId() => 
            -1970352846;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/document/TLDocument;>;")]
        public virtual TLVector getDocuments() => 
            this.documents;

        public virtual string getHash() => 
            this.hash;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x24, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLString(this.hash, stream);
            StreamingUtils.writeTLVector(this.documents, stream);
        }

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/document/TLDocument;>;)V")]
        public virtual void setDocuments(TLVector documents)
        {
            this.documents = documents;
        }

        public virtual void setHash(string hash)
        {
            this.hash = hash;
        }

        public override string toString() => 
            "stickers#8a8ecd32";
    }
}

