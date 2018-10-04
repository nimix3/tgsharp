namespace org.telegram.api.webpage
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using org.telegram.api.document;
    using org.telegram.api.page;
    using org.telegram.api.photo;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLWebPage : TLAbsWebPage
    {
        private string author;
        private TLAbsPage cachedPage;
        public const int CLASS_ID = 0x5f07b4bc;
        private string description;
        private string display_url;
        private TLAbsDocument document;
        private int duration;
        private int embed_height;
        private string embed_type;
        private string embed_url;
        private int embed_width;
        private const int FLAG_AUTHOR = 0x100;
        private const int FLAG_CACHED = 0x400;
        private const int FLAG_DESCRIPTION = 8;
        private const int FLAG_DOCUMENT = 0x200;
        private const int FLAG_DURATION = 0x80;
        private const int FLAG_PHOTO = 0x10;
        private const int FLAG_SITENAME = 2;
        private const int FLAG_SIZE = 0x40;
        private const int FLAG_TITLE = 4;
        private const int FLAG_TYPE = 1;
        private const int FLAG_URL = 0x20;
        private int flags;
        private int hash;
        private long id;
        private TLAbsPhoto photo;
        private string site_name;
        private string title;
        private string type;
        private string url;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x12, 0x68 })]
        public TLWebPage()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLWebPage(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 
            160, 0x52, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6a, 140, 0x6a, 140, 0x6a, 140, 0x6a, 140, 0x6b,
            0x92, 0x6b, 0x6c, 140, 0x6b, 0x6c, 140, 110, 140, 110, 140, 110, 0x92, 110, 0x97
        })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.id = StreamingUtils.readLong(stream);
            this.url = StreamingUtils.readTLString(stream);
            this.display_url = StreamingUtils.readTLString(stream);
            this.hash = StreamingUtils.readInt(stream);
            if ((this.flags & 1) != 0)
            {
                this.type = StreamingUtils.readTLString(stream);
            }
            if ((this.flags & 2) != 0)
            {
                this.site_name = StreamingUtils.readTLString(stream);
            }
            if ((this.flags & 4) != 0)
            {
                this.title = StreamingUtils.readTLString(stream);
            }
            if ((this.flags & 8) != 0)
            {
                this.description = StreamingUtils.readTLString(stream);
            }
            if ((this.flags & 0x10) != 0)
            {
                this.photo = StreamingUtils.readTLObject(stream, context);
            }
            if ((this.flags & 0x20) != 0)
            {
                this.embed_url = StreamingUtils.readTLString(stream);
                this.embed_type = StreamingUtils.readTLString(stream);
            }
            if ((this.flags & 0x40) != 0)
            {
                this.embed_width = StreamingUtils.readInt(stream);
                this.embed_height = StreamingUtils.readInt(stream);
            }
            if ((this.flags & 0x80) != 0)
            {
                this.duration = StreamingUtils.readInt(stream);
            }
            if ((this.flags & 0x100) != 0)
            {
                this.author = StreamingUtils.readTLString(stream);
            }
            if ((this.flags & 0x200) != 0)
            {
                this.document = StreamingUtils.readTLObject(stream, context);
            }
            if ((this.flags & 0x400) != 0)
            {
                this.cachedPage = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLAbsPage>.Value);
            }
        }

        public virtual string getAuthor() => 
            this.author;

        public virtual TLAbsPage getCachedPage() => 
            this.cachedPage;

        public override int getClassId() => 
            0x5f07b4bc;

        public virtual string getDescription() => 
            this.description;

        public virtual string getDisplay_url() => 
            this.display_url;

        public virtual TLAbsDocument getDocument() => 
            this.document;

        public virtual int getDuration() => 
            this.duration;

        public virtual int getEmbed_height() => 
            this.embed_height;

        public virtual string getEmbed_type() => 
            this.embed_type;

        public virtual string getEmbed_url() => 
            this.embed_url;

        public virtual int getEmbed_width() => 
            this.embed_width;

        public virtual int getFlags() => 
            this.flags;

        public virtual int getHash() => 
            this.hash;

        public virtual long getId() => 
            this.id;

        public virtual TLAbsPhoto getPhoto() => 
            this.photo;

        public virtual string getSite_name() => 
            this.site_name;

        public virtual string getTitle() => 
            this.title;

        public virtual string getType() => 
            this.type;

        public virtual string getUrl() => 
            this.url;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 
            0x65, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6a, 140, 0x6a, 140, 0x6a, 140, 0x6a, 140, 0x6b, 140,
            0x6b, 0x6c, 140, 0x6b, 0x6c, 140, 110, 140, 110, 140, 110, 140, 110, 0x8e
        })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeLong(this.id, stream);
            StreamingUtils.writeTLString(this.url, stream);
            StreamingUtils.writeTLString(this.display_url, stream);
            StreamingUtils.writeInt(this.hash, stream);
            if ((this.flags & 1) != 0)
            {
                StreamingUtils.writeTLString(this.type, stream);
            }
            if ((this.flags & 2) != 0)
            {
                StreamingUtils.writeTLString(this.site_name, stream);
            }
            if ((this.flags & 4) != 0)
            {
                StreamingUtils.writeTLString(this.title, stream);
            }
            if ((this.flags & 8) != 0)
            {
                StreamingUtils.writeTLString(this.description, stream);
            }
            if ((this.flags & 0x10) != 0)
            {
                StreamingUtils.writeTLObject(this.photo, stream);
            }
            if ((this.flags & 0x20) != 0)
            {
                StreamingUtils.writeTLString(this.embed_url, stream);
                StreamingUtils.writeTLString(this.embed_type, stream);
            }
            if ((this.flags & 0x40) != 0)
            {
                StreamingUtils.writeInt(this.embed_width, stream);
                StreamingUtils.writeInt(this.embed_height, stream);
            }
            if ((this.flags & 0x80) != 0)
            {
                StreamingUtils.writeInt(this.duration, stream);
            }
            if ((this.flags & 0x100) != 0)
            {
                StreamingUtils.writeTLString(this.author, stream);
            }
            if ((this.flags & 0x200) != 0)
            {
                StreamingUtils.writeTLObject(this.document, stream);
            }
            if ((this.flags & 0x400) != 0)
            {
                StreamingUtils.writeTLObject(this.cachedPage, stream);
            }
        }

        public override string toString() => 
            "webPage#5f07b4bc";
    }
}

