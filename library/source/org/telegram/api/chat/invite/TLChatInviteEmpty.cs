namespace org.telegram.api.chat.invite
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLChatInviteEmpty : TLAbsChatInvite
    {
        public const int CLASS_ID = 0x69df3769;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa8, 0x68 })]
        public TLChatInviteEmpty()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLChatInviteEmpty(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            0x69df3769;

        public override string toString() => 
            "chat.chatInviteEmpty#69df3769";
    }
}

