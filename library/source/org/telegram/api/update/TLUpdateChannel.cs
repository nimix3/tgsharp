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
    public class TLUpdateChannel : TLAbsUpdate, TLChannelUpdate
    {
        private int channelId;
        public const int CLASS_ID = -1227598250;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa7, 0x68 })]
        public TLUpdateChannel()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLUpdateChannel(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xbd, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.channelId = StreamingUtils.readInt(stream);
        }

        public virtual int getChannelId() => 
            this.channelId;

        public override int getClassId() => 
            -1227598250;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb8, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.channelId, stream);
        }

        public virtual void setChannelId(int channelId)
        {
            this.channelId = channelId;
        }

        public override string toString() => 
            "update.TLUpdateChannel#b6d45656";
    }
}

