namespace org.telegram.api.help
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLNoAppUpdate : TLAbsAppUpdate
    {
        public const int CLASS_ID = -1000708810;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9e, 0x68 })]
        public TLNoAppUpdate()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLNoAppUpdate(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            -1000708810;

        public override string toString() => 
            "help.noAppUpdate#c45a6536";
    }
}

