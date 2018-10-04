namespace org.telegram.api.message
{
    using IKVM.Attributes;
    using java.io;
    using java.lang;
    using org.telegram.api.keyboard.replymarkup;
    using org.telegram.api.message.media;
    using org.telegram.api.peer;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLMessage : TLAbsMessage
    {
        public const int CLASS_ID = -1063525281;
        private int date;
        private int editDate;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/message/entity/TLAbsMessageEntity;>;")]
        private TLVector entities;
        private const int FLAG_EDIT_DATE = 0x8000;
        private const int FLAG_ENTITIES = 0x80;
        private const int FLAG_FROMID = 0x100;
        private const int FLAG_FWD = 4;
        private const int FLAG_MEDIA = 0x200;
        private const int FLAG_MEDIA_UNREAD = 0x20;
        private const int FLAG_MENTION = 0x10;
        private const int FLAG_OUT = 2;
        private const int FLAG_POST = 0x4000;
        private const int FLAG_REPLY = 8;
        private const int FLAG_REPLYKEYBOARD = 0x40;
        private const int FLAG_SILENT = 0x2000;
        private const int FLAG_UNUSED_0 = 1;
        private const int FLAG_UNUSED_12 = 0x1000;
        private const int FLAG_VIA_BOT_ID = 0x800;
        private const int FLAG_VIEWS = 0x400;
        private int flags;
        private int fromId;
        private TLMessageFwdHeader fwdFrom;
        private int id;
        private TLAbsMessageMedia media;
        private string message;
        private TLAbsReplyMarkup replyMarkup;
        private int replyToMsgId;
        private TLAbsPeer toId;
        private int viaBotId;
        private int views;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 11, 0x68 })]
        public TLMessage()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLMessage(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 
            0xa1, 5, 0x6c, 0x6c, 110, 140, 0x72, 0x6a, 0x92, 110, 140, 0x6a, 140, 0x6c, 0x6c, 110,
            0x92, 0x6b, 0x92, 110, 0x8d, 110, 140, 110, 140
        })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.id = StreamingUtils.readInt(stream);
            if ((this.flags & 0x100) != 0)
            {
                this.fromId = StreamingUtils.readInt(stream);
            }
            this.toId = StreamingUtils.readTLObject(stream, context);
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
            this.date = StreamingUtils.readInt(stream);
            this.message = StreamingUtils.readTLString(stream);
            if ((this.flags & 0x200) != 0)
            {
                this.media = StreamingUtils.readTLObject(stream, context);
            }
            if ((this.flags & 0x40) != 0)
            {
                this.replyMarkup = StreamingUtils.readTLObject(stream, context);
            }
            if ((this.flags & 0x80) != 0)
            {
                this.entities = StreamingUtils.readTLVector(stream, context);
            }
            if ((this.flags & 0x400) != 0)
            {
                this.views = StreamingUtils.readInt(stream);
            }
            if ((this.flags & 0x8000) != 0)
            {
                this.editDate = StreamingUtils.readInt(stream);
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0xb2)]
        public override int getChatId() => 
            this.getToId().getId();

        public override int getClassId() => 
            -1063525281;

        public virtual int getDate() => 
            this.date;

        public virtual int getEditDate() => 
            this.editDate;

        [MethodImpl(MethodImplOptions.NoInlining), Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/message/entity/TLAbsMessageEntity;>;"), LineNumberTable(0xea)]
        public virtual TLVector getEntities() => 
            (!this.hasEntities() ? new TLVector() : this.entities);

        public virtual int getFlags() => 
            this.flags;

        public virtual int getFromId() => 
            this.fromId;

        public virtual TLMessageFwdHeader getFwdFrom() => 
            this.fwdFrom;

        public virtual int getId() => 
            this.id;

        public virtual TLAbsMessageMedia getMedia() => 
            this.media;

        public virtual string getMessage() => 
            this.message;

        public virtual TLAbsReplyMarkup getReplyMarkup() => 
            this.replyMarkup;

        public virtual int getReplyToMsgId() => 
            this.replyToMsgId;

        public virtual TLAbsPeer getToId() => 
            this.toId;

        public virtual int getViaBotId() => 
            this.viaBotId;

        public virtual int getViews() => 
            this.views;

        public virtual bool hasEntities() => 
            ((this.flags & 0x80) != 0);

        public virtual bool hasFromId() => 
            ((this.flags & 0x100) != 0);

        [LineNumberTable(0x138)]
        public virtual bool hasMedia() => 
            (((this.flags & 0x200) != 0) && !(this.media is TLMessageMediaEmpty));

        public virtual bool hasReplyKeyboard() => 
            ((this.flags & 0x40) != 0);

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x130)]
        public virtual bool hasText() => 
            ((this.message == null) || !String.instancehelper_isEmpty(this.message));

        public virtual bool isForwarded() => 
            ((this.flags & 4) != 0);

        public virtual bool isMention() => 
            ((this.flags & 0x10) != 0);

        public virtual bool isPost() => 
            ((this.flags & 0x4000) != 0);

        public virtual bool isReply() => 
            ((this.flags & 8) != 0);

        public virtual bool isSent() => 
            ((this.flags & 2) != 0);

        public virtual bool isSilent() => 
            ((this.flags & 0x2000) != 0);

        public virtual bool isUnreadContent() => 
            ((this.flags & 0x20) != 0);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 
            160, 0xe0, 0x6c, 0x6c, 110, 140, 0x6c, 0x6a, 140, 110, 140, 0x6a, 140, 0x6c, 0x6c, 110,
            140, 0x6b, 140, 110, 140, 110, 140, 110, 0x8e
        })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeInt(this.id, stream);
            if ((this.flags & 0x100) != 0)
            {
                StreamingUtils.writeInt(this.fromId, stream);
            }
            StreamingUtils.writeTLObject(this.toId, stream);
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
            StreamingUtils.writeInt(this.date, stream);
            StreamingUtils.writeTLString(this.message, stream);
            if ((this.flags & 0x200) != 0)
            {
                StreamingUtils.writeTLObject(this.media, stream);
            }
            if ((this.flags & 0x40) != 0)
            {
                StreamingUtils.writeTLObject(this.replyMarkup, stream);
            }
            if ((this.flags & 0x80) != 0)
            {
                StreamingUtils.writeTLVector(this.entities, stream);
            }
            if ((this.flags & 0x400) != 0)
            {
                StreamingUtils.writeInt(this.views, stream);
            }
            if ((this.flags & 0x8000) != 0)
            {
                StreamingUtils.writeInt(this.editDate, stream);
            }
        }

        public virtual void setDate(int date)
        {
            this.date = date;
        }

        public virtual void setEditDate(int editDate)
        {
            this.editDate = editDate;
        }

        [MethodImpl(MethodImplOptions.NoInlining), Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/message/entity/TLAbsMessageEntity;>;)V"), LineNumberTable(new byte[] { 160, 0x7c, 0x67, 0x77 })]
        public virtual void setEntities(TLVector entities)
        {
            this.entities = entities;
            this.toggleEntities((entities != null) && !entities.isEmpty());
        }

        public virtual void setFlags(int flags)
        {
            this.flags = flags;
        }

        public virtual void setFromId(int fromId)
        {
            this.fromId = fromId;
        }

        public virtual void setFwdFrom(TLMessageFwdHeader fwdFrom)
        {
            this.fwdFrom = fwdFrom;
        }

        public virtual void setId(int id)
        {
            this.id = id;
        }

        public virtual void setMedia(TLAbsMessageMedia media)
        {
            this.media = media;
        }

        public virtual void setMessage(string message)
        {
            this.message = message;
        }

        public virtual void setReplyMarkup(TLAbsReplyMarkup replyMarkup)
        {
            this.replyMarkup = replyMarkup;
        }

        public virtual void setReplyToMsgId(int replyToMsgId)
        {
            this.replyToMsgId = replyToMsgId;
        }

        public virtual void setToId(TLAbsPeer toId)
        {
            this.toId = toId;
        }

        public virtual void setViaBotId(int viaBotId)
        {
            this.viaBotId = viaBotId;
        }

        public virtual void setViews(int views)
        {
            this.views = views;
        }

        [LineNumberTable(new byte[] { 0x9f, 0x52, 0xa2, 0x63, 0x94, 0x92 })]
        private void toggleEntities(bool flag1)
        {
            if (flag1)
            {
                this.flags |= 0x80;
            }
            else
            {
                this.flags &= -129;
            }
        }

        public override string toString() => 
            "message#c09be45f";
    }
}

