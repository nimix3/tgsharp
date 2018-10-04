namespace org.telegram.api.document.attribute
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLDocumentAttributeImageSize : TLAbsDocumentAttribute
    {
        public const int CLASS_ID = 0x6c37c15c;
        private int h;
        private int w;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb2, 0x68 })]
        public TLDocumentAttributeImageSize()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLDocumentAttributeImageSize(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 40, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.w = StreamingUtils.readInt(stream);
            this.h = StreamingUtils.readInt(stream);
        }

        public override int getClassId() => 
            0x6c37c15c;

        public virtual int getH() => 
            this.h;

        public virtual int getW() => 
            this.w;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x21, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.w, stream);
            StreamingUtils.writeInt(this.h, stream);
        }

        public virtual void setH(int h)
        {
            this.h = h;
        }

        public virtual void setW(int w)
        {
            this.w = w;
        }

        public override string toString() => 
            "documentAttributeImageSize#6c37c15c";
    }
}

