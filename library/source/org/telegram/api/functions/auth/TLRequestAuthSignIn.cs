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
    public class TLRequestAuthSignIn : TLMethod
    {
        public const int CLASS_ID = -1126886015;
        private string phoneCode;
        private string phoneCodeHash;
        private string phoneNumber;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xac, 0x68 })]
        public TLRequestAuthSignIn()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestAuthSignIn(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(0x10)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 60, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.phoneNumber = StreamingUtils.readTLString(stream);
            this.phoneCodeHash = StreamingUtils.readTLString(stream);
            this.phoneCode = StreamingUtils.readTLString(stream);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb5, 0x68, 0x63, 0x70, 0x68, 0x67 })]
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

        public override int getClassId() => 
            -1126886015;

        public virtual string getPhoneCode() => 
            this.phoneCode;

        public virtual string getPhoneCodeHash() => 
            this.phoneCodeHash;

        public virtual string getPhoneNumber() => 
            this.phoneNumber;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x35, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLString(this.phoneNumber, stream);
            StreamingUtils.writeTLString(this.phoneCodeHash, stream);
            StreamingUtils.writeTLString(this.phoneCode, stream);
        }

        public virtual void setPhoneCode(string value)
        {
            this.phoneCode = value;
        }

        public virtual void setPhoneCodeHash(string value)
        {
            this.phoneCodeHash = value;
        }

        public virtual void setPhoneNumber(string value)
        {
            this.phoneNumber = value;
        }

        public override string toString() => 
            "auth.signIn#bcd51581";
    }
}

