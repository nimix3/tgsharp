namespace org.telegram.api.engine
{
    using System;

    public interface LoggerInterface
    {
        void d(string str1, string str2);
        void e(string str, Exception t);
        void w(string str1, string str2);
    }
}

