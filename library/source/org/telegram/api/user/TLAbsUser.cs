namespace org.telegram.api.user
{
    using IKVM.Attributes;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public abstract class TLAbsUser : TLObject
    {
        protected internal int id;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(8)]
        public TLAbsUser()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAbsUser(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
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

