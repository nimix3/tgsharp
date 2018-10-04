namespace org.telegram.api.toppeer.category
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLTopPeerCategoryChannels : TLAbsTopPeerCategory
    {
        public const int CLASS_ID = 0x161d9628;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9b, 0x68 })]
        public TLTopPeerCategoryChannels()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLTopPeerCategoryChannels(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            0x161d9628;

        public override string toString() => 
            "topPeerCategoryChannels#161d9628";
    }
}

