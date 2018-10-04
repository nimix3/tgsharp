namespace org.telegram.api.chat.participant.chatparticipants
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.api.chat.participant.chatparticipant;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLChatParticipantsForbidden : TLAbsChatParticipants
    {
        public const int CLASS_ID = -57668565;
        private const int FLAG_SELF = 1;
        private int flags;
        private TLAbsChatParticipant selfParticipant;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 6, 0x68 })]
        public TLChatParticipantsForbidden()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLChatParticipantsForbidden(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x2b, 0x6c, 0x6c, 0x6a, 0x92 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            base.chatId = StreamingUtils.readInt(stream);
            if ((this.flags & 1) != 0)
            {
                this.selfParticipant = StreamingUtils.readTLObject(stream, context);
            }
        }

        public override int getClassId() => 
            -57668565;

        public virtual int getFlags() => 
            this.flags;

        public virtual TLAbsChatParticipant getSelfParticipant() => 
            this.selfParticipant;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x21, 0x6c, 0x6c, 0x6a, 0x8e })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeInt(base.chatId, stream);
            if ((this.flags & 1) != 0)
            {
                StreamingUtils.writeTLObject(this.selfParticipant, stream);
            }
        }

        public virtual void setFlags(int flags)
        {
            this.flags = flags;
        }

        public virtual void setSelfParticipant(TLAbsChatParticipant selfParticipant)
        {
            this.selfParticipant = selfParticipant;
        }

        public override string toString() => 
            "chatParticipantsForbidden#fc900c2b";
    }
}

