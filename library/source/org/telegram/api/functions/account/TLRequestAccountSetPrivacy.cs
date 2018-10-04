namespace org.telegram.api.functions.account
{
    using IKVM.Attributes;
    using java.io;
    using java.lang;
    using org.telegram.api.account;
    using org.telegram.api.input.privacy.inputprivacykey;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/api/account/TLAccountPrivacyRules;>;")]
    public class TLRequestAccountSetPrivacy : TLMethod
    {
        public const int CLASS_ID = -906486552;
        private TLAbsInputPrivacyKey key;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/input/privacy/inputprivacyrule/TLAbsInputPrivacyRule;>;")]
        private TLVector rules;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xae, 0x68 })]
        public TLRequestAccountSetPrivacy()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestAccountSetPrivacy(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(0x13)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x2b, 0x72, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.key = StreamingUtils.readTLObject(stream, context);
            this.rules = StreamingUtils.readTLVector(stream, context);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb7, 0x68, 0x63, 0x70, 0x68, 0x67 })]
        public virtual TLAccountPrivacyRules deserializeResponse(InputStream stream, TLContext context)
        {
            TLObject obj2 = StreamingUtils.readTLObject(stream, context);
            if (obj2 == null)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IOException("Unable to parse response");
            }
            if (obj2 is TLAccountPrivacyRules)
            {
                return (TLAccountPrivacyRules) obj2;
            }
            Throwable.__<suppressFillInStackTrace>();
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected org.telegram.api.account.TLAccountPrivacyRules, got: ").append(Object.instancehelper_getClass(obj2).getCanonicalName()).toString());
        }

        public override int getClassId() => 
            -906486552;

        public virtual TLAbsInputPrivacyKey getKey() => 
            this.key;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/input/privacy/inputprivacyrule/TLAbsInputPrivacyRule;>;")]
        public virtual TLVector getRules() => 
            this.rules;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x25, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.key, stream);
            StreamingUtils.writeTLVector(this.rules, stream);
        }

        public virtual void setKey(TLAbsInputPrivacyKey key)
        {
            this.key = key;
        }

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/input/privacy/inputprivacyrule/TLAbsInputPrivacyRule;>;)V")]
        public virtual void setRules(TLVector rules)
        {
            this.rules = rules;
        }

        public override string toString() => 
            "account.setPrivacy#c9f81ce8";
    }
}

