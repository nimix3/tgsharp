namespace org.telegram.api.notify.peer
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLNotifyChats : TLAbsNotifyPeer
    {
        public const int CLASS_ID = -1073230141;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x11)]
        public TLNotifyChats()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLNotifyChats(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            -1073230141;

        public override string toString() => 
            "notifyChats#c007cec3";
    }
}

