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
    public class TLTextEmail : TLAbsRichText
    {
        public const int CLASS_ID = -564523562;
        private string email;
        private TLAbsRichText text;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa4, 0x68 })]
        public TLTextEmail()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLTextEmail(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xbc, 0x77, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.text = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLAbsRichText>.Value);
            this.email = StreamingUtils.readTLString(stream);
        }

        public override int getClassId() => 
            -564523562;

        public virtual string getEmail() => 
            this.email;

        public virtual TLAbsRichText getText() => 
            this.text;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb6, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.text, stream);
            StreamingUtils.writeTLString(this.email, stream);
        }

        public override string toString() => 
            "textEmail#de5a0dd6";
    }
}

