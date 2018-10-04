namespace org.telegram.api.bot.inlinemessage
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.api.geo.point;
    using org.telegram.api.keyboard.replymarkup;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLBotInlineMessageMediaVenue : TLAbsBotInlineMessage
    {
        private string address;
        public const int CLASS_ID = 0x4366232e;
        private const int FLAG_REPLY_MARKUP = 4;
        private const int FLAG_UNUSED0 = 1;
        private const int FLAG_UNUSED1 = 2;
        private int flags;
        private TLAbsGeoPoint geo;
        private string provider;
        private TLAbsReplyMarkup replyMarkup;
        private string title;
        private string venueId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0, 0x68 })]
        public TLBotInlineMessageMediaVenue()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLBotInlineMessageMediaVenue(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x33, 0x6c, 0x72, 0x6c, 0x6c, 0x6c, 0x6c, 0x6a, 0x92 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.geo = StreamingUtils.readTLObject(stream, context);
            this.title = StreamingUtils.readTLString(stream);
            this.address = StreamingUtils.readTLString(stream);
            this.provider = StreamingUtils.readTLString(stream);
            this.venueId = StreamingUtils.readTLString(stream);
            if ((this.flags & 4) != 0)
            {
                this.replyMarkup = StreamingUtils.readTLObject(stream, context);
            }
        }

        public virtual string getAddress() => 
            this.address;

        public override int getClassId() => 
            0x4366232e;

        public virtual int getFlags() => 
            this.flags;

        public virtual TLAbsGeoPoint getGeo() => 
            this.geo;

        public virtual string getProvider() => 
            this.provider;

        public virtual TLAbsReplyMarkup getReplyMarkup() => 
            this.replyMarkup;

        public virtual string getTitle() => 
            this.title;

        public virtual string getVenueId() => 
            this.venueId;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x26, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6a, 0x8e })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeTLObject(this.geo, stream);
            StreamingUtils.writeTLString(this.title, stream);
            StreamingUtils.writeTLString(this.address, stream);
            StreamingUtils.writeTLString(this.provider, stream);
            StreamingUtils.writeTLString(this.venueId, stream);
            if ((this.flags & 4) != 0)
            {
                StreamingUtils.writeTLObject(this.replyMarkup, stream);
            }
        }

        public override string toString() => 
            "botInlineMessageMediaVenue#4366232e";
    }
}

