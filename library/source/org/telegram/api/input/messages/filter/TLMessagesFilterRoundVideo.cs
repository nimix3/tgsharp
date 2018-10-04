namespace org.telegram.api.input.messages.filter
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLMessagesFilterRoundVideo : TLAbsMessagesFilter
    {
        public const int CLASS_ID = -1253451181;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(6)]
        public TLMessagesFilterRoundVideo()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLMessagesFilterRoundVideo(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            -1253451181;

        public override string toString() => 
            "inputMessagesFilterRoundVideo#b549da53";
    }
}

