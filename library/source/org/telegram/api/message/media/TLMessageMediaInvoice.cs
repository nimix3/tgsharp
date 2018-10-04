namespace org.telegram.api.message.media
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using org.telegram.api.input.media;
    using org.telegram.api.paymentapi;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLMessageMediaInvoice : TLAbsInputMedia
    {
        public const int CLASS_ID = -2074799289;
        private string currency;
        private string description;
        private const int FLAG_PHOTO = 1;
        private const int FLAG_RECEIPT_MSG_ID = 4;
        private const int FLAG_SHIPPING_ADDRESS_REQUEST = 2;
        private const int FLAG_TEST = 8;
        private int flags;
        private TLWebDocument photo;
        private int receiptMsgId;
        private string startParam;
        private string title;
        private string totalAmount;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xac, 0x68 })]
        public TLMessageMediaInvoice()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLMessageMediaInvoice(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x34, 0x6c, 0x6c, 0x6c, 0x6a, 0x97, 0x6a, 140, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.title = StreamingUtils.readTLString(stream);
            this.description = StreamingUtils.readTLString(stream);
            if ((this.flags & 1) != 0)
            {
                this.photo = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLWebDocument>.Value);
            }
            if ((this.flags & 4) != 0)
            {
                this.receiptMsgId = StreamingUtils.readInt(stream);
            }
            this.currency = StreamingUtils.readTLString(stream);
            this.totalAmount = StreamingUtils.readTLString(stream);
            this.startParam = StreamingUtils.readTLString(stream);
        }

        public override int getClassId() => 
            -2074799289;

        public virtual string getCurrency() => 
            this.currency;

        public virtual string getDescription() => 
            this.description;

        public virtual TLWebDocument getPhoto() => 
            this.photo;

        public virtual int getReceiptMsgId() => 
            this.receiptMsgId;

        public virtual string getStartParam() => 
            this.startParam;

        public virtual string getTitle() => 
            this.title;

        public virtual string getTotalAmount() => 
            this.totalAmount;

        public virtual bool hasPhoto() => 
            ((this.flags & 1) != 0);

        public virtual bool hasReceiptMsgId() => 
            ((this.flags & 4) != 0);

        public virtual bool hasShippingAddressRequested() => 
            ((this.flags & 2) != 0);

        public virtual bool isTest() => 
            ((this.flags & 8) != 0);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x24, 0x6c, 0x6c, 0x6c, 0x6a, 140, 0x6a, 140, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeTLString(this.title, stream);
            StreamingUtils.writeTLString(this.description, stream);
            if ((this.flags & 1) != 0)
            {
                StreamingUtils.writeTLObject(this.photo, stream);
            }
            if ((this.flags & 4) != 0)
            {
                StreamingUtils.writeInt(this.receiptMsgId, stream);
            }
            StreamingUtils.writeTLString(this.currency, stream);
            StreamingUtils.writeTLString(this.totalAmount, stream);
            StreamingUtils.writeTLString(this.startParam, stream);
        }

        public override string toString() => 
            "messageMediaInvoice#84551347";
    }
}

