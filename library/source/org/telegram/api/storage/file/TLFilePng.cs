namespace org.telegram.api.storage.file
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLFilePng : TLAbsFileType
    {
        public const int CLASS_ID = 0xa4f63c0;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(6)]
        public TLFilePng()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLFilePng(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            0xa4f63c0;

        public override string toString() => 
            "storage.filePng#a4f63c0";
    }
}

