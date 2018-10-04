namespace org.telegram.api.chat.participant.chatparticipants
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLChatParticipants : TLAbsChatParticipants
    {
        public const int CLASS_ID = 0x3f460fed;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/chat/participant/chatparticipant/TLAbsChatParticipant;>;")]
        private TLVector participants;
        private int version;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 5, 0x68 })]
        public TLChatParticipants()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLChatParticipants(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 60, 0x6c, 0x6d, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            base.chatId = StreamingUtils.readInt(stream);
            this.participants = StreamingUtils.readTLVector(stream, context);
            this.version = StreamingUtils.readInt(stream);
        }

        public override int getClassId() => 
            0x3f460fed;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/chat/participant/chatparticipant/TLAbsChatParticipant;>;")]
        public virtual TLVector getParticipants() => 
            this.participants;

        public virtual int getVersion() => 
            this.version;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x34, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(base.chatId, stream);
            StreamingUtils.writeTLVector(this.participants, stream);
            StreamingUtils.writeInt(this.version, stream);
        }

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/chat/participant/chatparticipant/TLAbsChatParticipant;>;)V")]
        public virtual void setParticipants(TLVector participants)
        {
            this.participants = participants;
        }

        public virtual void setVersion(int version)
        {
            this.version = version;
        }

        public override string toString() => 
            "chatParticipants#3f460fed";
    }
}

