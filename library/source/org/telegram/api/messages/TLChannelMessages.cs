namespace org.telegram.api.messages
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLChannelMessages : TLAbsMessages
    {
        public const int CLASS_ID = -1725551049;
        private int count;
        private int flags;
        private int pts;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xad, 0x68 })]
        public TLChannelMessages()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLChannelMessages(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0, 0x6c, 0x6c, 0x6c, 0x6d, 0x6d, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.pts = StreamingUtils.readInt(stream);
            this.count = StreamingUtils.readInt(stream);
            base.messages = StreamingUtils.readTLVector(stream, context);
            base.chats = StreamingUtils.readTLVector(stream, context);
            base.users = StreamingUtils.readTLVector(stream, context);
        }

        public override int getClassId() => 
            -1725551049;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb6, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeInt(this.pts, stream);
            StreamingUtils.writeInt(this.count, stream);
            StreamingUtils.writeTLVector(base.messages, stream);
            StreamingUtils.writeTLVector(base.chats, stream);
            StreamingUtils.writeTLVector(base.users, stream);
        }

        public override string toString() => 
            "messages.channelMessages#99262e37";
    }
}

