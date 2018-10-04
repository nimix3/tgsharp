namespace org.telegram.api.input.reportspamreason
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLReportSpamReasonOther : TLReportSpamReasonSpam
    {
        public const int CLASS_ID = -512463606;
        private string text;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x22)]
        public TLReportSpamReasonOther()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLReportSpamReasonOther(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 9, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.text = StreamingUtils.readTLString(stream);
        }

        public override int getClassId() => 
            -512463606;

        public virtual string getText() => 
            this.text;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 4, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLString(this.text, stream);
        }

        public virtual void setText(string text)
        {
            this.text = text;
        }

        public override string toString() => 
            "reportSpamReasonPornography#2e59d922";
    }
}

