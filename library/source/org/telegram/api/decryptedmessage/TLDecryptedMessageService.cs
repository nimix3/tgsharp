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
    public class TLDecryptedMessageService : TLAbsDecryptedMessage
    {
        private TLDecryptedMessageAction action;
        public const int CLASS_ID = 0x73164160;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb1, 0x68 })]
        public TLDecryptedMessageService()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLDecryptedMessageService(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x15, 0x6c, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            base.randomId = StreamingUtils.readLong(stream);
            this.action = StreamingUtils.readTLObject(stream, context);
        }

        public virtual TLDecryptedMessageAction getAction() => 
            this.action;

        public override int getClassId() => 
            0x73164160;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 14, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeLong(base.randomId, stream);
            StreamingUtils.writeTLObject(this.action, stream);
        }

        public virtual void setAction(TLDecryptedMessageAction action)
        {
            this.action = action;
        }

        public override string toString() => 
            "decryptedMessageService#73164160";
    }
}

