namespace org.telegram.api.richtext
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLTextConcat : TLAbsRichText
    {
        public const int CLASS_ID = 0x7e6260d7;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/richtext/TLAbsRichText;>;")]
        private TLVector texts;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa4, 0x68 })]
        public TLTextConcat()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLTextConcat(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb7, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.texts = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLAbsRichText>.Value);
        }

        public override int getClassId() => 
            0x7e6260d7;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/richtext/TLAbsRichText;>;")]
        public virtual TLVector getTexts() => 
            this.texts;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb2, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLVector(this.texts, stream);
        }

        public override string toString() => 
            "textConcat#7e6260d7";
    }
}

