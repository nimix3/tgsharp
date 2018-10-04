namespace org.telegram.api.message.entity
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLMessageEntityHashtag : TLAbsMessageEntity
    {
        public const int CLASS_ID = 0x6f635b0d;
        private int length;
        private int offset;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa5, 0x68 })]
        public TLMessageEntityHashtag()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLMessageEntityHashtag(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 5, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.offset = StreamingUtils.readInt(stream);
            this.length = StreamingUtils.readInt(stream);
        }

        public override int getClassId() => 
            0x6f635b0d;

        public virtual int getLength() => 
            this.length;

        public virtual int getOffset() => 
            this.offset;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xbf, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.offset, stream);
            StreamingUtils.writeInt(this.length, stream);
        }

        public virtual void setLength(int length)
        {
            this.length = length;
        }

        public virtual void setOffset(int offset)
        {
            this.offset = offset;
        }

        public override string toString() => 
            "message.entity.MessageEntityHashtag#6f635b0d";
    }
}

