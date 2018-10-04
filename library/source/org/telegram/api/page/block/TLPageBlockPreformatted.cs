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
    public class TLPageBlockPreformatted : TLAbsPageBlock
    {
        public const int CLASS_ID = -1066346178;
        private string language;
        private TLAbsRichText text;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa4, 0x68 })]
        public TLPageBlockPreformatted()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLPageBlockPreformatted(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xbc, 0x77, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.text = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLAbsRichText>.Value);
            this.language = StreamingUtils.readTLString(stream);
        }

        public override int getClassId() => 
            -1066346178;

        public virtual string getLanguage() => 
            this.language;

        public virtual TLAbsRichText getText() => 
            this.text;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb6, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.text, stream);
            StreamingUtils.writeTLString(this.language, stream);
        }

        public override string toString() => 
            "pageBlockPreformatted#c070d93e";
    }
}

