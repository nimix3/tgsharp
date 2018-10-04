namespace org.telegram.api.toppeer.category
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLTopPeerCategoryBotsPM : TLAbsTopPeerCategory
    {
        public const int CLASS_ID = -1419371685;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9b, 0x68 })]
        public TLTopPeerCategoryBotsPM()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLTopPeerCategoryBotsPM(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            -1419371685;

        public override string toString() => 
            "topPeerCategoryBotsPM#ab661b5b";
    }
}

