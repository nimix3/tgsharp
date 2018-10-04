namespace org.telegram.api.page.block
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using org.telegram.api.richtext;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLPageBlockPhoto : TLAbsPageBlock
    {
        private TLAbsRichText caption;
        public const int CLASS_ID = -372860542;
        private long photoId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa5, 0x68 })]
        public TLPageBlockPhoto()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLPageBlockPhoto(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xbd, 0x6c, 0x77 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.photoId = StreamingUtils.readLong(stream);
            this.caption = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLAbsRichText>.Value);
        }

        public virtual TLAbsRichText getCaption() => 
            this.caption;

        public override int getClassId() => 
            -372860542;

        public virtual long getPhotoId() => 
            this.photoId;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb7, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeLong(this.photoId, stream);
            StreamingUtils.writeTLObject(this.caption, stream);
        }

        public override string toString() => 
            "pageBlockPhoto#e9c69982";
    }
}

