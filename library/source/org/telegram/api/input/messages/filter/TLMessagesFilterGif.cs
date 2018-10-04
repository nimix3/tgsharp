namespace org.telegram.api.input.messages.filter
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLMessagesFilterGif : TLAbsMessagesFilter
    {
        public const int CLASS_ID = -3644025;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xaf, 0x68 })]
        public TLMessagesFilterGif()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLMessagesFilterGif(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            -3644025;

        public override string toString() => 
            "inputMessagesFilterGif#ffc86587";
    }
}

