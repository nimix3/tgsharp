namespace org.telegram.mtproto.util
{
    using java.lang;
    using System;

    public class TimeUtil : Object
    {
        public static int getUnixTime(long msgId) => 
            ((int) (msgId >> 0x20));
    }
}

