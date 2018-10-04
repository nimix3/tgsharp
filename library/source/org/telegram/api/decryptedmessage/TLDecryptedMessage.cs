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
    public class TLDecryptedMessage : TLAbsDecryptedMessage
    {
        public const int CLASS_ID = 0x204d3878;
        private TLAbsDecryptedMessageMedia media;
        private string message;
        private int ttl;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb8, 0x68 })]
        public TLDecryptedMessage()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLDecryptedMessage(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x42, 0x6c, 0x6c, 0x6c, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            base.randomId = StreamingUtils.readLong(stream);
            this.ttl = StreamingUtils.readInt(stream);
            this.message = StreamingUtils.readTLString(stream);
            this.media = StreamingUtils.readTLObject(stream, context);
        }

        public override int getClassId() => 
            0x204d3878;

        public virtual TLAbsDecryptedMessageMedia getMedia() => 
            this.media;

        public virtual string getMessage() => 
            this.message;

        public virtual int getTtl() => 
            this.ttl;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x39, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeLong(base.randomId, stream);
            StreamingUtils.writeInt(this.ttl, stream);
            StreamingUtils.writeTLString(this.message, stream);
            StreamingUtils.writeTLObject(this.media, stream);
        }

        public virtual void setMedia(TLAbsDecryptedMessageMedia media)
        {
            this.media = media;
        }

        public virtual void setMessage(string message)
        {
            this.message = message;
        }

        public virtual void setTtl(int ttl)
        {
            this.ttl = ttl;
        }

        public override string toString() => 
            "decryptedMessage#204d3878";
    }
}

