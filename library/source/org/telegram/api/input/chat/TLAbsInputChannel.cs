namespace org.telegram.api.input.chat
{
    using IKVM.Attributes;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public abstract class TLAbsInputChannel : TLObject
    {
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(11)]
        public TLAbsInputChannel()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAbsInputChannel(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public abstract int getChannelId();
    }
}

