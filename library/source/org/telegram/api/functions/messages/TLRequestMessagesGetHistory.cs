namespace org.telegram.api.functions.messages
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using java.lang;
    using org.telegram.api.input.peer;
    using org.telegram.api.messages;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/api/messages/TLAbsMessages;>;")]
    public class TLRequestMessagesGetHistory : TLMethod
    {
        private int addOffset;
        public const int CLASS_ID = -1347868602;
        private int limit;
        private int maxId;
        private int minId;
        private int offsetDate;
        private int offsetId;
        private TLAbsInputPeer peer;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb1, 0x68 })]
        public TLRequestMessagesGetHistory()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestMessagesGetHistory(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(0x11)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x67, 0x72, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.peer = StreamingUtils.readTLObject(stream, context);
            this.offsetId = StreamingUtils.readInt(stream);
            this.offsetDate = StreamingUtils.readInt(stream);
            this.addOffset = StreamingUtils.readInt(stream);
            this.limit = StreamingUtils.readInt(stream);
            this.maxId = StreamingUtils.readInt(stream);
            this.minId = StreamingUtils.readInt(stream);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xba, 0x68, 0x63, 0x90, 0x68, 0x87 })]
        public virtual TLAbsMessages deserializeResponse(InputStream stream, TLContext context)
        {
            TLObject obj2 = StreamingUtils.readTLObject(stream, context);
            if (obj2 == null)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IOException("Unable to parse response");
            }
            if (obj2 is TLAbsMessages)
            {
                return (TLAbsMessages) obj2;
            }
            Throwable.__<suppressFillInStackTrace>();
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected ").append(ClassLiteral<TLAbsMessages>.Value.getName()).append(", got: ").append(Object.instancehelper_getClass(obj2).getCanonicalName()).toString());
        }

        public virtual int getAddOffset() => 
            this.addOffset;

        public override int getClassId() => 
            -1347868602;

        public virtual int getLimit() => 
            this.limit;

        public virtual int getMaxId() => 
            this.maxId;

        public virtual int getMinId() => 
            this.minId;

        public virtual int getOffsetDate() => 
            this.offsetDate;

        public virtual int getOffsetId() => 
            this.offsetId;

        public virtual TLAbsInputPeer getPeer() => 
            this.peer;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x5c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.peer, stream);
            StreamingUtils.writeInt(this.offsetId, stream);
            StreamingUtils.writeInt(this.offsetDate, stream);
            StreamingUtils.writeInt(this.addOffset, stream);
            StreamingUtils.writeInt(this.limit, stream);
            StreamingUtils.writeInt(this.maxId, stream);
            StreamingUtils.writeInt(this.minId, stream);
        }

        public virtual void setAddOffset(int addOffset)
        {
            this.addOffset = addOffset;
        }

        public virtual void setLimit(int value)
        {
            this.limit = value;
        }

        public virtual void setMaxId(int value)
        {
            this.maxId = value;
        }

        public virtual void setMinId(int minId)
        {
            this.minId = minId;
        }

        public virtual void setOffsetDate(int offsetDate)
        {
            this.offsetDate = offsetDate;
        }

        public virtual void setOffsetId(int offsetId)
        {
            this.offsetId = offsetId;
        }

        public virtual void setPeer(TLAbsInputPeer value)
        {
            this.peer = value;
        }

        public override string toString() => 
            "messages.getHistory#afa92846";
    }
}

