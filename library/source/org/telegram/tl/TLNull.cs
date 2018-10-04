namespace org.telegram.tl
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLNull : TLObject
    {
        public const int CLASS_ID = 0x56730bcc;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x10)]
        public TLNull()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLNull(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            0x56730bcc;

        public override string toString() => 
            "null#56730bcc";
    }
}

