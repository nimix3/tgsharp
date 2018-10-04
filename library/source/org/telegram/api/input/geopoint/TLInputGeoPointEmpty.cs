namespace org.telegram.api.input.geopoint
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLInputGeoPointEmpty : TLAbsInputGeoPoint
    {
        public const int CLASS_ID = -457104426;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9e, 0x68 })]
        public TLInputGeoPointEmpty()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLInputGeoPointEmpty(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            -457104426;

        public override string toString() => 
            "inputGeoPointEmpty#e4c123d6";
    }
}

