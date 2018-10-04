namespace org.telegram.api.decryptedmessage
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLDecryptedMessageMediaGeoPoint : TLAbsDecryptedMessageMedia
    {
        public const int CLASS_ID = 0x35480a59;
        private double latitude;
        private double longtitude;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb2, 0x68 })]
        public TLDecryptedMessageMediaGeoPoint()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLDecryptedMessageMediaGeoPoint(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 40, 0x6d, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.latitude = StreamingUtils.readDouble(stream);
            this.longtitude = StreamingUtils.readDouble(stream);
        }

        public override int getClassId() => 
            0x35480a59;

        public virtual double getLatitude() => 
            this.latitude;

        public virtual double getLongtitude() => 
            this.longtitude;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x21, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeDouble(this.latitude, stream);
            StreamingUtils.writeDouble(this.longtitude, stream);
        }

        public virtual void setLatitude(double latitude)
        {
            this.latitude = latitude;
        }

        public virtual void setLongtitude(double longtitude)
        {
            this.longtitude = longtitude;
        }

        public override string toString() => 
            "decryptedMessageMediaGeoPoint#35480a59";
    }
}

