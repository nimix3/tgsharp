namespace org.telegram.api.sendmessage.action
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLSendMessageCancelAction : TLAbsSendMessageAction
    {
        public const int CLASS_ID = -44119819;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa9, 0x68 })]
        public TLSendMessageCancelAction()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLSendMessageCancelAction(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            -44119819;

        public override string toString() => 
            "sendMessageCancelAction#fd5ec8f5";
    }
}

