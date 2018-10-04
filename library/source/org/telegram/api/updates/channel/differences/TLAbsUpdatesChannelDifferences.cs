namespace org.telegram.api.updates.channel.differences
{
    using IKVM.Attributes;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public abstract class TLAbsUpdatesChannelDifferences : TLObject
    {
        protected internal int flags;
        protected internal int pts;
        protected internal int timeout;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9f, 0x68 })]
        public TLAbsUpdatesChannelDifferences()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAbsUpdatesChannelDifferences(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public virtual int getFlags() => 
            this.flags;

        public virtual int getPts() => 
            this.pts;

        public virtual int getTimeout() => 
            this.timeout;

        public virtual void setFlags(int flags)
        {
            this.flags = flags;
        }

        public virtual void setPts(int pts)
        {
            this.pts = pts;
        }

        public virtual void setTimeout(int timeout)
        {
            this.timeout = timeout;
        }
    }
}

