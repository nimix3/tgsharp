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
    public class ServerDhFailure : ServerDhParams
    {
        public const int CLASS_ID = 0x79cb045d;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 170, 0x68, 0x67, 0x67, 0x67, 0x67 })]
        public ServerDhFailure()
        {
            base.nonce = null;
            base.serverNonce = null;
            base.newNonceHash = null;
            base.encryptedAnswer = null;
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected ServerDhFailure(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa3, 0x68, 0x67, 0x67, 0x67, 0x67 })]
        public ServerDhFailure(byte[] nonce, byte[] serverNonce, byte[] newNonceHash)
        {
            base.nonce = nonce;
            base.serverNonce = serverNonce;
            base.newNonceHash = newNonceHash;
            base.encryptedAnswer = null;
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xbf, 110, 110, 110 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            base.nonce = StreamingUtils.readBytes(0x10, stream);
            base.serverNonce = StreamingUtils.readBytes(0x10, stream);
            base.newNonceHash = StreamingUtils.readBytes(0x10, stream);
        }

        public override int getClassId() => 
            0x79cb045d;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb8, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeByteArray(base.nonce, stream);
            StreamingUtils.writeByteArray(base.serverNonce, stream);
            StreamingUtils.writeByteArray(base.newNonceHash, stream);
        }

        public override string toString() => 
            "server_DH_params_fail#2043348061";
    }
}

