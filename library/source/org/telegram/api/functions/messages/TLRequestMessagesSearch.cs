namespace org.telegram.api.functions.messages
{
    using IKVM.Attributes;
    using java.io;
    using java.lang;
    using org.telegram.api.input.messages.filter;
    using org.telegram.api.input.peer;
    using org.telegram.api.messages;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/api/messages/TLAbsMessages;>;")]
    public class TLRequestMessagesSearch : TLMethod
    {
        public const int CLASS_ID = -732523960;
        private TLAbsMessagesFilter filter;
        private const int FLAG_IMPORTANT_ONLY = 1;
        private int flags;
        private int limit;
        private int maxDate;
        private int maxId;
        private int minDate;
        private int offset;
        private TLAbsInputPeer peer;
        private string q;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb6, 0x68 })]
        public TLRequestMessagesSearch()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestMessagesSearch(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(0x12)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 160, 110, 0x6c, 0x72, 0x6c, 0x72, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.peer = StreamingUtils.readTLObject(stream, context);
            this.q = StreamingUtils.readTLString(stream);
            this.filter = StreamingUtils.readTLObject(stream, context);
            this.minDate = StreamingUtils.readInt(stream);
            this.maxDate = StreamingUtils.readInt(stream);
            this.offset = StreamingUtils.readInt(stream);
            this.maxId = StreamingUtils.readInt(stream);
            this.limit = StreamingUtils.readInt(stream);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xbf, 0x68, 0x63, 0x70, 0x68, 0x67 })]
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
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected org.telegram.api.messages.TLAbsMessages, got: ").append(Object.instancehelper_getClass(obj2).getCanonicalName()).toString());
        }

        public override int getClassId() => 
            -732523960;

        public virtual TLAbsMessagesFilter getFilter() => 
            this.filter;

        public virtual int getFlags() => 
            this.flags;

        public virtual int getLimit() => 
            this.limit;

        public virtual int getMaxDate() => 
            this.maxDate;

        public virtual int getMaxId() => 
            this.maxId;

        public virtual int getMinDate() => 
            this.minDate;

        public virtual int getOffset() => 
            this.offset;

        public virtual TLAbsInputPeer getPeer() => 
            this.peer;

        public virtual string getQ() => 
            this.q;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 160, 0x61, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeTLObject(this.peer, stream);
            StreamingUtils.writeTLString(this.q, stream);
            StreamingUtils.writeTLObject(this.filter, stream);
            StreamingUtils.writeInt(this.minDate, stream);
            StreamingUtils.writeInt(this.maxDate, stream);
            StreamingUtils.writeInt(this.offset, stream);
            StreamingUtils.writeInt(this.maxId, stream);
            StreamingUtils.writeInt(this.limit, stream);
        }

        public virtual void setFilter(TLAbsMessagesFilter value)
        {
            this.filter = value;
        }

        public virtual void setFlags(int flags)
        {
            this.flags = flags;
        }

        public virtual void setLimit(int value)
        {
            this.limit = value;
        }

        public virtual void setMaxDate(int value)
        {
            this.maxDate = value;
        }

        public virtual void setMaxId(int value)
        {
            this.maxId = value;
        }

        public virtual void setMinDate(int value)
        {
            this.minDate = value;
        }

        public virtual void setOffset(int value)
        {
            this.offset = value;
        }

        public virtual void setPeer(TLAbsInputPeer value)
        {
            this.peer = value;
        }

        public virtual void setQ(string value)
        {
            this.q = value;
        }

        public override string toString() => 
            "messages.search#d4569248";
    }
}

