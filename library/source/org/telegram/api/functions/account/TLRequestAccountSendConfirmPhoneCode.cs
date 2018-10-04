namespace org.telegram.api.functions.account
{
    using IKVM.Attributes;
    using ikvm.internal;
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
    public class TLRequestAccountSendConfirmPhoneCode : TLMethod
    {
        public const int CLASS_ID = 0x1516d7bd;
        private bool currentNumber;
        private const int FLAG_ALLOW_FLASHCALL = 1;
        private int flags;
        private string hash;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xab, 0x68 })]
        public TLRequestAccountSendConfirmPhoneCode()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestAccountSendConfirmPhoneCode(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(0x13)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        public virtual bool allowFlashCalls() => 
            ((this.flags & 1) != 0);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x27, 0x6c, 0x6c, 0x6a, 140 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.hash = StreamingUtils.readTLString(stream);
            if ((this.flags & 1) != 0)
            {
                this.currentNumber = StreamingUtils.readTLBool(stream);
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x12, 0x68, 0x63, 0x90, 0x68, 0x87 })]
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
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected ").append(ClassLiteral<TLSentCode>.Value.getCanonicalName()).append(", got: ").append(Object.instancehelper_getClass(obj2).getCanonicalName()).toString());
        }

        public override int getClassId() => 
            0x1516d7bd;

        public virtual int getFlags() => 
            this.flags;

        public virtual string getHash() => 
            this.hash;

        public virtual bool isCurrentNumber() => 
            this.currentNumber;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 30, 0x6c, 0x6c, 0x6a, 0x8e })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeTLString(this.hash, stream);
            if ((this.flags & 1) != 0)
            {
                StreamingUtils.writeTLBool(this.currentNumber, stream);
            }
        }

        [LineNumberTable(new byte[] { 0x9f, 0x80, 130, 110, 0x67 })]
        public virtual void setCurrentNumber(bool currentNumber)
        {
            int num = (int) currentNumber;
            this.flags |= 1;
            this.currentNumber = (bool) num;
        }

        public virtual void setFlags(int flags)
        {
            this.flags = flags;
        }

        public virtual void setHash(string hash)
        {
            this.hash = hash;
        }

        public override string toString() => 
            "account.sendConfirmPhoneCode#1516d7bd";
    }
}

