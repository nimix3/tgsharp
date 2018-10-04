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
    public class TLChatParticipantCreator : TLAbsChatParticipant
    {
        public const int CLASS_ID = -636267638;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0, 0x68 })]
        public TLChatParticipantCreator()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLChatParticipantCreator(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x10, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            base.userId = StreamingUtils.readInt(stream);
        }

        public override int getClassId() => 
            -636267638;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 10, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(base.userId, stream);
        }

        public override string toString() => 
            "chatParticipantCreator#da13538a";
    }
}

