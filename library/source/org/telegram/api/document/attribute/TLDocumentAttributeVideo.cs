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
    public class TLDocumentAttributeVideo : TLAbsDocumentAttribute
    {
        public const int CLASS_ID = 0xef02ce6;
        private int duration;
        private const int FLAG_ROUND_MESSAGE = 1;
        private int flags;
        private int h;
        private int w;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb2, 0x68 })]
        public TLDocumentAttributeVideo()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLDocumentAttributeVideo(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x2a, 0x6c, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.duration = StreamingUtils.readInt(stream);
            this.w = StreamingUtils.readInt(stream);
            this.h = StreamingUtils.readInt(stream);
        }

        public override int getClassId() => 
            0xef02ce6;

        public virtual int getDuration() => 
            this.duration;

        public virtual int getH() => 
            this.h;

        public virtual int getW() => 
            this.w;

        public virtual bool isRoundMessage() => 
            ((this.flags & 1) != 0);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x21, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeInt(this.duration, stream);
            StreamingUtils.writeInt(this.w, stream);
            StreamingUtils.writeInt(this.h, stream);
        }

        public virtual void setDuration(int duration)
        {
            this.duration = duration;
        }

        public virtual void setH(int h)
        {
            this.h = h;
        }

        [LineNumberTable(new byte[] { 0x9f, 0x7c, 0x62, 0x63, 0x90, 0x8f })]
        public virtual void setRoundMessage(bool enabled)
        {
            if (enabled)
            {
                this.flags |= 1;
            }
            else
            {
                this.flags &= -2;
            }
        }

        public virtual void setW(int w)
        {
            this.w = w;
        }

        public override string toString() => 
            "documentAttributeVideo#ef02ce6";
    }
}

