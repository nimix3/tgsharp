namespace org.telegram.api.decryptedmessage
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLDecryptedMessageActionNoop : TLDecryptedMessageAction
    {
        public const int CLASS_ID = -1473258141;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9d, 0x68 })]
        public TLDecryptedMessageActionNoop()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLDecryptedMessageActionNoop(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            -1473258141;

        public override string toString() => 
            "decryptedMessageActionNoop#a82fdd63";
    }
}

