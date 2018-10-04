namespace org.telegram.api.update.encrypted
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.api.encrypted.message;
    using org.telegram.api.update;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLUpdateNewEncryptedMessage : TLAbsUpdate
    {
        public const int CLASS_ID = 0x12bcbd9a;
        private TLAbsEncryptedMessage message;
        private int qts;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 170, 0x68 })]
        public TLUpdateNewEncryptedMessage()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLUpdateNewEncryptedMessage(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x1d, 0x72, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.message = StreamingUtils.readTLObject(stream, context);
            this.qts = StreamingUtils.readInt(stream);
        }

        public override int getClassId() => 
            0x12bcbd9a;

        public virtual TLAbsEncryptedMessage getMessage() => 
            this.message;

        public virtual int getQts() => 
            this.qts;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x17, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.message, stream);
            StreamingUtils.writeInt(this.qts, stream);
        }

        public virtual void setMessage(TLAbsEncryptedMessage message)
        {
            this.message = message;
        }

        public virtual void setQts(int qts)
        {
            this.qts = qts;
        }

        public override string toString() => 
            "updateNewEncryptedMessage#12bcbd9a";
    }
}

