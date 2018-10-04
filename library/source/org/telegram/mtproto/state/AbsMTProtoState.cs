namespace org.telegram.mtproto.state
{
    using IKVM.Attributes;
    using java.lang;
    using java.util;
    using org.telegram.mtproto.time;
    using System;
    using System.Runtime.CompilerServices;

    public abstract class AbsMTProtoState : Object
    {
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb8, 0x73, 0x7f, 1 })]
        public virtual void addCurrentSalt(long salt)
        {
            int validSince = (int) (((ulong) TimeOverlord.getInstance().getServerTime()) / 0x3e8L);
            KnownSalt[] salts = new KnownSalt[] { new KnownSalt(validSince, validSince + 0x708, salt) };
            this.mergeKnownSalts(validSince, salts);
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xbd, 0x73, 0x7f, 0 })]
        public virtual void badServerSalt(long salt)
        {
            int validSince = (int) (((ulong) TimeOverlord.getInstance().getServerTime()) / 0x3e8L);
            KnownSalt[] ksarr = new KnownSalt[] { new KnownSalt(validSince, validSince + 0x708, salt) };
            this.writeKnownSalts(ksarr);
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 7, 0x67, 0x70, 0x74, 10, 230, 70 })]
        public virtual long findActualSalt(int time)
        {
            KnownSalt[] saltArray2 = this.readKnownSalts();
            int length = saltArray2.Length;
            for (int i = 0; i < length; i++)
            {
                KnownSalt salt = saltArray2[i];
                if ((salt.getValidSince() <= time) && (time <= salt.getValidUntil()))
                {
                    return salt.getSalt();
                }
            }
            return 0L;
        }

        public abstract byte[] getAuthKey();
        public abstract ConnectionInfo[] getAvailableConnections();
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 2, 0x73, 0x7f, 0 })]
        public virtual void initialServerSalt(long salt)
        {
            int validSince = (int) (((ulong) TimeOverlord.getInstance().getServerTime()) / 0x3e8L);
            KnownSalt[] ksarr = new KnownSalt[] { new KnownSalt(validSince, validSince + 0x708, salt) };
            this.writeKnownSalts(ksarr);
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x12, 0x62, 0x75, 0x6a, 4, 230, 0x45 })]
        public virtual int maximumCachedSalts(int time)
        {
            int num = 0;
            KnownSalt[] saltArray = this.readKnownSalts();
            int length = saltArray.Length;
            for (int i = 0; i < length; i++)
            {
                KnownSalt salt = saltArray[i];
                if (salt.getValidSince() > time)
                {
                    num++;
                }
            }
            return num;
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x1c, 0x62, 0x75, 0x2e, 0xa6 })]
        public virtual int maximumCachedSaltsTime()
        {
            int num = 0;
            KnownSalt[] saltArray = this.readKnownSalts();
            int length = saltArray.Length;
            for (int i = 0; i < length; i++)
            {
                num = Math.max(num, saltArray[i].getValidUntil());
            }
            return num;
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 
            0x9f, 0xa6, 0x67, 0x66, 0x73, 0x6a, 130, 0xf5, 60, 0xe8, 70, 0x73, 0x6a, 130, 0xf5, 60,
            0xe8, 70, 0x7e
        })]
        public virtual void mergeKnownSalts(int currentTime, KnownSalt[] salts)
        {
            KnownSalt salt;
            KnownSalt[] saltArray = this.readKnownSalts();
            HashMap map = new HashMap();
            KnownSalt[] saltArray2 = saltArray;
            int length = saltArray2.Length;
            int index = 0;
            while (true)
            {
                if (index >= length)
                {
                    break;
                }
                salt = saltArray2[index];
                if (salt.getValidUntil() >= currentTime)
                {
                    map.put(Long.valueOf(salt.getSalt()), salt);
                }
                index++;
            }
            saltArray2 = salts;
            length = saltArray2.Length;
            index = 0;
            while (true)
            {
                if (index >= length)
                {
                    break;
                }
                salt = saltArray2[index];
                if (salt.getValidUntil() >= currentTime)
                {
                    map.put(Long.valueOf(salt.getSalt()), salt);
                }
                index++;
            }
            this.writeKnownSalts((KnownSalt[]) map.values().toArray(new KnownSalt[0]));
        }

        public abstract KnownSalt[] readKnownSalts();
        protected internal abstract void writeKnownSalts(KnownSalt[] ksarr);
    }
}

