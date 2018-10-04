namespace org.telegram.api.chat.participant.chatparticipant
{
    using IKVM.Attributes;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public abstract class TLAbsChatParticipant : TLObject
    {
        protected internal int userId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x23)]
        public TLAbsChatParticipant()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAbsChatParticipant(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public virtual int getUserId() => 
            this.userId;

        public virtual void setUserId(int value)
        {
            this.userId = value;
        }
    }
}

