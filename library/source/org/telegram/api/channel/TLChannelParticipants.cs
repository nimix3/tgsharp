namespace org.telegram.api.channel
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLChannelParticipants : TLObject
    {
        public const int CLASS_ID = -177282392;
        private int count;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/channel/participants/TLAbsChannelParticipant;>;")]
        private TLVector participants;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLAbsUser;>;")]
        private TLVector users;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 170, 0x68 })]
        public TLChannelParticipants()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLChannelParticipants(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x13, 0x6c, 0x6d, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.count = StreamingUtils.readInt(stream);
            this.participants = StreamingUtils.readTLVector(stream, context);
            this.users = StreamingUtils.readTLVector(stream, context);
        }

        public override int getClassId() => 
            -177282392;

        public virtual int getCount() => 
            this.count;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/channel/participants/TLAbsChannelParticipant;>;")]
        public virtual TLVector getParticipants() => 
            this.participants;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLAbsUser;>;")]
        public virtual TLVector getUsers() => 
            this.users;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 12, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.count, stream);
            StreamingUtils.writeTLVector(this.participants, stream);
            StreamingUtils.writeTLVector(this.users, stream);
        }

        public virtual void setCount(int count)
        {
            this.count = count;
        }

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/channel/participants/TLAbsChannelParticipant;>;)V")]
        public virtual void setParticipants(TLVector participants)
        {
            this.participants = participants;
        }

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLAbsUser;>;)V")]
        public virtual void setUsers(TLVector users)
        {
            this.users = users;
        }

        public override string toString() => 
            "channel.TLChannelParticipants#f56ee2a8";
    }
}

