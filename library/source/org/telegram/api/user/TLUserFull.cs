namespace org.telegram.api.user
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.api.bot;
    using org.telegram.api.contacts;
    using org.telegram.api.peer.notify.settings;
    using org.telegram.api.photo;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLUserFull : TLObject
    {
        private string about;
        private TLBotInfo botInfo;
        public const int CLASS_ID = 0xf220f3f;
        private int commonChatsCount;
        private const int FLAG_ABOUT = 2;
        private const int FLAG_BLOCKED = 1;
        private const int FLAG_BOT_INFO = 8;
        private const int FLAG_CALLS_AVAILABLE = 0x10;
        private const int FLAG_PHONE_CALLS_PRIVATE = 0x20;
        private const int FLAG_PROFILE_PHOTO = 4;
        private int flags;
        private TLContactsLink link;
        private TLAbsPeerNotifySettings notifySettings;
        private TLAbsPhoto profilePhoto;
        private TLAbsUser user;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xba, 0x68 })]
        public TLUserFull()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLUserFull(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x41, 0x6c, 0x72, 0x6a, 140, 0x72, 0x6a, 0x92, 0x72, 0x6a, 0x92, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.user = StreamingUtils.readTLObject(stream, context);
            if ((this.flags & 2) != 0)
            {
                this.about = StreamingUtils.readTLString(stream);
            }
            this.link = StreamingUtils.readTLObject(stream, context);
            if ((this.flags & 4) != 0)
            {
                this.profilePhoto = StreamingUtils.readTLObject(stream, context);
            }
            this.notifySettings = StreamingUtils.readTLObject(stream, context);
            if ((this.flags & 8) != 0)
            {
                this.botInfo = StreamingUtils.readTLObject(stream, context);
            }
            this.commonChatsCount = StreamingUtils.readInt(stream);
        }

        public virtual string getAbout() => 
            this.about;

        public virtual TLBotInfo getBotInfo() => 
            this.botInfo;

        public override int getClassId() => 
            0xf220f3f;

        public virtual int getCommonChatsCount() => 
            this.commonChatsCount;

        public virtual int getFlags() => 
            this.flags;

        public virtual TLContactsLink getLink() => 
            this.link;

        public virtual TLAbsPeerNotifySettings getNotifySettings() => 
            this.notifySettings;

        public virtual TLAbsPhoto getProfilePhoto() => 
            this.profilePhoto;

        public virtual TLAbsUser getUser() => 
            this.user;

        public virtual bool hasPhoneCallsAvailable() => 
            ((this.flags & 0x10) != 0);

        public virtual bool hasPhoneCallsPrivate() => 
            ((this.flags & 0x20) != 0);

        public virtual bool isBlocked() => 
            ((this.flags & 1) != 0);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x2f, 0x6c, 0x6c, 0x6a, 140, 0x6c, 0x6a, 140, 0x6c, 0x6a, 140, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeTLObject(this.user, stream);
            if ((this.flags & 2) != 0)
            {
                StreamingUtils.writeTLString(this.about, stream);
            }
            StreamingUtils.writeTLObject(this.link, stream);
            if ((this.flags & 4) != 0)
            {
                StreamingUtils.writeTLObject(this.profilePhoto, stream);
            }
            StreamingUtils.writeTLObject(this.notifySettings, stream);
            if ((this.flags & 8) != 0)
            {
                StreamingUtils.writeTLObject(this.botInfo, stream);
            }
            StreamingUtils.writeInt(this.commonChatsCount, stream);
        }

        public override string toString() => 
            "userFull#f220f3f";
    }
}

