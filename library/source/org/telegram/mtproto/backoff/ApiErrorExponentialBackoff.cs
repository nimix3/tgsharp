namespace org.telegram.mtproto.backoff
{
    using IKVM.Attributes;
    using IKVM.Runtime;
    using java.lang;
    using System;
    using System.Runtime.CompilerServices;

    public class ApiErrorExponentialBackoff : Object
    {
        private int currentIntervalMillis;
        public const int DEFAULT_INITIAL_INTERVAL_MILLIS = 100;
        public const int DEFAULT_MAX_ELAPSED_TIME_MILLIS = 0x493e0;
        public const int DEFAULT_MAX_INTERVAL_MILLIS = 0x7530;
        public const double DEFAULT_MULTIPLIER = 1.5;
        public const double DEFAULT_RANDOMIZATION_FACTOR = 0.5;
        [Modifiers(0x12)]
        private int initialIntervalMillis;
        [Modifiers(0x12)]
        private int maxElapsedTimeMillis;
        [Modifiers(0x12)]
        private int maxIntervalMillis;
        [Modifiers(0x12)]
        private double multiplier;
        [Modifiers(0x12)]
        private double randomizationFactor;
        internal long startTimeNanos;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x5b, 0x6d })]
        public ApiErrorExponentialBackoff() : this(new Builder())
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x61, 0x68, 0x6c, 0x6d, 0x6d, 0x6c, 0x6c, 0x68 })]
        protected internal ApiErrorExponentialBackoff(Builder builder)
        {
            this.initialIntervalMillis = builder.initialIntervalMillis;
            this.randomizationFactor = builder.randomizationFactor;
            this.multiplier = builder.multiplier;
            this.maxIntervalMillis = builder.maxIntervalMillis;
            this.maxElapsedTimeMillis = builder.maxElapsedTimeMillis;
            this.reset();
        }

        public int getCurrentIntervalMillis() => 
            this.currentIntervalMillis;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x106)]
        public long getElapsedTimeMillis() => 
            ((long) (((ulong) (this.nanoTime() - this.startTimeNanos)) / 0xf4240L));

        public int getInitialIntervalMillis() => 
            this.initialIntervalMillis;

        public int getMaxElapsedTimeMillis() => 
            this.maxElapsedTimeMillis;

        public int getMaxIntervalMillis() => 
            this.maxIntervalMillis;

        public double getMultiplier() => 
            this.multiplier;

        public double getRandomizationFactor() => 
            this.randomizationFactor;

        internal static int getRandomValueFromInterval(double num1, double num6, int num5)
        {
            double num = num1 * num5;
            double num2 = num5 - num;
            double num3 = num5 + num;
            return ByteCodeHelper.d2i(num2 + (num6 * ((num3 - num2) + 1f)));
        }

        [LineNumberTable(new byte[] { 160, 0x9c, 0x77, 0x8e, 0x99 })]
        private void incrementCurrentInterval()
        {
            if (this.currentIntervalMillis >= (((double) this.maxIntervalMillis) / this.multiplier))
            {
                this.currentIntervalMillis = this.maxIntervalMillis;
            }
            else
            {
                this.currentIntervalMillis = ByteCodeHelper.d2i(this.currentIntervalMillis * this.multiplier);
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x11a)]
        private long nanoTime() => 
            System.nanoTime();

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x7e, 0x6f, 0x88, 0x66, 0x71, 0x66 })]
        public virtual long nextBackOffMillis()
        {
            if (this.getElapsedTimeMillis() > this.maxElapsedTimeMillis)
            {
                return (long) this.maxElapsedTimeMillis;
            }
            int num = getRandomValueFromInterval(this.randomizationFactor, Math.random(), this.currentIntervalMillis);
            this.incrementCurrentInterval();
            return (long) num;
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x6c, 0x6c, 0x6c })]
        public void reset()
        {
            this.currentIntervalMillis = this.initialIntervalMillis;
            this.startTimeNanos = this.nanoTime();
        }

        public class Builder : Object
        {
            internal int initialIntervalMillis = 100;
            internal int maxElapsedTimeMillis = 0x493e0;
            internal int maxIntervalMillis = 0x7530;
            internal double multiplier = 1.5;
            internal double randomizationFactor = 0.5;

            [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x148)]
            public virtual ApiErrorExponentialBackoff build() => 
                new ApiErrorExponentialBackoff(this);

            public int getInitialIntervalMillis() => 
                this.initialIntervalMillis;

            public int getMaxElapsedTimeMillis() => 
                this.maxElapsedTimeMillis;

            public int getMaxIntervalMillis() => 
                this.maxIntervalMillis;

            public double getMultiplier() => 
                this.multiplier;

            public double getRandomizationFactor() => 
                this.randomizationFactor;

            public virtual ApiErrorExponentialBackoff.Builder setInitialIntervalMillis(int initialIntervalMillis)
            {
                this.initialIntervalMillis = initialIntervalMillis;
                return this;
            }

            public virtual ApiErrorExponentialBackoff.Builder setMaxElapsedTimeMillis(int maxElapsedTimeMillis)
            {
                this.maxElapsedTimeMillis = maxElapsedTimeMillis;
                return this;
            }

            public virtual ApiErrorExponentialBackoff.Builder setMaxIntervalMillis(int maxIntervalMillis)
            {
                this.maxIntervalMillis = maxIntervalMillis;
                return this;
            }

            public virtual ApiErrorExponentialBackoff.Builder setMultiplier(double multiplier)
            {
                this.multiplier = multiplier;
                return this;
            }

            public virtual ApiErrorExponentialBackoff.Builder setRandomizationFactor(double randomizationFactor)
            {
                this.randomizationFactor = randomizationFactor;
                return this;
            }
        }
    }
}

