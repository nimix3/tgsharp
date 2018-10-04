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
    public class TLRequestMessagesSearchGlobal : TLMethod
    {
        public const int CLASS_ID = -1640190800;
        private int limit;
        private int offsetDate;
        private int offsetId;
        private TLAbsInputPeer offsetPeer;
        private string q;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xbf, 0x68 })]
        public TLRequestMessagesSearchGlobal()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestMessagesSearchGlobal(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(0x21)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x45, 0x6c, 0x6c, 0x72, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.q = StreamingUtils.readTLString(stream);
            this.offsetDate = StreamingUtils.readInt(stream);
            this.offsetPeer = StreamingUtils.readTLObject(stream, context);
            this.offsetId = StreamingUtils.readInt(stream);
            this.limit = StreamingUtils.readInt(stream);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 8, 0x68, 0x63, 0x90, 0x68, 0x87 })]
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
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected ").append(ClassLiteral<TLAbsMessages>.Value.getCanonicalName()).append(", got: ").append(Object.instancehelper_getClass(obj2).getCanonicalName()).toString());
        }

        public override int getClassId() => 
            -1640190800;

        public virtual int getLimit() => 
            this.limit;

        public virtual int getOffsetDate() => 
            this.offsetDate;

        public virtual int getOffsetId() => 
            this.offsetId;

        public virtual TLAbsInputPeer getOffsetPeer() => 
            this.offsetPeer;

        public virtual string getQ() => 
            this.q;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 60, 0x6c, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLString(this.q, stream);
            StreamingUtils.writeInt(this.offsetDate, stream);
            StreamingUtils.writeTLObject(this.offsetPeer, stream);
            StreamingUtils.writeInt(this.offsetId, stream);
            StreamingUtils.writeInt(this.limit, stream);
        }

        public virtual void setLimit(int limit)
        {
            this.limit = limit;
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

        public virtual void setQ(string q)
        {
            this.q = q;
        }

        public override string toString() => 
            "messages.searchGlobal#9e3cacb0";
    }
}

