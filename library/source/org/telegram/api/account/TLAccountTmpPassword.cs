namespace org.telegram.api.account
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLAccountTmpPassword : TLObject
    {
        public const int CLASS_ID = -614138572;
        private TLBytes tmpPassword;
        private int validUntil;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa8, 0x68 })]
        public TLAccountTmpPassword()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAccountTmpPassword(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 2, 0x6d, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.tmpPassword = StreamingUtils.readTLBytes(stream, context);
            this.validUntil = StreamingUtils.readInt(stream);
        }

        public override int getClassId() => 
            -614138572;

        public virtual TLBytes getTmpPassword() => 
            this.tmpPassword;

        public virtual int getValidUntil() => 
            this.validUntil;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xbb, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLBytes(this.tmpPassword, stream);
            StreamingUtils.writeInt(this.validUntil, stream);
        }

        public override string toString() => 
            "account.tmpPassword#db64fd34";
    }
}

