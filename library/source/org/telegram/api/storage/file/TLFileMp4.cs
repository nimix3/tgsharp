namespace org.telegram.api.storage.file
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLFileMp4 : TLAbsFileType
    {
        public const int CLASS_ID = -1278304028;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(6)]
        public TLFileMp4()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLFileMp4(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            -1278304028;

        public override string toString() => 
            "storage.fileMp4#b3cea0e4";
    }
}

