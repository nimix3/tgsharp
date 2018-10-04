namespace org.telegram.api.bot
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLInlineBotSwitchPm : TLObject
    {
        public const int CLASS_ID = 0x3c20629f;
        private string startParam;
        private string text;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa6, 0x68 })]
        public TLInlineBotSwitchPm()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLInlineBotSwitchPm(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 190, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.text = StreamingUtils.readTLString(stream);
            this.startParam = StreamingUtils.readTLString(stream);
        }

        public override int getClassId() => 
            0x3c20629f;

        public virtual string getStartParam() => 
            this.startParam;

        public virtual string getText() => 
            this.text;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb8, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLString(this.text, stream);
            StreamingUtils.writeTLString(this.startParam, stream);
        }

        public override string toString() => 
            "inlineBotSwitchPM#3c20629f";
    }
}

