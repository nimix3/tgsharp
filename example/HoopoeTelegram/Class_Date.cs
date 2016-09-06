namespace HoopoeTelegram
{
    using System;
    using System.Globalization;

    internal class Class_Date
    {
        public static string[] days;
        private static HijriCalendar hijri = new HijriCalendar();
        public static string[] Hijri_month_Arabic;
        public static string[] Hijri_month_TarjomeFarsi;
        public static string[] Hijri_WeekDay_Arabic;
        public static string[] Miladi_month_English;
        public static string[] Miladi_month_TarjomeFarsi;
        public static string[] Miladi_WeekDay_English;
        public static string[] persian_month;
        private static PersianCalendar shamsi = new PersianCalendar();

        static Class_Date()
        {
            string[] strArray = new string[7];
            int index = 0;
            strArray[index] = "يك شنبه";
            int num2 = 1;
            strArray[num2] = "دو شنبه";
            int num3 = 2;
            strArray[num3] = "سه شنبه";
            int num4 = 3;
            strArray[num4] = "چهار شنبه";
            int num5 = 4;
            strArray[num5] = "پنج شنبه";
            int num6 = 5;
            strArray[num6] = "جمعه";
            int num7 = 6;
            strArray[num7] = "شنبه";
            days = strArray;
            string[] strArray2 = new string[12];
            int num8 = 0;
            strArray2[num8] = "فروردين";
            int num9 = 1;
            strArray2[num9] = "ارديبهشت";
            int num10 = 2;
            strArray2[num10] = "خرداد";
            int num11 = 3;
            strArray2[num11] = "تير";
            int num12 = 4;
            strArray2[num12] = "مرداد";
            int num13 = 5;
            strArray2[num13] = "شهريور";
            int num14 = 6;
            strArray2[num14] = "مهر";
            int num15 = 7;
            strArray2[num15] = "آبان";
            int num16 = 8;
            strArray2[num16] = "آذر";
            int num17 = 9;
            strArray2[num17] = "دي";
            int num18 = 10;
            strArray2[num18] = "بهمن";
            int num19 = 11;
            strArray2[num19] = "اسفند";
            persian_month = strArray2;
            string[] strArray3 = new string[12];
            int num20 = 0;
            strArray3[num20] = "محرم";
            int num21 = 1;
            strArray3[num21] = "صفر";
            int num22 = 2;
            strArray3[num22] = "ربيع الاول";
            int num23 = 3;
            strArray3[num23] = "ربيع الثاني";
            int num24 = 4;
            strArray3[num24] = "جمادي الاول";
            int num25 = 5;
            strArray3[num25] = "جمادي الثاني";
            int num26 = 6;
            strArray3[num26] = "رجب";
            int num27 = 7;
            strArray3[num27] = "شعبان";
            int num28 = 8;
            strArray3[num28] = "رمضان";
            int num29 = 9;
            strArray3[num29] = "شوال";
            int num30 = 10;
            strArray3[num30] = "ذيقعده";
            int num31 = 11;
            strArray3[num31] = "ذيحجه";
            Hijri_month_TarjomeFarsi = strArray3;
            string[] strArray4 = new string[12];
            int num32 = 0;
            strArray4[num32] = "محرم";
            int num33 = 1;
            strArray4[num33] = "صفر";
            int num34 = 2;
            strArray4[num34] = "ربيع الأول";
            int num35 = 3;
            strArray4[num35] = "ربيع الآخر";
            int num36 = 4;
            strArray4[num36] = "جمادي الأولي";
            int num37 = 5;
            strArray4[num37] = "جمادي الآخرة";
            int num38 = 6;
            strArray4[num38] = "رجب";
            int num39 = 7;
            strArray4[num39] = "شعبان";
            int num40 = 8;
            strArray4[num40] = "رمضان";
            int num41 = 9;
            strArray4[num41] = "شوال";
            int num42 = 10;
            strArray4[num42] = "ذوالقعدة";
            int num43 = 11;
            strArray4[num43] = "ذوالحجة";
            Hijri_month_Arabic = strArray4;
            string[] strArray5 = new string[7];
            int num44 = 0;
            strArray5[num44] = "الأحد";
            int num45 = 1;
            strArray5[num45] = "الاثنين";
            int num46 = 2;
            strArray5[num46] = "الثلاثاء";
            int num47 = 3;
            strArray5[num47] = "الأربعاء";
            int num48 = 4;
            strArray5[num48] = "الخميس";
            int num49 = 5;
            strArray5[num49] = "الجمعة";
            int num50 = 6;
            strArray5[num50] = "السبت";
            Hijri_WeekDay_Arabic = strArray5;
            string[] strArray6 = new string[12];
            int num51 = 0;
            strArray6[num51] = "ژانويه";
            int num52 = 1;
            strArray6[num52] = "فوريه";
            int num53 = 2;
            strArray6[num53] = "مارس";
            int num54 = 3;
            strArray6[num54] = "آوريل";
            int num55 = 4;
            strArray6[num55] = "مه";
            int num56 = 5;
            strArray6[num56] = "ژوئن";
            int num57 = 6;
            strArray6[num57] = "ژوئيه";
            int num58 = 7;
            strArray6[num58] = "اوت";
            int num59 = 8;
            strArray6[num59] = "سپتامبر";
            int num60 = 9;
            strArray6[num60] = "اكتبر";
            int num61 = 10;
            strArray6[num61] = "نوامبر";
            int num62 = 11;
            strArray6[num62] = "دسامبر";
            Miladi_month_TarjomeFarsi = strArray6;
            string[] strArray7 = new string[12];
            int num63 = 0;
            strArray7[num63] = "January";
            int num64 = 1;
            strArray7[num64] = "February";
            int num65 = 2;
            strArray7[num65] = "March";
            int num66 = 3;
            strArray7[num66] = "April";
            int num67 = 4;
            strArray7[num67] = "May";
            int num68 = 5;
            strArray7[num68] = "June";
            int num69 = 6;
            strArray7[num69] = "July";
            int num70 = 7;
            strArray7[num70] = "August";
            int num71 = 8;
            strArray7[num71] = "September";
            int num72 = 9;
            strArray7[num72] = "October";
            int num73 = 10;
            strArray7[num73] = "November";
            int num74 = 11;
            strArray7[num74] = "December";
            Miladi_month_English = strArray7;
            string[] strArray8 = new string[7];
            int num75 = 0;
            strArray8[num75] = "Sunday";
            int num76 = 1;
            strArray8[num76] = "Monday";
            int num77 = 2;
            strArray8[num77] = "Tuesday";
            int num78 = 3;
            strArray8[num78] = "Wednesday";
            int num79 = 4;
            strArray8[num79] = "Thursday";
            int num80 = 5;
            strArray8[num80] = "Friday";
            int num81 = 6;
            strArray8[num81] = "Saturday";
            Miladi_WeekDay_English = strArray8;
        }

        public static string calc_Last_Date_of_Month_Persian(string date)
        {
            try
            {
                string str = return_Year(date).ToString();
                string str2 = "/";
                int num = return_Month(date) + 1;
                string str3 = num.ToString().PadLeft(2, '0');
                string str4 = "/01";
                return PersianDate_AddDays(str + str2 + str3 + str4, -1);
            }
            catch
            {
            }
            return "";
        }

        public static string Convert_Hijry_To_Milady(string date)
        {
            int year = -1;
            int month = -1;
            int day = -1;
            try
            {
                try
                {
                    string str = date;
                    char[] separator = new char[1];
                    int index = 0;
                    int num5 = 0x2f;
                    separator[index] = (char) num5;
                    year = int.Parse(str.Split(separator)[0]);
                }
                catch
                {
                }
                try
                {
                    string str2 = date;
                    char[] chArray2 = new char[1];
                    int num6 = 0;
                    int num7 = 0x2f;
                    chArray2[num6] = (char) num7;
                    month = int.Parse(str2.Split(chArray2)[1]);
                }
                catch
                {
                }
                try
                {
                    string str3 = date;
                    char[] chArray3 = new char[1];
                    int num8 = 0;
                    int num9 = 0x2f;
                    chArray3[num8] = (char) num9;
                    day = int.Parse(str3.Split(chArray3)[2]);
                }
                catch
                {
                }
            }
            catch
            {
            }
            hijri.HijriAdjustment = -1;
            try
            {
                DateTime time = hijri.ToDateTime(year, month, day, 0, 0, 0, 0);
                string[] strArray = new string[5];
                int num10 = 0;
                strArray[num10] = time.Year.ToString().PadLeft(4, '0');
                int num11 = 1;
                strArray[num11] = "/";
                int num12 = 2;
                strArray[num12] = time.Month.ToString().PadLeft(2, '0');
                int num13 = 3;
                strArray[num13] = "/";
                int num14 = 4;
                strArray[num14] = time.Day.ToString().PadLeft(2, '0');
                return string.Concat(strArray);
            }
            catch
            {
            }
            return "";
        }

        public static string Convert_Hijry_To_Shamsi(string date)
        {
            int year = -1;
            int month = -1;
            int day = -1;
            try
            {
                try
                {
                    string str = date;
                    char[] separator = new char[1];
                    int index = 0;
                    int num5 = 0x2f;
                    separator[index] = (char) num5;
                    year = int.Parse(str.Split(separator)[0]);
                }
                catch
                {
                }
                try
                {
                    string str2 = date;
                    char[] chArray2 = new char[1];
                    int num6 = 0;
                    int num7 = 0x2f;
                    chArray2[num6] = (char) num7;
                    month = int.Parse(str2.Split(chArray2)[1]);
                }
                catch
                {
                }
                try
                {
                    string str3 = date;
                    char[] chArray3 = new char[1];
                    int num8 = 0;
                    int num9 = 0x2f;
                    chArray3[num8] = (char) num9;
                    day = int.Parse(str3.Split(chArray3)[2]);
                }
                catch
                {
                }
            }
            catch
            {
            }
            hijri.HijriAdjustment = -1;
            try
            {
                DateTime time = hijri.ToDateTime(year, month, day, 0, 0, 0, 0);
                string[] strArray = new string[5];
                int num10 = 0;
                strArray[num10] = shamsi.GetYear(time).ToString().PadLeft(4, '0');
                int num11 = 1;
                strArray[num11] = "/";
                int num12 = 2;
                strArray[num12] = shamsi.GetMonth(time).ToString().PadLeft(2, '0');
                int num13 = 3;
                strArray[num13] = "/";
                int num14 = 4;
                strArray[num14] = shamsi.GetDayOfMonth(time).ToString().PadLeft(2, '0');
                return string.Concat(strArray);
            }
            catch
            {
            }
            return "";
        }

        public static string Convert_Milady_To_Hijry(string date)
        {
            try
            {
                DateTime time = DateTime.Parse(date);
                hijri.HijriAdjustment = -1;
                string[] strArray = new string[5];
                int index = 0;
                strArray[index] = hijri.GetYear(time).ToString().PadLeft(4, '0');
                int num2 = 1;
                strArray[num2] = "/";
                int num3 = 2;
                strArray[num3] = hijri.GetMonth(time).ToString().PadLeft(2, '0');
                int num4 = 3;
                strArray[num4] = "/";
                int num5 = 4;
                strArray[num5] = hijri.GetDayOfMonth(time).ToString().PadLeft(2, '0');
                return string.Concat(strArray);
            }
            catch
            {
            }
            return "";
        }

        public static string Convert_Milady_To_Shamsi(string date)
        {
            try
            {
                DateTime time = DateTime.Parse(date);
                string[] strArray = new string[5];
                int index = 0;
                strArray[index] = shamsi.GetYear(time).ToString().PadLeft(4, '0');
                int num2 = 1;
                strArray[num2] = "/";
                int num3 = 2;
                strArray[num3] = shamsi.GetMonth(time).ToString().PadLeft(2, '0');
                int num4 = 3;
                strArray[num4] = "/";
                int num5 = 4;
                strArray[num5] = shamsi.GetDayOfMonth(time).ToString().PadLeft(2, '0');
                return string.Concat(strArray);
            }
            catch
            {
            }
            return "";
        }

        public static string Convert_Shamsi_To_Hijry(string date)
        {
            int year = -1;
            int month = -1;
            int day = -1;
            try
            {
                try
                {
                    string str = date;
                    char[] separator = new char[1];
                    int index = 0;
                    int num5 = 0x2f;
                    separator[index] = (char) num5;
                    year = int.Parse(str.Split(separator)[0]);
                }
                catch
                {
                }
                try
                {
                    string str2 = date;
                    char[] chArray2 = new char[1];
                    int num6 = 0;
                    int num7 = 0x2f;
                    chArray2[num6] = (char) num7;
                    month = int.Parse(str2.Split(chArray2)[1]);
                }
                catch
                {
                }
                try
                {
                    string str3 = date;
                    char[] chArray3 = new char[1];
                    int num8 = 0;
                    int num9 = 0x2f;
                    chArray3[num8] = (char) num9;
                    day = int.Parse(str3.Split(chArray3)[2]);
                }
                catch
                {
                }
            }
            catch
            {
            }
            hijri.HijriAdjustment = -1;
            try
            {
                DateTime time = shamsi.ToDateTime(year, month, day, 0, 0, 0, 0);
                string[] strArray = new string[5];
                int num10 = 0;
                strArray[num10] = hijri.GetYear(time).ToString().PadLeft(4, '0');
                int num11 = 1;
                strArray[num11] = "/";
                int num12 = 2;
                strArray[num12] = hijri.GetMonth(time).ToString().PadLeft(2, '0');
                int num13 = 3;
                strArray[num13] = "/";
                int num14 = 4;
                strArray[num14] = hijri.GetDayOfMonth(time).ToString().PadLeft(2, '0');
                return string.Concat(strArray);
            }
            catch
            {
            }
            return "";
        }

        public static string Convert_Shamsi_To_Milady(string date)
        {
            int year = -1;
            int month = -1;
            int day = -1;
            try
            {
                try
                {
                    string str = date;
                    char[] separator = new char[1];
                    int index = 0;
                    int num5 = 0x2f;
                    separator[index] = (char) num5;
                    year = int.Parse(str.Split(separator)[0]);
                }
                catch
                {
                }
                try
                {
                    string str2 = date;
                    char[] chArray2 = new char[1];
                    int num6 = 0;
                    int num7 = 0x2f;
                    chArray2[num6] = (char) num7;
                    month = int.Parse(str2.Split(chArray2)[1]);
                }
                catch
                {
                }
                try
                {
                    string str3 = date;
                    char[] chArray3 = new char[1];
                    int num8 = 0;
                    int num9 = 0x2f;
                    chArray3[num8] = (char) num9;
                    day = int.Parse(str3.Split(chArray3)[2]);
                }
                catch
                {
                }
            }
            catch
            {
            }
            hijri.HijriAdjustment = -1;
            try
            {
                DateTime time = shamsi.ToDateTime(year, month, day, 0, 0, 0, 0);
                string[] strArray = new string[5];
                int num10 = 0;
                strArray[num10] = time.Year.ToString().PadLeft(4, '0');
                int num11 = 1;
                strArray[num11] = "/";
                int num12 = 2;
                strArray[num12] = time.Month.ToString().PadLeft(2, '0');
                int num13 = 3;
                strArray[num13] = "/";
                int num14 = 4;
                strArray[num14] = time.Day.ToString().PadLeft(2, '0');
                return string.Concat(strArray);
            }
            catch
            {
            }
            return "";
        }

        public static string correct_Date(string date)
        {
            try
            {
                new PersianCalendar();
                string str = date;
                char[] separator = new char[1];
                int index = 0;
                int num2 = 0x2f;
                separator[index] = (char) num2;
                string[] strArray = str.Split(separator);
                int num3 = int.Parse(strArray[0]);
                int num4 = int.Parse(strArray[1]);
                int num5 = int.Parse(strArray[2]);
                object[] objArray = new object[5];
                int num6 = 0;
                objArray[num6] = num3;
                int num7 = 1;
                objArray[num7] = "/";
                int num8 = 2;
                objArray[num8] = num4.ToString().PadLeft(2, '0');
                int num9 = 3;
                objArray[num9] = "/";
                int num10 = 4;
                objArray[num10] = num5.ToString().PadLeft(2, '0');
                return string.Concat(objArray);
            }
            catch
            {
                return "";
            }
        }

        public static int Days_Between_Years(string from_date, string to_date)
        {
            new PersianCalendar();
            DateTime time = PersianToDateTime(from_date);
            TimeSpan span = (TimeSpan) (PersianToDateTime(to_date) - time);
            return span.Days;
        }

        public static string end_Week_Date(string date, int number_Week)
        {
            try
            {
                for (int i = 0; i <= 7; i++)
                {
                    string str = PersianDate_AddDays(date, i);
                    if (get_Week_String_From_PersianDate(str) == "جمعه")
                    {
                        return PersianDate_AddDays(str, number_Week * 7);
                    }
                }
            }
            catch
            {
            }
            return "";
        }

        public static int get_Week_Number_From_PersianDate(string date)
        {
            try
            {
                PersianCalendar calendar = new PersianCalendar();
                string str = date;
                char[] separator = new char[1];
                int index = 0;
                int num2 = 0x2f;
                separator[index] = (char) num2;
                string[] strArray = str.Split(separator);
                int year = int.Parse(strArray[0]);
                int month = int.Parse(strArray[1]);
                int day = int.Parse(strArray[2]);
                int hour = DateTime.Now.Hour;
                int minute = DateTime.Now.Minute;
                int second = DateTime.Now.Second;
                int millisecond = DateTime.Now.Millisecond;
                int dayOfWeek = (int) calendar.ToDateTime(year, month, day, hour, minute, second, millisecond).DayOfWeek;
                return ((dayOfWeek != 6) ? (dayOfWeek + 1) : 0);
            }
            catch
            {
                return -1;
            }
        }

        public static string get_Week_String_From_PersianDate(string date)
        {
            try
            {
                PersianCalendar calendar = new PersianCalendar();
                string str = date;
                char[] separator = new char[1];
                int index = 0;
                int num2 = 0x2f;
                separator[index] = (char) num2;
                string[] strArray = str.Split(separator);
                int year = int.Parse(strArray[0]);
                int month = int.Parse(strArray[1]);
                int day = int.Parse(strArray[2]);
                int hour = DateTime.Now.Hour;
                int minute = DateTime.Now.Minute;
                int second = DateTime.Now.Second;
                int millisecond = DateTime.Now.Millisecond;
                int dayOfWeek = (int) calendar.ToDateTime(year, month, day, hour, minute, second, millisecond).DayOfWeek;
                return days[dayOfWeek];
            }
            catch
            {
                return "";
            }
        }

        public static string Name_of_Month_Persian_Date(string date)
        {
            try
            {
                string str = date;
                char[] separator = new char[1];
                int index = 0;
                int num2 = 0x2f;
                separator[index] = (char) num2;
                int num3 = int.Parse(str.Split(separator)[1]);
                return persian_month[num3 - 1];
            }
            catch
            {
            }
            return "";
        }

        public static string PersianDate(DateTime date)
        {
            PersianCalendar calendar = new PersianCalendar();
            int year = calendar.GetYear(date);
            int month = calendar.GetMonth(date);
            int dayOfMonth = calendar.GetDayOfMonth(date);
            object[] objArray = new object[5];
            int index = 0;
            objArray[index] = year;
            int num5 = 1;
            objArray[num5] = "/";
            int num6 = 2;
            objArray[num6] = month.ToString().PadLeft(2, '0');
            int num7 = 3;
            objArray[num7] = "/";
            int num8 = 4;
            objArray[num8] = dayOfMonth.ToString().PadLeft(2, '0');
            return string.Concat(objArray);
        }

        public static string PersianDate_AddDays(string date, int d)
        {
            new PersianCalendar();
            return PersianDate(PersianToDateTime(date).AddDays((double) d));
        }

        public static DateTime PersianToDateTime(string date)
        {
            PersianCalendar calendar = new PersianCalendar();
            try
            {
                string str = date;
                char[] separator = new char[1];
                int index = 0;
                int num2 = 0x2f;
                separator[index] = (char) num2;
                string[] strArray = str.Split(separator);
                int year = int.Parse(strArray[0]);
                int month = int.Parse(strArray[1]);
                int day = int.Parse(strArray[2]);
                int hour = DateTime.Now.Hour;
                int minute = DateTime.Now.Minute;
                int second = DateTime.Now.Second;
                int millisecond = DateTime.Now.Millisecond;
                return calendar.ToDateTime(year, month, day, hour, minute, second, millisecond);
            }
            catch
            {
                return calendar.ToDateTime(1, 1, 1, 0, 0, 0, 0);
            }
        }

        public static string Return_DateEnglish_From_TimeStamp(double timestamp)
        {
            string str = "";
            if (timestamp != 0.0)
            {
                try
                {
                    DateTime time = new DateTime(0x7b2, 1, 1, 0, 0, 0, 0);
                    time = time.AddSeconds(timestamp);
                    string[] strArray = new string[5];
                    int index = 0;
                    strArray[index] = time.Year.ToString();
                    int num2 = 1;
                    strArray[num2] = "/";
                    int num3 = 2;
                    strArray[num3] = time.Month.ToString().PadLeft(2, '0');
                    int num4 = 3;
                    strArray[num4] = "/";
                    int num5 = 4;
                    strArray[num5] = time.Day.ToString().PadLeft(2, '0');
                    str = string.Concat(strArray);
                }
                catch
                {
                }
            }
            return str;
        }

        public static string Return_DateEnglish_From_TimeStamp(string timestamp)
        {
            return Return_DateEnglish_From_TimeStamp(double.Parse(timestamp));
        }

        public static string Return_DateFarsi_From_TimeStamp(double timestamp)
        {
            string str = "";
            if (timestamp != 0.0)
            {
                try
                {
                    DateTime time = new DateTime(0x7b2, 1, 1, 0, 0, 0, 0);
                    str = PersianDate(time.AddSeconds(timestamp));
                }
                catch
                {
                }
            }
            return str;
        }

        public static string Return_DateFarsi_From_TimeStamp(string timestamp)
        {
            return Return_DateFarsi_From_TimeStamp(double.Parse(timestamp));
        }

        public static int return_Day(string date)
        {
            int num = -1;
            try
            {
                string str = date;
                char[] separator = new char[1];
                int index = 0;
                int num3 = 0x2f;
                separator[index] = (char) num3;
                num = int.Parse(str.Split(separator)[2]);
            }
            catch
            {
            }
            return num;
        }

        public static string return_Hijri_Month_Name_Persian(string date)
        {
            return Hijri_month_TarjomeFarsi[return_Month(date) - 1];
        }

        public static string return_Milay_Month_Name_English(string date)
        {
            return Miladi_month_English[return_Month(date) - 1];
        }

        public static int return_Month(string date)
        {
            int num = -1;
            try
            {
                string str = date;
                char[] separator = new char[1];
                int index = 0;
                int num3 = 0x2f;
                separator[index] = (char) num3;
                num = int.Parse(str.Split(separator)[1]);
            }
            catch
            {
            }
            return num;
        }

        public static int return_Year(string date)
        {
            int num = -1;
            try
            {
                string str = date;
                char[] separator = new char[1];
                int index = 0;
                int num3 = 0x2f;
                separator[index] = (char) num3;
                num = int.Parse(str.Split(separator)[0]);
            }
            catch
            {
            }
            return num;
        }

        public static string start_Week_Date(string date, int number_Week)
        {
            try
            {
                for (int i = 0; i <= 7; i++)
                {
                    string str = PersianDate_AddDays(date, -1 * i);
                    if (get_Week_String_From_PersianDate(str) == "شنبه")
                    {
                        return PersianDate_AddDays(str, number_Week * 7);
                    }
                }
            }
            catch
            {
            }
            return "";
        }

        public static string Today_Day_of_Month()
        {
            return new PersianCalendar().GetDayOfMonth(DateTime.Now).ToString();
        }

        public static string Today_Name_of_Month()
        {
            int month = new PersianCalendar().GetMonth(DateTime.Now);
            return persian_month[month - 1];
        }

        public static int Today_Persian_Month()
        {
            try
            {
                return new PersianCalendar().GetMonth(DateTime.Now);
            }
            catch
            {
                return 12;
            }
        }

        public static int Today_Persian_Year()
        {
            try
            {
                return new PersianCalendar().GetYear(DateTime.Now);
            }
            catch
            {
                return 0x572;
            }
        }

        public static string Today_PersianDate()
        {
            DateTime now = DateTime.Now;
            PersianCalendar calendar = new PersianCalendar();
            int year = calendar.GetYear(now);
            int month = calendar.GetMonth(now);
            int dayOfMonth = calendar.GetDayOfMonth(now);
            object[] objArray = new object[5];
            int index = 0;
            objArray[index] = year;
            int num5 = 1;
            objArray[num5] = "/";
            int num6 = 2;
            objArray[num6] = month.ToString().PadLeft(2, '0');
            int num7 = 3;
            objArray[num7] = "/";
            int num8 = 4;
            objArray[num8] = dayOfMonth.ToString().PadLeft(2, '0');
            return string.Concat(objArray);
        }

        public static string TodayFarsiWeek()
        {
            return days[(int) DateTime.Now.DayOfWeek];
        }

        public static int TodayFarsiWeek_number()
        {
            int dayOfWeek = (int) DateTime.Now.DayOfWeek;
            if (dayOfWeek == 6)
            {
                return 0;
            }
            return (dayOfWeek + 1);
        }
    }
}

