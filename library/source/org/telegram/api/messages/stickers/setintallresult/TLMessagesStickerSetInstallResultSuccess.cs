namespace org.telegram.api.messages.stickers.setintallresult
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLMessagesStickerSetInstallResultSuccess : TLAbsMessagesStickerSetInstallResult
    {
        public const int CLASS_ID = 0x38641628;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9b, 0x68 })]
        public TLMessagesStickerSetInstallResultSuccess()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLMessagesStickerSetInstallResultSuccess(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            0x38641628;

        public override string toString() => 
            "messages.stickerSetInstallResultSuccess#38641628";
    }
}

