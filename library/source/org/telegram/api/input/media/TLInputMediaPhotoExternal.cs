namespace org.telegram.api.input.media
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLInputMediaPhotoExternal : TLAbsInputMedia
    {
        private string caption;
        public const int CLASS_ID = -1252045032;
        private string url;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa8, 0x68 })]
        public TLInputMediaPhotoExternal()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLInputMediaPhotoExternal(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 7, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.url = StreamingUtils.readTLString(stream);
            this.caption = StreamingUtils.readTLString(stream);
        }

        public virtual string getCaption() => 
            this.caption;

        public override int getClassId() => 
            -1252045032;

        public virtual string getUrl() => 
            this.url;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 1, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLString(this.url, stream);
            StreamingUtils.writeTLString(this.caption, stream);
        }

        public virtual void setCaption(string caption)
        {
            this.caption = caption;
        }

        public virtual void setUrl(string url)
        {
            this.url = url;
        }

        public override string toString() => 
            "inputMediaPhotoExternal#b55f4f18";
    }
}

