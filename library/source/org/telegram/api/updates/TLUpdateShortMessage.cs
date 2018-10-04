namespace org.telegram.api.updates
{
    using IKVM.Attributes;
    using java.io;
    using java.lang;
    using org.telegram.api.message;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLUpdateShortMessage : TLAbsUpdates
    {
        public const int CLASS_ID = -1857044719;
        private int date;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/message/entity/TLAbsMessageEntity;>;")]
        private TLVector entities;
        private const int FLAG_CONTENT_UNREAD = 0x20;
        private const int FLAG_ENTITIES = 0x80;
        private const int FLAG_FWD = 4;
        private const int FLAG_MENTION = 0x10;
        private const int FLAG_OUT = 2;
        private const int FLAG_REPLY = 8;
        private const int FLAG_SILENT = 0x2000;
        private const int FLAG_UNUSED_0 = 1;
        private const int FLAG_UNUSED_12 = 0x1000;
        private const int FLAG_UNUSED10 = 0x400;
        private const int FLAG_UNUSED6 = 0x40;
        private const int FLAG_UNUSED8 = 0x100;
        private const int FLAG_UNUSED9 = 0x200;
        private const int FLAG_VIA_BOT_ID = 0x800;
        private int flags;
        private TLMessageFwdHeader fwdFrom;
        private int id;
        private string message;
        private int pts;
        private int ptsCount;
        private int replyToMsgId;
        private int userId;
        private int viaBotId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 3, 0xe8, 0x33, 0xeb, 0x4e })]
        public TLUpdateShortMessage()
        {
            this.message = "";
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLUpdateShortMessage(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 
            160, 0xb0, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6a, 0x92, 110, 140, 0x6a, 140, 110,
            0x8d
        })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.id = StreamingUtils.readInt(stream);
            this.userId = StreamingUtils.readInt(stream);
            this.message = StreamingUtils.readTLString(stream);
            this.pts = StreamingUtils.readInt(stream);
            this.ptsCount = StreamingUtils.readInt(stream);
            this.date = StreamingUtils.readInt(stream);
            if ((this.flags & 4) != 0)
            {
                this.fwdFrom = StreamingUtils.readTLObject(stream, context);
            }
            if ((this.flags & 0x800) != 0)
            {
                this.viaBotId = StreamingUtils.readInt(stream);
            }
            if ((this.flags & 8) != 0)
            {
                this.replyToMsgId = StreamingUtils.readInt(stream);
            }
            if ((this.flags & 0x80) != 0)
            {
                this.entities = StreamingUtils.readTLVector(stream, context);
            }
        }

        public override int getClassId() => 
            -1857044719;

        public virtual int getDate() => 
            this.date;

        [MethodImpl(MethodImplOptions.NoInlining), Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/message/entity/TLAbsMessageEntity;>;"), LineNumberTable(0xd1)]
        public virtual TLVector getEntities() => 
            (!this.hasEntities() ? new TLVector() : this.entities);

        public virtual int getFlags() => 
            this.flags;

        public virtual TLMessageFwdHeader getFwdFrom() => 
            this.fwdFrom;

        public virtual int getId() => 
            this.id;

        public virtual string getMessage() => 
            this.message;

        public virtual int getPts() => 
            this.pts;

        public virtual int getPtsCount() => 
            this.ptsCount;

        public virtual int getReplyToMsgId() => 
            this.replyToMsgId;

        public virtual int getUserId() => 
            this.userId;

        public virtual int getViaBotId() => 
            this.viaBotId;

        public virtual bool hasEntities() => 
            ((this.flags & 0x80) != 0);

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0xe5)]
        public virtual bool hasText() => 
            ((this.message == null) || !String.instancehelper_isEmpty(this.message));

        public virtual bool isForwarded() => 
            ((this.flags & 4) != 0);

        public virtual bool isMention() => 
            ((this.flags & 0x10) != 0);

        public virtual bool isReply() => 
            ((this.flags & 8) != 0);

        public virtual bool isSent() => 
            ((this.flags & 2) != 0);

        public virtual bool isUnreadContent() => 
            ((this.flags & 0x20) != 0);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 
            160, 0x99, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6a, 140, 110, 140, 0x6a, 140, 110,
            0x8e
        })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeInt(this.id, stream);
            StreamingUtils.writeInt(this.userId, stream);
            StreamingUtils.writeTLString(this.message, stream);
            StreamingUtils.writeInt(this.pts, stream);
            StreamingUtils.writeInt(this.ptsCount, stream);
            StreamingUtils.writeInt(this.date, stream);
            if ((this.flags & 4) != 0)
            {
                StreamingUtils.writeTLObject(this.fwdFrom, stream);
            }
            if ((this.flags & 0x800) != 0)
            {
                StreamingUtils.writeInt(this.viaBotId, stream);
            }
            if ((this.flags & 8) != 0)
            {
                StreamingUtils.writeInt(this.replyToMsgId, stream);
            }
            if ((this.flags & 0x80) != 0)
            {
                StreamingUtils.writeTLVector(this.entities, stream);
            }
        }

        public virtual void setDate(int date)
        {
            this.date = date;
        }

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/message/entity/TLAbsMessageEntity;>;)V")]
        public virtual void setEntities(TLVector entities)
        {
            this.entities = entities;
        }

        public virtual void setFlags(int flags)
        {
            this.flags = flags;
        }

        public virtual void setFwdFrom(TLMessageFwdHeader fwdFrom)
        {
            this.fwdFrom = fwdFrom;
        }

        public virtual void setId(int id)
        {
            this.id = id;
        }

        public virtual void setMessage(string message)
        {
            this.message = message;
        }

        public virtual void setPts(int pts)
        {
            this.pts = pts;
        }

        public virtual void setPtsCount(int ptsCount)
        {
            this.ptsCount = ptsCount;
        }

        public virtual void setReplyToMsgId(int replyToMsgId)
        {
            this.replyToMsgId = replyToMsgId;
        }

        public virtual void setUserId(int userId)
        {
            this.userId = userId;
        }

        public virtual void setViaBotId(int viaBotId)
        {
            this.viaBotId = viaBotId;
        }

        public override string toString() => 
            "updateShortMessage#914fbf11";
    }
}

