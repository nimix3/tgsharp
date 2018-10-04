namespace org.telegram.api.keyboard.button
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLKeyboardButtonCallback : TLAbsKeyboardButton
    {
        public const int CLASS_ID = 0x683a5e46;
        private TLBytes data;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa5, 0x68 })]
        public TLKeyboardButtonCallback()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLKeyboardButtonCallback(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb9, 0x6c, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            base.text = StreamingUtils.readTLString(stream);
            this.data = StreamingUtils.readTLBytes(stream, context);
        }

        public override int getClassId() => 
            0x683a5e46;

        public virtual TLBytes getData() => 
            this.data;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb3, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLString(base.text, stream);
            StreamingUtils.writeTLBytes(this.data, stream);
        }

        public override string toString() => 
            "keyboardButtonCallback#683a5e46";
    }
}

