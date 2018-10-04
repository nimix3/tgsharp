namespace org.telegram.api.paymentapi
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
    public class TLInvoice : TLObject
    {
        public const int CLASS_ID = -1022713000;
        private string currency;
        private const int FLAG_EMAIL_REQUESTED = 8;
        private const int FLAG_FLEXIBLE = 0x20;
        private const int FLAG_NAME_REQUESTED = 2;
        private const int FLAG_PHONE_REQUESTED = 4;
        private const int FLAG_SHIPPING_ADDRESS_REQUESTED = 0x10;
        private const int FLAG_TEST = 1;
        private int flags;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/paymentapi/TLLabeledPrice;>;")]
        private TLVector prices;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xad, 0x68 })]
        public TLInvoice()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLInvoice(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 30, 0x6c, 0x6c, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.currency = StreamingUtils.readTLString(stream);
            this.prices = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLLabeledPrice>.Value);
        }

        public override int getClassId() => 
            -1022713000;

        public virtual string getCurrency() => 
            this.currency;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/paymentapi/TLLabeledPrice;>;")]
        public virtual TLVector getPrices() => 
            this.prices;

        public virtual bool isEmailRequested() => 
            ((this.flags & 8) != 0);

        public virtual bool isFlexible() => 
            ((this.flags & 0x20) != 0);

        public virtual bool isNameRequested() => 
            ((this.flags & 2) != 0);

        public virtual bool isPhoneRequested() => 
            ((this.flags & 4) != 0);

        public virtual bool isShippingAddressRequeted() => 
            ((this.flags & 0x10) != 0);

        public virtual bool isTest() => 
            ((this.flags & 1) != 0);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x17, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeTLString(this.currency, stream);
            StreamingUtils.writeTLVector(this.prices, stream);
        }

        public override string toString() => 
            "invoice#c30aa358";
    }
}

