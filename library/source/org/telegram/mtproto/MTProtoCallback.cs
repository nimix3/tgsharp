namespace org.telegram.mtproto
{
    using System;

    public interface MTProtoCallback
    {
        void onApiMessage(byte[] barr, MTProto mtp);
        void onAuthInvalidated(MTProto mtp);
        void onConfirmed(int i);
        void onRpcError(int i1, int i2, string str, MTProto mtp);
        void onRpcResult(int i, byte[] barr, MTProto mtp);
        void onSessionCreated(MTProto mtp);
    }
}

