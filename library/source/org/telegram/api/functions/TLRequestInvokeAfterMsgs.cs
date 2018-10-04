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
    public class TLRequestInvokeAfterMsgs : TLMethod
    {
        public const int CLASS_ID = 0x3dc4b4f0;
        private TLLongVector msgIds;
        private TLMethod query;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xab, 0x68 })]
        public TLRequestInvokeAfterMsgs()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestInvokeAfterMsgs(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x23, 0x6d, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.msgIds = StreamingUtils.readTLLongVector(stream, context);
            this.query = StreamingUtils.readTLMethod(stream, context);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(0x26)]
        public override TLObject deserializeResponse(InputStream stream, TLContext context) => 
            this.query.deserializeResponse(stream, context);

        public override int getClassId() => 
            0x3dc4b4f0;

        public virtual TLLongVector getMsgIds() => 
            this.msgIds;

        public virtual TLMethod getQuery() => 
            this.query;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x1d, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLVector(this.msgIds, stream);
            StreamingUtils.writeTLMethod(this.query, stream);
        }

        public virtual void setMsgIds(TLLongVector value)
        {
            this.msgIds = value;
        }

        public virtual void setQuery(TLMethod value)
        {
            this.query = value;
        }

        public override string toString() => 
            "invokeAfterMsgs#3dc4b4f0";
    }
}

