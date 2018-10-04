namespace org.telegram.api.photo.size
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
    public class TLPhotoCachedSize : TLAbsPhotoSize
    {
        private TLBytes bytes;
        public const int CLASS_ID = -374917894;
        private int h;
        private TLAbsFileLocation location;
        private string type;
        private int w;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xac, 0x68 })]
        public TLPhotoCachedSize()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLPhotoCachedSize(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x58, 0x6c, 0x72, 0x6c, 0x6c, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.type = StreamingUtils.readTLString(stream);
            this.location = StreamingUtils.readTLObject(stream, context);
            this.w = StreamingUtils.readInt(stream);
            this.h = StreamingUtils.readInt(stream);
            this.bytes = StreamingUtils.readTLBytes(stream, context);
        }

        public virtual TLBytes getBytes() => 
            this.bytes;

        public override int getClassId() => 
            -374917894;

        public virtual int getH() => 
            this.h;

        public virtual TLAbsFileLocation getLocation() => 
            this.location;

        public virtual string getType() => 
            this.type;

        public virtual int getW() => 
            this.w;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x4f, 0x6c, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLString(this.type, stream);
            StreamingUtils.writeTLObject(this.location, stream);
            StreamingUtils.writeInt(this.w, stream);
            StreamingUtils.writeInt(this.h, stream);
            StreamingUtils.writeTLBytes(this.bytes, stream);
        }

        public virtual void setBytes(TLBytes bytes)
        {
            this.bytes = bytes;
        }

        public virtual void setH(int h)
        {
            this.h = h;
        }

        public virtual void setLocation(TLAbsFileLocation location)
        {
            this.location = location;
        }

        public virtual void setType(string type)
        {
            this.type = type;
        }

        public virtual void setW(int w)
        {
            this.w = w;
        }

        public override string toString() => 
            "photoCachedSize#e9a734fa";
    }
}

