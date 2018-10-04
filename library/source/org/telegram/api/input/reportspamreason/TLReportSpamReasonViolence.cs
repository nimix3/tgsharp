namespace org.telegram.api.input.reportspamreason
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLReportSpamReasonViolence : TLAbsReportSpamReason
    {
        public const int CLASS_ID = 0x1e22c78d;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x1c)]
        public TLReportSpamReasonViolence()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLReportSpamReasonViolence(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            0x1e22c78d;

        public override string toString() => 
            "reportSpamReasonViolence#1e22c78d";
    }
}

