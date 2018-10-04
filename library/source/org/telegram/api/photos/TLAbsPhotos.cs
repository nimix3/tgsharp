namespace org.telegram.api.photos
{
    using IKVM.Attributes;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public abstract class TLAbsPhotos : TLObject
    {
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/photo/TLAbsPhoto;>;")]
        protected internal TLVector photos;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLAbsUser;>;")]
        protected internal TLVector users;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa7, 0x68 })]
        protected internal TLAbsPhotos()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAbsPhotos(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/photo/TLAbsPhoto;>;")]
        public virtual TLVector getPhotos() => 
            this.photos;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLAbsUser;>;")]
        public virtual TLVector getUsers() => 
            this.users;

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/photo/TLAbsPhoto;>;)V")]
        public virtual void setPhotos(TLVector value)
        {
            this.photos = value;
        }

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLAbsUser;>;)V")]
        public virtual void setUsers(TLVector value)
        {
            this.users = value;
        }
    }
}

