namespace org.telegram.api.input.privacy.inputprivacykey
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLInputPrivacyKeyChatInvite : TLAbsInputPrivacyKey
    {
        public const int CLASS_ID = -1107622874;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xba, 0x68 })]
        public TLInputPrivacyKeyChatInvite()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLInputPrivacyKeyChatInvite(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            -1107622874;

        public override string toString() => 
            "inputPrivacyKeyChatInvite#bdfb0426";
    }
}

