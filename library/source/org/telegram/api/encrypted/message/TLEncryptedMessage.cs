namespace org.telegram.api.encrypted.message
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLEncryptedMessage : TLAbsEncryptedMessage
    {
        public const int CLASS_ID = -317144808;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa6, 0x68 })]
        public TLEncryptedMessage()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLEncryptedMessage(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xbb, 0x6c, 0x6c, 0x6c, 0x6d, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            base.randomId = StreamingUtils.readLong(stream);
            base.chatId = StreamingUtils.readInt(stream);
            base.date = StreamingUtils.readInt(stream);
            base.bytes = StreamingUtils.readTLBytes(stream, context);
            base.file = StreamingUtils.readTLObject(stream, context);
        }

        public override int getClassId() => 
            -317144808;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb1, 0x6c, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeLong(base.randomId, stream);
            StreamingUtils.writeInt(base.chatId, stream);
            StreamingUtils.writeInt(base.date, stream);
            StreamingUtils.writeTLBytes(base.bytes, stream);
            StreamingUtils.writeTLObject(base.file, stream);
        }

        public override string toString() => 
            "encryptedMessage#ed18c118";
    }
}

