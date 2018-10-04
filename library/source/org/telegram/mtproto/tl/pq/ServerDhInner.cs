namespace org.telegram.mtproto.tl.pq
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class ServerDhInner : TLObject
    {
        public const int CLASS_ID = -1249309254;
        protected internal byte[] dhPrime;
        protected internal int g;
        protected internal byte[] g_a;
        protected internal byte[] nonce;
        protected internal byte[] serverNonce;
        protected internal int serverTime;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb8, 0x88 })]
        public ServerDhInner()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected ServerDhInner(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xaf, 0x68, 0x67, 0x67, 0x67, 0x68, 0x68, 0x68 })]
        public ServerDhInner(byte[] nonce, byte[] serverNonce, int g, byte[] dhPrime, byte[] g_a, int serverTime)
        {
            this.nonce = nonce;
            this.serverNonce = serverNonce;
            this.g = g;
            this.dhPrime = dhPrime;
            this.g_a = g_a;
            this.serverTime = serverTime;
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x2a, 110, 110, 0x6c, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.nonce = StreamingUtils.readBytes(0x10, stream);
            this.serverNonce = StreamingUtils.readBytes(0x10, stream);
            this.g = StreamingUtils.readInt(stream);
            this.dhPrime = StreamingUtils.readTLBytes(stream);
            this.g_a = StreamingUtils.readTLBytes(stream);
            this.serverTime = StreamingUtils.readInt(stream);
        }

        public override int getClassId() => 
            -1249309254;

        public virtual byte[] getDhPrime() => 
            this.dhPrime;

        public virtual int getG() => 
            this.g;

        public virtual byte[] getG_a() => 
            this.g_a;

        public virtual byte[] getNonce() => 
            this.nonce;

        public virtual byte[] getServerNonce() => 
            this.serverNonce;

        public virtual int getServerTime() => 
            this.serverTime;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x20, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeByteArray(this.nonce, stream);
            StreamingUtils.writeByteArray(this.serverNonce, stream);
            StreamingUtils.writeInt(this.g, stream);
            StreamingUtils.writeTLBytes(this.dhPrime, stream);
            StreamingUtils.writeTLBytes(this.g_a, stream);
            StreamingUtils.writeInt(this.serverTime, stream);
        }

        public override string toString() => 
            "serverDhInner#b5890dba";
    }
}

