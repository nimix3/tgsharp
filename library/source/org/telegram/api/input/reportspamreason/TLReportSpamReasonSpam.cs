namespace org.telegram.api.input.reportspamreason
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLReportSpamReasonSpam : TLAbsReportSpamReason
    {
        public const int CLASS_ID = 0x58dbcab8;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x1c)]
        public TLReportSpamReasonSpam()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLReportSpamReasonSpam(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            0x58dbcab8;

        public override string toString() => 
            "reportSpamReasonSpam#58dbcab8";
    }
}

