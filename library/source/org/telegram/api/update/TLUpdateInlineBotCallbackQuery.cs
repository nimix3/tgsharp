namespace org.telegram.api.update
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.api.input.bot;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLUpdateInlineBotCallbackQuery : TLAbsUpdate
    {
        private long chatInstance;
        public const int CLASS_ID = -103646630;
        private TLBytes data;
        private const int FLAG_DATA = 1;
        private const int FLAG_GAMEID = 2;
        private int flags;
        private string gameShortName;
        private TLInputBotInlineMessageId msgId;
        private long queryId;
        private int userId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 3, 0x68 })]
        public TLUpdateInlineBotCallbackQuery()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLUpdateInlineBotCallbackQuery(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x33, 0x6c, 0x6c, 0x6c, 0x72, 0x6d, 0x6a, 0x8d, 0x6a, 140 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.queryId = StreamingUtils.readLong(stream);
            this.userId = StreamingUtils.readInt(stream);
            this.msgId = StreamingUtils.readTLObject(stream, context);
            this.chatInstance = StreamingUtils.readInt(stream);
            if ((this.flags & 1) != 0)
            {
                this.data = StreamingUtils.readTLBytes(stream, context);
            }
            if ((this.flags & 2) != 0)
            {
                this.gameShortName = StreamingUtils.readTLString(stream);
            }
        }

        public virtual long getChatInstance() => 
            this.chatInstance;

        public override int getClassId() => 
            -103646630;

        public virtual TLBytes getData() => 
            this.data;

        public virtual string getGameShortName() => 
            this.gameShortName;

        public virtual TLInputBotInlineMessageId getMsgId() => 
            this.msgId;

        public virtual long getQueryId() => 
            this.queryId;

        public virtual int getUserId() => 
            this.userId;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x24, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6a, 140, 0x6a, 0x8e })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeLong(this.queryId, stream);
            StreamingUtils.writeInt(this.userId, stream);
            StreamingUtils.writeTLObject(this.msgId, stream);
            StreamingUtils.writeLong(this.chatInstance, stream);
            if ((this.flags & 1) != 0)
            {
                StreamingUtils.writeTLBytes(this.data, stream);
            }
            if ((this.flags & 2) != 0)
            {
                StreamingUtils.writeTLString(this.gameShortName, stream);
            }
        }

        public override string toString() => 
            "updateInlineBotCallbackQuery#f9d27a5a";
    }
}

