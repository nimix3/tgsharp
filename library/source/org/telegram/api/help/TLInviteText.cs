namespace org.telegram.api.help
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLInviteText : TLObject
    {
        public const int CLASS_ID = 0x18cb9f78;
        private string message;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa8, 0x68 })]
        public TLInviteText()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLInviteText(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 8, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.message = StreamingUtils.readTLString(stream);
        }

        public override int getClassId() => 
            0x18cb9f78;

        public virtual string getMessage() => 
            this.message;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 3, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLString(this.message, stream);
        }

        public virtual void setMessage(string value)
        {
            this.message = value;
        }

        public override string toString() => 
            "help.inviteText#18cb9f78";
    }
}

