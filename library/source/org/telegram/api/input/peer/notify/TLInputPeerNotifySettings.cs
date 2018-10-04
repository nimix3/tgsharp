namespace org.telegram.api.input.peer.notify
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLInputPeerNotifySettings : TLObject
    {
        public const int CLASS_ID = 0x38935eb2;
        private const int FLAG_SHOW_PREVIEWS = 1;
        private const int FLAG_SILENT = 2;
        private int flags;
        private int muteUntil;
        private string sound;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xad, 0x68 })]
        public TLInputPeerNotifySettings()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLInputPeerNotifySettings(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x21, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.muteUntil = StreamingUtils.readInt(stream);
            this.sound = StreamingUtils.readTLString(stream);
        }

        public override int getClassId() => 
            0x38935eb2;

        public virtual int getMuteUntil() => 
            this.muteUntil;

        public virtual string getSound() => 
            this.sound;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x1a, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeInt(this.muteUntil, stream);
            StreamingUtils.writeTLString(this.sound, stream);
        }

        public virtual void setMuteUntil(int value)
        {
            this.muteUntil = value;
        }

        public virtual void setSound(string value)
        {
            this.sound = value;
        }

        public override string toString() => 
            "inputPeerNotifySettings#38935eb2";
    }
}

