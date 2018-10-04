namespace org.telegram.api.phone
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLPhoneConnection : TLObject
    {
        public const int CLASS_ID = -1655957568;
        private long id;
        private string ip;
        private string ipv6;
        private TLBytes peerTag;
        private int port;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x10)]
        public TLPhoneConnection()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLPhoneConnection(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 8, 0x6c, 0x6c, 0x6c, 0x6c, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.id = StreamingUtils.readLong(stream);
            this.ip = StreamingUtils.readTLString(stream);
            this.ipv6 = StreamingUtils.readTLString(stream);
            this.port = StreamingUtils.readInt(stream);
            this.peerTag = StreamingUtils.readTLBytes(stream, context);
        }

        public override int getClassId() => 
            -1655957568;

        public virtual string getIp() => 
            this.ip;

        public virtual string getIpv6() => 
            this.ipv6;

        public virtual TLBytes getPeerTag() => 
            this.peerTag;

        public virtual int getPort() => 
            this.port;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xbf, 0x6c, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeLong(this.id, stream);
            StreamingUtils.writeTLString(this.ip, stream);
            StreamingUtils.writeTLString(this.ipv6, stream);
            StreamingUtils.writeInt(this.port, stream);
            StreamingUtils.writeTLBytes(this.peerTag, stream);
        }

        public override string toString() => 
            "phoneConnection#9d4c17c0";
    }
}

