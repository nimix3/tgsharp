namespace org.telegram.mtproto.secure.aes
{
    using IKVM.Attributes;
    using IKVM.Runtime;
    using java.io;
    using java.lang;
    using org.telegram.mtproto.secure;
    using System;
    using System.Runtime.CompilerServices;

    public class DefaultAESImplementation : Object, AESImplementation
    {
        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 
            0x4d, 0x67, 0x87, 0x66, 0x8e, 0x6b, 0x8b, 0x72, 0x6d, 0x89, 0x71, 0x69, 0x69, 0x30, 0xa8, 0x6d,
            0x69, 0x31, 200, 100, 0x63, 0x89, 0x69, 0x65, 0x67, 0x67, 0x69
        })]
        public virtual void AES256IGEDecrypt(string sourceFile, string destFile, byte[] iv, byte[] key)
        {
            int num1;
            File file = new File(sourceFile);
            File file2 = new File(destFile);
            AESFastEngine engine = new AESFastEngine();
            engine.init(false, new KeyParameter(key));
            byte[] buffer = CryptoUtils.substring(iv, 0x10, 0x10);
            byte[] buffer2 = CryptoUtils.substring(iv, 0, 0x10);
            BufferedInputStream.__<clinit>();
            BufferedInputStream stream = new BufferedInputStream(new FileInputStream(file));
            BufferedOutputStream stream2 = new BufferedOutputStream(new FileOutputStream(file2));
            byte[] buffer3 = new byte[0x10];
        Label_0060:
            num1 = stream.read(buffer3);
            if (num1 <= 0)
            {
                stream2.flush();
                stream2.close();
                stream.close();
            }
            else
            {
                byte[] @in = new byte[0x10];
                int index = 0;
                while (true)
                {
                    if (index >= 0x10)
                    {
                        break;
                    }
                    @in[index] = (byte) ((sbyte) (buffer3[index] ^ buffer[index]));
                    index++;
                }
                engine.processBlock(@in, 0, @in, 0);
                index = 0;
                while (true)
                {
                    if (index >= 0x10)
                    {
                        break;
                    }
                    @in[index] = (byte) ((sbyte) (@in[index] ^ buffer2[index]));
                    index++;
                }
                buffer2 = buffer3;
                buffer = @in;
                buffer3 = new byte[0x10];
                stream2.write(@in);
                goto Label_0060;
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 
            0x9f, 0xa3, 0x66, 0x8e, 0x85, 0x63, 0x63, 100, 0x83, 0x6b, 0x87, 0x69, 0x37, 0xa8, 0x6d, 0x69,
            0x37, 200, 0x62, 100, 0x62, 0x84, 0x92, 0xbc, 2, 0x62, 0xe7, 0x2c, 0xeb, 0x58
        })]
        public virtual void AES256IGEDecrypt(byte[] src, byte[] dest, int len, byte[] iv, byte[] key)
        {
            int expressionStack_AF_0;
            AESFastEngine engine = new AESFastEngine();
            engine.init(false, new KeyParameter(key));
            int num = len / 0x10;
            byte[] buffer = iv;
            byte[] buffer2 = iv;
            int num2 = 0x10;
            int num3 = 0;
            int num4 = 0;
        Label_0029:
            if (num4 >= num)
            {
                return;
            }
            int inOff = num4 * 0x10;
            int num6 = 0;
            while (true)
            {
                if (num6 >= 0x10)
                {
                    break;
                }
                dest[inOff + num6] = (byte) ((sbyte) (src[inOff + num6] ^ buffer[num2 + num6]));
                num6++;
            }
            engine.processBlock(dest, inOff, dest, inOff);
            num6 = 0;
            while (true)
            {
                if (num6 >= 0x10)
                {
                    break;
                }
                dest[inOff + num6] = (byte) ((sbyte) (dest[inOff + num6] ^ buffer2[num3 + num6]));
                num6++;
            }
            buffer2 = src;
            num3 = inOff;
            buffer = dest;
            num2 = inOff;
            if (0x1f != -1)
            {
                int expressionStack_AE_1 = num4;
                int expressionStack_AE_0 = 0x1f;
                expressionStack_AF_0 = expressionStack_AE_1 % expressionStack_AE_0;
                goto Label_00AF;
            }
            else
            {
                int expressionStack_A9_1 = num4;
            }
            expressionStack_AF_0 = 0;
        Label_00AF:
            if (expressionStack_AF_0 == 0x20)
            {
                try
                {
                    Thread.sleep(10L);
                }
                catch (InterruptedException exception1)
                {
                    InterruptedException exception2 = ByteCodeHelper.MapException<InterruptedException>(exception1, 1);
                    Throwable.instancehelper_printStackTrace(exception2);
                }
            }
            num4++;
            goto Label_0029;
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 
            0x29, 0x67, 0x87, 0x66, 0x8e, 0x6b, 0x8b, 0x72, 0x6d, 0x89, 0x71, 0x69, 0x69, 0x31, 0xa8, 0x6d,
            0x69, 0x30, 200, 0x63, 100, 0x89, 0x69, 0x65, 0x67, 0x67, 0x69
        })]
        public virtual void AES256IGEEncrypt(string sourceFile, string destFile, byte[] iv, byte[] key)
        {
            int num1;
            File file = new File(sourceFile);
            File file2 = new File(destFile);
            AESFastEngine engine = new AESFastEngine();
            engine.init(true, new KeyParameter(key));
            byte[] buffer = CryptoUtils.substring(iv, 0x10, 0x10);
            byte[] buffer2 = CryptoUtils.substring(iv, 0, 0x10);
            BufferedInputStream.__<clinit>();
            BufferedInputStream stream = new BufferedInputStream(new FileInputStream(file));
            BufferedOutputStream stream2 = new BufferedOutputStream(new FileOutputStream(file2));
            byte[] buffer3 = new byte[0x10];
        Label_0060:
            num1 = stream.read(buffer3);
            if (num1 <= 0)
            {
                stream2.flush();
                stream2.close();
                stream.close();
            }
            else
            {
                byte[] @in = new byte[0x10];
                int index = 0;
                while (true)
                {
                    if (index >= 0x10)
                    {
                        break;
                    }
                    @in[index] = (byte) ((sbyte) (buffer3[index] ^ buffer2[index]));
                    index++;
                }
                engine.processBlock(@in, 0, @in, 0);
                index = 0;
                while (true)
                {
                    if (index >= 0x10)
                    {
                        break;
                    }
                    @in[index] = (byte) ((sbyte) (@in[index] ^ buffer[index]));
                    index++;
                }
                buffer = buffer3;
                buffer2 = @in;
                buffer3 = new byte[0x10];
                stream2.write(@in);
                goto Label_0060;
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 
            9, 0x66, 0x8e, 0x85, 0x63, 0x63, 100, 0x83, 0x8b, 0x87, 0x69, 0x37, 0xa8, 0x6d, 0x69, 0x37,
            200, 0x62, 100, 0x62, 0xe4, 0x31, 0xeb, 0x51
        })]
        public virtual void AES256IGEEncrypt(byte[] src, byte[] dest, int len, byte[] iv, byte[] key)
        {
            AESFastEngine engine = new AESFastEngine();
            engine.init(true, new KeyParameter(key));
            int num = len / 0x10;
            byte[] buffer = iv;
            byte[] buffer2 = iv;
            int num2 = 0x10;
            int num3 = 0;
            for (int i = 0; i < num; i++)
            {
                int inOff = i * 0x10;
                int num6 = 0;
                while (true)
                {
                    if (num6 >= 0x10)
                    {
                        break;
                    }
                    dest[inOff + num6] = (byte) ((sbyte) (src[inOff + num6] ^ buffer2[num3 + num6]));
                    num6++;
                }
                engine.processBlock(dest, inOff, dest, inOff);
                num6 = 0;
                while (true)
                {
                    if (num6 >= 0x10)
                    {
                        break;
                    }
                    dest[inOff + num6] = (byte) ((sbyte) (dest[inOff + num6] ^ buffer[num2 + num6]));
                    num6++;
                }
                buffer = src;
                num2 = inOff;
                buffer2 = dest;
                num3 = inOff;
            }
        }
    }
}

