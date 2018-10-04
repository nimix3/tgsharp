namespace org.telegram.api.decryptedmessage
{
    using IKVM.Attributes;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public abstract class TLAbsDecryptedMessageMedia : TLObject
    {
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa3, 0x68 })]
        protected internal TLAbsDecryptedMessageMedia()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAbsDecryptedMessageMedia(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }
    }
}

