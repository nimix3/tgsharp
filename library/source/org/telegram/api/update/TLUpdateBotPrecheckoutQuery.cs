namespace org.telegram.api.update
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
    public class TLUpdateBotPrecheckoutQuery : TLAbsUpdate
    {
        public const int CLASS_ID = 0x5d2f3aa9;
        private string currency;
        private const int FLAG_INFO = 1;
        private const int FLAG_SHIPPING_OPTION_ID = 2;
        private int flags;
        private TLPaymentRequestedInfo info;
        private TLBytes payload;
        private long queryId;
        private string shippingOptionId;
        private long totalAmount;
        private int userId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xbb, 0x68 })]
        public TLUpdateBotPrecheckoutQuery()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLUpdateBotPrecheckoutQuery(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x30, 0x6c, 0x6c, 0x6c, 0x6d, 0x6a, 0x97, 0x6a, 140, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.queryId = StreamingUtils.readLong(stream);
            this.userId = StreamingUtils.readInt(stream);
            this.payload = StreamingUtils.readTLBytes(stream, context);
            if ((this.flags & 1) != 0)
            {
                this.info = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLPaymentRequestedInfo>.Value);
            }
            if ((this.flags & 2) != 0)
            {
                this.shippingOptionId = StreamingUtils.readTLString(stream);
            }
            this.currency = StreamingUtils.readTLString(stream);
            this.totalAmount = StreamingUtils.readLong(stream);
        }

        public override int getClassId() => 
            0x5d2f3aa9;

        public virtual string getCurrency() => 
            this.currency;

        public virtual TLPaymentRequestedInfo getInfo() => 
            this.info;

        public virtual TLBytes getPayload() => 
            this.payload;

        public virtual long getQueryId() => 
            this.queryId;

        public virtual string getShippingOptionId() => 
            this.shippingOptionId;

        public virtual long getTotalAmount() => 
            this.totalAmount;

        public virtual int getUserId() => 
            this.userId;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x20, 0x6c, 0x6c, 0x6c, 0x6c, 0x6a, 140, 0x6a, 140, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeLong(this.queryId, stream);
            StreamingUtils.writeInt(this.userId, stream);
            StreamingUtils.writeTLBytes(this.payload, stream);
            if ((this.flags & 1) != 0)
            {
                StreamingUtils.writeTLObject(this.info, stream);
            }
            if ((this.flags & 2) != 0)
            {
                StreamingUtils.writeTLString(this.shippingOptionId, stream);
            }
            StreamingUtils.writeTLString(this.currency, stream);
            StreamingUtils.writeLong(this.totalAmount, stream);
        }

        public override string toString() => 
            "updateBotPrecheckoutQuery#5d2f3aa9";
    }
}

