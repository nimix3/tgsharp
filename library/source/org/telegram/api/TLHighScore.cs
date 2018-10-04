namespace org.telegram.api
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLHighScore : TLObject
    {
        public const int CLASS_ID = 0x58fffcd0;
        private int pos;
        private int score;
        private int userId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x11)]
        public TLHighScore()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLHighScore(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.pos = StreamingUtils.readInt(stream);
            this.userId = StreamingUtils.readInt(stream);
            this.score = StreamingUtils.readInt(stream);
        }

        public override int getClassId() => 
            0x58fffcd0;

        public virtual int getPos() => 
            this.pos;

        public virtual int getScore() => 
            this.score;

        public virtual int getUserId() => 
            this.userId;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb9, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.pos, stream);
            StreamingUtils.writeInt(this.userId, stream);
            StreamingUtils.writeInt(this.score, stream);
        }

        public override string toString() => 
            "highScore#58fffcd0";
    }
}

