namespace org.telegram.tl
{
    using IKVM.Attributes;
    using IKVM.Runtime;
    using java.io;
    using java.lang;
    using org.telegram.mtproto.log;
    using System;
    using System.Runtime.CompilerServices;

    public class StreamingUtils : Object
    {
        [LineNumberTable(540)]
        public static byte[] intToBytes(int value) => 
            new byte[] { ((sbyte) (value & 0xff)), ((sbyte) ((value >> 8) & 0xff)), ((sbyte) ((value >> 0x10) & 0xff)), ((sbyte) ((value >> 0x18) & 0xff)) };

        [LineNumberTable(0x22a)]
        public static byte[] longToBytes(long value) => 
            new byte[] { ((sbyte) ((int) (((ulong) value) & 0xffL))), ((sbyte) ((int) (((ulong) (value >> 8)) & 0xffL))), ((sbyte) ((int) (((ulong) (value >> 0x10)) & 0xffL))), ((sbyte) ((int) (((ulong) (value >> 0x18)) & 0xffL))), ((sbyte) ((int) (((ulong) (value >> 0x20)) & 0xffL))), ((sbyte) ((int) (((ulong) (value >> 40)) & 0xffL))), ((sbyte) ((int) (((ulong) (value >> 0x30)) & 0xffL))), ((sbyte) ((int) (((ulong) (value >> 0x38)) & 0xffL))) };

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 160, 0x71, 0x67, 100, 0x8b, 0x67, 100, 0x8b, 0x67, 100, 0x8b, 0x67, 100, 0xab })]
        public static int ºreadInt(InputStream stream)
        {
            int num = stream.read();
            if (num < 0)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IOException();
            }
            int num2 = stream.read();
            if (num2 < 0)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IOException();
            }
            int num3 = stream.read();
            if (num3 < 0)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IOException();
            }
            int num4 = stream.read();
            if (num4 < 0)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IOException();
            }
            return (((num + (num2 << 8)) + (num3 << 0x10)) + (num4 << 0x18));
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 160, 0xea, 0x67, 0x62, 0x65, 0x6d, 100, 0x66, 100, 0x8b, 0x85, 0x62 })]
        public static byte[] readBytes(int count, InputStream stream)
        {
            byte[] buffer = new byte[count];
            int num = 0;
            while (num < buffer.Length)
            {
                int num2 = stream.read(buffer, num, buffer.Length - num);
                if (num2 > 0)
                {
                    num += num2;
                }
                else
                {
                    if (num2 < 0)
                    {
                        Throwable.__<suppressFillInStackTrace>();
                        throw new IOException();
                    }
                    Thread.yield();
                }
            }
            return buffer;
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0xa1, 0x16, 0x62, 100, 110, 100, 0x66, 100, 0x8b, 0x85, 0x62 })]
        public static void readBytes(byte[] buffer, int offset, int count, InputStream stream)
        {
            int num = 0;
            while (num < count)
            {
                int num2 = stream.read(buffer, num + offset, count - num);
                if (num2 > 0)
                {
                    num += num2;
                }
                else
                {
                    if (num2 < 0)
                    {
                        Throwable.__<suppressFillInStackTrace>();
                        throw new IOException();
                    }
                    Thread.yield();
                }
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(0x129)]
        public static double readDouble(InputStream stream)
        {
            DoubleConverter converter;
            return DoubleConverter.ToDouble(readLong(stream), ref converter);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0xa1, 0xde, 0x62, 0x66, 0x30, 0xa6 })]
        public static int readInt(InputStream stream)
        {
            int num = 0;
            for (int i = 0; i < 4; i++)
            {
                num |= stream.read() << (i * 8);
            }
            return num;
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x23c)]
        public static int readInt(byte[] src) => 
            readInt(src, 0);

        [LineNumberTable(new byte[] { 0xa1, 0xd5, 0x66, 0x66, 0x66, 0x86 })]
        public static int readInt(byte[] src, int offset)
        {
            int num = src[offset + 0];
            int num2 = src[offset + 1];
            int num3 = src[offset + 2];
            int num4 = src[offset + 3];
            return (((num + (num2 << 8)) + (num3 << 0x10)) + (num4 << 0x18));
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 160, 0xa9, 0x67, 0x87 })]
        public static long readLong(InputStream stream)
        {
            long num = readUInt(stream);
            long num2 = readUInt(stream);
            return (num + (num2 << 0x20));
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0xa2, 7, 0x68, 0x8a })]
        public static long readLong(byte[] src, int offset)
        {
            long num = readUInt(src, offset);
            long num2 = readUInt(src, offset + 4);
            return ((num & -1L) + ((num2 & -1L) << 0x20));
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0xa1, 0x9a, 0x67, 0x68, 0x62, 0x68, 130 })]
        public static bool readTLBool(InputStream stream)
        {
            int num = readInt(stream);
            switch (num)
            {
                case -1720552011:
                    return true;

                case -1132882121:
                    return false;
            }
            Throwable.__<suppressFillInStackTrace>();
            throw new DeserializeException(new StringBuilder().append("Not bool value: ").append(Integer.toHexString(num)).toString());
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0xa1, 0x2b, 0x67, 0x62, 0x68, 0x7a, 0xa2, 0x68, 0x6f, 0x63, 0x65, 0xa8 })]
        public static byte[] readTLBytes(InputStream stream)
        {
            int num3;
            int expressionStack_43_0;
            int count = stream.read();
            int num2 = 1;
            if (count >= 0xfe)
            {
                count = (stream.read() + (stream.read() << 8)) + (stream.read() << 0x10);
                num2 = 4;
            }
            byte[] buffer = readBytes(count, stream);
            if (4 != -1)
            {
                int expressionStack_42_1 = count + num2;
                int expressionStack_42_0 = 4;
                expressionStack_43_0 = expressionStack_42_1 % expressionStack_42_0;
                goto Label_0043;
            }
            else
            {
                int expressionStack_3D_1 = count + num2;
            }
            expressionStack_43_0 = 0;
        Label_0043:
            num3 = expressionStack_43_0;
            if (num3 != 0)
            {
                int num4 = 4 - num3;
                skipBytes(num4, stream);
            }
            return buffer;
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0xa1, 0x45, 0x67, 0x62, 0x68, 0x7a, 130, 0x68, 0x98, 0x6f, 0x63, 0x65, 0x88 })]
        public static TLBytes readTLBytes(InputStream stream, TLContext context)
        {
            int num3;
            int expressionStack_5B_0;
            int size = stream.read();
            int num2 = 1;
            if (size >= 0xfe)
            {
                size = (stream.read() + (stream.read() << 8)) + (stream.read() << 0x10);
                num2 = 4;
            }
            TLBytes bytes = context.allocateBytes(size);
            readBytes(bytes.getData(), bytes.getOffset(), bytes.getLength(), stream);
            if (4 != -1)
            {
                int expressionStack_5A_1 = size + num2;
                int expressionStack_5A_0 = 4;
                expressionStack_5B_0 = expressionStack_5A_1 % expressionStack_5A_0;
                goto Label_005B;
            }
            else
            {
                int expressionStack_55_1 = size + num2;
            }
            expressionStack_5B_0 = 0;
        Label_005B:
            num3 = expressionStack_5B_0;
            if (num3 != 0)
            {
                int count = 4 - num3;
                skipBytes(count, stream);
            }
            return bytes;
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(0x1e9)]
        public static TLIntVector readTLIntVector(InputStream stream, TLContext context) => 
            context.deserializeIntVector(stream);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(0x1f5)]
        public static TLLongVector readTLLongVector(InputStream stream, TLContext context) => 
            context.deserializeLongVector(stream);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(0x150)]
        public static TLMethod readTLMethod(InputStream stream, TLContext context) => 
            ((TLMethod) context.deserializeMessage(stream));

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(320)]
        public static TLObject readTLObject(InputStream stream, TLContext context) => 
            context.deserializeMessage(stream);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Signature("<T:Lorg/telegram/tl/TLObject;>(Ljava/io/InputStream;Lorg/telegram/tl/TLContext;Ljava/lang/Class<TT;>;)TT;"), LineNumberTable(0x144)]
        public static TLObject readTLObject(InputStream stream, TLContext context, Class type) => 
            context.deserializeMessage(stream);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(0x134)]
        public static string readTLString(InputStream stream) => 
            String.newhelper(readTLBytes(stream));

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(0x201)]
        public static TLStringVector readTLStringVector(InputStream stream, TLContext context) => 
            context.deserializeStringVector(stream);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(0x1d1)]
        public static TLVector readTLVector(InputStream stream, TLContext context) => 
            context.deserializeVector(stream);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Signature("<T:Ljava/lang/Object;>(Ljava/io/InputStream;Lorg/telegram/tl/TLContext;Ljava/lang/Class<TT;>;)Lorg/telegram/tl/TLVector<TT;>;"), LineNumberTable(0x1dd)]
        public static TLVector readTLVector(InputStream stream, TLContext context, Class vectorType) => 
            context.deserializeVector(stream);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 160, 0x8d, 0x68, 0x65, 0x8b, 0x68, 0x65, 0x8b, 0x68, 0x65, 0x8b, 0x68, 0x65, 0xab })]
        public static long readUInt(InputStream stream)
        {
            long num = stream.read();
            if (num < 0L)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IOException();
            }
            long num2 = stream.read();
            if (num2 < 0L)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IOException();
            }
            long num3 = stream.read();
            if (num3 < 0L)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IOException();
            }
            long num4 = stream.read();
            if (num4 < 0L)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IOException();
            }
            return (((num + (num2 << 8)) + (num3 << 0x10)) + (num4 << 0x18));
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x25e)]
        public static long readUInt(byte[] src) => 
            readUInt(src, 0);

        [LineNumberTable(new byte[] { 0xa1, 0xf7, 0x67, 0x67, 0x67, 0x87 })]
        public static long readUInt(byte[] src, int offset)
        {
            long num = src[offset + 0];
            long num2 = src[offset + 1];
            long num3 = src[offset + 2];
            long num4 = src[offset + 3];
            return (((num + (num2 << 8)) + (num3 << 0x10)) + (num4 << 0x18));
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0xa1, 6, 0x67, 0x68, 0x9f, 0x17 })]
        public static void skipBytes(int count, InputStream stream)
        {
            byte[] buffer = new byte[count];
            stream.read(buffer);
            Logger.d("SKIPED", new StringBuilder().append("Skypped ").append(count).append(" bytes: ").append(buffer).toString());
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0x86, 0xa3, 0x69 })]
        public static void writeByte(byte v, OutputStream stream)
        {
            int num = (sbyte) v;
            stream.write(num);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xa6, 0x69 })]
        public static void writeByte(int v, OutputStream stream)
        {
            stream.write(v);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 40, 0x69 })]
        public static void writeByteArray(byte[] data, OutputStream stream)
        {
            stream.write(data);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x33, 0x6b })]
        public static void writeByteArray(byte[] data, int offset, int len, OutputStream stream)
        {
            stream.write(data, offset, len);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x1d, 0x6f })]
        public static void writeDouble(double v, OutputStream stream)
        {
            writeLong(Double.doubleToLongBits(v), stream);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xbc, 110, 0x70, 0x71, 0x73 })]
        public static void writeInt(int v, OutputStream stream)
        {
            writeByte((byte) ((sbyte) (v & 0xff)), stream);
            writeByte((byte) ((sbyte) ((v >> 8) & 0xff)), stream);
            writeByte((byte) ((sbyte) ((v >> 0x10) & 0xff)), stream);
            writeByte((byte) ((sbyte) ((v >> 0x18) & 0xff)), stream);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 10, 0x70, 0x72, 0x73, 0x93, 0x73, 0x73, 0x73, 0x75 })]
        public static void writeLong(long v, OutputStream stream)
        {
            writeByte((byte) ((sbyte) ((int) (((ulong) v) & 0xffL))), stream);
            writeByte((byte) ((sbyte) ((int) (((ulong) (v >> 8)) & 0xffL))), stream);
            writeByte((byte) ((sbyte) ((int) (((ulong) (v >> 0x10)) & 0xffL))), stream);
            writeByte((byte) ((sbyte) ((int) (((ulong) (v >> 0x18)) & 0xffL))), stream);
            writeByte((byte) ((sbyte) ((int) (((ulong) (v >> 0x20)) & 0xffL))), stream);
            writeByte((byte) ((sbyte) ((int) (((ulong) (v >> 40)) & 0xffL))), stream);
            writeByte((byte) ((sbyte) ((int) (((ulong) (v >> 0x30)) & 0xffL))), stream);
            writeByte((byte) ((sbyte) ((int) (((ulong) (v >> 0x38)) & 0xffL))), stream);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0x72, 0x42, 0x63, 0x8d, 0x8d })]
        public static void writeTLBool(bool v, OutputStream stream)
        {
            if (v)
            {
                writeInt(-1720552011, stream);
            }
            else
            {
                writeInt(-1132882121, stream);
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x74, 0x62, 0x6d, 0x62, 0x6b, 0x72, 0x74, 0x97, 0xac, 0x98, 0x74, 0x63, 100, 0x8e })]
        public static void writeTLBytes(TLBytes v, OutputStream stream)
        {
            int num2;
            int expressionStack_90_0;
            int num = 1;
            if (v.getLength() >= 0xfe)
            {
                num = 4;
                writeByte(0xfe, stream);
                writeByte((int) (v.getLength() & 0xff), stream);
                writeByte((int) ((v.getLength() >> 8) & 0xff), stream);
                writeByte((int) ((v.getLength() >> 0x10) & 0xff), stream);
            }
            else
            {
                writeByte(v.getLength(), stream);
            }
            writeByteArray(v.getData(), v.getOffset(), v.getLength(), stream);
            if (4 != -1)
            {
                int expressionStack_8F_1 = v.getLength() + num;
                int expressionStack_8F_0 = 4;
                expressionStack_90_0 = expressionStack_8F_1 % expressionStack_8F_0;
                goto Label_0090;
            }
            else
            {
                int expressionStack_8A_1 = v.getLength() + num;
            }
            expressionStack_90_0 = 0;
        Label_0090:
            num2 = expressionStack_90_0;
            if (num2 != 0)
            {
                int num3 = 4 - num2;
                writeByteArray(new byte[num3], stream);
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x58, 0x62, 0x69, 0x62, 0x6b, 110, 0x70, 0x93, 0xa8, 0x87, 0x70, 0x63, 100, 0x8e })]
        public static void writeTLBytes(byte[] v, OutputStream stream)
        {
            int num2;
            int expressionStack_67_0;
            int num = 1;
            if (v.Length >= 0xfe)
            {
                num = 4;
                writeByte(0xfe, stream);
                writeByte((int) (v.Length & 0xff), stream);
                writeByte((int) ((v.Length >> 8) & 0xff), stream);
                writeByte((int) ((v.Length >> 0x10) & 0xff), stream);
            }
            else
            {
                writeByte(v.Length, stream);
            }
            writeByteArray(v, stream);
            if (4 != -1)
            {
                int expressionStack_66_1 = v.Length + num;
                int expressionStack_66_0 = 4;
                expressionStack_67_0 = expressionStack_66_1 % expressionStack_66_0;
                goto Label_0067;
            }
            else
            {
                int expressionStack_61_1 = v.Length + num;
            }
            expressionStack_67_0 = 0;
        Label_0067:
            num2 = expressionStack_67_0;
            if (num2 != 0)
            {
                int num3 = 4 - num2;
                writeByteArray(new byte[num3], stream);
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 160, 0x5b, 0x69 })]
        public static void writeTLMethod(TLMethod v, OutputStream stream)
        {
            writeTLObject(v, stream);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 160, 80, 0x69 })]
        public static void writeTLObject(TLObject v, OutputStream stream)
        {
            v.serialize(stream);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x4d, 110 })]
        public static void writeTLString(string v, OutputStream stream)
        {
            writeTLBytes(String.instancehelper_getBytes(v), stream);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 160, 0x66, 0x69 })]
        public static void writeTLVector(TLVector v, OutputStream stream)
        {
            writeTLObject(v, stream);
        }
    }
}

