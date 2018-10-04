namespace jawnae.pyronet
{
    using java.io;
    using java.lang;
    using java.nio;
    using System;

    public interface PyroClientListener
    {
        void connectedClient(PyroClient pc);
        void disconnectedClient(PyroClient pc);
        void droppedClient(PyroClient pc, IOException ioe);
        void receivedData(PyroClient pc, ByteBuffer bb);
        void sentData(PyroClient pc, int i);
        void unconnectableClient(PyroClient pc, Exception e);
    }
}

