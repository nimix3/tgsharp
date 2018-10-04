namespace org.telegram.api.messages
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLMessagesHighScores : TLObject
    {
        public const int CLASS_ID = -1707344487;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/TLHighScore;>;")]
        private TLVector scores;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLAbsUser;>;")]
        private TLVector users;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa9, 0x68 })]
        public TLMessagesHighScores()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLMessagesHighScores(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 1, 0x72, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.scores = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLHighScore>.Value);
            this.users = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLAbsUser>.Value);
        }

        public override int getClassId() => 
            -1707344487;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/TLHighScore;>;")]
        public virtual TLVector getScores() => 
            this.scores;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLAbsUser;>;")]
        public virtual TLVector getUsers() => 
            this.users;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xbb, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLVector(this.scores, stream);
            StreamingUtils.writeTLVector(this.users, stream);
        }

        public override string toString() => 
            "messages.highScores#9a3bfd99";
    }
}

