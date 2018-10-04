namespace org.telegram.api.photos
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.api.photo;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLPhotosPhoto : TLObject
    {
        public const int CLASS_ID = 0x20212ca8;
        protected internal TLAbsPhoto photo;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLAbsUser;>;")]
        protected internal TLVector users;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xbd, 0x68 })]
        public TLPhotosPhoto()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLPhotosPhoto(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 13, 0x72, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.photo = StreamingUtils.readTLObject(stream, context);
            this.users = StreamingUtils.readTLVector(stream, context);
        }

        public override int getClassId() => 
            0x20212ca8;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 7, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.photo, stream);
            StreamingUtils.writeTLVector(this.users, stream);
        }

        public override string toString() => 
            "photos.photos#20212ca8";
    }
}

