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
    public class TLCheckedPhone : TLObject
    {
        public const int CLASS_ID = -2128698738;
        private bool phoneRegistered;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb2, 0x68 })]
        public TLCheckedPhone()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLCheckedPhone(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x10, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.phoneRegistered = StreamingUtils.readTLBool(stream);
        }

        public override int getClassId() => 
            -2128698738;

        public virtual bool isPhoneRegistered() => 
            this.phoneRegistered;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 12, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLBool(this.phoneRegistered, stream);
        }

        public virtual void setPhoneRegistered(bool phoneRegistered)
        {
            int num = (int) phoneRegistered;
            this.phoneRegistered = (bool) num;
        }

        public override string toString() => 
            "auth.checkedPhone#811ea28e";
    }
}

