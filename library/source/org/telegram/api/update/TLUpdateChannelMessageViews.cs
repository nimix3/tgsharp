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
    public class TLUpdateChannelMessageViews : TLAbsUpdate, TLChannelUpdate
    {
        private int channelId;
        public const int CLASS_ID = -1734268085;
        private int id;
        private int views;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa9, 0x68 })]
        public TLUpdateChannelMessageViews()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLUpdateChannelMessageViews(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x11, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.channelId = StreamingUtils.readInt(stream);
            this.id = StreamingUtils.readInt(stream);
            this.views = StreamingUtils.readInt(stream);
        }

        public virtual int getChannelId() => 
            this.channelId;

        public override int getClassId() => 
            -1734268085;

        public virtual int getId() => 
            this.id;

        public virtual int getViews() => 
            this.views;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 10, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.channelId, stream);
            StreamingUtils.writeInt(this.id, stream);
            StreamingUtils.writeInt(this.views, stream);
        }

        public virtual void setChannelId(int channelId)
        {
            this.channelId = channelId;
        }

        public virtual void setId(int id)
        {
            this.id = id;
        }

        public virtual void setViews(int views)
        {
            this.views = views;
        }

        public override string toString() => 
            "update.TLUpdateChannelMessageViews#98a12b4b";
    }
}

