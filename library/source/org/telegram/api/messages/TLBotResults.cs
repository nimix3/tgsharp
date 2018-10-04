namespace org.telegram.api.messages
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using org.telegram.api.bot;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLBotResults : TLObject
    {
        private int cacheTime;
        public const int CLASS_ID = -858565059;
        private const int FLAG_GALLERY = 1;
        private const int FLAG_NEXT_OFFSET = 2;
        private const int FLAG_SWITCH_PM = 4;
        private int flags;
        private string nextOffset;
        private long queryId;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/bot/inlineresult/TLAbsBotInlineResult;>;")]
        private TLVector results;
        private TLInlineBotSwitchPm switchPm;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xbf, 0x68 })]
        public TLBotResults()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLBotResults(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x33, 0x6c, 0x6c, 0x6a, 140, 0x6a, 0x97, 0x72, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.queryId = StreamingUtils.readLong(stream);
            if ((this.flags & 2) != 0)
            {
                this.nextOffset = StreamingUtils.readTLString(stream);
            }
            if ((this.flags & 4) != 0)
            {
                this.switchPm = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLInlineBotSwitchPm>.Value);
            }
            this.results = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLAbsBotInlineResult>.Value);
            this.cacheTime = StreamingUtils.readInt(stream);
        }

        public virtual int getCacheTime() => 
            this.cacheTime;

        public override int getClassId() => 
            -858565059;

        public virtual int getFlags() => 
            this.flags;

        public virtual string getNextOffset() => 
            this.nextOffset;

        public virtual long getQueryId() => 
            this.queryId;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/bot/inlineresult/TLAbsBotInlineResult;>;")]
        public virtual TLVector getResults() => 
            this.results;

        public virtual TLInlineBotSwitchPm getSwitchPm() => 
            this.switchPm;

        public virtual bool isGallery() => 
            ((this.flags & 1) != 0);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x25, 0x6c, 0x6c, 0x6a, 140, 0x6a, 140, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeLong(this.queryId, stream);
            if ((this.flags & 2) != 0)
            {
                StreamingUtils.writeTLString(this.nextOffset, stream);
            }
            if ((this.flags & 4) != 0)
            {
                StreamingUtils.writeTLObject(this.switchPm, stream);
            }
            StreamingUtils.writeTLVector(this.results, stream);
            StreamingUtils.writeInt(this.cacheTime, stream);
        }

        public override string toString() => 
            "messages.botResults#ccd3563d";
    }
}

