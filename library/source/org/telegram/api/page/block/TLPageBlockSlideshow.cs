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
    public class TLPageBlockSlideshow : TLAbsPageBlock
    {
        private TLAbsRichText caption;
        public const int CLASS_ID = 0x130c8963;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/page/block/TLAbsPageBlock;>;")]
        private TLVector items;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa5, 0x68 })]
        public TLPageBlockSlideshow()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLPageBlockSlideshow(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xbd, 0x72, 0x77 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.items = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLAbsPageBlock>.Value);
            this.caption = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLAbsRichText>.Value);
        }

        public virtual TLAbsRichText getCaption() => 
            this.caption;

        public override int getClassId() => 
            0x130c8963;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/page/block/TLAbsPageBlock;>;")]
        public virtual TLVector getItems() => 
            this.items;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb7, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLVector(this.items, stream);
            StreamingUtils.writeTLObject(this.caption, stream);
        }

        public override string toString() => 
            "pageBlockSlideshow#130c8963";
    }
}

