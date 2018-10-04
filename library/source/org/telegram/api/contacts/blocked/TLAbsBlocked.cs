namespace org.telegram.api.contacts.blocked
{
    using IKVM.Attributes;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public abstract class TLAbsBlocked : TLObject
    {
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/contact/TLContactBlocked;>;")]
        protected internal TLVector blocked;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLAbsUser;>;")]
        protected internal TLVector users;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xac, 0x68 })]
        protected internal TLAbsBlocked()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAbsBlocked(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/contact/TLContactBlocked;>;")]
        public virtual TLVector getBlocked() => 
            this.blocked;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLAbsUser;>;")]
        public virtual TLVector getUsers() => 
            this.users;

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/contact/TLContactBlocked;>;)V")]
        public virtual void setBlocked(TLVector value)
        {
            this.blocked = value;
        }

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLAbsUser;>;)V")]
        public virtual void setUsers(TLVector value)
        {
            this.users = value;
        }
    }
}

