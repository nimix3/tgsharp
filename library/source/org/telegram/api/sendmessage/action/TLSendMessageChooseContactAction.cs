namespace org.telegram.api.sendmessage.action
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLSendMessageChooseContactAction : TLAbsSendMessageAction
    {
        public const int CLASS_ID = 0x628cbc6f;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa9, 0x68 })]
        public TLSendMessageChooseContactAction()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLSendMessageChooseContactAction(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            0x628cbc6f;

        public override string toString() => 
            "sendMessageChooseContactAction#628cbc6f";
    }
}

