namespace org.telegram.api.functions.messages
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using java.lang;
    using org.telegram.api.document;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/api/document/TLAbsDocument;>;")]
    public class TLRequestMessagesGetDocumentByHash : TLMethod
    {
        public const int CLASS_ID = 0x338e2464;
        private string mimeType;
        private TLBytes sha256;
        private int size;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xbd, 0x68 })]
        public TLRequestMessagesGetDocumentByHash()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestMessagesGetDocumentByHash(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(0x21)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x31, 0x6d, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.sha256 = StreamingUtils.readTLBytes(stream, context);
            this.size = StreamingUtils.readInt(stream);
            this.mimeType = StreamingUtils.readTLString(stream);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 6, 0x68, 0x63, 0x90, 0x68, 0x87 })]
        public virtual TLAbsDocument deserializeResponse(InputStream stream, TLContext context)
        {
            TLObject obj2 = StreamingUtils.readTLObject(stream, context);
            if (obj2 == null)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IOException("Unable to parse response");
            }
            if (obj2 is TLAbsDocument)
            {
                return (TLAbsDocument) obj2;
            }
            Throwable.__<suppressFillInStackTrace>();
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected ").append(ClassLiteral<TLAbsDocument>.Value.getCanonicalName()).append(", got: ").append(Object.instancehelper_getClass(obj2).getCanonicalName()).toString());
        }

        public override int getClassId() => 
            0x338e2464;

        public virtual string getMimeType() => 
            this.mimeType;

        public virtual TLBytes getSha256() => 
            this.sha256;

        public virtual int getSize() => 
            this.size;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x2a, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLBytes(this.sha256, stream);
            StreamingUtils.writeInt(this.size, stream);
            StreamingUtils.writeTLString(this.mimeType, stream);
        }

        public virtual void setMimeType(string mimeType)
        {
            this.mimeType = mimeType;
        }

        public virtual void setSha256(TLBytes sha256)
        {
            this.sha256 = sha256;
        }

        public virtual void setSize(int size)
        {
            this.size = size;
        }

        public override string toString() => 
            "messages.getDocumentByHash#338e2464";
    }
}

