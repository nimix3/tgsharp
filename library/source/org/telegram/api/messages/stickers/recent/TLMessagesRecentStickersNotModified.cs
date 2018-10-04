namespace org.telegram.api.messages.stickers.recent
{
    using IKVM.Attributes;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLMessagesRecentStickersNotModified : TLObject
    {
        public const int CLASS_ID = 0xb17f890;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9d, 0x68 })]
        public TLMessagesRecentStickersNotModified()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLMessagesRecentStickersNotModified(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            0xb17f890;

        public override string toString() => 
            "messages.recentStickersNotModified#b17f890";
    }
}

