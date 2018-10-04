namespace org.telegram.api.functions.messages
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using java.lang;
    using org.telegram.api.input.peer;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/tl/TLBool;>;")]
    public class TLRequestMessagesSaveDraft : TLMethod
    {
        public const int CLASS_ID = -1137057461;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/message/entity/TLAbsMessageEntity;>;")]
        private TLVector entitites;
        private const int FLAG_ENTITIES = 8;
        private const int FLAG_NO_WEBPAGE = 2;
        private const int FLAG_REPLY_TO_MSG_ID = 1;
        private const int FLAG_UNUSED_2 = 4;
        private int flags;
        private string message;
        private TLAbsInputPeer peer;
        private int replyToMsgId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb6, 0x68 })]
        public TLRequestMessagesSaveDraft()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestMessagesSaveDraft(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(0x13)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x42, 0x6c, 0x6a, 140, 0x77, 0x6c, 0x6a, 0x92 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            if ((this.flags & 1) != 0)
            {
                this.replyToMsgId = StreamingUtils.readInt(stream);
            }
            this.peer = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLAbsInputPeer>.Value);
            this.message = StreamingUtils.readTLString(stream);
            if ((this.flags & 8) != 0)
            {
                this.entitites = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLAbsMessageEntity>.Value);
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xbf, 0x68, 0x63, 0x90, 0x68, 0x87 })]
        public virtual TLBool deserializeResponse(InputStream stream, TLContext context)
        {
            TLObject obj2 = StreamingUtils.readTLObject(stream, context);
            if (obj2 == null)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IOException("Unable to parse response");
            }
            if (obj2 is TLBool)
            {
                return (TLBool) obj2;
            }
            Throwable.__<suppressFillInStackTrace>();
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected ").append(ClassLiteral<TLBool>.Value.getName()).append(", got: ").append(Object.instancehelper_getClass(obj2).getCanonicalName()).toString());
        }

        [LineNumberTable(new byte[] { 0x30, 110 })]
        public virtual void disableWebPreview()
        {
            this.flags |= 2;
        }

        public override int getClassId() => 
            -1137057461;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/message/entity/TLAbsMessageEntity;>;")]
        public virtual TLVector getEntitites() => 
            this.entitites;

        public virtual string getMessage() => 
            this.message;

        public virtual TLAbsInputPeer getPeer() => 
            this.peer;

        public virtual int getReplyToMsgId() => 
            this.replyToMsgId;

        public virtual bool hasWebPreview() => 
            ((this.flags & 2) == 0);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x35, 0x6c, 0x6a, 140, 0x6c, 0x6c, 0x6a, 0x8e })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            if ((this.flags & 1) != 0)
            {
                StreamingUtils.writeInt(this.replyToMsgId, stream);
            }
            StreamingUtils.writeTLObject(this.peer, stream);
            StreamingUtils.writeTLString(this.message, stream);
            if ((this.flags & 8) != 0)
            {
                StreamingUtils.writeTLVector(this.entitites, stream);
            }
        }

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/message/entity/TLAbsMessageEntity;>;)V"), LineNumberTable(new byte[] { 0x27, 110, 0x67 })]
        public virtual void setEntitites(TLVector entitites)
        {
            this.flags |= 8;
            this.entitites = entitites;
        }

        public virtual void setMessage(string message)
        {
            this.message = message;
        }

        public virtual void setPeer(TLAbsInputPeer peer)
        {
            this.peer = peer;
        }

        [LineNumberTable(new byte[] { 14, 110, 0x67 })]
        public virtual void setReplyToMsgId(int replyToMsgId)
        {
            this.flags |= 1;
            this.replyToMsgId = replyToMsgId;
        }

        public override string toString() => 
            "messages.saveDraft#bc39e14b";
    }
}

