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
    public class ClientDhInner : TLObject
    {
        public const int CLASS_ID = 0x6643b654;
        protected internal byte[] gb;
        protected internal byte[] nonce;
        protected internal long retryId;
        protected internal byte[] serverNonce;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb3, 0x88 })]
        public ClientDhInner()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected ClientDhInner(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xac, 0x68, 0x67, 0x67, 0x67, 0x68 })]
        public ClientDhInner(byte[] nonce, byte[] serverNonce, long retryId, byte[] gb)
        {
            this.nonce = nonce;
            this.serverNonce = serverNonce;
            this.retryId = retryId;
            this.gb = gb;
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x1b, 110, 110, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.nonce = StreamingUtils.readBytes(0x10, stream);
            this.serverNonce = StreamingUtils.readBytes(0x10, stream);
            this.retryId = StreamingUtils.readLong(stream);
            this.gb = StreamingUtils.readTLBytes(stream);
        }

        public override int getClassId() => 
            0x6643b654;

        public virtual byte[] getGb() => 
            this.gb;

        public virtual byte[] getNonce() => 
            this.nonce;

        public virtual long getRetryId() => 
            this.retryId;

        public virtual byte[] getServerNonce() => 
            this.serverNonce;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x13, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeByteArray(this.nonce, stream);
            StreamingUtils.writeByteArray(this.serverNonce, stream);
            StreamingUtils.writeLong(this.retryId, stream);
            StreamingUtils.writeTLBytes(this.gb, stream);
        }

        public override string toString() => 
            "clientDhInner#6643b654";
    }
}

