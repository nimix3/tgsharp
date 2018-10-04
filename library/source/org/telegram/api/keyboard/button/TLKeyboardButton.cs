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
    public class TLKeyboardButton : TLAbsKeyboardButton
    {
        public const int CLASS_ID = -1560655744;
        private string text;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa4, 0x68 })]
        public TLKeyboardButton()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLKeyboardButton(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xbb, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.text = StreamingUtils.readTLString(stream);
        }

        public override int getClassId() => 
            -1560655744;

        public override string getText() => 
            this.text;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb6, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLString(this.text, stream);
        }

        public virtual void setText(string text)
        {
            this.text = text;
        }

        public override string toString() => 
            "keyboard.TLKeyboardButton#a2fa4880";
    }
}

