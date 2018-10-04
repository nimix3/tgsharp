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

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/api/auth/TLSentCode;>;")]
    public class TLRequestAuthSendCode : TLMethod
    {
        private string apiHash;
        private int apiId;
        public const int CLASS_ID = -2035355412;
        private Boolean currentPhoneNumber;
        private const int FLAG_ALLOW_FLASHCALL = 1;
        private int flags;
        private string phoneNumber;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb0, 0x68 })]
        public TLRequestAuthSendCode()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestAuthSendCode(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(0x10)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 70, 0x6c, 0x6c, 0x6a, 0x91, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.phoneNumber = StreamingUtils.readTLString(stream);
            if ((this.flags & 1) != 0)
            {
                this.currentPhoneNumber = Boolean.valueOf(StreamingUtils.readTLBool(stream));
            }
            this.apiId = StreamingUtils.readInt(stream);
            this.apiHash = StreamingUtils.readTLString(stream);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb9, 0x68, 0x63, 0x90, 0x68, 0x87 })]
        public virtual TLSentCode deserializeResponse(InputStream stream, TLContext context)
        {
            TLObject obj2 = StreamingUtils.readTLObject(stream, context);
            if (obj2 == null)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IOException("Unable to parse response");
            }
            if (obj2 is TLSentCode)
            {
                return (TLSentCode) obj2;
            }
            Throwable.__<suppressFillInStackTrace>();
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected org.telegram.api.auth.TLSentCode, got: ").append(Object.instancehelper_getClass(obj2).getCanonicalName()).toString());
        }

        public virtual string getApiHash() => 
            this.apiHash;

        public virtual int getApiId() => 
            this.apiId;

        public override int getClassId() => 
            -2035355412;

        public virtual string getPhoneNumber() => 
            this.phoneNumber;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x3b, 0x6c, 0x6c, 0x6a, 0x91, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeTLString(this.phoneNumber, stream);
            if ((this.flags & 1) != 0)
            {
                StreamingUtils.writeTLBool(this.currentPhoneNumber.booleanValue(), stream);
            }
            StreamingUtils.writeInt(this.apiId, stream);
            StreamingUtils.writeTLString(this.apiHash, stream);
        }

        public virtual void setApiHash(string value)
        {
            this.apiHash = value;
        }

        public virtual void setApiId(int value)
        {
            this.apiId = value;
        }

        public virtual void setPhoneNumber(string value)
        {
            this.phoneNumber = value;
        }

        public override string toString() => 
            "auth.sendCode#86aef0ec";
    }
}

