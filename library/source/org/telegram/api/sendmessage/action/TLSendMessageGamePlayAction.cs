namespace org.telegram.api.sendmessage.action
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLSendMessageGamePlayAction : TLAbsSendMessageAction
    {
        public const int CLASS_ID = -580219064;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa9, 0x68 })]
        public TLSendMessageGamePlayAction()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLSendMessageGamePlayAction(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            -580219064;

        public override string toString() => 
            "sendMessageGamePlayAction#dd6a8f48";
    }
}

