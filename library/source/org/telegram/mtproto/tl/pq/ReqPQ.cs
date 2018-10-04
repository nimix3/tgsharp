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

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/mtproto/tl/pq/ResPQ;>;")]
    public class ReqPQ : TLMethod
    {
        public const int CLASS_ID = 0x60469778;
        protected internal byte[] nonce;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb0, 0x88 })]
        public ReqPQ()
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa9, 0x68, 0x69, 0x90, 0x67 })]
        public ReqPQ(byte[] nonce)
        {
            if ((nonce == null) || (nonce.Length != 0x10))
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IllegalArgumentException("nonce might be not null and 16 bytes length");
            }
            this.nonce = nonce;
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected ReqPQ(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(0x15)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x18, 110 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.nonce = StreamingUtils.readBytes(0x10, stream);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb6, 0x68, 0x63, 0x90, 0x68, 0xb0 })]
        public virtual ResPQ deserializeResponse(InputStream stream, TLContext context)
        {
            TLObject obj2 = context.deserializeMessage(stream);
            if (obj2 == null)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new DeserializeException("Unable to deserialize response");
            }
            if (obj2 is ResPQ)
            {
                return (ResPQ) obj2;
            }
            Throwable.__<suppressFillInStackTrace>();
            throw new DeserializeException("Response has incorrect type");
        }

        public override int getClassId() => 
            0x60469778;

        public virtual byte[] getNonce() => 
            this.nonce;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x13, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeByteArray(this.nonce, stream);
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 6, 0x69, 0x90, 0x67 })]
        public virtual void setNonce(byte[] nonce)
        {
            if ((nonce == null) || (nonce.Length != 0x10))
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IllegalArgumentException("nonce might be not null and 16 bytes length");
            }
            this.nonce = nonce;
        }

        public override string toString() => 
            "req_pq#60469778";
    }
}

