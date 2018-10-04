namespace org.telegram.api.input.encrypted.file
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLInputEncryptedFileEmpty : TLAbsInputEncryptedFile
    {
        public const int CLASS_ID = 0x1837c364;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9e, 0x68 })]
        public TLInputEncryptedFileEmpty()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLInputEncryptedFileEmpty(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            0x1837c364;

        public override string toString() => 
            "inputEncryptedFileEmpty#1837c364";
    }
}

