namespace org.telegram.api.help
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLTermsOfService : TLObject
    {
        public const int CLASS_ID = -236044656;
        private string text;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb9, 0x68 })]
        public TLTermsOfService()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLTermsOfService(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 15, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.text = StreamingUtils.readTLString(stream);
        }

        public override int getClassId() => 
            -236044656;

        public virtual string getText() => 
            this.text;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 10, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLString(this.text, stream);
        }

        public virtual void setText(string text)
        {
            this.text = text;
        }

        public override string toString() => 
            "help.termsOfService#f1ee3e90";
    }
}

