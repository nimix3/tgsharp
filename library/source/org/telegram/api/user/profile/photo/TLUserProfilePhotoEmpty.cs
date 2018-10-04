namespace org.telegram.api.user.profile.photo
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLUserProfilePhotoEmpty : TLAbsUserProfilePhoto
    {
        public const int CLASS_ID = 0x4f11bae1;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9e, 0x68 })]
        public TLUserProfilePhotoEmpty()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLUserProfilePhotoEmpty(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            0x4f11bae1;

        public override string toString() => 
            "userProfilePhotoEmpty#4f11bae1";
    }
}

