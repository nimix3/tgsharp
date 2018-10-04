namespace org.telegram.api.engine
{
    using IKVM.Attributes;
    using java.lang;
    using System;
    using System.Runtime.CompilerServices;

    public class AppInfo : Object
    {
        protected internal int apiId;
        protected internal string appVersion;
        protected internal string deviceModel;
        protected internal string langCode;
        protected internal string systemVersion;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb6, 0x68, 0x67, 0x67, 0x67, 0x68, 0x68 })]
        public AppInfo(int apiId, string deviceModel, string systemVersion, string appVersion, string langCode)
        {
            this.apiId = apiId;
            this.deviceModel = deviceModel;
            this.systemVersion = systemVersion;
            this.appVersion = appVersion;
            this.langCode = langCode;
        }

        public virtual int getApiId() => 
            this.apiId;

        public virtual string getAppVersion() => 
            this.appVersion;

        public virtual string getDeviceModel() => 
            this.deviceModel;

        public virtual string getLangCode() => 
            this.langCode;

        public virtual string getSystemVersion() => 
            this.systemVersion;
    }
}

