namespace org.telegram.mtproto.tl
{
    using IKVM.Attributes;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class MTRpcAnswerUnknown : TLObject
    {
        public const int CLASS_ID = 0x5e2ad36e;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(11)]
        public MTRpcAnswerUnknown()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected MTRpcAnswerUnknown(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            0x5e2ad36e;

        public override string toString() => 
            "MTRpcAnswerUnknown#5e2ad36e";
    }
}

