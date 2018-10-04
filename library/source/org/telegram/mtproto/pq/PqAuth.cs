namespace org.telegram.mtproto.pq
{
    using IKVM.Attributes;
    using java.lang;
    using java.net;
    using System;
    using System.Runtime.CompilerServices;

    public class PqAuth : Object
    {
        private byte[] authKey;
        private long serverSalt;
        private Socket socket;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9e, 0x68, 0x67, 0x67, 0x67 })]
        public PqAuth(byte[] authKey, long serverSalt, Socket socket)
        {
            this.authKey = authKey;
            this.serverSalt = serverSalt;
            this.socket = socket;
        }

        public virtual byte[] getAuthKey() => 
            this.authKey;

        public virtual long getServerSalt() => 
            this.serverSalt;

        public virtual Socket getSocket() => 
            this.socket;
    }
}

