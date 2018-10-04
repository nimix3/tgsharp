namespace org.telegram.mtproto.state
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;

    public class MemoryProtoState : AbsMTProtoState
    {
        private string address;
        private byte[] authKey;
        private int port;
        private KnownSalt[] salts = new KnownSalt[0];

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9f, 0xe8, 0x3a, 0xec, 0x47, 0x67, 0x67, 0x67 })]
        public MemoryProtoState(byte[] authKey, string address, int port)
        {
            this.authKey = authKey;
            this.port = port;
            this.address = address;
        }

        public override byte[] getAuthKey() => 
            this.authKey;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(30)]
        public override ConnectionInfo[] getAvailableConnections() => 
            new ConnectionInfo[] { new ConnectionInfo(0, 0, this.address, this.port) };

        public override KnownSalt[] readKnownSalts() => 
            this.salts;

        protected internal override void writeKnownSalts(KnownSalt[] salts)
        {
            this.salts = salts;
        }
    }
}

