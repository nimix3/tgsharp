namespace org.telegram.api.storage.file
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLFileJpeg : TLAbsFileType
    {
        public const int CLASS_ID = 0x7efe0e;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(6)]
        public TLFileJpeg()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLFileJpeg(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            0x7efe0e;

        public override string toString() => 
            "storage.fileJpeg#7efe0e";
    }
}

