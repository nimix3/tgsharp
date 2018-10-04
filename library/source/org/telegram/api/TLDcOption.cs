namespace org.telegram.api
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLDcOption : TLObject
    {
        public const int CLASS_ID = 0x5d8c6cc;
        private const int FLAG_CDN = 8;
        private const int FLAG_IPV6 = 1;
        private const int FLAG_MEDIA_ONLY = 2;
        private const int FLAG_TCP_ONLY = 4;
        private int flags;
        private int id;
        private string ipAddress;
        private int port;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa7, 0x68 })]
        public TLDcOption()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLDcOption(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x18, 0x6c, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.id = StreamingUtils.readInt(stream);
            this.ipAddress = StreamingUtils.readTLString(stream);
            this.port = StreamingUtils.readInt(stream);
        }

        public override int getClassId() => 
            0x5d8c6cc;

        public virtual int getFlags() => 
            this.flags;

        public virtual int getId() => 
            this.id;

        public virtual string getIpAddress() => 
            this.ipAddress;

        public virtual int getPort() => 
            this.port;

        public virtual bool isCdn() => 
            ((this.flags & 8) != 0);

        public virtual bool isIPV6() => 
            ((this.flags & 1) != 0);

        public virtual bool isMediaOnly() => 
            ((this.flags & 2) != 0);

        public virtual bool isTcpOnly() => 
            ((this.flags & 4) != 0);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x10, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeInt(this.id, stream);
            StreamingUtils.writeTLString(this.ipAddress, stream);
            StreamingUtils.writeInt(this.port, stream);
        }

        public override string toString() => 
            "dcOption#5d8c6cc";
    }
}

