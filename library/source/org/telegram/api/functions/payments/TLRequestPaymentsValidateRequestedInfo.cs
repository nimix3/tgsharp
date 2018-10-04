namespace org.telegram.api.functions.payments
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using java.lang;
    using org.telegram.api.paymentapi;
    using org.telegram.api.paymentapi.payments;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/api/paymentapi/payments/TLPaymentsValidatedRequestedInfo;>;")]
    public class TLRequestPaymentsValidateRequestedInfo : TLMethod
    {
        public const int CLASS_ID = 0x770a8e74;
        private const int FLAG_SAVE = 1;
        private int flags;
        private TLPaymentRequestedInfo info;
        private int msgId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 170, 0x68 })]
        public TLRequestPaymentsValidateRequestedInfo()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestPaymentsValidateRequestedInfo(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(0x12)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x24, 0x6c, 0x6c, 0x77 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.msgId = StreamingUtils.readInt(stream);
            this.info = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLPaymentRequestedInfo>.Value);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 11, 0x68, 0x63, 0x90, 0x68, 0x87, 0x7f, 10 })]
        public virtual TLPaymentsValidatedRequestedInfo deserializeResponse(InputStream stream, TLContext context)
        {
            TLObject obj2 = StreamingUtils.readTLObject(stream, context);
            if (obj2 == null)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IOException("Unable to parse response");
            }
            if (obj2 is TLPaymentsValidatedRequestedInfo)
            {
                return (TLPaymentsValidatedRequestedInfo) obj2;
            }
            Throwable.__<suppressFillInStackTrace>();
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected ").append(ClassLiteral<TLPaymentsValidatedRequestedInfo>.Value.getName()).append(", got: ").append(Object.instancehelper_getClass(obj2).getCanonicalName()).toString());
        }

        public override int getClassId() => 
            0x770a8e74;

        public virtual TLPaymentRequestedInfo getInfo() => 
            this.info;

        public virtual int getMsgId() => 
            this.msgId;

        public virtual bool isSave() => 
            ((this.flags & 1) != 0);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x1d, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeInt(this.msgId, stream);
            StreamingUtils.writeTLObject(this.info, stream);
        }

        public virtual void setInfo(TLPaymentRequestedInfo info)
        {
            this.info = info;
        }

        public virtual void setMsgId(int msgId)
        {
            this.msgId = msgId;
        }

        [LineNumberTable(new byte[] { 0x9f, 130, 0x42, 0x63, 0x90, 0x8f })]
        public virtual void setSave(bool save)
        {
            if (save)
            {
                this.flags |= 1;
            }
            else
            {
                this.flags &= -2;
            }
        }

        public override string toString() => 
            "payments.validateRequestedInfo#770a8e74";
    }
}

