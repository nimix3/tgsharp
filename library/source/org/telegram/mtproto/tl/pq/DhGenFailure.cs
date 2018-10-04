namespace org.telegram.mtproto.tl.pq
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class DhGenFailure : DhGenResult
    {
        public const int CLASS_ID = -1499615742;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9e, 0x68 })]
        public DhGenFailure()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected DhGenFailure(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9b, 0x6b })]
        public DhGenFailure(byte[] nonce, byte[] serverNonce, byte[] newNonceHash) : base(nonce, serverNonce, newNonceHash)
        {
        }

        public override int getClassId() => 
            -1499615742;

        public override string toString() => 
            "dh_gen_fail#a69dae02";
    }
}

