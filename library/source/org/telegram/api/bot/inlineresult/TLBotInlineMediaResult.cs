namespace org.telegram.api.bot.inlineresult
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.api.bot.inlinemessage;
    using org.telegram.api.document;
    using org.telegram.api.photo;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLBotInlineMediaResult : TLAbsBotInlineResult
    {
        public const int CLASS_ID = 0x17db940b;
        private string description;
        private TLAbsDocument document;
        private const int FLAG_DESCRIPTION = 8;
        private const int FLAG_DOCUMENT = 2;
        private const int FLAG_PHOTO = 1;
        private const int FLAG_TITLE = 4;
        private int flags;
        private string id;
        private TLAbsPhoto photo;
        private TLAbsBotInlineMessage sendMessage;
        private string title;
        private string type;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 3, 0x68 })]
        public TLBotInlineMediaResult()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLBotInlineMediaResult(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x41, 0x6c, 0x6c, 0x6c, 0x6a, 0x92, 0x6a, 0x92, 0x6a, 140, 0x6a, 140, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.id = StreamingUtils.readTLString(stream);
            this.type = StreamingUtils.readTLString(stream);
            if ((this.flags & 1) != 0)
            {
                this.photo = StreamingUtils.readTLObject(stream, context);
            }
            if ((this.flags & 2) != 0)
            {
                this.document = StreamingUtils.readTLObject(stream, context);
            }
            if ((this.flags & 4) != 0)
            {
                this.title = StreamingUtils.readTLString(stream);
            }
            if ((this.flags & 8) != 0)
            {
                this.description = StreamingUtils.readTLString(stream);
            }
            this.sendMessage = StreamingUtils.readTLObject(stream, context);
        }

        public override int getClassId() => 
            0x17db940b;

        public virtual string getDescription() => 
            this.description;

        public virtual TLAbsDocument getDocument() => 
            this.document;

        public virtual int getFlags() => 
            this.flags;

        public virtual string getId() => 
            this.id;

        public virtual TLAbsPhoto getPhoto() => 
            this.photo;

        public virtual TLAbsBotInlineMessage getSendMessage() => 
            this.sendMessage;

        public virtual string getTitle() => 
            this.title;

        public virtual string getType() => 
            this.type;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x2d, 0x6c, 0x6c, 0x6c, 0x6a, 140, 0x6a, 140, 0x6a, 140, 0x6a, 140, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeTLString(this.id, stream);
            StreamingUtils.writeTLString(this.type, stream);
            if ((this.flags & 1) != 0)
            {
                StreamingUtils.writeTLObject(this.photo, stream);
            }
            if ((this.flags & 2) != 0)
            {
                StreamingUtils.writeTLObject(this.photo, stream);
            }
            if ((this.flags & 4) != 0)
            {
                StreamingUtils.writeTLString(this.title, stream);
            }
            if ((this.flags & 8) != 0)
            {
                StreamingUtils.writeTLString(this.title, stream);
            }
            StreamingUtils.writeTLObject(this.sendMessage, stream);
        }

        public override string toString() => 
            "botInlineMediaResult#17db940b";
    }
}

