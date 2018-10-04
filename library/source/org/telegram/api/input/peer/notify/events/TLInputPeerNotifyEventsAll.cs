namespace org.telegram.api.input.peer.notify.events
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLInputPeerNotifyEventsAll : TLAbsInputPeerNotifyEvents
    {
        public const int CLASS_ID = -395694988;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9e, 0x68 })]
        public TLInputPeerNotifyEventsAll()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLInputPeerNotifyEventsAll(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            -395694988;

        public override string toString() => 
            "inputPeerNotifyEventsAll#e86a2c74";
    }
}

