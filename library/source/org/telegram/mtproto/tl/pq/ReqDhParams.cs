namespace org.telegram.mtproto.tl.pq
{
    using IKVM.Attributes;
    using java.io;
    using java.lang;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/mtproto/tl/pq/ServerDhParams;>;")]
    public class ReqDhParams : TLMethod
    {
        public const int CLASS_ID = -686627650;
        protected internal byte[] encryptedData;
        protected internal long fingerPrint;
        protected internal byte[] nonce;
        protected internal byte[] p;
        protected internal byte[] q;
        protected internal byte[] serverNonce;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb9, 0x88 })]
        public ReqDhParams()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected ReqDhParams(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb0, 0x68, 0x67, 0x67, 0x67, 0x68, 0x68, 0x68 })]
        public ReqDhParams(byte[] nonce, byte[] serverNonce, byte[] p, byte[] q, long fingerPrint, byte[] encryptedData)
        {
            this.nonce = nonce;
            this.serverNonce = serverNonce;
            this.p = p;
            this.q = q;
            this.fingerPrint = fingerPrint;
            this.encryptedData = encryptedData;
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(0x19)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x34, 110, 110, 0x6c, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.nonce = StreamingUtils.readBytes(0x10, stream);
            this.serverNonce = StreamingUtils.readBytes(0x10, stream);
            this.p = StreamingUtils.readTLBytes(stream);
            this.q = StreamingUtils.readTLBytes(stream);
            this.fingerPrint = StreamingUtils.readLong(stream);
            this.encryptedData = StreamingUtils.readTLBytes(stream);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xbf, 0x88, 0x63, 0x90, 0x68, 0xb0 })]
        public virtual ServerDhParams deserializeResponse(InputStream stream, TLContext context)
        {
            TLObject obj2 = context.deserializeMessage(stream);
            if (obj2 == null)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new DeserializeException("Unable to deserialize response");
            }
            if (obj2 is ServerDhParams)
            {
                return (ServerDhParams) obj2;
            }
            Throwable.__<suppressFillInStackTrace>();
            throw new DeserializeException("Response has incorrect type");
        }

        public override int getClassId() => 
            -686627650;

        public virtual byte[] getEncryptedData() => 
            this.encryptedData;

        public virtual long getFingerPrint() => 
            this.fingerPrint;

        public virtual byte[] getNonce() => 
            this.nonce;

        public virtual byte[] getP() => 
            this.p;

        public virtual byte[] getQ() => 
            this.q;

        public virtual byte[] getServerNonce() => 
            this.serverNonce;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x2a, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeByteArray(this.nonce, stream);
            StreamingUtils.writeByteArray(this.serverNonce, stream);
            StreamingUtils.writeTLBytes(this.p, stream);
            StreamingUtils.writeTLBytes(this.q, stream);
            StreamingUtils.writeLong(this.fingerPrint, stream);
            StreamingUtils.writeTLBytes(this.encryptedData, stream);
        }

        public override string toString() => 
            "req_DH_params#d712e4be";
    }
}

