namespace org.telegram.api.functions.payments
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using java.lang;
    using org.telegram.api.input.paymentapi.paymentcredentials;
    using org.telegram.api.paymentapi.payments.result;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/api/paymentapi/payments/result/TLAbsPaymentsPaymentResult;>;")]
    public class TLRequestPaymentsSendPaymentForm : TLMethod
    {
        public const int CLASS_ID = 0x2b8879b3;
        private TLAbsInputPaymentCredentials credentials;
        private const int FLAG_INFO = 1;
        private const int FLAG_SHIPPING_OPTION = 2;
        private int flags;
        private int msgId;
        private string requestedInfo;
        private string shippingOptionId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xad, 0x68 })]
        public TLRequestPaymentsSendPaymentForm()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestPaymentsSendPaymentForm(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(0x12)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x43, 0x6c, 0x6c, 0x68, 140, 0x68, 140, 0x77 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.msgId = StreamingUtils.readInt(stream);
            if (this.hasInfo())
            {
                this.requestedInfo = StreamingUtils.readTLString(stream);
            }
            if (this.hasShippingOptions())
            {
                this.shippingOptionId = StreamingUtils.readTLString(stream);
            }
            this.credentials = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLAbsInputPaymentCredentials>.Value);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x24, 0x68, 0x63, 0x90, 0x68, 0x87, 0x7f, 10 })]
        public virtual TLAbsPaymentsPaymentResult deserializeResponse(InputStream stream, TLContext context)
        {
            TLObject obj2 = StreamingUtils.readTLObject(stream, context);
            if (obj2 == null)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IOException("Unable to parse response");
            }
            if (obj2 is TLAbsPaymentsPaymentResult)
            {
                return (TLAbsPaymentsPaymentResult) obj2;
            }
            Throwable.__<suppressFillInStackTrace>();
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected ").append(ClassLiteral<TLAbsPaymentsPaymentResult>.Value.getName()).append(", got: ").append(Object.instancehelper_getClass(obj2).getCanonicalName()).toString());
        }

        public override int getClassId() => 
            0x2b8879b3;

        public virtual TLAbsInputPaymentCredentials getCredentials() => 
            this.credentials;

        public virtual int getMsgId() => 
            this.msgId;

        public virtual string getRequestedInfo() => 
            this.requestedInfo;

        public virtual string getShippingOptionId() => 
            this.shippingOptionId;

        public virtual bool hasInfo() => 
            ((this.flags & 1) != 0);

        public virtual bool hasShippingOptions() => 
            ((this.flags & 2) != 0);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x36, 0x6c, 0x6c, 0x68, 140, 0x68, 140, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeInt(this.msgId, stream);
            if (this.hasInfo())
            {
                StreamingUtils.writeTLString(this.requestedInfo, stream);
            }
            if (this.hasShippingOptions())
            {
                StreamingUtils.writeTLString(this.shippingOptionId, stream);
            }
            StreamingUtils.writeTLObject(this.credentials, stream);
        }

        public virtual void setCredentials(TLAbsInputPaymentCredentials credentials)
        {
            this.credentials = credentials;
        }

        public virtual void setMsgId(int msgId)
        {
            this.msgId = msgId;
        }

        [LineNumberTable(new byte[] { 0x9f, 0xbd, 0x63, 0x91, 0x8e, 0x67 })]
        public virtual void setRequestedInfo(string requestedInfo)
        {
            if (requestedInfo == null)
            {
                this.flags &= -2;
            }
            else
            {
                this.flags |= 1;
            }
            this.requestedInfo = requestedInfo;
        }

        [LineNumberTable(new byte[] { 10, 0x63, 0x91, 0x8e, 0x67 })]
        public virtual void setShippingOptionId(string shippingOptionId)
        {
            if (shippingOptionId == null)
            {
                this.flags &= -3;
            }
            else
            {
                this.flags |= 2;
            }
            this.shippingOptionId = shippingOptionId;
        }

        public override string toString() => 
            "payments.sendPaymentForm#2b8879b3";
    }
}

