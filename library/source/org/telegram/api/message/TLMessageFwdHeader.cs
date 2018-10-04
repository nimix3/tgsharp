namespace org.telegram.api.message
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLMessageFwdHeader : TLObject
    {
        private int channelId;
        private int channelPost;
        public const int CLASS_ID = -947462709;
        private int date;
        private const int FLAG_CHANNEL_ID = 2;
        private const int FLAG_CHANNEL_POST = 4;
        private const int FLAG_FROM_ID = 1;
        private int flags;
        private int fromId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xad, 0x68 })]
        public TLMessageFwdHeader()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLMessageFwdHeader(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x26, 0x6c, 0x6a, 140, 0x6c, 0x6a, 140, 0x6a, 140 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            if ((this.flags & 1) != 0)
            {
                this.fromId = StreamingUtils.readInt(stream);
            }
            this.date = StreamingUtils.readInt(stream);
            if ((this.flags & 2) != 0)
            {
                this.channelId = StreamingUtils.readInt(stream);
            }
            if ((this.flags & 4) != 0)
            {
                this.channelPost = StreamingUtils.readInt(stream);
            }
        }

        public virtual int getChannelId() => 
            this.channelId;

        public virtual int getChannelPost() => 
            this.channelPost;

        public override int getClassId() => 
            -947462709;

        public virtual int getDate() => 
            this.date;

        public virtual int getFromId() => 
            this.fromId;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x17, 0x6c, 0x6a, 140, 0x6c, 0x6a, 140, 0x6a, 0x8e })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            if ((this.flags & 1) != 0)
            {
                StreamingUtils.writeInt(this.fromId, stream);
            }
            StreamingUtils.writeInt(this.date, stream);
            if ((this.flags & 2) != 0)
            {
                StreamingUtils.writeInt(this.channelId, stream);
            }
            if ((this.flags & 4) != 0)
            {
                StreamingUtils.writeInt(this.channelPost, stream);
            }
        }

        public virtual void setChannelId(int channelId)
        {
            this.channelId = channelId;
        }

        public virtual void setChannelPost(int channelPost)
        {
            this.channelPost = channelPost;
        }

        public virtual void setDate(int date)
        {
            this.date = date;
        }

        public virtual void setFromId(int fromId)
        {
            this.fromId = fromId;
        }

        public override string toString() => 
            "message.messageFwdHeader#c786ddcb";
    }
}

