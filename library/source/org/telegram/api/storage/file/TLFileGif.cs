namespace org.telegram.api.storage.file
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLFileGif : TLAbsFileType
    {
        public const int CLASS_ID = -891180321;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(6)]
        public TLFileGif()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLFileGif(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            -891180321;

        public override string toString() => 
            "storage.fileGif#cae1aadf";
    }
}

