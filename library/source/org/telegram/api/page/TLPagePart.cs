namespace org.telegram.api.page
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLPagePart : TLAbsPage
    {
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/page/block/TLAbsPageBlock;>;")]
        private TLVector blocks;
        public const int CLASS_ID = -1913754556;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/photo/TLAbsPhoto;>;")]
        private TLVector photos;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/document/TLAbsDocument;>;")]
        private TLVector videos;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa9, 0x68 })]
        public TLPagePart()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLPagePart(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 6, 0x72, 0x72, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.blocks = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLAbsPageBlock>.Value);
            this.photos = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLAbsPhoto>.Value);
            this.videos = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLAbsDocument>.Value);
        }

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/page/block/TLAbsPageBlock;>;")]
        public virtual TLVector getBlocks() => 
            this.blocks;

        public override int getClassId() => 
            -1913754556;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/photo/TLAbsPhoto;>;")]
        public virtual TLVector getPhotos() => 
            this.photos;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/document/TLAbsDocument;>;")]
        public virtual TLVector getVideos() => 
            this.videos;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xbf, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLVector(this.blocks, stream);
            StreamingUtils.writeTLVector(this.photos, stream);
            StreamingUtils.writeTLVector(this.videos, stream);
        }

        public override string toString() => 
            "pagePart#8dee6c44";
    }
}

