namespace org.telegram.mtproto.tl
{
    using IKVM.Attributes;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public abstract class MTBadMessage : TLObject
    {
        protected internal long badMsgId;
        protected internal int badMsqSeqno;
        protected internal int errorCode;
        protected internal long newServerSalt;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(5)]
        public MTBadMessage()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected MTBadMessage(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public virtual long getBadMsgId() => 
            this.badMsgId;

        public virtual int getBadMsqSeqno() => 
            this.badMsqSeqno;

        public virtual int getErrorCode() => 
            this.errorCode;

        public virtual long getNewServerSalt() => 
            this.newServerSalt;

        public virtual void setBadMsgId(long badMsgId)
        {
            this.badMsgId = badMsgId;
        }

        public virtual void setBadMsqSeqno(int badMsqSeqno)
        {
            this.badMsqSeqno = badMsqSeqno;
        }

        public virtual void setErrorCode(int errorCode)
        {
            this.errorCode = errorCode;
        }

        public virtual void setNewServerSalt(long newServerSalt)
        {
            this.newServerSalt = newServerSalt;
        }
    }
}

