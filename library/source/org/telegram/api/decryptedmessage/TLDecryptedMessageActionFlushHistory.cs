namespace org.telegram.api.decryptedmessage
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLDecryptedMessageActionFlushHistory : TLDecryptedMessageAction
    {
        public const int CLASS_ID = 0x6719e45c;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9d, 0x68 })]
        public TLDecryptedMessageActionFlushHistory()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLDecryptedMessageActionFlushHistory(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            0x6719e45c;

        public override string toString() => 
            "decryptedMessageActionFlushHistory#6719e45c";
    }
}

