namespace org.telegram.api.update
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.api.notify.peer;
    using org.telegram.api.peer.notify.settings;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLUpdateNotifySettings : TLAbsUpdate
    {
        public const int CLASS_ID = -1094555409;
        private TLAbsPeerNotifySettings notifySettings;
        private TLAbsNotifyPeer peer;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 170, 0x68 })]
        public TLUpdateNotifySettings()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLUpdateNotifySettings(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x1d, 0x72, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.peer = StreamingUtils.readTLObject(stream, context);
            this.notifySettings = StreamingUtils.readTLObject(stream, context);
        }

        public override int getClassId() => 
            -1094555409;

        public virtual TLAbsPeerNotifySettings getNotifySettings() => 
            this.notifySettings;

        public virtual TLAbsNotifyPeer getPeer() => 
            this.peer;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x17, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.peer, stream);
            StreamingUtils.writeTLObject(this.notifySettings, stream);
        }

        public virtual void setNotifySettings(TLAbsPeerNotifySettings notifySettings)
        {
            this.notifySettings = notifySettings;
        }

        public virtual void setPeer(TLAbsNotifyPeer peer)
        {
            this.peer = peer;
        }

        public override string toString() => 
            "updateNotifySettings#bec268ef";
    }
}

