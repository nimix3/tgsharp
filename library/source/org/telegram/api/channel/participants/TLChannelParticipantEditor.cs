namespace org.telegram.api.channel.participants
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLChannelParticipantEditor : TLAbsChannelParticipant
    {
        public const int CLASS_ID = -1743180447;
        private int date;
        private int inviterId;
        private int userId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa6, 0x68 })]
        public TLChannelParticipantEditor()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLChannelParticipantEditor(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 15, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.userId = StreamingUtils.readInt(stream);
            this.inviterId = StreamingUtils.readInt(stream);
            this.date = StreamingUtils.readInt(stream);
        }

        public override int getClassId() => 
            -1743180447;

        public virtual int getDate() => 
            this.date;

        public virtual int getInviterId() => 
            this.inviterId;

        public virtual int getUserId() => 
            this.userId;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 8, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.userId, stream);
            StreamingUtils.writeInt(this.inviterId, stream);
            StreamingUtils.writeInt(this.date, stream);
        }

        public virtual void setDate(int date)
        {
            this.date = date;
        }

        public virtual void setInviterId(int inviterId)
        {
            this.inviterId = inviterId;
        }

        public virtual void setUserId(int userId)
        {
            this.userId = userId;
        }

        public override string toString() => 
            "channel.participants.TLChannelParticipantEditor#98192d61";
    }
}

