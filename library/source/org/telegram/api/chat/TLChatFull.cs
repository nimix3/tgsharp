namespace org.telegram.api.chat
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
    public class TLChatFull : TLAbsChatFull
    {
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/bot/TLBotInfo;>;")]
        private TLVector botInfo;
        public const int CLASS_ID = 0x2e02a614;
        private TLAbsChatParticipants participants;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb9, 0xe8, 0x3a, 0xeb, 0x47 })]
        public TLChatFull()
        {
            this.botInfo = new TLVector();
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLChatFull(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 30, 0x6c, 0x72, 0x72, 0x72, 0x72, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            base.id = StreamingUtils.readInt(stream);
            this.participants = StreamingUtils.readTLObject(stream, context);
            base.photo = StreamingUtils.readTLObject(stream, context);
            base.notifySettings = StreamingUtils.readTLObject(stream, context);
            base.exportedInvite = StreamingUtils.readTLObject(stream, context);
            this.botInfo = StreamingUtils.readTLVector(stream, context);
        }

        public override int getClassId() => 
            0x2e02a614;

        public virtual TLAbsChatParticipants getParticipants() => 
            this.participants;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 20, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(base.id, stream);
            StreamingUtils.writeTLObject(this.participants, stream);
            StreamingUtils.writeTLObject(base.photo, stream);
            StreamingUtils.writeTLObject(base.notifySettings, stream);
            StreamingUtils.writeTLObject(base.exportedInvite, stream);
            StreamingUtils.writeTLVector(this.botInfo, stream);
        }

        public virtual void setParticipants(TLAbsChatParticipants value)
        {
            this.participants = value;
        }

        public override string toString() => 
            "chatFull#2e02a614";
    }
}

