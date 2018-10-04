namespace org.telegram.tl.util
{
    using IKVM.Attributes;
    using java.lang;
    using System;
    using System.Runtime.CompilerServices;

    internal class ContainerHelpers : Object
    {
        [Modifiers(0x18)]
        internal static bool[] EMPTY_BOOLEANS = new bool[0];
        [Modifiers(0x18)]
        internal static int[] EMPTY_INTS = new int[0];
        [Modifiers(0x18)]
        internal static long[] EMPTY_LONGS = new long[0];
        [Modifiers(0x18)]
        internal static object[] EMPTY_OBJECTS = new object[0];

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(3)]
        internal ContainerHelpers()
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void __<clinit>()
        {
        }

        [LineNumberTable(new byte[] { 0x9f, 0x9a, 0x62, 100, 0x84, 0x66, 100, 100, 0x66, 100, 0x86, 130, 0x62 })]
        internal static int binarySearch(int[] numArray1, int num1, int num5)
        {
            int num = 0;
            int num2 = num1 - 1;
        Label_0006:
            if (num > num2)
            {
                return (num ^ -1);
            }
            int index = (num + num2) >> 1;
            int num4 = numArray1[index];
            if (num4 < num5)
            {
                num = index + 1;
                goto Label_0006;
            }
            if (num4 > num5)
            {
                num2 = index - 1;
                goto Label_0006;
            }
            return index;
        }

        [LineNumberTable(new byte[] { 0x9f, 0xad, 0x62, 100, 0x84, 0x66, 100, 100, 0x66, 100, 0x86, 130, 0x62 })]
        internal static int binarySearch(long[] numArray1, int num1, long num5)
        {
            int num = 0;
            int num2 = num1 - 1;
        Label_0006:
            if (num > num2)
            {
                return (num ^ -1);
            }
            int index = (num + num2) >> 1;
            long num4 = numArray1[index];
            if (num4 < num5)
            {
                num = index + 1;
                goto Label_0006;
            }
            if (num4 > num5)
            {
                num2 = index - 1;
                goto Label_0006;
            }
            return index;
        }
    }
}

