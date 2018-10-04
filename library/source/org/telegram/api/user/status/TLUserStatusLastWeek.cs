namespace org.telegram.api.user.status
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLUserStatusLastWeek : TLAbsUserStatus
    {
        public const int CLASS_ID = 0x7bf09fc;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9e, 0x68 })]
        public TLUserStatusLastWeek()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLUserStatusLastWeek(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            0x7bf09fc;

        public override string toString() => 
            "userStatusLastWeek#7bf09fc";
    }
}

