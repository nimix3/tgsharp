namespace org.telegram.api.message
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLExportedMessageLink : TLObject
    {
        public const int CLASS_ID = 0x1f486803;
        private string link;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa5, 0x68 })]
        public TLExportedMessageLink()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLExportedMessageLink(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xbc, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.link = StreamingUtils.readTLString(stream);
        }

        public override int getClassId() => 
            0x1f486803;

        public virtual string getLink() => 
            this.link;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb7, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLString(this.link, stream);
        }

        public virtual void setLink(string link)
        {
            this.link = link;
        }

        public override string toString() => 
            "message.exportedMessageLink#1f486803";
    }
}

