namespace org.telegram.api.chat.invite
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using org.telegram.api.photo;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLChatInvite : TLAbsChatInvite
    {
        public const int CLASS_ID = -613092008;
        private const int FLAG_BROADCAST = 2;
        private const int FLAG_CHANNEL = 1;
        private const int FLAG_MEGAGROUP = 8;
        private const int FLAG_PARTICIPANTS = 0x10;
        private const int FLAG_PUBLIC = 4;
        private int flags;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLAbsUser;>;")]
        private TLVector participants;
        private int participantsCount;
        private TLAbsPhoto photo;
        private string title;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 190, 0x68 })]
        public TLChatInvite()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLChatInvite(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x38, 0x68, 0x6c, 140, 0x68, 0x6c, 0x6b, 0x92 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            base.deserializeBody(stream, context);
            this.flags = StreamingUtils.readInt(stream);
            this.title = StreamingUtils.readTLString(stream);
            StreamingUtils.readTLObject(stream, context);
            this.participantsCount = StreamingUtils.readInt(stream);
            if ((this.flags & 0x10) != 0)
            {
                this.participants = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLAbsUser>.Value);
            }
        }

        public override int getClassId() => 
            -613092008;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLAbsUser;>;")]
        public virtual TLVector getParticipants() => 
            this.participants;

        public virtual int getParticipantsCount() => 
            this.participantsCount;

        public virtual TLAbsPhoto getPhoto() => 
            this.photo;

        public virtual string getTitle() => 
            this.title;

        public virtual bool hasParticipants() => 
            ((this.flags & 0x10) != 0);

        public virtual bool isBroadcast() => 
            ((this.flags & 2) != 0);

        public virtual bool isChannel() => 
            ((this.flags & 1) != 0);

        public virtual bool isMegagroup() => 
            ((this.flags & 8) != 0);

        public virtual bool isPublic() => 
            ((this.flags & 4) != 0);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x2c, 0x67, 0x6c, 0x6c, 0x6c, 0x6c, 0x6b, 0x8e })]
        public override void serializeBody(OutputStream stream)
        {
            base.serializeBody(stream);
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeTLString(this.title, stream);
            StreamingUtils.writeTLObject(this.photo, stream);
            StreamingUtils.writeInt(this.participantsCount, stream);
            if ((this.flags & 0x10) != 0)
            {
                StreamingUtils.writeTLVector(this.participants, stream);
            }
        }

        public override string toString() => 
            "chatInvite#db74f558";
    }
}

