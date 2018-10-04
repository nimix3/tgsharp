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
    public class TLBotInlineMessageMediaGeo : TLAbsBotInlineMessage
    {
        public const int CLASS_ID = 0x3a8fd8b8;
        private const int FLAG_REPLY_MARKUP = 4;
        private const int FLAG_UNUSED0 = 1;
        private const int FLAG_UNUSED1 = 2;
        private int flags;
        private TLAbsGeoPoint geoPoint;
        private TLAbsReplyMarkup replyMarkup;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xbc, 0x68 })]
        public TLBotInlineMessageMediaGeo()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLBotInlineMessageMediaGeo(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x1b, 0x6c, 0x72, 0x6a, 0x92 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.geoPoint = StreamingUtils.readTLObject(stream, context);
            if ((this.flags & 4) != 0)
            {
                this.replyMarkup = StreamingUtils.readTLObject(stream, context);
            }
        }

        public override int getClassId() => 
            0x3a8fd8b8;

        public virtual int getFlags() => 
            this.flags;

        public virtual TLAbsGeoPoint getGeoPoint() => 
            this.geoPoint;

        public virtual TLAbsReplyMarkup getReplyMarkup() => 
            this.replyMarkup;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x12, 0x6c, 0x6c, 0x6a, 0x8e })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeTLObject(this.geoPoint, stream);
            if ((this.flags & 4) != 0)
            {
                StreamingUtils.writeTLObject(this.replyMarkup, stream);
            }
        }

        public override string toString() => 
            "botInlineMessageMediaGeo#3a8fd8b8";
    }
}

