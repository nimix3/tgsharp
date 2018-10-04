namespace org.telegram.api.account
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLAccountPasswordSettings : TLObject
    {
        public const int CLASS_ID = -1212732749;
        private string email;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb3, 0x68 })]
        public TLAccountPasswordSettings()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAccountPasswordSettings(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x16, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.email = StreamingUtils.readTLString(stream);
        }

        public override int getClassId() => 
            -1212732749;

        public virtual string getEmail() => 
            this.email;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x10, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLString(this.email, stream);
        }

        public virtual void setEmail(string email)
        {
            this.email = email;
        }

        public override string toString() => 
            "accountPasswordSettings#b7b72ab3";
    }
}

