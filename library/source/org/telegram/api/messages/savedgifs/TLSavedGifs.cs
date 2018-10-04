namespace org.telegram.api.messages.savedgifs
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLSavedGifs : TLObject
    {
        public const int CLASS_ID = 0x2e0709a5;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/document/TLAbsDocument;>;")]
        private TLVector gifs;
        private int hash;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb8, 0x68 })]
        public TLSavedGifs()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLSavedGifs(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x18, 0x6c, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.hash = StreamingUtils.readInt(stream);
            this.gifs = StreamingUtils.readTLVector(stream, context);
        }

        public override int getClassId() => 
            0x2e0709a5;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/document/TLAbsDocument;>;")]
        public virtual TLVector getGifs() => 
            this.gifs;

        public virtual int getHash() => 
            this.hash;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x12, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.hash, stream);
            StreamingUtils.writeTLVector(this.gifs, stream);
        }

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/document/TLAbsDocument;>;)V")]
        public virtual void setGifs(TLVector gifs)
        {
            this.gifs = gifs;
        }

        public virtual void setHash(int hash)
        {
            this.hash = hash;
        }

        public override string toString() => 
            "savedgifs#2e0709a5";
    }
}

