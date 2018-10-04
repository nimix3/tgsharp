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
    public class TLBotCommand : TLObject
    {
        public const int CLASS_ID = -1032140601;
        private string command;
        private string description;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x11)]
        public TLBotCommand()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLBotCommand(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 2, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.command = StreamingUtils.readTLString(stream);
            this.description = StreamingUtils.readTLString(stream);
        }

        public override int getClassId() => 
            -1032140601;

        public virtual string getCommand() => 
            this.command;

        public virtual string getDescription() => 
            this.description;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xbc, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLString(this.command, stream);
            StreamingUtils.writeTLString(this.description, stream);
        }

        public virtual void setCommand(string command)
        {
            this.command = command;
        }

        public virtual void setDescription(string description)
        {
            this.description = description;
        }

        public override string toString() => 
            "bot.BotCommands#c27ac8c7";
    }
}

