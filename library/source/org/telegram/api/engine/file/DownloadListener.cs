namespace org.telegram.api.engine.file
{
    using System;

    public interface DownloadListener
    {
        void onDownloaded(Downloader.DownloadTask ddt);
        void onFailed();
        void onPartDownloaded(int i1, int i2);
    }
}

