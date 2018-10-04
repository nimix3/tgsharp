namespace org.telegram.api.page.block
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using java.lang;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLPageBlockList : TLAbsPageBlock
    {
        public const int CLASS_ID = 0x3a58c7f4;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/richtext/TLAbsRichText;>;")]
        private TLVector items;
        private Boolean ordered;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa5, 0x68 })]
        public TLPageBlockList()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLPageBlockList(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xbd, 0x71, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.ordered = Boolean.valueOf(StreamingUtils.readTLBool(stream));
            this.items = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLAbsRichText>.Value);
        }

        public override int getClassId() => 
            0x3a58c7f4;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/richtext/TLAbsRichText;>;")]
        public virtual TLVector getItems() => 
            this.items;

        public virtual Boolean getOrdered() => 
            this.ordered;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb7, 0x71, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLBool(this.ordered.booleanValue(), stream);
            StreamingUtils.writeTLVector(this.items, stream);
        }

        public override string toString() => 
            "pageBlockList#3a58c7f4";
    }
}

