namespace org.telegram.api.channel.participants.filters
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLChannelParticipantsFilterKicked : TLAbsChannelParticipantsFilter
    {
        public const int CLASS_ID = 0x3c37bb7a;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9b, 0x68 })]
        public TLChannelParticipantsFilterKicked()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLChannelParticipantsFilterKicked(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            0x3c37bb7a;

        public override string toString() => 
            "channel.participants.filters.TLChannelParticipantsKicked#3c37bb7a";
    }
}

