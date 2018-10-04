namespace org.telegram.api.phone.call.discardreason
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLPhoneCallDiscardReasonMissed : TLAbsPhoneCallDiscardReason
    {
        public const int CLASS_ID = -2048646399;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9b, 0x68 })]
        public TLPhoneCallDiscardReasonMissed()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLPhoneCallDiscardReasonMissed(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            -2048646399;

        public override string toString() => 
            "phoneCallDiscardReasonMissed#85e42301";
    }
}

