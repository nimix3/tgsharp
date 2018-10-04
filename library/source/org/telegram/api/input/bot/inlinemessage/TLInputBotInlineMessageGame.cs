namespace org.telegram.api.input.bot.inlinemessage
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.api.keyboard.replymarkup;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLInputBotInlineMessageGame : TLAbsInputBotInlineMessage
    {
        public const int CLASS_ID = 0x4b425864;
        private const int FLAG_REPLY_MARKUP = 4;
        private const int FLAG_UNUSED0 = 1;
        private const int FLAG_UNUSED1 = 2;
        private int flags;
        private TLAbsReplyMarkup replyMarkup;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xba, 0x68 })]
        public TLInputBotInlineMessageGame()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLInputBotInlineMessageGame(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 20, 0x6c, 0x6a, 0x92 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            if ((this.flags & 4) != 0)
            {
                this.replyMarkup = StreamingUtils.readTLObject(stream, context);
            }
        }

        public override int getClassId() => 
            0x4b425864;

        public virtual int getFlags() => 
            this.flags;

        public virtual TLAbsReplyMarkup getReplyMarkup() => 
            this.replyMarkup;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 12, 0x6c, 0x6a, 0x8e })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            if ((this.flags & 4) != 0)
            {
                StreamingUtils.writeTLObject(this.replyMarkup, stream);
            }
        }

        public override string toString() => 
            "inputBotInlineMessageGame#4b425864";
    }
}

