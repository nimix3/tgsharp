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
    public class TLMessageActionChatJoinedByLink : TLAbsMessageAction
    {
        public const int CLASS_ID = -123931160;
        private int inviterId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa7, 0x68 })]
        public TLMessageActionChatJoinedByLink()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLMessageActionChatJoinedByLink(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 7, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.inviterId = StreamingUtils.readInt(stream);
        }

        public override int getClassId() => 
            -123931160;

        public virtual int getInviterId() => 
            this.inviterId;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 2, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.inviterId, stream);
        }

        public virtual void setInviterId(int inviterId)
        {
            this.inviterId = inviterId;
        }

        public override string toString() => 
            "messageaction.messageActionChatJoinedByLink#f89cf5e8";
    }
}

