namespace org.telegram.api.input.privacy.inputprivacykey
{
    using IKVM.Attributes;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public abstract class TLAbsInputPrivacyKey : TLObject
    {
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x1d)]
        public TLAbsInputPrivacyKey()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAbsInputPrivacyKey(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }
    }
}

