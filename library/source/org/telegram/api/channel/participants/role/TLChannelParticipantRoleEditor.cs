namespace org.telegram.api.channel.participants.role
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLChannelParticipantRoleEditor : TLAbsChannelParticipantRole
    {
        public const int CLASS_ID = -2113143156;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9b, 0x68 })]
        public TLChannelParticipantRoleEditor()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLChannelParticipantRoleEditor(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            -2113143156;

        public override string toString() => 
            "channel.participants.filters.TLChannelParticipantRoleEditor#820bfe8c";
    }
}

