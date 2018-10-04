namespace org.telegram.mtproto.tl.pq
{
    using IKVM.Attributes;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public abstract class ServerDhParams : TLObject
    {
        public byte[] encryptedAnswer;
        public byte[] newNonceHash;
        public byte[] nonce;
        public byte[] serverNonce;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(11)]
        public ServerDhParams()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected ServerDhParams(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public virtual byte[] getEncryptedAnswer() => 
            this.encryptedAnswer;

        public virtual byte[] getNewNonceHash() => 
            this.newNonceHash;

        public virtual byte[] getNonce() => 
            this.nonce;

        public virtual byte[] getServerNonce() => 
            this.serverNonce;

        public virtual void setEncryptedAnswer(byte[] encryptedAnswer)
        {
            this.encryptedAnswer = encryptedAnswer;
        }

        public virtual void setNewNonceHash(byte[] newNonceHash)
        {
            this.newNonceHash = newNonceHash;
        }

        public virtual void setNonce(byte[] nonce)
        {
            this.nonce = nonce;
        }

        public virtual void setServerNonce(byte[] serverNonce)
        {
            this.serverNonce = serverNonce;
        }
    }
}

