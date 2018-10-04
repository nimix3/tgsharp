namespace org.telegram.api.encrypted.file
{
    using IKVM.Attributes;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public abstract class TLAbsEncryptedFile : TLObject
    {
        protected internal long id;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa8, 0x68 })]
        protected internal TLAbsEncryptedFile()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAbsEncryptedFile(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public virtual long getId() => 
            this.id;

        public virtual void setId(long id)
        {
            this.id = id;
        }
    }
}

