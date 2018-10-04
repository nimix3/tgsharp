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
    public class TLRequestMessagesEditMessage : TLMethod
    {
        public const int CLASS_ID = -829299510;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/message/entity/TLAbsMessageEntity;>;")]
        private TLVector entities;
        private const int FLAG_ENTITIES = 8;
        private const int FLAG_MESSAGE = 0x800;
        private const int FLAG_NO_WEBPREVIEW = 2;
        private const int FLAG_REPLY_MARKUP = 4;
        private const int FLAG_UNUSED_0 = 1;
        private const int FLAG_UNUSED_10 = 0x400;
        private const int FLAG_UNUSED_4 = 0x10;
        private const int FLAG_UNUSED_5 = 0x20;
        private const int FLAG_UNUSED_6 = 0x40;
        private const int FLAG_UNUSED_7 = 0x80;
        private const int FLAG_UNUSED_8 = 0x100;
        private const int FLAG_UNUSED_9 = 0x200;
        private int flags;
        private int id;
        private string message;
        private TLAbsInputPeer peer;
        private TLAbsReplyMarkup replyMarkup;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0, 0x68 })]
        public TLRequestMessagesEditMessage()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestMessagesEditMessage(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(20)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x3b, 0x6c, 0x72, 0x6c, 110, 140, 0x6a, 0x92, 0x6a, 0xad })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.peer = StreamingUtils.readTLObject(stream, context);
            this.id = StreamingUtils.readInt(stream);
            if ((this.flags & 0x800) != 0)
            {
                this.message = StreamingUtils.readTLString(stream);
            }
            if ((this.flags & 4) != 0)
            {
                this.replyMarkup = StreamingUtils.readTLObject(stream, context);
            }
            if ((this.flags & 8) != 0)
            {
                this.entities = StreamingUtils.readTLVector(stream, context);
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 9, 0x68, 0x63, 0x90, 0x68, 0x87 })]
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
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected ").append(ClassLiteral<TLAbsUpdates>.Value.getName()).append(", got: ").append(Object.instancehelper_getClass(obj2).getName()).toString());
        }

        public override int getClassId() => 
            -829299510;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/message/entity/TLAbsMessageEntity;>;")]
        public virtual TLVector getEntities() => 
            this.entities;

        public virtual int getId() => 
            this.id;

        public virtual string getMessage() => 
            this.message;

        public virtual TLAbsInputPeer getPeer() => 
            this.peer;

        public virtual TLAbsReplyMarkup getReplyMarkup() => 
            this.replyMarkup;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x2a, 0x6c, 0x6c, 0x6c, 110, 140, 0x6a, 140, 0x6a, 0x8e })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeTLObject(this.peer, stream);
            StreamingUtils.writeInt(this.id, stream);
            if ((this.flags & 0x800) != 0)
            {
                StreamingUtils.writeTLString(this.message, stream);
            }
            if ((this.flags & 4) != 0)
            {
                StreamingUtils.writeTLObject(this.replyMarkup, stream);
            }
            if ((this.flags & 8) != 0)
            {
                StreamingUtils.writeTLVector(this.entities, stream);
            }
        }

        public override string toString() => 
            "messages.editMessage#ce91e4ca";
    }
}

