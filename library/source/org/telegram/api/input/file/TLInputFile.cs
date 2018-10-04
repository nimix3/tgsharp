namespace org.telegram.api.input.file
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLInputFile : TLAbsInputFile
    {
        public const int CLASS_ID = -181407105;
        private string md5Checksum;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 170, 0xe8, 0x3a, 0xeb, 0x47 })]
        public TLInputFile()
        {
            this.md5Checksum = "";
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLInputFile(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 13, 0x6c, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            base.id = StreamingUtils.readLong(stream);
            base.parts = StreamingUtils.readInt(stream);
            base.name = StreamingUtils.readTLString(stream);
            this.md5Checksum = StreamingUtils.readTLString(stream);
        }

        public override int getClassId() => 
            -181407105;

        public virtual string getMd5Checksum() => 
            this.md5Checksum;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 5, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeLong(base.id, stream);
            StreamingUtils.writeInt(base.parts, stream);
            StreamingUtils.writeTLString(base.name, stream);
            StreamingUtils.writeTLString(this.md5Checksum, stream);
        }

        public virtual void setMd5Checksum(string md5Checksum)
        {
            this.md5Checksum = md5Checksum;
        }

        public override string toString() => 
            "inputFile#f52ff27f";
    }
}

