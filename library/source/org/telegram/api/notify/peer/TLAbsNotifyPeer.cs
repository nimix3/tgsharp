namespace org.telegram.api.notify.peer
{
    using IKVM.Attributes;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public abstract class TLAbsNotifyPeer : TLObject
    {
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x13)]
        public TLAbsNotifyPeer()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAbsNotifyPeer(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }
    }
}

