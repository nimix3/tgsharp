namespace org.telegram.api.functions.photos
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using java.lang;
    using org.telegram.api.input.user;
    using org.telegram.api.photos;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/api/photos/TLAbsPhotos;>;")]
    public class TLRequestPhotosGetUserPhotos : TLMethod
    {
        public const int CLASS_ID = -1848823128;
        private int limit;
        private long maxId;
        private int offset;
        private TLAbsInputUser userId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xae, 0x68 })]
        public TLRequestPhotosGetUserPhotos()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestPhotosGetUserPhotos(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(0x11)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x53, 0x72, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.userId = StreamingUtils.readTLObject(stream, context);
            this.offset = StreamingUtils.readInt(stream);
            this.maxId = StreamingUtils.readLong(stream);
            this.limit = StreamingUtils.readInt(stream);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb7, 0x68, 0x63, 0x90, 0x68, 0x87 })]
        public virtual TLAbsPhotos deserializeResponse(InputStream stream, TLContext context)
        {
            TLObject obj2 = StreamingUtils.readTLObject(stream, context);
            if (obj2 == null)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IOException("Unable to parse response");
            }
            if (obj2 is TLAbsPhotos)
            {
                return (TLAbsPhotos) obj2;
            }
            Throwable.__<suppressFillInStackTrace>();
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected ").append(ClassLiteral<TLAbsPhotos>.Value.getName()).append(", got: ").append(Object.instancehelper_getClass(obj2).getCanonicalName()).toString());
        }

        public override int getClassId() => 
            -1848823128;

        public virtual int getLimit() => 
            this.limit;

        public virtual long getMaxId() => 
            this.maxId;

        public virtual int getOffset() => 
            this.offset;

        public virtual TLAbsInputUser getUserId() => 
            this.userId;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x4b, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.userId, stream);
            StreamingUtils.writeInt(this.offset, stream);
            StreamingUtils.writeLong(this.maxId, stream);
            StreamingUtils.writeInt(this.limit, stream);
        }

        public virtual void setLimit(int value)
        {
            this.limit = value;
        }

        public virtual void setMaxId(long value)
        {
            this.maxId = value;
        }

        public virtual void setOffset(int value)
        {
            this.offset = value;
        }

        public virtual void setUserId(TLAbsInputUser value)
        {
            this.userId = value;
        }

        public override string toString() => 
            "photos.getUserPhotos#91cd32a8";
    }
}

