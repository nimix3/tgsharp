namespace org.telegram.api.message.action
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLMessageActionGameScore : TLAbsMessageAction
    {
        public const int CLASS_ID = -1834538890;
        private long gameId;
        private int score;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa8, 0x68 })]
        public TLMessageActionGameScore()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLMessageActionGameScore(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 8, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.gameId = StreamingUtils.readLong(stream);
            this.score = StreamingUtils.readInt(stream);
        }

        public override int getClassId() => 
            -1834538890;

        public virtual long getGameId() => 
            this.gameId;

        public virtual int getScore() => 
            this.score;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 2, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeLong(this.gameId, stream);
            StreamingUtils.writeInt(this.score, stream);
        }

        public virtual void setGameId(long gameId)
        {
            this.gameId = gameId;
        }

        public virtual void setScore(int score)
        {
            this.score = score;
        }

        public override string toString() => 
            "messageActionGameScore#92a72876";
    }
}

