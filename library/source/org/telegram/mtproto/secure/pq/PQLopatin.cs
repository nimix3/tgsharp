namespace org.telegram.mtproto.secure.pq
{
    using IKVM.Attributes;
    using java.lang;
    using java.util;
    using System;
    using System.Runtime.CompilerServices;

    public class PQLopatin : Object, PQImplementation
    {
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(11)]
        public virtual long findDivider(long src) => 
            this.findSmallMultiplierLopatin(src);

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 
            0x9f, 0xae, 0x66, 0x63, 0x62, 0x69, 0x73, 0x74, 0x6b, 0x6c, 100, 0x6d, 0x66, 0x69, 0x67, 0x65,
            0xa6, 0x67, 0x65, 0x86, 0x88, 100, 0x74, 0x6a, 0x65, 130, 0x69, 0xe4, 0x29, 0xeb, 90, 0x65,
            0xe2, 0x21, 0xe9, 0x63, 110
        })]
        private long findSmallMultiplierLopatin(long num1)
        {
            long num13;
            long expressionStack_F6_1;
            long expressionStack_FB_0;
            Random random = new Random();
            long num = 0L;
            int num2 = 0;
            int num3 = 0;
        Label_000D:
            if (num3 >= 3)
            {
                goto Label_00EF;
            }
            int num4 = (random.nextInt(0x80) & 15) + 0x11;
            long num5 = random.nextInt(0x3b9aca00) + 1;
            long num6 = num5;
            int num7 = ((int) 1) << (num3 + 0x12);
            int num8 = 1;
        Label_0049:
            if (num8 < num7)
            {
                long expressionStack_B4_0;
                num2++;
                long num9 = num5;
                long num10 = num5;
                long num11 = num4;
                while (true)
                {
                    if (num10 == 0L)
                    {
                        break;
                    }
                    if ((num10 & 1L) != 0L)
                    {
                        num11 += num9;
                        if (num11 >= num1)
                        {
                            num11 -= num1;
                        }
                    }
                    num9 += num9;
                    if (num9 >= num1)
                    {
                        num9 -= num1;
                    }
                    num10 = num10 >> 1;
                }
                num5 = num11;
                if (num5 < num6)
                {
                    expressionStack_B4_0 = num6 - num5;
                }
                else
                {
                    expressionStack_B4_0 = num5 - num6;
                }
                long num12 = expressionStack_B4_0;
                num = this.GCD(num12, num1);
                if (num == 1L)
                {
                    if ((num8 & (num8 - 1)) == 0)
                    {
                        num6 = num5;
                    }
                    num8++;
                    goto Label_0049;
                }
            }
            if (num <= 1L)
            {
                num3++;
                goto Label_000D;
            }
        Label_00EF:
            if (num != -1L)
            {
                long expressionStack_FA_1 = num1;
                long expressionStack_FA_0 = num;
                expressionStack_FB_0 = expressionStack_FA_1 / expressionStack_FA_0;
                goto Label_00FB;
            }
            else
            {
                expressionStack_F6_1 = num1;
                long expressionStack_F6_0 = num;
            }
            expressionStack_FB_0 = -expressionStack_F6_1;
        Label_00FB:
            num13 = expressionStack_FB_0;
            return Math.min(num13, num);
        }

        private long GCD(long num1, long num2)
        {
            while ((num1 != 0L) && (num2 != 0L))
            {
                while (true)
                {
                    if ((num2 & 1L) != 0L)
                    {
                        break;
                    }
                    num2 = num2 >> 1;
                }
                while ((num1 & 1L) == 0L)
                {
                    num1 = num1 >> 1;
                }
                if (num1 > num2)
                {
                    num1 -= num2;
                }
                else
                {
                    num2 -= num1;
                }
            }
            return ((num2 != 0L) ? num2 : num1);
        }
    }
}

