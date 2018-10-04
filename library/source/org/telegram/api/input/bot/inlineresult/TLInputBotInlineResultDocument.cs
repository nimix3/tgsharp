namespace org.telegram.api.input.bot.inlineresult
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.api.input.bot.inlinemessage;
    using org.telegram.api.input.document;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLInputBotInlineResultDocument : TLAbsInputBotInlineResult
    {
        public const int CLASS_ID = -459324;
        private string description;
        private TLAbsInputDocument document;
        private const int FLAG_DESCRIPTION = 4;
        private const int FLAG_TITLE = 2;
        private const int FLAG_UNUSED0 = 1;
        private const int FLAG_UNUSED3 = 8;
        private const int FLAG_UNUSED4 = 0x10;
        private const int FLAG_UNUSED5 = 0x20;
        private const int FLAG_UNUSED6 = 0x40;
        private const int FLAG_UNUSED7 = 0x80;
        private int flags;
        private string id;
        private TLAbsInputBotInlineMessage sendMessage;
        private string title;
        private string type;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 5, 0x68 })]
        public TLInputBotInlineResultDocument()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLInputBotInlineResultDocument(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x3a, 0x6c, 0x6c, 0x6c, 0x6a, 140, 0x6a, 140, 0x72, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.id = StreamingUtils.readTLString(stream);
            this.type = StreamingUtils.readTLString(stream);
            if ((this.flags & 2) != 0)
            {
                this.title = StreamingUtils.readTLString(stream);
            }
            if ((this.flags & 4) != 0)
            {
                this.description = StreamingUtils.readTLString(stream);
            }
            this.document = StreamingUtils.readTLObject(stream, context);
            this.sendMessage = StreamingUtils.readTLObject(stream, context);
        }

        public override int getClassId() => 
            -459324;

        public virtual string getDescription() => 
            this.description;

        public virtual TLAbsInputDocument getDocument() => 
            this.document;

        public virtual int getFlags() => 
            this.flags;

        public virtual string getId() => 
            this.id;

        public virtual TLAbsInputBotInlineMessage getSendMessage() => 
            this.sendMessage;

        public virtual string getTitle() => 
            this.title;

        public virtual string getType() => 
            this.type;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x2b, 0x6c, 0x6c, 0x6c, 0x6a, 140, 0x6a, 140, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeTLString(this.id, stream);
            StreamingUtils.writeTLString(this.type, stream);
            if ((this.flags & 2) != 0)
            {
                StreamingUtils.writeTLString(this.title, stream);
            }
            if ((this.flags & 4) != 0)
            {
                StreamingUtils.writeTLString(this.description, stream);
            }
            StreamingUtils.writeTLObject(this.document, stream);
            StreamingUtils.writeTLObject(this.sendMessage, stream);
        }

        public override string toString() => 
            "inputBotInlineResultDocument#fff8fdc4";
    }
}

