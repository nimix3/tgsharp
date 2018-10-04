namespace org.telegram.api.encrypted.file
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLEncryptedFileEmpty : TLAbsEncryptedFile
    {
        public const int CLASS_ID = -1038136962;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa8, 0x68 })]
        public TLEncryptedFileEmpty()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLEncryptedFileEmpty(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            -1038136962;

        public override string toString() => 
            "encryptedFileEmpty#c21f497e";
    }
}

