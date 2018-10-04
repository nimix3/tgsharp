namespace org.telegram.api.richtext
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLTextPlain : TLAbsRichText
    {
        public const int CLASS_ID = 0x744694e0;
        private string text;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa3, 0x68 })]
        public TLTextPlain()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLTextPlain(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb6, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.text = StreamingUtils.readTLString(stream);
        }

        public override int getClassId() => 
            0x744694e0;

        public virtual string getText() => 
            this.text;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb1, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLString(this.text, stream);
        }

        public override string toString() => 
            "textPlain#744694e0";
    }
}

