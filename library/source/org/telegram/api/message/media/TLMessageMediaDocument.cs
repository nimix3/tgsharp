namespace org.telegram.api.message.media
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.api.document;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLMessageMediaDocument : TLAbsMessageMedia
    {
        private string caption;
        public const int CLASS_ID = -203411800;
        private TLAbsDocument document;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa9, 0x68 })]
        public TLMessageMediaDocument()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLMessageMediaDocument(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x15, 0x72, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.document = StreamingUtils.readTLObject(stream, context);
            this.caption = StreamingUtils.readTLString(stream);
        }

        public virtual string getCaption() => 
            this.caption;

        public override int getClassId() => 
            -203411800;

        public virtual TLAbsDocument getDocument() => 
            this.document;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 14, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.document, stream);
            StreamingUtils.writeTLString(this.caption, stream);
        }

        public virtual void setCaption(string caption)
        {
            this.caption = caption;
        }

        public virtual void setDocument(TLAbsDocument document)
        {
            this.document = document;
        }

        public override string toString() => 
            "messageMediaDocument#f3e02ea8";
    }
}

