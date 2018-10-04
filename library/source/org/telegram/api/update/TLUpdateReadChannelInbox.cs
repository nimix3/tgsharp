namespace org.telegram.api.update
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Implements(new string[] { "org.telegram.api.update.TLChannelUpdate" })]
    public class TLUpdateReadChannelInbox : TLAbsUpdate, TLChannelUpdate
    {
        private int channelId;
        public const int CLASS_ID = 0x4214f37f;
        private int maxId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa8, 0x68 })]
        public TLUpdateReadChannelInbox()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLUpdateReadChannelInbox(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 7, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.channelId = StreamingUtils.readInt(stream);
            this.maxId = StreamingUtils.readInt(stream);
        }

        public virtual int getChannelId() => 
            this.channelId;

        public override int getClassId() => 
            0x4214f37f;

        public virtual int getMaxId() => 
            this.maxId;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 1, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.channelId, stream);
            StreamingUtils.writeInt(this.maxId, stream);
        }

        public virtual void setChannelId(int channelId)
        {
            this.channelId = channelId;
        }

        public virtual void setMaxId(int maxId)
        {
            this.maxId = maxId;
        }

        public override string toString() => 
            "update.TLUpdateReadChannelInbox#4214f37f";
    }
}

