namespace org.telegram.api.help
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.api.user;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLSupport : TLObject
    {
        public const int CLASS_ID = 0x17c6b5f6;
        private string phoneNumber;
        private TLAbsUser user;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 170, 0x68 })]
        public TLSupport()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLSupport(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x1d, 0x6c, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.phoneNumber = StreamingUtils.readTLString(stream);
            this.user = StreamingUtils.readTLObject(stream, context);
        }

        public override int getClassId() => 
            0x17c6b5f6;

        public virtual string getPhoneNumber() => 
            this.phoneNumber;

        public virtual TLAbsUser getUser() => 
            this.user;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x17, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLString(this.phoneNumber, stream);
            StreamingUtils.writeTLObject(this.user, stream);
        }

        public virtual void setPhoneNumber(string value)
        {
            this.phoneNumber = value;
        }

        public virtual void setUser(TLAbsUser value)
        {
            this.user = value;
        }

        public override string toString() => 
            "help.support#17c6b5f6";
    }
}

