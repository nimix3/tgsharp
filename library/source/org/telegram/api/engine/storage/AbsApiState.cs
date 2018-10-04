namespace org.telegram.api.engine.storage
{
    using org.telegram.api;
    using org.telegram.mtproto.state;
    using System;

    public interface AbsApiState
    {
        byte[] getAuthKey(int i);
        ConnectionInfo[] getAvailableConnections(int i);
        AbsMTProtoState getMtProtoState(int i);
        int getPrimaryDc();
        bool isAuthenticated(int i);
        void putAuthKey(int i, byte[] barr);
        void reset();
        void resetAuth();
        void setAuthenticated(int i, bool b);
        void setPrimaryDc(int i);
        void updateSettings(TLConfig tlc);
    }
}

