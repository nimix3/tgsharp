namespace org.telegram.api.functions.messages
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using java.lang;
    using org.telegram.api.bot.inlineresult;
    using org.telegram.api.input.geopoint;
    using org.telegram.api.input.peer;
    using org.telegram.api.input.user;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/api/bot/inlineresult/TLAbsBotInlineResult;>;")]
    public class TLRequestMessagesGetInlineBotResults : TLMethod
    {
        private TLAbsInputUser bot;
        public const int CLASS_ID = 0x514e999d;
        private const int FLAG_GEO_POINT = 1;
        private int flags;
        private TLAbsInputGeoPoint geoPoint;
        private string offset;
        private TLAbsInputPeer peer;
        private string query;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 4, 0x68 })]
        public TLRequestMessagesGetInlineBotResults()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestMessagesGetInlineBotResults(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(0x23)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x4e, 0x6c, 0x72, 0x72, 0x6a, 0x92, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.bot = StreamingUtils.readTLObject(stream, context);
            this.peer = StreamingUtils.readTLObject(stream, context);
            if ((this.flags & 1) != 0)
            {
                this.geoPoint = StreamingUtils.readTLObject(stream, context);
            }
            this.query = StreamingUtils.readTLString(stream);
            this.offset = StreamingUtils.readTLString(stream);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x36, 0x68, 0x63, 0x90, 0x68, 0x87 })]
        public virtual TLAbsBotInlineResult deserializeResponse(InputStream stream, TLContext context)
        {
            TLObject obj2 = StreamingUtils.readTLObject(stream, context);
            if (obj2 == null)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IOException("Unable to parse response");
            }
            if (obj2 is TLAbsBotInlineResult)
            {
                return (TLAbsBotInlineResult) obj2;
            }
            Throwable.__<suppressFillInStackTrace>();
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected ").append(ClassLiteral<TLAbsBotInlineResult>.Value.getCanonicalName()).append(", got: ").append(Object.instancehelper_getClass(obj2).getCanonicalName()).toString());
        }

        public virtual TLAbsInputUser getBot() => 
            this.bot;

        public override int getClassId() => 
            0x514e999d;

        public virtual TLAbsInputGeoPoint getGeoPoint() => 
            this.geoPoint;

        public virtual string getOffset() => 
            this.offset;

        public virtual TLAbsInputPeer getPeer() => 
            this.peer;

        public virtual string getQuery() => 
            this.query;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x42, 0x6c, 0x6c, 0x6c, 0x6a, 140, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeTLObject(this.bot, stream);
            StreamingUtils.writeTLObject(this.peer, stream);
            if ((this.flags & 1) != 0)
            {
                StreamingUtils.writeTLObject(this.geoPoint, stream);
            }
            StreamingUtils.writeTLString(this.query, stream);
            StreamingUtils.writeTLString(this.offset, stream);
        }

        public virtual void setBot(TLAbsInputUser bot)
        {
            this.bot = bot;
        }

        public virtual void setGeoPoint(TLAbsInputGeoPoint geoPoint)
        {
            this.geoPoint = geoPoint;
        }

        public virtual void setOffset(string offset)
        {
            this.offset = offset;
        }

        public virtual void setPeer(TLAbsInputPeer peer)
        {
            this.peer = peer;
        }

        public virtual void setQuery(string query)
        {
            this.query = query;
        }

        public override string toString() => 
            "messages.getInlineBotResults#514e999d";
    }
}

