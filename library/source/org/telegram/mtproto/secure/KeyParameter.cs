namespace org.telegram.mtproto.secure
{
    using IKVM.Attributes;
    using IKVM.Runtime;
    using java.lang;
    using System;
    using System.Runtime.CompilerServices;

    public class KeyParameter : Object
    {
        private byte[] key;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x95, 0x6c })]
        public KeyParameter(byte[] key) : this(key, 0, key.Length)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x98, 0x68, 140, 0x71 })]
        public KeyParameter(byte[] key, int keyOff, int keyLen)
        {
            this.key = new byte[keyLen];
            ByteCodeHelper.arraycopy_primitive_1(key, keyOff, this.key, 0, keyLen);
        }

        public virtual byte[] getKey() => 
            this.key;
    }
}

