namespace org.telegram.api.engine
{
    using IKVM.Attributes;
    using java.io;
    using java.lang;
    using java.util.regex;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class RpcException : IOException
    {
        private int errorCode;
        private string errorTag;
        [Modifiers(0x1a)]
        private static Pattern REGEXP_PATTERN = Pattern.compile("[A-Z_0-9]+");

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa7, 110, 0x67, 0x6c })]
        public RpcException(int errorCode, string message) : base(getErrorMessage(message))
        {
            this.errorCode = errorCode;
            this.errorTag = getErrorTag(message);
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected RpcException(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void __<clinit>()
        {
        }

        public virtual int getErrorCode() => 
            this.errorCode;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb8, 0x63, 0x86, 0x6c, 100, 0x8a })]
        private static string getErrorMessage(string text1)
        {
            if (text1 == null)
            {
                return "Unknown error";
            }
            int num = String.instancehelper_indexOf(text1, ":");
            if (num > 0)
            {
                return String.instancehelper_substring(text1, num);
            }
            return text1;
        }

        public virtual string getErrorTag() => 
            this.errorTag;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xad, 0x63, 0x86, 0x7c, 0x68, 0x89 })]
        private static string getErrorTag(string text1)
        {
            if (text1 != null)
            {
                CharSequence sequence;
                object obj2 = text1;
                sequence.__<ref> = obj2;
                Matcher matcher = REGEXP_PATTERN.matcher(sequence);
                if (matcher.find())
                {
                    return matcher.group();
                }
            }
            return "UNKNOWN";
        }
    }
}

