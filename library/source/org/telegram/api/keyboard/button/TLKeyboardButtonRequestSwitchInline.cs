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
    public class TLKeyboardButtonRequestSwitchInline : TLAbsKeyboardButton
    {
        public const int CLASS_ID = 0x568a748;
        private const int FLAG_SAME_PEER = 1;
        private int flags;
        private string query;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa7, 0x68 })]
        public TLKeyboardButtonRequestSwitchInline()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLKeyboardButtonRequestSwitchInline(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            base.text = StreamingUtils.readTLString(stream);
            this.query = StreamingUtils.readTLString(stream);
        }

        public override int getClassId() => 
            0x568a748;

        public virtual string getQuery() => 
            this.query;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb9, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeTLString(base.text, stream);
            StreamingUtils.writeTLString(this.query, stream);
        }

        public virtual bool toSamePeer() => 
            ((this.flags & 1) != 0);

        public override string toString() => 
            "keyboardButtonSwitchInline#568a748";
    }
}

