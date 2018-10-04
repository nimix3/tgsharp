namespace org.telegram.api.sticker.pack
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLStickerPack : TLObject
    {
        public const int CLASS_ID = 0x12b299d4;
        private TLLongVector documents;
        private string emoticon;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb5, 0x68 })]
        public TLStickerPack()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLStickerPack(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x2b, 0x6c, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.emoticon = StreamingUtils.readTLString(stream);
            this.documents = StreamingUtils.readTLLongVector(stream, context);
        }

        public override int getClassId() => 
            0x12b299d4;

        public virtual TLLongVector getDocuments() => 
            this.documents;

        public virtual string getEmoticon() => 
            this.emoticon;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x24, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLString(this.emoticon, stream);
            StreamingUtils.writeTLVector(this.documents, stream);
        }

        public virtual void setDocuments(TLLongVector documents)
        {
            this.documents = documents;
        }

        public virtual void setEmoticon(string emoticon)
        {
            this.emoticon = emoticon;
        }

        public override string toString() => 
            "stickerPack#12b299d4";
    }
}

