namespace org.telegram.mtproto.tl
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class MTPingDelayDisconnect : TLObject
    {
        public const int CLASS_ID = -213746804;
        private int disconnectDelay;
        private long pingId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xae, 0x88 })]
        public MTPingDelayDisconnect()
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa9, 0x68, 0x67, 0x67 })]
        public MTPingDelayDisconnect(long pingId, int disconnectDelay)
        {
            this.pingId = pingId;
            this.disconnectDelay = disconnectDelay;
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected MTPingDelayDisconnect(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 7, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.pingId = StreamingUtils.readLong(stream);
            this.disconnectDelay = StreamingUtils.readInt(stream);
        }

        public override int getClassId() => 
            -213746804;

        public virtual int getDisconnectDelay() => 
            this.disconnectDelay;

        public virtual long getPingId() => 
            this.pingId;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 1, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeLong(this.pingId, stream);
            StreamingUtils.writeInt(this.disconnectDelay, stream);
        }

        public override string toString() => 
            "ping_delay_disconnect#f3427b8c";
    }
}

