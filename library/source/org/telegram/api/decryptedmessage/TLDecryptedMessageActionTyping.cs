namespace org.telegram.api.decryptedmessage
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.api.sendmessage.action;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLDecryptedMessageActionTyping : TLDecryptedMessageAction
    {
        private TLAbsSendMessageAction action;
        public const int CLASS_ID = 0xc4f40be;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa7, 0x68 })]
        public TLDecryptedMessageActionTyping()
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xaf, 0x68, 0x67 })]
        public TLDecryptedMessageActionTyping(TLAbsSendMessageAction action)
        {
            this.action = action;
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLDecryptedMessageActionTyping(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x10, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.action = StreamingUtils.readTLObject(stream, context);
        }

        public virtual TLAbsSendMessageAction getAction() => 
            this.action;

        public override int getClassId() => 
            0xc4f40be;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 11, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.action, stream);
        }

        public virtual void setAction(TLAbsSendMessageAction action)
        {
            this.action = action;
        }

        public override string toString() => 
            "decryptedMessageActionSetMessageTTL#c4f40be";
    }
}

