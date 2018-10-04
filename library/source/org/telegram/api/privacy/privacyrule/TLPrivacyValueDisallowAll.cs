namespace org.telegram.api.privacy.privacyrule
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLPrivacyValueDisallowAll : TLAbsPrivacyRule
    {
        public const int CLASS_ID = -1955338397;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xba, 0x68 })]
        public TLPrivacyValueDisallowAll()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLPrivacyValueDisallowAll(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            -1955338397;

        public override string toString() => 
            "privacy.privacyValueDisallowAll#8b73e763";
    }
}

