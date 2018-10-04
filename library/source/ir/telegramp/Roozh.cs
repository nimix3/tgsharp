namespace ir.telegramp
{
    using IKVM.Attributes;
    using java.lang;
    using java.text;
    using java.util;
    using System;
    using System.Runtime.CompilerServices;

    public class Roozh : Object
    {
        private int day;
        private int gD;
        private int gM;
        private int gY;
        private int jD;
        private int jM;
        private int jY;
        private int leap;
        private int march;
        private int month;
        private int year;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 160, 0xa6, 0x76, 0x76, 0x76 })]
        public virtual string d2string(Date date)
        {
            int hour = Integer.parseInt(new SimpleDateFormat("HH").format(date));
            int minute = Integer.parseInt(new SimpleDateFormat("mm").format(date));
            int second = Integer.parseInt(new SimpleDateFormat("ss").format(date));
            return new StringBuilder().append(GetHourName(hour)).append(" ").append(GetMinuteName(minute)).append(" دقیقه و ").append(GetSecondName(second)).append(" ثانیه").toString();
        }

        public virtual int getDay() => 
            this.day;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 160, 0x9f, 0x65, 0x9f, 0x15 })]
        public static string GetHourName(int hour)
        {
            int expressionStack_25_2;
            object[] expressionStack_25_3;
            object[] expressionStack_25_4;
            string expressionStack_25_5;
            int expressionStack_2B_0;
            int expressionStack_2B_1;
            object[] expressionStack_2B_2;
            object[] expressionStack_2B_3;
            string expressionStack_2B_4;
            if (hour < 20)
            {
                return GetLessThan20(hour);
            }
            object[] objArray2 = new object[2];
            objArray2[0] = GetUpperThan20(hour / 10);
            if (10 != -1)
            {
                string expressionStack_2A_5 = "%s و %s";
                object[] expressionStack_2A_4 = objArray2;
                object[] expressionStack_2A_3 = objArray2;
                int expressionStack_2A_2 = 1;
                int expressionStack_2A_1 = hour;
                int expressionStack_2A_0 = 10;
                expressionStack_2B_4 = expressionStack_2A_5;
                expressionStack_2B_3 = expressionStack_2A_4;
                expressionStack_2B_2 = expressionStack_2A_3;
                expressionStack_2B_1 = expressionStack_2A_2;
                expressionStack_2B_0 = expressionStack_2A_1 % expressionStack_2A_0;
                goto Label_002B;
            }
            else
            {
                expressionStack_25_5 = "%s و %s";
                expressionStack_25_4 = objArray2;
                expressionStack_25_3 = objArray2;
                expressionStack_25_2 = 1;
                int expressionStack_25_1 = hour;
            }
            expressionStack_2B_4 = expressionStack_25_5;
            expressionStack_2B_3 = expressionStack_25_4;
            expressionStack_2B_2 = expressionStack_25_3;
            expressionStack_2B_1 = expressionStack_25_2;
            expressionStack_2B_0 = 0;
        Label_002B:
            expressionStack_2B_2[expressionStack_2B_1] = GetLessThan20(expressionStack_2B_0);
            return String.format(expressionStack_2B_4, expressionStack_2B_3);
        }

        private static string GetLessThan20(int num1)
        {
            switch (num1)
            {
                case 1:
                    return "یک";

                case 2:
                    return "دو";

                case 3:
                    return "سه";

                case 4:
                    return "چهار";

                case 5:
                    return "پنج";

                case 6:
                    return "شش";

                case 7:
                    return "هفت";

                case 8:
                    return "هشت";

                case 9:
                    return "نه";

                case 10:
                    return "ده";

                case 11:
                    return "یازده";

                case 12:
                    return "دوازده";

                case 13:
                    return "سیزده";

                case 14:
                    return "چهارده";

                case 15:
                    return "پانزده";

                case 0x10:
                    return "شانزده";

                case 0x11:
                    return "هفده";

                case 0x12:
                    return "هیجده";

                case 0x13:
                    return "نوزده";
            }
            return "";
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 160, 0x8d, 0x65, 0x9f, 0x15 })]
        public static string GetMinuteName(int minute)
        {
            int expressionStack_25_2;
            object[] expressionStack_25_3;
            object[] expressionStack_25_4;
            string expressionStack_25_5;
            int expressionStack_2B_0;
            int expressionStack_2B_1;
            object[] expressionStack_2B_2;
            object[] expressionStack_2B_3;
            string expressionStack_2B_4;
            if (minute < 20)
            {
                return GetLessThan20(minute);
            }
            object[] objArray2 = new object[2];
            objArray2[0] = GetUpperThan20(minute / 10);
            if (10 != -1)
            {
                string expressionStack_2A_5 = "%s و %s";
                object[] expressionStack_2A_4 = objArray2;
                object[] expressionStack_2A_3 = objArray2;
                int expressionStack_2A_2 = 1;
                int expressionStack_2A_1 = minute;
                int expressionStack_2A_0 = 10;
                expressionStack_2B_4 = expressionStack_2A_5;
                expressionStack_2B_3 = expressionStack_2A_4;
                expressionStack_2B_2 = expressionStack_2A_3;
                expressionStack_2B_1 = expressionStack_2A_2;
                expressionStack_2B_0 = expressionStack_2A_1 % expressionStack_2A_0;
                goto Label_002B;
            }
            else
            {
                expressionStack_25_5 = "%s و %s";
                expressionStack_25_4 = objArray2;
                expressionStack_25_3 = objArray2;
                expressionStack_25_2 = 1;
                int expressionStack_25_1 = minute;
            }
            expressionStack_2B_4 = expressionStack_25_5;
            expressionStack_2B_3 = expressionStack_25_4;
            expressionStack_2B_2 = expressionStack_25_3;
            expressionStack_2B_1 = expressionStack_25_2;
            expressionStack_2B_0 = 0;
        Label_002B:
            expressionStack_2B_2[expressionStack_2B_1] = GetLessThan20(expressionStack_2B_0);
            return String.format(expressionStack_2B_4, expressionStack_2B_3);
        }

        public virtual int getMonth() => 
            this.month;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 160, 0x97, 0x65, 0x9f, 0x15 })]
        public static string GetSecondName(int second)
        {
            int expressionStack_25_2;
            object[] expressionStack_25_3;
            object[] expressionStack_25_4;
            string expressionStack_25_5;
            int expressionStack_2B_0;
            int expressionStack_2B_1;
            object[] expressionStack_2B_2;
            object[] expressionStack_2B_3;
            string expressionStack_2B_4;
            if (second < 20)
            {
                return GetLessThan20(second);
            }
            object[] objArray2 = new object[2];
            objArray2[0] = GetUpperThan20(second / 10);
            if (10 != -1)
            {
                string expressionStack_2A_5 = "%s و %s";
                object[] expressionStack_2A_4 = objArray2;
                object[] expressionStack_2A_3 = objArray2;
                int expressionStack_2A_2 = 1;
                int expressionStack_2A_1 = second;
                int expressionStack_2A_0 = 10;
                expressionStack_2B_4 = expressionStack_2A_5;
                expressionStack_2B_3 = expressionStack_2A_4;
                expressionStack_2B_2 = expressionStack_2A_3;
                expressionStack_2B_1 = expressionStack_2A_2;
                expressionStack_2B_0 = expressionStack_2A_1 % expressionStack_2A_0;
                goto Label_002B;
            }
            else
            {
                expressionStack_25_5 = "%s و %s";
                expressionStack_25_4 = objArray2;
                expressionStack_25_3 = objArray2;
                expressionStack_25_2 = 1;
                int expressionStack_25_1 = second;
            }
            expressionStack_2B_4 = expressionStack_25_5;
            expressionStack_2B_3 = expressionStack_25_4;
            expressionStack_2B_2 = expressionStack_25_3;
            expressionStack_2B_1 = expressionStack_25_2;
            expressionStack_2B_0 = 0;
        Label_002B:
            expressionStack_2B_2[expressionStack_2B_1] = GetLessThan20(expressionStack_2B_0);
            return String.format(expressionStack_2B_4, expressionStack_2B_3);
        }

        private static string GetUpperThan20(int num1)
        {
            switch (num1)
            {
                case 2:
                    return "بیست";

                case 3:
                    return "سی";

                case 4:
                    return "چهل";

                case 5:
                    return "پنجاه";

                case 6:
                    return "شصت";
            }
            return "";
        }

        public virtual int getYear() => 
            this.year;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 160, 0xc4, 0x6b, 0x67, 0x6c, 0x6c, 0x6c })]
        public virtual void GregorianToPersian(int year, int month, int day)
        {
            int num = this.JG2JD(year, month, day, 0);
            this.JD2Jal(num);
            this.year = this.jY;
            this.month = this.jM;
            this.day = this.jD;
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x4d, 0x67, 0x9f, 9 })]
        private int Jal2JD(int num1, int num2, int num3)
        {
            this.JalCal(num1);
            return ((((this.JG2JD(this.gY, 3, this.march, 1) + ((num2 - 1) * 0x1f)) - ((num2 / 7) * (num2 - 7))) + num3) - 1);
        }

        [LineNumberTable(new byte[] { 
            0x5c, 0x67, 0x87, 0xbf, 160, 0x4b, 0x6d, 0x63, 0x84, 0x62, 0x6a, 0x65, 0x66, 0x68, 0x65, 0x9d,
            0x79, 0x84, 0x9f, 1, 0x8d, 0x68, 0x92, 0x9f, 4, 0x69, 0xc9, 0x7b, 0xe3, 0x27, 0xe9, 0x5b
        })]
        private void JalCal(int num1)
        {
            int expressionStack_101_2;
            int expressionStack_1BD_0;
            int expressionStack_1BD_1;
            int expressionStack_107_0;
            int expressionStack_107_1;
            int expressionStack_11B_0;
            Roozh expressionStack_17C_2;
            int expressionStack_182_0;
            Roozh expressionStack_182_1;
            Roozh expressionStack_189_2;
            int expressionStack_18F_0;
            Roozh expressionStack_18F_1;
            this.march = 0;
            this.leap = 0;
            int[] numArray = new int[] { 
                -61, 9, 0x26, 0xc7, 0x1aa, 0x2ae, 0x2f4, 0x332, 0x457, 0x49d, 0x4ba, 0x663, 0x80c, 0x831, 0x890, 0x8d6,
                0x914, 0x95a, 0x998, 0xc6a
            };
            this.gY = num1 + 0x26d;
            int num = -14;
            int num2 = numArray[0];
            int index = 1;
        Label_00D0:
            if (index > 0x13)
            {
                return;
            }
            int num4 = numArray[index];
            int num5 = num4 - num2;
            if (num1 >= num4)
            {
                int expressionStack_1B7_2;
                if (0x21 != -1)
                {
                    int expressionStack_1BC_2 = num + ((num5 / 0x21) * 8);
                    int expressionStack_1BC_1 = num5;
                    int expressionStack_1BC_0 = 0x21;
                    expressionStack_1BD_1 = expressionStack_1BC_2;
                    expressionStack_1BD_0 = expressionStack_1BC_1 % expressionStack_1BC_0;
                    goto Label_01BD;
                }
                else
                {
                    expressionStack_1B7_2 = num + ((num5 / 0x21) * 8);
                    int expressionStack_1B7_1 = num5;
                }
                expressionStack_1BD_1 = expressionStack_1B7_2;
                expressionStack_1BD_0 = 0;
                goto Label_01BD;
            }
            int num6 = num1 - num2;
            if (0x21 != -1)
            {
                int expressionStack_106_2 = num + ((num6 / 0x21) * 8);
                int expressionStack_106_1 = num6;
                int expressionStack_106_0 = 0x21;
                expressionStack_107_1 = expressionStack_106_2;
                expressionStack_107_0 = expressionStack_106_1 % expressionStack_106_0;
                goto Label_0107;
            }
            else
            {
                expressionStack_101_2 = num + ((num6 / 0x21) * 8);
                int expressionStack_101_1 = num6;
            }
            expressionStack_107_1 = expressionStack_101_2;
            expressionStack_107_0 = 0;
        Label_0107:
            num = expressionStack_107_1 + ((expressionStack_107_0 + 3) / 4);
            if (0x21 != -1)
            {
                int expressionStack_11A_1 = num5;
                int expressionStack_11A_0 = 0x21;
                expressionStack_11B_0 = expressionStack_11A_1 % expressionStack_11A_0;
                goto Label_011B;
            }
            else
            {
                int expressionStack_115_1 = num5;
            }
            expressionStack_11B_0 = 0;
        Label_011B:
            if ((expressionStack_11B_0 == 4) && ((num5 - num6) == 4))
            {
                num++;
            }
            int num7 = ((this.gY / 4) - ((((this.gY / 100) + 1) * 3) / 4)) - 150;
            this.march = (20 + num) - num7;
            if ((num5 - num6) < 6)
            {
                num6 = (num6 - num5) + (((num5 + 4) / 0x21) * 0x21);
            }
            if (0x21 != -1)
            {
                Roozh expressionStack_181_2 = this;
                int expressionStack_181_1 = num6 + 1;
                int expressionStack_181_0 = 0x21;
                expressionStack_182_1 = expressionStack_181_2;
                expressionStack_182_0 = expressionStack_181_1 % expressionStack_181_0;
                goto Label_0182;
            }
            else
            {
                expressionStack_17C_2 = this;
                int expressionStack_17C_1 = num6 + 1;
            }
            expressionStack_182_1 = expressionStack_17C_2;
            expressionStack_182_0 = 0;
        Label_0182:
            if (4 != -1)
            {
                Roozh expressionStack_18E_2 = expressionStack_182_1;
                int expressionStack_18E_1 = expressionStack_182_0 - 1;
                int expressionStack_18E_0 = 4;
                expressionStack_18F_1 = expressionStack_18E_2;
                expressionStack_18F_0 = expressionStack_18E_1 % expressionStack_18E_0;
                goto Label_018F;
            }
            else
            {
                expressionStack_189_2 = expressionStack_182_1;
                int expressionStack_189_1 = expressionStack_182_0 - 1;
            }
            expressionStack_18F_1 = expressionStack_189_2;
            expressionStack_18F_0 = 0;
        Label_018F:
            expressionStack_18F_1.leap = expressionStack_18F_0;
            if (this.leap == -1)
            {
                this.leap = 4;
            }
            return;
        Label_01BD:
            num = expressionStack_1BD_1 + (expressionStack_1BD_0 / 4);
            num2 = num4;
            index++;
            goto Label_00D0;
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 
            0x27, 0x88, 0x72, 140, 0x75, 100, 100, 0x68, 0x6c, 0x75, 0x81, 170, 110, 0x68, 0x69, 0xa4,
            0x6c, 0x75
        })]
        private void JD2Jal(int num1)
        {
            Roozh expressionStack_AE_2;
            Roozh expressionStack_5F_2;
            int expressionStack_B4_0;
            Roozh expressionStack_B4_1;
            int expressionStack_65_0;
            Roozh expressionStack_65_1;
            this.JD2JG(num1, 0);
            this.jY = this.gY - 0x26d;
            this.JalCal(this.jY);
            int num = this.JG2JD(this.gY, 3, this.march, 0);
            int num2 = num1 - num;
            if (num2 < 0)
            {
                this.jY--;
                num2 += 0xb3;
                if (this.leap == 1)
                {
                    num2++;
                }
                goto Label_009A;
            }
            if (num2 > 0xb9)
            {
                num2 -= 0xba;
                goto Label_009A;
            }
            this.jM = 1 + (num2 / 0x1f);
            if (0x1f != -1)
            {
                Roozh expressionStack_64_2 = this;
                int expressionStack_64_1 = num2;
                int expressionStack_64_0 = 0x1f;
                expressionStack_65_1 = expressionStack_64_2;
                expressionStack_65_0 = expressionStack_64_1 % expressionStack_64_0;
                goto Label_0065;
            }
            else
            {
                expressionStack_5F_2 = this;
                int expressionStack_5F_1 = num2;
            }
            expressionStack_65_1 = expressionStack_5F_2;
            expressionStack_65_0 = 0;
        Label_0065:
            expressionStack_65_1.jD = expressionStack_65_0 + 1;
            return;
        Label_009A:
            this.jM = 7 + (num2 / 30);
            if (30 != -1)
            {
                Roozh expressionStack_B3_2 = this;
                int expressionStack_B3_1 = num2;
                int expressionStack_B3_0 = 30;
                expressionStack_B4_1 = expressionStack_B3_2;
                expressionStack_B4_0 = expressionStack_B3_1 % expressionStack_B3_0;
                goto Label_00B4;
            }
            else
            {
                expressionStack_AE_2 = this;
                int expressionStack_AE_1 = num2;
            }
            expressionStack_B4_1 = expressionStack_AE_2;
            expressionStack_B4_0 = 0;
        Label_00B4:
            expressionStack_B4_1.jD = expressionStack_B4_0 + 1;
        }

        [LineNumberTable(new byte[] { 20, 0x8a, 0x63, 190, 0x7b, 0x7a, 0x7b, 0x7e })]
        private void JD2JG(int num1, int num3)
        {
            int num2;
            int expressionStack_3B_0;
            Roozh expressionStack_51_2;
            int expressionStack_57_0;
            Roozh expressionStack_57_1;
            Roozh expressionStack_6E_2;
            int expressionStack_74_0;
            Roozh expressionStack_74_1;
            int num = (4 * num1) + 0x84e7d5f;
            if (num3 == 0)
            {
                num = (num + ((((((4 * num1) + 0xaeb3908) / 0x23ab1) * 3) / 4) * 4)) - 0xf44;
            }
            if (0x5b5 != -1)
            {
                int expressionStack_3A_1 = num;
                int expressionStack_3A_0 = 0x5b5;
                expressionStack_3B_0 = expressionStack_3A_1 % expressionStack_3A_0;
                goto Label_003B;
            }
            else
            {
                int expressionStack_35_1 = num;
            }
            expressionStack_3B_0 = 0;
        Label_003B:
            num2 = ((expressionStack_3B_0 / 4) * 5) + 0x134;
            if (0x99 != -1)
            {
                Roozh expressionStack_56_2 = this;
                int expressionStack_56_1 = num2;
                int expressionStack_56_0 = 0x99;
                expressionStack_57_1 = expressionStack_56_2;
                expressionStack_57_0 = expressionStack_56_1 % expressionStack_56_0;
                goto Label_0057;
            }
            else
            {
                expressionStack_51_2 = this;
                int expressionStack_51_1 = num2;
            }
            expressionStack_57_1 = expressionStack_51_2;
            expressionStack_57_0 = 0;
        Label_0057:
            expressionStack_57_1.gD = (expressionStack_57_0 / 5) + 1;
            if (12 != -1)
            {
                Roozh expressionStack_73_2 = this;
                int expressionStack_73_1 = num2 / 0x99;
                int expressionStack_73_0 = 12;
                expressionStack_74_1 = expressionStack_73_2;
                expressionStack_74_0 = expressionStack_73_1 % expressionStack_73_0;
                goto Label_0074;
            }
            else
            {
                expressionStack_6E_2 = this;
                int expressionStack_6E_1 = num2 / 0x99;
            }
            expressionStack_74_1 = expressionStack_6E_2;
            expressionStack_74_0 = 0;
        Label_0074:
            expressionStack_74_1.gM = expressionStack_74_0 + 1;
            this.gY = ((num / 0x5b5) - 0x18704) + ((8 - this.gM) / 6);
        }

        [LineNumberTable(new byte[] { 0x9f, 0xba, 0xff, 0x30, 0x45, 100, 0x9d })]
        private int JG2JD(int num1, int num2, int num3, int num4)
        {
            int num = (((((0x5b5 * ((num1 + 0x12c0) + ((num2 - 14) / 12))) / 4) + ((0x16f * ((num2 - 2) - (12 * ((num2 - 14) / 12)))) / 12)) - ((3 * (((num1 + 0x1324) + ((num2 - 14) / 12)) / 100)) / 4)) + num3) - 0x7d4b;
            if (num4 == 0)
            {
                num = (num - (((((num1 + 0x18704) + ((num2 - 8) / 6)) / 100) * 3) / 4)) + 0x2f0;
            }
            return num;
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 160, 0xd6, 0x6a, 0x68, 0x6c, 0x6c, 0x6c })]
        public virtual void PersianToGregorian(int year, int month, int day)
        {
            int num = this.Jal2JD(year, month, day);
            this.JD2JG(num, 0);
            this.year = this.gY;
            this.month = this.gM;
            this.day = this.gD;
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x128)]
        public override string toString()
        {
            object[] objArray1 = new object[] { Integer.valueOf(this.getYear()), Integer.valueOf(this.getMonth()), Integer.valueOf(this.getDay()) };
            return String.format("%04d-%02d-%02d", objArray1);
        }
    }
}

