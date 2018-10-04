namespace org.telegram.api.functions.messages
{
    using IKVM.Attributes;
    using java.io;
    using java.lang;
    using org.telegram.api.input.media;
    using org.telegram.api.input.peer;
    using org.telegram.api.keyboard.replymarkup;
    using org.telegram.api.updates;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/api/updates/TLAbsUpdates;>;")]
    public class TLRequestMessagesSendMedia : TLMethod
    {
        public const int CLASS_ID = -923703407;
        private const int FLAG_BACKGROUND = 0x40;
        private const int FLAG_BROADCAST = 0x10;
        private const int FLAG_REPLY = 1;
        private const int FLAG_REPLYMARKUP = 4;
        private const int FLAG_SILENT = 0x20;
        private const int FLAG_UNUSED1 = 2;
        private const int FLAG_UNUSED3 = 8;
        private int flags;
        private TLAbsInputMedia media;
        private TLAbsInputPeer peer;
        private long randomId;
        private TLAbsReplyMarkup replyMarkup;
        private int replyToMsgId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xba, 0x68 })]
        public TLRequestMessagesSendMedia()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestMessagesSendMedia(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(0x13)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x75, 0x6c, 0x72, 0x6a, 140, 0x72, 0x6c, 0x6a, 0x92 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.peer = StreamingUtils.readTLObject(stream, context);
            if ((this.flags & 1) != 0)
            {
                this.replyToMsgId = StreamingUtils.readInt(stream);
            }
            this.media = StreamingUtils.readTLObject(stream, context);
            this.randomId = StreamingUtils.readLong(stream);
            if ((this.flags & 4) != 0)
            {
                this.replyMarkup = StreamingUtils.readTLObject(stream, context);
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 3, 0x68, 0x63, 0x70, 0x68, 0x67 })]
        public virtual TLAbsUpdates deserializeResponse(InputStream stream, TLContext context)
        {
            TLObject obj2 = StreamingUtils.readTLObject(stream, context);
            if (obj2 == null)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IOException("Unable to parse response");
            }
            if (obj2 is TLAbsUpdates)
            {
                return (TLAbsUpdates) obj2;
            }
            Throwable.__<suppressFillInStackTrace>();
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected org.telegram.api.updates.TLAbsUpdates, got: ").append(Object.instancehelper_getClass(obj2).getCanonicalName()).toString());
        }

        public override int getClassId() => 
            -923703407;

        public virtual int getFlags() => 
            this.flags;

        public virtual TLAbsInputMedia getMedia() => 
            this.media;

        public virtual TLAbsInputPeer getPeer() => 
            this.peer;

        public virtual long getRandomId() => 
            this.randomId;

        public virtual int getReplyToMsgId() => 
            this.replyToMsgId;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x67, 0x6c, 0x6c, 0x6a, 140, 0x6c, 0x6c, 0x6a, 0x8e })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeTLObject(this.peer, stream);
            if ((this.flags & 1) != 0)
            {
                StreamingUtils.writeInt(this.replyToMsgId, stream);
            }
            StreamingUtils.writeTLObject(this.media, stream);
            StreamingUtils.writeLong(this.randomId, stream);
            if ((this.flags & 4) != 0)
            {
                StreamingUtils.writeTLObject(this.replyMarkup, stream);
            }
        }

        public virtual void setFlags(int flags)
        {
            this.flags = flags;
        }

        public virtual void setMedia(TLAbsInputMedia value)
        {
            this.media = value;
        }

        public virtual void setPeer(TLAbsInputPeer value)
        {
            this.peer = value;
        }

        public virtual void setRandomId(long value)
        {
            this.randomId = value;
        }

        public virtual void setReplyToMsgId(int replyToMsgId)
        {
            this.replyToMsgId = replyToMsgId;
        }

        public override string toString() => 
            "messages.sendMedia#c8f16791";
    }
}

