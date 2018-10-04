namespace org.telegram.api.toppeer.category
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLTopPeerCategoryCorrespondents : TLAbsTopPeerCategory
    {
        public const int CLASS_ID = 0x637b7ed;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9b, 0x68 })]
        public TLTopPeerCategoryCorrespondents()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLTopPeerCategoryCorrespondents(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            0x637b7ed;

        public override string toString() => 
            "topPeerCategoryCorrespondents#637b7ed";
    }
}

