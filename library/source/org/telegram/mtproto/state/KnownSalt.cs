namespace org.telegram.mtproto.state
{
    using IKVM.Attributes;
    using java.lang;
    using System;
    using System.Runtime.CompilerServices;

    public class KnownSalt : Object
    {
        private long salt;
        private int validSince;
        private int validUntil;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9c, 0x68, 0x67, 0x67, 0x67 })]
        public KnownSalt(int validSince, int validUntil, long salt)
        {
            this.validSince = validSince;
            this.validUntil = validUntil;
            this.salt = salt;
        }

        public virtual long getSalt() => 
            this.salt;

        public virtual int getValidSince() => 
            this.validSince;

        public virtual int getValidUntil() => 
            this.validUntil;
    }
}

