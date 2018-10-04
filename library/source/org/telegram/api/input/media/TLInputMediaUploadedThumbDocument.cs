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
    public class TLInputMediaUploadedThumbDocument : TLAbsInputMedia
    {
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/document/attribute/TLAbsDocumentAttribute;>;")]
        private TLVector attributes;
        private string caption;
        public const int CLASS_ID = 0x50d88cae;
        private TLAbsInputFile file;
        private const int FLAG_STICKERS = 1;
        private int flags;
        private string mimeType;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/input/document/TLAbsInputDocument;>;")]
        private TLVector stickers;
        private TLAbsInputFile thumb;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb3, 0x68, 0x6b })]
        public TLInputMediaUploadedThumbDocument()
        {
            this.mimeType = "";
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLInputMediaUploadedThumbDocument(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x5d, 0x6c, 0x77, 0x77, 0x6c, 0x72, 0x6c, 0x6a, 0x92 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.file = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLAbsInputFile>.Value);
            this.thumb = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLAbsInputFile>.Value);
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
            0x50d88cae;

        public virtual TLAbsInputFile getFile() => 
            this.file;

        public virtual string getMimeType() => 
            this.mimeType;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/input/document/TLAbsInputDocument;>;")]
        public virtual TLVector getStickers() => 
            this.stickers;

        public virtual TLAbsInputFile getThumb() => 
            this.thumb;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 80, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6a, 0x8e })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeTLObject(this.file, stream);
            StreamingUtils.writeTLObject(this.thumb, stream);
            StreamingUtils.writeTLString(this.mimeType, stream);
            StreamingUtils.writeTLVector(this.attributes, stream);
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

        [MethodImpl(MethodImplOptions.NoInlining), Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/input/document/TLAbsInputDocument;>;)V"), LineNumberTable(new byte[] { 70, 0x6b, 0x91, 0x8e, 0x67 })]
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

        public virtual void setThumb(TLAbsInputFile thumb)
        {
            this.thumb = thumb;
        }

        public override string toString() => 
            "inputMediaUploadedThumbDocument#50d88cae";
    }
}

