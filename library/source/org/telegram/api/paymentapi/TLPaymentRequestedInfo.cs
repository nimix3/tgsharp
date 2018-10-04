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
    public class TLPaymentRequestedInfo : TLObject
    {
        public const int CLASS_ID = -1868808300;
        private string email;
        private const int FLAG_EMIAL = 4;
        private const int FLAG_NAME = 1;
        private const int FLAG_PHONE = 2;
        private const int FLAG_SHIPPING_ADDRESS = 8;
        private int flags;
        private string name;
        private string phone;
        private TLPostAddress shippingAddress;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xac, 0x68 })]
        public TLPaymentRequestedInfo()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLPaymentRequestedInfo(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x27, 0x6c, 0x68, 140, 0x68, 140, 0x68, 140, 0x68, 0x97 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            if (this.hasName())
            {
                this.name = StreamingUtils.readTLString(stream);
            }
            if (this.hasPhone())
            {
                this.phone = StreamingUtils.readTLString(stream);
            }
            if (this.hasEmail())
            {
                this.email = StreamingUtils.readTLString(stream);
            }
            if (this.hasShippingAddress())
            {
                this.shippingAddress = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLPostAddress>.Value);
            }
        }

        public override int getClassId() => 
            -1868808300;

        public virtual string getEmail() => 
            this.email;

        public virtual string getName() => 
            this.name;

        public virtual string getPhone() => 
            this.phone;

        public virtual TLPostAddress getShippingAddress() => 
            this.shippingAddress;

        public virtual bool hasEmail() => 
            ((this.flags & 4) != 0);

        public virtual bool hasName() => 
            ((this.flags & 1) != 0);

        public virtual bool hasPhone() => 
            ((this.flags & 2) != 0);

        public virtual bool hasShippingAddress() => 
            ((this.flags & 8) != 0);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x16, 0x6c, 0x68, 140, 0x68, 140, 0x68, 140, 0x68, 0x8e })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            if (this.hasName())
            {
                StreamingUtils.writeTLString(this.name, stream);
            }
            if (this.hasPhone())
            {
                StreamingUtils.writeTLString(this.phone, stream);
            }
            if (this.hasEmail())
            {
                StreamingUtils.writeTLString(this.email, stream);
            }
            if (this.hasShippingAddress())
            {
                StreamingUtils.writeTLObject(this.shippingAddress, stream);
            }
        }

        public override string toString() => 
            "paymentRequestedInfo#909c3f94";
    }
}

