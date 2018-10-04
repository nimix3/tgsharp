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
    public class TLAccountPassword : TLAbsAccountPassword
    {
        public const int CLASS_ID = 0x7c18141c;
        private TLBytes currentSalt;
        private bool hasRecovery;
        private string hint;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 180, 0xe8, 0x39, 0xeb, 0x48 })]
        public TLAccountPassword()
        {
            this.hint = "";
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAccountPassword(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x3f, 0x6d, 0x6d, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.currentSalt = StreamingUtils.readTLBytes(stream, context);
            base.newSalt = StreamingUtils.readTLBytes(stream, context);
            this.hint = StreamingUtils.readTLString(stream);
            this.hasRecovery = StreamingUtils.readTLBool(stream);
            base.emailUnconfirmedPattern = StreamingUtils.readTLString(stream);
        }

        public override int getClassId() => 
            0x7c18141c;

        public virtual TLBytes getCurrentSalt() => 
            this.currentSalt;

        public virtual string getHint() => 
            this.hint;

        public virtual bool isHasRecovery() => 
            this.hasRecovery;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x35, 0x6c, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLBytes(this.currentSalt, stream);
            StreamingUtils.writeTLBytes(base.newSalt, stream);
            StreamingUtils.writeTLString(this.hint, stream);
            StreamingUtils.writeTLBool(this.hasRecovery, stream);
            StreamingUtils.writeTLString(base.emailUnconfirmedPattern, stream);
        }

        public virtual void setCurrentSalt(TLBytes currentSalt)
        {
            this.currentSalt = currentSalt;
        }

        public virtual void setHasRecovery(bool hasRecovery)
        {
            int num = (int) hasRecovery;
            this.hasRecovery = (bool) num;
        }

        public virtual void setHint(string hint)
        {
            this.hint = hint;
        }

        public override string toString() => 
            "accountPassword#7c18141c";
    }
}

