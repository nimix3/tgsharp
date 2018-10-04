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
    public class TLPhotoSize : TLAbsPhotoSize
    {
        public const int CLASS_ID = 0x77bfb61b;
        private int h;
        private TLAbsFileLocation location;
        private int size;
        private string type;
        private int w;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xac, 0x68 })]
        public TLPhotoSize()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLPhotoSize(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x5b, 0x6c, 0x72, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.type = StreamingUtils.readTLString(stream);
            this.location = StreamingUtils.readTLObject(stream, context);
            this.w = StreamingUtils.readInt(stream);
            this.h = StreamingUtils.readInt(stream);
            this.size = StreamingUtils.readInt(stream);
        }

        public override int getClassId() => 
            0x77bfb61b;

        public virtual int getH() => 
            this.h;

        public virtual TLAbsFileLocation getLocation() => 
            this.location;

        public virtual int getSize() => 
            this.size;

        public virtual string getType() => 
            this.type;

        public virtual int getW() => 
            this.w;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x51, 0x6c, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLString(this.type, stream);
            StreamingUtils.writeTLObject(this.location, stream);
            StreamingUtils.writeInt(this.w, stream);
            StreamingUtils.writeInt(this.h, stream);
            StreamingUtils.writeInt(this.size, stream);
        }

        public virtual void setH(int h)
        {
            this.h = h;
        }

        public virtual void setLocation(TLAbsFileLocation location)
        {
            this.location = location;
        }

        public virtual void setSize(int size)
        {
            this.size = size;
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
            "photoSize#77bfb61b";
    }
}

