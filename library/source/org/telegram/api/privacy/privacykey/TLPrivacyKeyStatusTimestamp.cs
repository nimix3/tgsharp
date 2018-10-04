namespace org.telegram.api.privacy.privacykey
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLPrivacyKeyStatusTimestamp : TLAbsPrivacyKey
    {
        public const int CLASS_ID = -1137792208;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xba, 0x68 })]
        public TLPrivacyKeyStatusTimestamp()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLPrivacyKeyStatusTimestamp(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            -1137792208;

        public override string toString() => 
            "privacy.privacyKeyStatusTimestamp#bc2eab30";
    }
}

