namespace org.telegram.api.functions.auth
{
    using IKVM.Attributes;
    using java.io;
    using java.lang;
    using org.telegram.api.auth;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/api/auth/TLAuthorization;>;")]
    public class TLRequestAuthImportAuthorization : TLMethod
    {
        private TLBytes bytes;
        public const int CLASS_ID = -470837741;
        private int id;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xac, 0x68 })]
        public TLRequestAuthImportAuthorization()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestAuthImportAuthorization(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(0x11)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x29, 0x6c, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.id = StreamingUtils.readInt(stream);
            this.bytes = StreamingUtils.readTLBytes(stream, context);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb5, 0x68, 0x63, 0x70, 0x68, 0x67 })]
        public virtual TLAuthorization deserializeResponse(InputStream stream, TLContext context)
        {
            TLObject obj2 = StreamingUtils.readTLObject(stream, context);
            if (obj2 == null)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IOException("Unable to parse response");
            }
            if (obj2 is TLAuthorization)
            {
                return (TLAuthorization) obj2;
            }
            Throwable.__<suppressFillInStackTrace>();
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected org.telegram.api.auth.TLAuthorization, got: ").append(Object.instancehelper_getClass(obj2).getCanonicalName()).toString());
        }

        public virtual TLBytes getBytes() => 
            this.bytes;

        public override int getClassId() => 
            -470837741;

        public virtual int getId() => 
            this.id;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x23, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.id, stream);
            StreamingUtils.writeTLBytes(this.bytes, stream);
        }

        public virtual void setBytes(TLBytes value)
        {
            this.bytes = value;
        }

        public virtual void setId(int value)
        {
            this.id = value;
        }

        public override string toString() => 
            "auth.importAuthorization#e3ef9613";
    }
}

