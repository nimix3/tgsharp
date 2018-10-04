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
    public class TLInputMediaGeoPoint : TLAbsInputMedia
    {
        public const int CLASS_ID = -104578748;
        protected internal TLAbsInputGeoPoint geoPoint;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xab, 0x68 })]
        public TLInputMediaGeoPoint()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLInputMediaGeoPoint(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 11, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.geoPoint = StreamingUtils.readTLObject(stream, context);
        }

        public override int getClassId() => 
            -104578748;

        public virtual TLAbsInputGeoPoint getGeoPoint() => 
            this.geoPoint;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 6, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.geoPoint, stream);
        }

        public virtual void setGeoPoint(TLAbsInputGeoPoint value)
        {
            this.geoPoint = value;
        }

        public override string toString() => 
            "inputMediaGeoPoint#f9c44144";
    }
}

