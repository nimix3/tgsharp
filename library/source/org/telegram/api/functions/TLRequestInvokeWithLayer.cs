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
    public class TLRequestInvokeWithLayer : TLMethod
    {
        public const int CLASS_ID = -627372787;
        private const int layer = 0x42;
        private TLMethod query;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 170, 0x68 })]
        public TLRequestInvokeWithLayer()
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb3, 0x68, 0x67 })]
        public TLRequestInvokeWithLayer(TLMethod query)
        {
            this.query = query;
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestInvokeWithLayer(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x1a, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.query = StreamingUtils.readTLMethod(stream, context);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(0x2f)]
        public override TLObject deserializeResponse(InputStream stream, TLContext context) => 
            this.query.deserializeResponse(stream, context);

        public override int getClassId() => 
            -627372787;

        public virtual TLMethod getQuery() => 
            this.query;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 20, 0x68, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(0x42, stream);
            StreamingUtils.writeTLMethod(this.query, stream);
        }

        public virtual void setQuery(TLMethod value)
        {
            this.query = value;
        }

        public override string toString() => 
            "invokeWithLayer#da9b0d0d";
    }
}

