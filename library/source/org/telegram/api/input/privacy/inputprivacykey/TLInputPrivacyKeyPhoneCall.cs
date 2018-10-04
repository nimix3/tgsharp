namespace org.telegram.api.input.privacy.inputprivacykey
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLInputPrivacyKeyPhoneCall : TLAbsInputPrivacyKey
    {
        public const int CLASS_ID = -88417185;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb3, 0x68 })]
        public TLInputPrivacyKeyPhoneCall()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLInputPrivacyKeyPhoneCall(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            -88417185;

        public override string toString() => 
            "inputPrivacyKeyPhoneCall#fabadc5f";
    }
}

