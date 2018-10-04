namespace org.telegram.api.channel.filters
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLChannelMessagesFilterEmpty : TLAbsChannelMessagesFilter
    {
        public const int CLASS_ID = -1798033689;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9b, 0x68 })]
        public TLChannelMessagesFilterEmpty()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLChannelMessagesFilterEmpty(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            -1798033689;

        public override string toString() => 
            "channel.messages.filter.TLChannelMessagesFilterEmpty#94d42ee7";
    }
}

