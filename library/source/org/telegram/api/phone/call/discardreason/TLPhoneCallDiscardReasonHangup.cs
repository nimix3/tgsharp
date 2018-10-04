namespace org.telegram.api.phone.call.discardreason
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLPhoneCallDiscardReasonHangup : TLAbsPhoneCallDiscardReason
    {
        public const int CLASS_ID = 0x57adc690;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9b, 0x68 })]
        public TLPhoneCallDiscardReasonHangup()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLPhoneCallDiscardReasonHangup(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            0x57adc690;

        public override string toString() => 
            "phoneCallDiscardReasonHangup#57adc690";
    }
}

