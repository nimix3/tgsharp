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
    public class TLReplayInlineKeyboardMarkup : TLAbsReplyMarkup
    {
        public const int CLASS_ID = 0x48a30254;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/keyboard/TLKeyboardButtonRow;>;")]
        private TLVector rows;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa6, 0xe8, 0x3d, 0xcb })]
        public TLReplayInlineKeyboardMarkup()
        {
            this.rows = new TLVector();
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLReplayInlineKeyboardMarkup(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb9, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.rows = StreamingUtils.readTLVector(stream, context);
        }

        public override int getClassId() => 
            0x48a30254;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/keyboard/TLKeyboardButtonRow;>;")]
        public virtual TLVector getRows() => 
            this.rows;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 180, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLVector(this.rows, stream);
        }

        public override string toString() => 
            "replyInlineMarkup#48a30254";
    }
}

