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
    public class TLDecryptedMessageMediaDocument : TLAbsDecryptedMessageMedia
    {
        public const int CLASS_ID = -1332395189;
        private string fileName;
        private TLBytes iv;
        private TLBytes key;
        private string mimeType;
        private int size;
        private TLBytes thumb;
        private int thumbH;
        private int thumbW;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb9, 0x68 })]
        public TLDecryptedMessageMediaDocument()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLDecryptedMessageMediaDocument(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 160, 0x61, 0x6d, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6d, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.thumb = StreamingUtils.readTLBytes(stream, context);
            this.thumbW = StreamingUtils.readInt(stream);
            this.thumbH = StreamingUtils.readInt(stream);
            this.fileName = StreamingUtils.readTLString(stream);
            this.mimeType = StreamingUtils.readTLString(stream);
            this.size = StreamingUtils.readInt(stream);
            this.key = StreamingUtils.readTLBytes(stream, context);
            this.iv = StreamingUtils.readTLBytes(stream, context);
        }

        public override int getClassId() => 
            -1332395189;

        public virtual string getFileName() => 
            this.fileName;

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

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 160, 0x54, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLBytes(this.thumb, stream);
            StreamingUtils.writeInt(this.thumbW, stream);
            StreamingUtils.writeInt(this.thumbH, stream);
            StreamingUtils.writeTLString(this.fileName, stream);
            StreamingUtils.writeTLString(this.mimeType, stream);
            StreamingUtils.writeInt(this.size, stream);
            StreamingUtils.writeTLBytes(this.key, stream);
            StreamingUtils.writeTLBytes(this.iv, stream);
        }

        public virtual void setFileName(string fileName)
        {
            this.fileName = fileName;
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

        public override string toString() => 
            "decryptedMessageMediaDocument#b095434b";
    }
}

