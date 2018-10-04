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
    public class TLChannelParticipant : TLAbsChannelParticipant
    {
        public const int CLASS_ID = 0x15ebac1d;
        private int date;
        private int userId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa5, 0x68 })]
        public TLChannelParticipant()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLChannelParticipant(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 5, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.userId = StreamingUtils.readInt(stream);
            this.date = StreamingUtils.readInt(stream);
        }

        public override int getClassId() => 
            0x15ebac1d;

        public virtual int getDate() => 
            this.date;

        public virtual int getUserId() => 
            this.userId;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xbf, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.userId, stream);
            StreamingUtils.writeInt(this.date, stream);
        }

        public virtual void setDate(int date)
        {
            this.date = date;
        }

        public virtual void setUserId(int userId)
        {
            this.userId = userId;
        }

        public override string toString() => 
            "channel.participants.TLChannelParticipant#15ebac1d";
    }
}

