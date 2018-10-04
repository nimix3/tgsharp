namespace org.telegram.api.privacy.privacykey
{
    using IKVM.Attributes;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public abstract class TLAbsPrivacyKey : TLObject
    {
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x24)]
        public TLAbsPrivacyKey()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAbsPrivacyKey(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }
    }
}

