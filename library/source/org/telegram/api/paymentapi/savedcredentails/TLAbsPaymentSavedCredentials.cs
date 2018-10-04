namespace org.telegram.api.paymentapi.savedcredentails
{
    using IKVM.Attributes;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public abstract class TLAbsPaymentSavedCredentials : TLObject
    {
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(9)]
        public TLAbsPaymentSavedCredentials()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAbsPaymentSavedCredentials(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }
    }
}

