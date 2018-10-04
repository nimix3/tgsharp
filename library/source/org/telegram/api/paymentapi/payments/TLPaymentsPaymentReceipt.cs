namespace org.telegram.api.paymentapi.payments
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
    public class TLPaymentsPaymentReceipt : TLObject
    {
        private int botId;
        public const int CLASS_ID = 0x500911e1;
        private string credentialsTitle;
        private string currency;
        private int date;
        private const int FLAG_INFO = 1;
        private const int FLAG_SHIPPING_OPTIONS = 2;
        private int flags;
        private TLPaymentRequestedInfo info;
        private TLInvoice invoice;
        private int providerId;
        private TLShippingOption shipping;
        private long totalAmount;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLAbsUser;>;")]
        private TLVector users;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb5, 0x68 })]
        public TLPaymentsPaymentReceipt()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLPaymentsPaymentReceipt(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x42, 0x6c, 0x6c, 0x6c, 0x77, 0x6c, 0x68, 0x97, 0x68, 0x97, 0x6c, 0x6c, 0x6c, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.date = StreamingUtils.readInt(stream);
            this.botId = StreamingUtils.readInt(stream);
            this.invoice = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLInvoice>.Value);
            this.providerId = StreamingUtils.readInt(stream);
            if (this.hasInfo())
            {
                this.info = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLPaymentRequestedInfo>.Value);
            }
            if (this.hasShippingInfo())
            {
                this.shipping = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLShippingOption>.Value);
            }
            this.currency = StreamingUtils.readTLString(stream);
            this.totalAmount = StreamingUtils.readLong(stream);
            this.credentialsTitle = StreamingUtils.readTLString(stream);
            this.users = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLAbsUser>.Value);
        }

        public virtual int getBotId() => 
            this.botId;

        public override int getClassId() => 
            0x500911e1;

        public virtual string getCredentialsTitle() => 
            this.credentialsTitle;

        public virtual string getCurrency() => 
            this.currency;

        public virtual int getDate() => 
            this.date;

        public virtual TLPaymentRequestedInfo getInfo() => 
            this.info;

        public virtual TLInvoice getInvoice() => 
            this.invoice;

        public virtual int getProviderId() => 
            this.providerId;

        public virtual TLShippingOption getShipping() => 
            this.shipping;

        public virtual long getTotalAmount() => 
            this.totalAmount;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLAbsUser;>;")]
        public virtual TLVector getUsers() => 
            this.users;

        public virtual bool hasInfo() => 
            ((this.flags & 1) != 0);

        public virtual bool hasShippingInfo() => 
            ((this.flags & 2) != 0);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x2f, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x68, 140, 0x68, 140, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeInt(this.date, stream);
            StreamingUtils.writeInt(this.botId, stream);
            StreamingUtils.writeTLObject(this.invoice, stream);
            StreamingUtils.writeInt(this.providerId, stream);
            if (this.hasInfo())
            {
                StreamingUtils.writeTLObject(this.info, stream);
            }
            if (this.hasShippingInfo())
            {
                StreamingUtils.writeTLObject(this.shipping, stream);
            }
            StreamingUtils.writeTLString(this.currency, stream);
            StreamingUtils.writeLong(this.totalAmount, stream);
            StreamingUtils.writeTLString(this.credentialsTitle, stream);
            StreamingUtils.writeTLVector(this.users, stream);
        }

        public override string toString() => 
            "payments.paymentReceipt#500911e1";
    }
}

