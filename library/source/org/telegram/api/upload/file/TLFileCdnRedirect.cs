namespace org.telegram.api.upload.file
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLFileCdnRedirect : TLAbsFile
    {
        public const int CLASS_ID = 0x1508485a;
        private int dcId;
        private TLBytes encryptionIv;
        private TLBytes encryptionKey;
        private TLBytes fileToken;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa2, 0x68 })]
        public TLFileCdnRedirect()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLFileCdnRedirect(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 3, 0x6c, 0x6d, 0x6d, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.dcId = StreamingUtils.readInt(stream);
            this.fileToken = StreamingUtils.readTLBytes(stream, context);
            this.encryptionKey = StreamingUtils.readTLBytes(stream, context);
            this.encryptionIv = StreamingUtils.readTLBytes(stream, context);
        }

        public override int getClassId() => 
            0x1508485a;

        public virtual int getDcId() => 
            this.dcId;

        public virtual TLBytes getEncryptionIv() => 
            this.encryptionIv;

        public virtual TLBytes getEncryptionKey() => 
            this.encryptionKey;

        public virtual TLBytes getFileToken() => 
            this.fileToken;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xbb, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.dcId, stream);
            StreamingUtils.writeTLBytes(this.fileToken, stream);
            StreamingUtils.writeTLBytes(this.encryptionKey, stream);
            StreamingUtils.writeTLBytes(this.encryptionIv, stream);
        }

        public override string toString() => 
            "upload.fileCdnRedirect#1508485a";
    }
}

