namespace org.telegram.api.input.bot.inlineresult
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.api.input.bot.inlinemessage;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLInputBotInlineResultGame : TLAbsInputBotInlineResult
    {
        public const int CLASS_ID = 0x4fa417f2;
        private string id;
        private TLAbsInputBotInlineMessage sendMessage;
        private string shortName;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb7, 0x68 })]
        public TLInputBotInlineResultGame()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLInputBotInlineResultGame(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x20, 0x6c, 0x6c, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.id = StreamingUtils.readTLString(stream);
            this.shortName = StreamingUtils.readTLString(stream);
            this.sendMessage = StreamingUtils.readTLObject(stream, context);
        }

        public override int getClassId() => 
            0x4fa417f2;

        public virtual string getId() => 
            this.id;

        public virtual TLAbsInputBotInlineMessage getSendMessage() => 
            this.sendMessage;

        public virtual string getShortName() => 
            this.shortName;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x19, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLString(this.id, stream);
            StreamingUtils.writeTLString(this.shortName, stream);
            StreamingUtils.writeTLObject(this.sendMessage, stream);
        }

        public virtual void setId(string id)
        {
            this.id = id;
        }

        public virtual void setSendMessage(TLAbsInputBotInlineMessage sendMessage)
        {
            this.sendMessage = sendMessage;
        }

        public virtual void setShortName(string shortName)
        {
            this.shortName = shortName;
        }

        public override string toString() => 
            "inputBotInlineResultGame#4fa417f2";
    }
}

