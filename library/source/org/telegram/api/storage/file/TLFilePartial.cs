namespace org.telegram.api.storage.file
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLFilePartial : TLAbsFileType
    {
        public const int CLASS_ID = 0x40bc6f52;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(6)]
        public TLFilePartial()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLFilePartial(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            0x40bc6f52;

        public override string toString() => 
            "storage.filePartial#40bc6f52";
    }
}

