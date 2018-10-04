namespace org.telegram.api.privacy.privacyrule
{
    using IKVM.Attributes;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public abstract class TLAbsPrivacyRule : TLObject
    {
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb7, 0x68 })]
        protected internal TLAbsPrivacyRule()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAbsPrivacyRule(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }
    }
}

