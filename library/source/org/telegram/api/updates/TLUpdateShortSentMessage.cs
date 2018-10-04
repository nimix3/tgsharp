namespace org.telegram.api.updates
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.api.message.media;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLUpdateShortSentMessage : TLAbsUpdates
    {
        public const int CLASS_ID = 0x11f1331c;
        private int date;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/message/entity/TLAbsMessageEntity;>;")]
        private TLVector entities;
        private const int FLAG_ENTITIES = 0x80;
        private const int FLAG_MEDIA = 0x200;
        private const int FLAG_OUT = 2;
        private const int FLAG_UNUSED_0 = 1;
        private const int FLAG_UNUSED2 = 4;
        private const int FLAG_UNUSED3 = 8;
        private const int FLAG_UNUSED4 = 0x10;
        private const int FLAG_UNUSED5 = 0x20;
        private const int FLAG_UNUSED6 = 0x40;
        private const int FLAG_UNUSED8 = 0x100;
        private int flags;
        private int id;
        private TLAbsMessageMedia media;
        private int pts;
        private int ptsCount;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xbb, 0x68 })]
        public TLUpdateShortSentMessage()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLUpdateShortSentMessage(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 160, 0x4a, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 110, 0x92, 110, 0x8d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.id = StreamingUtils.readInt(stream);
            this.pts = StreamingUtils.readInt(stream);
            this.ptsCount = StreamingUtils.readInt(stream);
            this.date = StreamingUtils.readInt(stream);
            if ((this.flags & 0x200) != 0)
            {
                this.media = StreamingUtils.readTLObject(stream, context);
            }
            if ((this.flags & 0x80) != 0)
            {
                this.entities = StreamingUtils.readTLVector(stream, context);
            }
        }

        public override int getClassId() => 
            0x11f1331c;

        public virtual int getDate() => 
            this.date;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/message/entity/TLAbsMessageEntity;>;")]
        public virtual TLVector getEntities() => 
            this.entities;

        public virtual int getFlags() => 
            this.flags;

        public virtual int getId() => 
            this.id;

        public virtual TLAbsMessageMedia getMedia() => 
            this.media;

        public virtual int getPts() => 
            this.pts;

        public virtual int getPtsCount() => 
            this.ptsCount;

        public virtual bool hasMedia() => 
            ((this.flags & 0x200) != 0);

        public virtual bool isSent() => 
            ((this.flags & 2) != 0);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x7b, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 110, 140, 110, 0x8e })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeInt(this.id, stream);
            StreamingUtils.writeInt(this.pts, stream);
            StreamingUtils.writeInt(this.ptsCount, stream);
            StreamingUtils.writeInt(this.date, stream);
            if ((this.flags & 0x200) != 0)
            {
                StreamingUtils.writeTLObject(this.media, stream);
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

        public virtual void setId(int id)
        {
            this.id = id;
        }

        public virtual void setMedia(TLAbsMessageMedia media)
        {
            this.media = media;
        }

        public virtual void setPts(int pts)
        {
            this.pts = pts;
        }

        public virtual void setPtsCount(int ptsCount)
        {
            this.ptsCount = ptsCount;
        }

        public override string toString() => 
            "updateShortSentMessage#11f1331c";
    }
}

