namespace org.telegram.mtproto.tl.pq
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class DhGenOk : DhGenResult
    {
        public const int CLASS_ID = 0x3bcbf734;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9e, 0x68 })]
        public DhGenOk()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected DhGenOk(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9b, 0x6b })]
        public DhGenOk(byte[] nonce, byte[] serverNonce, byte[] newNonceHash) : base(nonce, serverNonce, newNonceHash)
        {
        }

        public override int getClassId() => 
            0x3bcbf734;

        public override string toString() => 
            "dh_gen_ok#3bcbf734";
    }
}

