namespace org.telegram.mtproto.transport
{
    using IKVM.Attributes;
    using IKVM.Runtime;
    using java.io;
    using java.lang;
    using java.net;
    using org.telegram.mtproto.log;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;

    public class PlainTcpConnection : Object
    {
        private const int CONNECTION_TIMEOUT = 0x1388;
        private bool isBroken;
        private Socket socket = new Socket();
        private const string TAG = "PlainTcpConnection";

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xac, 0x68, 0x6b, 0x77, 0x6c, 0x6c, 0x75, 0x67 })]
        public PlainTcpConnection(string ip, int port)
        {
            this.socket.connect(new InetSocketAddress(ip, port), 0x1388);
            this.socket.setKeepAlive(true);
            this.socket.setTcpNoDelay(true);
            this.socket.getOutputStream().write(0xef);
            this.isBroken = false;
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x1c, 0xbd, 2, 0x61, 0x8b })]
        public virtual void destroy()
        {
            try
            {
                this.socket.close();
            }
            catch (IOException exception1)
            {
                IOException exception2 = ByteCodeHelper.MapException<IOException>(exception1, 1);
                Logger.e("PlainTcpConnection", (Exception) exception2);
                return;
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x16, 0x67 })]
        public virtual byte[] executeMethod(byte[] request)
        {
            this.writeMessage(request);
            return this.readMessage();
        }

        public virtual Socket getSocket() => 
            this.socket;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x23, 0x67, 100, 0x8b })]
        private int readByte(InputStream stream1)
        {
            int num = stream1.read();
            if (num < 0)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IOException();
            }
            return num;
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xba, 0x6c, 0x88, 0x65, 0x9d, 100 })]
        private byte[] readMessage()
        {
            InputStream stream = this.socket.getInputStream();
            int num = this.readByte(stream);
            if (num == 0x7f)
            {
                num = (this.readByte(stream) + (this.readByte(stream) << 8)) + (this.readByte(stream) << 0x10);
            }
            int count = num * 4;
            return StreamingUtils.readBytes(count, stream);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 5, 0x66, 0x68, 0x65, 0x68, 0x6d, 0x6f, 0x70, 0x62, 0x8a, 0x67, 0x67, 0x74, 0x72 })]
        private void writeMessage(byte[] buffer1)
        {
            ByteArrayOutputStream stream = new ByteArrayOutputStream();
            if ((buffer1.Length / 4) >= 0x7f)
            {
                int num = buffer1.Length / 4;
                StreamingUtils.writeByte(0x7f, stream);
                StreamingUtils.writeByte((int) (num & 0xff), stream);
                StreamingUtils.writeByte((int) ((num >> 8) & 0xff), stream);
                StreamingUtils.writeByte((int) ((num >> 0x10) & 0xff), stream);
            }
            else
            {
                StreamingUtils.writeByte((int) (buffer1.Length / 4), stream);
            }
            StreamingUtils.writeByteArray(buffer1, stream);
            byte[] buffer = stream.toByteArray();
            this.socket.getOutputStream().write(buffer, 0, buffer.Length);
            this.socket.getOutputStream().flush();
        }
    }
}

