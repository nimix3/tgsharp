namespace org.telegram.api.paymentapi.payments
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using org.telegram.api.paymentapi;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLPaymentsSavedInfo : TLObject
    {
        public const int CLASS_ID = -74456004;
        private const int FLAG_HAS_SAVED_CREDENTIALS = 2;
        private const int FLAG_SAVED_INFO = 1;
        public int flags;
        public TLPaymentRequestedInfo savedInfo;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa8, 0x68 })]
        public TLPaymentsSavedInfo()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLPaymentsSavedInfo(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 7, 0x6c, 0x68, 0x97 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            if (this.hasSavedInfo())
            {
                this.savedInfo = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLPaymentRequestedInfo>.Value);
            }
        }

        public override int getClassId() => 
            -74456004;

        public virtual TLPaymentRequestedInfo getSavedInfo() => 
            this.savedInfo;

        public virtual bool hasSavedCredentials() => 
            ((this.flags & 2) != 0);

        public virtual bool hasSavedInfo() => 
            ((this.flags & 1) != 0);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 190, 0x6c, 0x68, 0xae })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            if (this.hasSavedInfo())
            {
                StreamingUtils.writeTLObject(this.savedInfo, stream);
            }
        }

        public override string toString() => 
            "payments.savedInfo#fb8fe43c";
    }
}

