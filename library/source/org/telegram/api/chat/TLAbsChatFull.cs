namespace org.telegram.api.chat
{
    using IKVM.Attributes;
    using org.telegram.api.chat.invite;
    using org.telegram.api.peer.notify.settings;
    using org.telegram.api.photo;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public abstract class TLAbsChatFull : TLObject
    {
        protected internal TLAbsChatInvite exportedInvite;
        protected internal int id;
        protected internal TLAbsPeerNotifySettings notifySettings;
        protected internal TLAbsPhoto photo;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa4, 0x68 })]
        protected internal TLAbsChatFull()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAbsChatFull(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public virtual TLAbsChatInvite getExportedInvite() => 
            this.exportedInvite;

        public virtual int getId() => 
            this.id;

        public virtual TLAbsPeerNotifySettings getNotifySettings() => 
            this.notifySettings;

        public virtual TLAbsPhoto getPhoto() => 
            this.photo;

        public virtual void setExportedInvite(TLAbsChatInvite exportedInvite)
        {
            this.exportedInvite = exportedInvite;
        }

        public virtual void setId(int id)
        {
            this.id = id;
        }

        public virtual void setNotifySettings(TLAbsPeerNotifySettings notifySettings)
        {
            this.notifySettings = notifySettings;
        }

        public virtual void setPhoto(TLAbsPhoto photo)
        {
            this.photo = photo;
        }
    }
}

