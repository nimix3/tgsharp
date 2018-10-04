namespace jawnae.pyronet
{
    using java.io;
    using java.lang;
    using java.nio;
    using System;

    public class PyroClientAdapter : Object, PyroClientListener
    {
        private const string LOGTAG = "PYROCLIENTADAPTER";

        public virtual void connectedClient(PyroClient client)
        {
        }

        public virtual void disconnectedClient(PyroClient client)
        {
        }

        public virtual void droppedClient(PyroClient client, IOException cause)
        {
            if (cause != null)
            {
            }
        }

        public virtual void receivedData(PyroClient client, ByteBuffer data)
        {
        }

        public virtual void sentData(PyroClient client, int bytes)
        {
        }

        public virtual void unconnectableClient(PyroClient client)
        {
        }

        public virtual void unconnectableClient(PyroClient client, Exception cause)
        {
        }
    }
}

