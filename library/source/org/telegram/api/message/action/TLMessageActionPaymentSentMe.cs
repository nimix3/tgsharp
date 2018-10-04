namespace org.telegram.api.message.action
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using org.telegram.api.paymentapi;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLMessageActionPaymentSentMe : TLAbsMessageAction
    {
        private TLPaymentCharge charge;
        public const int CLASS_ID = -1892568281;
        private string currency;
        private const int FLAG_INFO = 1;
        private const int FLAG_SHIPPING_OPTION_ID = 2;
        private int flags;
        private TLPaymentRequestedInfo info;
        private TLBytes payload;
        private string shippingOptionId;
        private long totalAmount;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xac, 0x68 })]
        public TLMessageActionPaymentSentMe()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLMessageActionPaymentSentMe(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x25, 0x6c, 0x6c, 0x6c, 0x6d, 0x6a, 0x97, 0x6a, 140, 0x77 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.currency = StreamingUtils.readTLString(stream);
            this.totalAmount = StreamingUtils.readLong(stream);
            this.payload = StreamingUtils.readTLBytes(stream, context);
            if ((this.flags & 1) != 0)
            {
                this.info = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLPaymentRequestedInfo>.Value);
            }
            if ((this.flags & 2) != 0)
            {
                this.shippingOptionId = StreamingUtils.readTLString(stream);
            }
            this.charge = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLPaymentCharge>.Value);
        }

        public virtual TLPaymentCharge getCharge() => 
            this.charge;

        public override int getClassId() => 
            -1892568281;

        public virtual string getCurrency() => 
            this.currency;

        public virtual TLPaymentRequestedInfo getInfo() => 
            this.info;

        public virtual TLBytes getPayload() => 
            this.payload;

        public virtual string getShippingOptionId() => 
            this.shippingOptionId;

        public virtual long getTotalAmount() => 
            this.totalAmount;

        public virtual bool hasInfo() => 
            ((this.flags & 1) != 0);

        public virtual bool hasShippingOption() => 
            ((this.flags & 2) != 0);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x16, 0x6c, 0x6c, 0x6c, 0x6c, 0x6a, 140, 0x6a, 140, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeTLString(this.currency, stream);
            StreamingUtils.writeLong(this.totalAmount, stream);
            StreamingUtils.writeTLBytes(this.payload, stream);
            if ((this.flags & 1) != 0)
            {
                StreamingUtils.writeTLObject(this.info, stream);
            }
            if ((this.flags & 2) != 0)
            {
                StreamingUtils.writeTLString(this.shippingOptionId, stream);
            }
            StreamingUtils.writeTLObject(this.charge, stream);
        }

        public override string toString() => 
            "messageActionPaymentSentMe#8f31b327";
    }
}

