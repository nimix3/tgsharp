namespace org.telegram.api.contact.link
{
    using IKVM.Attributes;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public abstract class TLAbsContactLink : TLObject
    {
        protected internal bool contact;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa8, 0x68 })]
        protected internal TLAbsContactLink()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAbsContactLink(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public virtual bool isContact() => 
            this.contact;

        public virtual void setContact(bool contact)
        {
            int num = (int) contact;
            this.contact = (bool) num;
        }
    }
}

