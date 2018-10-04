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
    public class TLRequestMessagesSetBotPrecheckoutResults : TLMethod
    {
        public const int CLASS_ID = 0x9c2dd95;
        private string error;
        private const int FLAG_ERROR = 1;
        private const int FLAG_SUCCESS = 2;
        private int flags;
        private long queryId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa6, 0x68 })]
        public TLRequestMessagesSetBotPrecheckoutResults()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestMessagesSetBotPrecheckoutResults(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(13)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x26, 0x6c, 0x6c, 0x68, 140 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.queryId = StreamingUtils.readLong(stream);
            if (this.hasError())
            {
                this.error = StreamingUtils.readTLString(stream);
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x10, 0x68, 0x63, 0x90, 0x68, 0x87, 0x7f, 10 })]
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
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected ").append(ClassLiteral<TLBool>.Value.getCanonicalName()).append(", got: ").append(Object.instancehelper_getClass(obj2).getCanonicalName()).toString());
        }

        public override int getClassId() => 
            0x9c2dd95;

        public virtual string getError() => 
            this.error;

        public virtual long getQueryId() => 
            this.queryId;

        public virtual bool hasError() => 
            ((this.flags & 1) != 0);

        public virtual bool isSuccess() => 
            ((this.flags & 2) != 0);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x1d, 0x6c, 0x6c, 0x68, 0x8e })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeLong(this.queryId, stream);
            if (this.hasError())
            {
                StreamingUtils.writeTLString(this.error, stream);
            }
        }

        [LineNumberTable(new byte[] { 0x9f, 0xb6, 0x63, 0x91, 0x8e, 0x67 })]
        public virtual void setError(string error)
        {
            if (error == null)
            {
                this.flags &= -2;
            }
            else
            {
                this.flags |= 1;
            }
            this.error = error;
        }

        public virtual void setQueryId(long queryId)
        {
            this.queryId = queryId;
        }

        [LineNumberTable(new byte[] { 0x9f, 0x81, 0x62, 0x63, 0x90, 0x8f })]
        public virtual void setSuccess(bool success)
        {
            if (success)
            {
                this.flags |= 1;
            }
            else
            {
                this.flags &= -2;
            }
        }

        public override string toString() => 
            "messages.setBotPrecheckoutResults#9c2dd95";
    }
}

