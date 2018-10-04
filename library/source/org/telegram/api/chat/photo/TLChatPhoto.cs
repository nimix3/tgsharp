namespace org.telegram.api.chat.photo
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
    public class TLChatPhoto : TLAbsChatPhoto
    {
        public const int CLASS_ID = 0x6153276a;
        private TLAbsFileLocation photo_big;
        private TLAbsFileLocation photo_small;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb3, 0x68 })]
        public TLChatPhoto()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLChatPhoto(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x26, 0x72, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.photo_small = StreamingUtils.readTLObject(stream, context);
            this.photo_big = StreamingUtils.readTLObject(stream, context);
        }

        public override int getClassId() => 
            0x6153276a;

        public virtual TLAbsFileLocation getPhoto_big() => 
            this.photo_big;

        public virtual TLAbsFileLocation getPhoto_small() => 
            this.photo_small;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x20, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.photo_small, stream);
            StreamingUtils.writeTLObject(this.photo_big, stream);
        }

        public virtual void setPhoto_big(TLAbsFileLocation photo_big)
        {
            this.photo_big = photo_big;
        }

        public virtual void setPhoto_small(TLAbsFileLocation photo_small)
        {
            this.photo_small = photo_small;
        }

        public override string toString() => 
            "chatPhoto#6153276a";
    }
}

