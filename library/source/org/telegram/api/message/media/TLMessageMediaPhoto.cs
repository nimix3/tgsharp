namespace org.telegram.api.message.media
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.api.photo;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLMessageMediaPhoto : TLAbsMessageMedia
    {
        private string caption;
        public const int CLASS_ID = 0x3d8ce53d;
        private TLAbsPhoto photo;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa9, 0x68 })]
        public TLMessageMediaPhoto()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLMessageMediaPhoto(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x1f, 0x72, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.photo = StreamingUtils.readTLObject(stream, context);
            this.caption = StreamingUtils.readTLString(stream);
        }

        public virtual string getCaption() => 
            this.caption;

        public override int getClassId() => 
            0x3d8ce53d;

        public virtual TLAbsPhoto getPhoto() => 
            this.photo;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x18, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.photo, stream);
            StreamingUtils.writeTLString(this.caption, stream);
        }

        public virtual void setCaption(string caption)
        {
            this.caption = caption;
        }

        public virtual void setPhoto(TLAbsPhoto photo)
        {
            this.photo = photo;
        }

        public override string toString() => 
            "messageMediaPhoto#3d8ce53d";
    }
}

