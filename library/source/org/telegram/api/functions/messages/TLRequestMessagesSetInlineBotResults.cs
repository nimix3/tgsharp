namespace org.telegram.api.functions.messages
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using java.lang;
    using org.telegram.api.bot;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/tl/TLBool;>;")]
    public class TLRequestMessagesSetInlineBotResults : TLMethod
    {
        private int cacheTime;
        public const int CLASS_ID = -346119674;
        private const int FLAG_GALLERY = 1;
        private const int FLAG_NEXT_OFFSET = 4;
        private const int FLAG_PRIVATE = 2;
        private const int FLAG_SWITCH_PM = 8;
        private int flags;
        private string nextOffset;
        private long queryId;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/input/bot/inlineresult/TLAbsInputBotInlineResult;>;")]
        private TLVector results;
        private TLInlineBotSwitchPm switchPm;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 7, 0x68 })]
        public TLRequestMessagesSetInlineBotResults()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestMessagesSetInlineBotResults(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(0x23)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x3e, 0x6c, 0x6c, 0x6d, 0x6c, 0x6a, 140, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.queryId = StreamingUtils.readLong(stream);
            this.results = StreamingUtils.readTLVector(stream, context);
            this.cacheTime = StreamingUtils.readInt(stream);
            if ((this.flags & 4) != 0)
            {
                this.nextOffset = StreamingUtils.readTLString(stream);
            }
            this.switchPm = StreamingUtils.readTLObject(stream, context);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x24, 0x68, 0x63, 0x90, 0x68, 0x87 })]
        public virtual TLBool deserializeResponse(InputStream stream, TLContext context)
        {
            TLObject obj2 = StreamingUtils.readTLObject(stream, context);
            if (obj2 == null)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IOException("Unable to parse response");
            }
            if (obj2 is TLBool)
            {
                return (TLBool) obj2;
            }
            Throwable.__<suppressFillInStackTrace>();
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected ").append(ClassLiteral<TLBool>.Value.getCanonicalName()).append(", got: ").append(Object.instancehelper_getClass(obj2).getCanonicalName()).toString());
        }

        public virtual int getCacheTime() => 
            this.cacheTime;

        public override int getClassId() => 
            -346119674;

        public virtual string getNextOffset() => 
            this.nextOffset;

        public virtual long getQueryId() => 
            this.queryId;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/input/bot/inlineresult/TLAbsInputBotInlineResult;>;")]
        public virtual TLVector getResults() => 
            this.results;

        public virtual TLInlineBotSwitchPm getSwitchPm() => 
            this.switchPm;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x30, 0x6c, 0x6c, 0x6c, 0x6c, 0x6a, 140, 0x6a, 0x8e })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeLong(this.queryId, stream);
            StreamingUtils.writeTLVector(this.results, stream);
            StreamingUtils.writeInt(this.cacheTime, stream);
            if ((this.flags & 4) != 0)
            {
                StreamingUtils.writeTLString(this.nextOffset, stream);
            }
            if ((this.flags & 8) != 0)
            {
                StreamingUtils.writeTLObject(this.switchPm, stream);
            }
        }

        public override string toString() => 
            "messages.setInlineBotResults#eb5ea206";
    }
}

