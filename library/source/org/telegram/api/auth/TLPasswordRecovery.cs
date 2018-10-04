namespace org.telegram.api.auth
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLPasswordRecovery : TLObject
    {
        public const int CLASS_ID = 0x137948a5;
        private string emailPattern;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb2, 0x68 })]
        public TLPasswordRecovery()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLPasswordRecovery(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x13, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.emailPattern = StreamingUtils.readTLString(stream);
        }

        public override int getClassId() => 
            0x137948a5;

        public virtual string getEmailPattern() => 
            this.emailPattern;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 14, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLString(this.emailPattern, stream);
        }

        public virtual void setEmailPattern(string emailPattern)
        {
            this.emailPattern = emailPattern;
        }

        public override string toString() => 
            "auth.passwordrecovery#137948a5";
    }
}

