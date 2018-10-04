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
    public class TLRequestInvokeWithoutUpdates : TLMethod
    {
        public const int CLASS_ID = -1080796745;
        private TLMethod query;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa9, 0x68 })]
        public TLRequestInvokeWithoutUpdates()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestInvokeWithoutUpdates(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 14, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.query = StreamingUtils.readTLMethod(stream, context);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(0x24)]
        public override TLObject deserializeResponse(InputStream stream, TLContext context) => 
            this.query.deserializeResponse(stream, context);

        public override int getClassId() => 
            -1080796745;

        public virtual TLMethod getQuery() => 
            this.query;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 9, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLMethod(this.query, stream);
        }

        public virtual void setQuery(TLMethod value)
        {
            this.query = value;
        }

        public override string toString() => 
            "invokeWithoutUpdates#bf9459b7";
    }
}

