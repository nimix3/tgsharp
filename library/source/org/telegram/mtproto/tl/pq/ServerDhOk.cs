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
    public class ServerDhOk : ServerDhParams
    {
        public const int CLASS_ID = -790100132;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xad, 0x68, 0x67, 0x67, 0x67, 0x67 })]
        public ServerDhOk()
        {
            base.nonce = null;
            base.serverNonce = null;
            base.newNonceHash = null;
            base.encryptedAnswer = null;
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected ServerDhOk(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa6, 0x68, 0x67, 0x67, 0x67, 0x67 })]
        public ServerDhOk(byte[] nonce, byte[] serverNonce, byte[] encryptedAnswer)
        {
            base.nonce = nonce;
            base.serverNonce = serverNonce;
            base.newNonceHash = null;
            base.encryptedAnswer = encryptedAnswer;
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 2, 110, 110, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            base.nonce = StreamingUtils.readBytes(0x10, stream);
            base.serverNonce = StreamingUtils.readBytes(0x10, stream);
            base.encryptedAnswer = StreamingUtils.readTLBytes(stream);
        }

        public override int getClassId() => 
            -790100132;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xbb, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeByteArray(base.nonce, stream);
            StreamingUtils.writeByteArray(base.serverNonce, stream);
            StreamingUtils.writeTLBytes(base.encryptedAnswer, stream);
        }

        public override string toString() => 
            "server_DH_params_ok#d0e8075c";
    }
}

