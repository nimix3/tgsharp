namespace org.telegram.api.photo.size
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLPhotoSizeEmpty : TLAbsPhotoSize
    {
        public const int CLASS_ID = 0xe17e23c;
        private string type;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa6, 0x68 })]
        public TLPhotoSizeEmpty()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLPhotoSizeEmpty(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 9, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.type = StreamingUtils.readTLString(stream);
        }

        public override int getClassId() => 
            0xe17e23c;

        public virtual string getType() => 
            this.type;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 3, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLString(this.type, stream);
        }

        public virtual void setType(string type)
        {
            this.type = type;
        }

        public override string toString() => 
            "photoSizeEmpty#e17e23c";
    }
}

