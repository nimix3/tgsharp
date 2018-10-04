namespace org.telegram.api.sendmessage.action
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLSendMessageRecordVideoAction : TLAbsSendMessageAction
    {
        public const int CLASS_ID = -1584933265;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa9, 0x68 })]
        public TLSendMessageRecordVideoAction()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLSendMessageRecordVideoAction(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            -1584933265;

        public override string toString() => 
            "sendMessageRecordAudioAction#a187d66f";
    }
}

