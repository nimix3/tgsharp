namespace org.telegram.api.foundgif
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.api.document;
    using org.telegram.api.photo;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLFoundGifCached : TLAbsFoundGif
    {
        public const int CLASS_ID = -1670052855;
        private TLAbsDocument document;
        private TLAbsPhoto photo;
        private string url;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb8, 0x68 })]
        public TLFoundGifCached()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLFoundGifCached(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x21, 0x6c, 0x72, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.url = StreamingUtils.readTLString(stream);
            this.photo = StreamingUtils.readTLObject(stream, context);
            this.document = StreamingUtils.readTLObject(stream, context);
        }

        public override int getClassId() => 
            -1670052855;

        public virtual TLAbsDocument getDocument() => 
            this.document;

        public virtual TLAbsPhoto getPhoto() => 
            this.photo;

        public virtual string getUrl() => 
            this.url;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x1a, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLString(this.url, stream);
            StreamingUtils.writeTLObject(this.photo, stream);
            StreamingUtils.writeTLObject(this.document, stream);
        }

        public virtual void setDocument(TLAbsDocument document)
        {
            this.document = document;
        }

        public virtual void setPhoto(TLAbsPhoto photo)
        {
            this.photo = photo;
        }

        public virtual void setUrl(string url)
        {
            this.url = url;
        }

        public override string toString() => 
            "foundGifCached#9c750409";
    }
}

