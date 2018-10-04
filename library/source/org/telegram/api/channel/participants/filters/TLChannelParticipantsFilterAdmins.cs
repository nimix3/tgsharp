namespace org.telegram.api.channel.participants.filters
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLChannelParticipantsFilterAdmins : TLAbsChannelParticipantsFilter
    {
        public const int CLASS_ID = -1268741783;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9b, 0x68 })]
        public TLChannelParticipantsFilterAdmins()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLChannelParticipantsFilterAdmins(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            -1268741783;

        public override string toString() => 
            "channel.participants.filters.TLChannelParticipantsAdmins#b4608969";
    }
}

