namespace org.telegram.api.engine.file
{
    using System;

    public interface UploadListener
    {
        void onPartUploaded(int i1, int i2);
        void onUploaded(Uploader.UploadTask uut);
    }
}

