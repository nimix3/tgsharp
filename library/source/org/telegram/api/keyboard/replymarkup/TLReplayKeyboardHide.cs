namespace org.telegram.api.keyboard.replymarkup
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLReplayKeyboardHide : TLAbsReplyMarkup
    {
        public const int CLASS_ID = -1606526075;
        private const int FLAG_SELECTIVE = 4;
        private const int FLAG_UNUSED0 = 1;
        private const int FLAG_UNUSED1 = 2;
        private int flags;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x10)]
        public TLReplayKeyboardHide()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLReplayKeyboardHide(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb7, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
        }

        public override int getClassId() => 
            -1606526075;

        public virtual int getFlags() => 
            this.flags;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb2, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
        }

        public override string toString() => 
            "keyboard#ReplyKeyboardHide#a03e5b85";
    }
}

