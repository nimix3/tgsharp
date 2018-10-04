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
    public class TLInputMediaUploadedPhoto : TLAbsInputMedia
    {
        private string caption;
        public const int CLASS_ID = 0x630c9af1;
        private TLAbsInputFile file;
        private const int FLAG_STICKERS = 1;
        private int flags;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/input/document/TLAbsInputDocument;>;")]
        private TLVector stickers;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xac, 0x68 })]
        public TLInputMediaUploadedPhoto()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLInputMediaUploadedPhoto(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x30, 0x6c, 0x77, 0x6c, 0x6a, 0x92 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.file = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLAbsInputFile>.Value);
            this.caption = StreamingUtils.readTLString(stream);
            if ((this.flags & 1) != 0)
            {
                this.stickers = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLAbsInputDocument>.Value);
            }
        }

        public virtual string getCaption() => 
            this.caption;

        public override int getClassId() => 
            0x630c9af1;

        public virtual TLAbsInputFile getFile() => 
            this.file;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/input/document/TLAbsInputDocument;>;")]
        public virtual TLVector getStickers() => 
            this.stickers;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x26, 0x6c, 0x6c, 0x6c, 0x6a, 0x8e })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeTLObject(this.file, stream);
            StreamingUtils.writeTLString(this.caption, stream);
            if ((this.flags & 1) != 0)
            {
                StreamingUtils.writeTLVector(this.stickers, stream);
            }
        }

        public virtual void setCaption(string caption)
        {
            this.caption = caption;
        }

        public virtual void setFile(TLAbsInputFile value)
        {
            this.file = value;
        }

        [MethodImpl(MethodImplOptions.NoInlining), Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/input/document/TLAbsInputDocument;>;)V"), LineNumberTable(new byte[] { 0x1c, 0x6b, 0x91, 0x8e, 0x67 })]
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
            "inputMediaUploadedPhoto#630c9af1";
    }
}

