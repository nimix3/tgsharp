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
    public class TLReplayKeyboardMarkup : TLAbsReplyMarkup
    {
        public const int CLASS_ID = 0x3502758c;
        private const int FLAG_RESIZE = 1;
        private const int FLAG_SELECTIVE = 4;
        private const int FLAG_SINGLEUSE = 2;
        protected internal int flags;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/keyboard/TLKeyboardButtonRow;>;")]
        private TLVector rows;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 160, 0xe8, 0x47 })]
        public TLReplayKeyboardMarkup()
        {
            this.rows = new TLVector();
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLReplayKeyboardMarkup(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xbf, 0x6c, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.rows = StreamingUtils.readTLVector(stream, context);
        }

        public override int getClassId() => 
            0x3502758c;

        public virtual int getFlags() => 
            this.flags;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/keyboard/TLKeyboardButtonRow;>;")]
        public virtual TLVector getRows() => 
            this.rows;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb9, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeTLVector(this.rows, stream);
        }

        public override string toString() => 
            "keyboard.ReplyKeyboardMarkup#3502758c";
    }
}

