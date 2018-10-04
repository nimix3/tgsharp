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
    public class TLSentEncryptedMessage : TLAbsSentEncryptedMessage
    {
        public const int CLASS_ID = 0x560f8935;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa5, 0x68 })]
        public TLSentEncryptedMessage()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLSentEncryptedMessage(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb3, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            base.date = StreamingUtils.readInt(stream);
        }

        public override int getClassId() => 
            0x560f8935;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xae, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(base.date, stream);
        }

        public override string toString() => 
            "messages.sentEncryptedMessage#560f8935";
    }
}

