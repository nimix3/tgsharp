namespace org.telegram.tl
{
    using IKVM.Attributes;
    using IKVM.Runtime;
    using java.lang;
    using System;
    using System.Runtime.CompilerServices;

    public class TLBytes : Object
    {
        private byte[] data;
        private int len;
        private int offset;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x99, 0x68, 0x67, 0x67, 0x68 })]
        public TLBytes(byte[] data)
        {
            this.data = data;
            this.offset = 0;
            this.len = data.Length;
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9f, 0x68, 0x67, 0x67, 0x67 })]
        public TLBytes(byte[] data, int offset, int len)
        {
            this.data = data;
            this.offset = offset;
            this.len = len;
        }

        [LineNumberTable(new byte[] { 0x9f, 0xb2, 0x77, 0x87, 0x6c, 0x79 })]
        public virtual byte[] cleanData()
        {
            if ((this.offset == 0) && (this.len == this.data.Length))
            {
                return this.data;
            }
            byte[] buffer = new byte[this.len];
            ByteCodeHelper.arraycopy_primitive_1(this.data, this.offset, buffer, 0, this.len);
            return buffer;
        }

        public virtual byte[] getData() => 
            this.data;

        public virtual int getLength() => 
            this.len;

        public virtual int getOffset() => 
            this.offset;
    }
}

