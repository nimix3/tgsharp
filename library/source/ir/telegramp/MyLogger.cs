namespace ir.telegramp
{
    using IKVM.Attributes;
    using IKVM.Runtime;
    using java.io;
    using java.lang;
    using java.nio.file;
    using java.text;
    using java.util;
    using System;
    using System.Runtime.CompilerServices;

    public class MyLogger : Object
    {
        public static BufferedWriter bufferWritter = null;
        public static bool file_logging = true;
        private static string file_name = "debug";
        public static string log_path = new StringBuilder().append(JarPath.GetPath()).append("//").toString();

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void __<clinit>()
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x24, 0x7f, 10 })]
        public static void log(int message)
        {
            log(new StringBuilder().append(message).append("").toString(), "", true, 0, true);
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x29, 0x7f, 6 })]
        public static void log(int message, string extra)
        {
            log(new StringBuilder().append(message).append("").toString(), extra, true, 0, true);
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xab, 0x70 })]
        public static void log(string message, int index)
        {
            log(message, "", true, index, true);
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x38, 0x6c })]
        public static void log(string message, string extra)
        {
            log(message, extra, true, 0, true);
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x76, 0x42, 0x70 })]
        public static void log(string message, int index, bool newLine)
        {
            int num = (int) newLine;
            log(message, "", (bool) num, index, true);
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x3e, 0x6c })]
        public static void log(string message, string extra, int index)
        {
            log(message, extra, true, index, true);
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x75, 100, 0x70 })]
        public static void log(string message, int index, bool newLine, bool time)
        {
            int num = (int) time;
            int num2 = (int) newLine;
            log(message, "", (bool) num, index, (bool) num2);
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 
            0x9f, 0x85, 0xa2, 0x7f, 0x2f, 0x7f, 1, 0x67, 0x65, 0x7f, 0x20, 0x67, 0x68, 0x75, 0x87, 0xff,
            0x45, 0x5d, 0xe2, 0x3d, 0xe1, 0x47
        })]
        public static void log(string message, string extra, bool newLine, int index, bool time)
        {
            int num = (int) newLine;
            try
            {
                extra = new StringBuilder().append("{").append(new SimpleDateFormat("MM/dd|HH:mm:ss").format(Calendar.getInstance().getTime())).append("}=> ").append(extra).append(": ").toString();
                System.get_out().println(new StringBuilder().append(extra).append(message).toString());
                if (file_logging)
                {
                    File file = new File(new StringBuilder().append(log_path).append(file_name).append((index > 0) ? Integer.valueOf(index) : "").append(".log").toString());
                    if (!file.exists())
                    {
                        File.__<clinit>();
                        new File(log_path).mkdirs();
                        file.createNewFile();
                    }
                    OpenOption[] optionArray1 = new OpenOption[] { StandardOpenOption.APPEND };
                    Files.write(file.toPath(), String.instancehelper_getBytes(new StringBuilder().append(extra).append(message).append((num == 0) ? "" : "\r\n").toString(), "utf-8"), optionArray1);
                }
            }
            catch (Exception exception1)
            {
                if (ByteCodeHelper.MapException<Exception>(exception1, 2) == null)
                {
                    throw;
                }
                return;
            }
        }
    }
}

