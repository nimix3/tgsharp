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
    public class PQInner : TLObject
    {
        public const int CLASS_ID = -2083955988;
        protected internal byte[] newNonce;
        protected internal byte[] nonce;
        protected internal byte[] p;
        protected internal byte[] pq;
        protected internal byte[] q;
        protected internal byte[] serverNonce;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb6, 0x88 })]
        public PQInner()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected PQInner(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xad, 0x68, 0x67, 0x67, 0x67, 0x68, 0x68, 0x68 })]
        public PQInner(byte[] pq, byte[] p, byte[] q, byte[] nonce, byte[] serverNonce, byte[] newNonce)
        {
            this.pq = pq;
            this.p = p;
            this.q = q;
            this.nonce = nonce;
            this.serverNonce = serverNonce;
            this.newNonce = newNonce;
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 40, 0x6c, 0x6c, 0x6c, 110, 110, 110 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.pq = StreamingUtils.readTLBytes(stream);
            this.p = StreamingUtils.readTLBytes(stream);
            this.q = StreamingUtils.readTLBytes(stream);
            this.nonce = StreamingUtils.readBytes(0x10, stream);
            this.serverNonce = StreamingUtils.readBytes(0x10, stream);
            this.newNonce = StreamingUtils.readBytes(0x20, stream);
        }

        public override int getClassId() => 
            -2083955988;

        public virtual byte[] getNewNonce() => 
            this.newNonce;

        public virtual byte[] getNonce() => 
            this.nonce;

        public virtual byte[] getP() => 
            this.p;

        public virtual byte[] getPq() => 
            this.pq;

        public virtual byte[] getQ() => 
            this.q;

        public virtual byte[] getServerNonce() => 
            this.serverNonce;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 30, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLBytes(this.pq, stream);
            StreamingUtils.writeTLBytes(this.p, stream);
            StreamingUtils.writeTLBytes(this.q, stream);
            StreamingUtils.writeByteArray(this.nonce, stream);
            StreamingUtils.writeByteArray(this.serverNonce, stream);
            StreamingUtils.writeByteArray(this.newNonce, stream);
        }

        public override string toString() => 
            "pQInner#83c95aec";
    }
}

