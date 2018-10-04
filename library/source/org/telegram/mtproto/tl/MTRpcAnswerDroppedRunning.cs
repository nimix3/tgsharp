namespace org.telegram.mtproto.tl
{
    using IKVM.Attributes;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class MTRpcAnswerDroppedRunning : TLObject
    {
        public const int CLASS_ID = -847714938;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(11)]
        public MTRpcAnswerDroppedRunning()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected MTRpcAnswerDroppedRunning(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            -847714938;

        public override string toString() => 
            "MTPRpcAnswerDropper#cd78e586";
    }
}

