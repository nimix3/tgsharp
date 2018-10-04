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
    public class TLDecryptedMessageMediaVideo : TLAbsDecryptedMessageMedia
    {
        public const int CLASS_ID = 0x524a415d;
        private int duration;
        private int h;
        private TLBytes iv;
        private TLBytes key;
        private string mimeType;
        private int size;
        private TLBytes thumb;
        private int thumbH;
        private int thumbW;
        private int w;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xbb, 0x68 })]
        public TLDecryptedMessageMediaVideo()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLDecryptedMessageMediaVideo(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 160, 0x89, 0x6d, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6d, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.thumb = StreamingUtils.readTLBytes(stream, context);
            this.thumbW = StreamingUtils.readInt(stream);
            this.thumbH = StreamingUtils.readInt(stream);
            this.duration = StreamingUtils.readInt(stream);
            this.mimeType = StreamingUtils.readTLString(stream);
            this.w = StreamingUtils.readInt(stream);
            this.h = StreamingUtils.readInt(stream);
            this.size = StreamingUtils.readInt(stream);
            this.key = StreamingUtils.readTLBytes(stream, context);
            this.iv = StreamingUtils.readTLBytes(stream, context);
        }

        public override int getClassId() => 
            0x524a415d;

        public virtual int getDuration() => 
            this.duration;

        public virtual int getH() => 
            this.h;

        public virtual TLBytes getIv() => 
            this.iv;

        public virtual TLBytes getKey() => 
            this.key;

        public virtual string getMimeType() => 
            this.mimeType;

        public virtual int getSize() => 
            this.size;

        public virtual TLBytes getThumb() => 
            this.thumb;

        public virtual int getThumbH() => 
            this.thumbH;

        public virtual int getThumbW() => 
            this.thumbW;

        public virtual int getW() => 
            this.w;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 160, 0x7a, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLBytes(this.thumb, stream);
            StreamingUtils.writeInt(this.thumbW, stream);
            StreamingUtils.writeInt(this.thumbH, stream);
            StreamingUtils.writeInt(this.duration, stream);
            StreamingUtils.writeTLString(this.mimeType, stream);
            StreamingUtils.writeInt(this.w, stream);
            StreamingUtils.writeInt(this.h, stream);
            StreamingUtils.writeInt(this.size, stream);
            StreamingUtils.writeTLBytes(this.key, stream);
            StreamingUtils.writeTLBytes(this.iv, stream);
        }

        public virtual void setDuration(int duration)
        {
            this.duration = duration;
        }

        public virtual void setH(int h)
        {
            this.h = h;
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

        public virtual void setThumb(TLBytes thumb)
        {
            this.thumb = thumb;
        }

        public virtual void setThumbH(int thumbH)
        {
            this.thumbH = thumbH;
        }

        public virtual void setThumbW(int thumbW)
        {
            this.thumbW = thumbW;
        }

        public virtual void setW(int w)
        {
            this.w = w;
        }

        public override string toString() => 
            "decryptedMessageMediaVideo#524a415d";
    }
}

