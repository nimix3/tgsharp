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
    public class TLPageBlockBlockquote : TLAbsPageBlock
    {
        private TLAbsRichText caption;
        public const int CLASS_ID = 0x263d7c26;
        private TLAbsRichText text;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa4, 0x68 })]
        public TLPageBlockBlockquote()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLPageBlockBlockquote(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xbc, 0x77, 0x77 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.text = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLAbsRichText>.Value);
            this.caption = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLAbsRichText>.Value);
        }

        public virtual TLAbsRichText getCaption() => 
            this.caption;

        public override int getClassId() => 
            0x263d7c26;

        public virtual TLAbsRichText getText() => 
            this.text;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb6, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.text, stream);
            StreamingUtils.writeTLObject(this.caption, stream);
        }

        public override string toString() => 
            "pageBlockBlockquote#263d7c26";
    }
}

