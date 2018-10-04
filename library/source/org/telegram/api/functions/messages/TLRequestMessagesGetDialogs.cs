namespace org.telegram.api.functions.messages
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using java.lang;
    using org.telegram.api.input.peer;
    using org.telegram.api.messages.dialogs;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/api/messages/dialogs/TLAbsDialogs;>;")]
    public class TLRequestMessagesGetDialogs : TLMethod
    {
        public const int CLASS_ID = 0x191ba9c5;
        private const int FLAG_EXCLUDE_PINNED = 1;
        private int flags;
        private int limit;
        private int offsetDate;
        private int offsetId;
        private TLAbsInputPeer offsetPeer;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xab, 0x68 })]
        public TLRequestMessagesGetDialogs()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestMessagesGetDialogs(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(14)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x35, 0x6c, 0x6c, 0x6c, 0x72, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.offsetDate = StreamingUtils.readInt(stream);
            this.offsetId = StreamingUtils.readInt(stream);
            this.offsetPeer = StreamingUtils.readTLObject(stream, context);
            this.limit = StreamingUtils.readInt(stream);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 180, 0x68, 0x63, 0x90, 0x68, 0x87 })]
        public virtual TLAbsDialogs deserializeResponse(InputStream stream, TLContext context)
        {
            TLObject obj2 = StreamingUtils.readTLObject(stream, context);
            if (obj2 == null)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IOException("Unable to parse response");
            }
            if (obj2 is TLAbsDialogs)
            {
                return (TLAbsDialogs) obj2;
            }
            Throwable.__<suppressFillInStackTrace>();
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected ").append(ClassLiteral<TLAbsDialogs>.Value.getName()).append(", got: ").append(Object.instancehelper_getClass(obj2).getCanonicalName()).toString());
        }

        [LineNumberTable(new byte[] { 0x9f, 0x7a, 0x62, 0x63, 0x90, 0x8f })]
        private void excludePinned(bool flag1)
        {
            if (flag1)
            {
                this.flags |= 1;
            }
            else
            {
                this.flags &= -2;
            }
        }

        public override int getClassId() => 
            0x191ba9c5;

        public virtual int getLimit() => 
            this.limit;

        public virtual int getOffsetDate() => 
            this.offsetDate;

        public virtual int getOffsetId() => 
            this.offsetId;

        public virtual TLAbsInputPeer getOffsetPeer() => 
            this.offsetPeer;

        private bool pinnedExcluded() => 
            ((this.flags & 1) != 0);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x2c, 0x6c, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeInt(this.offsetDate, stream);
            StreamingUtils.writeInt(this.offsetId, stream);
            StreamingUtils.writeTLObject(this.offsetPeer, stream);
            StreamingUtils.writeInt(this.limit, stream);
        }

        public virtual void setLimit(int value)
        {
            this.limit = value;
        }

        public virtual void setOffsetDate(int offsetDate)
        {
            this.offsetDate = offsetDate;
        }

        public virtual void setOffsetId(int offsetId)
        {
            this.offsetId = offsetId;
        }

        public virtual void setOffsetPeer(TLAbsInputPeer offsetPeer)
        {
            this.offsetPeer = offsetPeer;
        }

        public override string toString() => 
            "messages.getDialogs#191ba9c5";
    }
}

