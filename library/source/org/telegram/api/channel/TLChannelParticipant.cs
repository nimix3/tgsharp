namespace org.telegram.api.channel
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.api.channel.participants;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLChannelParticipant : TLObject
    {
        public const int CLASS_ID = -791039645;
        private TLAbsChannelParticipant participant;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLAbsUser;>;")]
        private TLVector users;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa9, 0x68 })]
        public TLChannelParticipant()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLChannelParticipant(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 9, 0x72, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.participant = StreamingUtils.readTLObject(stream, context);
            this.users = StreamingUtils.readTLVector(stream, context);
        }

        public override int getClassId() => 
            -791039645;

        public virtual TLAbsChannelParticipant getParticipant() => 
            this.participant;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLAbsUser;>;")]
        public virtual TLVector getUsers() => 
            this.users;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 3, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.participant, stream);
            StreamingUtils.writeTLVector(this.users, stream);
        }

        public virtual void setParticipant(TLAbsChannelParticipant participant)
        {
            this.participant = participant;
        }

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLAbsUser;>;)V")]
        public virtual void setUsers(TLVector users)
        {
            this.users = users;
        }

        public override string toString() => 
            "channel.TLChannelParticipant#d0d9b163";
    }
}

