namespace org.telegram.api.channel.participants.role
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLChannelParticipantRoleEmpty : TLAbsChannelParticipantRole
    {
        public const int CLASS_ID = -1299865402;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9b, 0x68 })]
        public TLChannelParticipantRoleEmpty()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLChannelParticipantRoleEmpty(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            -1299865402;

        public override string toString() => 
            "channel.participants.filters.TLChannelParticipantRoleEmpty#b285a0c6";
    }
}

