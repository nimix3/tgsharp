namespace org.telegram.api.functions
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/tl/TLObject;>;")]
    public class TLRequestInitConnection : TLMethod
    {
        private int apiId;
        private string appVersion;
        public const int CLASS_ID = 0x69796de9;
        private string deviceModel;
        private string langCode;
        private TLMethod query;
        private string systemVersion;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xae, 0x68 })]
        public TLRequestInitConnection()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestInitConnection(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xbc, 0x68, 0x67, 0x67, 0x67, 0x68, 0x68, 0x68 })]
        public TLRequestInitConnection(int apiId, string deviceModel, string systemVersion, string appVersion, string langCode, TLMethod query)
        {
            this.apiId = apiId;
            this.deviceModel = deviceModel;
            this.systemVersion = systemVersion;
            this.appVersion = appVersion;
            this.langCode = langCode;
            this.query = query;
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 160, 70, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.apiId = StreamingUtils.readInt(stream);
            this.deviceModel = StreamingUtils.readTLString(stream);
            this.systemVersion = StreamingUtils.readTLString(stream);
            this.appVersion = StreamingUtils.readTLString(stream);
            this.langCode = StreamingUtils.readTLString(stream);
            this.query = StreamingUtils.readTLMethod(stream, context);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(0x3d)]
        public override TLObject deserializeResponse(InputStream stream, TLContext context) => 
            this.query.deserializeResponse(stream, context);

        public virtual int getApiId() => 
            this.apiId;

        public virtual string getAppVersion() => 
            this.appVersion;

        public override int getClassId() => 
            0x69796de9;

        public virtual string getDeviceModel() => 
            this.deviceModel;

        public virtual string getLangCode() => 
            this.langCode;

        public virtual TLMethod getQuery() => 
            this.query;

        public virtual string getSystemVersion() => 
            this.systemVersion;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x7c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.apiId, stream);
            StreamingUtils.writeTLString(this.deviceModel, stream);
            StreamingUtils.writeTLString(this.systemVersion, stream);
            StreamingUtils.writeTLString(this.appVersion, stream);
            StreamingUtils.writeTLString(this.langCode, stream);
            StreamingUtils.writeTLMethod(this.query, stream);
        }

        public virtual void setApiId(int value)
        {
            this.apiId = value;
        }

        public virtual void setAppVersion(string value)
        {
            this.appVersion = value;
        }

        public virtual void setDeviceModel(string value)
        {
            this.deviceModel = value;
        }

        public virtual void setLangCode(string value)
        {
            this.langCode = value;
        }

        public virtual void setQuery(TLMethod value)
        {
            this.query = value;
        }

        public virtual void setSystemVersion(string value)
        {
            this.systemVersion = value;
        }

        public override string toString() => 
            "initConnection#69796de9";
    }
}

