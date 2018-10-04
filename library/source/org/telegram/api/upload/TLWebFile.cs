namespace org.telegram.api.upload
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using org.telegram.api.storage.file;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLWebFile : TLObject
    {
        private TLBytes bytes;
        public const int CLASS_ID = 0x21e753bc;
        private TLAbsFileType fileType;
        private string mimeType;
        private int mTime;
        private int size;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa9, 0x68 })]
        public TLWebFile()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLWebFile(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x10, 0x6c, 0x6c, 0x77, 0x6c, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.size = StreamingUtils.readInt(stream);
            this.mimeType = StreamingUtils.readTLString(stream);
            this.fileType = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLAbsFileType>.Value);
            this.mTime = StreamingUtils.readInt(stream);
            this.bytes = StreamingUtils.readTLBytes(stream, context);
        }

        public virtual TLBytes getBytes() => 
            this.bytes;

        public override int getClassId() => 
            0x21e753bc;

        public virtual TLAbsFileType getFileType() => 
            this.fileType;

        public virtual string getMimeType() => 
            this.mimeType;

        public virtual int getmTime() => 
            this.mTime;

        public virtual int getSize() => 
            this.size;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 7, 0x6c, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.size, stream);
            StreamingUtils.writeTLString(this.mimeType, stream);
            StreamingUtils.writeTLObject(this.fileType, stream);
            StreamingUtils.writeInt(this.mTime, stream);
            StreamingUtils.writeTLBytes(this.bytes, stream);
        }

        public override string toString() => 
            "upload.webFile#21e753bc";
    }
}

