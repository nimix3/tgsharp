namespace org.telegram.api.input.privacy.inputprivacyrule
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLInputPrivacyValueAllowContacts : TLAbsInputPrivacyRule
    {
        public const int CLASS_ID = 0xd09e07b;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xaf, 0x68 })]
        public TLInputPrivacyValueAllowContacts()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLInputPrivacyValueAllowContacts(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            0xd09e07b;

        public override string toString() => 
            "inputPrivacyValueAllowContacts#d09e07b";
    }
}

