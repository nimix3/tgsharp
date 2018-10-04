namespace org.telegram.api.input.paymentapi.paymentcredentials
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLInputPaymentCredentialsSaved : TLAbsInputPaymentCredentials
    {
        public const int CLASS_ID = -1056001329;
        private string id;
        private TLBytes tmpPassword;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa4, 0x68 })]
        public TLInputPaymentCredentialsSaved()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLInputPaymentCredentialsSaved(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 4, 0x6c, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.id = StreamingUtils.readTLString(stream);
            this.tmpPassword = StreamingUtils.readTLBytes(stream, context);
        }

        public override int getClassId() => 
            -1056001329;

        public virtual string getId() => 
            this.id;

        public virtual TLBytes getTmpPassword() => 
            this.tmpPassword;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 190, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLString(this.id, stream);
            StreamingUtils.writeTLBytes(this.tmpPassword, stream);
        }

        public virtual void setId(string id)
        {
            this.id = id;
        }

        public virtual void setTmpPassword(TLBytes tmpPassword)
        {
            this.tmpPassword = tmpPassword;
        }

        public override string toString() => 
            "inputPaymentCredentialsSaved#c10eb2cf";
    }
}

