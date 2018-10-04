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
    public class TLMessageEntityTextUrl : TLAbsMessageEntity
    {
        public const int CLASS_ID = 0x76a6d327;
        private int length;
        private int offset;
        private string url;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa7, 0x68 })]
        public TLMessageEntityTextUrl()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLMessageEntityTextUrl(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x10, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.offset = StreamingUtils.readInt(stream);
            this.length = StreamingUtils.readInt(stream);
            this.url = StreamingUtils.readTLString(stream);
        }

        public override int getClassId() => 
            0x76a6d327;

        public virtual int getLength() => 
            this.length;

        public virtual int getOffset() => 
            this.offset;

        public virtual string getUrl() => 
            this.url;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 9, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.offset, stream);
            StreamingUtils.writeInt(this.length, stream);
            StreamingUtils.writeTLString(this.url, stream);
        }

        public virtual void setLength(int length)
        {
            this.length = length;
        }

        public virtual void setOffset(int offset)
        {
            this.offset = offset;
        }

        public virtual void setUrl(string url)
        {
            this.url = url;
        }

        public override string toString() => 
            "message.entity.MessageEntityTextUrl#76a6d327";
    }
}

