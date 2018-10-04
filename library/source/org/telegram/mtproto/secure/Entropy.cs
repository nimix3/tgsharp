namespace org.telegram.mtproto.secure
{
    using IKVM.Attributes;
    using java.lang;
    using java.security;
    using System;
    using System.Runtime.CompilerServices;

    public sealed class Entropy : Object
    {
        private static Entropy instance;
        private static SecureRandom random;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 160, 0x86, 0xba, 2, 0x61, 0x8a })]
        private Entropy()
        {
            try
            {
                random = SecureRandom.getInstance("SHA1PRNG");
            }
            catch (NoSuchAlgorithmException)
            {
                random = new SecureRandom();
                return;
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 8, 0x6c, 0x6b, 0x6f })]
        public virtual void feedEntropy(byte[] data)
        {
            lock (random)
            {
                random.setSeed(data);
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xbc, 0x6c, 0x70 })]
        public virtual long generateRandomId()
        {
            long num;
            lock (random)
            {
                long expressionStack_19_0 = random.nextLong();
                goto Label_0019;
                expressionStack_19_0 = num;
            Label_0019:
                num = expressionStack_19_0;
            }
            return num;
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb0, 0x6c, 0x71 })]
        public virtual byte[] generateSeed(int size)
        {
            byte[] buffer;
            lock (random)
            {
                byte[] expressionStack_1A_0 = random.generateSeed(size);
                goto Label_001A;
                expressionStack_1A_0 = buffer;
            Label_001A:
                buffer = expressionStack_1A_0;
            }
            return buffer;
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb6, 0x6c, 120 })]
        public virtual byte[] generateSeed(byte[] sourceSeed)
        {
            byte[] buffer;
            lock (random)
            {
                byte[] expressionStack_21_0 = CryptoUtils.xor(random.generateSeed(sourceSeed.Length), sourceSeed);
                goto Label_0021;
                expressionStack_21_0 = buffer;
            Label_0021:
                buffer = expressionStack_21_0;
            }
            return buffer;
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa9, 0x67, 0x8a })]
        public static Entropy getInstance()
        {
            if (instance == null)
            {
                instance = new Entropy();
            }
            return instance;
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 2, 0x6c, 0x70 })]
        public virtual int randomInt()
        {
            int num;
            lock (random)
            {
                int expressionStack_19_0 = random.nextInt();
                goto Label_0019;
                expressionStack_19_0 = num;
            Label_0019:
                num = expressionStack_19_0;
            }
            return num;
        }
    }
}

