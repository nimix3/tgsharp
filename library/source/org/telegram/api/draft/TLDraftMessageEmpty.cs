namespace org.telegram.api.draft
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLDraftMessageEmpty : TLAbsDraftMessage
    {
        public const int CLASS_ID = -1169445179;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(9)]
        public TLDraftMessageEmpty()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLDraftMessageEmpty(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            -1169445179;

        public override string toString() => 
            "draftMessageEmpty#ba4baec5";
    }
}

