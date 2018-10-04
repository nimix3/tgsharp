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
    public class TLDecryptedMessageActionRequestKey : TLDecryptedMessageAction
    {
        public const int CLASS_ID = -204906213;
        private long exchangeId;
        private TLBytes g_a;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa7, 0x68 })]
        public TLDecryptedMessageActionRequestKey()
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb0, 0x68, 0x67, 0x67 })]
        public TLDecryptedMessageActionRequestKey(long exchangeId, TLBytes g_a)
        {
            this.exchangeId = exchangeId;
            this.g_a = g_a;
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLDecryptedMessageActionRequestKey(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 40, 0x6c, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.exchangeId = StreamingUtils.readLong(stream);
            this.g_a = StreamingUtils.readTLBytes(stream, context);
        }

        public override int getClassId() => 
            -204906213;

        public virtual long getExchangeId() => 
            this.exchangeId;

        public virtual TLBytes getG_a() => 
            this.g_a;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x21, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeLong(this.exchangeId, stream);
            StreamingUtils.writeTLBytes(this.g_a, stream);
        }

        public virtual void setExchangeId(long exchangeId)
        {
            this.exchangeId = exchangeId;
        }

        public virtual void setG_a(TLBytes g_a)
        {
            this.g_a = g_a;
        }

        public override string toString() => 
            "decryptedMessageActionRequestKey#f3c9611b";
    }
}

