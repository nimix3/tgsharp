namespace org.telegram.api.message.action
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLMessageActionChatEditTitle : TLAbsMessageAction
    {
        public const int CLASS_ID = -1247687078;
        private string title;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa7, 0x68 })]
        public TLMessageActionChatEditTitle()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLMessageActionChatEditTitle(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 7, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.title = StreamingUtils.readTLString(stream);
        }

        public override int getClassId() => 
            -1247687078;

        public virtual string getTitle() => 
            this.title;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 2, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLString(this.title, stream);
        }

        public virtual void setTitle(string title)
        {
            this.title = title;
        }

        public override string toString() => 
            "messageActionChatEditTitle#b5a1ce5a";
    }
}

