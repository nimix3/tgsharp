namespace org.telegram.api.input.reportspamreason
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLReportSpamReasonPornography : TLAbsReportSpamReason
    {
        public const int CLASS_ID = 0x2e59d922;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x1c)]
        public TLReportSpamReasonPornography()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLReportSpamReasonPornography(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            0x2e59d922;

        public override string toString() => 
            "reportSpamReasonPornography#2e59d922";
    }
}

