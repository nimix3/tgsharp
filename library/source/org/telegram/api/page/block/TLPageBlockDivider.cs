namespace org.telegram.api.page.block
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLPageBlockDivider : TLAbsPageBlock
    {
        public const int CLASS_ID = -618614392;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x99, 0x68 })]
        public TLPageBlockDivider()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLPageBlockDivider(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            -618614392;

        public override string toString() => 
            "pageBlockDivider#db20b188";
    }
}

