namespace org.telegram.api.channel.participants.filters
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLChannelParticipantsFilterBots : TLAbsChannelParticipantsFilter
    {
        public const int CLASS_ID = -1328445861;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xac, 0x68 })]
        public TLChannelParticipantsFilterBots()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLChannelParticipantsFilterBots(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            -1328445861;

        public override string toString() => 
            "channel.participants.filters.TLChannelParticipantsBots#b0d1865b";
    }
}

