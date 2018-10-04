namespace org.telegram.api.functions.messages
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using java.lang;
    using org.telegram.api.input.peer;
    using org.telegram.api.updates;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/api/updates/TLAbsUpdates;>;")]
    public class TLRequestMessagesSendInlineBotResults : TLMethod
    {
        public const int CLASS_ID = -1318189314;
        private const int FLAG_BACKGROUND = 0x40;
        private const int FLAG_BROADCAST = 0x10;
        private const int FLAG_REPLY = 1;
        private const int FLAG_SILENT = 0x20;
        private const int FLAG_UNUSED1 = 2;
        private const int FLAG_UNUSED2 = 4;
        private const int FLAG_UNUSED3 = 8;
        private int flags;
        private string id;
        private TLAbsInputPeer peer;
        private long queryId;
        private long randomId;
        private int replyToMsgId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 8, 0x68 })]
        public TLRequestMessagesSendInlineBotResults()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestMessagesSendInlineBotResults(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(0x21)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x51, 0x6c, 0x72, 0x6a, 140, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.peer = StreamingUtils.readTLObject(stream, context);
            if ((this.flags & 1) != 0)
            {
                this.replyToMsgId = StreamingUtils.readInt(stream);
            }
            this.randomId = StreamingUtils.readLong(stream);
            this.queryId = StreamingUtils.readLong(stream);
            this.id = StreamingUtils.readTLString(stream);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x39, 0x68, 0x63, 0x90, 0x68, 0x87 })]
        public virtual TLAbsUpdates deserializeResponse(InputStream stream, TLContext context)
        {
            TLObject obj2 = StreamingUtils.readTLObject(stream, context);
            if (obj2 == null)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IOException("Unable to parse response");
            }
            if (obj2 is TLAbsUpdates)
            {
                return (TLAbsUpdates) obj2;
            }
            Throwable.__<suppressFillInStackTrace>();
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected ").append(ClassLiteral<TLAbsUpdates>.Value.getCanonicalName()).append(", got: ").append(Object.instancehelper_getClass(obj2).getCanonicalName()).toString());
        }

        public override int getClassId() => 
            -1318189314;

        public virtual string getId() => 
            this.id;

        public virtual TLAbsInputPeer getPeer() => 
            this.peer;

        public virtual long getQueryId() => 
            this.queryId;

        public virtual long getRandomId() => 
            this.randomId;

        public virtual int getReplyToMsgId() => 
            this.replyToMsgId;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x45, 0x6c, 0x6c, 0x6a, 140, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeTLObject(this.peer, stream);
            if ((this.flags & 1) != 0)
            {
                StreamingUtils.writeInt(this.replyToMsgId, stream);
            }
            StreamingUtils.writeLong(this.randomId, stream);
            StreamingUtils.writeLong(this.queryId, stream);
            StreamingUtils.writeTLString(this.id, stream);
        }

        public virtual void setId(string id)
        {
            this.id = id;
        }

        public virtual void setPeer(TLAbsInputPeer peer)
        {
            this.peer = peer;
        }

        public virtual void setQueryId(long queryId)
        {
            this.queryId = queryId;
        }

        public virtual void setRandomId(long randomId)
        {
            this.randomId = randomId;
        }

        public virtual void setReplyToMsgId(int replyToMsgId)
        {
            this.replyToMsgId = replyToMsgId;
        }

        public override string toString() => 
            "messages.sendInlineBotResult#b16e06fe";
    }
}

