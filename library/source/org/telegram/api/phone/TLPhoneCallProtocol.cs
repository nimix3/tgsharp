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
    public class TLPhoneCallProtocol : TLObject
    {
        public const int CLASS_ID = -1564789301;
        private const int FLAG_DP_P2P = 1;
        private const int FLAG_UDP_REFLECTOR = 2;
        private int flags;
        private int maxLayer;
        private int minLayer;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa8, 0x68 })]
        public TLPhoneCallProtocol()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLPhoneCallProtocol(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x25, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.minLayer = StreamingUtils.readInt(stream);
            this.maxLayer = StreamingUtils.readInt(stream);
        }

        public override int getClassId() => 
            -1564789301;

        public virtual int getFlags() => 
            this.flags;

        public virtual int getMaxLayer() => 
            this.maxLayer;

        public virtual int getMinLayer() => 
            this.minLayer;

        public virtual bool isDpP2p() => 
            ((this.flags & 1) != 0);

        public virtual bool isUdpReflector() => 
            ((this.flags & 2) != 0);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 30, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeInt(this.minLayer, stream);
            StreamingUtils.writeInt(this.maxLayer, stream);
        }

        [LineNumberTable(new byte[] { 0x9f, 0x80, 130, 0x63, 0x90, 0x8f })]
        public virtual void setDpP2p(bool enabled)
        {
            if (enabled)
            {
                this.flags |= 1;
            }
            else
            {
                this.flags &= -2;
            }
        }

        public virtual void setMaxLayer(int maxLayer)
        {
            this.maxLayer = maxLayer;
        }

        public virtual void setMinLayer(int minLayer)
        {
            this.minLayer = minLayer;
        }

        [LineNumberTable(new byte[] { 0x9f, 0x7e, 130, 0x63, 0x90, 0x8f })]
        public virtual void setUdpReflector(bool enabled)
        {
            if (enabled)
            {
                this.flags |= 2;
            }
            else
            {
                this.flags &= -3;
            }
        }

        public override string toString() => 
            "phoneCallProtocol#a2bb35cb";
    }
}

