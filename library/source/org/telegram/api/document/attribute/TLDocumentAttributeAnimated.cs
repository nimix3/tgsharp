namespace org.telegram.api.document.attribute
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLDocumentAttributeAnimated : TLAbsDocumentAttribute
    {
        public const int CLASS_ID = 0x11b58939;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa8, 0x68 })]
        public TLDocumentAttributeAnimated()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLDocumentAttributeAnimated(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            0x11b58939;

        public override string toString() => 
            "documentAttributeAnimated#11b58939";
    }
}

