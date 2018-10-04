namespace org.telegram.api.functions.account
{
    using IKVM.Attributes;
    using java.io;
    using java.lang;
    using org.telegram.api.user;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/api/user/TLAbsUser;>;")]
    public class TLRequestAccountChangePhone : TLMethod
    {
        public const int CLASS_ID = 0x70c32edb;
        private string phoneCode;
        private string phoneCodeHash;
        private string phoneNumber;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xac, 0x68 })]
        public TLRequestAccountChangePhone()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestAccountChangePhone(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(0x10)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x3e, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.phoneNumber = StreamingUtils.readTLString(stream);
            this.phoneCodeHash = StreamingUtils.readTLString(stream);
            this.phoneCode = StreamingUtils.readTLString(stream);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb5, 0x68, 0x63, 0x70, 0x68, 0x67 })]
        public virtual TLAbsUser deserializeResponse(InputStream stream, TLContext context)
        {
            TLObject obj2 = StreamingUtils.readTLObject(stream, context);
            if (obj2 == null)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IOException("Unable to parse response");
            }
            if (obj2 is TLAbsUser)
            {
                return (TLAbsUser) obj2;
            }
            Throwable.__<suppressFillInStackTrace>();
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected org.telegram.tl.TLAbsUser, got: ").append(Object.instancehelper_getClass(obj2).getCanonicalName()).toString());
        }

        public override int getClassId() => 
            0x70c32edb;

        public virtual string getPhoneCode() => 
            this.phoneCode;

        public virtual string getPhoneCodeHash() => 
            this.phoneCodeHash;

        public virtual string getPhoneNumber() => 
            this.phoneNumber;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x36, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLString(this.phoneNumber, stream);
            StreamingUtils.writeTLString(this.phoneCodeHash, stream);
            StreamingUtils.writeTLString(this.phoneCode, stream);
        }

        public virtual void setPhoneCode(string phoneCode)
        {
            this.phoneCode = phoneCode;
        }

        public virtual void setPhoneCodeHash(string phoneCodeHash)
        {
            this.phoneCodeHash = phoneCodeHash;
        }

        public virtual void setPhoneNumber(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }

        public override string toString() => 
            "account.sendChangePhone#70c32edb";
    }
}

