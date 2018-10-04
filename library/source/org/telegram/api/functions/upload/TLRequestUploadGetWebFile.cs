namespace org.telegram.api.functions.upload
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using java.lang;
    using org.telegram.api.input.paymentapi;
    using org.telegram.api.upload;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/api/upload/TLWebFile;>;")]
    public class TLRequestUploadGetWebFile : TLMethod
    {
        public const int CLASS_ID = 0x24e6818d;
        private int limit;
        private TLInputWebFileLocation location;
        private int offset;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa1, 0x68 })]
        public TLRequestUploadGetWebFile()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestUploadGetWebFile(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(11)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 20, 0x77, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.location = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLInputWebFileLocation>.Value);
            this.offset = StreamingUtils.readInt(stream);
            this.limit = StreamingUtils.readInt(stream);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 170, 0x68, 0x63, 0x70, 0x68, 0x67, 0x7f, 10 })]
        public virtual TLWebFile deserializeResponse(InputStream stream, TLContext context)
        {
            TLObject obj2 = StreamingUtils.readTLObject(stream, context);
            if (obj2 == null)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IOException("Unable to parse response");
            }
            if (obj2 is TLWebFile)
            {
                return (TLWebFile) obj2;
            }
            Throwable.__<suppressFillInStackTrace>();
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected ").append(ClassLiteral<TLWebFile>.Value.getCanonicalName()).append(", got: ").append(Object.instancehelper_getClass(obj2).getCanonicalName()).toString());
        }

        public override int getClassId() => 
            0x24e6818d;

        public virtual int getLimit() => 
            this.limit;

        public virtual TLInputWebFileLocation getLocation() => 
            this.location;

        public virtual int getOffset() => 
            this.offset;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 13, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.location, stream);
            StreamingUtils.writeInt(this.offset, stream);
            StreamingUtils.writeInt(this.limit, stream);
        }

        public virtual void setLimit(int limit)
        {
            this.limit = limit;
        }

        public virtual void setLocation(TLInputWebFileLocation location)
        {
            this.location = location;
        }

        public virtual void setOffset(int offset)
        {
            this.offset = offset;
        }

        public override string toString() => 
            "upload.getWebFile#24e6818d";
    }
}

