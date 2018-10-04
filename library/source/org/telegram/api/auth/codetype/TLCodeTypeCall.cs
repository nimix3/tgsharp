namespace org.telegram.api.auth.codetype
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLCodeTypeCall : TLAbsCodeType
    {
        public const int CLASS_ID = 0x741cd3e3;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9b, 0x68 })]
        public TLCodeTypeCall()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLCodeTypeCall(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            0x741cd3e3;

        public override string toString() => 
            "auth.codeTypeCall#741cd3e3";
    }
}

