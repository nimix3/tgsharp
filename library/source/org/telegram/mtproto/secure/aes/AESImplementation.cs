namespace org.telegram.mtproto.secure.aes
{
    using IKVM.Attributes;
    using System;

    public interface AESImplementation
    {
        [Throws(new string[] { "java.io.IOException" })]
        void AES256IGEDecrypt(string str1, string str2, byte[] barr1, byte[] barr2);
        void AES256IGEDecrypt(byte[] barr1, byte[] barr2, int i, byte[] barr3, byte[] barr4);
        [Throws(new string[] { "java.io.IOException" })]
        void AES256IGEEncrypt(string str1, string str2, byte[] barr1, byte[] barr2);
        void AES256IGEEncrypt(byte[] barr1, byte[] barr2, int i, byte[] barr3, byte[] barr4);
    }
}

