namespace org.telegram.api.input.messages.filter
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLMessagesFilterEmpty : TLAbsMessagesFilter
    {
        public const int CLASS_ID = 0x57e2f66c;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(6)]
        public TLMessagesFilterEmpty()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLMessagesFilterEmpty(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            0x57e2f66c;

        public override string toString() => 
            "inputMessagesFilterEmpty#57e2f66c";
    }
}

