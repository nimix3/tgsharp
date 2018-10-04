namespace org.telegram.api.messages.stickers.featured
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLMessagesFeaturedStickersNotModified : TLAbsMessagesFeaturedStickers
    {
        public const int CLASS_ID = 0x4ede3cf;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9b, 0x68 })]
        public TLMessagesFeaturedStickersNotModified()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLMessagesFeaturedStickersNotModified(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            0x4ede3cf;

        public override string toString() => 
            "messages.featuredStickersNotModified#4ede3cf";
    }
}

