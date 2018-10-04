namespace org.telegram.api.messages
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLMessagesBotCallbackAnswer : TLObject
    {
        private int cacheTime;
        public const int CLASS_ID = 0x36585ea4;
        private const int FLAG_ALERT = 2;
        private const int FLAG_HAS_URL = 8;
        private const int FLAG_MESSAGE = 1;
        private const int FLAG_URL = 4;
        private int flags;
        private string message;
        private string url;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 170, 0x68 })]
        public TLMessagesBotCallbackAnswer()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLMessagesBotCallbackAnswer(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x18, 0x6c, 0x6a, 140, 0x6a, 140, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            if ((this.flags & 1) != 0)
            {
                this.message = StreamingUtils.readTLString(stream);
            }
            if ((this.flags & 4) != 0)
            {
                this.url = StreamingUtils.readTLString(stream);
            }
            this.cacheTime = StreamingUtils.readInt(stream);
        }

        public virtual int getCacheTime() => 
            this.cacheTime;

        public override int getClassId() => 
            0x36585ea4;

        public virtual string getMessage() => 
            this.message;

        public virtual string getUrl() => 
            this.url;

        public virtual bool hasAlert() => 
            ((this.flags & 2) != 0);

        public virtual bool hasMessage() => 
            ((this.flags & 1) != 0);

        public virtual bool hasUrl() => 
            ((this.flags & 8) != 0);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 12, 0x6c, 0x6a, 140, 0x6a, 140, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            if ((this.flags & 1) != 0)
            {
                StreamingUtils.writeTLString(this.message, stream);
            }
            if ((this.flags & 4) != 0)
            {
                StreamingUtils.writeTLString(this.url, stream);
            }
            StreamingUtils.writeInt(this.cacheTime, stream);
        }

        public override string toString() => 
            "messages.botCallbackAnswer#36585ea4";
    }
}

