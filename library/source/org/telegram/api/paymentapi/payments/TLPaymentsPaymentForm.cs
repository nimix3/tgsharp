namespace org.telegram.api.paymentapi.payments
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using org.telegram.api;
    using org.telegram.api.paymentapi;
    using org.telegram.api.paymentapi.savedcredentails;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLPaymentsPaymentForm : TLObject
    {
        private int botId;
        public const int CLASS_ID = 0x3f56aea3;
        private const int FLAG_CAN_SAVE_CREDENTIALS = 4;
        private const int FLAG_NATIVE = 0x10;
        private const int FLAG_PASSWORD_MISSING = 8;
        private const int FLAG_SAVED_CREDENTIALS = 2;
        private const int FLAG_SAVED_INFO = 1;
        private int flags;
        private TLInvoice invoice;
        private TLDataJSON nativeParams;
        private string nativeProvider;
        private int providerId;
        private TLAbsPaymentSavedCredentials savedCredentials;
        private TLPaymentRequestedInfo savedInfo;
        private string url;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLAbsUser;>;")]
        private TLVector users;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb8, 0x68 })]
        public TLPaymentsPaymentForm()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLPaymentsPaymentForm(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public virtual bool canSaveCredentials() => 
            ((this.flags & 4) != 0);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x4e, 0x6c, 0x6c, 0x77, 0x6c, 0x6c, 0x68, 0x6c, 0x97, 0x68, 0x97, 0x68, 0x97, 0x92 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.botId = StreamingUtils.readInt(stream);
            this.invoice = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLInvoice>.Value);
            this.providerId = StreamingUtils.readInt(stream);
            this.url = StreamingUtils.readTLString(stream);
            if (this.isNative())
            {
                this.nativeProvider = StreamingUtils.readTLString(stream);
                this.nativeParams = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLDataJSON>.Value);
            }
            if (this.hasSavedInfo())
            {
                this.savedInfo = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLPaymentRequestedInfo>.Value);
            }
            if (this.hasSavedCredentials())
            {
                this.savedCredentials = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLAbsPaymentSavedCredentials>.Value);
            }
            this.users = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLAbsUser>.Value);
        }

        public virtual int getBotId() => 
            this.botId;

        public override int getClassId() => 
            0x3f56aea3;

        public virtual TLInvoice getInvoice() => 
            this.invoice;

        public virtual TLDataJSON getNativeParams() => 
            this.nativeParams;

        public virtual string getNativeProvider() => 
            this.nativeProvider;

        public virtual int getProviderId() => 
            this.providerId;

        public virtual TLAbsPaymentSavedCredentials getSavedCredentials() => 
            this.savedCredentials;

        public virtual TLPaymentRequestedInfo getSavedInfo() => 
            this.savedInfo;

        public virtual string getUrl() => 
            this.url;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLAbsUser;>;")]
        public virtual TLVector getUsers() => 
            this.users;

        public virtual bool hasSavedCredentials() => 
            ((this.flags & 2) != 0);

        public virtual bool hasSavedInfo() => 
            ((this.flags & 1) != 0);

        public virtual bool isNative() => 
            ((this.flags & 0x10) != 0);

        public virtual bool isPasswordMissing() => 
            ((this.flags & 8) != 0);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x3a, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x68, 0x6c, 140, 0x68, 140, 0x68, 140, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeInt(this.botId, stream);
            StreamingUtils.writeTLObject(this.invoice, stream);
            StreamingUtils.writeInt(this.providerId, stream);
            StreamingUtils.writeTLString(this.url, stream);
            if (this.isNative())
            {
                StreamingUtils.writeTLString(this.nativeProvider, stream);
                StreamingUtils.writeTLObject(this.nativeParams, stream);
            }
            if (this.hasSavedInfo())
            {
                StreamingUtils.writeTLObject(this.savedInfo, stream);
            }
            if (this.hasSavedCredentials())
            {
                StreamingUtils.writeTLObject(this.savedCredentials, stream);
            }
            StreamingUtils.writeTLVector(this.users, stream);
        }

        public override string toString() => 
            "payments.paymentForm#3f56aea3";
    }
}

