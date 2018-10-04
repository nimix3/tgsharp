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
    public class TLDecryptedMessageActionAbortKey : TLDecryptedMessageAction
    {
        public const int CLASS_ID = -586814357;
        private long exchangeId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa6, 0x68 })]
        public TLDecryptedMessageActionAbortKey()
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xae, 0x68, 0x67 })]
        public TLDecryptedMessageActionAbortKey(long exchangeId)
        {
            this.exchangeId = exchangeId;
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLDecryptedMessageActionAbortKey(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x12, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.exchangeId = StreamingUtils.readLong(stream);
        }

        public override int getClassId() => 
            -586814357;

        public virtual long getExchangeId() => 
            this.exchangeId;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 12, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeLong(this.exchangeId, stream);
        }

        public virtual void setExchangeId(long exchangeId)
        {
            this.exchangeId = exchangeId;
        }

        public override string toString() => 
            "decryptedMessageActionAbortKey#dd05ec6b";
    }
}

