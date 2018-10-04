namespace org.telegram.api.paymentapi
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLPostAddress : TLObject
    {
        private string city;
        public const int CLASS_ID = 0x1e8caaeb;
        private string countryIso2;
        private string postCode;
        private string state;
        private string streetLine1;
        private string streetLine2;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa8, 0x68 })]
        public TLPostAddress()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLPostAddress(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 20, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.streetLine1 = StreamingUtils.readTLString(stream);
            this.streetLine2 = StreamingUtils.readTLString(stream);
            this.city = StreamingUtils.readTLString(stream);
            this.state = StreamingUtils.readTLString(stream);
            this.countryIso2 = StreamingUtils.readTLString(stream);
            this.postCode = StreamingUtils.readTLString(stream);
        }

        public virtual string getCity() => 
            this.city;

        public override int getClassId() => 
            0x1e8caaeb;

        public virtual string getCountryIso2() => 
            this.countryIso2;

        public virtual string getPostCode() => 
            this.postCode;

        public virtual string getState() => 
            this.state;

        public virtual string getStreetLine1() => 
            this.streetLine1;

        public virtual string getStreetLine2() => 
            this.streetLine2;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 10, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLString(this.streetLine1, stream);
            StreamingUtils.writeTLString(this.streetLine2, stream);
            StreamingUtils.writeTLString(this.city, stream);
            StreamingUtils.writeTLString(this.state, stream);
            StreamingUtils.writeTLString(this.countryIso2, stream);
            StreamingUtils.writeTLString(this.postCode, stream);
        }

        public override string toString() => 
            "postAddress#1e8caaeb";
    }
}

