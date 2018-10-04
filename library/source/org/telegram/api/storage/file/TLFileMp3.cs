namespace org.telegram.api.storage.file
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLFileMp3 : TLAbsFileType
    {
        public const int CLASS_ID = 0x528a0677;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(6)]
        public TLFileMp3()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLFileMp3(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            0x528a0677;

        public override string toString() => 
            "storage.fileMp3#528a0677";
    }
}

