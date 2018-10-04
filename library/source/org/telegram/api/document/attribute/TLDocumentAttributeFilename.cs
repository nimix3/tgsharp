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
    public class TLDocumentAttributeFilename : TLAbsDocumentAttribute
    {
        public const int CLASS_ID = 0x15590068;
        private string fileName;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb1, 0x68 })]
        public TLDocumentAttributeFilename()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLDocumentAttributeFilename(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 20, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.fileName = StreamingUtils.readTLString(stream);
        }

        public override int getClassId() => 
            0x15590068;

        public virtual string getFileName() => 
            this.fileName;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 14, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLString(this.fileName, stream);
        }

        public virtual void setFileName(string fileName)
        {
            this.fileName = fileName;
        }

        public override string toString() => 
            "documentAttributeFilename#15590068";
    }
}

