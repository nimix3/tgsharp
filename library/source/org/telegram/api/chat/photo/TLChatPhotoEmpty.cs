namespace org.telegram.api.chat.photo
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLChatPhotoEmpty : TLAbsChatPhoto
    {
        public const int CLASS_ID = 0x37c1011c;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa8, 0x68 })]
        public TLChatPhotoEmpty()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLChatPhotoEmpty(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            0x37c1011c;

        public override string toString() => 
            "chatPhotoEmpty#37c1011c";
    }
}

