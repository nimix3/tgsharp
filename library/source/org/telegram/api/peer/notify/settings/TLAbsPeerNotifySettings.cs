namespace org.telegram.api.peer.notify.settings
{
    using IKVM.Attributes;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public abstract class TLAbsPeerNotifySettings : TLObject
    {
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x99, 0x68 })]
        public TLAbsPeerNotifySettings()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAbsPeerNotifySettings(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }
    }
}

