namespace org.telegram.api.chat
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.api.chat.photo;
    using org.telegram.api.input.chat;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLChat : TLAbsChat
    {
        public const int CLASS_ID = -652419756;
        private int date;
        private const int FLAG_ADMINS_ENABLED = 8;
        private const int FLAG_DEACTIVATED = 0x20;
        private const int FLAG_MIGRATED_TO = 0x40;
        private const int FLAG_USER_ADMIN = 0x10;
        private const int FLAG_USER_CREATOR = 1;
        private const int FLAG_USER_KICKED = 2;
        private const int FLAG_USER_LEFT = 4;
        private int flags;
        private TLAbsInputChannel migratedTo;
        private int participantsCount;
        private TLAbsChatPhoto photo;
        private string title;
        private int version;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 1, 0x68 })]
        public TLChat()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLChat(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 160, 0x4e, 0x6c, 0x6c, 0x6c, 0x72, 0x6c, 0x6c, 0x6c, 0x6b, 0x92 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            base.id = StreamingUtils.readInt(stream);
            this.title = StreamingUtils.readTLString(stream);
            this.photo = StreamingUtils.readTLObject(stream, context);
            this.participantsCount = StreamingUtils.readInt(stream);
            this.date = StreamingUtils.readInt(stream);
            this.version = StreamingUtils.readInt(stream);
            if ((this.flags & 0x40) != 0)
            {
                this.migratedTo = StreamingUtils.readTLObject(stream, context);
            }
        }

        public override int getClassId() => 
            -652419756;

        public virtual int getDate() => 
            this.date;

        public virtual int getFlags() => 
            this.flags;

        public virtual TLAbsInputChannel getMigratedTo() => 
            this.migratedTo;

        public virtual int getParticipantsCount() => 
            this.participantsCount;

        public virtual TLAbsChatPhoto getPhoto() => 
            this.photo;

        public virtual string getTitle() => 
            this.title;

        public virtual int getVersion() => 
            this.version;

        public virtual bool isForbidden() => 
            (((this.flags & 2) != 0) || ((this.flags & 4) != 0));

        public virtual bool isLeft() => 
            ((this.flags & 4) != 0);

        public virtual bool isMigratedTo() => 
            ((this.flags & 0x40) != 0);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 160, 0x40, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6b, 0x8e })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeInt(base.id, stream);
            StreamingUtils.writeTLString(this.title, stream);
            StreamingUtils.writeTLObject(this.photo, stream);
            StreamingUtils.writeInt(this.participantsCount, stream);
            StreamingUtils.writeInt(this.date, stream);
            StreamingUtils.writeInt(this.version, stream);
            if ((this.flags & 0x40) != 0)
            {
                StreamingUtils.writeTLObject(this.migratedTo, stream);
            }
        }

        public virtual void setDate(int date)
        {
            this.date = date;
        }

        public virtual void setFlags(int flags)
        {
            this.flags = flags;
        }

        public virtual void setMigratedTo(TLAbsInputChannel migratedTo)
        {
            this.migratedTo = migratedTo;
        }

        public virtual void setParticipantsCount(int participantsCount)
        {
            this.participantsCount = participantsCount;
        }

        public virtual void setPhoto(TLAbsChatPhoto photo)
        {
            this.photo = photo;
        }

        public virtual void setTitle(string title)
        {
            this.title = title;
        }

        public virtual void setVersion(int version)
        {
            this.version = version;
        }

        public override string toString() => 
            "chat#d91cdd54";
    }
}

