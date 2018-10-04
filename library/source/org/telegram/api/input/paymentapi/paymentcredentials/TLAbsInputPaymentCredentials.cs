namespace org.telegram.api.input.paymentapi.paymentcredentials
{
    using IKVM.Attributes;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public abstract class TLAbsInputPaymentCredentials : TLObject
    {
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(9)]
        public TLAbsInputPaymentCredentials()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAbsInputPaymentCredentials(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }
    }
}

