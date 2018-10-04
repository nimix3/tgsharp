namespace org.telegram.api.message.media
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using org.telegram.api.game;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLMessageMediaGame : TLAbsMessageMedia
    {
        public const int CLASS_ID = -38694904;
        private TLGame game;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa8, 0x68 })]
        public TLMessageMediaGame()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLMessageMediaGame(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xbd, 0x77 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.game = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLGame>.Value);
        }

        public override int getClassId() => 
            -38694904;

        public virtual TLGame getGame() => 
            this.game;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb7, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.game, stream);
        }

        public override string toString() => 
            "messageMediaGame#fdb19008";
    }
}

