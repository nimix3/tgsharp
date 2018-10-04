namespace org.telegram.api.engine
{
    using IKVM.Attributes;
    using java.io;
    using java.lang;
    using java.util.zip;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("<T:Lorg/telegram/tl/TLObject;>Lorg/telegram/tl/TLMethod<TT;>;")]
    public class GzipRequest : TLMethod
    {
        private const int CLASS_ID = 0x3072cfa1;
        [Signature("Lorg/telegram/tl/TLMethod<TT;>;")]
        private TLMethod method;

        [MethodImpl(MethodImplOptions.NoInlining), Signature("(Lorg/telegram/tl/TLMethod<TT;>;)V"), LineNumberTable(new byte[] { 0x9f, 0xad, 0x68, 0x67 })]
        public GzipRequest(TLMethod method)
        {
            this.method = method;
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected GzipRequest(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(0x3a)]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            Throwable.__<suppressFillInStackTrace>();
            throw new IOException("Unsupported operation");
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Signature("(Ljava/io/InputStream;Lorg/telegram/tl/TLContext;)TT;"), LineNumberTable(0x25)]
        public override TLObject deserializeResponse(InputStream stream, TLContext context) => 
            this.method.deserializeResponse(stream, context);

        public override int getClassId() => 
            0x3072cfa1;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xbd, 0x66, 0x67, 0x6c, 0x66, 0x66, 0x67, 0x69 })]
        public override void serializeBody(OutputStream stream)
        {
            ByteArrayOutputStream stream2 = new ByteArrayOutputStream();
            GZIPOutputStream stream3 = new GZIPOutputStream(stream2);
            this.method.serialize(stream3);
            stream3.flush();
            stream3.close();
            StreamingUtils.writeTLBytes(stream2.toByteArray(), stream);
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x3f)]
        public override string toString() => 
            new StringBuilder().append("gzip<").append(this.method).append(">").toString();
    }
}

