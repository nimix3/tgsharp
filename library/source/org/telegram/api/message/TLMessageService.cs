namespace org.telegram.api.message
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.api.message.action;
    using org.telegram.api.peer;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLMessageService : TLAbsMessage
    {
        private TLAbsMessageAction action;
        public const int CLASS_ID = -1642487306;
        private int date;
        private const int FLAG_FROMID = 0x100;
        private const int FLAG_MEDIA_UNREAD = 0x20;
        private const int FLAG_MENTIONED = 0x10;
        private const int FLAG_OUT = 2;
        private const int FLAG_POST = 0x4000;
        private const int FLAG_REPLY_TO_MSG_ID = 8;
        private const int FLAG_SILENT = 0x2000;
        private const int FLAG_UNUSED_0 = 1;
        private const int FLAG_UNUSED_10 = 0x400;
        private const int FLAG_UNUSED_11 = 0x800;
        private const int FLAG_UNUSED_12 = 0x1000;
        private const int FLAG_UNUSED_9 = 0x200;
        private const int FLAG_UNUSED2 = 4;
        private const int FLAG_UNUSED7 = 0x40;
        private const int FLAG_UNUSED8 = 0x80;
        private int flags;
        private int fromId;
        private int id;
        private int replyToMessageId;
        private TLAbsPeer toId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xbf, 0x68 })]
        public TLMessageService()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLMessageService(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 160, 110, 0x6c, 0x6c, 110, 140, 0x72, 0x6a, 140, 0x6c, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.id = StreamingUtils.readInt(stream);
            if ((this.flags & 0x100) != 0)
            {
                this.fromId = StreamingUtils.readInt(stream);
            }
            this.toId = StreamingUtils.readTLObject(stream, context);
            if ((this.flags & 8) != 0)
            {
                this.replyToMessageId = StreamingUtils.readInt(stream);
            }
            this.date = StreamingUtils.readInt(stream);
            this.action = StreamingUtils.readTLObject(stream, context);
        }

        public virtual TLAbsMessageAction getAction() => 
            this.action;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x79)]
        public override int getChatId() => 
            this.getToId().getId();

        public override int getClassId() => 
            -1642487306;

        public virtual int getDate() => 
            this.date;

        public virtual int getFlags() => 
            this.flags;

        public virtual int getFromId() => 
            this.fromId;

        public virtual int getId() => 
            this.id;

        public virtual int getReplyToMessageId() => 
            this.replyToMessageId;

        public virtual TLAbsPeer getToId() => 
            this.toId;

        public virtual bool hasFromId() => 
            ((this.flags & 0x100) != 0);

        public virtual bool isMention() => 
            ((this.flags & 0x10) != 0);

        public virtual bool isPost() => 
            ((this.flags & 0x4000) != 0);

        public virtual bool isSent() => 
            ((this.flags & 2) != 0);

        public virtual bool isSilent() => 
            ((this.flags & 0x2000) != 0);

        public virtual bool isUnreadContent() => 
            ((this.flags & 0x20) != 0);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 160, 0x5f, 0x6c, 0x6c, 110, 140, 0x6c, 0x6a, 140, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeInt(this.id, stream);
            if ((this.flags & 0x100) != 0)
            {
                StreamingUtils.writeInt(this.fromId, stream);
            }
            StreamingUtils.writeTLObject(this.toId, stream);
            if ((this.flags & 8) != 0)
            {
                StreamingUtils.writeInt(this.replyToMessageId, stream);
            }
            StreamingUtils.writeInt(this.date, stream);
            StreamingUtils.writeTLObject(this.action, stream);
        }

        public virtual void setAction(TLAbsMessageAction action)
        {
            this.action = action;
        }

        public virtual void setDate(int date)
        {
            this.date = date;
        }

        public virtual void setFlags(int flags)
        {
            this.flags = flags;
        }

        public virtual void setFromId(int fromId)
        {
            this.fromId = fromId;
        }

        public virtual void setId(int id)
        {
            this.id = id;
        }

        public virtual void setReplyToMessageId(int replyToMessageId)
        {
            this.replyToMessageId = replyToMessageId;
        }

        public virtual void setToId(TLAbsPeer toId)
        {
            this.toId = toId;
        }

        public override string toString() => 
            "messageService#9e19a1f6";
    }
}

