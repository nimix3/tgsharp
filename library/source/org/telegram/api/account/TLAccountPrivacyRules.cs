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
    public class TLAccountPrivacyRules : TLObject
    {
        public const int CLASS_ID = 0x554abb6f;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/privacy/privacyrule/TLAbsPrivacyRule;>;")]
        private TLVector rules;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLAbsUser;>;")]
        private TLVector users;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb3, 0x68 })]
        public TLAccountPrivacyRules()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAccountPrivacyRules(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x2a, 0x6d, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.rules = StreamingUtils.readTLVector(stream, context);
            this.users = StreamingUtils.readTLVector(stream, context);
        }

        public override int getClassId() => 
            0x554abb6f;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/privacy/privacyrule/TLAbsPrivacyRule;>;")]
        public virtual TLVector getRules() => 
            this.rules;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLAbsUser;>;")]
        public virtual TLVector getUsers() => 
            this.users;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x22, 0x6c, 0x8e })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLVector(this.rules, stream);
            StreamingUtils.writeTLVector(this.users, stream);
        }

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/privacy/privacyrule/TLAbsPrivacyRule;>;)V")]
        public virtual void setRules(TLVector rules)
        {
            this.rules = rules;
        }

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLAbsUser;>;)V")]
        public virtual void setUsers(TLVector users)
        {
            this.users = users;
        }

        public override string toString() => 
            "account.PrivacyRules#554abb6f";
    }
}

