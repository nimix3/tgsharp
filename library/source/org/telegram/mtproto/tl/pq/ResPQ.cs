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
    public class ResPQ : TLObject
    {
        public const int CLASS_ID = 0x5162463;
        protected internal TLLongVector fingerprints;
        protected internal byte[] nonce;
        protected internal byte[] pq;
        protected internal byte[] serverNonce;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb6, 0x68 })]
        public ResPQ()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected ResPQ(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xaf, 0x68, 0x67, 0x67, 0x67, 0x68 })]
        public ResPQ(byte[] nonce, byte[] serverNonce, byte[] pq, TLLongVector fingerprints)
        {
            this.nonce = nonce;
            this.serverNonce = serverNonce;
            this.pq = pq;
            this.fingerprints = fingerprints;
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 40, 110, 110, 0x6c, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.nonce = StreamingUtils.readBytes(0x10, stream);
            this.serverNonce = StreamingUtils.readBytes(0x10, stream);
            this.pq = StreamingUtils.readTLBytes(stream);
            this.fingerprints = StreamingUtils.readTLLongVector(stream, context);
        }

        public override int getClassId() => 
            0x5162463;

        public virtual TLLongVector getFingerprints() => 
            this.fingerprints;

        public virtual byte[] getNonce() => 
            this.nonce;

        public virtual byte[] getPq() => 
            this.pq;

        public virtual byte[] getServerNonce() => 
            this.serverNonce;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x20, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeByteArray(this.nonce, stream);
            StreamingUtils.writeByteArray(this.serverNonce, stream);
            StreamingUtils.writeTLBytes(this.pq, stream);
            StreamingUtils.writeTLVector(this.fingerprints, stream);
        }

        public virtual void setFingerprints(TLLongVector fingerprints)
        {
            this.fingerprints = fingerprints;
        }

        public virtual void setNonce(byte[] nonce)
        {
            this.nonce = nonce;
        }

        public virtual void setPq(byte[] pq)
        {
            this.pq = pq;
        }

        public virtual void setServerNonce(byte[] serverNonce)
        {
            this.serverNonce = serverNonce;
        }

        public override string toString() => 
            "resPQ#05162463";
    }
}

