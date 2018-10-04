namespace org.telegram.api.functions.auth
{
    using IKVM.Attributes;
    using java.io;
    using java.lang;
    using org.telegram.api.auth;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/api/auth/TLAuthorization;>;")]
    public class TLRequestAuthImportBotAuthorization : TLMethod
    {
        private string apiHash;
        private int apiId;
        private string botAuthToken;
        public const int CLASS_ID = 0x67a3ff2c;
        private int flags;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xad, 0x68 })]
        public TLRequestAuthImportBotAuthorization()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestAuthImportBotAuthorization(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(0x10)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 40, 0x6c, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.apiId = StreamingUtils.readInt(stream);
            this.apiHash = StreamingUtils.readTLString(stream);
            this.botAuthToken = StreamingUtils.readTLString(stream);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb6, 0x68, 0x63, 0x70, 0x68, 0x67 })]
        public virtual TLAuthorization deserializeResponse(InputStream stream, TLContext context)
        {
            TLObject obj2 = StreamingUtils.readTLObject(stream, context);
            if (obj2 == null)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IOException("Unable to parse response");
            }
            if (obj2 is TLAuthorization)
            {
                return (TLAuthorization) obj2;
            }
            Throwable.__<suppressFillInStackTrace>();
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected org.telegram.api.auth.TLAuthorization, got: ").append(Object.instancehelper_getClass(obj2).getCanonicalName()).toString());
        }

        public virtual string getApiHash() => 
            this.apiHash;

        public virtual int getApiId() => 
            this.apiId;

        public virtual string getBotAuthToken() => 
            this.botAuthToken;

        public override int getClassId() => 
            0x67a3ff2c;

        public virtual int getFlags() => 
            this.flags;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x20, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeInt(this.apiId, stream);
            StreamingUtils.writeTLString(this.apiHash, stream);
            StreamingUtils.writeTLString(this.botAuthToken, stream);
        }

        public virtual void setApiHash(string apiHash)
        {
            this.apiHash = apiHash;
        }

        public virtual void setApiId(int apiId)
        {
            this.apiId = apiId;
        }

        public virtual void setBotAuthToken(string botAuthToken)
        {
            this.botAuthToken = botAuthToken;
        }

        public virtual void setFlags(int flags)
        {
            this.flags = flags;
        }

        public override string toString() => 
            "auth.importBotAuthorization#67a3ff2c";
    }
}

