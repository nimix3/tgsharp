namespace org.telegram.api.functions.payments
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using java.lang;
    using org.telegram.api.paymentapi.payments;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/api/paymentapi/payments/TLPaymentsPaymentReceipt;>;")]
    public class TLRequestPaymentsGetPaymentReceipt : TLMethod
    {
        public const int CLASS_ID = -1601001088;
        private int msgId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa5, 0x68 })]
        public TLRequestPaymentsGetPaymentReceipt()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestPaymentsGetPaymentReceipt(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(0x11)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 9, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.msgId = StreamingUtils.readInt(stream);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb2, 0x68, 0x63, 0x90, 0x68, 0x87, 0x7f, 10 })]
        public virtual TLPaymentsPaymentReceipt deserializeResponse(InputStream stream, TLContext context)
        {
            TLObject obj2 = StreamingUtils.readTLObject(stream, context);
            if (obj2 == null)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IOException("Unable to parse response");
            }
            if (obj2 is TLPaymentsPaymentReceipt)
            {
                return (TLPaymentsPaymentReceipt) obj2;
            }
            Throwable.__<suppressFillInStackTrace>();
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected ").append(ClassLiteral<TLPaymentsPaymentReceipt>.Value.getName()).append(", got: ").append(Object.instancehelper_getClass(obj2).getCanonicalName()).toString());
        }

        public override int getClassId() => 
            -1601001088;

        public virtual int getMsgId() => 
            this.msgId;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 4, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.msgId, stream);
        }

        public virtual void setMsgId(int msgId)
        {
            this.msgId = msgId;
        }

        public override string toString() => 
            "payments.getPaymentReceipt#a092a980";
    }
}

