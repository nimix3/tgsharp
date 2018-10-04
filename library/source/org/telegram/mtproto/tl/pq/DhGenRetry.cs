namespace org.telegram.mtproto.tl.pq
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class DhGenRetry : DhGenResult
    {
        public const int CLASS_ID = 0x46dc1fb9;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9e, 0x68 })]
        public DhGenRetry()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected DhGenRetry(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9b, 0x6b })]
        public DhGenRetry(byte[] nonce, byte[] serverNonce, byte[] newNonceHash) : base(nonce, serverNonce, newNonceHash)
        {
        }

        public override int getClassId() => 
            0x46dc1fb9;

        public override string toString() => 
            "dh_gen_retry#46dc1fb9";
    }
}

