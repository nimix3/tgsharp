﻿namespace org.telegram.api.messages.stickers.setintallresult
{
    using IKVM.Attributes;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public abstract class TLAbsMessagesStickerSetInstallResult : TLObject
    {
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9b, 0x68 })]
        public TLAbsMessagesStickerSetInstallResult()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAbsMessagesStickerSetInstallResult(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }
    }
}

