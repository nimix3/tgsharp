namespace org.telegram.api.toppeer.category
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLTopPeerCategoryBotsInline : TLAbsTopPeerCategory
    {
        public const int CLASS_ID = 0x148677e2;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9b, 0x68 })]
        public TLTopPeerCategoryBotsInline()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLTopPeerCategoryBotsInline(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            0x148677e2;

        public override string toString() => 
            "topPeerCategoryBotsInline#148677e2";
    }
}

