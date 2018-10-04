namespace org.telegram.api.auth.codetype
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLCodeTypeFlashCall : TLAbsCodeType
    {
        public const int CLASS_ID = 0x226ccefb;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9b, 0x68 })]
        public TLCodeTypeFlashCall()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLCodeTypeFlashCall(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            0x226ccefb;

        public override string toString() => 
            "auth.codeTypeFlashCall#226ccefb";
    }
}

