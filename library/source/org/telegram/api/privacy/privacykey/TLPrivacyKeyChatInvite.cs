namespace org.telegram.api.privacy.privacykey
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLPrivacyKeyChatInvite : TLAbsPrivacyKey
    {
        public const int CLASS_ID = 0x500e6dfa;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xba, 0x68 })]
        public TLPrivacyKeyChatInvite()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLPrivacyKeyChatInvite(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            0x500e6dfa;

        public override string toString() => 
            "privacy.privacyKeyChatInvite#500e6dfa";
    }
}

