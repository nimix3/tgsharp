namespace org.telegram.api.chat.channel
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.api.chat;
    using org.telegram.api.chat.photo;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLChannel : TLAbsChat
    {
        private long accessHash;
        public const int CLASS_ID = -1588737454;
        private int date;
        private const int FLAG_ACCESS_HASH = 0x2000;
        private const int FLAG_BROADCAST = 0x20;
        private const int FLAG_CREATOR = 1;
        private const int FLAG_EDITOR = 8;
        private const int FLAG_INVITES_ENABLED = 0x400;
        private const int FLAG_KICKED = 2;
        private const int FLAG_LEFT = 4;
        private const int FLAG_MEGAGROUP = 0x100;
        private const int FLAG_MIN = 0x1000;
        private const int FLAG_MODERATOR = 0x10;
        private const int FLAG_RESTRICTED = 0x200;
        private const int FLAG_SIGNATURES = 0x800;
        private const int FLAG_USERNAME = 0x40;
        private const int FLAG_VERIFIED = 0x80;
        private int flags;
        private TLAbsChatPhoto photo;
        private string restrictionReason;
        private string title;
        private string username;
        private int version;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xbc, 0x68 })]
        public TLChannel()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLChannel(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 120, 0x6c, 0x6c, 110, 140, 0x6c, 0x6b, 140, 0x72, 0x6c, 0x6c, 110, 140 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            base.id = StreamingUtils.readInt(stream);
            if ((this.flags & 0x2000) != 0)
            {
                this.accessHash = StreamingUtils.readLong(stream);
            }
            this.title = StreamingUtils.readTLString(stream);
            if ((this.flags & 0x40) != 0)
            {
                this.username = StreamingUtils.readTLString(stream);
            }
            this.photo = StreamingUtils.readTLObject(stream, context);
            this.date = StreamingUtils.readInt(stream);
            this.version = StreamingUtils.readInt(stream);
            if ((this.flags & 0x200) != 0)
            {
                this.restrictionReason = StreamingUtils.readTLString(stream);
            }
        }

        public virtual long getAccessHash() => 
            this.accessHash;

        public override int getClassId() => 
            -1588737454;

        public virtual int getDate() => 
            this.date;

        public virtual int getFlags() => 
            this.flags;

        public virtual TLAbsChatPhoto getPhoto() => 
            this.photo;

        public virtual string getRestrictionReason() => 
            this.restrictionReason;

        public virtual string getTitle() => 
            this.title;

        public virtual string getUsername() => 
            this.username;

        public virtual int getVersion() => 
            this.version;

        public virtual bool hasAccessHash() => 
            ((this.flags & 0x2000) != 0);

        public virtual bool hasRestrictionReason() => 
            ((this.flags & 0x200) != 0);

        public virtual bool hasUsername() => 
            ((this.flags & 0x40) != 0);

        public virtual bool isBroadcast() => 
            ((this.flags & 0x20) != 0);

        public virtual bool isMegagroup() => 
            ((this.flags & 0x100) != 0);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x65, 0x6c, 0x6c, 110, 140, 0x6c, 0x6b, 140, 0x6c, 0x6c, 0x6c, 110, 0x8e })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeInt(base.id, stream);
            if ((this.flags & 0x2000) != 0)
            {
                StreamingUtils.writeLong(this.accessHash, stream);
            }
            StreamingUtils.writeTLString(this.title, stream);
            if ((this.flags & 0x40) != 0)
            {
                StreamingUtils.writeTLString(this.username, stream);
            }
            StreamingUtils.writeTLObject(this.photo, stream);
            StreamingUtils.writeInt(this.date, stream);
            StreamingUtils.writeInt(this.version, stream);
            if ((this.flags & 0x200) != 0)
            {
                StreamingUtils.writeTLString(this.restrictionReason, stream);
            }
        }

        public virtual void setAccessHash(long accessHash)
        {
            this.accessHash = accessHash;
        }

        public virtual void setDate(int date)
        {
            this.date = date;
        }

        public virtual void setFlags(int flags)
        {
            this.flags = flags;
        }

        public virtual void setPhoto(TLAbsChatPhoto photo)
        {
            this.photo = photo;
        }

        public virtual void setRestrictionReason(string restrictionReason)
        {
            this.restrictionReason = restrictionReason;
        }

        public virtual void setTitle(string title)
        {
            this.title = title;
        }

        public virtual void setUsername(string username)
        {
            this.username = username;
        }

        public virtual void setVersion(int version)
        {
            this.version = version;
        }

        public override string toString() => 
            "channel.TLChannel#a14dca52";
    }
}

