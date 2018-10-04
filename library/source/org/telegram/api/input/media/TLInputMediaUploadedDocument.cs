namespace org.telegram.api.input.media
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using org.telegram.api.input.file;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLInputMediaUploadedDocument : TLAbsInputMedia
    {
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/document/attribute/TLAbsDocumentAttribute;>;")]
        private TLVector attributes;
        private string caption;
        public const int CLASS_ID = -797904407;
        private TLAbsInputFile file;
        private const int FLAG_STICKERS = 1;
        private int flags;
        private string mimeType;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/input/document/TLAbsInputDocument;>;")]
        private TLVector stickers;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb2, 0xe8, 0x38, 0xeb, 0x49, 0x6b })]
        public TLInputMediaUploadedDocument()
        {
            this.attributes = new TLVector();
            this.mimeType = "";
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLInputMediaUploadedDocument(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x53, 0x6c, 0x72, 0x6c, 0x72, 0x6c, 0x6a, 0x92 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.file = StreamingUtils.readTLObject(stream, context);
            this.mimeType = StreamingUtils.readTLString(stream);
            this.attributes = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLAbsDocumentAttribute>.Value);
            this.caption = StreamingUtils.readTLString(stream);
            if ((this.flags & 1) != 0)
            {
                this.stickers = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLAbsInputDocument>.Value);
            }
        }

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/document/attribute/TLAbsDocumentAttribute;>;")]
        public virtual TLVector getAttributes() => 
            this.attributes;

        public virtual string getCaption() => 
            this.caption;

        public override int getClassId() => 
            -797904407;

        public virtual TLAbsInputFile getFile() => 
            this.file;

        public virtual string getMimeType() => 
            this.mimeType;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/input/document/TLAbsInputDocument;>;")]
        public virtual TLVector getStickers() => 
            this.stickers;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x47, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6a, 0x8e })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeTLObject(this.file, stream);
            StreamingUtils.writeTLString(this.mimeType, stream);
            StreamingUtils.writeTLObject(this.attributes, stream);
            StreamingUtils.writeTLString(this.caption, stream);
            if ((this.flags & 1) != 0)
            {
                StreamingUtils.writeTLVector(this.stickers, stream);
            }
        }

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/document/attribute/TLAbsDocumentAttribute;>;)V")]
        public virtual void setAttributes(TLVector attributes)
        {
            this.attributes = attributes;
        }

        public virtual void setCaption(string caption)
        {
            this.caption = caption;
        }

        public virtual void setFile(TLAbsInputFile file)
        {
            this.file = file;
        }

        public virtual void setMimeType(string mimeType)
        {
            this.mimeType = mimeType;
        }

        [MethodImpl(MethodImplOptions.NoInlining), Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/input/document/TLAbsInputDocument;>;)V"), LineNumberTable(new byte[] { 0x3d, 0x6b, 0x91, 0x8e, 0x67 })]
        public virtual void setStickers(TLVector stickers)
        {
            if ((stickers == null) || stickers.isEmpty())
            {
                this.flags &= -2;
            }
            else
            {
                this.flags |= 1;
            }
            this.stickers = stickers;
        }

        public override string toString() => 
            "inputMediaUploadedDocument#d070f1e9";
    }
}

