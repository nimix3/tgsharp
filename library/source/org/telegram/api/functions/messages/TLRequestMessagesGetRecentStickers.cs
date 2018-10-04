namespace org.telegram.api.functions.messages
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using java.lang;
    using org.telegram.api.messages.stickers.recent;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/api/messages/stickers/recent/TLAbsMessagesRecentStickers;>;")]
    public class TLRequestMessagesGetRecentStickers : TLMethod
    {
        public const int CLASS_ID = 0x5ea192c9;
        private const int FLAG_ATTACHED = 1;
        private int flags;
        private int hash;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xae, 0x68 })]
        public TLRequestMessagesGetRecentStickers()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestMessagesGetRecentStickers(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(0x11)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x19, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.hash = StreamingUtils.readInt(stream);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb7, 0x68, 0x63, 0x90, 0x68, 0x87 })]
        public virtual TLAbsMessagesRecentStickers deserializeResponse(InputStream stream, TLContext context)
        {
            TLObject obj2 = StreamingUtils.readTLObject(stream, context);
            if (obj2 == null)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IOException("Unable to parse response");
            }
            if (obj2 is TLAbsMessagesRecentStickers)
            {
                return (TLAbsMessagesRecentStickers) obj2;
            }
            Throwable.__<suppressFillInStackTrace>();
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected ").append(ClassLiteral<TLAbsMessagesFeaturedStickers>.Value.getName()).append(", got: ").append(Object.instancehelper_getClass(obj2).getCanonicalName()).toString());
        }

        [LineNumberTable(new byte[] { 0x9f, 0x7f, 0x42, 0x63, 0x90, 0x8f })]
        public virtual void enableAttached(bool enabled)
        {
            if (enabled)
            {
                this.flags |= 1;
            }
            else
            {
                this.flags &= -2;
            }
        }

        public override int getClassId() => 
            0x5ea192c9;

        public virtual int getHash() => 
            this.hash;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x13, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeInt(this.hash, stream);
        }

        public virtual void setHash(int hash)
        {
            this.hash = hash;
        }

        public override string toString() => 
            "messages.getRecentStickers#5ea192c9";
    }
}

