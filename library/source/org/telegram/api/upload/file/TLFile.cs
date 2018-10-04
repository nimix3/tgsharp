namespace org.telegram.api.upload.file
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.api.storage.file;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLFile : TLAbsFile
    {
        private TLBytes bytes;
        public const int CLASS_ID = 0x96a18d5;
        private int mtime;
        private TLAbsFileType type;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xab, 0x68 })]
        public TLFile()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLFile(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x31, 0x72, 0x6c, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.type = StreamingUtils.readTLObject(stream, context);
            this.mtime = StreamingUtils.readInt(stream);
            this.bytes = StreamingUtils.readTLBytes(stream, context);
        }

        public virtual TLBytes getBytes() => 
            this.bytes;

        public override int getClassId() => 
            0x96a18d5;

        public virtual int getMtime() => 
            this.mtime;

        public virtual TLAbsFileType getType() => 
            this.type;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x2a, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.type, stream);
            StreamingUtils.writeInt(this.mtime, stream);
            StreamingUtils.writeTLBytes(this.bytes, stream);
        }

        public virtual void setBytes(TLBytes value)
        {
            this.bytes = value;
        }

        public virtual void setMtime(int value)
        {
            this.mtime = value;
        }

        public virtual void setType(TLAbsFileType value)
        {
            this.type = value;
        }

        public override string toString() => 
            "upload.file#96a18d5";
    }
}

