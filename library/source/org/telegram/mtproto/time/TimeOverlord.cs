namespace org.telegram.mtproto.time
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.lang;
    using System;
    using System.Runtime.CompilerServices;

    public class TimeOverlord : Object
    {
        private static TimeOverlord instance;
        private long nanotimeShift = (System.currentTimeMillis() - ((long) (((ulong) System.nanoTime()) / 0x3e8L)));
        private long timeAccuracy = 0x7fffffffffffffffL;
        protected internal long timeDelta;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9d, 40, 0x8f, 120 })]
        private TimeOverlord()
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x1b)]
        public virtual long createWeakMessageId() => 
            ((long) ((this.getServerTime() / 0x3e8L) << 0x20));

        [MethodImpl(MethodImplOptions.NoInlining), Modifiers(0x29), LineNumberTable(new byte[] { 0x9f, 0x89, 0x4c, 0x67, 0x8a })]
        public static TimeOverlord getInstance()
        {
            lock (ClassLiteral<TimeOverlord>.Value)
            {
                if (instance == null)
                {
                    instance = new TimeOverlord();
                }
                return instance;
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x1f)]
        public virtual long getLocalTime() => 
            System.currentTimeMillis();

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x23)]
        public virtual long getServerTime() => 
            (this.getLocalTime() + this.timeDelta);

        public virtual long getTimeAccuracy() => 
            this.timeAccuracy;

        public virtual long getTimeDelta() => 
            this.timeDelta;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 2, 110, 0x67 })]
        public virtual void onForcedServerTimeArrived(long serverTime, long duration)
        {
            this.timeDelta = serverTime - this.getLocalTime();
            this.timeAccuracy = duration;
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 20, 0x65, 0xa1, 0x74 })]
        public virtual void onMethodExecuted(long sentId, long responseId, long duration)
        {
            if (duration >= 0L)
            {
                this.onServerTimeArrived((long) (((ulong) (responseId >> 0x20)) * 0x3e8L), duration);
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 7, 0x65, 0x81, 0x69, 110, 0x69, 0x7d, 110, 0x87 })]
        public virtual void onServerTimeArrived(long serverTime, long duration)
        {
            if (duration >= 0L)
            {
                if (duration < this.timeAccuracy)
                {
                    this.timeDelta = serverTime - this.getLocalTime();
                    this.timeAccuracy = duration;
                }
                else if (Math.abs(this.getLocalTime() - serverTime) > ((duration / 2L) + (this.timeAccuracy / 2L)))
                {
                    this.timeDelta = serverTime - this.getLocalTime();
                    this.timeAccuracy = duration;
                }
            }
        }

        public virtual void setTimeDelta(long timeDelta, long timeAccuracy)
        {
            this.timeDelta = timeDelta;
            this.timeAccuracy = timeAccuracy;
        }
    }
}

