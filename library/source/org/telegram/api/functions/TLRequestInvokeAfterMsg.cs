namespace org.telegram.api.functions
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/tl/TLObject;>;")]
    public class TLRequestInvokeAfterMsg : TLMethod
    {
        public const int CLASS_ID = -878758099;
        private long msgId;
        private TLMethod query;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 170, 0x68 })]
        public TLRequestInvokeAfterMsg()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestInvokeAfterMsg(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x26, 0x6c, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.msgId = StreamingUtils.readLong(stream);
            this.query = StreamingUtils.readTLMethod(stream, context);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(0x27)]
        public override TLObject deserializeResponse(InputStream stream, TLContext context) => 
            this.query.deserializeResponse(stream, context);

        public override int getClassId() => 
            -878758099;

        public virtual long getMsgId() => 
            this.msgId;

        public virtual TLMethod getQuery() => 
            this.query;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x1f, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeLong(this.msgId, stream);
            StreamingUtils.writeTLMethod(this.query, stream);
        }

        public virtual void setMsgId(long value)
        {
            this.msgId = value;
        }

        public virtual void setQuery(TLMethod value)
        {
            this.query = value;
        }

        public override string toString() => 
            "invokeAfterMsg#cb9f372d";
    }
}

