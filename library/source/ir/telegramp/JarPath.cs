namespace ir.telegramp
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.lang;
    using System;
    using System.Runtime.CompilerServices;

    public class JarPath : Object
    {
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9e, 0x7a, 0x73, 110, 0x7f, 20, 0x7f, 20 })]
        public static string GetPath()
        {
            CharSequence sequence;
            string str = ClassLiteral<JarPath>.Value.getProtectionDomain().getCodeSource().getLocation().getPath();
            str = String.instancehelper_substring(str, 0, String.instancehelper_lastIndexOf(str, "/"));
            object obj2 = " ";
            object obj3 = "%20";
            sequence.__<ref> = obj3;
            obj3 = obj2;
            sequence.__<ref> = obj3;
            obj3 = @"\";
            obj2 = "/";
            string introduced4 = String.instancehelper_replace(String.instancehelper_substring(str, 1, String.instancehelper_length(str)), sequence, sequence);
            sequence.__<ref> = obj2;
            obj2 = obj3;
            sequence.__<ref> = obj2;
            return String.instancehelper_replace(introduced4, sequence, sequence);
        }
    }
}

