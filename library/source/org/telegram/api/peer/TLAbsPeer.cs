namespace org.telegram.api.peer
{
    using IKVM.Attributes;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public abstract class TLAbsPeer : TLObject
    {
        protected internal int id;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9e, 0x68 })]
        protected internal TLAbsPeer()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAbsPeer(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
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

