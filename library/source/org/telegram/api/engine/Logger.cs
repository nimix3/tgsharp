namespace org.telegram.api.engine
{
    using IKVM.Attributes;
    using java.lang;
    using System;
    using System.Runtime.CompilerServices;

    public class Logger : Object
    {
        private static LoggerInterface logInterface;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb8, 0x67, 0x8e, 0x9f, 13 })]
        public static void d(string tag, string message)
        {
            if (logInterface != null)
            {
                logInterface.d(tag, message);
            }
            else
            {
                System.get_out().println(new StringBuilder().append(tag).append(":").append(message).toString());
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 6, 0x67, 0x8e, 0x88 })]
        public static void e(string tag, Exception t)
        {
            if (logInterface != null)
            {
                logInterface.e(tag, t);
            }
            else
            {
                Throwable.instancehelper_printStackTrace(t);
            }
        }

        public static void registerInterface(LoggerInterface logInterface)
        {
            Logger.logInterface = logInterface;
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 170, 0x67, 0x8e, 0x9f, 13 })]
        public static void w(string tag, string message)
        {
            if (logInterface != null)
            {
                logInterface.w(tag, message);
            }
            else
            {
                System.get_out().println(new StringBuilder().append(tag).append(":").append(message).toString());
            }
        }
    }
}

