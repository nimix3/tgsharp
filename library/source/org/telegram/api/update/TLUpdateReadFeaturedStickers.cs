namespace org.telegram.api.update
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLUpdateReadFeaturedStickers : TLAbsUpdate
    {
        public const int CLASS_ID = 0x571d2742;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9e, 0x68 })]
        public TLUpdateReadFeaturedStickers()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLUpdateReadFeaturedStickers(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            0x571d2742;

        public override string toString() => 
            "updateReadFeaturedStickers#571d2742";
    }
}

