namespace org.telegram.api.functions.upload
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using java.lang;
    using org.telegram.api.upload.cdn;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/api/upload/cdn/TLAbsCdnFile;>;")]
    public class TLRequestUploadGetCdnFile : TLMethod
    {
        public const int CLASS_ID = 0x2000bcc3;
        private TLBytes fileToken;
        private int limit;
        private int offset;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 160, 0x68 })]
        public TLRequestUploadGetCdnFile()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestUploadGetCdnFile(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(10)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x13, 0x6d, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.fileToken = StreamingUtils.readTLBytes(stream, context);
            this.offset = StreamingUtils.readInt(stream);
            this.limit = StreamingUtils.readInt(stream);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xa9, 0x68, 0x63, 0x70, 0x68, 0x67, 0x7f, 10 })]
        public virtual TLAbsCdnFile deserializeResponse(InputStream stream, TLContext context)
        {
            TLObject obj2 = StreamingUtils.readTLObject(stream, context);
            if (obj2 == null)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IOException("Unable to parse response");
            }
            if (obj2 is TLAbsCdnFile)
            {
                return (TLAbsCdnFile) obj2;
            }
            Throwable.__<suppressFillInStackTrace>();
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected ").append(ClassLiteral<TLAbsCdnFile>.Value.getCanonicalName()).append(", got: ").append(Object.instancehelper_getClass(obj2).getCanonicalName()).toString());
        }

        public override int getClassId() => 
            0x2000bcc3;

        public virtual TLBytes getFileToken() => 
            this.fileToken;

        public virtual int getLimit() => 
            this.limit;

        public virtual int getOffset() => 
            this.offset;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 12, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLBytes(this.fileToken, stream);
            StreamingUtils.writeInt(this.offset, stream);
            StreamingUtils.writeInt(this.limit, stream);
        }

        public virtual void setFileToken(TLBytes fileToken)
        {
            this.fileToken = fileToken;
        }

        public virtual void setLimit(int value)
        {
            this.limit = value;
        }

        public virtual void setOffset(int offset)
        {
            this.offset = offset;
        }

        public override string toString() => 
            "upload.getCdnFile#2000bcc3";
    }
}

