namespace org.telegram.api.input.privacy.inputprivacykey
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLInputPrivacyKeyStatusTimestamp : TLAbsInputPrivacyKey
    {
        public const int CLASS_ID = 0x4f96cb18;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xba, 0x68 })]
        public TLInputPrivacyKeyStatusTimestamp()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLInputPrivacyKeyStatusTimestamp(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            0x4f96cb18;

        public override string toString() => 
            "inputPrivacyKeyStatusTimestamp#4f96cb18";
    }
}

