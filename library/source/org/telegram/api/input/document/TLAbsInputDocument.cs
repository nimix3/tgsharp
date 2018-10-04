namespace org.telegram.api.input.document
{
    using IKVM.Attributes;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public abstract class TLAbsInputDocument : TLObject
    {
        protected internal long accessHash;
        protected internal long id;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa4, 0x68 })]
        protected internal TLAbsInputDocument()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAbsInputDocument(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public virtual long getAccessHash() => 
            this.accessHash;

        public virtual long getId() => 
            this.id;

        public virtual void setAccessHash(long accessHash)
        {
            this.accessHash = accessHash;
        }

        public virtual void setId(long id)
        {
            this.id = id;
        }
    }
}

