namespace org.telegram.api.cdn
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLCdnConfig : TLObject
    {
        public const int CLASS_ID = 0x5725e40a;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/cdn/TLCdnPublicKey;>;")]
        private TLVector publicKeys;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x10)]
        public TLCdnConfig()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLCdnConfig(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb7, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.publicKeys = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLCdnPublicKey>.Value);
        }

        public override int getClassId() => 
            0x5725e40a;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/cdn/TLCdnPublicKey;>;")]
        public virtual TLVector getPublicKeys() => 
            this.publicKeys;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb2, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLVector(this.publicKeys, stream);
        }

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/cdn/TLCdnPublicKey;>;)V")]
        public virtual void setPublicKeys(TLVector publicKeys)
        {
            this.publicKeys = publicKeys;
        }

        public override string toString() => 
            "cdnConfig#5725e40a";
    }
}

