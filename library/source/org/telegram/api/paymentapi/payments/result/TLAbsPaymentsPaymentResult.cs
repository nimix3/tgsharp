namespace org.telegram.api.paymentapi.payments.result
{
    using IKVM.Attributes;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public abstract class TLAbsPaymentsPaymentResult : TLObject
    {
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(9)]
        public TLAbsPaymentsPaymentResult()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAbsPaymentsPaymentResult(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }
    }
}

