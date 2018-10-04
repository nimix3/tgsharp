namespace org.telegram.api.channel.participants.filters
{
    using IKVM.Attributes;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public abstract class TLAbsChannelParticipantsFilter : TLObject
    {
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9b, 0x68 })]
        public TLAbsChannelParticipantsFilter()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAbsChannelParticipantsFilter(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }
    }
}

