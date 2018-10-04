namespace org.telegram.api.input.privacy.inputprivacyrule
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLInputPrivacyValueAllowAll : TLAbsInputPrivacyRule
    {
        public const int CLASS_ID = 0x184b35ce;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xaf, 0x68 })]
        public TLInputPrivacyValueAllowAll()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLInputPrivacyValueAllowAll(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            0x184b35ce;

        public override string toString() => 
            "inputPrivacyValueAllowAll#184b35ce";
    }
}

