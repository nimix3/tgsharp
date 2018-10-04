namespace org.telegram.api.input.paymentapi.paymentcredentials
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using org.telegram.api;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLInputPaymentCredentials : TLAbsInputPaymentCredentials
    {
        public const int CLASS_ID = 0x3417d728;
        private TLDataJSON data;
        private const int FLAG_SAVE = 1;
        private int flags;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa6, 0x68 })]
        public TLInputPaymentCredentials()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLInputPaymentCredentials(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 11, 0x6c, 0x77 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.data = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLDataJSON>.Value);
        }

        public override int getClassId() => 
            0x3417d728;

        public virtual TLDataJSON getData() => 
            this.data;

        public virtual bool isSave() => 
            ((this.flags & 1) != 0);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 4, 0x6c, 0x8e })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeTLObject(this.data, stream);
        }

        public virtual void setData(TLDataJSON data)
        {
            this.data = data;
        }

        [LineNumberTable(new byte[] { 0x9f, 0x85, 0x42, 0x63, 0x90, 0x8f })]
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
            "inputPaymentCredentials#3417d728";
    }
}

