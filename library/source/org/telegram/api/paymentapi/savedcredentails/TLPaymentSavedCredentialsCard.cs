namespace org.telegram.api.paymentapi.savedcredentails
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLPaymentSavedCredentialsCard : TLAbsPaymentSavedCredentials
    {
        public const int CLASS_ID = -842892769;
        private string id;
        private string title;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(14)]
        public TLPaymentSavedCredentialsCard()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLPaymentSavedCredentialsCard(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb7, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.id = StreamingUtils.readTLString(stream);
            this.title = StreamingUtils.readTLString(stream);
        }

        public override int getClassId() => 
            -842892769;

        public virtual string getId() => 
            this.id;

        public virtual string getTitle() => 
            this.title;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb1, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLString(this.id, stream);
            StreamingUtils.writeTLString(this.title, stream);
        }

        public override string toString() => 
            "paymentSavedCredentialsCard#cdc27a1f";
    }
}

