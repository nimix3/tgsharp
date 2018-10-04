namespace org.telegram.mtproto.transport
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.lang;
    using java.util;
    using org.telegram.mtproto.log;
    using System;
    using System.Runtime.CompilerServices;
    using System.Threading;

    public class BuffersStorage : Object
    {
        [Modifiers(0x12), Signature("Ljava/util/ArrayList<Lorg/telegram/mtproto/transport/ByteBufferDesc;>;")]
        private ArrayList freeBuffers1024;
        [Modifiers(0x12), Signature("Ljava/util/ArrayList<Lorg/telegram/mtproto/transport/ByteBufferDesc;>;")]
        private ArrayList freeBuffers128;
        [Modifiers(0x12), Signature("Ljava/util/ArrayList<Lorg/telegram/mtproto/transport/ByteBufferDesc;>;")]
        private ArrayList freeBuffers16384;
        [Modifiers(0x12), Signature("Ljava/util/ArrayList<Lorg/telegram/mtproto/transport/ByteBufferDesc;>;")]
        private ArrayList freeBuffers32768;
        [Modifiers(0x12), Signature("Ljava/util/ArrayList<Lorg/telegram/mtproto/transport/ByteBufferDesc;>;")]
        private ArrayList freeBuffers4096;
        [Modifiers(0x12), Signature("Ljava/util/ArrayList<Lorg/telegram/mtproto/transport/ByteBufferDesc;>;")]
        private ArrayList freeBuffersBig;
        private static volatile BuffersStorage Instance = null;
        private bool isThreadSafe;
        [Modifiers(0x1a)]
        private static object sync = new Object();

        [LineNumberTable(new byte[] { 0x9f, 0xa6, 0x8a })]
        static BuffersStorage()
        {
            Thread.MemoryBarrier();
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x84, 0x42, 0x68, 0x67, 0x6b, 0x6b, 0x6b, 0x6b, 0x6b, 0x8b, 0x66, 0x36, 0xa6 })]
        public BuffersStorage(bool threadSafe)
        {
            int num = (int) threadSafe;
            this.isThreadSafe = (bool) num;
            this.freeBuffers128 = new ArrayList();
            this.freeBuffers1024 = new ArrayList();
            this.freeBuffers4096 = new ArrayList();
            this.freeBuffers16384 = new ArrayList();
            this.freeBuffers32768 = new ArrayList();
            this.freeBuffersBig = new ArrayList();
            int num2 = 0;
            while (true)
            {
                if (num2 >= 5)
                {
                    break;
                }
                this.freeBuffers128.add(new ByteBufferDesc(0x80));
                num2++;
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void __<clinit>()
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 
            5, 100, 130, 0x62, 0x62, 0x62, 0x68, 0x67, 0x6b, 0x68, 0x67, 0x6b, 0x68, 0x67, 0x68, 0x68,
            0x67, 0x68, 0x68, 0x67, 0x68, 0x68, 0x67, 0x88, 0xa7, 0x66, 0x68, 0x6c, 0x69, 0x6d, 0x88, 0x91,
            0x69, 0x6d, 200, 0x63, 0x67, 0xdf, 15, 0x72
        })]
        public virtual ByteBufferDesc getFreeBuffer(int size)
        {
            if (size <= 0)
            {
                return null;
            }
            int num = 0;
            ArrayList freeBuffersBig = null;
            ByteBufferDesc desc = null;
            if (size <= 0x80)
            {
                freeBuffersBig = this.freeBuffers128;
                num = 0x80;
            }
            else if (size <= 0x4c8)
            {
                freeBuffersBig = this.freeBuffers1024;
                num = 0x4c8;
            }
            else if (size <= 0x10c8)
            {
                freeBuffersBig = this.freeBuffers4096;
                num = 0x10c8;
            }
            else if (size <= 0x40c8)
            {
                freeBuffersBig = this.freeBuffers16384;
                num = 0x40c8;
            }
            else if (size <= 0x9c40)
            {
                freeBuffersBig = this.freeBuffers32768;
                num = 0x9c40;
            }
            else if (size <= 0x445c0)
            {
                freeBuffersBig = this.freeBuffersBig;
                num = 0x445c0;
            }
            else
            {
                desc = new ByteBufferDesc(size);
            }
            if (freeBuffersBig != null)
            {
                if (this.isThreadSafe)
                {
                    lock (sync)
                    {
                        if (freeBuffersBig.size() > 0)
                        {
                            desc = (ByteBufferDesc) freeBuffersBig.get(0);
                            freeBuffersBig.remove(0);
                        }
                    }
                }
                else if (freeBuffersBig.size() > 0)
                {
                    desc = (ByteBufferDesc) freeBuffersBig.get(0);
                    freeBuffersBig.remove(0);
                }
                if (desc == null)
                {
                    desc = new ByteBufferDesc(num);
                    Logger.d("tmessages", new StringBuilder().append("create new ").append(num).append(" buffer").toString());
                }
            }
            desc.buffer.limit(size).rewind();
            return desc;
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 170, 0x68, 0x63, 0x6c, 0x68, 0x63, 0x94, 0x8f })]
        public static BuffersStorage getInstance()
        {
            BuffersStorage instance = Instance;
            if (instance == null)
            {
                lock (ClassLiteral<BuffersStorage>.Value)
                {
                    instance = Instance;
                    if (instance == null)
                    {
                        Instance = instance = new BuffersStorage(true);
                        Thread.MemoryBarrier();
                    }
                }
            }
            return instance;
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 
            0x3b, 0x63, 0x81, 0x63, 0x62, 0x72, 0x69, 0x72, 0x67, 0x72, 0x69, 0x72, 0x69, 0x72, 0x69, 0x72,
            0x67, 0x83, 0x66, 0x68, 0x6c, 0x69, 0x8a, 0x8f, 0x91, 0x69, 200
        })]
        public virtual void reuseFreeBuffer(ByteBufferDesc buffer)
        {
            if (buffer != null)
            {
                int num = 10;
                ArrayList freeBuffersBig = null;
                if (buffer.buffer.capacity() == 0x80)
                {
                    freeBuffersBig = this.freeBuffers128;
                }
                else if (buffer.buffer.capacity() == 0x4c8)
                {
                    freeBuffersBig = this.freeBuffers1024;
                }
                if (buffer.buffer.capacity() == 0x10c8)
                {
                    freeBuffersBig = this.freeBuffers4096;
                }
                else if (buffer.buffer.capacity() == 0x40c8)
                {
                    freeBuffersBig = this.freeBuffers16384;
                }
                else if (buffer.buffer.capacity() == 0x9c40)
                {
                    freeBuffersBig = this.freeBuffers32768;
                }
                else if (buffer.buffer.capacity() == 0x445c0)
                {
                    freeBuffersBig = this.freeBuffersBig;
                    num = 10;
                }
                if (freeBuffersBig != null)
                {
                    if (this.isThreadSafe)
                    {
                        lock (sync)
                        {
                            if (freeBuffersBig.size() < num)
                            {
                                freeBuffersBig.add(buffer);
                            }
                            else
                            {
                                Logger.w("tmessages", "too more");
                            }
                        }
                    }
                    else if (freeBuffersBig.size() < num)
                    {
                        freeBuffersBig.add(buffer);
                    }
                }
            }
        }
    }
}

