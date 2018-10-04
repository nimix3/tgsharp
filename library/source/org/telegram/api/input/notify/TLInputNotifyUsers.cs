namespace org.telegram.api.input.notify
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLInputNotifyUsers : TLAbsInputNotifyPeer
    {
        public const int CLASS_ID = 0x193b4417;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9e, 0x68 })]
        public TLInputNotifyUsers()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLInputNotifyUsers(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            0x193b4417;

        public override string toString() => 
            "inputNotifyUsers#193b4417";
    }
}

