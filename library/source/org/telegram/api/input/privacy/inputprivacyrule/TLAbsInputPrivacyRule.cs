namespace org.telegram.api.input.privacy.inputprivacyrule
{
    using IKVM.Attributes;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public abstract class TLAbsInputPrivacyRule : TLObject
    {
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb8, 0x68 })]
        protected internal TLAbsInputPrivacyRule()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAbsInputPrivacyRule(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }
    }
}

