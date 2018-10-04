namespace org.telegram.api.messages
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLFoundGifs : TLObject
    {
        public const int CLASS_ID = 0x450a1c0a;
        private int nextOffset;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/foundgif/TLAbsFoundGif;>;")]
        private TLVector results;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xbf, 0x68 })]
        public TLFoundGifs()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLFoundGifs(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x1f, 0x68, 0x6c, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            base.deserializeBody(stream, context);
            this.nextOffset = StreamingUtils.readInt(stream);
            this.results = StreamingUtils.readTLVector(stream, context);
        }

        public override int getClassId() => 
            0x450a1c0a;

        public virtual int getNextOffset() => 
            this.nextOffset;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/foundgif/TLAbsFoundGif;>;")]
        public virtual TLVector getResults() => 
            this.results;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x19, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.nextOffset, stream);
            StreamingUtils.writeTLVector(this.results, stream);
        }

        public virtual void setNextOffset(int nextOffset)
        {
            this.nextOffset = nextOffset;
        }

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/foundgif/TLAbsFoundGif;>;)V")]
        public virtual void setResults(TLVector results)
        {
            this.results = results;
        }

        public override string toString() => 
            "messages.foundGifs#450a1c0a";
    }
}

