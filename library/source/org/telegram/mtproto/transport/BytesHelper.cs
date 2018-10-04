namespace org.telegram.mtproto.transport
{
    using IKVM.Attributes;
    using java.io;
    using java.lang;
    using System;
    using System.Runtime.CompilerServices;

    internal class BytesHelper : Object
    {
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(12)]
        internal BytesHelper()
        {
        }

        [LineNumberTable(14)]
        public static byte[] intToBytes(int num1) => 
            new byte[] { ((sbyte) (num1 & 0xff)), ((sbyte) ((num1 >> 8) & 0xff)), ((sbyte) ((num1 >> 0x10) & 0xff)), ((sbyte) ((num1 >> 0x18) & 0xff)) };

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xab, 0x69 })]
        public static void writeByte(int num1, OutputStream stream1)
        {
            stream1.write(num1);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xaf, 0x69 })]
        public static void writeByteArray(byte[] buffer1, OutputStream stream1)
        {
            stream1.write(buffer1);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xa4, 110, 0x70, 0x71, 0x73 })]
        public static void writeInt(int num1, OutputStream stream1)
        {
            stream1.write((sbyte) (num1 & 0xff));
            stream1.write((sbyte) ((num1 >> 8) & 0xff));
            stream1.write((sbyte) ((num1 >> 0x10) & 0xff));
            stream1.write((sbyte) ((num1 >> 0x18) & 0xff));
        }
    }
}

