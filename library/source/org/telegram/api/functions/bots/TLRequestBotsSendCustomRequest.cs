namespace org.telegram.api.functions.bots
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

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/api/TLDataJSON;>;")]
    public class TLRequestBotsSendCustomRequest : TLMethod
    {
        public const int CLASS_ID = -1440257555;
        private string customMethod;
        private TLDataJSON @params;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa3, 0x68 })]
        public TLRequestBotsSendCustomRequest()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestBotsSendCustomRequest(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(14)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 11, 0x6c, 0x77 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.customMethod = StreamingUtils.readTLString(stream);
            this.@params = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLDataJSON>.Value);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xa8, 0x68, 0x63, 0x90, 0x68, 0x87, 0x7f, 10 })]
        public virtual TLDataJSON deserializeResponse(InputStream stream, TLContext context)
        {
            TLObject obj2 = StreamingUtils.readTLObject(stream, context);
            if (obj2 == null)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IOException("Unable to parse response");
            }
            if (obj2 is TLDataJSON)
            {
                return (TLDataJSON) obj2;
            }
            Throwable.__<suppressFillInStackTrace>();
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected ").append(ClassLiteral<TLDataJSON>.Value.getCanonicalName()).append(", got: ").append(Object.instancehelper_getClass(obj2).getCanonicalName()).toString());
        }

        public override int getClassId() => 
            -1440257555;

        public virtual string getCustomMethod() => 
            this.customMethod;

        public virtual TLDataJSON getParams() => 
            this.@params;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 5, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLString(this.customMethod, stream);
            StreamingUtils.writeTLObject(this.@params, stream);
        }

        public virtual void setCustomMethod(string customMethod)
        {
            this.customMethod = customMethod;
        }

        public virtual void setParams(TLDataJSON @params)
        {
            this.@params = @params;
        }

        public override string toString() => 
            "bots.sendCustomRequest#aa2769ed";
    }
}

