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
    public class TLShippingOption : TLObject
    {
        public const int CLASS_ID = -1239335713;
        private string id;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/paymentapi/TLLabeledPrice;>;")]
        private TLVector prices;
        private string title;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa6, 0x68 })]
        public TLShippingOption()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLShippingOption(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 15, 0x6c, 0x6c, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.id = StreamingUtils.readTLString(stream);
            this.title = StreamingUtils.readTLString(stream);
            this.prices = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLLabeledPrice>.Value);
        }

        public override int getClassId() => 
            -1239335713;

        public virtual string getId() => 
            this.id;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/paymentapi/TLLabeledPrice;>;")]
        public virtual TLVector getPrices() => 
            this.prices;

        public virtual string getTitle() => 
            this.title;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 8, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLString(this.id, stream);
            StreamingUtils.writeTLString(this.title, stream);
            StreamingUtils.writeTLVector(this.prices, stream);
        }

        public virtual void setId(string id)
        {
            this.id = id;
        }

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/paymentapi/TLLabeledPrice;>;)V")]
        public virtual void setPrices(TLVector prices)
        {
            this.prices = prices;
        }

        public virtual void setTitle(string title)
        {
            this.title = title;
        }

        public override string toString() => 
            "shippingOption#b6213cdf";
    }
}

