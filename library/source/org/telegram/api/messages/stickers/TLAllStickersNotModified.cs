namespace org.telegram.api.messages.stickers
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLAllStickersNotModified : TLAbsAllStickers
    {
        public const int CLASS_ID = -395967805;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa9, 0x68 })]
        public TLAllStickersNotModified()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAllStickersNotModified(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            -395967805;

        public override string toString() => 
            "allStickersNotModified#e86602c3";
    }
}

