namespace org.telegram.api.input.messages.filter
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLMessagesFilterVideo : TLAbsMessagesFilter
    {
        public const int CLASS_ID = -1614803355;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9e, 0x68 })]
        public TLMessagesFilterVideo()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLMessagesFilterVideo(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            -1614803355;

        public override string toString() => 
            "inputMessagesFilterVideo#9fc00e65";
    }
}

