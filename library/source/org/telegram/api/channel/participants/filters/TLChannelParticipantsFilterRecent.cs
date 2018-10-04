namespace org.telegram.api.channel.participants.filters
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLChannelParticipantsFilterRecent : TLAbsChannelParticipantsFilter
    {
        public const int CLASS_ID = -566281095;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9b, 0x68 })]
        public TLChannelParticipantsFilterRecent()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLChannelParticipantsFilterRecent(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            -566281095;

        public override string toString() => 
            "channel.participants.filters.TLChannelParticipantsRecent#de3f3c79";
    }
}

