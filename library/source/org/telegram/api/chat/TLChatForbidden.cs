namespace org.telegram.api.chat
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLChatForbidden : TLAbsChat
    {
        public const int CLASS_ID = 0x7328bdb;
        private string title;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb1, 0x68 })]
        public TLChatForbidden()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLChatForbidden(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x12, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            base.id = StreamingUtils.readInt(stream);
            this.title = StreamingUtils.readTLString(stream);
        }

        public override int getClassId() => 
            0x7328bdb;

        public virtual string getTitle() => 
            this.title;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 12, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(base.id, stream);
            StreamingUtils.writeTLString(this.title, stream);
        }

        public virtual void setTitle(string title)
        {
            this.title = title;
        }

        public override string toString() => 
            "chatForbidden#7328bdb";
    }
}

