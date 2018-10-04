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
    public class TLDecryptedMessageActionCommitKey : TLDecryptedMessageAction
    {
        public const int CLASS_ID = -332526693;
        private long exchangeId;
        private long keyFingerprint;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa7, 0x68 })]
        public TLDecryptedMessageActionCommitKey()
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb0, 0x68, 0x67, 0x67 })]
        public TLDecryptedMessageActionCommitKey(long exchangeId, long keyFingerprint)
        {
            this.exchangeId = exchangeId;
            this.keyFingerprint = keyFingerprint;
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLDecryptedMessageActionCommitKey(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 40, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.exchangeId = StreamingUtils.readLong(stream);
            this.keyFingerprint = StreamingUtils.readLong(stream);
        }

        public override int getClassId() => 
            -332526693;

        public virtual long getExchangeId() => 
            this.exchangeId;

        public virtual long getKeyFingerprint() => 
            this.keyFingerprint;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x21, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeLong(this.exchangeId, stream);
            StreamingUtils.writeLong(this.keyFingerprint, stream);
        }

        public virtual void setExchangeId(long exchangeId)
        {
            this.exchangeId = exchangeId;
        }

        public virtual void setKeyFingerprint(long keyFingerprint)
        {
            this.keyFingerprint = keyFingerprint;
        }

        public override string toString() => 
            "decryptedMessageActionCommitKey#ec2e0b9b";
    }
}

