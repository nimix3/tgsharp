namespace org.telegram.api.bot.inlinemessage
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
    public class TLBotInlineMessageText : TLAbsBotInlineMessage
    {
        public const int CLASS_ID = -1937807902;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/message/entity/TLAbsMessageEntity;>;")]
        private TLVector entites;
        private const int FLAG_ENTITIES = 2;
        private const int FLAG_NO_WEBPAGE = 1;
        private const int FLAG_REPLYMARKUP = 4;
        private int flags;
        private string message;
        private TLAbsReplyMarkup replyMarkup;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 190, 0x68 })]
        public TLBotInlineMessageText()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLBotInlineMessageText(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 40, 0x6c, 0x6c, 0x6a, 0x8d, 0x6a, 0x92 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.message = StreamingUtils.readTLString(stream);
            if ((this.flags & 2) != 0)
            {
                this.entites = StreamingUtils.readTLVector(stream, context);
            }
            if ((this.flags & 4) != 0)
            {
                this.replyMarkup = StreamingUtils.readTLObject(stream, context);
            }
        }

        public override int getClassId() => 
            -1937807902;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/message/entity/TLAbsMessageEntity;>;")]
        public virtual TLVector getEntites() => 
            this.entites;

        public virtual int getFlags() => 
            this.flags;

        public virtual string getMessage() => 
            this.message;

        public virtual TLAbsReplyMarkup getReplyMarkup() => 
            this.replyMarkup;

        public virtual bool hasWebPreview() => 
            ((this.flags & 1) == 0);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x1c, 0x6c, 0x6c, 0x6a, 140, 0x6a, 0x8e })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeTLString(this.message, stream);
            if ((this.flags & 2) != 0)
            {
                StreamingUtils.writeTLVector(this.entites, stream);
            }
            if ((this.flags & 4) != 0)
            {
                StreamingUtils.writeTLObject(this.replyMarkup, stream);
            }
        }

        public override string toString() => 
            "botInlineMessageText#8c7f65e2";
    }
}

