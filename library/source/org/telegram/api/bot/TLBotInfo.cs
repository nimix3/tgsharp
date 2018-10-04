namespace org.telegram.api.bot
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLBotInfo : TLObject
    {
        public const int CLASS_ID = -1729618630;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/bot/TLBotCommand;>;")]
        private TLVector commands;
        private string description;
        private int userId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 160, 0xe8, 0x45 })]
        public TLBotInfo()
        {
            this.commands = new TLVector();
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLBotInfo(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 12, 0x6c, 0x6c, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.userId = StreamingUtils.readInt(stream);
            this.description = StreamingUtils.readTLString(stream);
            this.commands = StreamingUtils.readTLVector(stream, context);
        }

        public override int getClassId() => 
            -1729618630;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/bot/TLBotCommand;>;")]
        public virtual TLVector getCommands() => 
            this.commands;

        public virtual string getDescription() => 
            this.description;

        public virtual int getUserId() => 
            this.userId;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 6, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.userId, stream);
            StreamingUtils.writeTLVector(this.commands, stream);
        }

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/bot/TLBotCommand;>;)V")]
        public virtual void setCommands(TLVector commands)
        {
            this.commands = commands;
        }

        public virtual void setDescription(string description)
        {
            this.description = description;
        }

        public virtual void setUserId(int userId)
        {
            this.userId = userId;
        }

        public override string toString() => 
            "bot.BotInfo#98e81d3a";
    }
}

