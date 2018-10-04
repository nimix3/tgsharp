namespace org.telegram.api.geo.point
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLGeoPointEmpty : TLAbsGeoPoint
    {
        public const int CLASS_ID = 0x1117dd5f;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9e, 0x68 })]
        public TLGeoPointEmpty()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLGeoPointEmpty(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            0x1117dd5f;

        public override string toString() => 
            "geoPointEmpty#1117dd5f";
    }
}

