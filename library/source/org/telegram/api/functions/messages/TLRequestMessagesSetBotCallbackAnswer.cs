namespace org.telegram.api.functions.messages
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using java.lang;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/tl/TLBool;>;")]
    public class TLRequestMessagesSetBotCallbackAnswer : TLMethod
    {
        private int cacheTime;
        public const int CLASS_ID = -712043766;
        private const int FLAG_ALERT = 2;
        private const int FLAG_MESSAGE = 1;
        private const int FLAG_URL = 4;
        private int flags;
        private string message;
        private long queryId;
        private string url;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb2, 0x68 })]
        public TLRequestMessagesSetBotCallbackAnswer()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestMessagesSetBotCallbackAnswer(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(0x10)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x48, 0x6c, 0x6c, 0x6a, 140, 0x6a, 140, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.queryId = StreamingUtils.readLong(stream);
            if ((this.flags & 1) != 0)
            {
                this.message = StreamingUtils.readTLString(stream);
            }
            if ((this.flags & 4) != 0)
            {
                this.url = StreamingUtils.readTLString(stream);
            }
            this.cacheTime = StreamingUtils.readInt(stream);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xbb, 0x68, 0x63, 0x90, 0x68, 0x87 })]
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
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected ").append(ClassLiteral<TLBool>.Value.getName()).append(", got: ").append(Object.instancehelper_getClass(obj2).getName()).toString());
        }

        public virtual int getCacheTime() => 
            this.cacheTime;

        public override int getClassId() => 
            -712043766;

        public virtual int getFlags() => 
            this.flags;

        public virtual string getMessage() => 
            this.message;

        public virtual long getQueryId() => 
            this.queryId;

        public virtual string getUrl() => 
            this.url;

        public virtual bool hasAlert() => 
            ((this.flags & 2) != 0);

        public virtual bool hasUrl() => 
            ((this.flags & 4) != 0);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x3a, 0x6c, 0x6c, 0x6a, 140, 0x6a, 140, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeLong(this.queryId, stream);
            if ((this.flags & 1) != 0)
            {
                StreamingUtils.writeTLString(this.message, stream);
            }
            if ((this.flags & 4) != 0)
            {
                StreamingUtils.writeTLString(this.url, stream);
            }
            StreamingUtils.writeInt(this.cacheTime, stream);
        }

        public virtual void setCacheTime(int cacheTime)
        {
            this.cacheTime = cacheTime;
        }

        public virtual void setFlags(int flags)
        {
            this.flags = flags;
        }

        [LineNumberTable(new byte[] { 0x26, 110, 0x67 })]
        public virtual void setMessage(string message)
        {
            this.flags |= 1;
            this.message = message;
        }

        public virtual void setQueryId(long queryId)
        {
            this.queryId = queryId;
        }

        [LineNumberTable(new byte[] { 0x2f, 110, 0x67 })]
        public virtual void setUrl(string url)
        {
            this.flags |= 4;
            this.url = url;
        }

        public override string toString() => 
            "messages.setBotCallbackAnswer#d58f130a";
    }
}

