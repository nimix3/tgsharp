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

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/mtproto/tl/pq/DhGenResult;>;")]
    public class ReqSetDhClientParams : TLMethod
    {
        public const int CLASS_ID = -184262881;
        protected internal byte[] encrypted;
        protected internal byte[] nonce;
        protected internal byte[] serverNonce;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb1, 0x88 })]
        public ReqSetDhClientParams()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected ReqSetDhClientParams(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xab, 0x68, 0x67, 0x67, 0x67 })]
        public ReqSetDhClientParams(byte[] nonce, byte[] serverNonce, byte[] encrypted)
        {
            this.nonce = nonce;
            this.serverNonce = serverNonce;
            this.encrypted = encrypted;
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(0x17)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x1b, 110, 110, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.nonce = StreamingUtils.readBytes(0x10, stream);
            this.serverNonce = StreamingUtils.readBytes(0x10, stream);
            this.encrypted = StreamingUtils.readTLBytes(stream);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb7, 0x68, 0x63, 0x90, 0x68, 0x90 })]
        public virtual DhGenResult deserializeResponse(InputStream stream, TLContext context)
        {
            TLObject obj2 = context.deserializeMessage(stream);
            if (obj2 == null)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new DeserializeException("Unable to deserialize response");
            }
            if (obj2 is DhGenResult)
            {
                return (DhGenResult) obj2;
            }
            Throwable.__<suppressFillInStackTrace>();
            throw new DeserializeException("Response has incorrect type");
        }

        public override int getClassId() => 
            -184262881;

        public virtual byte[] getEncrypted() => 
            this.encrypted;

        public virtual byte[] getNonce() => 
            this.nonce;

        public virtual byte[] getServerNonce() => 
            this.serverNonce;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 20, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeByteArray(this.nonce, stream);
            StreamingUtils.writeByteArray(this.serverNonce, stream);
            StreamingUtils.writeTLBytes(this.encrypted, stream);
        }

        public override string toString() => 
            "set_client_DH_params#f5045f1f";
    }
}

