// GlobalCrypto Class Library V.1 By NIMIX3
// IV & KEY Should 32Characters Only
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace HoopoeTelegram
{
    public class GlobalCrypto
    {
        public string Encrypt(string PlainText, string KEY, string IV)
        {
            try
            {
                byte[] _encdata;
                MemoryStream ms = new MemoryStream();
                RijndaelManaged aes = new RijndaelManaged();
                aes.KeySize = 256;
                aes.BlockSize = 256;
                aes.Padding = PaddingMode.Zeros;
                aes.Mode = CipherMode.CBC;
                ICryptoTransform encryptor = aes.CreateEncryptor(Convert.FromBase64String(KEY), Convert.FromBase64String(IV));
                byte[] _text = Encoding.Default.GetBytes(PlainText);

                CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write);
                cs.Write(_text, 0, _text.Length);
                cs.FlushFinalBlock();

                _encdata = ms.ToArray();
                ms.Close();
                cs.Close();
                return Convert.ToBase64String(_encdata);
            }
            catch
            {
                return null;
            }
        }

        public string Decrypt(string Cypher, string KEY, string IV)
        {
            try
            {
                byte[] _data;
                int i = 0;
                MemoryStream ms = new MemoryStream(Convert.FromBase64String(Cypher));
                RijndaelManaged aes = new RijndaelManaged();
                aes.KeySize = 256;
                aes.BlockSize = 256;
                aes.Padding = PaddingMode.Zeros;
                aes.Mode = CipherMode.CBC;
                ICryptoTransform decryptor = aes.CreateDecryptor(
                        Convert.FromBase64String(KEY), Convert.FromBase64String(IV));
                CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read);
                _data = new byte[ms.Length];
                i = cs.Read(_data, 0, _data.Length);
                return Encoding.Default.GetString(_data, 0, i);
            }
            catch
            {
                return null;
            }
        }
    }
}