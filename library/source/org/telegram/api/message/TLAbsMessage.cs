namespace org.telegram.api.message
{
    using IKVM.Attributes;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public abstract class TLAbsMessage : TLObject
    {
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9c, 0x68 })]
        protected internal TLAbsMessage()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAbsMessage(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public abstract int getChatId();
    }
}

