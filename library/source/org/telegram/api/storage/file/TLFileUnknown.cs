namespace org.telegram.api.storage.file
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLFileUnknown : TLAbsFileType
    {
        public const int CLASS_ID = -1432995067;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(6)]
        public TLFileUnknown()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLFileUnknown(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            -1432995067;

        public override string toString() => 
            "storage.fileUnknown#aa963b05";
    }
}

