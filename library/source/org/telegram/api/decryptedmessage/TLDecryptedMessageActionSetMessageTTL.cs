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
    public class TLDecryptedMessageActionSetMessageTTL : TLDecryptedMessageAction
    {
        public const int CLASS_ID = -1586283796;
        private int ttlSeconds;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa6, 0x68 })]
        public TLDecryptedMessageActionSetMessageTTL()
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xae, 0x68, 0x67 })]
        public TLDecryptedMessageActionSetMessageTTL(int _ttlSeconds)
        {
            this.ttlSeconds = _ttlSeconds;
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLDecryptedMessageActionSetMessageTTL(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 15, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.ttlSeconds = StreamingUtils.readInt(stream);
        }

        public override int getClassId() => 
            -1586283796;

        public virtual int getTtlSeconds() => 
            this.ttlSeconds;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 10, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.ttlSeconds, stream);
        }

        public virtual void setTtlSeconds(int ttlSeconds)
        {
            this.ttlSeconds = ttlSeconds;
        }

        public override string toString() => 
            "decryptedMessageActionSetMessageTTL#a1733aec";
    }
}

