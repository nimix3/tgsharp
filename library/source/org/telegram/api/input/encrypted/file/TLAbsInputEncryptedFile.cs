namespace org.telegram.api.input.encrypted.file
{
    using IKVM.Attributes;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public abstract class TLAbsInputEncryptedFile : TLObject
    {
        public long accessHash;
        public long id;
        public TLBytes iv;
        public TLBytes key;
        public int keyFingerprint;
        public string md5Checksum;
        public int parts;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb9, 0x68 })]
        protected internal TLAbsInputEncryptedFile()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAbsInputEncryptedFile(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public virtual long getAccessHash() => 
            this.accessHash;

        public virtual long getId() => 
            this.id;

        public virtual TLBytes getIv() => 
            this.iv;

        public virtual TLBytes getKey() => 
            this.key;

        public virtual int getKeyFingerprint() => 
            this.keyFingerprint;

        public virtual string getMd5Checksum() => 
            this.md5Checksum;

        public virtual int getParts() => 
            this.parts;

        public virtual void setAccessHash(long accessHash)
        {
            this.accessHash = accessHash;
        }

        public virtual void setId(long id)
        {
            this.id = id;
        }

        public virtual void setIv(TLBytes iv)
        {
            this.iv = iv;
        }

        public virtual void setKey(TLBytes key)
        {
            this.key = key;
        }

        public virtual void setKeyFingerprint(int keyFingerprint)
        {
            this.keyFingerprint = keyFingerprint;
        }

        public virtual void setMd5Checksum(string md5Checksum)
        {
            this.md5Checksum = md5Checksum;
        }

        public virtual void setParts(int parts)
        {
            this.parts = parts;
        }
    }
}

