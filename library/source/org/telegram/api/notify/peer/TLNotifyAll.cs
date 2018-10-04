namespace org.telegram.api.notify.peer
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLNotifyAll : TLAbsNotifyPeer
    {
        public const int CLASS_ID = 0x74d07c60;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x11)]
        public TLNotifyAll()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLNotifyAll(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            0x74d07c60;

        public override string toString() => 
            "notifyAll#74d07c60";
    }
}

