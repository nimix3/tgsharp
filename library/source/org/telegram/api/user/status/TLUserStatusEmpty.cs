﻿namespace org.telegram.api.user.status
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLUserStatusEmpty : TLAbsUserStatus
    {
        public const int CLASS_ID = 0x9d05049;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9e, 0x68 })]
        public TLUserStatusEmpty()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLUserStatusEmpty(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            0x9d05049;

        public override string toString() => 
            "userStatusEmpty#9d05049";
    }
}

