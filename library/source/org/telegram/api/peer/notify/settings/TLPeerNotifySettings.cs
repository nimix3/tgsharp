namespace org.telegram.api.peer.notify.settings
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLPeerNotifySettings : TLAbsPeerNotifySettings
    {
        public const int CLASS_ID = -1697798976;
        private const int FLAG_SHOW_PREVIEWS = 1;
        private const int FLAG_SILENT = 2;
        private int flags;
        private int muteUntil;
        private string sound;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x16, 0x68 })]
        public TLPeerNotifySettings()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLPeerNotifySettings(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x29, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.muteUntil = StreamingUtils.readInt(stream);
            this.sound = StreamingUtils.readTLString(stream);
        }

        public override int getClassId() => 
            -1697798976;

        public virtual int getMuteUntil() => 
            this.muteUntil;

        public virtual string getSound() => 
            this.sound;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x21, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeInt(this.muteUntil, stream);
            StreamingUtils.writeTLString(this.sound, stream);
        }

        public virtual void setMuteUntil(int muteUntil)
        {
            this.muteUntil = muteUntil;
        }

        public virtual void setSound(string sound)
        {
            this.sound = sound;
        }

        public override string toString() => 
            "peerNotifySettings#9acda4c0";
    }
}

