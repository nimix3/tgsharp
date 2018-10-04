namespace org.telegram.api.storage.file
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLFileWebp : TLAbsFileType
    {
        public const int CLASS_ID = 0x1081464c;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(6)]
        public TLFileWebp()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLFileWebp(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            0x1081464c;

        public override string toString() => 
            "storage.fileWebp#1081464c";
    }
}

