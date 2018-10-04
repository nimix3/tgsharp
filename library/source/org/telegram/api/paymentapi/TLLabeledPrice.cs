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
    public class TLLabeledPrice : TLObject
    {
        private long amount;
        public const int CLASS_ID = -886477832;
        private string label;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa4, 0x68 })]
        public TLLabeledPrice()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLLabeledPrice(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xbc, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.label = StreamingUtils.readTLString(stream);
            this.amount = StreamingUtils.readLong(stream);
        }

        public virtual long getAmount() => 
            this.amount;

        public override int getClassId() => 
            -886477832;

        public virtual string getLabel() => 
            this.label;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb6, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLString(this.label, stream);
            StreamingUtils.writeLong(this.amount, stream);
        }

        public override string toString() => 
            "labeledPrice#cb296bf8";
    }
}

