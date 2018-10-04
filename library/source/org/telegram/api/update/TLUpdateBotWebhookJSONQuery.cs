namespace org.telegram.api.update
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using org.telegram.api;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLUpdateBotWebhookJSONQuery : TLAbsUpdate
    {
        public const int CLASS_ID = -1684914010;
        private TLDataJSON data;
        private long queryId;
        private int timeout;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb2, 0x68 })]
        public TLUpdateBotWebhookJSONQuery()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLUpdateBotWebhookJSONQuery(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 14, 0x6c, 0x77, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.queryId = StreamingUtils.readLong(stream);
            this.data = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLDataJSON>.Value);
            this.timeout = StreamingUtils.readInt(stream);
        }

        public override int getClassId() => 
            -1684914010;

        public virtual TLDataJSON getData() => 
            this.data;

        public virtual long getQueryId() => 
            this.queryId;

        public virtual int getTimeout() => 
            this.timeout;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 7, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeLong(this.queryId, stream);
            StreamingUtils.writeTLObject(this.data, stream);
            StreamingUtils.writeInt(this.timeout, stream);
        }

        public override string toString() => 
            "updateBotWebhookJSONQuery#9b9240a6";
    }
}

