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
    public class TLEncryptedMessageService : TLAbsEncryptedMessage
    {
        public const int CLASS_ID = 0x23734b06;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa5, 0x68 })]
        public TLEncryptedMessageService()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLEncryptedMessageService(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb9, 0x6c, 0x6c, 0x6c, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            base.randomId = StreamingUtils.readLong(stream);
            base.chatId = StreamingUtils.readInt(stream);
            base.date = StreamingUtils.readInt(stream);
            base.bytes = StreamingUtils.readTLBytes(stream, context);
        }

        public override int getClassId() => 
            0x23734b06;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb0, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeLong(base.randomId, stream);
            StreamingUtils.writeInt(base.chatId, stream);
            StreamingUtils.writeInt(base.date, stream);
            StreamingUtils.writeTLBytes(base.bytes, stream);
        }

        public override string toString() => 
            "encryptedMessageService#23734b06";
    }
}

