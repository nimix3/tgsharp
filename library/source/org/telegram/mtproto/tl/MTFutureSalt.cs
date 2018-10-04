namespace org.telegram.mtproto.tl
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class MTFutureSalt : TLObject
    {
        public const int CLASS_ID = 0x949d9dc;
        private long salt;
        private int validSince;
        private int validUntil;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb1, 0x88 })]
        public MTFutureSalt()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected MTFutureSalt(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xab, 0x68, 0x67, 0x67, 0x67 })]
        public MTFutureSalt(int validSince, int validUntil, long salt)
        {
            this.validSince = validSince;
            this.validUntil = validUntil;
            this.salt = salt;
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 15, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.validSince = StreamingUtils.readInt(stream);
            this.validUntil = StreamingUtils.readInt(stream);
            this.salt = StreamingUtils.readLong(stream);
        }

        public override int getClassId() => 
            0x949d9dc;

        public virtual long getSalt() => 
            this.salt;

        public virtual int getValidSince() => 
            this.validSince;

        public virtual int getValidUntil() => 
            this.validUntil;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 8, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.validSince, stream);
            StreamingUtils.writeInt(this.validUntil, stream);
            StreamingUtils.writeLong(this.salt, stream);
        }

        public override string toString() => 
            "future_salt#0949d9dc";
    }
}

