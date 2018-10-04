namespace org.telegram.api.message.media
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.api.geo.point;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLMessageMediaVenue : TLAbsMessageMedia
    {
        private string address;
        public const int CLASS_ID = 0x7912b71f;
        private TLAbsGeoPoint geo;
        private string provider;
        private string title;
        private string venue_id;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xac, 0x68 })]
        public TLMessageMediaVenue()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLMessageMediaVenue(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x5b, 0x72, 0x6c, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.geo = StreamingUtils.readTLObject(stream, context);
            this.title = StreamingUtils.readTLString(stream);
            this.address = StreamingUtils.readTLString(stream);
            this.provider = StreamingUtils.readTLString(stream);
            this.venue_id = StreamingUtils.readTLString(stream);
        }

        public virtual string getAddress() => 
            this.address;

        public override int getClassId() => 
            0x7912b71f;

        public virtual TLAbsGeoPoint getGeo() => 
            this.geo;

        public virtual string getProvider() => 
            this.provider;

        public virtual string getTitle() => 
            this.title;

        public virtual string getVenue_id() => 
            this.venue_id;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x51, 0x6c, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.geo, stream);
            StreamingUtils.writeTLString(this.title, stream);
            StreamingUtils.writeTLString(this.address, stream);
            StreamingUtils.writeTLString(this.provider, stream);
            StreamingUtils.writeTLString(this.venue_id, stream);
        }

        public virtual void setAddress(string address)
        {
            this.address = address;
        }

        public virtual void setGeo(TLAbsGeoPoint geo)
        {
            this.geo = geo;
        }

        public virtual void setProvider(string provider)
        {
            this.provider = provider;
        }

        public virtual void setTitle(string title)
        {
            this.title = title;
        }

        public virtual void setVenue_id(string venue_id)
        {
            this.venue_id = venue_id;
        }

        public override string toString() => 
            "messageMediaVenue#7912b71f";
    }
}

