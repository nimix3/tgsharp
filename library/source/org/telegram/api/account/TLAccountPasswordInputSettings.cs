namespace org.telegram.api.account
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLAccountPasswordInputSettings : TLObject
    {
        public const int CLASS_ID = -2037289493;
        private string email;
        private const int FLAG_EMAIL = 2;
        private const int FLAG_SALT = 1;
        private int flags;
        private string hint;
        private TLBytes newPasswordHash;
        private TLBytes newSalt;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 1, 0x68 })]
        public TLAccountPasswordInputSettings()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAccountPasswordInputSettings(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x74, 0x6c, 0x6a, 0x6d, 0x6d, 140, 0x6a, 140 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            if ((this.flags & 1) != 0)
            {
                this.newSalt = StreamingUtils.readTLBytes(stream, context);
                this.newPasswordHash = StreamingUtils.readTLBytes(stream, context);
                this.hint = StreamingUtils.readTLString(stream);
            }
            if ((this.flags & 2) != 0)
            {
                this.email = StreamingUtils.readTLString(stream);
            }
        }

        public override int getClassId() => 
            -2037289493;

        public virtual string getEmail() => 
            this.email;

        public virtual int getFlags() => 
            this.flags;

        public virtual string getHint() => 
            this.hint;

        public virtual TLBytes getNewPasswordHash() => 
            this.newPasswordHash;

        public virtual TLBytes getNewSalt() => 
            this.newSalt;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x66, 0x6c, 0x6a, 0x6c, 0x6c, 140, 0x6a, 0x8e })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            if ((this.flags & 1) != 0)
            {
                StreamingUtils.writeTLBytes(this.newSalt, stream);
                StreamingUtils.writeTLBytes(this.newPasswordHash, stream);
                StreamingUtils.writeTLString(this.hint, stream);
            }
            if ((this.flags & 2) != 0)
            {
                StreamingUtils.writeTLString(this.email, stream);
            }
        }

        public virtual void setEmail(string email)
        {
            this.email = email;
        }

        public virtual void setFlags(int flags)
        {
            this.flags = flags;
        }

        public virtual void setHint(string hint)
        {
            this.hint = hint;
        }

        public virtual void setNewPasswordHash(TLBytes newPasswordHash)
        {
            this.newPasswordHash = newPasswordHash;
        }

        public virtual void setNewSalt(TLBytes newSalt)
        {
            this.newSalt = newSalt;
        }

        public override string toString() => 
            "accountPasswordInputSettings#86916deb";
    }
}

