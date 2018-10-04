namespace org.telegram.api.peer.notify.events
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLPeerNotifyEventsEmpty : TLAbsPeerNotifyEvents
    {
        public const int CLASS_ID = -1378534221;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9e, 0x68 })]
        public TLPeerNotifyEventsEmpty()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLPeerNotifyEventsEmpty(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            -1378534221;

        public override string toString() => 
            "peerNotifyEventsEmpty#add53cb3";
    }
}

