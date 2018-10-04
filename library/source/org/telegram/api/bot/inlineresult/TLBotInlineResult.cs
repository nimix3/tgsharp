namespace org.telegram.api.bot.inlineresult
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.api.bot.inlinemessage;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLBotInlineResult : TLAbsBotInlineResult
    {
        public const int CLASS_ID = -1679053127;
        private string contentType;
        private string contentUrl;
        private string description;
        private int duration;
        private const int FLAG_CONTENT = 0x20;
        private const int FLAG_DESCRIPTION = 4;
        private const int FLAG_DURATION = 0x80;
        private const int FLAG_SIZE = 0x40;
        private const int FLAG_THUMB_URL = 0x10;
        private const int FLAG_TITLE = 2;
        private const int FLAG_UNUSED0 = 1;
        private const int FLAG_URL = 8;
        private int flags;
        private int h;
        private string id;
        private TLAbsBotInlineMessage sendMessage;
        private string thumbUrl;
        private string title;
        private string type;
        private string url;
        private int w;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 10, 0x68 })]
        protected internal TLBotInlineResult()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLBotInlineResult(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 
            160, 0x53, 0x6c, 0x6c, 0x6c, 0x6a, 140, 0x6a, 140, 0x6a, 140, 0x6b, 140, 0x6b, 0x6c, 140,
            0x6b, 0x6c, 140, 110, 140, 0x72
        })]
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
            if ((this.flags & 8) != 0)
            {
                this.url = StreamingUtils.readTLString(stream);
            }
            if ((this.flags & 0x10) != 0)
            {
                this.thumbUrl = StreamingUtils.readTLString(stream);
            }
            if ((this.flags & 0x20) != 0)
            {
                this.contentUrl = StreamingUtils.readTLString(stream);
                this.contentType = StreamingUtils.readTLString(stream);
            }
            if ((this.flags & 0x40) != 0)
            {
                this.w = StreamingUtils.readInt(stream);
                this.h = StreamingUtils.readInt(stream);
            }
            if ((this.flags & 0x80) != 0)
            {
                this.duration = StreamingUtils.readInt(stream);
            }
            this.sendMessage = StreamingUtils.readTLObject(stream, context);
        }

        public override int getClassId() => 
            -1679053127;

        public virtual string getContentType() => 
            this.contentType;

        public virtual string getContentUrl() => 
            this.contentUrl;

        public virtual string getDescription() => 
            this.description;

        public virtual int getDuration() => 
            this.duration;

        public virtual int getH() => 
            this.h;

        public virtual string getId() => 
            this.id;

        public virtual TLAbsBotInlineMessage getSendMessage() => 
            this.sendMessage;

        public virtual string getThumbUrl() => 
            this.thumbUrl;

        public virtual string getTitle() => 
            this.title;

        public virtual string getType() => 
            this.type;

        public virtual string getUrl() => 
            this.url;

        public virtual int getW() => 
            this.w;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 
            0x74, 0x6c, 0x6c, 0x6c, 0x6a, 140, 0x6a, 140, 0x6a, 140, 0x6b, 140, 0x6b, 0x6c, 140, 0x6b,
            0x6c, 140, 110, 140, 110
        })]
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
            if ((this.flags & 8) != 0)
            {
                StreamingUtils.writeTLString(this.url, stream);
            }
            if ((this.flags & 0x10) != 0)
            {
                StreamingUtils.writeTLString(this.thumbUrl, stream);
            }
            if ((this.flags & 0x20) != 0)
            {
                StreamingUtils.writeTLString(this.contentUrl, stream);
                StreamingUtils.writeTLString(this.contentType, stream);
            }
            if ((this.flags & 0x40) != 0)
            {
                StreamingUtils.writeInt(this.w, stream);
                StreamingUtils.writeInt(this.h, stream);
            }
            if ((this.flags & 0x80) != 0)
            {
                StreamingUtils.writeInt(this.duration, stream);
            }
            StreamingUtils.writeTLObject(this.sendMessage, stream);
        }

        public virtual void setContentType(string contentType)
        {
            this.contentType = contentType;
        }

        public virtual void setContentUrl(string contentUrl)
        {
            this.contentUrl = contentUrl;
        }

        public virtual void setDescription(string description)
        {
            this.description = description;
        }

        public virtual void setDuration(int duration)
        {
            this.duration = duration;
        }

        public virtual void setH(int h)
        {
            this.h = h;
        }

        public virtual void setId(string id)
        {
            this.id = id;
        }

        public virtual void setSendMessage(TLAbsBotInlineMessage sendMessage)
        {
            this.sendMessage = sendMessage;
        }

        public virtual void setThumbUrl(string thumbUrl)
        {
            this.thumbUrl = thumbUrl;
        }

        public virtual void setTitle(string title)
        {
            this.title = title;
        }

        public virtual void setType(string type)
        {
            this.type = type;
        }

        public virtual void setUrl(string url)
        {
            this.url = url;
        }

        public virtual void setW(int w)
        {
            this.w = w;
        }

        public override string toString() => 
            "botInlineResult#9bebaeb9";
    }
}

