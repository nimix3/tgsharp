namespace org.telegram.api.update
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.api.privacy.privacykey;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLUpdatePrivacy : TLAbsUpdate
    {
        public const int CLASS_ID = -298113238;
        private TLAbsPrivacyKey key;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/privacy/privacyrule/TLAbsPrivacyRule;>;")]
        private TLVector rules;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xab, 0x68 })]
        public TLUpdatePrivacy()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLUpdatePrivacy(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 30, 0x72, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.key = StreamingUtils.readTLObject(stream, context);
            this.rules = StreamingUtils.readTLVector(stream, context);
        }

        public override int getClassId() => 
            -298113238;

        public virtual TLAbsPrivacyKey getKey() => 
            this.key;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/privacy/privacyrule/TLAbsPrivacyRule;>;")]
        public virtual TLVector getRules() => 
            this.rules;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x18, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.key, stream);
            StreamingUtils.writeTLVector(this.rules, stream);
        }

        public virtual void setKey(TLAbsPrivacyKey key)
        {
            this.key = key;
        }

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/privacy/privacyrule/TLAbsPrivacyRule;>;)V")]
        public virtual void setRules(TLVector rules)
        {
            this.rules = rules;
        }

        public override string toString() => 
            "updatePrivacy#ee3b272a";
    }
}

