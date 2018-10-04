namespace org.telegram.api.storage.file
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLFileMov : TLAbsFileType
    {
        public const int CLASS_ID = 0x4b09ebbc;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(6)]
        public TLFileMov()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLFileMov(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            0x4b09ebbc;

        public override string toString() => 
            "storage.fileMov#4b09ebbc";
    }
}

