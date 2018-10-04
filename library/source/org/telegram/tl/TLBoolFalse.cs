namespace org.telegram.tl
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLBoolFalse : TLBool
    {
        public const int CLASS_ID = -1132882121;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(8)]
        public TLBoolFalse()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLBoolFalse(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            -1132882121;

        public override string toString() => 
            "boolFalse#bc799737";
    }
}

