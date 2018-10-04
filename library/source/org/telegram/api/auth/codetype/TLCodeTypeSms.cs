namespace org.telegram.api.auth.codetype
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLCodeTypeSms : TLAbsCodeType
    {
        public const int CLASS_ID = 0x72a3158c;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9b, 0x68 })]
        public TLCodeTypeSms()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLCodeTypeSms(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            0x72a3158c;

        public override string toString() => 
            "auth.codeTypeSms#72a3158c";
    }
}

