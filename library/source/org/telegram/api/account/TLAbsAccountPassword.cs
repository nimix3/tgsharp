namespace org.telegram.api.account
{
    using IKVM.Attributes;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public abstract class TLAbsAccountPassword : TLObject
    {
        protected internal string emailUnconfirmedPattern;
        protected internal TLBytes newSalt;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xaf, 0x68 })]
        protected internal TLAbsAccountPassword()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAbsAccountPassword(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public virtual string getEmailUnconfirmedPattern() => 
            this.emailUnconfirmedPattern;

        public virtual TLBytes getNewSalt() => 
            this.newSalt;

        public virtual void setEmailUnconfirmedPattern(string emailUnconfirmedPattern)
        {
            this.emailUnconfirmedPattern = emailUnconfirmedPattern;
        }

        public virtual void setNewSalt(TLBytes newSalt)
        {
            this.newSalt = newSalt;
        }
    }
}

