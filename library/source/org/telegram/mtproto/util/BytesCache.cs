namespace org.telegram.mtproto.util
{
    using IKVM.Attributes;
    using java.lang;
    using java.util;
    using System;
    using System.Runtime.CompilerServices;

    public class BytesCache : Object
    {
        [Signature("Ljava/util/HashSet<[B>;")]
        private HashSet byteBuffer = new HashSet();
        [Signature("Ljava/util/HashMap<Ljava/lang/Integer;Ljava/util/HashSet<[B>;>;")]
        private HashMap fastBuffers = new HashMap();
        private static BytesCache instance = new BytesCache("GlobalByteCache");
        [Signature("Ljava/util/HashSet<[B>;")]
        private HashSet mainFilter = new HashSet();
        [Modifiers(0x12)]
        private int MAX_SIZE = 0xa000;
        [Signature("Ljava/util/WeakHashMap<[B[Ljava/lang/StackTraceElement;>;")]
        private WeakHashMap references = new WeakHashMap();
        [Modifiers(0x12)]
        private int[] SIZES = new int[] { 0x40, 0x80, 0xc00, 0x5000, 0xa000 };
        [Modifiers(0x12)]
        private string TAG;
        [Modifiers(0x12)]
        private bool TRACK_ALLOCATIONS = false;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa5, 0xe8, 0x37, 0x7f, 0x12, 0x6b, 0x87, 0x6b, 0x6b, 0x6b, 0xab, 0x67, 0x6c, 0x3e, 0xa6 })]
        public BytesCache(string logTag)
        {
            this.TAG = logTag;
            int index = 0;
            while (true)
            {
                if (index >= this.SIZES.Length)
                {
                    break;
                }
                this.fastBuffers.put(Integer.valueOf(this.SIZES[index]), new HashSet());
                index++;
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void __<clinit>()
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.Synchronized), LineNumberTable(new byte[] { 
            2, 0x75, 0x6f, 110, 0x7f, 5, 0x7f, 4, 0x6c, 0x86, 0x8d, 0xca, 0xa2, 0xee, 0x30, 0xee,
            0x54, 0x62, 0x7f, 1, 0x65, 130, 0x63, 100, 0x66, 130, 130, 0x63, 0x6d, 0x6d, 170, 0xc2
        })]
        public virtual byte[] allocate(int minSize)
        {
            Iterator iterator;
            byte[] buffer;
            string text1 = this.ToString;
            if (minSize <= 0xa000)
            {
                for (int i = 0; i < this.SIZES.Length; i++)
                {
                    if (minSize < this.SIZES[i])
                    {
                        if (!((HashSet) this.fastBuffers.get(Integer.valueOf(this.SIZES[i]))).isEmpty())
                        {
                            iterator = ((HashSet) this.fastBuffers.get(Integer.valueOf(this.SIZES[i]))).iterator();
                            buffer = (byte[]) iterator.next();
                            iterator.remove();
                            this.mainFilter.remove(buffer);
                            string text2 = this.ToString;
                            return buffer;
                        }
                        return new byte[this.SIZES[i]];
                    }
                }
            }
            else
            {
                byte[] buffer2 = null;
                iterator = this.byteBuffer.iterator();
                while (iterator.hasNext())
                {
                    buffer = (byte[]) iterator.next();
                    if (buffer.Length >= minSize)
                    {
                        if (buffer2 == null)
                        {
                            buffer2 = buffer;
                        }
                        else if (buffer2.Length > buffer.Length)
                        {
                            buffer2 = buffer;
                        }
                    }
                }
                if (buffer2 != null)
                {
                    this.byteBuffer.remove(buffer2);
                    this.mainFilter.remove(buffer2);
                    string text3 = this.ToString;
                    return buffer2;
                }
            }
            return new byte[minSize];
        }

        public static BytesCache getInstance() => 
            instance;

        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.Synchronized), LineNumberTable(new byte[] { 0x9f, 0xb1, 0x8d, 0x71, 0x79, 0x6a, 120, 0xe1, 0x3d, 230, 70, 0x73, 0x81, 0x8d })]
        public virtual void put(byte[] data)
        {
            this.references.remove(data);
            if (this.mainFilter.add(data))
            {
                int[] sIZES = this.SIZES;
                int length = sIZES.Length;
                int index = 0;
                while (true)
                {
                    if (index >= length)
                    {
                        break;
                    }
                    Integer integer = Integer.valueOf(sIZES[index]);
                    if (data.Length == integer.intValue())
                    {
                        ((HashSet) this.fastBuffers.get(integer)).add(data);
                        return;
                    }
                    index++;
                }
                string text1 = this.ToString;
                if (data.Length > 0xa000)
                {
                    this.byteBuffer.add(data);
                }
            }
        }
    }
}

