namespace org.telegram.api.input.privacy.inputprivacyrule
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLInputPrivacyValueDisallowContacts : TLAbsInputPrivacyRule
    {
        public const int CLASS_ID = 0xba52007;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xaf, 0x68 })]
        public TLInputPrivacyValueDisallowContacts()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLInputPrivacyValueDisallowContacts(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            0xba52007;

        public override string toString() => 
            "inputPrivacyValueDisallowContacts#ba52007";
    }
}

