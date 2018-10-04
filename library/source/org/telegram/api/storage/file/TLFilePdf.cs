namespace org.telegram.api.storage.file
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLFilePdf : TLAbsFileType
    {
        public const int CLASS_ID = -1373745011;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(6)]
        public TLFilePdf()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLFilePdf(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            -1373745011;

        public override string toString() => 
            "storage.filePdf#ae1e508d";
    }
}

