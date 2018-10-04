namespace org.telegram.api.input.document
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLInputDocumentEmpty : TLAbsInputDocument
    {
        public const int CLASS_ID = 0x72f0eaae;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9e, 0x68 })]
        public TLInputDocumentEmpty()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLInputDocumentEmpty(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            0x72f0eaae;

        public override string toString() => 
            "inputDocumentEmpty#72f0eaae";
    }
}

