namespace org.telegram.api.decryptedmessage
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLDecryptedMessageActionAcceptKey : TLDecryptedMessageAction
    {
        public const int CLASS_ID = 0x6fe1735b;
        private long exchangeId;
        private TLBytes g_a;
        private long KeyFingerprint;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa9, 0x68 })]
        public TLDecryptedMessageActionAcceptKey()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLDecryptedMessageActionAcceptKey(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb3, 0x68, 0x67, 0x67, 0x67 })]
        public TLDecryptedMessageActionAcceptKey(long exchangeId, TLBytes g_a, long KeyFingerprint)
        {
            this.exchangeId = exchangeId;
            this.g_a = g_a;
            this.KeyFingerprint = KeyFingerprint;
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x3f, 0x6c, 0x6d, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.exchangeId = StreamingUtils.readLong(stream);
            this.g_a = StreamingUtils.readTLBytes(stream, context);
            this.KeyFingerprint = StreamingUtils.readLong(stream);
        }

        public override int getClassId() => 
            0x6fe1735b;

        public virtual long getExchangeId() => 
            this.exchangeId;

        public virtual TLBytes getG_a() => 
            this.g_a;

        public virtual long getKeyFingerprint() => 
            this.KeyFingerprint;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x37, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeLong(this.exchangeId, stream);
            StreamingUtils.writeTLBytes(this.g_a, stream);
            StreamingUtils.writeLong(this.KeyFingerprint, stream);
        }

        public virtual void setExchangeId(long exchangeId)
        {
            this.exchangeId = exchangeId;
        }

        public virtual void setG_a(TLBytes g_a)
        {
            this.g_a = g_a;
        }

        public virtual void setKeyFingerprint(long keyFingerprint)
        {
            this.KeyFingerprint = keyFingerprint;
        }

        public override string toString() => 
            "decryptedMessageActionAcceptKey#6fe1735b";
    }
}

