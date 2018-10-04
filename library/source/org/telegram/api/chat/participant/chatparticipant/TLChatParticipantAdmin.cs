namespace org.telegram.api.chat.participant.chatparticipant
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLChatParticipantAdmin : TLAbsChatParticipant
    {
        public const int CLASS_ID = -489233354;
        private int date;
        private int inviterId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 3, 0x68 })]
        public TLChatParticipantAdmin()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLChatParticipantAdmin(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x39, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            base.userId = StreamingUtils.readInt(stream);
            this.inviterId = StreamingUtils.readInt(stream);
            this.date = StreamingUtils.readInt(stream);
        }

        public override int getClassId() => 
            -489233354;

        public virtual int getDate() => 
            this.date;

        public virtual int getInviterId() => 
            this.inviterId;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x31, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(base.userId, stream);
            StreamingUtils.writeInt(this.inviterId, stream);
            StreamingUtils.writeInt(this.date, stream);
        }

        public virtual void setDate(int value)
        {
            this.date = value;
        }

        public virtual void setInviterId(int value)
        {
            this.inviterId = value;
        }

        public override string toString() => 
            "chatParticipantAdmin#e2d6e436";
    }
}

