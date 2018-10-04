namespace org.telegram.api.decryptedmessage
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLDecryptedMessageLayer : TLObject
    {
        public const int CLASS_ID = 0x1be31789;
        public int inSeqNo;
        public int layer;
        public TLAbsDecryptedMessage message;
        public int outSeqNo;
        public TLBytes randomBytes;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xbc, 0x68 })]
        public TLDecryptedMessageLayer()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLDecryptedMessageLayer(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x11, 0x6d, 0x6c, 0x6c, 0x6c, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.randomBytes = StreamingUtils.readTLBytes(stream, context);
            this.layer = StreamingUtils.readInt(stream);
            this.inSeqNo = StreamingUtils.readInt(stream);
            this.outSeqNo = StreamingUtils.readInt(stream);
            this.message = StreamingUtils.readTLObject(stream, context);
        }

        public override int getClassId() => 
            0x1be31789;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 7, 0x6c, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLBytes(this.randomBytes, stream);
            StreamingUtils.writeInt(this.layer, stream);
            StreamingUtils.writeInt(this.inSeqNo, stream);
            StreamingUtils.writeInt(this.outSeqNo, stream);
            StreamingUtils.writeTLObject(this.message, stream);
        }

        public override string toString() => 
            "decryptedMessageLayer#1be31789";
    }
}

