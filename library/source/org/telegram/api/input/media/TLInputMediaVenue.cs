namespace org.telegram.api.input.media
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.api.input.geopoint;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLInputMediaVenue : TLObject
    {
        private string address;
        public const int CLASS_ID = 0x2827a81a;
        private TLAbsInputGeoPoint inputGeoPoint;
        private string provider;
        private string title;
        private string venueId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb2, 0x68 })]
        public TLInputMediaVenue()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLInputMediaVenue(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x60, 0x68, 0x72, 0x6c, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            base.deserializeBody(stream, context);
            this.inputGeoPoint = StreamingUtils.readTLObject(stream, context);
            this.title = StreamingUtils.readTLString(stream);
            this.address = StreamingUtils.readTLString(stream);
            this.provider = StreamingUtils.readTLString(stream);
            this.venueId = StreamingUtils.readTLString(stream);
        }

        public virtual string getAddress() => 
            this.address;

        public override int getClassId() => 
            0x2827a81a;

        public virtual TLAbsInputGeoPoint getInputGeoPoint() => 
            this.inputGeoPoint;

        public virtual string getProvider() => 
            this.provider;

        public virtual string getTitle() => 
            this.title;

        public virtual string getVenueId() => 
            this.venueId;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x56, 0x67, 0x6c, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            base.serializeBody(stream);
            StreamingUtils.writeTLObject(this.inputGeoPoint, stream);
            StreamingUtils.writeTLString(this.title, stream);
            StreamingUtils.writeTLString(this.address, stream);
            StreamingUtils.writeTLString(this.provider, stream);
            StreamingUtils.writeTLString(this.venueId, stream);
        }

        public virtual void setAddress(string address)
        {
            this.address = address;
        }

        public virtual void setInputGeoPoint(TLAbsInputGeoPoint inputGeoPoint)
        {
            this.inputGeoPoint = inputGeoPoint;
        }

        public virtual void setProvider(string provider)
        {
            this.provider = provider;
        }

        public virtual void setTitle(string title)
        {
            this.title = title;
        }

        public virtual void setVenueId(string venueId)
        {
            this.venueId = venueId;
        }

        public override string toString() => 
            "input.mediaVenue#2827a81a";
    }
}

