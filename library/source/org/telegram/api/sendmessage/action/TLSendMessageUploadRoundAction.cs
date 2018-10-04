namespace org.telegram.api.sendmessage.action
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLSendMessageUploadRoundAction : TLAbsSendMessageAction
    {
        public const int CLASS_ID = 0x243e1c66;
        private int progress;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 170, 0x68 })]
        public TLSendMessageUploadRoundAction()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLSendMessageUploadRoundAction(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 2, 0x68, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            base.deserializeBody(stream, context);
            this.progress = StreamingUtils.readInt(stream);
        }

        public override int getClassId() => 
            0x243e1c66;

        public virtual int getProgress() => 
            this.progress;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xbc, 0x67, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            base.serializeBody(stream);
            StreamingUtils.writeInt(this.progress, stream);
        }

        public virtual void setProgress(int progress)
        {
            this.progress = progress;
        }

        public override string toString() => 
            "sendMessageUploadRoundAction#243e1c66";
    }
}

