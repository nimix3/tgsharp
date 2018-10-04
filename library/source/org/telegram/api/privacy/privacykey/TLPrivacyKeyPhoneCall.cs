namespace org.telegram.api.privacy.privacykey
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLPrivacyKeyPhoneCall : TLAbsPrivacyKey
    {
        public const int CLASS_ID = 0x3d662b7b;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb3, 0x68 })]
        public TLPrivacyKeyPhoneCall()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLPrivacyKeyPhoneCall(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            0x3d662b7b;

        public override string toString() => 
            "privacyKeyPhoneCall#3d662b7b";
    }
}

