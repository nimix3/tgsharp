namespace org.telegram.api.user.profile.photo
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.api.file.location;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLUserProfilePhoto : TLAbsUserProfilePhoto
    {
        public const int CLASS_ID = -715532088;
        private TLAbsFileLocation photoBig;
        private long photoId;
        private TLAbsFileLocation photoSmall;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 170, 0x68 })]
        public TLUserProfilePhoto()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLUserProfilePhoto(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x30, 0x6c, 0x72, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.photoId = StreamingUtils.readLong(stream);
            this.photoSmall = StreamingUtils.readTLObject(stream, context);
            this.photoBig = StreamingUtils.readTLObject(stream, context);
        }

        public override int getClassId() => 
            -715532088;

        public virtual TLAbsFileLocation getPhotoBig() => 
            this.photoBig;

        public virtual long getPhotoId() => 
            this.photoId;

        public virtual TLAbsFileLocation getPhotoSmall() => 
            this.photoSmall;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x29, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeLong(this.photoId, stream);
            StreamingUtils.writeTLObject(this.photoSmall, stream);
            StreamingUtils.writeTLObject(this.photoBig, stream);
        }

        public virtual void setPhotoBig(TLAbsFileLocation photoBig)
        {
            this.photoBig = photoBig;
        }

        public virtual void setPhotoId(long photoId)
        {
            this.photoId = photoId;
        }

        public virtual void setPhotoSmall(TLAbsFileLocation photoSmall)
        {
            this.photoSmall = photoSmall;
        }

        public override string toString() => 
            "userProfilePhoto#d559d8c8";
    }
}

