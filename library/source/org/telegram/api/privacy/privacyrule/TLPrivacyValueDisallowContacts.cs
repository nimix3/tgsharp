namespace org.telegram.api.privacy.privacyrule
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLPrivacyValueDisallowContacts : TLAbsPrivacyRule
    {
        public const int CLASS_ID = -125240806;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xba, 0x68 })]
        public TLPrivacyValueDisallowContacts()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLPrivacyValueDisallowContacts(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            -125240806;

        public override string toString() => 
            "privacy.privacyValueDisallowContacts#f888fa1a";
    }
}

