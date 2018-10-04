namespace org.telegram.api.dialog
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.api.draft;
    using org.telegram.api.peer;
    using org.telegram.api.peer.notify.settings;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLDialog : TLObject
    {
        public const int CLASS_ID = 0x66ffba14;
        private TLAbsDraftMessage draft;
        private const int FLAG_DRAFT = 2;
        private const int FLAG_PINNED = 4;
        private const int FLAG_PTS = 1;
        private int flags;
        private TLAbsPeerNotifySettings notifySettings;
        private TLAbsPeer peer;
        private int pts;
        private int readInboxMaxId;
        private int readOutboxMaxId;
        private int topMessage;
        private int unreadCount;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb7, 0x68 })]
        public TLDialog()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLDialog(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x35, 0x6c, 0x72, 0x6c, 0x6c, 0x6c, 0x6c, 0x72, 0x6a, 140, 0x6a, 0x92 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.peer = StreamingUtils.readTLObject(stream, context);
            this.topMessage = StreamingUtils.readInt(stream);
            this.readInboxMaxId = StreamingUtils.readInt(stream);
            this.readOutboxMaxId = StreamingUtils.readInt(stream);
            this.unreadCount = StreamingUtils.readInt(stream);
            this.notifySettings = StreamingUtils.readTLObject(stream, context);
            if ((this.flags & 1) != 0)
            {
                this.pts = StreamingUtils.readInt(stream);
            }
            if ((this.flags & 2) != 0)
            {
                this.draft = StreamingUtils.readTLObject(stream, context);
            }
        }

        public override int getClassId() => 
            0x66ffba14;

        public virtual TLAbsDraftMessage getDraft() => 
            this.draft;

        public virtual TLAbsPeerNotifySettings getNotifySettings() => 
            this.notifySettings;

        public virtual TLAbsPeer getPeer() => 
            this.peer;

        public virtual int getPts() => 
            this.pts;

        public virtual int getReadInboxMaxId() => 
            this.readInboxMaxId;

        public virtual int getReadOutboxMaxId() => 
            this.readOutboxMaxId;

        public virtual int getTopMessage() => 
            this.topMessage;

        public virtual int getUnreadCount() => 
            this.unreadCount;

        public virtual bool isPinned() => 
            ((this.flags & 4) != 0);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x24, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6a, 140, 0x6a, 0x8e })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeTLObject(this.peer, stream);
            StreamingUtils.writeInt(this.topMessage, stream);
            StreamingUtils.writeInt(this.readInboxMaxId, stream);
            StreamingUtils.writeInt(this.readOutboxMaxId, stream);
            StreamingUtils.writeInt(this.unreadCount, stream);
            StreamingUtils.writeTLObject(this.notifySettings, stream);
            if ((this.flags & 1) != 0)
            {
                StreamingUtils.writeInt(this.pts, stream);
            }
            if ((this.flags & 2) != 0)
            {
                StreamingUtils.writeTLObject(this.draft, stream);
            }
        }

        public override string toString() => 
            "dialog#66ffba14";
    }
}

