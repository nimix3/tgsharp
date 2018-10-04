namespace org.telegram.api.notify.peer
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLNotifyUsers : TLAbsNotifyPeer
    {
        public const int CLASS_ID = -1261946036;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x11)]
        public TLNotifyUsers()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLNotifyUsers(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            -1261946036;

        public override string toString() => 
            "notifyUsers#b4c83b4c";
    }
}

