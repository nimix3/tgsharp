namespace org.telegram.api.input.messages.filter
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLMessagesFilterPhotoVideo : TLAbsMessagesFilter
    {
        public const int CLASS_ID = 0x56e9f0e4;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(6)]
        public TLMessagesFilterPhotoVideo()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLMessagesFilterPhotoVideo(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            0x56e9f0e4;

        public override string toString() => 
            "inputMessagesFilterPhotoVideo#56e9f0e4";
    }
}

