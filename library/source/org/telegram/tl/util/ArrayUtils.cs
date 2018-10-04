namespace org.telegram.tl.util
{
    using IKVM.Attributes;
    using ikvm.internal;
    using IKVM.Runtime;
    using java.lang;
    using java.lang.reflect;
    using System;
    using System.Runtime.CompilerServices;

    public class ArrayUtils : Object
    {
        private const int CACHE_SIZE = 0x49;
        private static object[] EMPTY = new object[0];
        private static object[] sCache = new object[0x49];

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void __<clinit>()
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Signature("<T:Ljava/lang/Object;>(Ljava/lang/Class<TT;>;[TT;TT;)[TT;"), LineNumberTable(new byte[] { 0x68, 0x83, 0x63, 0x74, 0xcc, 0x62, 0x92, 100 })]
        public static object[] appendElement(Class kind, object[] array, object element)
        {
            int length;
            object[] objArray;
            if (array != null)
            {
                length = array.Length;
                objArray = (object[]) Array.newInstance(kind, length + 1);
                ByteCodeHelper.arraycopy(array, 0, objArray, 0, length);
            }
            else
            {
                length = 0;
                objArray = (object[]) Array.newInstance(kind, 1);
            }
            objArray[length] = element;
            return objArray;
        }

        [LineNumberTable(new byte[] { 160, 0x4e, 0x63, 0x8b, 0x63, 0x66, 0x66, 2, 230, 0x45, 0x69, 0x6a, 100 })]
        public static int[] appendInt(int[] cur, int val)
        {
            if (cur == null)
            {
                return new int[] { val };
            }
            int length = cur.Length;
            int index = 0;
            while (true)
            {
                if (index >= length)
                {
                    break;
                }
                if (cur[index] == val)
                {
                    return cur;
                }
                index++;
            }
            int[] numArray = new int[length + 1];
            ByteCodeHelper.arraycopy_primitive_4(cur, 0, numArray, 0, length);
            numArray[length] = val;
            return numArray;
        }

        [LineNumberTable(new byte[] { 0x4d, 0x65, 0x86, 100, 100, 0xe2, 60, 230, 0x47 })]
        public static bool contains(int[] array, int value)
        {
            int[] numArray = array;
            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
                int num3 = numArray[i];
                if (num3 == value)
                {
                    return true;
                }
            }
            return false;
        }

        [MethodImpl(MethodImplOptions.NoInlining), Signature("<T:Ljava/lang/Object;>([TT;TT;)Z"), LineNumberTable(0x5c)]
        public static bool contains(object[] array, object value) => 
            (indexOf(array, value) != -1);

        [MethodImpl(MethodImplOptions.NoInlining), Signature("<T:Ljava/lang/Object;>([TT;[TT;)Z"), LineNumberTable(new byte[] { 0x40, 0x65, 0x86, 100, 0x69, 0xe2, 60, 230, 0x47 })]
        public static bool containsAll(object[] array, object[] check)
        {
            object[] objArray;
            int length = (objArray = check).Length;
            for (int i = 0; i < length; i++)
            {
                object obj2 = objArray[i];
                if (!contains(array, obj2))
                {
                    return false;
                }
            }
            return true;
        }

        [MethodImpl(MethodImplOptions.NoInlining), Signature("<T:Ljava/lang/Object;>(Ljava/lang/Class<TT;>;)[TT;"), LineNumberTable(new byte[] { 0x1b, 0x68, 0x8b, 0x7b, 0x68, 0x91, 0x68, 0x88 })]
        public static object[] emptyArray(Class kind)
        {
            int num;
            int expressionStack_2D_0;
            if (kind == ClassLiteral<Object>.Value)
            {
                return EMPTY;
            }
            if (0x49 != -1)
            {
                int expressionStack_2C_1 = (System.identityHashCode(kind) / 8) & 0x7fffffff;
                int expressionStack_2C_0 = 0x49;
                expressionStack_2D_0 = expressionStack_2C_1 % expressionStack_2C_0;
                goto Label_002D;
            }
            else
            {
                int expressionStack_27_1 = (System.identityHashCode(kind) / 8) & 0x7fffffff;
            }
            expressionStack_2D_0 = 0;
        Label_002D:
            num = expressionStack_2D_0;
            object obj2 = sCache[num];
            if ((obj2 == null) || (Object.instancehelper_getClass(obj2).getComponentType() != kind))
            {
                obj2 = Array.newInstance(kind, 0);
                sCache[num] = obj2;
            }
            return (object[]) obj2;
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 8, 100, 0x8b, 100, 130, 0x70, 130, 0x66, 0x68, 2, 230, 0x45 })]
        public static bool equals(byte[] array1, byte[] array2, int length)
        {
            if (length < 0)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IllegalArgumentException();
            }
            if (array1 != array2)
            {
                if (((array1 == null) || (array2 == null)) || ((array1.Length < length) || (array2.Length < length)))
                {
                    return false;
                }
                for (int i = 0; i < length; i++)
                {
                    if (array1[i] != array2[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x17)]
        public static int idealBooleanArraySize(int need) => 
            idealByteArraySize(need);

        public static int idealByteArraySize(int need)
        {
            for (int i = 4; i < 0x20; i++)
            {
                if (need <= ((((int) 1) << i) - 12))
                {
                    return ((((int) 1) << i) - 12);
                }
            }
            return need;
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x21)]
        public static int idealCharArraySize(int need) => 
            (idealByteArraySize(need * 2) / 2);

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x2b)]
        public static int idealFloatArraySize(int need) => 
            (idealByteArraySize(need * 4) / 4);

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x26)]
        public static int idealIntArraySize(int need) => 
            (idealByteArraySize(need * 4) / 4);

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x35)]
        public static int idealLongArraySize(int need) => 
            (idealByteArraySize(need * 8) / 8);

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x30)]
        public static int idealObjectArraySize(int need) => 
            (idealByteArraySize(need * 4) / 4);

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x1c)]
        public static int idealShortArraySize(int need) => 
            (idealByteArraySize(need * 2) / 2);

        [MethodImpl(MethodImplOptions.NoInlining), Signature("<T:Ljava/lang/Object;>([TT;TT;)I"), LineNumberTable(new byte[] { 0x2f, 0x67, 0x85, 0x63, 0xa2, 110, 0xe2, 0x38, 230, 0x4b })]
        public static int indexOf(object[] array, object value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == null)
                {
                    if (value == null)
                    {
                        return i;
                    }
                }
                else if ((value != null) && Object.instancehelper_equals(array[i], value))
                {
                    return i;
                }
            }
            return -1;
        }

        [MethodImpl(MethodImplOptions.NoInlining), Signature("<T:Ljava/lang/Object;>(Ljava/lang/Class<TT;>;[TT;TT;)[TT;"), LineNumberTable(new byte[] { 0x79, 0x86, 0x63, 0x66, 0x86, 100, 130, 0x74, 0x6a, 0x70, 0xe7, 0x37, 0xe9, 0x4d })]
        public static object[] removeElement(Class kind, object[] array, object element)
        {
            if (array != null)
            {
                int length = array.Length;
                for (int i = 0; i < length; i++)
                {
                    if (array[i] == element)
                    {
                        if (length == 1)
                        {
                            return null;
                        }
                        object[] objArray = (object[]) Array.newInstance(kind, length - 1);
                        ByteCodeHelper.arraycopy(array, 0, objArray, 0, i);
                        ByteCodeHelper.arraycopy(array, i + 1, objArray, i, (length - i) - 1);
                        return objArray;
                    }
                }
            }
            return array;
        }

        [LineNumberTable(new byte[] { 160, 0x5f, 0x63, 130, 0x63, 0x66, 0x86, 0x69, 100, 0x8a, 0x66, 0x90, 0xe2, 0x36, 0xe9, 0x4d })]
        public static int[] removeInt(int[] cur, int val)
        {
            if (cur == null)
            {
                return null;
            }
            int length = cur.Length;
            for (int i = 0; i < length; i++)
            {
                if (cur[i] == val)
                {
                    int[] numArray = new int[length - 1];
                    if (i > 0)
                    {
                        ByteCodeHelper.arraycopy_primitive_4(cur, 0, numArray, 0, i);
                    }
                    if (i < (length - 1))
                    {
                        ByteCodeHelper.arraycopy_primitive_4(cur, i + 1, numArray, i, (length - i) - 1);
                    }
                    return numArray;
                }
            }
            return cur;
        }

        [LineNumberTable(new byte[] { 90, 0x63, 0x65, 0x86, 0x65, 0xe5, 0x3d, 230, 0x45 })]
        public static long total(long[] array)
        {
            long num = 0L;
            long[] numArray = array;
            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
                long num4 = numArray[i];
                num += num4;
            }
            return num;
        }
    }
}

