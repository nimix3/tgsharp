namespace org.telegram.api.input.privacy.inputprivacyrule
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLInputPrivacyValueDisallowAll : TLAbsInputPrivacyRule
    {
        public const int CLASS_ID = -697604407;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xaf, 0x68 })]
        public TLInputPrivacyValueDisallowAll()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLInputPrivacyValueDisallowAll(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            -697604407;

        public override string toString() => 
            "inputPrivacyValueDisallowAll#d66b66c9";
    }
}

