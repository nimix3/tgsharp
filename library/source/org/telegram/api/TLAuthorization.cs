namespace org.telegram.api
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLAuthorization : TLObject
    {
        private int apiId;
        private string appName;
        private string appVersion;
        public const int CLASS_ID = 0x7bf2e6f6;
        private string country;
        private int dateActive;
        private int dateCreated;
        private string deviceModel;
        private int flags;
        private long hash;
        private string ip;
        private string platform;
        private string region;
        private string systemVersion;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb8, 0x68 })]
        public TLAuthorization()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAuthorization(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 160, 0xbd, 0x68, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            base.deserializeBody(stream, context);
            this.hash = StreamingUtils.readLong(stream);
            this.flags = StreamingUtils.readInt(stream);
            this.deviceModel = StreamingUtils.readTLString(stream);
            this.platform = StreamingUtils.readTLString(stream);
            this.systemVersion = StreamingUtils.readTLString(stream);
            this.apiId = StreamingUtils.readInt(stream);
            this.appName = StreamingUtils.readTLString(stream);
            this.appVersion = StreamingUtils.readTLString(stream);
            this.dateCreated = StreamingUtils.readInt(stream);
            this.dateActive = StreamingUtils.readInt(stream);
            this.ip = StreamingUtils.readTLString(stream);
            this.country = StreamingUtils.readTLString(stream);
            this.region = StreamingUtils.readTLString(stream);
        }

        public virtual int getApiId() => 
            this.apiId;

        public virtual string getAppName() => 
            this.appName;

        public virtual string getAppVersion() => 
            this.appVersion;

        public override int getClassId() => 
            0x7bf2e6f6;

        public virtual string getCountry() => 
            this.country;

        public virtual int getDateActive() => 
            this.dateActive;

        public virtual int getDateCreated() => 
            this.dateCreated;

        public virtual string getDeviceModel() => 
            this.deviceModel;

        public virtual int getFlags() => 
            this.flags;

        public virtual long getHash() => 
            this.hash;

        public virtual string getIp() => 
            this.ip;

        public virtual string getPlatform() => 
            this.platform;

        public virtual string getRegion() => 
            this.region;

        public virtual string getSystemVersion() => 
            this.systemVersion;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 160, 0xac, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeLong(this.hash, stream);
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeTLString(this.deviceModel, stream);
            StreamingUtils.writeTLString(this.platform, stream);
            StreamingUtils.writeTLString(this.systemVersion, stream);
            StreamingUtils.writeInt(this.apiId, stream);
            StreamingUtils.writeTLString(this.appName, stream);
            StreamingUtils.writeTLString(this.appVersion, stream);
            StreamingUtils.writeInt(this.dateCreated, stream);
            StreamingUtils.writeInt(this.dateActive, stream);
            StreamingUtils.writeTLString(this.ip, stream);
            StreamingUtils.writeTLString(this.country, stream);
            StreamingUtils.writeTLString(this.region, stream);
        }

        public virtual void setApiId(int apiId)
        {
            this.apiId = apiId;
        }

        public virtual void setAppName(string appName)
        {
            this.appName = appName;
        }

        public virtual void setAppVersion(string appVersion)
        {
            this.appVersion = appVersion;
        }

        public virtual void setCountry(string country)
        {
            this.country = country;
        }

        public virtual void setDateActive(int dateActive)
        {
            this.dateActive = dateActive;
        }

        public virtual void setDateCreated(int dateCreated)
        {
            this.dateCreated = dateCreated;
        }

        public virtual void setDeviceModel(string deviceModel)
        {
            this.deviceModel = deviceModel;
        }

        public virtual void setFlags(int flags)
        {
            this.flags = flags;
        }

        public virtual void setHash(long hash)
        {
            this.hash = hash;
        }

        public virtual void setIp(string ip)
        {
            this.ip = ip;
        }

        public virtual void setPlatform(string platform)
        {
            this.platform = platform;
        }

        public virtual void setRegion(string region)
        {
            this.region = region;
        }

        public virtual void setSystemVersion(string systemVersion)
        {
            this.systemVersion = systemVersion;
        }

        public override string toString() => 
            "authorization#7bf2e6f6";
    }
}

