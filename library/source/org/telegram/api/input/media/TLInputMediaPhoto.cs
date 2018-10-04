namespace org.telegram.api.input.media
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.api.input.photo;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLInputMediaPhoto : TLAbsInputMedia
    {
        private string caption;
        public const int CLASS_ID = -373312269;
        private TLAbsInputPhoto id;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa9, 0x68 })]
        public TLInputMediaPhoto()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLInputMediaPhoto(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x1c, 0x72, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.id = StreamingUtils.readTLObject(stream, context);
            this.caption = StreamingUtils.readTLString(stream);
        }

        public virtual string getCaption() => 
            this.caption;

        public override int getClassId() => 
            -373312269;

        public virtual TLAbsInputPhoto getId() => 
            this.id;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x16, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.id, stream);
            StreamingUtils.writeTLString(this.caption, stream);
        }

        public virtual void setCaption(string caption)
        {
            this.caption = caption;
        }

        public virtual void setId(TLAbsInputPhoto value)
        {
            this.id = value;
        }

        public override string toString() => 
            "inputMediaPhoto#e9bfb4f3";
    }
}

