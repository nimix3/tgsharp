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
    public class TLDecryptedMessageActionReadMessages : TLDecryptedMessageAction
    {
        public const int CLASS_ID = 0xc4f40be;
        private TLLongVector randomIds;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa8, 0xe8, 0x3a, 0xeb, 0x47 })]
        public TLDecryptedMessageActionReadMessages()
        {
            this.randomIds = new TLLongVector();
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLDecryptedMessageActionReadMessages(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 8, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.randomIds = StreamingUtils.readTLLongVector(stream, context);
        }

        public override int getClassId() => 
            0xc4f40be;

        public virtual TLLongVector getRandomIds() => 
            this.randomIds;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 3, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLVector(this.randomIds, stream);
        }

        public virtual void setRandomIds(TLLongVector randomIds)
        {
            this.randomIds = randomIds;
        }

        public override string toString() => 
            "decryptedMessageActionSetMessageTTL#c4f40be";
    }
}

