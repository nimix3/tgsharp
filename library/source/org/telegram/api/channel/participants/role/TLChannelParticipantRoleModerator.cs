namespace org.telegram.api.channel.participants.role
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLChannelParticipantRoleModerator : TLAbsChannelParticipantRole
    {
        public const int CLASS_ID = -1776756363;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9b, 0x68 })]
        public TLChannelParticipantRoleModerator()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLChannelParticipantRoleModerator(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            -1776756363;

        public override string toString() => 
            "channel.participants.filters.TLChannelParticipantRoleModerator#9618d975";
    }
}

