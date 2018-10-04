namespace org.telegram.api.page.block
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLPageBlockUnsupported : TLAbsPageBlock
    {
        public const int CLASS_ID = 0x13567e8a;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x99, 0x68 })]
        public TLPageBlockUnsupported()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLPageBlockUnsupported(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            0x13567e8a;

        public override string toString() => 
            "pageBlockUnsupported#13567e8a";
    }
}

