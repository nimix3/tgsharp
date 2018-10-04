namespace org.telegram.api.toppeer.category
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLTopPeerCategoryGroups : TLAbsTopPeerCategory
    {
        public const int CLASS_ID = -1122524854;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9b, 0x68 })]
        public TLTopPeerCategoryGroups()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLTopPeerCategoryGroups(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            -1122524854;

        public override string toString() => 
            "topPeerCategoryGroups#bd17a14a";
    }
}

