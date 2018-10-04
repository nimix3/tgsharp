namespace org.telegram.api.functions.messages
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using java.lang;
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
    public class TLRequestMessagesSendMessage : TLMethod
    {
        public const int CLASS_ID = -91733382;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/message/entity/TLAbsMessageEntity;>;")]
        private TLVector entities;
        private const int FLAG_BACKGROUND = 0x40;
        private const int FLAG_BROADCAST = 0x10;
        private const int FLAG_ENTITIES = 8;
        private const int FLAG_NOWEBPREVIEW = 2;
        private const int FLAG_REPLY = 1;
        private const int FLAG_REPLYMARKUP = 4;
        private const int FLAG_SILENT = 0x20;
        private int flags;
        private string message;
        private TLAbsInputPeer peer;
        private long randomId;
        private TLAbsReplyMarkup replyMarkup;
        private int replyToMsgId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xbc, 0x68 })]
        public TLRequestMessagesSendMessage()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestMessagesSendMessage(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(20)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 160, 0x5b, 0x6c, 0x72, 0x6a, 140, 0x6c, 0x6c, 0x6a, 0x92, 0x6a, 0x8d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.peer = StreamingUtils.readTLObject(stream, context);
            if ((this.flags & 1) != 0)
            {
                this.replyToMsgId = StreamingUtils.readInt(stream);
            }
            this.message = StreamingUtils.readTLString(stream);
            this.randomId = StreamingUtils.readLong(stream);
            if ((this.flags & 4) != 0)
            {
                this.replyMarkup = StreamingUtils.readTLObject(stream, context);
            }
            if ((this.flags & 8) != 0)
            {
                this.entities = StreamingUtils.readTLVector(stream, context);
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 5, 0x68, 0x63, 0x90, 0x68, 0x87 })]
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
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected ").append(ClassLiteral<TLAbsUpdates>.Value.getName()).append(", got: ").append(Object.instancehelper_getClass(obj2).getCanonicalName()).toString());
        }

        [LineNumberTable(new byte[] { 0x7c, 110 })]
        public virtual void disableWebPreview()
        {
            this.flags |= 2;
        }

        [LineNumberTable(new byte[] { 0x9f, 0x62, 0xa2, 0x63, 0x91, 0x8f })]
        public virtual void enableBroadcast(bool enabled)
        {
            if (enabled)
            {
                this.flags |= 0x10;
            }
            else
            {
                this.flags &= -17;
            }
        }

        public override int getClassId() => 
            -91733382;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/message/entity/TLAbsMessageEntity;>;")]
        public virtual TLVector getEntities() => 
            this.entities;

        public virtual int getFlags() => 
            this.flags;

        public virtual string getMessage() => 
            this.message;

        public virtual TLAbsInputPeer getPeer() => 
            this.peer;

        public virtual long getRandomId() => 
            this.randomId;

        public virtual TLAbsReplyMarkup getReplyMarkup() => 
            this.replyMarkup;

        public virtual int getReplyToMsgId() => 
            this.replyToMsgId;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 160, 0x4a, 0x6c, 0x6c, 0x6a, 140, 0x6c, 0x6c, 0x6a, 140, 0x6a, 0x8e })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeTLObject(this.peer, stream);
            if ((this.flags & 1) != 0)
            {
                StreamingUtils.writeInt(this.replyToMsgId, stream);
            }
            StreamingUtils.writeTLString(this.message, stream);
            StreamingUtils.writeLong(this.randomId, stream);
            if ((this.flags & 4) != 0)
            {
                StreamingUtils.writeTLObject(this.replyMarkup, stream);
            }
            if ((this.flags & 8) != 0)
            {
                StreamingUtils.writeTLVector(this.entities, stream);
            }
        }

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/message/entity/TLAbsMessageEntity;>;)V"), LineNumberTable(new byte[] { 0x77, 0x67, 110 })]
        public virtual void setEntities(TLVector entities)
        {
            this.entities = entities;
            this.flags |= 8;
        }

        public virtual void setFlags(int flags)
        {
            this.flags = flags;
        }

        public virtual void setMessage(string value)
        {
            this.message = value;
        }

        public virtual void setPeer(TLAbsInputPeer value)
        {
            this.peer = value;
        }

        public virtual void setRandomId(long value)
        {
            this.randomId = value;
        }

        public virtual void setReplyMarkup(TLAbsReplyMarkup replyMarkup)
        {
            this.replyMarkup = replyMarkup;
        }

        [LineNumberTable(new byte[] { 0x66, 110, 0x67 })]
        public virtual void setReplyToMsgId(int replyToMsgId)
        {
            this.flags |= 1;
            this.replyToMsgId = replyToMsgId;
        }

        public override string toString() => 
            "messages.sendMessage#fa88427a";
    }
}

