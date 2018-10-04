namespace org.telegram.api.input.sticker.set
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLInputStickerSetEmpty : TLAbsInputStickerSet
    {
        public const int CLASS_ID = -4838507;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(9)]
        public TLInputStickerSetEmpty()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLInputStickerSetEmpty(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            -4838507;

        public override string toString() => 
            "sticker.set.inputStickerSetEmpty#ffb62b95";
    }
}

