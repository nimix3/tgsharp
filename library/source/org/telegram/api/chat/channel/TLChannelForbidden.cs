namespace org.telegram.api.chat.channel
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.api.chat;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLChannelForbidden : TLAbsChat
    {
        private long accessHash;
        public const int CLASS_ID = -2059962289;
        private const int FLAG_BROADCAST = 0x20;
        private const int FLAG_MEGAGROUP = 0x100;
        private const int FLAG_UNUSED_0 = 1;
        private const int FLAG_UNUSED_1 = 2;
        private const int FLAG_UNUSED_2 = 4;
        private const int FLAG_UNUSED_3 = 8;
        private const int FLAG_UNUSED_4 = 0x10;
        private const int FLAG_UNUSED_6 = 0x40;
        private const int FLAG_UNUSED_7 = 0x80;
        private int flags;
        private string title;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb1, 0x68 })]
        public TLChannelForbidden()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLChannelForbidden(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x13, 0x6c, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            base.id = StreamingUtils.readInt(stream);
            this.accessHash = StreamingUtils.readLong(stream);
            this.title = StreamingUtils.readTLString(stream);
        }

        public virtual long getAccessHash() => 
            this.accessHash;

        public override int getClassId() => 
            -2059962289;

        public virtual string getTitle() => 
            this.title;

        public virtual bool isBroadcast() => 
            ((this.flags & 0x20) != 0);

        public virtual bool isMegagroup() => 
            ((this.flags & 0x100) != 0);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 11, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeInt(base.id, stream);
            StreamingUtils.writeLong(this.accessHash, stream);
            StreamingUtils.writeTLString(this.title, stream);
        }

        public override string toString() => 
            "channelForbidden#8537784f";
    }
}

