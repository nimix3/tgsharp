namespace org.telegram.api.messages.dhconfig
{
    using IKVM.Attributes;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public abstract class TLAbsDhConfig : TLObject
    {
        public int g;
        public TLBytes p;
        protected internal TLBytes random;
        public int version;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xad, 0x68 })]
        protected internal TLAbsDhConfig()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAbsDhConfig(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public virtual int getG() => 
            this.g;

        public virtual TLBytes getP() => 
            this.p;

        public virtual TLBytes getRandom() => 
            this.random;

        public virtual int getVersion() => 
            this.version;

        public virtual void setG(int g)
        {
            this.g = g;
        }

        public virtual void setP(TLBytes p)
        {
            this.p = p;
        }

        public virtual void setRandom(TLBytes value)
        {
            this.random = value;
        }

        public virtual void setVersion(int version)
        {
            this.version = version;
        }
    }
}

