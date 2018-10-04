namespace org.telegram.api.keyboard
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLKeyboardButtonRow : TLObject
    {
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/keyboard/button/TLAbsKeyboardButton;>;")]
        public TLVector buttons;
        public const int CLASS_ID = 0x77608b83;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa1, 0xa8 })]
        public TLKeyboardButtonRow()
        {
            this.buttons = new TLVector();
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLKeyboardButtonRow(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb2, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.buttons = StreamingUtils.readTLVector(stream, context);
        }

        public override int getClassId() => 
            0x77608b83;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xad, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLVector(this.buttons, stream);
        }

        public override string toString() => 
            "keyboard.KeyboardButtonRow#77608b83";
    }
}

