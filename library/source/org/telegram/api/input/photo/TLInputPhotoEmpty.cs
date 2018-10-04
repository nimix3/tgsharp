namespace org.telegram.api.input.photo
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLInputPhotoEmpty : TLAbsInputPhoto
    {
        public const int CLASS_ID = 0x1cd7bf0d;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9e, 0x68 })]
        public TLInputPhotoEmpty()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLInputPhotoEmpty(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            0x1cd7bf0d;

        public override string toString() => 
            "inputPhotoEmpty#1cd7bf0d";
    }
}

