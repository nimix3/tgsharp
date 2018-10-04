namespace org.telegram.api.update
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using org.telegram.api.paymentapi;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLUpdateBotShippingQuery : TLAbsUpdate
    {
        public const int CLASS_ID = -523384512;
        private TLBytes payload;
        private long queryId;
        private TLPostAddress shippingAddress;
        private int userId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 180, 0x68 })]
        public TLUpdateBotShippingQuery()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLUpdateBotShippingQuery(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x15, 0x6c, 0x6c, 0x6d, 0x77 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.queryId = StreamingUtils.readLong(stream);
            this.userId = StreamingUtils.readInt(stream);
            this.payload = StreamingUtils.readTLBytes(stream, context);
            this.shippingAddress = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLPostAddress>.Value);
        }

        public override int getClassId() => 
            -523384512;

        public virtual TLBytes getPayload() => 
            this.payload;

        public virtual long getQueryId() => 
            this.queryId;

        public virtual TLPostAddress getShippingAddress() => 
            this.shippingAddress;

        public virtual int getUserId() => 
            this.userId;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 13, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeLong(this.queryId, stream);
            StreamingUtils.writeInt(this.userId, stream);
            StreamingUtils.writeTLBytes(this.payload, stream);
            StreamingUtils.writeTLObject(this.shippingAddress, stream);
        }

        public override string toString() => 
            "updateBotShippingQuery#e0cdc940";
    }
}

