namespace org.telegram.api.update
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.api.chat.participant.chatparticipants;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLUpdateChatParticipants : TLAbsUpdate
    {
        public const int CLASS_ID = 0x7761198;
        private TLAbsChatParticipants participants;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa8, 0x68 })]
        public TLUpdateChatParticipants()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLUpdateChatParticipants(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 8, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.participants = StreamingUtils.readTLObject(stream, context);
        }

        public override int getClassId() => 
            0x7761198;

        public virtual TLAbsChatParticipants getParticipants() => 
            this.participants;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 3, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.participants, stream);
        }

        public virtual void setParticipants(TLAbsChatParticipants participants)
        {
            this.participants = participants;
        }

        public override string toString() => 
            "updateChatParticipants#7761198";
    }
}

