namespace jawnae.pyronet
{
    using IKVM.Attributes;
    using java.lang;
    using java.nio;
    using java.util;
    using org.telegram.mtproto.transport;
    using System;
    using System.Runtime.CompilerServices;

    public class ByteStream : Object
    {
        [Modifiers(0x12), Signature("Ljava/util/List<Lorg/telegram/mtproto/transport/ByteBufferDesc;>;")]
        private List queue = new ArrayList();

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xac, 0x63, 0x8b, 0x6d })]
        public virtual void append(ByteBufferDesc buf)
        {
            if (buf == null)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new NullPointerException();
            }
            this.queue.add(buf);
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x24, 130, 100, 0x92, 110, 110, 0x63, 0xa2, 0x6d, 0x6b, 0x6f, 130, 0x63, 0x9f, 0x22 })]
        public virtual void discard(int count)
        {
            int num = count;
            while (true)
            {
                if (count <= 0)
                {
                    break;
                }
                ByteBufferDesc buffer = (ByteBufferDesc) this.queue.get(0);
                if (count < buffer.buffer.remaining())
                {
                    buffer.position(buffer.position() + count);
                    count = 0;
                    break;
                }
                this.queue.remove(0);
                BuffersStorage.getInstance().reuseFreeBuffer(buffer);
                count -= buffer.buffer.remaining();
            }
            if (count != 0)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new PyroException(new StringBuilder().append("discarded ").append(num - count).append("/").append(num).append(" bytes").toString());
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 7, 0x63, 0xab, 0x7f, 1, 140, 110, 0x6d, 0x68, 0xa2, 0x88, 0x68, 130, 0x65 })]
        public virtual void get(ByteBuffer dst)
        {
            if (dst == null)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new NullPointerException();
            }
            Iterator iterator = this.queue.iterator();
            do
            {
                if (!iterator.hasNext())
                {
                    break;
                }
                ByteBufferDesc desc = (ByteBufferDesc) iterator.next();
                ByteBuffer buffer = desc.buffer.slice();
                if (buffer.remaining() > dst.remaining())
                {
                    buffer.limit(dst.remaining());
                    dst.put(buffer);
                    break;
                }
                dst.put(buffer);
            }
            while (dst.hasRemaining());
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb7, 0x6c, 0x7f, 1, 0x68, 130, 0x62 })]
        public virtual bool hasData()
        {
            this.queue.size();
            Iterator iterator = this.queue.iterator();
            while (iterator.hasNext())
            {
                ByteBufferDesc desc = (ByteBufferDesc) iterator.next();
                if (desc.hasRemaining())
                {
                    return true;
                }
            }
            return false;
        }
    }
}

