namespace org.telegram.tl
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLBoolTrue : TLBool
    {
        public const int CLASS_ID = -1720552011;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(8)]
        public TLBoolTrue()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLBoolTrue(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            -1720552011;

        public override string toString() => 
            "boolTrue#997275b5";
    }
}

