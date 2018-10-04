namespace org.telegram.api.encrypted.file
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLEncryptedFile : TLAbsEncryptedFile
    {
        private long accessHash;
        public const int CLASS_ID = 0x4a70994c;
        private int dcId;
        private int keyFingerprint;
        private int size;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 180, 0x68 })]
        public TLEncryptedFile()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLEncryptedFile(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 160, 0x44, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            base.id = StreamingUtils.readLong(stream);
            this.accessHash = StreamingUtils.readLong(stream);
            this.size = StreamingUtils.readInt(stream);
            this.dcId = StreamingUtils.readInt(stream);
            this.keyFingerprint = StreamingUtils.readInt(stream);
        }

        public virtual long getAccess_hash() => 
            this.accessHash;

        public virtual long getAccessHash() => 
            this.accessHash;

        public override int getClassId() => 
            0x4a70994c;

        public virtual int getDc_id() => 
            this.dcId;

        public virtual int getDcId() => 
            this.dcId;

        public virtual int getKey_fingerprint() => 
            this.keyFingerprint;

        public virtual int getKeyFingerprint() => 
            this.keyFingerprint;

        public virtual int getSize() => 
            this.size;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x7b, 0x6c, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeLong(base.id, stream);
            StreamingUtils.writeLong(this.accessHash, stream);
            StreamingUtils.writeInt(this.size, stream);
            StreamingUtils.writeInt(this.dcId, stream);
            StreamingUtils.writeInt(this.keyFingerprint, stream);
        }

        public virtual void setAccess_hash(long accessHash)
        {
            this.accessHash = accessHash;
        }

        public virtual void setAccessHash(long accessHash)
        {
            this.accessHash = accessHash;
        }

        public virtual void setDc_id(int dcId)
        {
            this.dcId = dcId;
        }

        public virtual void setDcId(int dcId)
        {
            this.dcId = dcId;
        }

        public virtual void setKey_fingerprint(int keyFingerprint)
        {
            this.keyFingerprint = keyFingerprint;
        }

        public virtual void setKeyFingerprint(int keyFingerprint)
        {
            this.keyFingerprint = keyFingerprint;
        }

        public virtual void setSize(int size)
        {
            this.size = size;
        }

        public override string toString() => 
            "encryptedFile#4a70994c";
    }
}

