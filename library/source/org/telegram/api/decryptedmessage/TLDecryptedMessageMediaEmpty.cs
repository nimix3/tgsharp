namespace org.telegram.api.decryptedmessage
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLDecryptedMessageMediaEmpty : TLAbsDecryptedMessageMedia
    {
        public const int CLASS_ID = 0x89f5c4a;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa8, 0x68 })]
        public TLDecryptedMessageMediaEmpty()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLDecryptedMessageMediaEmpty(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            0x89f5c4a;

        public override string toString() => 
            "decryptedMessageMediaEmpty#89f5c4a";
    }
}

