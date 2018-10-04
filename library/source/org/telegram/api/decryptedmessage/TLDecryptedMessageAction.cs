namespace org.telegram.api.decryptedmessage
{
    using IKVM.Attributes;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public abstract class TLDecryptedMessageAction : TLObject
    {
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(8)]
        public TLDecryptedMessageAction()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLDecryptedMessageAction(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }
    }
}

