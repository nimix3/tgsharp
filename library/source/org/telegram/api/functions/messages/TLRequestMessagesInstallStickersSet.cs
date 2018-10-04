namespace org.telegram.api.functions.messages
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using java.lang;
    using org.telegram.api.input.sticker.set;
    using org.telegram.api.messages.stickers.setintallresult;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/api/messages/stickers/setintallresult/TLAbsMessagesStickerSetInstallResult;>;")]
    public class TLRequestMessagesInstallStickersSet : TLMethod
    {
        private bool archived;
        public const int CLASS_ID = -946871200;
        private TLAbsInputStickerSet stickerSet;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xac, 0x68 })]
        public TLRequestMessagesInstallStickersSet()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestMessagesInstallStickersSet(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(0x11)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x15, 0x72, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.stickerSet = StreamingUtils.readTLObject(stream, context);
            this.archived = StreamingUtils.readTLBool(stream);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 5, 0x68, 0x63, 0x70, 0x68, 0x67 })]
        public virtual TLAbsMessagesStickerSetInstallResult deserializeResponse(InputStream stream, TLContext context)
        {
            TLObject obj2 = StreamingUtils.readTLObject(stream, context);
            if (obj2 == null)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IOException("Unable to parse response");
            }
            if (obj2 is TLAbsMessagesStickerSetInstallResult)
            {
                return (TLAbsMessagesStickerSetInstallResult) obj2;
            }
            Throwable.__<suppressFillInStackTrace>();
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected ").append(ClassLiteral<TLAbsMessagesStickerSetInstallResult>.Value.getCanonicalName()).append(", got: ").append(Object.instancehelper_getClass(obj2).getCanonicalName()).toString());
        }

        public override int getClassId() => 
            -946871200;

        public virtual TLAbsInputStickerSet getStickerSet() => 
            this.stickerSet;

        public virtual bool isArchived() => 
            this.archived;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 15, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.stickerSet, stream);
            StreamingUtils.writeTLBool(this.archived, stream);
        }

        public virtual void setArchived(bool archived)
        {
            int num = (int) archived;
            this.archived = (bool) num;
        }

        public virtual void setStickerSet(TLAbsInputStickerSet stickerSet)
        {
            this.stickerSet = stickerSet;
        }

        public override string toString() => 
            "messages.installStickerSet#c78fe460";
    }
}

