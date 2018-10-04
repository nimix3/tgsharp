namespace org.telegram.api.input.bot.inlineresult
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.api.input.bot.inlinemessage;
    using org.telegram.api.input.photo;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLInputBotInlineResultPhoto : TLAbsInputBotInlineResult
    {
        public const int CLASS_ID = -1462213465;
        private string id;
        private TLAbsInputPhoto photo;
        private TLAbsInputBotInlineMessage sendMessage;
        private string type;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb9, 0x68 })]
        public TLInputBotInlineResultPhoto()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLInputBotInlineResultPhoto(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x1b, 0x6c, 0x6c, 0x72, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.id = StreamingUtils.readTLString(stream);
            this.type = StreamingUtils.readTLString(stream);
            this.photo = StreamingUtils.readTLObject(stream, context);
            this.sendMessage = StreamingUtils.readTLObject(stream, context);
        }

        public override int getClassId() => 
            -1462213465;

        public virtual string getId() => 
            this.id;

        public virtual TLAbsInputPhoto getPhoto() => 
            this.photo;

        public virtual TLAbsInputBotInlineMessage getSendMessage() => 
            this.sendMessage;

        public virtual string getType() => 
            this.type;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x13, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLString(this.id, stream);
            StreamingUtils.writeTLString(this.type, stream);
            StreamingUtils.writeTLObject(this.photo, stream);
            StreamingUtils.writeTLObject(this.sendMessage, stream);
        }

        public override string toString() => 
            "inputBotInlineResultPhoto#a8d864a7";
    }
}

