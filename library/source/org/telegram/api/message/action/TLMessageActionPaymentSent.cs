namespace org.telegram.api.message.action
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLMessageActionPaymentSent : TLAbsMessageAction
    {
        public const int CLASS_ID = 0x40699cd0;
        private string currency;
        private long totalAmount;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa3, 0x68 })]
        public TLMessageActionPaymentSent()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLMessageActionPaymentSent(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xbb, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.currency = StreamingUtils.readTLString(stream);
            this.totalAmount = StreamingUtils.readLong(stream);
        }

        public override int getClassId() => 
            0x40699cd0;

        public virtual string getCurrency() => 
            this.currency;

        public virtual long getTotalAmount() => 
            this.totalAmount;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb5, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLString(this.currency, stream);
            StreamingUtils.writeLong(this.totalAmount, stream);
        }

        public override string toString() => 
            "messageActionPaymentSent#40699cd0";
    }
}

