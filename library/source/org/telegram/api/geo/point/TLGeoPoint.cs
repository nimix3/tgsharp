namespace org.telegram.api.geo.point
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLGeoPoint : TLAbsGeoPoint
    {
        public const int CLASS_ID = 0x2049d70c;
        private double lat;
        private double lon;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa8, 0x68 })]
        public TLGeoPoint()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLGeoPoint(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 30, 0x6d, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.lon = StreamingUtils.readDouble(stream);
            this.lat = StreamingUtils.readDouble(stream);
        }

        public override int getClassId() => 
            0x2049d70c;

        public virtual double getLat() => 
            this.lat;

        public virtual double getLon() => 
            this.lon;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x17, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeDouble(this.lon, stream);
            StreamingUtils.writeDouble(this.lat, stream);
        }

        public virtual void setLat(double lat)
        {
            this.lat = lat;
        }

        public virtual void setLon(double lon)
        {
            this.lon = lon;
        }

        public override string toString() => 
            "geoPoint#2049d70c";
    }
}

