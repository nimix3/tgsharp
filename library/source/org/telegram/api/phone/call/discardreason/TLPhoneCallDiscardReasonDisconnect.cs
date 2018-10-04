namespace org.telegram.api.phone.call.discardreason
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLPhoneCallDiscardReasonDisconnect : TLAbsPhoneCallDiscardReason
    {
        public const int CLASS_ID = -527056480;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9b, 0x68 })]
        public TLPhoneCallDiscardReasonDisconnect()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLPhoneCallDiscardReasonDisconnect(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            -527056480;

        public override string toString() => 
            "phoneCallDiscardReasonDisconnect#e095c1a0";
    }
}

