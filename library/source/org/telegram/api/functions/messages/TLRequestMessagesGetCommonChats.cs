namespace org.telegram.api.functions.messages
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using java.lang;
    using org.telegram.api.input.user;
    using org.telegram.api.messages.chats;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/api/messages/chats/TLAbsMessagesChats;>;")]
    public class TLRequestMessagesGetCommonChats : TLMethod
    {
        public const int CLASS_ID = 0xd0a48c4;
        private int limit;
        private int maxId;
        private TLAbsInputUser userId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa4, 0x68 })]
        public TLRequestMessagesGetCommonChats()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestMessagesGetCommonChats(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(14)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x17, 0x77, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.userId = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLAbsInputUser>.Value);
            this.maxId = StreamingUtils.readInt(stream);
            this.limit = StreamingUtils.readInt(stream);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xad, 0x68, 0x63, 0x70, 0x68, 0x67, 0x7f, 10 })]
        public virtual TLAbsMessagesChats deserializeResponse(InputStream stream, TLContext context)
        {
            TLObject obj2 = StreamingUtils.readTLObject(stream, context);
            if (obj2 == null)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IOException("Unable to parse response");
            }
            if (obj2 is TLAbsMessagesChats)
            {
                return (TLAbsMessagesChats) obj2;
            }
            Throwable.__<suppressFillInStackTrace>();
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected ").append(ClassLiteral<TLAbsMessagesChats>.Value.getCanonicalName()).append(", got: ").append(Object.instancehelper_getClass(obj2).getCanonicalName()).toString());
        }

        public override int getClassId() => 
            0xd0a48c4;

        public virtual int getLimit() => 
            this.limit;

        public virtual int getMaxId() => 
            this.maxId;

        public virtual TLAbsInputUser getUserId() => 
            this.userId;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x10, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.userId, stream);
            StreamingUtils.writeInt(this.maxId, stream);
            StreamingUtils.writeInt(this.limit, stream);
        }

        public virtual void setLimit(int limit)
        {
            this.limit = limit;
        }

        public virtual void setMaxId(int maxId)
        {
            this.maxId = maxId;
        }

        public virtual void setUserId(TLAbsInputUser userId)
        {
            this.userId = userId;
        }

        public override string toString() => 
            "messages.getCommonChats#d0a48c4";
    }
}

