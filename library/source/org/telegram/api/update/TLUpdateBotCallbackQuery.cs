namespace org.telegram.api.update
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.api.peer;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLUpdateBotCallbackQuery : TLAbsUpdate
    {
        private long chatInstance;
        public const int CLASS_ID = -415938591;
        private TLBytes data;
        private const int FLAG_DATA = 1;
        private const int FLAG_GAMEID = 2;
        private int flags;
        private string gameShortName;
        private int msgId;
        private TLAbsPeer peer;
        private long queryId;
        private int userId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 4, 0x68 })]
        public TLUpdateBotCallbackQuery()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLUpdateBotCallbackQuery(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x39, 0x6c, 0x6c, 0x6c, 0x72, 0x6c, 0x6c, 0x6a, 0x8d, 0x6a, 140 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.queryId = StreamingUtils.readLong(stream);
            this.userId = StreamingUtils.readInt(stream);
            this.peer = StreamingUtils.readTLObject(stream, context);
            this.msgId = StreamingUtils.readInt(stream);
            this.chatInstance = StreamingUtils.readLong(stream);
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
            -415938591;

        public virtual TLBytes getData() => 
            this.data;

        public virtual string getGameShortName() => 
            this.gameShortName;

        public virtual int getMsgId() => 
            this.msgId;

        public virtual TLAbsPeer getPeer() => 
            this.peer;

        public virtual long getQueryId() => 
            this.queryId;

        public virtual int getUserId() => 
            this.userId;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x29, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6a, 140, 0x6a, 0x8e })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeLong(this.queryId, stream);
            StreamingUtils.writeInt(this.userId, stream);
            StreamingUtils.writeTLObject(this.peer, stream);
            StreamingUtils.writeInt(this.msgId, stream);
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
            "updateBotCallbackQuery#e73547e1";
    }
}

