namespace org.telegram.api.input.reportspamreason
{
    using IKVM.Attributes;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public abstract class TLAbsReportSpamReason : TLObject
    {
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x1c)]
        public TLAbsReportSpamReason()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAbsReportSpamReason(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }
    }
}

