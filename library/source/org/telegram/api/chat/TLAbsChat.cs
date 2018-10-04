namespace org.telegram.api.chat
{
    using IKVM.Attributes;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public abstract class TLAbsChat : TLObject
    {
        protected internal int id;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa8, 0x68 })]
        protected internal TLAbsChat()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAbsChat(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public virtual int getId() => 
            this.id;

        public virtual void setId(int id)
        {
            this.id = id;
        }
    }
}

