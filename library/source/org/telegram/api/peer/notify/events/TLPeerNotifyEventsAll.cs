namespace org.telegram.api.peer.notify.events
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLPeerNotifyEventsAll : TLAbsPeerNotifyEvents
    {
        public const int CLASS_ID = 0x6d1ded88;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9e, 0x68 })]
        public TLPeerNotifyEventsAll()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLPeerNotifyEventsAll(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            0x6d1ded88;

        public override string toString() => 
            "peerNotifyEventsAll#6d1ded88";
    }
}

