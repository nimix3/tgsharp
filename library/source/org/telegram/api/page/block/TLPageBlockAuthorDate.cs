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
    public class TLPageBlockAuthorDate : TLAbsPageBlock
    {
        private TLAbsRichText author;
        public const int CLASS_ID = -1162877472;
        private int publishedDate;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa4, 0x68 })]
        public TLPageBlockAuthorDate()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLPageBlockAuthorDate(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xbc, 0x77, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.author = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLAbsRichText>.Value);
            this.publishedDate = StreamingUtils.readInt(stream);
        }

        public virtual TLAbsRichText getAuthor() => 
            this.author;

        public override int getClassId() => 
            -1162877472;

        public virtual int getPublishedDate() => 
            this.publishedDate;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb6, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.author, stream);
            StreamingUtils.writeInt(this.publishedDate, stream);
        }

        public override string toString() => 
            "pageBlockAuthorDate#baafe5e0";
    }
}

