namespace org.telegram.mtproto.transport
{
    using System;

    public interface TcpContextCallback
    {
        void onChannelBroken(TcpContext tc);
        void onError(int i, TcpContext tc);
        void onFastConfirm(int i);
        void onRawMessage(byte[] barr, int i1, int i2, TcpContext tc);
    }
}

