namespace org.telegram.api.input.messages.filter
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLMessagesFilterPhotoVideoDocuments : TLAbsMessagesFilter
    {
        public const int CLASS_ID = -648121413;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9e, 0x68 })]
        public TLMessagesFilterPhotoVideoDocuments()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLMessagesFilterPhotoVideoDocuments(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            -648121413;

        public override string toString() => 
            "inputMessagesFilterPhotoVideo#d95e73bb";
    }
}

