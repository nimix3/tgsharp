namespace org.telegram.api.chat.invite
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLChatInviteExported : TLAbsChatInvite
    {
        public const int CLASS_ID = -64092740;
        private string link;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb1, 0x68 })]
        public TLChatInviteExported()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLChatInviteExported(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x13, 0x68, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            base.deserializeBody(stream, context);
            this.link = StreamingUtils.readTLString(stream);
        }

        public override int getClassId() => 
            -64092740;

        public virtual string getLink() => 
            this.link;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 13, 0x67, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            base.serializeBody(stream);
            StreamingUtils.writeTLString(this.link, stream);
        }

        public virtual void setLink(string link)
        {
            this.link = link;
        }

        public override string toString() => 
            "chat.chatInviteExported#fc2e05bc";
    }
}

