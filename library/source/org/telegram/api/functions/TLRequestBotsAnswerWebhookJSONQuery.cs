namespace org.telegram.api.functions
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using java.lang;
    using org.telegram.api;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/tl/TLBool;>;")]
    public class TLRequestBotsAnswerWebhookJSONQuery : TLMethod
    {
        public const int CLASS_ID = -434028723;
        private TLDataJSON data;
        private long queryId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa3, 0x68 })]
        public TLRequestBotsAnswerWebhookJSONQuery()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestBotsAnswerWebhookJSONQuery(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(14)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 11, 0x6c, 0x77 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.queryId = StreamingUtils.readLong(stream);
            this.data = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLDataJSON>.Value);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xa8, 0x68, 0x63, 0x90, 0x68, 0x87, 0x7f, 10 })]
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
            -434028723;

        public virtual TLDataJSON getData() => 
            this.data;

        public virtual long getQueryId() => 
            this.queryId;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 5, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeLong(this.queryId, stream);
            StreamingUtils.writeTLObject(this.data, stream);
        }

        public virtual void setData(TLDataJSON data)
        {
            this.data = data;
        }

        public virtual void setQueryId(long queryId)
        {
            this.queryId = queryId;
        }

        public override string toString() => 
            "bots.answerWebhookJSONQuery#e6213f4d";
    }
}

