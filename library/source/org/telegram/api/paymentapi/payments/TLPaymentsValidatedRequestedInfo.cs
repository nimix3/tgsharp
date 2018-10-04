namespace org.telegram.api.paymentapi.payments
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
    public class TLPaymentsValidatedRequestedInfo : TLObject
    {
        public const int CLASS_ID = -784000893;
        private const int FLAG_ID = 1;
        private const int FLAG_SHIPPING_OPTIONS = 2;
        private int flags;
        private string id;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/paymentapi/TLShippingOption;>;")]
        private TLVector shippingOptions;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 170, 0x68 })]
        public TLPaymentsValidatedRequestedInfo()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLPaymentsValidatedRequestedInfo(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 15, 0x6c, 0x68, 140, 0x68, 0x92 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            if (this.hasId())
            {
                this.id = StreamingUtils.readTLString(stream);
            }
            if (this.hasShippingOptions())
            {
                this.shippingOptions = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLShippingOption>.Value);
            }
        }

        public override int getClassId() => 
            -784000893;

        public virtual string getId() => 
            this.id;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/paymentapi/TLShippingOption;>;")]
        public virtual TLVector getShippingOptions() => 
            this.shippingOptions;

        public virtual bool hasId() => 
            ((this.flags & 1) != 0);

        public virtual bool hasShippingOptions() => 
            ((this.flags & 2) != 0);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 4, 0x6c, 0x68, 140, 0x68, 0x8e })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            if (this.hasId())
            {
                StreamingUtils.writeTLString(this.id, stream);
            }
            if (this.hasShippingOptions())
            {
                StreamingUtils.writeTLVector(this.shippingOptions, stream);
            }
        }

        public override string toString() => 
            "payments.validatedRequestedInfo#d1451883";
    }
}

