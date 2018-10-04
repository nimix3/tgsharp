namespace org.telegram.api.input.notify
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLInputNotifyChats : TLAbsInputNotifyPeer
    {
        public const int CLASS_ID = 0x4a95e84e;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9e, 0x68 })]
        public TLInputNotifyChats()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLInputNotifyChats(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            0x4a95e84e;

        public override string toString() => 
            "inputNotifyChats#4a95e84e";
    }
}

