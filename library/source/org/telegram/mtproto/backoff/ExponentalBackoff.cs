namespace org.telegram.mtproto.backoff
{
    using IKVM.Attributes;
    using java.lang;
    using java.util;
    using java.util.concurrent.atomic;
    using org.telegram.mtproto.log;
    using System;
    using System.Runtime.CompilerServices;

    public class ExponentalBackoff : Object
    {
        private AtomicInteger currentFailureCount = new AtomicInteger();
        private const int MAX_DELAY = 0x3a98;
        private const int MAX_FAILURE_COUNT = 50;
        private const int MIN_DELAY = 100;
        private Random rnd = new Random();
        [Modifiers(0x12)]
        private string TAG;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa2, 0xe8, 0x3d, 0x6b, 0xab, 0x67 })]
        public ExponentalBackoff(string logTag)
        {
            this.TAG = logTag;
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.lang.InterruptedException" }), LineNumberTable(new byte[] { 0x9f, 0xa7, 0x6c, 0x65, 0x6f, 0xa3, 0x8b, 0x68, 0x7f, 0x10, 0x68, 0x6f })]
        public virtual void onFailure()
        {
            int num = this.currentFailureCount.incrementAndGet();
            if (num > 50)
            {
                this.currentFailureCount.compareAndSet(num, 50);
                num = 50;
            }
            int num2 = 100 + (0x12a * num);
            lock (this)
            {
                Logger.d(this.TAG, new StringBuilder().append("onFailure: wait ").append(num2).append(" ms").toString());
                Object.instancehelper_wait(this, (long) num2);
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb6, 0x70, 0x6c, 0x65, 0x6f, 0x83 })]
        public virtual void onFailureNoWait()
        {
            Logger.d(this.TAG, "onFailureNoWait");
            int num = this.currentFailureCount.incrementAndGet();
            if (num > 50)
            {
                this.currentFailureCount.compareAndSet(num, 50);
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xbf, 0x70, 0x68 })]
        public virtual void onSuccess()
        {
            Logger.d(this.TAG, "onSuccess");
            this.reset();
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 4, 0x70, 140, 0x68, 0x66, 0x6f })]
        public virtual void reset()
        {
            Logger.d(this.TAG, "reset");
            this.currentFailureCount.set(0);
            lock (this)
            {
                Object.instancehelper_notifyAll(this);
            }
        }
    }
}

