namespace org.telegram.api.phone.call.discardreason
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLPhoneCallDiscardReasonBusy : TLAbsPhoneCallDiscardReason
    {
        public const int CLASS_ID = -84416311;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9b, 0x68 })]
        public TLPhoneCallDiscardReasonBusy()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLPhoneCallDiscardReasonBusy(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            -84416311;

        public override string toString() => 
            "phoneCallDiscardReasonBusy#faf7e8c9";
    }
}

