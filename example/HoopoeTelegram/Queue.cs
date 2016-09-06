namespace HoopoeTelegram
{
    using ir.telegramp;
    using System;
    using System.IO;
    using System.Linq;
    using System.Threading;

    internal class Queue
    {
        private static ReaderWriterLockSlim lock_ = new ReaderWriterLockSlim();
        private static readonly object LockObject_Queue = new object();
        public static string[] numbers;
        public static string path = "";

        public static int count()
        {
            try
            {
                return int.Parse(getQueueCount()[0]);
            }
            catch (Exception exception)
            {
                MyLogger.log("Count queue error! " + exception.Message,"");
                return 0;
            }
        }

        private static string[] getQueueCount()
        {
            return workOnQueue("count");
        }

        public static string[] read(int lines)
        {
            try
            {
                return workOnQueue("read", lines);
            }
            catch (Exception exception)
            {
                MyLogger.log("Read queue error! " + exception.Message, "");
                return null;
            }
        }

        private static string[] workOnQueue(string action)
        {
            return workOnQueue(action, null, 0);
        }

        private static string[] workOnQueue(string action, int lines)
        {
            return workOnQueue(action, null, lines);
        }

        private static string[] workOnQueue(string action, string[] lines)
        {
            return workOnQueue(action, lines, 0);
        }

        private static string[] workOnQueue(string action, string[] lines, int lines_count)
        {
            object obj2 = LockObject_Queue;
            lock (obj2)
            {
                if (action == "read")
                {
                    string[] strArray = numbers.Take<string>(lines_count).ToArray<string>();
                    numbers = numbers.Skip<string>(lines_count).ToArray<string>();
                    File.WriteAllLines(path, numbers);
                    return strArray;
                }
                if (action == "write")
                {
                    numbers = numbers.Union<string>(lines).ToArray<string>();
                    File.WriteAllLines(path, numbers);
                }
                else if (action == "count")
                {
                    string[] strArray2 = new string[1];
                    int index = 0;
                    strArray2[index] = numbers.Count<string>().ToString();
                    return strArray2;
                }
                return null;
            }
        }

        public static void write(string[] lines)
        {
            try
            {
                workOnQueue("write", lines);
            }
            catch (Exception exception)
            {
                MyLogger.log("Write queue error! " + exception.Message, "");
            }
        }

        public static void writeText(string lines)
        {
            try
            {
                string str = lines.Trim(new char[] { '\r', '\n', ' ' });
                string[] separator = new string[2];
                int index = 0;
                separator[index] = "\r\n";
                int num2 = 1;
                separator[num2] = "\n";
                int num3 = 0;
                write(str.Split(separator, (StringSplitOptions) num3));
            }
            catch (Exception exception)
            {
                MyLogger.log("Write queue error! " + exception.Message, "");
            }
        }
    }
}

