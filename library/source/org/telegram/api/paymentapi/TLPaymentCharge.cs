namespace org.telegram.api.paymentapi
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLPaymentCharge : TLObject
    {
        public const int CLASS_ID = -368917890;
        private string id;
        private string providerChargeId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(15)]
        public TLPaymentCharge()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLPaymentCharge(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb8, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.id = StreamingUtils.readTLString(stream);
            this.providerChargeId = StreamingUtils.readTLString(stream);
        }

        public override int getClassId() => 
            -368917890;

        public virtual string getId() => 
            this.id;

        public virtual string getProviderChargeId() => 
            this.providerChargeId;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb2, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLString(this.id, stream);
            StreamingUtils.writeTLString(this.providerChargeId, stream);
        }

        public override string toString() => 
            "paymentCharge#ea02c27e";
    }
}

