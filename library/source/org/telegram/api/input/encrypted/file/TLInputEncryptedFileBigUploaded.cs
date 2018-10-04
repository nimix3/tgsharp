namespace org.telegram.api.input.encrypted.file
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLInputEncryptedFileBigUploaded : TLAbsInputEncryptedFile
    {
        public const int CLASS_ID = 0x2dc173c8;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa5, 0x68 })]
        public TLInputEncryptedFileBigUploaded()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLInputEncryptedFileBigUploaded(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb5, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            base.id = StreamingUtils.readLong(stream);
            base.parts = StreamingUtils.readInt(stream);
            base.keyFingerprint = StreamingUtils.readInt(stream);
        }

        public override int getClassId() => 
            0x2dc173c8;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xae, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeLong(base.id, stream);
            StreamingUtils.writeInt(base.parts, stream);
            StreamingUtils.writeInt(base.keyFingerprint, stream);
        }

        public override string toString() => 
            "inputEncryptedFileBigUploaded#2dc173c8";
    }
}

