namespace org.telegram.api.input.peer
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLInputPeerSelf : TLAbsInputPeer
    {
        public const int CLASS_ID = 0x7da07ec9;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9e, 0x68 })]
        public TLInputPeerSelf()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLInputPeerSelf(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            0x7da07ec9;

        public override string toString() => 
            "inputPeerSelf#7da07ec9";
    }
}

