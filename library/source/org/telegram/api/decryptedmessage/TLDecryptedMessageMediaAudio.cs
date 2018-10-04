namespace org.telegram.api.decryptedmessage
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLDecryptedMessageMediaAudio : TLAbsDecryptedMessageMedia
    {
        public const int CLASS_ID = 0x57e0a9cb;
        private int duration;
        private TLBytes iv;
        private TLBytes key;
        private string mimeType;
        private int size;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb6, 0x68 })]
        public TLDecryptedMessageMediaAudio()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLDecryptedMessageMediaAudio(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x62, 0x6c, 0x6c, 0x6c, 0x6d, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.duration = StreamingUtils.readInt(stream);
            this.mimeType = StreamingUtils.readTLString(stream);
            this.size = StreamingUtils.readInt(stream);
            this.key = StreamingUtils.readTLBytes(stream, context);
            this.iv = StreamingUtils.readTLBytes(stream, context);
        }

        public override int getClassId() => 
            0x57e0a9cb;

        public virtual int getDuration() => 
            this.duration;

        public virtual TLBytes getIv() => 
            this.iv;

        public virtual TLBytes getKey() => 
            this.key;

        public virtual string getMimeType() => 
            this.mimeType;

        public virtual int getSize() => 
            this.size;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x59, 0x6c, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.duration, stream);
            StreamingUtils.writeTLString(this.mimeType, stream);
            StreamingUtils.writeInt(this.size, stream);
            StreamingUtils.writeTLBytes(this.key, stream);
            StreamingUtils.writeTLBytes(this.iv, stream);
        }

        public virtual void setDuration(int duration)
        {
            this.duration = duration;
        }

        public virtual void setIv(TLBytes iv)
        {
            this.iv = iv;
        }

        public virtual void setKey(TLBytes key)
        {
            this.key = key;
        }

        public virtual void setMimeType(string mimeType)
        {
            this.mimeType = mimeType;
        }

        public virtual void setSize(int size)
        {
            this.size = size;
        }

        public override string toString() => 
            "decryptedMessageMediaAudio#57e0a9cb";
    }
}

