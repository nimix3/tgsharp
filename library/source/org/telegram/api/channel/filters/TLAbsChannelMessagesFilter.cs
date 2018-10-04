namespace org.telegram.api.channel.filters
{
    using IKVM.Attributes;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public abstract class TLAbsChannelMessagesFilter : TLObject
    {
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(11)]
        public TLAbsChannelMessagesFilter()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAbsChannelMessagesFilter(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }
    }
}

