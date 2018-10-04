namespace org.telegram.mtproto.transport
{
    using IKVM.Attributes;
    using java.lang;
    using System;
    using System.Runtime.CompilerServices;

    public class ConnectionType : Object
    {
        private int connectionType;
        private string host;
        private int id;
        private int port;
        public const int TYPE_TCP = 0;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9c, 0x68, 0x67, 0x67, 0x67, 0x68 })]
        public ConnectionType(int id, string host, int port, int connectionType)
        {
            this.id = id;
            this.host = host;
            this.port = port;
            this.connectionType = connectionType;
        }

        public virtual int getConnectionType() => 
            this.connectionType;

        public virtual string getHost() => 
            this.host;

        public virtual int getId() => 
            this.id;

        public virtual int getPort() => 
            this.port;
    }
}

