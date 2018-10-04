namespace org.telegram.api.peer.notify.settings
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLPeerNotifySettingsEmpty : TLAbsPeerNotifySettings
    {
        public const int CLASS_ID = 0x70a68512;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9e, 0x68 })]
        public TLPeerNotifySettingsEmpty()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLPeerNotifySettingsEmpty(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            0x70a68512;

        public override string toString() => 
            "peerNotifySettingsEmpty#70a68512";
    }
}

