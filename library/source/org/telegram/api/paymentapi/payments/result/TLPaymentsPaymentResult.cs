namespace org.telegram.api.paymentapi.payments.result
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using org.telegram.api.updates;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLPaymentsPaymentResult : TLAbsPaymentsPaymentResult
    {
        public const int CLASS_ID = 0x4e5f810d;
        private TLAbsUpdates updates;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa3, 0x68 })]
        public TLPaymentsPaymentResult()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLPaymentsPaymentResult(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb6, 0x77 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.updates = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLAbsUpdates>.Value);
        }

        public override int getClassId() => 
            0x4e5f810d;

        public virtual TLAbsUpdates getUpdates() => 
            this.updates;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb1, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.updates, stream);
        }

        public override string toString() => 
            "payments.paymentResult#4e5f810d";
    }
}

