namespace org.telegram.api.input.peer.notify.events
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLInputPeerNotifyEventsEmpty : TLAbsInputPeerNotifyEvents
    {
        public const int CLASS_ID = -265263912;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9e, 0x68 })]
        public TLInputPeerNotifyEventsEmpty()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLInputPeerNotifyEventsEmpty(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            -265263912;

        public override string toString() => 
            "inputPeerNotifyEventsEmpty#f03064d8";
    }
}

