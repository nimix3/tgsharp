namespace org.telegram.tl
{
    using IKVM.Attributes;
    using java.io;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("<T:Lorg/telegram/tl/TLObject;>Lorg/telegram/tl/TLObject;")]
    public abstract class TLMethod : TLObject
    {
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(13)]
        public TLMethod()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLMethod(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [Signature("(Lorg/telegram/tl/TLObject;)TT;")]
        public virtual TLObject castResponse(TLObject response) => 
            response;

        [Throws(new string[] { "java.io.IOException" }), Signature("(Ljava/io/InputStream;Lorg/telegram/tl/TLContext;)TT;")]
        public abstract TLObject deserializeResponse(InputStream @is, TLContext tlc);
        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Signature("([BLorg/telegram/tl/TLContext;)TT;"), LineNumberTable(15)]
        public virtual TLObject deserializeResponse(byte[] data, TLContext context) => 
            this.deserializeResponse((InputStream) new ByteArrayInputStream(data), context);
    }
}

