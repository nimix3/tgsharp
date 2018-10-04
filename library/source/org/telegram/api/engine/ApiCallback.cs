namespace org.telegram.api.engine
{
    using org.telegram.api.updates;
    using System;

    public interface ApiCallback
    {
        void onAuthCancelled(TelegramApi ta);
        void onUpdate(TLAbsUpdates tlau);
        void onUpdatesInvalidated(TelegramApi ta);
    }
}

