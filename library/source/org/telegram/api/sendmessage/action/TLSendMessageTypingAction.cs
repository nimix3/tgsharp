namespace org.telegram.api.sendmessage.action
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLSendMessageTypingAction : TLAbsSendMessageAction
    {
        public const int CLASS_ID = 0x16bf744e;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa9, 0x68 })]
        public TLSendMessageTypingAction()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLSendMessageTypingAction(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            0x16bf744e;

        public override string toString() => 
            "sendMessageTypingAction#16bf744e";
    }
}

