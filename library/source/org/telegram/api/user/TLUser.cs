namespace org.telegram.api.user
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.api.user.profile.photo;
    using org.telegram.api.user.status;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLUser : TLAbsUser
    {
        private long accessHash;
        private int botInfoVersion;
        private string botInlinePlaceholder;
        public const int CLASS_ID = 0x2e13f4c3;
        private string firstName;
        private const int FLAG_ACCESS_HASH = 1;
        private const int FLAG_BOT = 0x4000;
        private const int FLAG_BOT_CANT_JOIN_GROUP = 0x10000;
        private const int FLAG_BOT_INLINE_GEO = 0x200000;
        private const int FLAG_BOT_READING_HISTORY = 0x8000;
        private const int FLAG_CONTACT = 0x800;
        private const int FLAG_DELETED = 0x2000;
        private const int FLAG_FIRST_NAME = 2;
        private const int FLAG_INLINE_PLACEHOLDER = 0x80000;
        private const int FLAG_LANG_CODE = 0x200000;
        private const int FLAG_LAST_NAME = 4;
        private const int FLAG_MIN = 0x100000;
        private const int FLAG_MUTUAL_CONTACT = 0x1000;
        private const int FLAG_PHONE = 0x10;
        private const int FLAG_PHOTO = 0x20;
        private const int FLAG_RESTRICTED = 0x40000;
        private const int FLAG_SELF = 0x400;
        private const int FLAG_STATUS = 0x40;
        private const int FLAG_UNUSED = 0x80;
        private const int FLAG_UNUSED2 = 0x100;
        private const int FLAG_UNUSED3 = 0x200;
        private const int FLAG_USERNAME = 8;
        private const int FLAG_VERIFIED = 0x20000;
        private int flags;
        private string langCode;
        private string lastName;
        private string phone;
        private TLAbsUserProfilePhoto photo;
        private string restrictionReason;
        private TLAbsUserStatus status;
        private string userName;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 8, 0xe8, 0x34, 0x6b, 0x6b, 0x6b, 0xeb, 0x4a })]
        public TLUser()
        {
            this.firstName = "";
            this.lastName = "";
            this.userName = "";
            this.phone = "";
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLUser(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 
            160, 0x6b, 0x6c, 0x6c, 0x6a, 140, 0x6a, 140, 0x6a, 140, 0x6a, 140, 0x6b, 140, 0x6b, 0x92,
            0x6b, 0x92, 110, 140, 110, 140, 110, 140, 110, 140
        })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            base.id = StreamingUtils.readInt(stream);
            if ((this.flags & 1) != 0)
            {
                this.accessHash = StreamingUtils.readLong(stream);
            }
            if ((this.flags & 2) != 0)
            {
                this.firstName = StreamingUtils.readTLString(stream);
            }
            if ((this.flags & 4) != 0)
            {
                this.lastName = StreamingUtils.readTLString(stream);
            }
            if ((this.flags & 8) != 0)
            {
                this.userName = StreamingUtils.readTLString(stream);
            }
            if ((this.flags & 0x10) != 0)
            {
                this.phone = StreamingUtils.readTLString(stream);
            }
            if ((this.flags & 0x20) != 0)
            {
                this.photo = StreamingUtils.readTLObject(stream, context);
            }
            if ((this.flags & 0x40) != 0)
            {
                this.status = StreamingUtils.readTLObject(stream, context);
            }
            if ((this.flags & 0x4000) != 0)
            {
                this.botInfoVersion = StreamingUtils.readInt(stream);
            }
            if ((this.flags & 0x40000) != 0)
            {
                this.restrictionReason = StreamingUtils.readTLString(stream);
            }
            if ((this.flags & 0x80000) != 0)
            {
                this.botInlinePlaceholder = StreamingUtils.readTLString(stream);
            }
            if ((this.flags & 0x200000) != 0)
            {
                this.langCode = StreamingUtils.readTLString(stream);
            }
        }

        public virtual long getAccessHash() => 
            this.accessHash;

        public virtual int getBotInfoVersion() => 
            this.botInfoVersion;

        public virtual string getBotInlinePlaceholder() => 
            this.botInlinePlaceholder;

        public override int getClassId() => 
            0x2e13f4c3;

        public virtual string getFirstName() => 
            this.firstName;

        public virtual int getFlags() => 
            this.flags;

        public virtual string getLangCode() => 
            this.langCode;

        public virtual string getLastName() => 
            this.lastName;

        public virtual string getPhone() => 
            this.phone;

        public virtual TLAbsUserProfilePhoto getPhoto() => 
            this.photo;

        public virtual string getRestrictionReason() => 
            this.restrictionReason;

        public virtual TLAbsUserStatus getStatus() => 
            this.status;

        public virtual string getUserName() => 
            this.userName;

        public virtual bool hasAccessHash() => 
            ((this.flags & 1) != 0);

        public virtual bool hasFirstName() => 
            ((this.flags & 2) != 0);

        public virtual bool hasLangCode() => 
            ((this.flags & 0x200000) != 0);

        public virtual bool hasLastName() => 
            ((this.flags & 4) != 0);

        public virtual bool hasPhone() => 
            ((this.flags & 0x10) != 0);

        public virtual bool hasUserName() => 
            ((this.flags & 8) != 0);

        public virtual bool isBot() => 
            ((this.flags & 0x4000) != 0);

        public virtual bool isBotCantAddToGroup() => 
            ((this.flags & 0x10000) != 0);

        public virtual bool isBotReadingHistory() => 
            ((this.flags & 0x8000) != 0);

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x90)]
        public virtual bool isContact() => 
            (((this.flags & 0x800) != 0) || this.isMutualContact());

        public virtual bool isDeleted() => 
            ((this.flags & 0x2000) != 0);

        public virtual bool isInlineBot() => 
            ((this.flags & 0x80000) != 0);

        public virtual bool isMutualContact() => 
            ((this.flags & 0x1000) != 0);

        public virtual bool isRestricted() => 
            ((this.flags & 0x40000) != 0);

        public virtual bool isSelf() => 
            ((this.flags & 0x400) != 0);

        public virtual bool isVerified() => 
            ((this.flags & 0x20000) != 0);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 
            160, 0x43, 0x6c, 140, 0x6a, 140, 0x6a, 140, 0x6a, 140, 0x6a, 140, 0x6b, 140, 0x6b, 140,
            0x6b, 140, 110, 140, 110, 140, 110, 140, 110, 0x8e
        })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeInt(base.id, stream);
            if ((this.flags & 1) != 0)
            {
                StreamingUtils.writeLong(this.accessHash, stream);
            }
            if ((this.flags & 2) != 0)
            {
                StreamingUtils.writeTLString(this.firstName, stream);
            }
            if ((this.flags & 4) != 0)
            {
                StreamingUtils.writeTLString(this.lastName, stream);
            }
            if ((this.flags & 8) != 0)
            {
                StreamingUtils.writeTLString(this.userName, stream);
            }
            if ((this.flags & 0x10) != 0)
            {
                StreamingUtils.writeTLString(this.phone, stream);
            }
            if ((this.flags & 0x20) != 0)
            {
                StreamingUtils.writeTLObject(this.photo, stream);
            }
            if ((this.flags & 0x40) != 0)
            {
                StreamingUtils.writeTLObject(this.status, stream);
            }
            if ((this.flags & 0x4000) != 0)
            {
                StreamingUtils.writeInt(this.botInfoVersion, stream);
            }
            if ((this.flags & 0x40000) != 0)
            {
                StreamingUtils.writeTLString(this.restrictionReason, stream);
            }
            if ((this.flags & 0x80000) != 0)
            {
                StreamingUtils.writeTLString(this.botInlinePlaceholder, stream);
            }
            if ((this.flags & 0x200000) != 0)
            {
                StreamingUtils.writeTLString(this.langCode, stream);
            }
        }

        public override string toString() => 
            "user.TLUser#2e13f4c3";
    }
}

