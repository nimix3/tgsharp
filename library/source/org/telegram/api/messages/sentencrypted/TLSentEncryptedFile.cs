namespace org.telegram.api.messages.sentencrypted
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLSentEncryptedFile : TLAbsSentEncryptedMessage
    {
        public const int CLASS_ID = -1802240206;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa6, 0x68 })]
        public TLSentEncryptedFile()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLSentEncryptedFile(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb8, 0x6c, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            base.date = StreamingUtils.readInt(stream);
            base.file = StreamingUtils.readTLObject(stream, context);
        }

        public override int getClassId() => 
            -1802240206;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb1, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(base.date, stream);
            StreamingUtils.writeTLObject(base.file, stream);
        }

        public override string toString() => 
            "messages.sentEncryptedFile#9493ff32";
    }
}

