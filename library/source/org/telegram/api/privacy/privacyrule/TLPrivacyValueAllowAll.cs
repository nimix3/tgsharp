namespace org.telegram.api.privacy.privacyrule
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLPrivacyValueAllowAll : TLAbsPrivacyRule
    {
        public const int CLASS_ID = 0x65427b82;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xba, 0x68 })]
        public TLPrivacyValueAllowAll()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLPrivacyValueAllowAll(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            0x65427b82;

        public override string toString() => 
            "privacy.privacyValueAllowAll#65427b82";
    }
}

