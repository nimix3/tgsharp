namespace org.telegram.tl
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLTrue : TLObject
    {
        public const int CLASS_ID = 0x3fedd339;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x1a)]
        public TLTrue()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLTrue(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            0x3fedd339;

        public override string toString() => 
            "TLTrue";
    }
}

