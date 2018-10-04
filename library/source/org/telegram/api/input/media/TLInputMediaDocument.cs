namespace org.telegram.api.input.media
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.api.input.document;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLInputMediaDocument : TLAbsInputMedia
    {
        private string caption;
        public const int CLASS_ID = 0x1a77f29c;
        protected internal TLAbsInputDocument id;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xac, 0x68 })]
        public TLInputMediaDocument()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLInputMediaDocument(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x15, 0x72, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.id = StreamingUtils.readTLObject(stream, context);
            this.caption = StreamingUtils.readTLString(stream);
        }

        public virtual string getCaption() => 
            this.caption;

        public override int getClassId() => 
            0x1a77f29c;

        public virtual TLAbsInputDocument getId() => 
            this.id;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 15, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.id, stream);
            StreamingUtils.writeTLString(this.caption, stream);
        }

        public virtual void setCaption(string caption)
        {
            this.caption = caption;
        }

        public virtual void setId(TLAbsInputDocument value)
        {
            this.id = value;
        }

        public override string toString() => 
            "inputMediaDocument#1a77f29c";
    }
}

