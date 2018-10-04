namespace org.telegram.api.functions.messages
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using org.telegram.api.input.sticker.media;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/tl/TLVector<Lorg/telegram/api/sticker/stickersetconvered/TLAbsStickerSetCovered;>;>;")]
    public class TLRequestMessagesGetAttachedStickers : TLMethod
    {
        public const int CLASS_ID = -866424884;
        private TLAbsInputStickeredMedia media;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xab, 0x68 })]
        public TLRequestMessagesGetAttachedStickers()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestMessagesGetAttachedStickers(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(0x11)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 6, 0x77 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.media = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLAbsInputStickeredMedia>.Value);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Signature("(Ljava/io/InputStream;Lorg/telegram/tl/TLContext;)Lorg/telegram/tl/TLVector<Lorg/telegram/api/sticker/stickersetconvered/TLAbsStickerSetCovered;>;"), LineNumberTable(0x26)]
        public virtual TLVector deserializeResponse(InputStream stream, TLContext context) => 
            StreamingUtils.readTLVector(stream, context, ClassLiteral<TLAbsStickerSetCovered>.Value);

        public override int getClassId() => 
            -866424884;

        public virtual TLAbsInputStickeredMedia getMedia() => 
            this.media;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 1, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.media, stream);
        }

        public virtual void setMedia(TLAbsInputStickeredMedia media)
        {
            this.media = media;
        }

        public override string toString() => 
            "messages.getAttachedStickers#cc5b67cc";
    }
}

