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
    public class TLMessageMediaGeo : TLAbsMessageMedia
    {
        public const int CLASS_ID = 0x56e0d474;
        private TLAbsGeoPoint geo;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa7, 0x68 })]
        public TLMessageMediaGeo()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLMessageMediaGeo(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 10, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.geo = StreamingUtils.readTLObject(stream, context);
        }

        public override int getClassId() => 
            0x56e0d474;

        public virtual TLAbsGeoPoint getGeo() => 
            this.geo;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 4, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.geo, stream);
        }

        public virtual void setGeo(TLAbsGeoPoint geo)
        {
            this.geo = geo;
        }

        public override string toString() => 
            "messageMediaGeo#56e0d474";
    }
}

